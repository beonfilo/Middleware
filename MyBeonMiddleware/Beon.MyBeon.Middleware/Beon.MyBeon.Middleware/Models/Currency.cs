using Beon.MyBeon.Middleware.Models.BaseModels;

namespace Beon.MyBeon.Middleware.Models;

public class Currency : BaseModel
{
    //public int ReferenceId { get; set; }
    public string Symbol { get; set; } = string.Empty;
    public string Name { get; set; } = string.Empty;
    public string Code { get; set; } = string.Empty;
    public int CurrType { get; set; } = default; //logo işlemleri bunun üzerinden yapıyor
}
