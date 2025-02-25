
// High-level module directly depending on low-level module
public class NotificationService
{
    private readonly EmailSender _emailSender;

    public NotificationService()
    {
        _emailSender = new EmailSender(); // Direct dependency on concrete class
    }

    public void SendNotification(string to, string message)
    {
        _emailSender.SendEmail(to, message);
    }
}


// High-level module depending on abstraction
public class NotificationService
{
    private readonly IMessageSender _messageSender;

    public NotificationService(IMessageSender messageSender)
    {
        _messageSender = messageSender;
    }

    public void SendNotification(string to, string message)
    {
        _messageSender.SendMessage(to, message);
    }
} 