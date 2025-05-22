using Microsoft.AspNetCore.Identity;

namespace AudioApp.UserData;

public class ApplicationUser : IdentityUser
{
    public string CountryCode { get; set; }
    public string FirstName { get; set; }
    public string MiddleName { get; set; }
    public string LastName { get; set; }
    public Address TheAddress { get; set; }
    public DateOnly DateOfBirth { get; set; }
    public string BankAccountName { get; set; }
    public int BankAccountNumber { get; set; }
    public UserRole UserRole { get; set; }
    public List<MainStory> PurchesedStories { get; set; }

    public override string ToString()
    {
        return Id + " " + UserName;
    }
}