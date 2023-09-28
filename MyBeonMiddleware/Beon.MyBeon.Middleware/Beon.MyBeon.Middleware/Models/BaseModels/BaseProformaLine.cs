namespace Beon.MyBeon.Middleware.Models.BaseModels;

public class BaseProformaLine : BaseModel
{
	public string BaseProformaModuleType { get; set; } = string.Empty;
	public BaseProforma? BaseProforma { get; set; }	
	public int LineNumber { get; set; } = default;
	public string CardType { get; set; } = string.Empty;
	public BaseItem? BaseItem { get; set; }
	public Unitset? Unitset { get; set; }
	public SubUnitset? SubUnitset { get; set; }
	public double Quantity { get; set; } = default;
	public double UnitPrice { get; set; } = default;
	public double VatRate { get; set; } = default;
	public double Total { get; set; } = default;
	public string DiscountType { get; set; } = string.Empty;
	public double Discount { get; set; } = default;
	public double TotalDiscount { get; set; } = default;
	public double TotalVat { get; set; } = default;
	public double NetTotal { get; set; } = default;
	public string Description { get; set; } = string.Empty;
	public ProformaRevision? ProformaRevision { get; set; }
}
