using Microsoft.AspNetCore.Identity;

public class Blog
{
    public int Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public string Subtitle { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public DateTime CreatedAt { get; set; }
    public DateTime LastEditedAt { get; set; }

    public string AuthorId { get; set; } = string.Empty;  // FK -> AspNetUsers
    public IdentityUser? Author { get; set; }
    public List<Post> Posts { get; set; } = new();        // one-to-many

}