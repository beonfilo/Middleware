using Beon.MyBeon.Middleware.Models.BaseModels;

namespace Beon.MyBeon.Middleware.Models
{
    public class LeadContact : BaseModel
    {
        public Lead? Lead { get; set; } 
        public bool IsPrivatePerson { get; set; } = default;
    }
}