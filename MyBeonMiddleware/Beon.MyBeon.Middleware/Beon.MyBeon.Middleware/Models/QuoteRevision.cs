using Beon.MyBeon.Middleware.Models.BaseModels;

namespace Beon.MyBeon.Middleware.Models
{
    public class QuoteRevision : BaseModel
    {
        public string? Code { get; set; } 
        public DateTime? CreatedOn { get; set; }
        public ApplicationUser? Owner { get; set; }
        public Quote? Quote { get; set; }
        public int? RevisionNumber { get; set; }  
        public QuoteRevision? PreviousRevision { get; set; }
    }
}