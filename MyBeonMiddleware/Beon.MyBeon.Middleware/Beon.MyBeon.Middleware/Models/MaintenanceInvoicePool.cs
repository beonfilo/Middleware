using Beon.MyBeon.Middleware.Models.BaseModels;

namespace Beon.MyBeon.Middleware.Models;

public class MaintenanceInvoicePool : BaseInvoicePool
{
	public MaintenanceTransaction? MaintenanceTransaction { get; set; }
	public MaintenanceWorkOrder? WorkOrder { get; set; }
	public MaintenanceServiceCard? ServiceCard { get; set; }
}
