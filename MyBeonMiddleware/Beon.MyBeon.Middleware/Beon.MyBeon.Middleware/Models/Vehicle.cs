namespace Beon.MyBeon.Middleware.Models
{
    public class Vehicle : VehicleCatalog
    {
        public string? IntegrationResult { get; set; }  
        public string? CardType { get; set; }  
        public string? Code { get; set; }  
		public int? Vat { get; set; } 
        public Unitset? Unitset { get; set; } 
        public bool? IsActive { get; set; } 
        public int? ReferenceId { get; set; } 
        public string? VehicleStatus { get; set; }  
        public byte[]? VehicleImage { get; set; }
        public VehiclePlate? Plate { get; set; }
        public VehicleBrand? Brand { get; set; }
        public VehicleBrandModel? Model { get; set; } 
        public VehicleBrandModelPackageYear? ModelYear { get; set; }
        public VehicleBrandModelPackage? Package { get; set; }
        public TyreDimension? TyreDimension { get; set; } 
        public VehicleBrandModelPackageColor? Color { get; set; } 
        public VehicleBrandModelPackageGear? Gear { get; set; } //iptal
        public GearType? GearType { get; set; }
        public string? ChassisNumber { get; set; }  
        public string? EngineNumber { get; set; }  
        
        #region Ruhsat Bilgileri
        public string? DocumentSerialNumber { get; set; }
        public City? City { get; set; }
        public County? County { get; set; }
        public DateTime? FirstRegistrationDate { get; set; }  
        public DateTime? LastRegistrationDate { get; set; }  
        public string? RegistrationNumber { get; set; }
        #endregion
        public DateTime? InspectionDate { get; set; }  //muayene 
        public DateTime? PolicyExpiryDate { get; set; }  // sigorta
        public DateTime? InsurancePolicyExpiryDate { get; set; }  //kasko
        public double? InsurancePolicyPrice { get; set; } 
        public bool? IsVehiclePledge { get; set; }  // rehin
        public Bank? Bank { get; set; }
        public LeasingCompany? LeasingCompany { get; set; }
        public string? BankCreditNumber { get; set; }
        public int? BankCreditReferenceId { get; set; } 
        public DateTime? BankCreditStartOn { get; set; }  
        public int? BankCreditMaturity { get; set; } 
        public DateTime? BankCreditEndOn { get; set; } 
        public bool? IsResevation { get; set; } 
        public string? VehicleReservationType { get; set; }  //(enum)
        public bool? IsLead { get; set; } 
        public Customer? ReservationCustomer { get; set; }
        public Lead? ReservationLead { get; set; } 
        public DateTime? ReservationDate { get; set; }  
        //public ApplicationUser? ReservationOwner { get; set; } 
        //public Tyre? LeftFrontTyre { get; set; } 
        //public Tyre? LeftRearTyre { get; set; } 
        //public Tyre? RightFrontTyre { get; set; } 
        //public Tyre? RightRearTyre { get; set; } 
        public VehiclePurchaseInfo? PurchaseInfo { get; set; }
        public double? RealNetTotal { get; set; } 
        public double? LastMaintenanceKilometer { get; set; }  //son bakım KM
        public DateTime? LastMaintenanceDate { get; set; } //son bakım tarihi
        public Dealer? Dealer { get; set; } 
        public StockLocation? StockLocation { get; set; }
		public FileData? LicenceDocument { get; set; }
		public string? UsageType { get; set; }  
        public string? Kdocument { get; set; }  //k belgesi ticari araçlar için zorunlu
        public string? VehicleTollFeeStatus { get; set; }  //hgsyi kim öder var:BEONi yok: Müşteri (Enum)
        public bool? IsMarketable { get; set; } //satılabilir
        public bool? IsRentable { get; set; } //kiralanabilir
        public bool? IsPoolKilometer { get; set; } 
        public int? SalesInvoiceReferenceId { get; set; } 
        public ContractTransactionVehicle? ContractTransactionVehicle { get; set; }
        public DateTime? CertificatefOfAuthExpiryDate { get; set; }
        public VehiclePurchaseOrderLine? VehiclePurchaseOrderLine { get; set; }
        public Guid VehicleInsurancePolicy { get; set; }
        public Guid InsurancePolicy { get; set; }

    }
}
