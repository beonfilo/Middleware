using Beon.MyBeon.Middleware.Models.BaseModels;

namespace Beon.MyBeon.Middleware.Models;

public class ProductBrand : BaseModel
{
	public DateTime CreatedOn { get; set; }
	public ApplicationUser? Owner { get; set; }
	public string Code { get; set; } = string.Empty;
	public string Name { get; set; } = string.Empty;
	public bool IsActive { get; set; } =default;
}
