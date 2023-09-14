namespace Beon.MyBeon.Middleware.Models.BaseModels
{
	public class BaseAppointment : BaseActivity
	{
		//public ApplicationUser _owner;
		public DateTime CreatedOn { get; set; } = DateTime.Now;
		public string AppointmentType { get; set; } = string.Empty;
		public string AppointmentStatus { get; set; } = string.Empty;
		public string SupplierCardType { get; set; } = string.Empty;
		public BaseDemand? BaseDemand { get; set; }
		public BaseProforma? BaseProforma { get; set; }
		public Supplier? Supplier { get; set; }
		public SupplierContact? SupplierContact { get; set; }
		public City? City { get; set; }
		public County? County { get; set; }
		public Vehicle? Vehicle { get; set; }
		public Customer? Customer { get; set; }
		public CustomerContact? customerContact { get; set; }
		public AppointmentRejectReason? RejectReason { get; set; }
		public DateTime StatusChangeDate { get; set; } = DateTime.Now;
		//public ApplicationUser _statusChanger;
		public string StatusDescription { get; set; } = string.Empty;

		public ReasonForRejection? ReasonForRejection { get; set; }
		public string RejectionDescription { get; set; } = string.Empty;
		public DateTime RejectionOn { get; set; } = DateTime.Now;
		//public ApplicationUser _rejectionOwner;

		#region Logo Transfer İşlem Bilgileri
		public DateTime TransferDate { get; set; } = DateTime.Now;
		public int TransferReferenceId { get; set; } = default;
		public string TransferFicheNumber { get; set; } = string.Empty;
		//public ApplicationUser _transferedBy;

		public DateTime RetrievalDate { get; set; } = DateTime.Now;
		public int RetrievalReferenceId { get; set; } = default;
		public string RetrievalFicheNumber { get; set; } = string.Empty;
		//public ApplicationUser _retrievaledBy;
		#endregion
	}
}
