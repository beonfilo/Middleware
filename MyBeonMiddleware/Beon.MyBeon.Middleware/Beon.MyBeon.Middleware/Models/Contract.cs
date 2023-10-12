using Beon.MyBeon.Middleware.Models.BaseModels;

namespace Beon.MyBeon.Middleware.Models;

public class Contract : BaseModel
{
    public DateTime? CreatedOn { get; set; }
    public string? Code { get; set; }
    public Customer? Customer { get; set; }
    public DateTime? StartDate { get; set; }
    public int? RevisionNumber { get; set; }
    public double? Total { get; set; }
    public double? TotalDiscount { get; set; }
    public double? TotalVat { get; set; }
    public double? NetTotal { get; set; }
    public bool? IsActive { get; set; }
    public bool? IsCustomerContract { get; set; }
    public bool? IsHandoverProtocol { get; set; }
    public DateTime HandevorProtocolOn { get; set; }
    public ApplicationUser? Owner { get; set; }

}
