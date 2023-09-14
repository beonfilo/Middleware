using Beon.MyBeon.Middleware.Models.BaseModels;

namespace Beon.MyBeon.Middleware.Models
{
	public class SupplierBranch : BaseBranch
	{
		public string SupplierBranchCardType { get; set; } = string.Empty;
		public Supplier? Supplier { get; set; }
	}
}