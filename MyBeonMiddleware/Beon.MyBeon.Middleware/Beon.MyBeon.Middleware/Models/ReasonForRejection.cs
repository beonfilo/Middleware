using Beon.MyBeon.Middleware.Models.BaseModels;

namespace Beon.MyBeon.Middleware.Models
{
	public class ReasonForRejection : BaseModel
	{
		public DateTime? CreatedOn { get; set; }
		//public ApplicationUser _owner;
		public string TargetType { get; set; } = string.Empty;
		public string Name { get; set; } = string.Empty;
		public string Description { get; set; } = string.Empty;
		public bool IsActive { get; set; } = false;
	}
}
