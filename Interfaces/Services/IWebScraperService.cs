namespace FreeUsePuller.Interfaces.Services
{
    public interface IWebScraperService
    {
        Task<IEnumerable<FreeUsePuller.Models.CategoryListing>> GetCategoryListingsAsync();
        Task<string> GetNewestVideosAsync();
    }
}