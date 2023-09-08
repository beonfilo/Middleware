using Beon.MyBeon.Middleware.Models.BaseModels;

namespace Beon.MyBeon.Middleware.Models;

public class TollPoint : BaseModel
{
    public DateTime CreatedOn { get; set; }
    //public ApplicationUser _owner;
    public City? City { get; set; }
    public County? County { get; set; }
    public string Name { get; set; } = string.Empty;
}
