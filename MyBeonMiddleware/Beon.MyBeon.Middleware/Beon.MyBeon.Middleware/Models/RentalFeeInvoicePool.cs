using Beon.MyBeon.Middleware.Models.BaseModels;

namespace Beon.MyBeon.Middleware.Models;

public class RentalFeeInvoicePool: BaseInvoicePool
{
	public RentalFeeTransaction? RentalFeeTransaction { get; set; }	
	public RentalFeeServiceCard? RerviceCard { get; set; }
}
