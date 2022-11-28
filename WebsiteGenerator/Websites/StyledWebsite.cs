namespace WebsiteGenerator.Website;

public class StyledWebsite : IWebsite
{
    public IEnumerable<string>? Messages { get; set; }
    public IEnumerable<string>? Courses { get; set; }
    public string? ClassName { get; set; }
    public string? Color { get; set; }
}