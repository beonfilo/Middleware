using Beon.MyBeon.Middleware.Models.BaseModels;

namespace Beon.MyBeon.Middleware.Models
{
	public class VehicleInsurancePolicy : BaseModel
	{
		public string Status { get; set; } = string.Empty;
		public DateTime CreatedOn { get; set; } = DateTime.Now;
		//public ApplicationUser _owner;

		public LeasingCompany? NameOfInsured { get; set; }//sigortalı adı
		public LeasingCompany? InsuredBy { get; set; }//sigorta Ettiren
		public AgencyCompany? Agency { get; set; }//acente adı

		public Vehicle? Vehicle { get; set; }
		public Customer? Customer { get; set; }
		public string PolicyNumber { get; set; } = string.Empty;
		public DateTime? StartDate { get; set; }
		public DateTime? EndDate { get; set; }
		public InsuranceCompany? InsuranceCompany { get; set; }
		public double Total { get; set; }
		public string PolicyDocumentData { get; set; } = string.Empty;//ana poliçe
		public string SupplementaryDocumentData { get; set; } = string.Empty;//plaka zeyl
		public string MortgageeDocumentData { get; set; } = string.Empty;//daini mürtehin dosyası

		public int RecoveryCount { get; set; } = default;
		public int EsedRecoveryCount { get; set; } = default;
		public double ExemptionTotal { get; set; } = default;
		public DateTime? CancelledOn { get; set; }
		//public ApplicationUser _cancelledBy;

	}
}