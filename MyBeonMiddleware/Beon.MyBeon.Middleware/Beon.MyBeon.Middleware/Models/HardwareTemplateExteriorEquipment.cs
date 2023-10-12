using Beon.MyBeon.Middleware.Models.BaseModels;

namespace Beon.MyBeon.Middleware.Models
{
    public class HardwareTemplateExteriorEquipment : BaseModel
    {
        public HardwareTemplate? HardwareTemplate { get; set; }
        public ExteriorEquipmentType? ExteriorEquipmentType { get; set; }
        public string? HardwareStatus { get; set; }
    }
}
