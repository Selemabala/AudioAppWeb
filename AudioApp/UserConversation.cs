namespace AudioApp;
using AudioApp.UserData;
public class UserConversation
{
    public int Id { get; set; } // Unique identifier for the inbox
    public User Sender { get; set; } // Author's username for display purposes
    public User User2Name { get; set; } // Second Author's username for display purposes
    public List<UserMessage> UserMessages { get; set; } // Messages in the inbox
    public DateTime LastUpdated { get; set; } // Timestamp of the last message
}
