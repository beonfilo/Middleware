namespace Beon.MyBeon.Middleware.Models.BaseModels
{
	public class ChargeoutInvoicePool : BaseInvoicePool
	{
		public ChargeoutTransaction? ChargeoutTransaction { get; set; }
		public ChargeoutServiceCard? ServiceCard { get; set; }
	}
}