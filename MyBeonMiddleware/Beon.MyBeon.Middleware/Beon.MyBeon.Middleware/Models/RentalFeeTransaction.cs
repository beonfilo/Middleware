using Beon.MyBeon.Middleware.Models.BaseModels;

namespace Beon.MyBeon.Middleware.Models;

public class RentalFeeTransaction : BaseFollowUpTransaction
{
	public RentalFeeServiceCard? ServiceCard { get; set; }
	public RentalFeeInvoicePool? RentalFeeInvoicePool { get; set; }
	public ContractTransactionVehiclePayment? ContractTransactionVehiclePayment { get; set; }
}
