using System.Reflection.Metadata;

namespace Beon.MyBeon.Middleware.Models.BaseModels;

public class BaseContact : BaseModel
{
    public string Name { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
    public string Position { get; set; } = string.Empty;
    public string Telephone { get; set; } = string.Empty;
    public string OtherTelephone { get; set; } = string.Empty;
    public string TCKN { get; set; } = string.Empty;
    public string EMail { get; set; } = string.Empty;
    public string AuthorizedPerson { get; set; } = string.Empty;
    public string Address { get; set; } = string.Empty;
    public bool IsActive { get; set; } = default;
}
