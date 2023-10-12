using Beon.MyBeon.Middleware.Models.BaseModels;

namespace Beon.MyBeon.Middleware.Models
{
	public class SupplierBranch : BaseBranch
	{
		public string? SupplierBranchCardType { get; set; }  
		public Supplier? Supplier { get; set; }
	}
}