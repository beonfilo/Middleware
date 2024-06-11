using Beon.MyBeon.Middleware.Models.BaseModels;

namespace Beon.MyBeon.Middleware.Models;

public class VehicleUserAssign : BaseModel
{
    public Vehicle? Vehicle{ get; set; }
    public Customer? Customer{ get; set; }
    public VehicleUser? VehicleUser{ get; set; }
}
