using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json.Serialization;
using Business.Builders;
using Client.BaseClient;
using Domain.Repositories;

namespace BoilerPlate_1
{
    public class Startup
    {
        public Startup(IHostingEnvironment env)
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(env.ContentRootPath)
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
                .AddJsonFile($"appsettings.{env.EnvironmentName}.json", optional: true)
                .AddEnvironmentVariables();
            Configuration = builder.Build();
        }

        public IConfigurationRoot Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddScoped<IBaseBuilder, BaseBuilder>();
            services.AddScoped<IBaseServiceClient, BaseClientService>();
            services.AddScoped<ILocationRepository, LocationRepository>();

            // Add framework services.
            services.AddMvc()
                .AddJsonOptions(
                config =>
                        config.SerializerSettings.ContractResolver = new CamelCasePropertyNamesContractResolver()

                )
                .AddJsonOptions(
                    config =>
                        config.SerializerSettings.Converters.Add(new Newtonsoft.Json.Converters.StringEnumConverter())
                );
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
        {
            loggerFactory.AddConsole(Configuration.GetSection("Logging"));
            loggerFactory.AddDebug();
            app.UseDeveloperExceptionPage();
            loggerFactory.AddDebug(LogLevel.Information);

            app.UseStaticFiles();

            app.UseMvc();
        }
    }
}
