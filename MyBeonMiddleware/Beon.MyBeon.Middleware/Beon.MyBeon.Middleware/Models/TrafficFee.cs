using Beon.MyBeon.Middleware.Models.BaseModels;

namespace Beon.MyBeon.Middleware.Models;

public class TrafficFee : BaseFollowUpTransaction
{
    public DateTime? DateOfIssuance { get; set; }//düzenleme tarihi 

    public TrafficFineServiceCard? TrafficFineServiceCard { get; set; }
    public DateTime? DateOfNotification { get; set; } //tebliğ tarihi
    public string? SerialNumber { get; set; } //ceza seri no
    public string? LineNumber { get; set; }  //ceza sıra no 
    public double? DiscountedTotal { get; set; }  

    public string? PaymentStaus { get; set; }
    public DateTime? PaymentDate { get; set; }

    public TrafficFeeInvoicePool? TrafficFeeInvoicePool { get; set; }
}
