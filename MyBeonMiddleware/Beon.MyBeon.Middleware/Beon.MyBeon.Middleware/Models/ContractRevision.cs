using Beon.MyBeon.Middleware.Models.BaseModels;

namespace Beon.MyBeon.Middleware.Models
{
    public class ContractRevision : BaseModel
    {
        public string Code { get; set; } = string.Empty;
        public DateTime? createdOn { get; set; }
        //public ApplicationUser owner{get;set;}
        public Contract? Contract { get; set; }
        public int RevisionNumber { get; set; } = default;
        public ContractRevision? PreviousRevision { get; set; }
    }
}