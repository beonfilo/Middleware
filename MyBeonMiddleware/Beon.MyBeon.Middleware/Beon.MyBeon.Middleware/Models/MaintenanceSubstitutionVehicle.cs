using Beon.MyBeon.Middleware.Models.BaseModels;

namespace Beon.MyBeon.Middleware.Models
{
	public class MaintenanceSubstitutionVehicle : BaseSubstitutionVehicle
	{
		public MaintenanceDemand? Demand { get; set; }
	}
}