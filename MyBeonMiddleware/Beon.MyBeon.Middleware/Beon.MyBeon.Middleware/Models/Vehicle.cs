using Beon.MyBeon.Middleware.Models.BaseModels;

namespace Beon.MyBeon.Middleware.Models
{
    public class Vehicle : BaseModel
    {
        //public IntegrationResult _integrationResult;
        //public CardType _cardType;
        public string Code { get; set; } = string.Empty;
		public string Name { get; set; } = string.Empty;
		public int Vat { get; set; } = default;
        public Unitset? Unitset { get; set; } 
        public bool IsActive { get; set; } = default;
        public int ReferenceId { get; set; } = default;
        //public VehicleStatus _status;
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
        public string ChassisNumber = string.Empty;
        public string EngineNumber = string.Empty;
        //public FileData _licenceDocument;
        #region Ruhsat Bilgileri
        public string DocumentSerialNumber = string.Empty;
        public City? City { get; set; }
        public County? County { get; set; }
        public DateTime FirstRegistrationDate { get; set; } = DateTime.Now;
        public DateTime LastRegistrationDate { get; set; } = DateTime.Now;
        public string RegistrationNumber = string.Empty;
        #endregion

        public DateTime InspectionDate { get; set; } = DateTime.Now; //muayene 
        public DateTime PolicyExpiryDate { get; set; } = DateTime.Now; // sigorta
        public DateTime InsurancePolicyExpiryDate { get; set; } = DateTime.Now; //kasko
        public double InsurancePolicyPrice { get; set; } = default;

        public bool IsVehiclePledge { get; set; } = default; // rehin
        public Bank? Bank { get; set; }
        //public LeasingCompany? LeasingCompany { get; set; }
        public string BankCreditNumber = string.Empty;
        public int BankCreditReferenceId { get; set; } = default;
        public DateTime BankCreditStartOn { get; set; } = DateTime.Now;
        public int BankCreditMaturity { get; set; } = default;
        public DateTime BankCreditEndOn { get; set; } = DateTime.Now;

        public bool IsResevation { get; set; } = default;
        //public VehicleReservationType? _reservationType { get; set; }
        public bool IsLead { get; set; } = default;
        public Customer? ReservationCustomer { get; set; }
        //public Lead? ReservationLead { get; set; } 
        public DateTime ReservationDate { get; set; } = default;
        //public ApplicationUser? ReservationOwner { get; set; } = default;
        //public Tyre? LeftFrontTyre { get; set; } = default;
        //public Tyre? LeftRearTyre { get; set; } = default;
        //public Tyre? RightFrontTyre { get; set; } = default;
        //public Tyre? RightRearTyre { get; set; } = default;
        //public VehiclePurchaseInfo? PurchaseInfo { get; set; } 
        public double RealNetTotal { get; set; } = default;
        public double LastMaintenanceKilometer { get; set; } = default; //son bakım KM
        public DateTime LastMaintenanceDate { get; set; } = DateTime.Now; //son bakım tarihi

        //public Dealer? Dealer { get; set; } = default;
        //public StockLocation? StockLocation { get; set; }

        //public VehicleUsageType? UsageType { get; set; }
        //public FileData KDocument;//K Belgesi Ticari araçlar için zorunlu

        //public VehicleTollFeeStatus? TollFeeStatus { get; set; } //hgsyi kim öder var:BEONi yok: Müşteri

        public bool IsMarketable { get; set; } = default;//satılabilir
        public bool IsRentable { get; set; } = default;//kiralanabilir
        public bool IsPoolKilometer { get; set; } = default;


        public int SalesInvoiceReferenceId { get; set; } = default;
        //public ContractTransactionVehicle? _contractTransactionVehicle { get; set; } 
        public DateTime CertificatefOfAuthExpiryDate { get; set; } = DateTime.Now;
        //public VehiclePurchaseOrderLine? _vehiclePurchaseOrderLine { get; set; } 
    }
}
