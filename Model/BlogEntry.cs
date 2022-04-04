namespace Blazor_blog_2022.Model;
public class BlogEntry
{
    public uint BlogEntryId { get; set; }
    public string Title { get; set; } = "Blog Entry Title";
    public string Content { get; set; } = "";
    public DateTime TimePosted { get; set; } = DateTime.Now;
}