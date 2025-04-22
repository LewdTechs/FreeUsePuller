using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

using FreeUsePuller.Services;
using FreeUsePuller.Options;
using FreeUsePuller.Interfaces.Services;

namespace FreeUsePuller
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            //Create builder
            HostApplicationBuilder builder = Host.CreateApplicationBuilder(args);
            //Add Services
            builder.Services.AddSingleton<IWebScraperService, WebScraperService>();
            //Add Options
            builder.Services.Configure<FreeUsePornOptions>(builder.Configuration.GetSection(FreeUsePornOptions.ConfigBinding));

            //Build and run builder
            IHost host = builder.Build();
            await host.StartAsync();
        }
    }
}