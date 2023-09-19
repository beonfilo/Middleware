using Beon.MyBeon.Middleware.Models.BaseModels;

namespace Beon.MyBeon.Middleware.Models
{
    public class VehiclePurchaseDemandLine : BaseModel
    {
        public VehiclePurchaseDemand? VehiclePurchaseDemand { get; set; }
        public string Status { get; set; } = string.Empty;
        public int LineNumber { get; set; } = default;
        public string Code { get; set; } = string.Empty;
        public VehicleBrand? Brand { get; set; }
        public VehicleBrandModel? Model { get; set; }
        public VehicleBrandModelPackage? Package { get; set; }
        public GearType? GearType { get; set; }
        public VehicleBrandModelPackageYear? Year { get; set; }
        public VehicleBrandModelPackageColor? Color { get; set; }
        public double Quantity { get; set; } = default;
        public DateTime? DueDate { get; set; }
        public string Description { get; set; } = string.Empty;
        public Quote? Quote { get; set; }
        public QuoteTransaction? QuoteTransaction { get; set; }
        public Order? Order { get; set; }
        public OrderTransaction? OrderTransaction { get; set; }
        public OrderTransactionVehicle? OrderTransactionVehicle { get; set; }
        public Customer? Customer { get; set; }
        public Dealer? Dealer { get; set; }

        public VehiclePurchaseOrder? VehiclePurchaseOrder { get; set; }
        public VehiclePurchaseOrderLine? VehiclePurchaseOrderLine { get; set; }

        public Vehicle? Vehicle { get; set; }
        public ContractTransactionVehicle? contractTransactionVehicle { get; set; }
    }
}