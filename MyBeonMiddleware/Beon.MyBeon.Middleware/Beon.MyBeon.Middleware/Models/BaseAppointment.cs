using Beon.MyBeon.Middleware.Models.BaseModels;

namespace Beon.MyBeon.Middleware.Models;

public class BaseAppointment : BaseActivity
{
    public ApplicationUser? Owner { get; set; }
    public DateTime? CreatedOn { get; set; }
    public string? AppointmentType { get; set; }
    public string? AppointmentStatus { get; set; }
    public string? SupplierCardType { get; set; }
    public BaseDemand? BaseDemand { get; set; }
    public BaseProforma? BaseProforma { get; set; }
    public Supplier? Supplier { get; set; }
    public SupplierContact? SupplierContact { get; set; }
    public City? City { get; set; }
    public County? County { get; set; }
    public Vehicle? Vehicle { get; set; }
    public Customer? Customer { get; set; }
    public CustomerContact? CustomerContact { get; set; }
    public AppointmentRejectReason? RejectReason { get; set; }
    public DateTime? StatusChangeDate { get; set; }
    public ApplicationUser? StatusChanger { get; set; }
    public string? StatusDescription { get; set; }

    public ReasonForRejection? ReasonForRejection { get; set; }
    public string? RejectionDescription { get; set; }
    public DateTime? RejectionOn { get; set; }
    public ApplicationUser? RejectionOwner { get; set; }

    #region Logo Transfer İşlem Bilgileri
    public DateTime? TransferDate { get; set; }
    public int? TransferReferenceId { get; set; }
    public string? TransferFicheNumber { get; set; }
    public ApplicationUser? TransferedBy { get; set; }

    public DateTime? RetrievalDate { get; set; }
    public int? RetrievalReferenceId { get; set; }
    public string? RetrievalFicheNumber { get; set; }
    public ApplicationUser? RetrievaledBy { get; set; }
    #endregion
}
