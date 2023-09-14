using Beon.MyBeon.Middleware.Models.BaseModels;

namespace Beon.MyBeon.Middleware.Models
{
	public class AppointmentRejectReason : BaseModel
	{

		public DateTime CreatedOn { get; set; } = DateTime.Now;
		//public ApplicationUser _owner;
		public string Name { get; set; } = string.Empty;
		public bool IsActive { get;set; } = false;
	}
}
