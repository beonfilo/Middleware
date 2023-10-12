using Beon.MyBeon.Middleware.Models.BaseModels;

namespace Beon.MyBeon.Middleware.Models
{
    public class Order : BaseModel
    {
        public string? Status { get; set; } 
        public DateTime? CreatedOn { get; set; }
        public ApplicationUser? Owner { get; set; }
        public string? Code { get; set; } 
        public Customer? Customer { get; set; }
        public DateTime? StartDate { get; set; }
        public Currency? Currency { get; set; }
        public Salesman? Salesman { get; set; }
        public int? RevisionNumber { get; set; }  
        public double? Total { get; set; }  
        public double? TotalDiscount { get; set; }  
        public double? TotalVat { get; set; }  
        public double? NetTotal { get; set; }  
        public Quote? Quote { get; set; }
    }
}