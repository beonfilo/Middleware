using Beon.MyBeon.Middleware.Models.BaseModels;

namespace Beon.MyBeon.Middleware.Models
{
    public class VehicleType : BaseModel
    {
        public string? Name { get; set; }  
        public string? Description { get; set; }  
        public int? InspectionFrequency { get; set; }   //muayene sıklığı ay
        public bool? IsActive { get; set; }  
    }
}
