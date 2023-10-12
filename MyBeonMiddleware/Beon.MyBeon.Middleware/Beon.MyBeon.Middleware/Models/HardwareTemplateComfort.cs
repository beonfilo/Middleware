using Beon.MyBeon.Middleware.Models.BaseModels;

namespace Beon.MyBeon.Middleware.Models
{
    public class HardwareTemplateComfort : BaseModel
    {
        public HardwareTemplate? HardwareTemplate { get; set; }
        public ComfortType? ComfortType { get; set; }
        public string? HardwareStatus { get; set; }
    }
}
