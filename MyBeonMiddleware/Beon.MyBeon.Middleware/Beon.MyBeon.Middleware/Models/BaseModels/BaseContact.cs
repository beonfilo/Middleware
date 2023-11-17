using System.Reflection.Metadata;

namespace Beon.MyBeon.Middleware.Models.BaseModels;

public class BaseContact : BaseModel
{
    public string Name { get; set; } = string.Empty;
    public string Lastname { get; set; } = string.Empty;
    public string Position { get; set; } = string.Empty;
	public Country? Country { get; set; }
	public City? City {  get; set; }
	public County? County {  get; set; }
	public string Telephone { get; set; } = string.Empty;
    public string OtherTelephone { get; set; } = string.Empty;
    public string TCKN { get; set; } = string.Empty;
    public string EMail { get; set; } = string.Empty;
    public string AuthorizedPerson { get; set; } = string.Empty;
    public string Address { get; set; } = string.Empty;
    public bool IsActive { get; set; } = default;
}
