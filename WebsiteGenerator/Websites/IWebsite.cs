namespace WebsiteGenerator.Website;

public interface IWebsite
{
    IEnumerable<string>? Messages { get; set; }
    IEnumerable<string>? Courses { get; set; }
    string? ClassName { get; set; }
}