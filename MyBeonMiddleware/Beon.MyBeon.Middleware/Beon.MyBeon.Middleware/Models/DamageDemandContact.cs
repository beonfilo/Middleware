using Beon.MyBeon.Middleware.Models.BaseModels;

namespace Beon.MyBeon.Middleware.Models;

public class DamageDemandContact : BaseModel
{
    public DamageDemand? Demand{ get; set; }
    public int? LineNumber { get; set; }  
    public  Contact? Concant { get; set; }
    public string? Plate { get; set; } 
}
