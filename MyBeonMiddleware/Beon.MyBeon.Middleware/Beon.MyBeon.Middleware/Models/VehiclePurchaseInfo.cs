using Beon.MyBeon.Middleware.Models.BaseModels;

namespace Beon.MyBeon.Middleware.Models
{
    public class VehiclePurchaseInfo : BaseModel
    {
        //public ApplicationUser _owner{get;set;}
        public DateTime? CreatedOn { get; set; }
        public int ReferenceId { get; set; } = default;
        public Vehicle? Vehicle { get; set; }
        public Dealer? VehicleDealer { get; set; }
        public DateTime? PurchaseDate { get; set; }
        public double UnitPrice { get; set; } = default;
        public double Discount { get; set; } = default;
        public double Total { get; set; } = default;
        public double OtvRate { get; set; } = default;
        public double TotalOtv { get; set; } = default;
        public double VatRate { get; set; } = default;
        public double TotalVat { get; set; } = default;
        public double NetTotal { get; set; } = default;
        public double RealNetTotal { get; set; } = default;
        public double Kilometer { get; set; } = default;
        public string TargetType { get; set; } = string.Empty;
        public string TargetNumber { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string InvoiceNumber { get; set; } = string.Empty;
        public int InvoiceReferenceId { get; set; } = default;
    }
}