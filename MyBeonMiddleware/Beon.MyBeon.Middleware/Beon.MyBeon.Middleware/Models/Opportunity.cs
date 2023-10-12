using Beon.MyBeon.Middleware.Models.BaseModels;

namespace Beon.MyBeon.Middleware.Models
    {
    public class Opportunity : BaseModel
    {
        public string? Status { get; set; } 
        public string? Code { get; set; } 
        public string? Topic { get; set; } 
        public Customer? Customer { get; set; }
        public DateTime? CreatedOn { get; set; }
        public ApplicationUser? Owner { get; set; }
        public DateTime? EstimatedCloseDate { get; set; }
        public decimal? EstimatedRevenue { get; set; } 
        public int? EstimatedNumberOfVehicles { get; set; } 
        public int? ActualNumberOfVehicles { get; set; } 
        public Currency? Currency { get; set; }
        public int? Probability { get; set; } 
        public string? Raiting { get; set; } 
        public string? CurrentSituation { get; set; } 
        public string? CustomerNeed { get; set; } 
        public string? ProposedSolution { get; set; } 
        public string? Description { get; set; } 
        public decimal? ActualRevenue { get; set; } 
        public DateTime? CloseDate { get; set; }
        public ApplicationUser? ClosedBy{ get;set;}
        public string? StatusDescription { get; set; } 
        public string? StatusReason { get; set; } 
        public Quote? Quote { get; set; }
        public Lead? Lead { get; set; }
        public string? CustomerType { get; set; } 
        public string? Months { get; set; } 
        public string? Kilometers { get; set; } 
        public ReasonForRejectionOpportunity? ReasonForRejection { get; set; }
    }
}