using Beon.MyBeon.Middleware.Models.BaseModels;

namespace Beon.MyBeon.Middleware.Models;

public class InsurancePolicy : BaseModel
{
	public string Status { get; set; } = string.Empty; //Enum
	public DateTime CreatedOn { get; set; }
	//public ApplicationUser _owner;
	public LeasingCompany? NameOfInsured { get; set; }//sigortalı adı
	public LeasingCompany? InsuredBy { get; set; }//sigorta Ettiren
	public AgencyCompany? Agency { get; set; }//acente adı
	public Vehicle? Vehicle { get; set; }
	public Customer? Customer { get; set; }
	public string PolicyNumber { get; set; } = string.Empty; //poliçe no
	public DateTime StartDate { get; set; } = default;
	public DateTime EndDate { get; set; } = default;
	public InsuranceCompany? InsuranceCompany { get; set; }
	public double Total { get; set; } = default;
	//public FileData _policyDocumentData;//poliçe dosyası
	//public FileData _supplementaryDocumentData;//zeyil dosyası
	public int RecoveryCount { get; set; } = default;
	public int UsedRecoveryCount { get; set; } = default;
	public double ExemptionTotal { get; set; } = default;//muafiyet tutarı
	public double ReturnedTotal { get; set; } = default;
	public DateTime CancelledOn { get; set; } = default;
	//public ApplicationUser _cancelledBy;
}
