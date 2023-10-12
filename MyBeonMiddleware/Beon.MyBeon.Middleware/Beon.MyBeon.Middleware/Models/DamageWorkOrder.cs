using Beon.MyBeon.Middleware.Models.BaseModels;

namespace Beon.MyBeon.Middleware.Models;

public class DamageWorkOrder : BaseModel
{
    public string? Status { get; set; }
    public DateTime? CreatedOn { get; set; }
    public ApplicationUser? Owner { get; set; }
    public string? Code { get; set; }
    public Vehicle? Vehicle { get; set; }

    public AuthorizedServiceShop? AuthorizedServiceShop { get; set; }
    public AuthorizedServiceShopBranch? Branch { get; set; }

    public string? DocumentTrackingNumber { get; set; } //dosya takip no
    public DateTime? DateOfComingTheVehicle { get; set; } //aracın geliş tarihi 

    public string? CoveredBy { get; set; }
    public string? RepairType { get; set; }
    public VehicleInsurancePolicy? VehicleInsurancePolicy { get; set; }
    public InsuranceCompany? InsuranceCompany { get; set; }
    public double? ExemptionTotal { get; set; }

    public double? DefectRate { get; set; } // kusur oranı
    public string? DamageCause { get; set; }
    public DateTime? DamageDate { get; set; } //hasar tarihi
    public TimeSpan? DamageTime { get; set; } //hasar saati
    public City? City { get; set; }
    public County? County { get; set; }

    public string? RecordType { get; set; } // tutanak tipi
    public string? RecordNumber { get; set; }//tutanak numarası

    public DateTime? EstimatedDeliveryDate { get; set; } //tahmini teslim tarihi
    public double? Kilometer { get; set; }

    public bool? IsBodilyHarm { get; set; } //bedensel hasar var mı 
    public bool? IsContractedWithInsurance { get; set; }//servis sigorta ile anlaşmalı mı ? 

    public Customer? Customer { get; set; }
    public CustomerContact? CustomerContact { get; set; }

    public bool? IsDriverHimself { get; set; } //sürücünün kendisi mi ?
    public Contact? PersonWhoCausedTheAccident { get; set; } //sürücünün kendisi mi ?

    public string? BroughtByType { get; set; }
    public string? BroughtByFirstname { get; set; }//aracı getiren adı
    public string? BroughtByLastname { get; set; }//aracı getiren soyadı
    public string? BroughtByTCKN { get; set; }
    public string? BroughtByTelephone { get; set; }
    public string? BroughtByEMail { get; set; }

    public CounterInsuranceCompany? CounterInsuranceCompany { get; set; }
    public string? VehicleStatus { get; set; }

    public Contact? ReportingBy { get; set; }//ihbarı bildiren kişi

    public DamageDemand? Demand { get; set; }

    public bool? IsSubstitutionVehicle { get; set; }
    public DamageSubstitutionVehicle? SubstitutionVehicle { get; set; }

    public DateTime? CompletedOn { get; set; }
    public ApplicationUser? CompletedBy { get; set; }
    public string? DamageStatus { get; set; }
    public DamageTransaction? DamageTransaction { get; set; }

    public double? Total { get; set; }
    public double? TotalVat { get; set; }
    public double? NetTotal { get; set; }
    public double? ChargeoutTotal { get; set; }

    public double? OtherTotal { get; set; }
    public double? OtherTotalVat { get; set; }
    public double? OtherNetTotal { get; set; }
    public string? ChargeoutStatus { get; set; }
    public double? OtherChargeoutTotal { get; set; }

    public FileData? ChargeoutDocumentData { get; set; }//yanıtma Belgesi

    public DamageWorkOrder? ParentWorkOrder { get; set; }

    public ReasonForRejection? ReasonForRejection { get; set; }
    public string? RejectionDescription { get; set; }
    public DateTime? RejectionOn { get; set; }
    public ApplicationUser? RejectionOwner { get; set; }
    public double? AgreedPrice { get; set; }
}
