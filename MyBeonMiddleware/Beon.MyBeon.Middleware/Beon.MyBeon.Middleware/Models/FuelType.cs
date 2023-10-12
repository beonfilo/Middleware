using Beon.MyBeon.Middleware.Models.BaseModels;

namespace Beon.MyBeon.Middleware.Models
{
    public class FuelType : BaseModel
    {
        public string? Name { get; set; } 
        public bool? IsActive { get; set; }  
    }
}
