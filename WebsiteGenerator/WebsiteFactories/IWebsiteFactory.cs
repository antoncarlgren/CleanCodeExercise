using WebsiteGenerator.Website;

namespace WebsiteGenerator.WebsiteFactories
{
	internal interface IWebsiteFactory
	{
		StyledWebsite CreateStyledWebsite();
	}
}