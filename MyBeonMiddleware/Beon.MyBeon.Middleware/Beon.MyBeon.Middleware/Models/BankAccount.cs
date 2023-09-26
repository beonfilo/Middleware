namespace Beon.MyBeon.Middleware.Models;

public class BankAccount
{
    public Bank  Bank{ get; set;}
    public int ReferenceId { get; set; }
    public  int İntegrationResult { get; set; }
    public BankAccount AccountType { get; set; }
    public string Code { get; set; }
    public string Name{ get; set; }
    public string  AccountNumber { get; set; }
    public  string Iban { get; set; }
    public Currency Currency { get; set; }
    public bool IsActive{ get; set; }
}
