using Beon.MyBeon.Middleware.Models.BaseModels;

namespace Beon.MyBeon.Middleware.Models
{
    public class ContractTransactionVehicleRevision : BaseModel
    {
        public string? Code { get; set; }
        public DateTime? CreatedOn { get; set; }
        public ApplicationUser? Owner { get; set; }
        public ContractTransactionVehicle? ContractTransactionVehicle { get; set; }
        public int? RevisionNumber { get; set; }
        public ContractTransactionVehicleRevision? PreviousRevision { get; set; }
    }
}