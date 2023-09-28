namespace Beon.MyBeon.Middleware.Models.BaseModels;

public class BaseFollowUpTransaction : BaseModel
{
    //public BaseFollowUpTransactionType TransactionType;
    public DateTime CreatedOn { get; set; }
    //public ApplicationUser? Owner{ get; set; }
    public string Code { get; set; } = string.Empty;
    public DateTime TransactionOn { get; set; }
    public Vehicle? Vehicle { get; set; }
   // public SalesServiceCard _salesServiceCard;
    public Contract? Contract { get; set; } //sözleşme
    public ContractTransaction? ContractTransaction { get; set; }//sipariş
    public ContractTransactionVehicle? ContractTransactionVehicle { get; set; }//araç
    public Customer? Customer { get; set; }
    public CustomerContact? CustomerContact { get; set; }
    public double Total { get; set; } = default;
    public string ChargeoutStatus { get; set; } = string.Empty;
    public double ChargeoutPrice { get; set; }
    //public FileData _chargeoutDocumentData;//yanıtma Belgesi 
    public string Description { get; set; } = string.Empty;
    //public BaseInvoicePool BaseInvoicePool;
    public DateTime ChargeoutOn { get; set; }
}
