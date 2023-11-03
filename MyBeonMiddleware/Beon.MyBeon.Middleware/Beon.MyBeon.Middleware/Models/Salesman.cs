using Beon.MyBeon.Middleware.Models.BaseModels;

namespace Beon.MyBeon.Middleware.Models
{
    public class Salesman : BaseModel
    {
        public string? Code { get; set; }  
        public string? Name { get; set; }  
        public ApplicationUser? Owner { get; set; }
        public bool? IsActive { get; set; }  
        public int? ReferenceId { get; set; }  
        public string? IntegrationResult { get; set; }  
    }
}