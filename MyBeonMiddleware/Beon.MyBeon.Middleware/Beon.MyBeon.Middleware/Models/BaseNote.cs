using Beon.MyBeon.Middleware.Models.BaseModels;

namespace Beon.MyBeon.Middleware.Models;

public class BaseNote : BaseModel
{
    public string? NoteType { get; set; } 
    public  DateTime? CreatedOn{ get; set; }
    public ApplicationUser? Owner { get; set; }
    public string? Priority { get; set; }  
    public string? Topic { get; set; } 
    public string? Description { get; set; }  


}
