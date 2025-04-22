using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.DependencyInjection;

using FreeUsePuller.Extensions;
using FreeUsePuller.Interfaces.Services;
using FreeUsePuller.Models;

namespace FreeUsePuller
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            //Get and start host
            IHost host = ApplicationHostingExtensions.BuildApplication(args);
            await host.StartAsync();

            //Create instance of Web Scraper Service
            IWebScraperService webScraperService = host.Services.GetRequiredService<IWebScraperService>();

            //Get categories and prompt user
            IEnumerable<CategoryListing> categories = await webScraperService.GetCategoryListingsAsync();
            Console.WriteLine("Select A Category");
            foreach (CategoryListing category in categories)
            {
                Console.WriteLine(category.Name);
            }
            string selectedCategory = Console.ReadLine();
            
            await host.StopAsync();
        }
    }
}