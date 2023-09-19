using Beon.MyBeon.Middleware.Models.BaseModels;

namespace Beon.MyBeon.Middleware.Models
{
    public class QuotePriceParameter : BaseModel
    {
        public VehicleBrand? Brand { get; set; }
        public VehicleBrandModel? Model { get; set; }
        public VehicleBrandModelPackage? Package { get; set; }
        public VehicleBrandModelPackageYear? Year { get; set; }
        public double Coefficient { get; set; } = default;//katsayı
        public double PurchasePrice { get; set; } = default;//satınalma fiyatı
        public double ValueOfvehicleInsurance { get; set; } = default;//kasko değeri
    }
}