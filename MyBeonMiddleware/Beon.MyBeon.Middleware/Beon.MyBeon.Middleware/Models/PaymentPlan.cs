using Beon.MyBeon.Middleware.Models.BaseModels;

namespace Beon.MyBeon.Middleware.Models
{
    public class PaymentPlan : BaseModel
	{
		public string? Code { get; set; } 
		public string? Name { get; set; } 
		public string? Description { get; set; } 
		public bool? IsActive { get; set; } = false;
		public string? IntegrationResult { get; set; } 
	}
}
