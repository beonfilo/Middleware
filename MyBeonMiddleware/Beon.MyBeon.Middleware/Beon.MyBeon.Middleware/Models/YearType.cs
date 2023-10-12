using Beon.MyBeon.Middleware.Models.BaseModels;

namespace Beon.MyBeon.Middleware.Models
{
    public class YearType : BaseModel
    {
        public string? Name { get; set; }  
        public bool? IsActive { get; set; }  
    }
}
