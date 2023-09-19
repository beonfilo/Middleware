namespace Beon.MyBeon.Middleware.Models
{
    public class Vehicle : VehicleCatalog
    {
        public string IntegrationResult { get; set; } = string.Empty;
        public string CardType { get; set; } = string.Empty;
        public string Code { get; set; } = string.Empty;
		public int Vat { get; set; } = default;
        public Unitset? Unitset { get; set; } 
        public bool IsActive { get; set; } = default;
        public int ReferenceId { get; set; } = default;
        public string VehicleStatus { get; set; } = string.Empty;
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
        public string ChassisNumber { get; set; } = string.Empty;
        public string EngineNumber { get; set; } = string.Empty;
        public string LicenceDocument { get; set; } = string.Empty;
        #region Ruhsat Bilgileri
        public string DocumentSerialNumber = string.Empty;
        public City? City { get; set; }
        public County? County { get; set; }
        public DateTime? FirstRegistrationDate { get; set; }  
        public DateTime? LastRegistrationDate { get; set; }  
        public string RegistrationNumber = string.Empty;
        #endregion
        public DateTime? InspectionDate { get; set; }  //muayene 
        public DateTime? PolicyExpiryDate { get; set; }  // sigorta
        public DateTime? InsurancePolicyExpiryDate { get; set; }  //kasko
        public double InsurancePolicyPrice { get; set; } = default;
        public bool IsVehiclePledge { get; set; } = default; // rehin
        public Bank? Bank { get; set; }
        public LeasingCompany? LeasingCompany { get; set; }
        public string BankCreditNumber = string.Empty;
        public int BankCreditReferenceId { get; set; } = default;
        public DateTime? BankCreditStartOn { get; set; }  
        public int BankCreditMaturity { get; set; } = default;
        public DateTime? BankCreditEndOn { get; set; } 
        public bool IsResevation { get; set; } = default;
        public string VehicleReservationType { get; set; } = string.Empty;//(enum)
        public bool IsLead { get; set; } = default;
        public Customer? ReservationCustomer { get; set; }
        public Lead? ReservationLead { get; set; } 
        public DateTime? ReservationDate { get; set; }  
        //public ApplicationUser? ReservationOwner { get; set; } = default;
        //public Tyre? LeftFrontTyre { get; set; } = default;
        //public Tyre? LeftRearTyre { get; set; } = default;
        //public Tyre? RightFrontTyre { get; set; } = default;
        //public Tyre? RightRearTyre { get; set; } = default;
        public VehiclePurchaseInfo? PurchaseInfo { get; set; }
        public double RealNetTotal { get; set; } = default;
        public double LastMaintenanceKilometer { get; set; } = default; //son bakım KM
        public DateTime? LastMaintenanceDate { get; set; } //son bakım tarihi
        public Dealer? Dealer { get; set; } = default;
        public StockLocation? StockLocation { get; set; }

        public string UsageType { get; set; } = string.Empty;
        public string Kdocument { get; set; } = string.Empty;//k belgesi ticari araçlar için zorunlu
        public string VehicleTollFeeStatus { get; set; } = string.Empty;//hgsyi kim öder var:BEONi yok: Müşteri (Enum)
        public bool IsMarketable { get; set; } = default;//satılabilir
        public bool IsRentable { get; set; } = default;//kiralanabilir
        public bool IsPoolKilometer { get; set; } = default;
        public int SalesInvoiceReferenceId { get; set; } = default;
        public ContractTransactionVehicle? ContractTransactionVehicle { get; set; }
        public DateTime? CertificatefOfAuthExpiryDate { get; set; }
        public VehiclePurchaseOrderLine? VehiclePurchaseOrderLine { get; set; } 
    }
}
