using Beon.MyBeon.Middleware.Models.BaseModels;

namespace Beon.MyBeon.Middleware.Models;

public class Roadway : BaseModel
{
    public DateTime? CreatedOn { get; set; }
    //public ApplicationUser Owner;
    public City? City { get; set; }
    public County? County { get; set; }
    public string Name{get; set;} = string.Empty;
}
