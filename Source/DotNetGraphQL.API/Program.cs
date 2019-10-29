using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;

namespace DotNetGraphQL.API
{
    public static class Program
    {
        public static Task Main(string[] args) =>
            WebHost.CreateDefaultBuilder<Startup>(args)
                .UseWebRoot(Path.Combine(Directory.GetCurrentDirectory(), "Public"))
                .Build()
                .RunAsync();
    }
}
