using Beon.MyBeon.Middleware.Models.BaseModels;

namespace Beon.MyBeon.Middleware.Models
{
    public class VehiclePurchaseOrder : BasePurchaseOrder
    {
        public string Status { get; set; } = string.Empty;
        public Dealer? Dealer { get; set; }
    }
}