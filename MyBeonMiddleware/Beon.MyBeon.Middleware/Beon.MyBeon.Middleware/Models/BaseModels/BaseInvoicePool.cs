namespace Beon.MyBeon.Middleware.Models.BaseModels;

public class BaseInvoicePool : BaseModel
{
	public string BaseInvoicePoolTargetType { get; set; } = string.Empty;
	public string BaseInvoicePoolStatus { get; set; } = string.Empty;
	public DateTime CreatedOn { get; set; } = default;
	//public ApplicationUser _owner;
	public string Code { get; set; } = string.Empty;
	public DateTime TransactionOn { get; set; } = default;
	public Vehicle? Vehicle { get; set; }
	public Contract? Contract{ get; set; }
	public Customer? Customer { get; set; }
	public Customer? BillCustomer { get; set; }
	public CustomerContact? CustomerContact { get; set; }
	public string Description { get; set; } = string.Empty;
	public SalesServiceCard? SalesServiceCard { get; set; }
	public double Total { get; set; } = default;
	//	public FileData _chargeoutDocumentData;//yanıtma Belgesi
	public DateTime InvoiceDate { get; set; } = default;
	public string InvoiceNumber { get; set; } = string.Empty;
	public int InvoiceReferenceId { get; set; } = default;
}
