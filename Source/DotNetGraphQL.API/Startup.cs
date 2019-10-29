using GraphQL;
using GraphQL.Http;
using GraphQL.Types;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace DotNetGraphQL.API
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddSingleton<IDocumentExecuter, DocumentExecuter>();
            services.AddSingleton<IDocumentWriter, DocumentWriter>();

            services.AddSingleton<ISchema, ImagesSchema>();

            services.AddCors(options =>
                                options.AddPolicy("AllowAll", p => p.AllowAnyOrigin()
                                .AllowAnyMethod()
                                .AllowAnyHeader()));
            services.AddLogging(builder => builder.AddConsole());
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
        {
            if (env.IsDevelopment())
                app.UseDeveloperExceptionPage();

            app.UseCors("AllowAll");

            app.UseMiddleware<GraphQLMiddleware>(new GraphQLSettings(true, ctx => new GraphQLUserContext(ctx.User)));

            app.UseDefaultFiles();
            app.UseStaticFiles();
        }
    }
}
