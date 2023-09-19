using Beon.MyBeon.Middleware.Models.BaseModels;

namespace Beon.MyBeon.Middleware.Models
{
    public class OrderTransaction : BaseModel
    {
        public DateTime? CreatedOn { get; set; }
        public string Owner { get; set; } = string.Empty;
        public string Code { get; set; } = string.Empty;
        public Order? Order { get; set; }
        public Customer? Customer { get; set; }
        public int LineNumber { get; set; } = default;
        public string TollFeeStatus { get; set; } = string.Empty;//hgs var/yok varsa beon öder, yoksa müşteri öder
        public VehicleBrand? Brand { get; set; }
        public VehicleBrandModel? Model { get; set; }
        public VehicleBrandModelPackage? Package { get; set; }
        public double Quantity { get; set; } = default;
        public double UnitPrice { get; set; } = default;
        public double Kilometer { get; set; } = default;
        public int Month { get; set; } = default;
        public int TotalDay { get; set; } = default;
        public Currency? Currency { get; set; }
        public string VatType { get; set; } = string.Empty;
        public int VatRate { get; set; } = default;
        public string DiscountType { get; set; } = string.Empty;
        public double Discount { get; set; } = default;
        public double Total { get; set; } = default;
        public double TotalDiscount { get; set; } = default;
        public double TotalVat { get; set; } = default;
        public double LineNet { get; set; } = default;
        public string Description { get; set; } = string.Empty;
        public Quote? Quote { get; set; }
        public QuoteTransaction? QuoteTransaction { get; set; }
        public ContractRevision? ContractRevision { get; set; }
        public string Status { get; set; } = string.Empty;
        public DateTime? StatusChangeDate { get; set; }
        //public ApplicationUser statusChanger { get; set; }
        public ReasonForRejection? ReasonForRejection { get; set; }
        public string RejectedDescription { get; set; } = string.Empty;
        public double ExtraKilometerPrice { get; set; } = default;//fazla km bedeli
        public double MissingKilometerPrice { get; set; } = default;//eksik km bedlei
        public double Factor { get; set; } = default;//çarpan
        public Vehicle? Vehicle { get; set; }
        public GearType? GearType { get; set; }
        public VehicleBrandModelPackageYear? Year { get; set; }
        public YearType? YearType { get; set; }
        public double DeclarationLimit { get; set; } = default;
        public QuoteTransactionDetail? QuoteTransactionDetail { get; set; }//teklifte onaylanan asıl araç bilgisi
        public DateTime? TransactionDate { get; set; }
        public ContractTransaction? ContractTransaction { get; set; }
        public double PoolKilometer { get; set; } = default;
    }
}