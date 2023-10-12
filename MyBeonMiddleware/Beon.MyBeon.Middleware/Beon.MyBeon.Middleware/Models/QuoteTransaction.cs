using Beon.MyBeon.Middleware.Models.BaseModels;

namespace Beon.MyBeon.Middleware.Models
{
    public class QuoteTransaction : BaseModel
    {
        public Quote? Quote{ get; set;}
        public string? Code { get; set; }  
        public int? LineNumber { get; set; }  
        public VehicleBrand? Brand{ get; set;}
        public VehicleBrandModel? Model{ get; set;}
        public VehicleBrandModelPackage? Package{ get; set;}
        public double? Quantity{ get; set;}  
        public double? UnitPrice{ get; set;}  
        public double? Kilometer{ get; set;}  
        public int? Month{ get; set;}  
        public int? TotalDay{ get; set;}  
        public Currency? Currency{ get; set;}
        public string? VatType{ get; set; }  
        public int? VatRate{ get; set;}  
        public string? DiscountType { get; set; }  
        public double? Discount{ get; set;}  
        public double? Total{ get; set;}  
        public double? TotalDiscount{ get; set;}  
        public double? TotalVat{ get; set;}  
        public double? LineNet{ get; set;}  
        public string? Description{ get; set; }  
        public QuoteRevision? QuoteRevision{ get; set;}
        public double? Coefficient{ get; set;}  //katsayı
        public double? PurchasePrice { get; set; }  //satınalma fiyatı
        public double? ValueOfvehicleInsurance{ get; set;}//kasko değeri
        public string? Status { get; set; }  
        public GearType? GearType{ get; set;}//şanzıman
        public VehicleBrandModelPackageYear? Year{ get; set;}
        public double? DeclarationLimit{ get; set;}  //beyan limiti
        public bool? IsVehicleOptions{ get; set;}  //araçları opsiyonlayacak mıyız ?
        public QuotePriceParameter? QuotePriceParameter{ get; set;}
        public double? PoolKilometer{ get; set;}  
    }
}