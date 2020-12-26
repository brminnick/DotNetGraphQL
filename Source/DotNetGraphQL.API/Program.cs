using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;

namespace DotNetGraphQL.API
{
    public static class Program
    {
        public static Task Main(string[] args)
        {
            var directory = Directory.GetCurrentDirectory();

            return new WebHostBuilder()
                .UseKestrel()
                .UseContentRoot(directory)
                .UseWebRoot(Path.Combine(directory, "Public"))
                .UseIISIntegration()
                .UseStartup<Startup>()
                .Build()
                .RunAsync();
        }
    }
}
