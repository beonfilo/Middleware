namespace Beon.MyBeon.Middleware.Models.BaseModels
{
	public class ChargeoutTransaction : BaseFollowUpTransaction
	{
		public DateTime? ChargeoutDate { get; set; }
		public ChargeoutServiceCard? ServiceCard { get; set; }
		public ChargeoutInvoicePool? ChargeoutInvoicePool { get; set; }
		public BaseVehicleReturnTransaction? BaseVehicleReturnTransaction { get; set; }
	}
}