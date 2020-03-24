using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DotNetGraphQL.Common;
using GraphQL;
using GraphQL.Client.Http;
using GraphQL.Client.Serializer.Newtonsoft;
using Polly;

namespace DotNetGraphQL.Mobile
{
    public static class GraphQLService
    {
        static readonly Lazy<GraphQLHttpClient> _clientHolder = new Lazy<GraphQLHttpClient>(CreateGraphQLClient);

        static GraphQLHttpClient Client => _clientHolder.Value;

        public static async Task<List<DogImagesModel>> GetDogImages()
        {
            var graphQLRequest = new GraphQLRequest
            {
                Query = "query { dogs  { avatarUrl, birthDate, breed, coatColor, imagesList, title, websiteUrl } }"
            };

            var dogImages = await AttemptAndRetry(() => Client.SendQueryAsync<DogImagesGraphQLResponse>(graphQLRequest)).ConfigureAwait(false);

            return dogImages.Dogs;
        }

        static GraphQLHttpClient CreateGraphQLClient() {

            var options = new GraphQLHttpClientOptions
            {
                EndPoint = new Uri(BackendConstants.GraphQLApiUrl),
#if !DEBUG
                HttpMessageHandler = new ModernHttpClient.NativeMessageHandler()
#endif
            };

            return new GraphQLHttpClient(options, new NewtonsoftJsonSerializer());
        }

        static async Task<T> AttemptAndRetry<T>(Func<Task<GraphQLResponse<T>>> action, int numRetries = 2)
        {
            var response = await Policy.Handle<Exception>().WaitAndRetryAsync(numRetries, pollyRetryAttempt).ExecuteAsync(action).ConfigureAwait(false);

            if (response.Errors != null && response.Errors.Count() > 1)
                throw new AggregateException(response.Errors.Select(x => new Exception(x.ToString())));
            else if (response.Errors != null && response.Errors.Any())
                throw new Exception(response.Errors.First().ToString());

            return response.Data;

            static TimeSpan pollyRetryAttempt(int attemptNumber) => TimeSpan.FromSeconds(Math.Pow(2, attemptNumber));
        }
    }
}
