namespace Beon.MyBeon.Middleware.Models;

public class DamageDemandContact
{
    public DamageDemand? Demand{ get; set; }
    public int LineNumber { get; set; } = default;
    public  Contact? Concant { get; set; }
    public string Plate { get; set; } = string.Empty;
}
