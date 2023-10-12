using Beon.MyBeon.Middleware.Models.BaseModels;

namespace Beon.MyBeon.Middleware.Models;

public class Currency : BaseModel
{
    public string? Symbol { get; set; }
    public string? Name { get; set; }
    public string? Code { get; set; }
    public int? CurrType { get; set; }
}
