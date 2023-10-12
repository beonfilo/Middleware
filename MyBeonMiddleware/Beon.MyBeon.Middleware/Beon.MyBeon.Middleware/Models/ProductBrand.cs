using Beon.MyBeon.Middleware.Models.BaseModels;

namespace Beon.MyBeon.Middleware.Models;

public class ProductBrand : BaseModel
{
	public DateTime CreatedOn { get; set; }
	public ApplicationUser? Owner { get; set; }
	public string? Code { get; set; }  
	public string? Name { get; set; }  
	public bool? IsActive { get; set; }  
}
