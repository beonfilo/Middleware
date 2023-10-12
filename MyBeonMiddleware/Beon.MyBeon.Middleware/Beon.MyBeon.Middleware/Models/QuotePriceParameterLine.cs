using Beon.MyBeon.Middleware.Models.BaseModels;

namespace Beon.MyBeon.Middleware.Models
{
    public class QuotePriceParameterLine : BaseModel
    {
        public QuotePriceParameter? QuotePriceParameter { get; set; }
        public int? Month { get; set; } 
        public int? TotalDay { get; set; } 
        public double? Kilometer { get; set; } 
        public double? UnitPrice { get; set; } 
    }
}