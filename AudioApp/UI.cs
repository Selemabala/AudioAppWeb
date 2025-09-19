namespace AudioApp;
using AudioApp.UserData;
public class UI
{
    public static void DisplayAboutThisApp()
    {
        Console.WriteLine("Hello, welcome to this Audio Application");
        Console.WriteLine("This application has several audio stories");
        Console.WriteLine("You have to fill your age for us to determine which stories to offer you.");
        Console.WriteLine("Just follow the instructions correctly");
    }
    
    public static int GetUserAge()
    {
        Console.WriteLine("how old are you");
        int number = GetNumber();
        return number;
    }
    public static void DisplayStoriesAvailable()
    {
        Console.WriteLine("Stories available");
    }
    public static void DisplayPermission(int age)
    {
        if (age < Constants.LEGAL_AGE)
        {
            Console.WriteLine("You are bellow the age to buy this story");
            return;
        }
        Console.WriteLine("Your age allows you to access all our stories");
    }
    public static void DisplayMainStoryNames(List<MainStory> allStories)
    {
        foreach (MainStory story in allStories)
        {
            Console.WriteLine(story.Name); 
        }
    }
    
    public static void DisplayEpisodesNames(MainStory story)
    {
        foreach (Episode episode  in story.Episodes)
        {
            Console.WriteLine(episode.Title); 
        }
    }
    
    /* public static int DisplayUserStoryChoice(MainStory story, int choice)
    {
        if(choice == story.ID)
        {
            return story.ID;
            yield break;
        }
    }
    */
    public static void DisplayAdminStories(string name)
    {
        {
            Console.WriteLine($"{name} has the following stories");
        }
    }
    
    public static void DisplayEpisodesTotalCost(MainStory story)
    {
        double allPrice = 0;
        foreach (Episode episode  in story.Episodes)
        {
            double price = episode.Price;
            allPrice = allPrice + price;
        }
        Console.WriteLine($"The cost of all episodes is {allPrice}"); 
    }
    public static void DisplayAdminNames(List<ApplicationUser> users)
    {
        foreach (ApplicationUser user in users)
        {
            if (user.UserRole == UserRole.Uploader)
            {
                Console.Write(user.FirstName);
                Console.Write(" ");
                Console.Write(user.MiddleName);
                Console.Write(" ");
                Console.Write(user.LastName);
                Console.WriteLine();
            }
        }
    }
    public static int GetNumber()
    {
        while (true)
        {
            string input = Console.ReadLine();
            if (int.TryParse(input, out int number))
            {
                return number;
            }
            Console.WriteLine("Please enter number");
        }
    }
    
public void WhatIsAudioApp()
    {
        Console.WriteLine("Q: What is AudioApp?");
        Console.WriteLine("A: AudioApp is a platform where you can listen to engaging audio stories. You can purchase entire stories or individual episodes and stream them online.\n");
    }

    public void HowToCreateAccount()
    {
        Console.WriteLine("Q: How do I create an account?");
        Console.WriteLine("A: Tap the 'Sign Up' button on the home screen, enter your details, and follow the instructions to set up your account.\n");
    }

    public void IsAudioAppFree()
    {
        Console.WriteLine("Q: Is AudioApp free to use?");
        Console.WriteLine("A: The app is free to download, and each first content is free to stream. However, premium stories and episodes need to be purchased.\n");
    }

    public void HowToPurchaseStory()
    {
        Console.WriteLine("Q: How can I purchase a story?");
        Console.WriteLine("A: Browse or search for the story you want, select 'Buy Full Story' or 'Buy Episodes,' and complete the purchase through the app's secure payment system.");
        Console.WriteLine("Q: You can but our stories through");
        Console.WriteLine("Tigo Pesa");
        Console.WriteLine("Airtel Money");
        Console.WriteLine("Lipa Namba");
        Console.WriteLine("Azam Pesa");
        Console.WriteLine("M-Pesa");
        Console.WriteLine("Halo Pesa");
        Console.WriteLine("Bank Credit Card");
    }

    public void CanBuySpecificEpisodes()
    {
        Console.WriteLine("Q: Can I buy only specific episodes of a story?");
        Console.WriteLine("A: Yes, you can buy individual episodes by selecting them from the story's episode list.\n");
    }

    public void DiscountsForFullStory()
    {
        Console.WriteLine("Q: Are there discounts for buying the entire story?");
        Console.WriteLine("A: Yes, purchasing the full story is often cheaper than buying episodes individually.\n");
    }

    public void AcceptedPaymentMethods()
    {
        Console.WriteLine("Q: What payment methods are accepted?");
        Console.WriteLine("A: We accept international payments through credit/debit cards, as well as local payments through.\n");
        Console.WriteLine("A: Tigo Pesa");
        Console.WriteLine("A: Airtel Money");
        Console.WriteLine("A: Lipa Namba");
        Console.WriteLine("A: Azam Pesa");
        Console.WriteLine("A: M-Pesa");
        Console.WriteLine("A: Halo Pesa");
    }

