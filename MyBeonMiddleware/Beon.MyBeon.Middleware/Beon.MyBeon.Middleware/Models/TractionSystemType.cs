using Beon.MyBeon.Middleware.Models.BaseModels;

namespace Beon.MyBeon.Middleware.Models
{
    public class TractionSystemType : BaseModel
    {
        public string Name { get; set; } = string.Empty;
        public bool IsActive { get; set; } = default;
    }
}
