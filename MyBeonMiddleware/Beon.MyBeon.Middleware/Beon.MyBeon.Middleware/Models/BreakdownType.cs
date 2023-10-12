using Beon.MyBeon.Middleware.Models.BaseModels;

namespace Beon.MyBeon.Middleware.Models;

public class BreakdownType : BaseModel
{
    public BreakdownType? BreakdownLocation { get; set; }
    public string? Name { get; set; }

}
