using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

using FreeUsePuller.Interfaces.Services;

namespace FreeUsePuller.Services
{
    public class WebScraperService : IWebScraperService, IHostedService, IAsyncDisposable
    {
        private readonly ILogger<WebScraperService> _logger;
        public WebScraperService(ILogger<WebScraperService> logger)
        {
            _logger = logger;
        }
        #region  IWebScraperService Implementation
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