namespace AudioApp;
using AudioApp.UserData;
public class UserPost
{
    public int Id { get; set; } // Unique identifier for the post
    public ApplicationUser Author { get; set; } // Author's username for display purposes
    public string Content { get; set; } // Post content
    public DateTime CreatedAt { get; set; } // Timestamp for the post creation
    public List<UserComment> UserComments { get; set; } // Comments on the post
    public int TotalLikes { get; set; } // Like count
    public int TotalDisLikes { get; set; } // Dislike count
}