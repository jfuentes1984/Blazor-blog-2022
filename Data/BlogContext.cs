using Microsoft.EntityFrameworkCore;

namespace Blazor_blog_2022.Model;

public class BlogContext : DbContext
{
    public BlogContext(DbContextOptions<BlogContext> options) : base(options) { }
    public DbSet<BlogEntry>? Blog { get; set; }
}
