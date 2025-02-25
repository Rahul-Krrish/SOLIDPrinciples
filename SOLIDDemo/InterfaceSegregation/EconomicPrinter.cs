// Basic printer only implements what it can actually do
public class EconomicPrinter : IPrinter
{
    public void Print(string document)
    {
        Console.WriteLine($"Printing: {document}");
    }
} 