namespace Beon.MyBeon.Middleware.Models
{
    public class VehicleView
    {
        public Guid? Oid { get; set; }
        public string? Status { get; set; }
        public string? Plate { get; set; }
        public Guid? CustomerOid { get; set; }
        public string? Customer { get; set; }
		public string? VehicleUser { get; set; }
		public string? ParentCustomer { get; set; }
        public DateTime? InvoiceStartDate { get; set; }
        public DateTime? InvoiceEndDate { get; set; }
        public double? UnitPrice { get; set; }
        public int? Kilometer { get; set; }
        public int? Month { get; set; }
        public double? DeclarationLimit { get; set; }
        public double? ExtraKilometerPrice { get; set; }
        public int? PoolKilometer { get; set; }
        public bool? IsVehiclePledge { get; set; }
        public string? BrandName { get; set; }
        public string? ModelName { get; set; }
        public string? PackageName { get; set; }
        public string? ModelYear { get; set; }
        public string? FuelType { get; set; }
        public string? GearType { get; set; }
        public string? Color { get; set; }
        public bool? IsActive { get; set; }
        public string? ReservationType { get; set; }
        public DateTime? FirstRegistrationDate { get; set; }
        public DateTime? LastRegistrationDate { get; set; }
        public string? EngineNumber { get; set; }
        public string? ChassisNumber { get; set; }
        public string? UsageType { get; set; }
        public string? SegmentType { get; set; }
        public string? DocumentSerialNumber { get; set; }
        public string? ContractNumber { get; set; }
        public DateTime? InspectionDate { get; set; }
        public DateTime? InsurancePolicyExpiryDate { get; set; }
        public DateTime? PolicyExpiryDate { get; set; }
        public double? InsurancePolicyPrice { get; set; }
        public string? LeasingCompany { get; set; }
        public DateTime? BankCreditEndOn { get; set; }
        public string? StockLocation { get; set; }
        public string? Dealer { get; set; }
        public DateTime? ReservationDate { get; set; }
        public string? ReservationCustomer { get; set; }
        public string? VehicleType { get; set; }
        public string? RegistrationNumber { get; set; }
        public string? City { get; set; }
        public string? County { get; set; }
        public string? Bank { get; set; }
        public string? BankCreditNumber { get; set; }
        public int? BankCreditReferenceId { get; set; }
        public DateTime? BankCreditStartOn { get; set; }
        public int? BankCreditMaturity { get; set; }
        public byte[]? BrandImage { get; set; }
    }
}
