using Beon.MyBeon.Middleware.Models.BaseModels;

namespace Beon.MyBeon.Middleware.Models
{
    public class QuotePriceParameterLine : BaseModel
    {
        public QuotePriceParameter? QuotePriceParameter { get; set; }
        public int Month { get; set; } = default;
        public int TotalDay { get; set; } = default;
        public double Kilometer { get; set; } = default;
        public double UnitPrice { get; set; } = default;
    }
}