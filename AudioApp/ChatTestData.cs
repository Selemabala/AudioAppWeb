namespace AudioApp;

public class ChatTestData
{
    public static List<UserMessage> genereteMessages()
  
    {
        List<UserMessage> messages = new List<UserMessage>();
        UserMessage message1 = new UserMessage();
        message1.Id = 1;
        message1.AuthorName = TestData.GenerateTestUsers()[0];
        message1.Content = "Hello People";
        message1.SentAt = DateTime.Now;
        message1.IsRead = false;
        //message1.ReplyToMessage = message2;
        messages.Add(message1);
        
        UserMessage message2 = new UserMessage();
        message2.Id = 2;
        message2.AuthorName = TestData.GenerateTestUsers()[1];
        message2.Content = "Hello Guys, Im not attending the party today";
        message2.SentAt = new DateTime(2024, 11, 28, 22, 30, 0);
        message2.IsRead = false;
        //message2.ReplyToMessage = message1;
        messages.Add(message2);
        
        UserMessage message3 = new UserMessage();
        message3.Id = 3;
        message3.AuthorName = TestData.GenerateTestUsers()[2];
        message3.Content = "Greetings lovely people, I just wanna tell you Jesus loves you";
        message3.SentAt = new DateTime(2024, 12, 08, 12, 30, 0);
        message3.IsRead = false;
        //message3.ReplyToMessage = message1;
        messages.Add(message3);

        return messages;
    }
    

}