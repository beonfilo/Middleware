using Beon.MyBeon.Middleware.Models.BaseModels;

namespace Beon.MyBeon.Middleware.Models
{
    public class Salesman : BaseModel
    {
        public string Code { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        //public ApplicationUser _owner { get; set}
        public bool IsActive { get; set; } = default;
        public int ReferenceId { get; set; } = default;
        public string IntegrationResult { get; set; } = string.Empty;
    }
}