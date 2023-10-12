using Beon.MyBeon.Middleware.Models.BaseModels;

namespace Beon.MyBeon.Middleware.Models;

public class InsurancePolicy : BaseModel
{
    public string? Status { get; set; }  //Enum
    public DateTime? CreatedOn { get; set; }
    public ApplicationUser? Owner { get; set; }
    public LeasingCompany? NameOfInsured { get; set; }//sigortalı adı
    public LeasingCompany? InsuredBy { get; set; }//sigorta Ettiren
    public AgencyCompany? Agency { get; set; }//acente adı
    public Vehicle? Vehicle { get; set; }
    public Customer? Customer { get; set; }
    public string? PolicyNumber { get; set; }  //poliçe no
    public DateTime? StartDate { get; set; }
    public DateTime? EndDate { get; set; }
    public InsuranceCompany? InsuranceCompany { get; set; }
    public double? Total { get; set; }  
    public FileData? PolicyDocumentData { get; set; }//poliçe dosyası
    public FileData? SupplementaryDocumentData { get; set; }//zeyil dosyası
    public int? RecoveryCount { get; set; }  
    public int? UsedRecoveryCount { get; set; }  
    public double? ExemptionTotal { get; set; }  //muafiyet tutarı
    public double? ReturnedTotal { get; set; }  
    public DateTime? CancelledOn { get; set; }
    public ApplicationUser? CancelledBy { get; set; }
}
