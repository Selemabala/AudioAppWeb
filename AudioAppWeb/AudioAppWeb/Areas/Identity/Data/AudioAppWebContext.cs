using AudioApp.UserData;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using AudioApp;

namespace AudioAppWeb.Data;

public class AudioAppWebContext : IdentityDbContext<ApplicationUser>
{
    public DbSet<MainStory> MainStories { get; set; }
    public DbSet<Episode> Episodes { get; set; }
    public DbSet<Address> Addresses { get; set; }
    public DbSet<UserConversation> UserConversations { get; set; }
    public DbSet<UserMessage> UserMessages { get; set; }
    public DbSet<UserPost> UserPosts { get; set; }
    public DbSet<Chatbox> Chatboxes { get; set; }

    public AudioAppWebContext(DbContextOptions<AudioAppWebContext> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        // Customize the ASP.NET Identity model and override the defaults if needed.
        // For example, you can rename the ASP.NET Identity table names and more.
        // Add your customizations after calling base.OnModelCreating(builder);
    }
}
