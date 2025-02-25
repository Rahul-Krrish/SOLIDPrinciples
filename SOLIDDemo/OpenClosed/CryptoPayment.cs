public class CryptoPayment : IPaymentMethod
{
    public void ProcessPayment(decimal amount)
    {
        Console.WriteLine($"Processing cryptocurrency payment of {amount}");
        // Cryptocurrency processing logic
    }
} 