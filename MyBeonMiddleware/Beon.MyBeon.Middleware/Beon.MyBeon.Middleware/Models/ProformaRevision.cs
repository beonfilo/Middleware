using Beon.MyBeon.Middleware.Models.BaseModels;

namespace Beon.MyBeon.Middleware.Models
{
    public class ProformaRevision : BaseModel
    {
        public DateTime? CreatedOn { get; set; }
        public ApplicationUser? Owner { get; set; }
        public string? Code { get; set; }
        public int? RevisionNumber { get; set; }
        public BaseProforma? BaseProforma { get; set; }
        public ProformaRevision? PreviousRevision { get; set; }
    }
}
