using Beon.MyBeon.Middleware.Models.BaseModels;
using System.Text.Json.Serialization;

namespace Beon.MyBeon.Middleware.Models
{
    public class DamageDemand : BaseModel
    {
        public string? Status { get; set; }
        public DateTime? CreatedOn { get; set; }
        public ApplicationUser? Owner { get; set; }
        public string? Code { get; set; }
        public Vehicle? Vehicle { get; set; }

        public string? DocumentTrackingNumber { get; set; }  //dosya takip no
        public DateTime? DateOfComingTheVehicle { get; set; }   //aracın geliş tarihi 

        public string? CoveredBy { get; set; }
        public string? RepairType { get; set; }
        public VehicleInsurancePolicy? VehicleInsurancePolicy { get; set; }
        public InsuranceCompany? InsuranceCompany { get; set; }
        public double? ExemptionTotal { get; set; }

        public double? DefectRate { get; set; } = default; // kusur oranı
        public string? DamageCause { get; set; }
        public DateTime? DamageDate { get; set; }//hasar tarihi

        [JsonIgnore]
        public TimeSpan DamageTime { get; set; } //hasar saati
        public City? City { get; set; }
        public County? County { get; set; } 
        public string? RecordType { get; set; }  // tutanak tipi
        public string? RecordNumber { get; set; } //tutanak numarası 
        public DateTime? EstimatedDeliveryDate { get; set; } //tahmini teslim tarihi
        public double? Kilometer { get; set; } = default; 
        public bool? IsBodilyHarm { get; set; } = default; //bedensel hasar var mı 
        public bool? IsContractedWithInsurance { get; set; } = default;//servis sigorta ile anlaşmalı mı ?  
        public Customer? Customer { get; set; }
        public CustomerContact? CustomerContact { get; set; } 
        public bool? IsDriverHimself { get; set; } = default; //sürücünün kendisi mi ?
        public Contact? PersonWhoCausedTheAccident { get; set; }  //kazaya sebep olan kişi  
        public string? BroughtByType { get; set; }  //aracı getiren kişinin tipi
        public string? BroughtByFirstname { get; set; } //aracı getiren adı
        public string? BroughtByLastname { get; set; } //aracı getiren soyadı
        public string? BroughtByTCKN { get; set; }
        public string? BroughtByTelephone { get; set; }
        public string? BroughtByEMail { get; set; }

        public CounterInsuranceCompany? CounterInsuranceCompany;
        public string? VehicleStatus { get; set; } 
        public Contact? ReportingBy { get; set; }//ihbarı bildiren kişi

        public bool IsSubstitutionVehicle;
        public DamageSubstitutionVehicle? SubstitutionVehicle { get; set; }
        public ContractTransactionVehicle? ContractTransactionVehicle { get; set; }

    }
}
