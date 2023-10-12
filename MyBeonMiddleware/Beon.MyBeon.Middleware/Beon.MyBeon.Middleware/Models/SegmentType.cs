using Beon.MyBeon.Middleware.Models.BaseModels;

namespace Beon.MyBeon.Middleware.Models
{
    public class SegmentType : BaseModel
    {
        public string? Name { get; set; } 
        public string? Description { get; set; } 
        public bool? IsActive { get; set; } 
    }
}
