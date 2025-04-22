namespace FreeUsePuller.Interfaces.Services
{
    public interface IWebScraperService
    {
        Task<string> GetNewestVideosAsync();
    }
}