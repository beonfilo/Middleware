using Beon.MyBeon.Middleware.Models.BaseModels;

namespace Beon.MyBeon.Middleware.Models
{
    public class VehicleBrandModelPackageGear : BaseModel
    {
        public VehicleBrandModelPackage? Package { get; set; }
        public GearType? GearType { get; set; }
        public int GearRange { get; set; } = default;
    }
}
