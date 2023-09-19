using Beon.MyBeon.Middleware.Models.BaseModels;

namespace Beon.MyBeon.Middleware.Models
{
    public class VehiclePurchaseOrderLine : BasePurchaseOrderLine
    {
        public string Status { get; set; } = string.Empty;
        public VehiclePurchaseOrder? VehiclePurchaseOrder { get; set; }
        public VehicleBrand? Brand { get; set; }
        public VehicleBrandModel? Model { get; set; }
        public VehicleBrandModelPackage? Package { get; set; }
        public GearType? GearType { get; set; }
        public VehicleBrandModelPackageYear? Year { get; set; }
        public VehicleBrandModelPackageColor? Color { get; set; }

        public double RawPrice { get; set; } = default;//araç bedeli
        public double OtvRate { get; set; } = default;//ötv oranı
        public double OtvTotal { get; set; } = default;//ötv tutarı

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
        public string ChassisNumber { get; set; } = string.Empty;
        public string EngineNumber { get; set; } = string.Empty;

        public bool IsVehiclePledge { get; set; } = default; // rehin
        public Bank? Bank { get; set; }
        public LeasingCompany? LeasingCompany { get; set; }
        public string BankCreditNumber { get; set; } = string.Empty;
        public int BankCreditReferenceId { get; set; } = default;
        public DateTime? BankCreditStartOn { get; set; }
        public int BankCreditMaturity { get; set; } = default;
        public DateTime? BankCreditEndOn { get; set; }
    }
}