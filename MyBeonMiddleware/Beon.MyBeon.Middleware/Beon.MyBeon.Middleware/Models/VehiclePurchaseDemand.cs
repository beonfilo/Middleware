using Beon.MyBeon.Middleware.Models.BaseModels;

namespace Beon.MyBeon.Middleware.Models
{
    public class VehiclePurchaseDemand : BaseModel
    {
        public string? Status { get; set; }  
        public DateTime? CreatedOn { get; set; }
        public DateTime? DueDate { get; set; }
        public ApplicationUser? Owner { get; set; }
        public string? Code { get; set; }  
        public Customer? Customer { get; set; }
        public Quote? Quote { get; set; }
        public Contract? Contract { get; set; }
        public string? Description { get; set; }  
    }
}