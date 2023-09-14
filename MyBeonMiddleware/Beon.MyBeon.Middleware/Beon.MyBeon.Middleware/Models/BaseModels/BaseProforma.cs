namespace Beon.MyBeon.Middleware.Models.BaseModels
{
	public class BaseProforma : BaseModel
	{
	
		public DateTime CreatedOn { get; set; } = DateTime.Now;
		//public ApplicationUser _owner;
		public string BaseProformaModuleType { get; set; } = string.Empty;
		public string ProformaType { get; set; } = string.Empty;
		public string Status { get; set; } = string.Empty;
		public ProformaRevision? ProformaRevision { get; set; }
		public string ProformaNumber { get; set; } = string.Empty;
		public DateTime ProformaDate { get; set; } = DateTime.Now;
		public Vehicle? Vehicle { get; set; }
		public BaseCustomer? BaseCustomer { get; set; }
		public PaymentPlan? PaymentPlan { get; set; }
		public Currency? Currency { get; set; }
		public double CurrencyRate { get; set; } =default;
		public string Description { get; set; } = string.Empty;
		public BaseDemand? BaseDemand { get; set; }
		public BaseAppointment? BaseAppointment { get; set; }
		public BaseServiceCard? BaseServiceCard { get; set; }

		public double Total { get; set; } = default;
		public double TotalVat { get; set; } = default;
		public double TotalDiscount { get; set; } = default;
		public double NetTotal { get; set; } = default;

		#region Red Bilgileri
		public ReasonForRejection? ReasonForRejection { get; set; }
		public DateTime RejectedDate { get; set; } = DateTime.Now;
		//public ApplicationUser _rejectedBy;
		#endregion

		#region Onay ve Sipariş Bilgileri
		public DateTime ApproveDate { get; set; } = DateTime.Now;
		//public ApplicationUser _approvedBy;
		public int OrderReferenceId { get; set; } = default;
		public string OrderFicheNumber { get; set; } = string.Empty;
		#endregion
	}
}
