using Beon.MyBeon.Middleware.Models.BaseModels;

namespace Beon.MyBeon.Middleware.Models
{
    public class Quote : BaseModel
    {
        public DateTime? CreatedOn { get; set; }
        public ApplicationUser? Owner { get; set; }
        public string? Status { get; set; }
        public string? Code { get; set; }
        public QuoteRevision? QuoteRevision { get; set; }
        public int? RevisionNumber { get; set; }
        public string? CustomerType { get; set; }
        public Customer? Customer { get; set; }
        public CustomerContact? CustomerContact { get; set; }
        public Lead? Lead { get; set; }
        public LeadContact? LeadContact { get; set; }
        public Opportunity? Opportunity { get; set; }
        public string? DocumentNumber { get; set; }
        public string? DocumentTrackingNumber { get; set; }
        public Salesman? Salesman { get; set; }
        public Currency? Currency { get; set; }
        public DateTime? DateOfValidity { get; set; }
        public string? Description { get; set; }
        public double? Total { get; set; }
        public double? TotalDiscount { get; set; }
        public double? TotalVat { get; set; }
        public double? NetTotal { get; set; }
        public ReasonForRejection? ReasonForRejection { get; set; }
        public DateTime? StatusChangeDate { get; set; }
        public ApplicationUser? StatusChanger { get; set; }
        public string? RejectedDescription { get; set; }
        public Contract? Contract { get; set; }
        public string? Months { get; set; }
        public string? Kilometers { get; set; }
        public string? Factor { get; set; }
    }
}