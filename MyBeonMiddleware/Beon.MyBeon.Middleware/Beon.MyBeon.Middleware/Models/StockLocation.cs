using Beon.MyBeon.Middleware.Models.BaseModels;

namespace Beon.MyBeon.Middleware.Models
{
    public class StockLocation : BaseModel
    {
        public string Code { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public City? City { get; set; }
        public County? _County { get; set; }
        public string Address { get; set; } = string.Empty;
        public bool IsActive { get; set; } = default;

        public DateTime? CreatedOn { get; set; }
        //public ApplicationUser _owner{get;set;}
    }
}