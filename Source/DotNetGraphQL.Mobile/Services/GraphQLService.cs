using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DotNetGraphQL.Common;
using GraphQL.Client.Http;
using GraphQL.Common.Exceptions;
using GraphQL.Common.Request;
using GraphQL.Common.Response;
using Polly;

namespace DotNetGraphQL.Mobile
{
    public static class GraphQLService
    {
        static readonly Lazy<GraphQLHttpClient> _clientHolder = new Lazy<GraphQLHttpClient>(CreateGraphQLClient);

        static GraphQLHttpClient Client => _clientHolder.Value;

        public static async IAsyncEnumerable<DogImagesModel> GetDogImages()
        {
            var graphQLRequest = new GraphQLRequest
            {
                Query = "query { dogs  { avatarUrl, birthDate, breed, coatColor, imagesList, title, websiteUrl } }"
            };

            var gitHubUserResponse = await AttemptAndRetry(() => Client.SendQueryAsync(graphQLRequest)).ConfigureAwait(false);

            foreach (var dogImageModel in gitHubUserResponse.GetDataFieldAs<IEnumerable<DogImagesModel>>("dogs"))
                yield return dogImageModel;
        }

        static GraphQLHttpClient CreateGraphQLClient() => new GraphQLHttpClient(new GraphQLHttpClientOptions
        {
            EndPoint = new Uri(BackendConstants.GraphQLApiUrl),
#if !DEBUG
            HttpMessageHandler = new ModernHttpClient.NativeMessageHandler()
#endif
        });

        static async Task<GraphQLResponse> AttemptAndRetry(Func<Task<GraphQLResponse>> action, int numRetries = 2)
        {
            var response = await Policy.Handle<Exception>().WaitAndRetryAsync(numRetries, pollyRetryAttempt).ExecuteAsync(action).ConfigureAwait(false);

            if (response.Errors != null && response.Errors.Count() > 1)
                throw new AggregateException(response.Errors.Select(x => new GraphQLException(x)));

            if (response.Errors != null && response.Errors.Count() is 1)
                throw new GraphQLException(response.Errors.First());

            return response;

            static TimeSpan pollyRetryAttempt(int attemptNumber) => TimeSpan.FromSeconds(Math.Pow(2, attemptNumber));
        }
    }
}
