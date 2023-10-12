namespace Beon.MyBeon.Middleware.Models;

public class MaintenanceProformaLine : PurchaseProformaLine
{
	public MaintenanceProforma? Proforma { get; set; }
	public double? DefinedDiscountRate { get; set; }  
	public bool? IsDefault { get; set; }  
	public int? LastTransactionKM { get; set; } 
	public DateTime? LastTransactionOn { get; set; }
}
