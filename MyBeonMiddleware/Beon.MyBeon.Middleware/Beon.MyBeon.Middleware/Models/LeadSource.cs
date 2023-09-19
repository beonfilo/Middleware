using Beon.MyBeon.Middleware.Models.BaseModels;

namespace Beon.MyBeon.Middleware.Models
{
    public class LeadSource : BaseModel
    {
        public string Name { get;set ; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public bool IsActive { get; set; } = default;
    }
}