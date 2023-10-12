using Beon.MyBeon.Middleware.Models.BaseModels;

namespace Beon.MyBeon.Middleware.Models
{
    public class ReasonForRejection : BaseModel
    {
        public DateTime? CreatedOn { get; set; }
        public ApplicationUser? Owner { get; set; }
        public string? TargetType { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public bool? IsActive { get; set; }
    }
}
