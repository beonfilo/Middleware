using Beon.MyBeon.Middleware.Models.BaseModels;

namespace Beon.MyBeon.Middleware.Models
{
    public class QuotePriceParameter : BaseModel
    {
        public VehicleBrand? Brand { get; set; }
        public VehicleBrandModel? Model { get; set; }
        public VehicleBrandModelPackage? Package { get; set; }
        public VehicleBrandModelPackageYear? Year { get; set; }
        public double? Coefficient { get; set; } //katsayı
        public double? PurchasePrice { get; set; } //satınalma fiyatı
        public double? ValueOfvehicleInsurance { get; set; } //kasko değeri
    }
}