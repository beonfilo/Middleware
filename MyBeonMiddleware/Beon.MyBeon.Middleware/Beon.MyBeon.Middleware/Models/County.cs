using Beon.MyBeon.Middleware.Models.BaseModels;

namespace Beon.MyBeon.Middleware.Models;

public class County : BaseModel
{
    public City? City { get; set; }
    public string? Code { get; set; }  
    public string? Name { get; set; }  
}
