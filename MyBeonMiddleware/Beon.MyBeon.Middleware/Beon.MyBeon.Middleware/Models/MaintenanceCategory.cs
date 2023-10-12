using Beon.MyBeon.Middleware.Models.BaseModels;

namespace Beon.MyBeon.Middleware.Models
{
    public class MaintenanceCategory : BaseModel
	{
		public DateTime? CreatedOn { get; set; } 
		public ApplicationUser? Owner { get; set; }
		public string? Name { get; set; } 
		public double? StartKilometer { get; set; } 
		public double? EndKilometer { get; set; }  
	}
}