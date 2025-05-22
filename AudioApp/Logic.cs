using System.ComponentModel.Design;
using AudioApp.UserData;

namespace AudioApp;

public class Logic
{
    public static List<MainStory> FindAllStories(ApplicationUser applicationUser, List<MainStory> allStories)
    {
        List<MainStory> userMainStory = new List<MainStory>();
        foreach (MainStory mainStory in allStories)  
        {
            foreach (Episode episode in mainStory.Episodes)  
            {
                if (episode.CreatedBy.Id == applicationUser.Id)  
                {
                    userMainStory.Add(mainStory);
                    break;
                }
            }
        }
        return userMainStory;  
    }
    
    public static bool ValidateLegalAge(int userAge)
    {
        
        if (userAge >= Constants.LEGAL_AGE)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public static bool ValidateIfInteger(string intFromUser)
    {
        if (int.TryParse(intFromUser, out int _))
        {
            return true;
        }
        return false;
    }
    
}