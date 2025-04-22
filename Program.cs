using Microsoft.Extensions.Hosting;

using FreeUsePuller.Extensions;

namespace FreeUsePuller
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            //Get and start host
            IHost host = ApplicationHostingExtensions.BuildApplication(args);
            await host.StartAsync();
        }
    }
}