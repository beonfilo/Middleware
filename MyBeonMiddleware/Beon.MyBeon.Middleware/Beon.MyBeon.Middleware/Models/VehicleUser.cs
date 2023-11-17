using Beon.MyBeon.Middleware.Models.BaseModels;

namespace Beon.MyBeon.Middleware.Models;

public class VehicleUser : BaseContact
{
	public Customer? Customer {  get; set; }	
}
