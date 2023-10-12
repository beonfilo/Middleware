using Beon.MyBeon.Middleware.Models.BaseModels;

namespace Beon.MyBeon.Middleware.Models
{
    public class OrderTransaction : BaseModel
    {
        public DateTime? CreatedOn { get; set; }
        public string? Owner { get; set; }
        public string? Code { get; set; }
        public Order? Order { get; set; }
        public Customer? Customer { get; set; }
        public int? LineNumber { get; set; }
        public string? TollFeeStatus { get; set; }  //hgs var/yok varsa beon öder, yoksa müşteri öder
        public VehicleBrand? Brand { get; set; }
        public VehicleBrandModel? Model { get; set; }
        public VehicleBrandModelPackage? Package { get; set; }
        public double? Quantity { get; set; }
        public double? UnitPrice { get; set; }
        public double? Kilometer { get; set; }
        public int? Month { get; set; }
        public int? TotalDay { get; set; }
        public Currency? Currency { get; set; }
        public string? VatType { get; set; }
        public int? VatRate { get; set; }
        public string? DiscountType { get; set; }
        public double? Discount { get; set; }
        public double? Total { get; set; }
        public double? TotalDiscount { get; set; }
        public double? TotalVat { get; set; }
        public double? LineNet { get; set; }
        public string? Description { get; set; }
        public Quote? Quote { get; set; }
        public QuoteTransaction? QuoteTransaction { get; set; }
        public ContractRevision? ContractRevision { get; set; }
        public string? Status { get; set; }
        public DateTime? StatusChangeDate { get; set; }
        public ApplicationUser? StatusChanger { get; set; }
        public ReasonForRejection? ReasonForRejection { get; set; }
        public string? RejectedDescription { get; set; }
        public double? ExtraKilometerPrice { get; set; } //fazla km bedeli
        public double? MissingKilometerPrice { get; set; } //eksik km bedlei
        public double? Factor { get; set; } //çarpan
        public Vehicle? Vehicle { get; set; }
        public GearType? GearType { get; set; }
        public VehicleBrandModelPackageYear? Year { get; set; }
        public YearType? YearType { get; set; }
        public double? DeclarationLimit { get; set; }
        public QuoteTransactionDetail? QuoteTransactionDetail { get; set; }//teklifte onaylanan asıl araç bilgisi
        public DateTime? TransactionDate { get; set; }
        public ContractTransaction? ContractTransaction { get; set; }
        public double? PoolKilometer { get; set; }
    }
}