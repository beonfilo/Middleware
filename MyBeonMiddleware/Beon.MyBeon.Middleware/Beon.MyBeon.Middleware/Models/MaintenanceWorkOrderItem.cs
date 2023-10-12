using Beon.MyBeon.Middleware.Models.BaseModels;

namespace Beon.MyBeon.Middleware.Models;

public class MaintenanceWorkOrderItem : BaseModel
{
    public MaintenanceWorkOrder? WorkOrder { get; set; }
    public string? CardType { get; set; }  
    public BaseItem? Item { get; set; }
    public Unitset? Unitset { get; set; }
    public SubUnitset? SubUnitset { get; set; }
    public double? Quantity { get; set; }  
    public string? Description { get; set; }  
    public MaintenanceProformaLine? ProformaLine { get; set; }
}
