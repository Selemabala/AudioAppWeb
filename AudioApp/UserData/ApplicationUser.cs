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
    public string CustomName { get; set; }
    public UserRole UserRole { get; set; } = UserRole.Customer;
    public List<MainStory> PurchesedStories { get; set; }

    public override string ToString()
    {
        return $"{UserName} ({UserRole}) born {DateOfBirth}";
    }

    public bool IsOver18()
    {
        DateTime now = DateTime.Now;
        const int ADULT_AGE = 18;
        if (now >= DateOfBirth.AddYears(ADULT_AGE).ToDateTime(TimeOnly.MinValue))
        {
            return true;
        }
        return false;
        
        //bool isOver18 = DateOfBirth.ToDateTime(TimeOnly.MinValue) < DateTime.Now.AddYears(-18);
        //return isOver18;
    }
    
    // Calculate age for the age authorization (not stored in DB)
    public int GetAge()
    {
        //var agex = DateTime.Now - DateOfBirth.ToDateTime(TimeOnly.MinValue);
        
        DateOnly today = DateOnly.FromDateTime(DateTime.Today);

        const int oneYear = 1;

        int age = today.Year - DateOfBirth.Year;

        bool birthdayNotReached = today.Month < DateOfBirth.Month || (today.Month == DateOfBirth.Month && today.Day < DateOfBirth.Day);

        if (birthdayNotReached)
        {
            age = age - oneYear;
        }

        return age;
    }
}