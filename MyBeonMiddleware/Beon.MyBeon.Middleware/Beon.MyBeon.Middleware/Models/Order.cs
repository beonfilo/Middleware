using Beon.MyBeon.Middleware.Models.BaseModels;

namespace Beon.MyBeon.Middleware.Models
{
    public class Order : BaseModel
    {
        public string Status { get; set; } = string.Empty;
        public DateTime? CreatedOn { get; set; }
        //public ApplicationUser owner;
        public string Code { get; set; } = string.Empty;
        public Customer? Customer { get; set; }
        public DateTime? StartDate { get; set; }
        public Currency? Currency { get; set; }
        public Salesman? Salesman { get; set; }
        public int RevisionNumber { get; set; } = default;
        public double Total { get; set; } = default;
        public double TotalDiscount { get; set; } = default;
        public double TotalVat { get; set; } = default;
        public double NetTotal { get; set; } = default;
        public Quote? Quote { get; set; }
    }
}