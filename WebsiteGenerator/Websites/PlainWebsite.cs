namespace WebsiteGenerator.Website;

public class PlainWebsite : IWebsite
{
    public IEnumerable<string>? Messages { get; set; }
    public IEnumerable<string>? Courses { get; set; }
    public string? ClassName { get; set; }
}