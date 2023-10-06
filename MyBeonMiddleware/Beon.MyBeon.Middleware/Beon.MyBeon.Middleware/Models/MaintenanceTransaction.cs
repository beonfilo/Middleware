using Beon.MyBeon.Middleware.Models.BaseModels;

namespace Beon.MyBeon.Middleware.Models;

public class MaintenanceTransaction : BaseFollowUpTransaction
{
	public string MaintenanceType { get; set; } = string.Empty;
	public AuthorizedServiceShop? AuthorizedServiceShop { get; set; }
	public AuthorizedServiceShopBranch? Branch { get; set; }
	public DateTime? MaintenanceDate { get; set; }
	public double Kilometer { get; set; } = default;
	public MaintenanceServiceCard? ServiceCard { get; set; }
	public MaintenanceInvoicePool? MaintenanceInvoicePool { get; set; }
	public MaintenanceWorkOrder? WorkOrder { get; set; }
	public MaintenanceProforma? Proforma { get; set; }
	public MaintenanceDemand? Demand { get; set; }
	public MaintenanceWorkOrderItem? MaintenanceWorkOrderItem { get; set; }
}
