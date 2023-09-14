using Beon.MyBeon.Middleware.Models.BaseModels;

namespace Beon.MyBeon.Middleware.Models
{
	public class PeriodicMaintenanceParameter : BaseModel
	{
		public VehicleBrand? Brand { get; set; }
		public VehicleBrandModel? Model { get; set; }
		public MotorType? Motor { get; set; }

		public MaintenanceCategory? MaintenanceCategory { get; set; }

		public double StartKilometer { get; set; } = default;
		public double EndKilometer { get; set; } = default;
	}
}