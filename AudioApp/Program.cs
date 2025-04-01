using AudioApp.UserData;

namespace AudioApp;

class Program
{
    static void Main(string[] args)
    {
        UI.DisplayAboutThisApp();
        int age = UI.GetUserAge();
        UI.DisplayPermission(age);
        UI.DisplayStoriesAvailable();
        List<MainStory> allStories = TestData.GenerateTestStories();
        UI.DisplayMainStoryNames(allStories);
        List<User> users = TestData.GenerateTestUsers();
        UI.DisplayAdminNames(users);
        MainStory story = TestData.GenerateTestStories()[2];
        UI.DisplayEpisodesNames(story);
        User user1 = TestData.GenerateTestUsers()[1];
        List<MainStory> allUserStories = Logic.FindAllStories(user1, allStories);
        string name = user1.FirstName;
        UI.DisplayAdminStories(name);
        UI.DisplayMainStoryNames(allUserStories);
        MainStory geza = TestData.GenerateTestStories()[2];
        UI.DisplayEpisodesTotalCost(geza);
    }
}