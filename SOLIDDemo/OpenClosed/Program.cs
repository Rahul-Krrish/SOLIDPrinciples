using System;

public class Program
{
    static void Main()
    {
        // Before - Violating OCP
        var oldProcessor = new PaymentProcessor();
        oldProcessor.ProcessPayment("CreditCard", 100.00m);
        oldProcessor.ProcessPayment("PayPal", 50.00m);

        // After - Following OCP
        var creditCardProcessor = new PaymentProcessor(new CreditCardPayment());
        creditCardProcessor.ProcessPayment(100.00m);

        var payPalProcessor = new PaymentProcessor(new PayPalPayment());
        payPalProcessor.ProcessPayment(50.00m);

        // Adding new payment method without modifying existing code
        var cryptoProcessor = new PaymentProcessor(new CryptoPayment());
        cryptoProcessor.ProcessPayment(75.00m);
    }
} 