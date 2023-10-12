using Beon.MyBeon.Middleware.Models.BaseModels;

namespace Beon.MyBeon.Middleware.Models
{
    public class OrderTransactionVehicle : BaseModel
    {
        public OrderTransaction? OrderTransaction { get; set; }
        public int? LineNumber { get; set; } 
        public string? Status { get; set; }  
        public Vehicle? Vehicle { get; set; }
        public VehicleBrand? Brand { get; set; }
        public VehicleBrandModel? Model { get; set; }
        public VehicleBrandModelPackage? Package { get; set; }
        public VehicleBrandModelPackageYear? Year { get; set; }
        public GearType? GearType { get; set; }
        public string? MeetType { get; set; }  
        public string? PurchaseStatus { get; set; }  
        public QuoteTransactionVehicle? QuoteTransactionVehicle { get; set; }
        public VehiclePurchaseDemand? VehiclePurchaseDemand { get; set; }
        public VehiclePurchaseDemandLine? VehiclePurchaseDemandLine { get; set; }
        public double? PoolKilometer { get; set; } 
        public bool? IsPoolKilometer { get; set; } 
    }
}