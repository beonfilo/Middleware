namespace Beon.MyBeon.Middleware.Models;

public class ContractProtocol
{
    public Contact? Contact { get; set; }
    public string FileName { get; set; } = string.Empty;
    public ApplicationUser? Owner { get; set; }
    public DateTime CreatedOn { get; set; }
    public DateTime SigningDate { get; set; }
    public string Description { get; set; } = string.Empty;
}
