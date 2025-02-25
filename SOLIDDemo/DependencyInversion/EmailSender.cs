// Low-level module implementing abstraction
public class EmailSender : IMessageSender
{
    public void SendMessage(string to, string message)
    {
        Console.WriteLine($"Sending email to {to}: {message}");
        // Email sending logic here
    }
} 