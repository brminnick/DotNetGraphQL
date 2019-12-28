using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using HotChocolate;
using HotChocolate.AspNetCore;

namespace DotNetGraphQL.API
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddGraphQL(
                SchemaBuilder.New()
                    .AddQueryType<Query>());

            services.AddCors(options => options
                .AddPolicy("AllowAll", p => p.AllowAnyOrigin()
                .AllowAnyMethod()
                .AllowAnyHeader()));
            services.AddLogging(builder => builder.AddConsole());
            services.AddHttpContextAccessor();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, ILoggerFactory loggerFactory)
        {
            if (env.IsDevelopment())
                app.UseDeveloperExceptionPage();

            app.UseCors("AllowAll");

            app.UseGraphQL();

            app.UseDefaultFiles();
            app.UseStaticFiles();
        }
    }
}
