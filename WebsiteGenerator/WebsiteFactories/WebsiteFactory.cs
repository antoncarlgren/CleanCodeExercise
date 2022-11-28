using WebsiteGenerator.DataReader;
using WebsiteGenerator.Website;

namespace WebsiteGenerator.WebsiteFactories
{
	class WebsiteFactory : IWebsiteFactory
	{
		private readonly IDataReader _dataReader;
		private readonly IWebsite _website;

		public WebsiteFactory(IDataReader dataReader)
		{
			_dataReader = dataReader;
		}

		public StyledWebsite CreateStyledWebsite()
		{

		}

		private void WithClassName(string className)
		{

		}

		private async Task WithColorStyling(string colorSource)
		{

		}

		private async Task WithMessages(string messageSource)
		{

		}

		private async Task WithCourses(string courseSource)
		{

		}
	}
}
