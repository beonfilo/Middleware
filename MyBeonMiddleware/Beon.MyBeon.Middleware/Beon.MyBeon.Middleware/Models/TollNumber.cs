using Beon.MyBeon.Middleware.Models.BaseModels;

namespace Beon.MyBeon.Middleware.Models;

public class TollNumber : BaseModel
{
    public DateTime? CreatedOn { get; set; }
    public ApplicationUser? Owner { get; set; }
    public string? Name { get; set; } 
    public string? LicenceNumber { get; set; } 
    public Vehicle? Vehicle { get; set; }
    public bool? IsActive { get; set; } 
}
