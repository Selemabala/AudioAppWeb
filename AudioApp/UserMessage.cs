namespace AudioApp;
using AudioApp.UserData;
public class UserMessage
{
    public int Id { get; set; } // Unique identifier for the message
    public ApplicationUser AuthorName { get; set; } // Author's username for display purposes
    public string Content { get; set; } // The text or media content
    public DateTime SentAt { get; set; } // Timestamp of the message
    public bool IsRead { get; set; } // Whether the message has been read
    //public UserMessage ReplyToMessage { get; set; } // Optional ID for replies
}