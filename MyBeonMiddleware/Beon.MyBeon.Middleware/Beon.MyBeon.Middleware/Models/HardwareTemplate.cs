using Beon.MyBeon.Middleware.Models.BaseModels;

namespace Beon.MyBeon.Middleware.Models
{
    public class HardwareTemplate : BaseModel
    {
        public VehicleBrand? Brand { get; set; }
        public VehicleBrandModel? Model { get; set; }
        public VehicleBrandModelPackage? Package { get; set; }
        public VehicleBrandModelPackageYear? ModelYear { get; set; }
        public bool? IsActive { get; set; }
    }
}