    public void ListenOffline()
    {
        Console.WriteLine("Q: Can I listen to stories offline?");
        Console.WriteLine("A: Yes, once you've purchased a story or episode, you can download it for offline listening.\n");
    }

    public void FindPurchasedStories()
    {
        Console.WriteLine("Q: How do I find the stories I've purchased?");
        Console.WriteLine("A: Go to the 'My Library' section in the app to view and access all your purchased content.\n");
    }

    public void StreamWithoutDownloading()
    {
        Console.WriteLine("Q: Can I stream stories without downloading them?");
        Console.WriteLine("A: Yes, you can stream stories directly from the app without downloading.\n");
    }

    public void ShareAccount()
    {
        Console.WriteLine("Q: Can I share my account with others?");
        Console.WriteLine("A: No, accounts are for individual use only. Sharing accounts is against our terms of service.");
        Console.WriteLine("A: Once you share our content with others you are risking a police case on your door, we dont advice you to dare");
    }

    public void ResetPassword()
    {
        Console.WriteLine("Q: How do I reset my password?");
        Console.WriteLine("A: Tap 'Forgot Password' on the login screen, enter your email address, and follow the instructions sent to your inbox.\n");
    }

    public void RequestRefund()
    {
        Console.WriteLine("Q: Can I request a refund?");
        Console.WriteLine("A: Refunds are provided under certain conditions, such as technical issues. Please contact our support team for assistance.");
        Console.WriteLine("A: If its an emergence call us through +255 713 338 355");
    }

    public void TypesOfStories()
    {
        Console.WriteLine("Q: What types of stories are available?");
        Console.WriteLine("A: We offer a wide range of genres, including drama, romance, mystery, secret security, and kids’ stories.\n");
    }

    public void RequestNewStories()
    {
        Console.WriteLine("Q: Can I request new stories or suggest ideas?");
        Console.WriteLine("A: Absolutely! Visit the 'Feedback' section in the app and share your ideas. We love hearing from our users!\n");
    }

    public static PaymentMethods GetPaymentMethod()
    {
        Console.WriteLine("");
        int number = GetNumber();
        switch (number)
        {
            case 1:
                return PaymentMethods.AirtelMoney;
            case 2:
                return PaymentMethods.AzamPesa;
            default:
                return PaymentMethods.TigoPesa;
        }
    }
    
    public static void DisplayModesOfPayments()
    {
        Console.WriteLine("The following are the modes of payments, you will choose one");
        Console.WriteLine("TigoPesa, Press 1");
        Console.WriteLine("AirtelMoney Press 2");
        Console.WriteLine("Lipa Namba Press 3");
        Console.WriteLine("AzamPesa Press 4");
        Console.WriteLine("M-Pesa Press 5");
        Console.WriteLine("HaloPesa Press 6");
        Console.WriteLine("Bank Credit Card Press 7");
    }

    public static int DisplayFullStoryPrice()
    {
        Console.WriteLine("Enter the price of your story if someone wants to buy the whole story");
        int storyPrice = GetNumber();
        return storyPrice;
    }


    public static int DisplayEpisodePrice()
    {
        Console.WriteLine("Enter the price for each episode");
        int EpisodePrice = GetNumber();
        return EpisodePrice;  
    }
    public static void GetPaymentProcess(PaymentMethods paymentMethod)
    {
        while (true)
        {
            if (paymentMethod == PaymentMethods.TigoPesa)
            {
                Console.WriteLine("TigoPesa payment system is activated.");
                // Code to activate TigoPesa payment system
                return;
            }
            
            if (paymentMethod == PaymentMethods.AirtelMoney)
            {
                Console.WriteLine("AirtelMoney payment system is activated.");
                // Code to activate AirtelMoney payment system
                return;
            }

            if (paymentMethod == PaymentMethods.LipaNamba)
            {
                Console.WriteLine("LipaNamba payment system is activated.");
                // Code to activate LipaNamba payment system
                return;
            }

            if (paymentMethod == PaymentMethods.AzamPesa)
            {
                Console.WriteLine("AzamPesa payment system is activated.");
                // Code to activate AzamPesa payment system
                return;
            }

            if (paymentMethod == PaymentMethods.MPesa)
            {
                Console.WriteLine("MPesa payment system is activated.");
                // Code to activate MPesa payment system
                return;
            }

            if (paymentMethod == PaymentMethods.HaloPesa)
            {
                Console.WriteLine("HaloPesa payment system is activated.");
                // Code to activate HaloPesa payment system
                return;
            }

            if (paymentMethod == PaymentMethods.BankCreditCard)
            {
                Console.WriteLine("Bank Credit Card payment system is activated.");
                // Code to activate Bank Credit Card payment system
                return;
            }
            else
            {
                Console.WriteLine("Invalid payment method.");
            }
        }
    }
}