using WebsiteGenerator.Website;

namespace WebsiteGenerator.WebsiteFactories
{
    internal interface IWebsiteFactory
    {
        Task<StyledWebsite> CreateStyledWebsite();
        Task<Website.Website> CreateWebsite();
    }
}