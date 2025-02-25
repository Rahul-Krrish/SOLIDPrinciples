// High-end printer implementing only the interfaces it needs
public class ExpensivePrinter : IPrinter, IScanner, IFax, IEmailSender, IDuplexPrinter
{
    public void Print(string document)
    {
        Console.WriteLine($"Printing: {document}");
    }

    public void Scan(string document)
    {
        Console.WriteLine($"Scanning: {document}");
    }

    public void Fax(string document)
    {
        Console.WriteLine($"Faxing: {document}");
    }

    public void PrintDuplex(string document)
    {
        Console.WriteLine($"Printing duplex: {document}");
    }

    public void SendEmail(string document, string emailAddress)
    {
        Console.WriteLine($"Sending {document} by email to {emailAddress}");
    }
} 