using Beon.MyBeon.Middleware.Models.BaseModels;

namespace Beon.MyBeon.Middleware.Models;

public class MaintenanceTransaction : BaseFollowUpTransaction
{
	public string? MaintenanceType { get; set; }

    public string MaintenanceTypeName
    {
        get
        {

            switch (MaintenanceType)
            {
                case "Periodic":
                    return "Periyodik Bakım";
                case "Breakdown":
                    return "Arıza Bakım";
                case "PeriodicAndBreakdown":
                    return "Periyodik ve Arıza Bakım";
                default:
                    return "Diğer";
            }
        }
    }
    public AuthorizedServiceShop? AuthorizedServiceShop { get; set; }
	public AuthorizedServiceShopBranch? Branch { get; set; }
	public DateTime? MaintenanceDate { get; set; }
	public double? Kilometer { get; set; } 
	public MaintenanceServiceCard? ServiceCard { get; set; }
	public MaintenanceInvoicePool? MaintenanceInvoicePool { get; set; }
	public MaintenanceWorkOrder? WorkOrder { get; set; }
	public MaintenanceProforma? Proforma { get; set; }
	public MaintenanceDemand? Demand { get; set; }
	public MaintenanceWorkOrderItem? MaintenanceWorkOrderItem { get; set; }
}
