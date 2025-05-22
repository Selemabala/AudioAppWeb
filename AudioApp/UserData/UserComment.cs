namespace AudioApp.UserData;

public class UserComment
{
    public int Id { get; set; } // Unique identifier for the comment
    public ApplicationUser Author{ get; set; } // Author's username for display purposes
    public string Content { get; set; } // Comment text
    public DateTime CreatedAt { get; set; } // Timestamp for the comment
}