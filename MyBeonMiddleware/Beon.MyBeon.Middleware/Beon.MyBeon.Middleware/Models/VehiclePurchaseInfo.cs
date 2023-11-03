using Beon.MyBeon.Middleware.Models.BaseModels;

namespace Beon.MyBeon.Middleware.Models
{
    public class VehiclePurchaseInfo : BaseModel
    {
        public ApplicationUser? Owner { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? ReferenceId { get; set; }  
        public Vehicle? Vehicle { get; set; }
        public Dealer? VehicleDealer { get; set; }
        public DateTime? PurchaseDate { get; set; }
        public double? UnitPrice { get; set; }  
        public double? Discount { get; set; }  
        public double? Total { get; set; }  
        public double? OtvRate { get; set; }  
        public double? TotalOtv { get; set; }  
        public double? VatRate { get; set; }  
        public double? TotalVat { get; set; }  
        public double? NetTotal { get; set; }  
        public double? RealNetTotal { get; set; }  
        public double? Kilometer { get; set; }  
        public string? TargetType { get; set; }  
        public string? TargetNumber { get; set; }  
        public string? Description { get; set; }  
        public string? InvoiceNumber { get; set; }  
        public int? InvoiceReferenceId { get; set; }  
    }
}