using Beon.MyBeon.Middleware.Models.BaseModels;

namespace Beon.MyBeon.Middleware.Models
{
    public class StockLocation : BaseModel
    {
        public string? Code { get; set; }  
        public string? Name { get; set; }  
        public City? City { get; set; }
        public County? _County { get; set; }
        public string? Address { get; set; }  
        public bool? IsActive { get; set; }  

        public DateTime? CreatedOn { get; set; }
        public ApplicationUser? Owner { get; set; }
    }
}