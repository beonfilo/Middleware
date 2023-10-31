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
    public DateTime? HandevorProtocolOn { get; set; }
    public ApplicationUser? Owner { get; set; }
    public string? Status { get; set; }
	public string StatusName
	{
		get
		{

			switch (Status)
			{
				case "SignatureState":
					return "İmza Aşamasında";
				case "IsValid":
					return "Yürürlükte";
				case "Abrogated":
					return "Feshedildi";
				case "Terminated":
					return "Süresi Doldu";
				case "Cancelled":
					return "İptal Edildi";
				case "Devir":
					return "Devir";
				default:
					return "Diğer";
			}
		}
	}
	public Currency? Currency { get; set; }
	public Salesman? Salesman { get; set; }	
	public ContractRevision? ContractRevision {  get; set; }	
	public Quote? Quote { get; set; }
	public Customer? HandoverProtocolCustomer { get; set; }
	public Contract? HandoverProtocolContract { get; set; }
	public FileData? CustomerContractFile { get; set; }

}
