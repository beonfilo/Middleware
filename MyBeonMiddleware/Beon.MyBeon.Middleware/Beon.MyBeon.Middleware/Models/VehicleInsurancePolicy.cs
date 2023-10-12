using Beon.MyBeon.Middleware.Models.BaseModels;

namespace Beon.MyBeon.Middleware.Models
{
    public class VehicleInsurancePolicy : BaseModel
	{
		public string? Status { get; set; }  
		public DateTime CreatedOn { get; set; }  
		public ApplicationUser? Owner { get; set; }
		public LeasingCompany? NameOfInsured { get; set; }//sigortalı adı
		public LeasingCompany? InsuredBy { get; set; }//sigorta Ettiren
		public AgencyCompany? Agency { get; set; }//acente adı

		public Vehicle? Vehicle { get; set; }
		public Customer? Customer { get; set; }
		public string? PolicyNumber { get; set; }  
		public DateTime? StartDate { get; set; }
		public DateTime? EndDate { get; set; }
		public InsuranceCompany? InsuranceCompany { get; set; }
		public double? Total { get; set; }
		public string? PolicyDocumentData { get; set; }  //ana poliçe
		public string? SupplementaryDocumentData { get; set; }  //plaka zeyl
		public string? MortgageeDocumentData { get; set; }  //daini mürtehin dosyası

		public int? RecoveryCount { get; set; }  
		public int? EsedRecoveryCount { get; set; }  
		public double? ExemptionTotal { get; set; }  
		public DateTime? CancelledOn { get; set; }
		public ApplicationUser? CancelledBy{ get; set; }

    }
}