using Beon.MyBeon.Middleware.Models.BaseModels;

namespace Beon.MyBeon.Middleware.Models
{
    public class PurchaseProforma : BaseProforma
	{
		public string? SupplierCardType { get; set; } 
		public string? PurchaseProformaModuleType { get; set; }  
		public Supplier? Supplier { get; set; }
		public SupplierContact? SupplierContact { get; set; } 
		public PurchaseServiceCard? PurchaseServiceCard { get; set; }
		public double? ChargeoutTotal { get; set; }  
	}
}