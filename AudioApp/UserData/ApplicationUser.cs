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
    public UserRole UserRole { get; set; } = UserRole.Customer;
    public List<MainStory> PurchesedStories { get; set; }

    public override string ToString()
    {
        return $"{UserName} ({UserRole}) born {DateOfBirth}";
    }
    
    // ✅ Calculate age whenever needed (not stored in DB)
    public int GetAge()
    {
        DateTime today = DateTime.Today;
        int age = today.Year - DateOfBirth.Year;

        if (DateOfBirth.Month > today.Month ||
            (DateOfBirth.Month == today.Month && DateOfBirth.Day > today.Day))
        {
            age--;
        }

        return age;
    }
}