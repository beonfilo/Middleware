namespace Beon.MyBeon.Middleware.Models.BaseModels
{
	public class KilometerExceedingInvoicePool : BaseInvoicePool
	{
		public KilometerExceedingTransaction? KilometerExceedingTransaction { get; set; }
		public KilometerExceedingServiceCard? ServiceCard { get; set; }
	}
}