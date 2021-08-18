using GraphQL.Server;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Server.Kestrel.Core;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace DotNetGraphQL.API
{
    public class Startup
    {
        public static void ConfigureServices(IServiceCollection services)
        {
            services.Configure<KestrelServerOptions>(options => options.AllowSynchronousIO = true);

            services.AddSingleton<ImagesSchema>();

            services.AddGraphQL(options => options.EnableMetrics = false)
                    .AddErrorInfoProvider(options => options.ExposeExceptionStackTrace = true)
                    .AddNewtonsoftJson();

            services.AddCors(options => options.AddPolicy("AllowAll", p => p.AllowAnyOrigin()
                                                 .AllowAnyMethod()
                                                 .AllowAnyHeader()));
            services.AddLogging(builder => builder.AddConsole());
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
        }

        public static void Configure(IApplicationBuilder app, IWebHostEnvironment env, ILoggerFactory loggerFactory)
        {
            if (env.IsDevelopment())
                app.UseDeveloperExceptionPage();

            app.UseCors("AllowAll");

            app.UseDefaultFiles();
            app.UseStaticFiles();

            app.UseGraphQL<ImagesSchema>("/");
        }
    }
}
