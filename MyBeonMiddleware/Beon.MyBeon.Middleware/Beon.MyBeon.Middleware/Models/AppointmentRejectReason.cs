using Beon.MyBeon.Middleware.Models.BaseModels;

namespace Beon.MyBeon.Middleware.Models
{
    public class AppointmentRejectReason : BaseModel
    { 
        public DateTime? CreatedOn { get; set; }  
        public ApplicationUser? Owner { get; set; }
        public string? Name { get; set; }  
        public bool? IsActive { get; set; }  
    }
}
