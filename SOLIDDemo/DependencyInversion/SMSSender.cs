// Another low-level module implementing the same abstraction
public class SMSSender : IMessageSender
{
    public void SendMessage(string to, string message)
    {
        Console.WriteLine($"Sending SMS to {to}: {message}");
        // SMS sending logic here
    }
} 