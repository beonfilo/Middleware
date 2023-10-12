using Beon.MyBeon.Middleware.Models.BaseModels;

namespace Beon.MyBeon.Middleware.Models;

public class Position : BaseModel
{
    public string? Code { get; set; }  
    public string? Name { get; set; }  
    public string? Description { get; set; }  
    public bool? IsActive { get; set; } 
    public Department? Department { get; set; }
}
