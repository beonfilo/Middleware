using Beon.MyBeon.Middleware.Models.BaseModels;

namespace Beon.MyBeon.Middleware.Models
{
	public class MaintenanceCategory : BaseModel
	{
		public DateTime CreatedOn { get; set; } =DateTime.Now;
		//public ApplicationUser _owner;
		public string Name { get; set; } = string.Empty;
		public double StartKilometer { get; set; } = default;
		public double EndKilometer { get; set; } = default;
	}
}