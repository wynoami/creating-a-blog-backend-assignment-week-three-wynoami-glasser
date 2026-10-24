using Microsoft.AspNetCore.Identity;

public class Comment
{
    public int Id { get; set; }
    public DateTime CreatedAt { get; set; }
    public string Text { get; set; } = string.Empty;
    public bool IsVisible { get; set; } = true;

    public string UserId { get; set; } = string.Empty;
    public IdentityUser? User { get; set; }
    public int PostId { get; set; }
    public Post? Post { get; set; }
}