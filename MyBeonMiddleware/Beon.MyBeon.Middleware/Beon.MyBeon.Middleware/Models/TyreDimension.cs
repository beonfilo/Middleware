using Beon.MyBeon.Middleware.Models.BaseModels;

namespace Beon.MyBeon.Middleware.Models
{
    public class TyreDimension : BaseModel
    {
        public string Code { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public int Width { get; set; } = default;
        public int Height { get; set; } = default;
        public int Diameter { get; set; } = default;
        public bool IsActive { get; set; } = default;
    }
}
