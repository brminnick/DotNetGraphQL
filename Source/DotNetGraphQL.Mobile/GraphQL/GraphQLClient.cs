using System;
using System.Collections.Generic;
using Microsoft.Extensions.DependencyInjection;

namespace DotNetGraphQL.Mobile
{
    public static class GraphQLClient
    {
        private static readonly Lazy<IDogsClient> _clientHolder = new Lazy<IDogsClient>(Create);

        public static IDogsClient Instance => _clientHolder.Value;

        public static async IAsyncEnumerable<IDogImage> GetAllDogsAsync()
        {
            var result = await Instance.GetAllDogsAsync();
            result.EnsureNoErrors();

            foreach (var image in result.Data!.Dogs)
            {
                yield return image;
            }
        }

        public static async IAsyncEnumerable<IDogImage> GetDogsByCoatColorAsync(string coatColor)
        {
            var result = await Instance.GetDogsByCoatColorAsync();
            result.EnsureNoErrors();

            foreach (var image in result.Data!.Dogs)
            {
                yield return image;
            }
        }

        private static IDogsClient Create()
        {
            var services = new ServiceCollection();
            services.AddHttpClient("DogsClient", c => c.BaseAddress = new Uri("http://localhost:5000"));
            services.AddDogsClient();
            return services.BuildServiceProvider().GetRequiredService<IDogsClient>();
        }
    }
}