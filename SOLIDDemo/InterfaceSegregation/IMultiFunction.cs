// Before - Fat interface that forces classes to implement unnecessary methods
public interface IMultiFunction
{
    void Print(string document);
    void Scan(string document);
    void Fax(string document);
    void PrintDuplex(string document);
    void SendEmail(string document, string emailAddress);
} 