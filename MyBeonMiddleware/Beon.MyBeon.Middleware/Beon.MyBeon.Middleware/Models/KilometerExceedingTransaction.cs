namespace Beon.MyBeon.Middleware.Models.BaseModels
{
	public class KilometerExceedingTransaction : BaseFollowUpTransaction
	{
		public KilometerExceedingServiceCard? ServiceCard { get; set; }
		public double? ExtraKilometerPrice { get; set; }//fazla km bedeli
		public double? ExceedingKilometer { get; set; }
		public KilometerExceedingInvoicePool? KilometerExceedingInvoicePool { get; set; }
	}
}