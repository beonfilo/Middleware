using Beon.MyBeon.Middleware.Models.BaseModels;

namespace Beon.MyBeon.Middleware.Models
{
	public class DamageDemand : BaseModel
	{
		public string Status { get; set; } = string.Empty;
		public DateTime? CreatedOn { get; set; } = DateTime.Now;
		//public ApplicationUser _owner;
		public string Code { get; set; } = string.Empty;
		public Vehicle? Vehicle { get; set; }

		public string DocumentTrackingNumber { get; set; } = string.Empty; //dosya takip no
		public DateTime? DateOfComingTheVehicle { get; set; } = DateTime.Now; //aracın geliş tarihi 

		public string CoveredBy { get; set; } = string.Empty;
		public string RepairType { get; set; } = string.Empty;
		public VehicleInsurancePolicy? VehicleInsurancePolicy { get; set; }
		public InsuranceCompany? InsuranceCompany { get; set; }
		public double ExemptionTotal { get; set; }

		public double DefectRate { get; set; } =default; // kusur oranı
		public string DamageCause { get; set; } = string.Empty;
		public DateTime? DamageDate { get; set; }//hasar tarihi
		public TimeSpan DamageTime { get; set; } //hasar saati
		public City? City { get; set; }
		public County? County { get; set; }

		public string RecordType { get; set; } = string.Empty; // tutanak tipi
		public string RecordNumber { get; set; } = string.Empty;//tutanak numarası

		public DateTime? EstimatedDeliveryDate { get; set; } //tahmini teslim tarihi
		public double Kilometer { get; set; } = default;

		public bool IsBodilyHarm { get; set; } = default; //bedensel hasar var mı 
		public bool IsContractedWithInsurance { get; set; } = default;//servis sigorta ile anlaşmalı mı ? 

		public Customer? Customer { get; set; }
		public CustomerContact? CustomerContact { get; set; }

		public bool IsDriverHimself { get; set; } = default; //sürücünün kendisi mi ?
		public Contact? PersonWhoCausedTheAccident { get; set; }  //kazaya sebep olan kişi


		public string BroughtByType { get; set; } = string.Empty; //aracı getiren kişinin tipi
		public string BroughtByFirstname { get; set; } = string.Empty;//aracı getiren adı
		public string BroughtByLastname { get; set; } = string.Empty;//aracı getiren soyadı
		public string BroughtByTCKN { get; set; } = string.Empty;
		public string BroughtByTelephone { get; set; } = string.Empty;
		public string BroughtByEMail { get; set; } = string.Empty;

		public CounterInsuranceCompany? CounterInsuranceCompany;
		public string VehicleStatus { get; set; } = string.Empty;

		public Contact? ReportingBy { get; set; }//ihbarı bildiren kişi

		public bool IsSubstitutionVehicle;
		public DamageSubstitutionVehicle? SubstitutionVehicle { get; set; }
		public ContractTransactionVehicle? ContractTransactionVehicle { get; set; }

	}
}
