using Beon.MyBeon.Middleware.Models.BaseModels;

namespace Beon.MyBeon.Middleware.Models
{
    public class VehiclePurchaseOrderLine : BasePurchaseOrderLine
    {
        public string? Status { get; set; }  
        public VehiclePurchaseOrder? VehiclePurchaseOrder { get; set; }
        public VehicleBrand? Brand { get; set; }
        public VehicleBrandModel? Model { get; set; }
        public VehicleBrandModelPackage? Package { get; set; }
        public GearType? GearType { get; set; }
        public VehicleBrandModelPackageYear? Year { get; set; }
        public VehicleBrandModelPackageColor? Color { get; set; }
        public double? RawPrice { get; set; } //araç bedeli
        public double? OtvRate { get; set; } //ötv oranı
        public double? OtvTotal { get; set; } //ötv tutarı
        public DateTime? EstimatedDeliveryDate { get; set; }//ön görülen teslim tarihi
        public DateTime? EstimatedInvoiceDate { get; set; }//ön görülen fatura tarihi
        public Customer? Customer { get; set; }
        public VehiclePurchaseDemand? VehiclePurchaseDemand { get; set; }
        public VehiclePurchaseDemandLine? VehiclePurchaseDemandLine { get; set; }
        public Quote? Quote { get; set; }
        public QuoteTransaction? QuoteTransaction { get; set; }
        public Contract? Contract { get; set; }
        public ContractTransaction? ContractTransaction { get; set; }
        public ContractTransactionVehicle? contractTransactionVehicle { get; set; }
        public Vehicle? Vehicle { get; set; }
        public string? ChassisNumber { get; set; }  
        public string? EngineNumber { get; set; }  
        public bool? IsVehiclePledge { get; set; }  // rehin
        public Bank? Bank { get; set; }
        public LeasingCompany? LeasingCompany { get; set; }
        public string? BankCreditNumber { get; set; }  
        public int? BankCreditReferenceId { get; set; } 
        public DateTime? BankCreditStartOn { get; set; }
        public int? BankCreditMaturity { get; set; } 
        public DateTime? BankCreditEndOn { get; set; }
    }
}