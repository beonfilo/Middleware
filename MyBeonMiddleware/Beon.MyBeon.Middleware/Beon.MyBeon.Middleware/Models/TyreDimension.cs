using Beon.MyBeon.Middleware.Models.BaseModels;

namespace Beon.MyBeon.Middleware.Models
{
    public class TyreDimension : BaseModel
    {
        public string? Code { get; set; }  
        public string? Name { get; set; }  
        public int? Width { get; set; }  
        public int? Height { get; set; }  
        public int? Diameter { get; set; }  
        public bool? IsActive { get; set; }  
    }
}
