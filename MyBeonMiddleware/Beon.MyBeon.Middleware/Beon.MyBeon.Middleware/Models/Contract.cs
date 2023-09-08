using Beon.MyBeon.Middleware.Models.BaseModels;

namespace Beon.MyBeon.Middleware.Models;

public class Contract : BaseModel
{
    public DateTime CreatedOn { get; set; }
    public string Code{ get; set; } = string.Empty;
    public Customer? Customer { get; set; }
    public DateTime StartDate { get; set; }
    public int RevisionNumber { get; set; } = default;
    public double Total { get; set; } = default;
    public double TotalDiscount { get; set; } = default;
    public double TotalVat { get; set; } = default;
    public double NetTotal { get; set; } = default;
    public bool IsActive { get; set; } = default;
    public bool IsCustomerContract { get; set; } = default;
    public bool IsHandoverProtocol { get; set; } = default;
    public DateTime HandevorProtocolOn { get; set; }
   // public ApplicationUser? Owner { get; set; }

}
