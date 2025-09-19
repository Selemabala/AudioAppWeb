using System.Net.Sockets;
using AudioApp.UserData;
namespace AudioApp;

public static class TestData
{
    public static List<ApplicationUser> GenerateTestUsers()
    {
        List<ApplicationUser> users = new List<ApplicationUser>();
        ApplicationUser user1 = new ApplicationUser();
        user1.UserName = "Adam1";
        user1.FirstName = "Adam1";
        user1.MiddleName = "Mc";
        user1.LastName = "Donald";
        user1.Email = "adam1@test.com";
        user1.Id = "1";
        user1.UserRole = UserRole.Uploader;
        user1.CountryCode = "+45";
        user1.PhoneNumber = "123456";
        user1.BankAccountName = "Nordea";
        user1.BankAccountNumber = 12345678;
        user1.DateOfBirth = new DateOnly(2002, 1, 1);
        user1.TheAddress = GenerateTestAddress()[0];
        users.Add(user1);

        ApplicationUser user2 = new ApplicationUser();
        user2.UserName = "Adam2";
        user2.FirstName = "Adam2";
        user2.MiddleName = "Bin";
        user2.LastName = "Laden";
        user2.Email = "adam2@test.com";
        user2.UserRole = UserRole.Uploader;
    
        user2.CountryCode = "+45";
        user2.PhoneNumber = "223456";
        user2.BankAccountName = "Nordea";
        user2.BankAccountNumber = 22345678;
        user2.DateOfBirth = new DateOnly(2001, 2, 1);
        user2.TheAddress = GenerateTestAddress()[1];
        users.Add(user2);

        ApplicationUser user3 = new ApplicationUser();
        user3.UserName = "Adam3";
        user3.FirstName = "Adam3";
        user3.MiddleName = "Von";
        user3.LastName = "Smitch";
        user3.Email = "adam3@test.com";
        user3.Id = "3";
        user3.UserRole = UserRole.Customer;
        user3.CountryCode = "+45";
        user3.PhoneNumber = "323456";
        user3.BankAccountName = "Nordea";
        user3.BankAccountNumber = 32345678;
        user3.DateOfBirth = new DateOnly(2000, 3, 1);
        user3.TheAddress = GenerateTestAddress()[2];
        users.Add(user3);


        ApplicationUser user4 = new ApplicationUser();
        user4.UserName = "Adam4";
        user4.FirstName = "Adam4";
        user4.MiddleName = "Van";
        user4.LastName = "Deim";
        user4.Email = "adam4@test.com";
        user4.Id = "4";
        user4.UserRole = UserRole.Customer;
      
        user4.CountryCode = "+45";
        user4.PhoneNumber = "423456";
        user4.BankAccountName = "Nordea";
        user4.BankAccountNumber = 42345678;
        user4.DateOfBirth = new DateOnly(2000, 4, 1);
        user4.TheAddress = GenerateTestAddress()[3];
        users.Add(user4);

        return users;
    }

    public static List<Address> GenerateTestAddress()
    {
        List<Address> addresses = new List<Address>();
        Address address1 = new Address();
        address1.City = "Copenhagen";
        address1.Country = "Denmark";
        address1.HouseNumber = "1A";
        address1.StreetName = "Østerbro";
        addresses.Add(address1);

        Address address2 = new Address();
        address2.City = "Copenhagen";
        address2.Country = "Denmark";
        address2.HouseNumber = "2A";
        address2.StreetName = "Østerbro";
        addresses.Add(address2);

        Address address3 = new Address();
        address3.City = "Copenhagen";
        address3.Country = "Denmark";
        address3.HouseNumber = "3A";
        address3.StreetName = "Østerbro";
        addresses.Add(address3);

        Address address4 = new Address();
        address4.City = "Copenhagen";
        address4.Country = "Denmark";
        address4.HouseNumber = "1A";
        address4.StreetName = "Østerbro";
        addresses.Add(address4);
        return addresses;
    }


