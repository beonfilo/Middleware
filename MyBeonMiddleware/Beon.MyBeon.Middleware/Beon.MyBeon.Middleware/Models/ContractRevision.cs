using Beon.MyBeon.Middleware.Models.BaseModels;

namespace Beon.MyBeon.Middleware.Models
{
    public class ContractRevision : BaseModel
    {
        public string? Code { get; set; }
        public DateTime? createdOn { get; set; }
        public ApplicationUser? owner { get; set; }
        public Contract? Contract { get; set; }
        public int? RevisionNumber { get; set; }
        public ContractRevision? PreviousRevision { get; set; }
    }
}