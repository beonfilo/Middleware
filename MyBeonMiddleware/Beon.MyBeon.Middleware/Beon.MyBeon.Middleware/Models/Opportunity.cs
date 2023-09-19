using Beon.MyBeon.Middleware.Models.BaseModels;

namespace Beon.MyBeon.Middleware.Models
{
    public class Opportunity : BaseModel
    {
        public string Status { get; set; } =string.Empty;
        public string Code { get; set; } = string.Empty;
        public string Topic { get; set; } = string.Empty;
        public Customer? Customer { get; set; }
        public DateTime? CreatedOn { get; set; }
        //public ApplicationUser _owner{ get;set;}
        public DateTime? EstimatedCloseDate { get; set; }
        public decimal EstimatedRevenue { get; set; } = default;
        public int EstimatedNumberOfVehicles { get; set; } = default;
        public int ActualNumberOfVehicles { get; set; } = default;
        public Currency? Currency { get; set; }
        public int Probability { get; set; } = default;
        public string Raiting { get; set; } = string.Empty;
        public string CurrentSituation { get; set; } = string.Empty;
        public string CustomerNeed { get; set; } = string.Empty;
        public string ProposedSolution { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public decimal ActualRevenue { get; set; } = default;
        public DateTime? CloseDate { get; set; }
        //public ApplicationUser _closedBy{ get;set;}
        public string StatusDescription { get; set; } = string.Empty;
        public string StatusReason { get; set; } = string.Empty;
        public Quote? Quote { get; set; }
        public Lead? Lead { get; set; }
        public string CustomerType { get; set; } = string.Empty;

        public string Months { get; set; } = string.Empty;
        public string Kilometers { get; set; } = string.Empty;
        public ReasonForRejectionOpportunity? ReasonForRejection { get; set; }
    }
}