    public static List<Episode> GenerateTestStoryEpisodesMama()
    {
        List<Episode> mamaEpisodes = new List<Episode>();
        Episode StoryOneEpisode = new Episode();
        StoryOneEpisode.Id = 1;
        StoryOneEpisode.Title = "Mama1";
        StoryOneEpisode.Price = 10;
        StoryOneEpisode.AudioPath = "/Users/mabala/Desktop/7feb/Stories/mama/mama1.mp3";
        StoryOneEpisode.AgeLimit = false;
        StoryOneEpisode.CreatedBy = GenerateTestUsers()[2];
        StoryOneEpisode.AudioCoverImagePath = "/Users/mabala/Desktop/7feb/Stories/mama.png";
        StoryOneEpisode.DateUploaded = DateTime.Now;
        mamaEpisodes.Add(StoryOneEpisode);


        Episode StoryTwoEpisode = new Episode();
        StoryTwoEpisode.Id = 2;
        StoryTwoEpisode.Title = "Mama2";
        StoryTwoEpisode.Price = 10;
        StoryTwoEpisode.AudioPath = "/Users/mabala/Desktop/7feb/Stories/mama/mama2.mp3";
        StoryTwoEpisode.AgeLimit = false;
        StoryTwoEpisode.CreatedBy = GenerateTestUsers()[2];
        StoryTwoEpisode.AudioCoverImagePath = "/Users/mabala/Desktop/7feb/Stories/mama.png";
        StoryTwoEpisode.DateUploaded = DateTime.Now;
        mamaEpisodes.Add(StoryTwoEpisode);


        Episode StoryThreeEpisode = new Episode();
        StoryThreeEpisode.Id = 1;
        StoryThreeEpisode.Title = "Mama3";
        StoryThreeEpisode.Price = 10;
        StoryThreeEpisode.AudioPath = "/Users/mabala/Desktop/7feb/Stories/mama/mama3.mp3";
        StoryThreeEpisode.AgeLimit = true;
        StoryThreeEpisode.CreatedBy = GenerateTestUsers()[2];
        StoryThreeEpisode.AudioCoverImagePath = "/Users/mabala/Desktop/7feb/Stories/mama.png";
        StoryThreeEpisode.DateUploaded = DateTime.Now;
        mamaEpisodes.Add(StoryThreeEpisode);

        return mamaEpisodes;
    }


    public static List<Episode> GenerateTestStoryEpisodesGeza()
    {
        List<Episode> gezaEpisodes = new List<Episode>();
        Episode StoryOneEpisode = new Episode();
        StoryOneEpisode.Id = 1;
        StoryOneEpisode.Title = "Geza1";
        StoryOneEpisode.Price = 10;
        StoryOneEpisode.AudioPath = "/Users/mabala/Desktop/7feb/Stories/geza/geza1.mp3";
        StoryOneEpisode.AgeLimit = false;
        StoryOneEpisode.CreatedBy = GenerateTestUsers()[1];
        StoryOneEpisode.AudioCoverImagePath = "/Users/mabala/Desktop/7feb/Stories/geza.png";
        StoryOneEpisode.DateUploaded = DateTime.Now;
        gezaEpisodes.Add(StoryOneEpisode);



        Episode StoryTwoEpisode = new Episode();
        StoryTwoEpisode.Id = 2;
        StoryTwoEpisode.Title = "Geza2";
        StoryTwoEpisode.Price = 10;
        StoryTwoEpisode.AudioPath = "/Users/mabala/Desktop/7feb/Stories/geza/geza2.mp3";
        StoryTwoEpisode.AgeLimit = false;
        StoryTwoEpisode.CreatedBy = GenerateTestUsers()[1];
        StoryTwoEpisode.AudioCoverImagePath = "/Users/mabala/Desktop/7feb/Stories/geza.png";
        StoryTwoEpisode.DateUploaded = DateTime.Now;
        gezaEpisodes.Add(StoryTwoEpisode);


        Episode StoryThreeEpisode = new Episode();
        StoryThreeEpisode.Id = 1;
        StoryThreeEpisode.Title = "Geza3";
        StoryThreeEpisode.Price = 10;
        StoryThreeEpisode.AudioPath = "/Users/mabala/Desktop/7feb/Stories/geza/geza3.mp3";
        StoryThreeEpisode.AgeLimit = true;
        StoryThreeEpisode.CreatedBy = GenerateTestUsers()[1];
        StoryThreeEpisode.AudioCoverImagePath = "/Users/mabala/Desktop/7feb/Stories/geza.png";
        StoryThreeEpisode.DateUploaded = DateTime.Now;
        gezaEpisodes.Add(StoryThreeEpisode);

        return gezaEpisodes;
    }

