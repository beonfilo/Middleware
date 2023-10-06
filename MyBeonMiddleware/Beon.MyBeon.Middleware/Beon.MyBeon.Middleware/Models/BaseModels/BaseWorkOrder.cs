namespace Beon.MyBeon.Middleware.Models.BaseModels;

public class BaseWorkOrder:BaseModel
{
	public string WorkOrderType { get; set; } = string.Empty;
	public string Status { get; set; } = string.Empty;
	public DateTime? CreatedOn { get; set; }
	public ApplicationUser? Owner { get; set; }
	public string Code { get; set; } = string.Empty;
	public Vehicle? Vehicle { get; set; }
	public Contract? Contract { get; set; }
	public Customer? Customer { get; set; }
	public CustomerContact? CustomerContact { get; set; }
	public string Description { get; set; } = string.Empty;
	public ApplicationUser? StartedBy { get; set; }
	public DateTime? ActualStartDate { get; set; }
	public TimeSpan? ActualStartTime { get; set; }
	public ApplicationUser? EndedBy { get; set; }
	public DateTime? ActualEndDate { get; set; }
	public TimeSpan? ActualEndTime { get; set; }
	public BaseDemand? BaseDemand { get; set; }
	public BaseAppointment? BaseAppointment { get; set; }
	public BaseProforma? BaseProforma { get; set; }
	public string SupplierCardType { get; set; } = string.Empty;
	public Supplier? Supplier { get; set; }
	public SupplierContact? SupplierContact { get; set; }
	public BaseSubstitutionVehicle? BaseSubstitutionVehicle { get; set; }
	public ApplicationUser? CanceledBy { get; set; }
	public DateTime? CanceledDate { get; set; }
	public string CanceledDescription { get; set; } = string.Empty;
	public AppointmentRejectReason? RejectReason { get; set; }
	public ReasonForRejection? ReasonForRejection { get; set; }
	public string RejectionDescription { get; set; } = string.Empty;
	public DateTime? RejectionOn { get; set; }
	public ApplicationUser? RejectionOwner { get; set; }
}
