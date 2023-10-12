using Beon.MyBeon.Middleware.Models.BaseModels;

namespace Beon.MyBeon.Middleware.Models;

public class ProtocolApproveVehicle : BaseModel
{
    public ProtocolApprove? ProtocolApprove { get; set; }
    public Vehicle? Vehicle { get; set; }
    public ContractTransactionVehicle? ContractTransactionVehicle { get; set; }
    public ContractTransaction? ContractTransaction { get; set; }
    public Contract? Contract { get; set; }
    public Customer? Customer { get; set; }
    public int? MissingDay { get; set; } 
    public bool? IsMissing { get; set; } 

}
