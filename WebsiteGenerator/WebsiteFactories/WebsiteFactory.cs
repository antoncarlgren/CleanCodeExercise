using System.Configuration;
using WebsiteGenerator.DataReader;
using WebsiteGenerator.Website;

namespace WebsiteGenerator.WebsiteFactories
{
    class WebsiteFactory : IWebsiteFactory
    {
        private readonly IDataReader _dataReader;
        private IWebsite _website;
        private string _messagesSource;
        private string _classNameSource;
        private string _coursesSource;
        private string _colorSource;

        public WebsiteFactory(IDataReader dataReader)
        {
            _messagesSource = ConfigurationManager.AppSettings["messagesSource"]!;
            _classNameSource = ConfigurationManager.AppSettings["classNameSource"]!;
            _coursesSource = ConfigurationManager.AppSettings["coursesSource"]!;
            _colorSource = ConfigurationManager.AppSettings["colorSource"]!;
            _dataReader = dataReader;
        }



        public async Task<StyledWebsite> CreateStyledWebsite()
        {
            _website = new StyledWebsite();
            await SetClassName();
            await SetColorStyling();
            await SetMessages();
            await SetCourses();
            return (_website as StyledWebsite)!;
        }
        public async Task<Website.Website> CreateWebsite()
        {
            _website = new Website.Website();
            await SetClassName();
            await SetMessages();
            await SetCourses();
            return (_website as Website.Website)!;
        }

        private async Task SetClassName()
        {
            _website.ClassName = await _dataReader.GetString(_classNameSource);
        }

        private async Task SetColorStyling()
        {
            (_website as StyledWebsite)!.Color = await _dataReader.GetString(_colorSource);
        }

        private async Task SetMessages()
        {
            _website.Messages = await _dataReader.GetStringArray(_messagesSource);
        }

        private async Task SetCourses()
        {
            _website.Courses = await _dataReader.GetStringArray(_coursesSource);
        }
    }
}
