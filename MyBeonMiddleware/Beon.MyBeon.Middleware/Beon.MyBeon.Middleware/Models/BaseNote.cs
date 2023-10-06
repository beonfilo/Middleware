using Beon.MyBeon.Middleware.Models.BaseModels;

namespace Beon.MyBeon.Middleware.Models;

public class BaseNote : BaseModel
{
    public string NoteType { get; set; } = string.Empty;
    public  DateTime CreatedOn{ get; set; }
    public ApplicationUser? Owner { get; set; }
    public string Priority { get; set; } = string.Empty;
    public string Topic { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;


}
