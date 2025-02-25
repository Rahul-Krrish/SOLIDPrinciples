// Now follows OCP - we can add new payment methods without modifying this class
public class PaymentProcessor
{
    private readonly IPaymentMethod _paymentMethod;

    public PaymentProcessor(IPaymentMethod paymentMethod)
    {
        _paymentMethod = paymentMethod;
    }

    public void ProcessPayment(decimal amount)
    {
        _paymentMethod.ProcessPayment(amount);
    }
} 