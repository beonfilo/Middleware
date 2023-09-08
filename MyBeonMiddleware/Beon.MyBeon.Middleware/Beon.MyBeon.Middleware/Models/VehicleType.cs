using Beon.MyBeon.Middleware.Models.BaseModels;

namespace Beon.MyBeon.Middleware.Models
{
    public class VehicleType : BaseModel
    {
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public int InspectionFrequency { get; set; } = default; //muayene sıklığı ay
        public bool IsActive { get; set; } = default;
    }
}