    public static List<Episode> GenerateTestStoryEpisodesRiport()
    {
        List<Episode> riportEpisodes = new List<Episode>();
        Episode StoryOneEpisode = new Episode();
        StoryOneEpisode.Id = 1;
        StoryOneEpisode.Title = "Riport1";
        StoryOneEpisode.Price = 10;
        StoryOneEpisode.AudioPath = "/Users/mabala/Desktop/7feb/Stories/riport/riport1.mp3";
        StoryOneEpisode.AgeLimit = false;
        StoryOneEpisode.CreatedBy = GenerateTestUsers()[0];
        StoryOneEpisode.AudioCoverImagePath = "/Users/mabala/Desktop/7feb/Stories/riport.png";
        StoryOneEpisode.DateUploaded = DateTime.Now;
        riportEpisodes.Add(StoryOneEpisode);

        Episode StoryTwoEpisode = new Episode();
        StoryTwoEpisode.Id = 2;
        StoryTwoEpisode.Title = "Riport2";
        StoryTwoEpisode.Price = 10;
        StoryTwoEpisode.AudioPath = "/Users/mabala/Desktop/7feb/Stories/riport/riport2.mp3";
        StoryTwoEpisode.AgeLimit = false;
        StoryTwoEpisode.CreatedBy = GenerateTestUsers()[0];
        StoryTwoEpisode.AudioCoverImagePath = "/Users/mabala/Desktop/7feb/Stories/riport.png";
        StoryTwoEpisode.DateUploaded = DateTime.Now;
        riportEpisodes.Add(StoryTwoEpisode);

        Episode StoryThreeEpisode = new Episode();
        StoryThreeEpisode.Id = 3;
        StoryThreeEpisode.Title = "Riport3";
        StoryThreeEpisode.Price = 10;
        StoryThreeEpisode.AudioPath = "/Users/mabala/Desktop/7feb/Stories/riport/riport3.mp3";
        StoryThreeEpisode.AgeLimit = true;
        StoryThreeEpisode.AudioCoverImagePath = "/Users/mabala/Desktop/7feb/riport/riport.png";
        StoryThreeEpisode.CreatedBy = GenerateTestUsers()[0];
        StoryTwoEpisode.DateUploaded = DateTime.Now;
        riportEpisodes.Add(StoryThreeEpisode);
        return riportEpisodes;
    }


    public static List<MainStory> GenerateTestStories()
    {
        List<MainStory> stories = new List<MainStory>();
        MainStory mainStory1 = new MainStory();
        mainStory1.ID = 1;
        mainStory1.Price = 100;
        mainStory1.Name = "mama";
        mainStory1.CoverPath = "/episodes/Mama/cover.jpg";
        mainStory1.Episodes = GenerateTestStoryEpisodesMama();
        stories.Add(mainStory1);


        MainStory mainStory2 = new MainStory();
        mainStory2.ID = 2;
        mainStory2.Price = 100;
        mainStory2.Name = "Geza";
        mainStory2.CoverPath = "/Users/mabala/Desktop/7feb/Stories/Geza.png";
        mainStory2.Episodes = GenerateTestStoryEpisodesGeza();
        stories.Add(mainStory2);

        MainStory mainStory3 = new MainStory();
        mainStory3.ID = 3;
        mainStory3.Price = 100;
        mainStory3.Name = "Ripoti kamili";
        mainStory3.CoverPath = "/Users/mabala/Desktop/7feb/Stories/Ripoti kamili.mp3";
        mainStory3.Episodes = GenerateTestStoryEpisodesRiport();
        stories.Add(mainStory3);
        return stories;
    }

