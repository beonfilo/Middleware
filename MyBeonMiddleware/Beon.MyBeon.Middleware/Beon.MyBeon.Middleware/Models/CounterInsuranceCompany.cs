using Beon.MyBeon.Middleware.Models.BaseModels;

namespace Beon.MyBeon.Middleware.Models
{
	public class CounterInsuranceCompany : BaseModel
	{
		public string Title { get; set; } = string.Empty;
		public string Telephone { get; set; } = string.Empty;
		public string Email { get; set; } = string.Empty;
	}
}