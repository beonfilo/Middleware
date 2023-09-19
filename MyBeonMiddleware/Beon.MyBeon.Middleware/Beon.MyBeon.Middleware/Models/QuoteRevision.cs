using Beon.MyBeon.Middleware.Models.BaseModels;

namespace Beon.MyBeon.Middleware.Models
{
    public class QuoteRevision : BaseModel
    {
        public string Code { get; set; } = string.Empty;
        public DateTime? CreatedOn { get; set; }
        //public ApplicationUser _owner{ get;set;}
        public Quote? Quote { get; set; }
        public int RevisionNumber { get; set; } = default;
        public QuoteRevision? PreviousRevision { get; set; }
    }
}