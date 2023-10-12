using Beon.MyBeon.Middleware.Models.BaseModels;

namespace Beon.MyBeon.Middleware.Models
{
    public class Bank : BaseModel
    {
        public string? IntegrationResult { get; set; }  
        public string? Code { get; set; } 
        public string? Name { get; set; } 
        public string? BranchNumber { get; set; } 
        public string? BranchName { get; set; } 
        public string? EMailAddress { get; set; } 
        public string? Incharge { get; set; } 
        public string? Telephone { get; set; } 
        public string? OtherTelephone { get; set; } 
        public bool? IsActive { get; set; } = default;
    }
}
