using Beon.MyBeon.Middleware.Models.BaseModels;

namespace Beon.MyBeon.Middleware.Models
{
    public class VehiclePlate : BaseModel
    {
        public string? Plate { get; set; }  
        public Vehicle? Vehicle { get; set; } 
        public bool? IsActive { get; set; }  
    }
}
