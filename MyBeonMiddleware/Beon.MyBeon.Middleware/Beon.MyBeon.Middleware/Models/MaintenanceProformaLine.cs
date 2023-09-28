namespace Beon.MyBeon.Middleware.Models;

public class MaintenanceProformaLine : PurchaseProformaLine
{
	public MaintenanceProforma? Proforma { get; set; }
	public double DefinedDiscountRate { get; set; } = default;
	public bool IsDefault { get; set; } = default;
	public int LastTransactionKM { get; set; } = default;
	public DateTime LastTransactionOn { get; set; }
}
