using Beon.MyBeon.Middleware.Models.BaseModels;

namespace Beon.MyBeon.Middleware.Models
{
    public class VehicleBrandModel : VehicleCatalog
    {
        public VehicleBrand? Brand { get; set; } 
        public BrandType? BrandType { get; set; } 
        public BrandModelType? ModelType { get; set; }
        public VehicleType? VehicleType { get; set; } 
        public SegmentType? SegmentType { get; set; } 
        public double? DeclarationLimit { get; set; }  
        public bool? IsActive { get; set; }  
    }
}
