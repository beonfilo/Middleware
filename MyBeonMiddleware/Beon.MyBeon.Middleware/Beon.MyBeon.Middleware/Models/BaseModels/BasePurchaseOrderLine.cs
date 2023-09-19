namespace Beon.MyBeon.Middleware.Models.BaseModels
{
    public class BasePurchaseOrderLine : BaseModel
    {
        public string TargetType { get; set; } = string.Empty;
        public BasePurchaseOrder? BasePurchaseOrder { get; set; }
        public int LineNumber { get; set; } = default;
        public string Code { get; set; } = string.Empty;
        public DateTime? DueDate { get; set; }
        public double Quantity { get; set; } = default;
        public double UnitPrice { get; set; } = default;
        public Currency? Currency { get; set; }
        public string VatType { get; set; } = string.Empty;
        public int VatRate { get; set; } = default;
        public string DiscountType { get; set; } = string.Empty;
        public double Discount { get; set; } = default;
        public double Total { get; set; } = default;
        public double TotalDiscount { get; set; } = default;
        public double TotalVat { get; set; } = default;
        public double LineNet { get; set; } = default;
        public string Description { get; set; } = string.Empty;
    }
}
