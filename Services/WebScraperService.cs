using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

using FreeUsePuller.Interfaces.Services;
using FreeUsePuller.Options;
using FreeUsePuller.Models;

namespace FreeUsePuller.Services
{
    public class WebScraperService : IWebScraperService, IHostedService, IAsyncDisposable
    {
        private readonly ILogger<WebScraperService> _logger;
        private readonly FreeUsePornOptions _freeUsePornOptions;
        public WebScraperService(ILogger<WebScraperService> logger
                               , IOptions<FreeUsePornOptions> freeUsePornOptions)
        {
            _logger = logger;
            _freeUsePornOptions = freeUsePornOptions.Value;
        }
        #region  IWebScraperService Implementation
        public async Task<IEnumerable<CategoryListing>> GetCategoryListingsAsync()
        {
            throw new NotImplementedException();
        }
        public async Task<string> GetNewestVideosAsync()
        {
            throw new NotImplementedException();
        }
        #endregion

        #region IHostedService Implementation
        public async Task StartAsync(CancellationToken cancellationToken)
        {
            _logger.LogInformation("Starting Web Scraper Service");
        }
        public async Task StopAsync(CancellationToken cancellationToken)
        {
            _logger.LogInformation("Stopping Web Scraper Service");
        }
        #endregion

        #region IAsyncDisposable Implementation
        public async ValueTask DisposeAsync()
        {

        }
        #endregion
    }
}