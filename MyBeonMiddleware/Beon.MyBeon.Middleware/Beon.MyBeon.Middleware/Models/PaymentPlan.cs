using Beon.MyBeon.Middleware.Models.BaseModels;

namespace Beon.MyBeon.Middleware.Models
{
	public class PaymentPlan : BaseModel
	{
		public string Code { get; set; } = string.Empty;
		public string Name { get; set; } = string.Empty;
		public string Description { get; set; } = string.Empty;
		public bool IsActive { get; set; } = false;
		public string IntegrationResult { get; set; } = string.Empty;
	}
}
