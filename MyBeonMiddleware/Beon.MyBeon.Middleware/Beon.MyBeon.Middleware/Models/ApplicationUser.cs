using Beon.MyBeon.Middleware.Models.BaseModels;

namespace Beon.MyBeon.Middleware.Models;

public class ApplicationUser : BaseModel
{
    public string? Code { get; set; }
    public string? TCKN { get; set; }
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public string? Telephone { get; set; }
    public string? OtherTelephone { get; set; }
    public string? WebAddress { get; set; }
    public string? EMail { get; set; }
    public MediaDataObject? Image { get; set; }
    public bool? IsActive { get; set; }
    public string? UserName { get; set; }
    public string? StoredPassword { get; set; }
    public Customer? Customer { get; set; }
    public CustomerContact? CustomerContact { get; set; }
}
