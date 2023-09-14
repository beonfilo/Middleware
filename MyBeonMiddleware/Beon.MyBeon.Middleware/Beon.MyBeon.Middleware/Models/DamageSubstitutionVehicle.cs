using Beon.MyBeon.Middleware.Models.BaseModels;

namespace Beon.MyBeon.Middleware.Models
{
	public class DamageSubstitutionVehicle : BaseSubstitutionVehicle
	{
		public DamageDemand? Demand { get; set; }
	}
}