namespace AudioApp;
using AudioApp.UserData;


public class Chatbox
{
    public int Id { get; set; } // Unique identifier for the chatbox
    public string AuthorName { get; set; } // Author's username for display purposes
    public List<ApplicationUser> Participants { get; set; } // Users involved in the chat
    public List<UserMessage> UserMessagesMessages { get; set; } // All messages exchanged
    public DateTime CreatedAt { get; set; } // Timestamp for when the chat started
    public bool IsGroupChat { get; set; } // Whether it's a group or private chat
    public string GroupName { get; set; } // Name for group chats (optional)
}

