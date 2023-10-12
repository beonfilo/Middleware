using Beon.MyBeon.Middleware.Models.BaseModels;

namespace Beon.MyBeon.Middleware.Models;

public class CleaningDemand : BaseModel
{
    public string? Status { get; set; }
    public DateTime? CreatedOn{ get; set; }
    public ApplicationUser? Owner{ get; set; }
    public string? Code{ get; set; }
    public Vehicle? Vehicle{ get; set; }
    public CleaningType? CleaningType{ get; set; }
    public CleaningCause? CleaningCause{ get; set; }

    public Contract? Contract{ get; set; }//sözleşme
    public ContractTransaction? ContractTransaction{ get; set; }//sipariş
    public ContractTransactionVehicle? ContractTransactionVehicle{ get; set; }//araç
    public Customer? Customer{ get; set; }
    public CustomerContact? CustomerContact{ get; set; }
}
