using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Configuration;

using FreeUsePuller.Interfaces.Services;
using FreeUsePuller.Services;
using FreeUsePuller.Options;

namespace FreeUsePuller.Extensions
{
    public static class ApplicationHostingExtensions
    {
        public static IHost BuildApplication(string[] args)
        {
            //Create builder
            HostApplicationBuilder builder = Host.CreateApplicationBuilder(args);
            //Add Services
            AddServices(builder.Services);
            //Add Options
            ConfigureServices(builder.Services, builder.Configuration);
            //Build and return builder
            return builder.Build();
        }
        private static void AddServices(IServiceCollection services)
        {
            services.AddSingleton<IWebScraperService, WebScraperService>();
        }
        private static void ConfigureServices(IServiceCollection services, ConfigurationManager configurationManager)
        {
            services.Configure<FreeUsePornOptions>(configurationManager.GetSection(FreeUsePornOptions.ConfigBinding));
        }
    }
}