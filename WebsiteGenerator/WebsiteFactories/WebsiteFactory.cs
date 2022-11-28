using WebsiteGenerator.DataReader;
using WebsiteGenerator.Website;

namespace WebsiteGenerator.WebsiteFactories
{
	class WebsiteFactory : IWebsiteFactory
	{
		private readonly IDataReader _dataReader;
		private IWebsite _website;

		public WebsiteFactory(IDataReader dataReader)
		{
			_dataReader = dataReader;
		}

		
		
		public async Task<StyledWebsite> CreateStyledWebsite()
		{
			
			_website = new StyledWebsite();
			await SetClassName();
			await SetColorStyling();
			await SetMessages();
			await SetCourses();
		}

		private async Task SetClassName(string classSource)
		{
			_website.ClassName = await _dataReader.GetString(classSource);
		}

		private async Task SetColorStyling(string colorSource)
		{
			(_website as StyledWebsite)!.Color = await _dataReader.GetString(colorSource);
		}

		private async Task SetMessages(string messageSource)
		{
			_website.Messages = await _dataReader.GetStringArray(messageSource);
		}

		private async Task SetCourses(string courseSource)
		{
			_website.Courses = await _dataReader.GetStringArray(courseSource);
		}
	}
}
