using Beon.MyBeon.Middleware.Models.BaseModels;

namespace Beon.MyBeon.Middleware.Models;

public class TollNumber : BaseModel
{
    public DateTime CreatedOn { get; set; }
    //public ApplicationUser _owner;
    public string Name { get; set; } = string.Empty;
    public string LicenceNumber { get; set; } = string.Empty;
    public Vehicle? Vehicle { get; set; }
    public bool IsActive { get; set; } = default;
}
