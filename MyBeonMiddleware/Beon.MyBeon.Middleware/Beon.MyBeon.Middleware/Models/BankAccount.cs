namespace Beon.MyBeon.Middleware.Models;

public class BankAccount
{
    public Bank? Bank{ get; set;}
    public int ReferenceId { get; set; } = default;
    public int IntegrationResult { get; set; } = default;
    public BankAccount? AccountType { get; set; }
    public string Code { get; set; } = string.Empty; 
    public string Name { get; set; } = string.Empty;
    public string AccountNumber { get; set; } = string.Empty;
    public string Iban { get; set; } = string.Empty;
    public Currency? Currency { get; set; }
    public bool IsActive{ get; set; }
}