    public static List<UserPost> GenerateUserPosts()
    {
        List<UserPost> posts = new List<UserPost>();
        UserPost post1 = new UserPost();
        post1.Id = 1;
        post1.Author = GenerateTestUsers()[1];
        post1.Content = "Hey guys, which story is good so far?";
        post1.CreatedAt = DateTime.Now;
        post1.UserComments =  GenerateUserComments();
        post1.TotalLikes = 5;
        post1.TotalDisLikes = 2;
        posts.Add(post1);

        UserPost post2 = new UserPost();
        post2.Id = 2;
        post2.Author = GenerateTestUsers()[0];
        post2.Content = "How are you guys?";
        post2.CreatedAt = DateTime.Now;
        post2.UserComments =GenerateUserComments();
        post2.TotalLikes = 5;
        post2.TotalDisLikes = 2;
        posts.Add(post2);


        UserPost post3 = new UserPost();
        post3.Id = 1;
        post3.Author = GenerateTestUsers()[2];
        post3.Content =
            "I bought a story they indicated its for adults but I was disappointed there is no explicit content in there?";
        post3.CreatedAt = DateTime.Now;
        post3.UserComments = GenerateUserComments();
        post3.TotalLikes = 5;
        post3.TotalDisLikes = 0;
        posts.Add(post1);

        return posts;

    }

    public static List<UserComment> GenerateUserComments()
    {
        List<UserComment> comments = new List<UserComment>();
        UserComment comment1 = new UserComment();
        comment1.Id = 1;
        comment1.CreatedAt = DateTime.Now;
        comment1.Author = GenerateTestUsers()[1];
        comment1.Content = "Good stories";
        comments.Add(comment1);

        UserComment comment2 = new UserComment();
        comment2.Id = 2;
        comment2.CreatedAt = DateTime.Now;
        comment2.Author = GenerateTestUsers()[2];
        comment2.Content = "Im happy to be here";
        comments.Add(comment2);

        UserComment comment3 = new UserComment();
        comment3.Id = 3;
        comment3.CreatedAt = DateTime.Now;
        comment3.Author = GenerateTestUsers()[0];
        comment3.Content = "Good stories";
        comments.Add(comment3);

        return comments;

    }

    public static List<UserMessage> GenerateUserMessages()
    {
        List<UserMessage> messages = new List<UserMessage>();
        UserMessage message1 = new UserMessage();
        message1.Id = 1;
        message1.AuthorName = GenerateTestUsers()[2];
        message1.Content = "Hello there";
        message1.SentAt = DateTime.Now;
        message1.IsRead = false;
        messages.Add(message1);

       
        
        UserMessage message2 = new UserMessage();
        message2.Id = 1;
        message2.AuthorName = GenerateTestUsers()[1];
        message2.Content = "Where have you been?";
        message2.SentAt = DateTime.Now;  //for dattimes , just invent a few realistic ones
        message2.IsRead = false;
        messages.Add(message2);
        

        UserMessage message3 = new UserMessage();
        message3.Id = 3;
        message3.AuthorName = GenerateTestUsers()[0];
        message3.Content = "Are we going to the Restaurant?";
        message3.SentAt = DateTime.Now;
        message3.IsRead = false;
        messages.Add(message3);

        return messages;
    }

    
    public static List<UserConversation> GenerateUserConversations()
    {
        List<UserConversation> conversations = new List<UserConversation>();
        UserConversation conversation1 = new UserConversation();
        conversation1.Id = 1;
        conversation1.Sender = GenerateTestUsers()[2];
        conversation1.User2Name = GenerateTestUsers()[0];
        conversation1.UserMessages = GenerateUserMessages();
        conversation1.LastUpdated = new DateTime(2024,12,12,18,24,11);;
        conversations.Add(conversation1);

        UserConversation conversation2 = new UserConversation();
        conversation2.Id = 2;
        conversation2.Sender = GenerateTestUsers()[0];
        conversation2.User2Name = GenerateTestUsers()[1];
        conversation2.UserMessages = GenerateUserMessages();
        conversation2.LastUpdated = new DateTime(2024,12,12,4,4,3);;
        conversations.Add(conversation2);


        UserConversation conversation3 = new UserConversation();
        conversation3.Id = 3;
        conversation3.Sender = GenerateTestUsers()[1];
        conversation3.User2Name = GenerateTestUsers()[2];
        conversation3.UserMessages = GenerateUserMessages();
        conversation3.LastUpdated = new DateTime(2024,12,12,8,44,34);
        
        conversations.Add(conversation3);

        return conversations;
    }

    
}