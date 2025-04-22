using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

using FreeUsePuller.Services;

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

            //Build and run builder
            IHost host = builder.Build();
            await host.StartAsync();
        }
    }
}