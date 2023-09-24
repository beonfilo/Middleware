using Beon.MyBeon.Middleware.Models.BaseModels;

namespace Beon.MyBeon.Middleware.Models;

public class ApplicationUser : BaseModel
{
    public string Code { get; set; } = string.Empty;
    public string TCKN { get; set; } = string.Empty;
    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
    public string Telephone { get; set; } = string.Empty;
    public string OtherTelephone { get; set; }=string.Empty;
    public string WebAddress { get; set; } = string.Empty;
    public string EMail { get; set; } = string.Empty;
    public MediaDataObject? Image { get; set; }
    public bool IsActive { get; set; }
    public string UserName { get; set; } = string.Empty;
    public string StoredPassword { get; set; } = string.Empty;
}
