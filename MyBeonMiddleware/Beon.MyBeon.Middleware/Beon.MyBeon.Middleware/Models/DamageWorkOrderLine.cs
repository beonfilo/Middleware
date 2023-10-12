using Beon.MyBeon.Middleware.Models.BaseModels;

namespace Beon.MyBeon.Middleware.Models
{
    public class DamageWorkOrderLine : BaseModel
    {
        public DamageWorkOrder? WorkOrder { get; set; }
        public int? LineNumber { get; set; }
        public string? CardType { get; set; }
        public string? PurchaseProformaLineCardType { get; set; }
        public BaseItem? BaseItem { get; set; }
        public double? Quantity { get; set; }
        public Unitset? Unitset { get; set; }
        public SubUnitset? SubUnitset { get; set; }
        public double? UnitPrice { get; set; }
        public double? Total { get; set; }
        public double? Vat { get; set; }
        public double? TotalVat { get; set; }
        public double? NetTotal { get; set; }
        public string? ChargeoutStatus { get; set; }
        public double? ChargeoutPrice { get; set; }
    }
}
