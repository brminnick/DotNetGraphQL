using System;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using DotNetGraphQL.Common;
using GraphQL;
using GraphQL.Common.Request;
using GraphQL.Http;
using GraphQL.Instrumentation;
using GraphQL.Types;
using GraphQL.Validation;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;

namespace DotNetGraphQL.API
{
    class GraphQLMiddleware
    {
        readonly static Lazy<JsonSerializer> _serializerHolder = new Lazy<JsonSerializer>(() => new JsonSerializer());

        readonly RequestDelegate _next;
        readonly GraphQLSettings _settings;
        readonly IDocumentExecuter _executer;
        readonly IDocumentWriter _writer;

        public GraphQLMiddleware(RequestDelegate next, GraphQLSettings settings, IDocumentExecuter executer, IDocumentWriter writer) =>
            (_next, _settings, _executer, _writer) = (next, settings, executer, writer);

        static JsonSerializer Serializer => _serializerHolder.Value;

        public Task Invoke(HttpContext context, ISchema schema)
        {
            if (IsGraphQLRequest(context))
                return ExecuteAsync(context, schema);

            return _next(context);
        }

        static T Deserialize<T>(Stream stream)
        {
            using var streamReader = new StreamReader(stream);
            using var jsonTextReader = new JsonTextReader(streamReader);

            return Serializer.Deserialize<T>(jsonTextReader);
        }

        bool IsGraphQLRequest(HttpContext context)
        {
            return context.Request.Path.StartsWithSegments(_settings.Path)
                && context.Request.Method.Equals("POST", StringComparison.OrdinalIgnoreCase);
        }

        async Task ExecuteAsync(HttpContext context, ISchema schema)
        {
            var request = Deserialize<GraphQLRequest>(context.Request.Body);

            var result = await _executer.ExecuteAsync(options =>
            {
                options.Schema = schema;
                options.Query = request.Query;
                options.OperationName = request.OperationName ?? string.Empty;
                options.Inputs = request.Variables?.ToInputs();
                options.UserContext = _settings.BuildUserContext.Invoke(context);
                options.ValidationRules = DocumentValidator.CoreRules.Concat(new[] { new InputValidationRule() });
                options.EnableMetrics = _settings.EnableMetrics;

                if (_settings.EnableMetrics)
                    options.FieldMiddleware.Use<InstrumentFieldsMiddleware>();
            });

            await WriteResponseAsync(context, result).ConfigureAwait(false);
        }

        Task WriteResponseAsync(HttpContext context, ExecutionResult result)
        {
            context.Response.ContentType = "application/json";
            context.Response.StatusCode = result.Errors?.Any() is true ? (int)HttpStatusCode.BadRequest : (int)HttpStatusCode.OK;

            return _writer.WriteAsync(context.Response.Body, result);
        }
    }
}
