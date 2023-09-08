using Beon.MyBeon.Middleware.Models.BaseModels;

namespace Beon.MyBeon.Middleware.Models
{
    public class VehicleBrandModelPackageYear  : BaseModel
    {
        public VehicleBrandModelPackage? VehicleBrandModelPackage { get; set; }
        public YearType? YearType { get; set; }
        public string EndYear { get; set; } = string.Empty;
        public HardwareTemplate? HardwareTemplate { get; set; }
        public double InsurancePolicyPrice { get; set; } = default;
    }
}
