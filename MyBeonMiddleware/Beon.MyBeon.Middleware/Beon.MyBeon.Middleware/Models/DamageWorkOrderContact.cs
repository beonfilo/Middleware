namespace Beon.MyBeon.Middleware.Models;
public class DamageWorkOrderContact
{
    public DamageWorkOrder  WorkOrder{ get; set; }
    public int  LineNumber{ get; set; }
    public Contact Contact { get; set; }
    public string Plate { get; set; }
    public DamageDemandContact DamageDemandContact{ get; set; }
}
