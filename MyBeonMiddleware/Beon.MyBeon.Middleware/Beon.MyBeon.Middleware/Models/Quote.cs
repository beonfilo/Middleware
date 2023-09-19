using Beon.MyBeon.Middleware.Models.BaseModels;

namespace Beon.MyBeon.Middleware.Models
{
    public class Quote : BaseModel
    {
        public DateTime? CreatedOn { get; set; }
        //public ApplicationUser _owner{ get;set;}
        public string Status { get; set; } = string.Empty;
        public string Code { get; set; } = string.Empty;
        public QuoteRevision? QuoteRevision { get; set; }
        public int RevisionNumber { get; set; } = default;
        public string CustomerType { get; set; } = string.Empty;
        public Customer? Customer { get; set; }
        public CustomerContact? CustomerContact { get; set; }
        public Lead? Lead { get; set; }
        public LeadContact? LeadContact { get; set; }
        public Opportunity? Opportunity { get; set; }
        public string DocumentNumber { get; set; } = string.Empty;
        public string DocumentTrackingNumber { get; set; } = string.Empty;
        public Salesman? Salesman { get; set; }
        public Currency? Currency { get; set; }
        public DateTime? DateOfValidity { get; set; }
        public string Description { get; set; } = string.Empty;
        public double Total { get; set; } = default;
        public double TotalDiscount { get; set; } = default;
        public double TotalVat { get; set; } = default;
        public double NetTotal { get; set; } = default;
        public ReasonForRejection? ReasonForRejection { get; set; }
        public DateTime? StatusChangeDate { get; set; }
        //public ApplicationUser StatusChanger { get; set; }
        public string RejectedDescription { get; set; } = string.Empty;
        public Contract? Contract { get; set; }
        public string Months { get; set; } = string.Empty;
        public string Kilometers { get; set; } = string.Empty;
        public string Factor { get; set; } = string.Empty;
    }
}