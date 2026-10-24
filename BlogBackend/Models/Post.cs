using Microsoft.AspNetCore.Identity;
public class Post
{
    public int Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public DateTime PostDate { get; set; }
    public string Text { get; set; } = string.Empty;
    public DateTime CreatedAt { get; set; }
    public DateTime LastEditedAt { get; set; }

    public int BlogId { get; set; }
    public Blog? Blog { get; set; }
    public List<Comment> Comments { get; set; } = new(); 

}