using Beon.MyBeon.Middleware.Models.BaseModels;

namespace Beon.MyBeon.Middleware.Models
{
    public class QuoteTransactionDetail :BaseModel
    {
        public string? Status { get; set; }  
        public QuoteTransaction? QuoteTransaction{ get; set;}
        public int? LineNumber { get; set; }  
        public double? UnitPrice{ get; set;}  
        public double? Kilometer{ get; set;}  
        public int? Month{ get; set;}  
        public int? TotalDay{ get; set;}  
        public string? VatType { get; set;}  
        public int? VatRate{ get; set;}  
        public string? DiscountType { get; set;}  
        public double? Discount{ get; set;}  
        public double? Total{ get; set;}  
        public double? TotalDiscount{ get; set;}  
        public double? TotalVat{ get; set;}  
        public double? LineNet{ get; set;}  
        public double? ExtraKilometerPrice{ get; set;}  //fazla km bedeli
        public double? MissingKilometerPrice{ get; set;}  //eksik km bedlei
        public double? Factor{ get; set;}  //çarpan
        public double? QuoteTransactionFactor{ get; set;}  
        public double? PurchasePrice{ get; set;}  
        public double? ValueOfvehicleInsurance{ get; set;}  
        public QuotePriceParameter? QuotePriceParameter{ get; set;}
        public QuotePriceParameterLine? QuotePriceParameterLine{ get; set;}
        public double? PoolKilometer{ get; set;}  
    }
}