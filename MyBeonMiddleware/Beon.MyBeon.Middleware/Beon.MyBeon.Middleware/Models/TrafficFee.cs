using Beon.MyBeon.Middleware.Models.BaseModels;

namespace Beon.MyBeon.Middleware.Models;

public class TrafficFee : BaseFollowUpTransaction
{
    public DateTime DateOfIssuance { get; set; }//düzenleme tarihi 

    //public TrafficFineServiceCard _trafficFineServiceCard;
    public DateTime DateOfNotification { get; set; } //tebliğ tarihi
    public string SerialNumber { get; set; } = string.Empty;//ceza seri no
    public string LineNumber { get; set; } = string.Empty;//ceza sıra no 
    public double DiscountedTotal { get; set; } = default;

    //public TrafficFeePaymentStatus PaymentStaus;
    public DateTime PaymentDate { get; set; }

    //public TrafficFeeInvoicePool _trafficFeeInvoicePool;
}
