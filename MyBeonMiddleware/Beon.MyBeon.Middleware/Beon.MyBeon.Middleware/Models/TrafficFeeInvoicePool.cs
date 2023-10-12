using Beon.MyBeon.Middleware.Models.BaseModels;

namespace Beon.MyBeon.Middleware.Models
{
    public class TrafficFeeInvoicePool : BaseInvoicePool
    {
        public TrafficFineServiceCard? ServiceCard { get; set; }
        public TrafficFee? TrafficFee{ get; set; }
    }
}