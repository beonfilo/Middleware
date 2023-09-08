using Beon.MyBeon.Middleware.Models.BaseModels;
using System.Xml.Linq;

namespace Beon.MyBeon.Middleware.Models
{
    public class GearType : BaseModel
    {
        public string Name { get; set; } = string.Empty;
        public bool IsActive { get; set; } = default;
        public int GearRange { get; set; } = default;
    }
}
