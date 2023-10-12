using Beon.MyBeon.Middleware.Models.BaseModels;

namespace Beon.MyBeon.Middleware.Models
{
    public class VehiclePurchaseOrder : BasePurchaseOrder
    {
        public string? Status { get; set; }  
        public Dealer? Dealer { get; set; }
    }
}