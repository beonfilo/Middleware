using Beon.MyBeon.Middleware.Models.BaseModels;

namespace Beon.MyBeon.Middleware.Models
{
	public class MaintenanceAppointment : BaseAppointment
	{
		public MaintenanceDemand? Demand { get;set; }
		public MaintenanceProforma? Proforma { get; set; }
		public AuthorizedServiceShop? DemandedServiceShop { get; set; }

		public string ServiceShopType { get; set; } = string.Empty;
		public string ContractType { get; set; } = string.Empty;
		public AuthorizedServiceShop? AuthorizedServiceShop { get; set; }
		public AuthorizedServiceShopBranch? Branch { get; set; }
	}
}