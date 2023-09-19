using Beon.MyBeon.Middleware.Models.BaseModels;

namespace Beon.MyBeon.Middleware.Models
{
    public class QuoteTransaction : BaseModel
    {
        public Quote? Quote{ get; set;}
        public string Code { get; set; } = string.Empty;
        public int LineNumber { get; set; } = default;
        public VehicleBrand? Brand{ get; set;}
        public VehicleBrandModel? Model{ get; set;}
        public VehicleBrandModelPackage? Package{ get; set;}
        public double Quantity{ get; set;} = default;
        public double UnitPrice{ get; set;} = default;
        public double Kilometer{ get; set;} = default;
        public int Month{ get; set;} = default;
        public int TotalDay{ get; set;} = default;
        public Currency? Currency{ get; set;}
        public string VatType{ get; set; } = string.Empty;
        public int VatRate{ get; set;} = default;
        public string DiscountType { get; set; } = string.Empty;
        public double Discount{ get; set;} = default;
        public double Total{ get; set;} = default;
        public double TotalDiscount{ get; set;} = default;
        public double TotalVat{ get; set;} = default;
        public double LineNet{ get; set;} = default;
        public string Description{ get; set; } = string.Empty;
        public QuoteRevision? QuoteRevision{ get; set;}
        public double Coefficient{ get; set;} = default;//katsayı
        public double PurchasePrice { get; set; } = default;//satınalma fiyatı
        public double ValueOfvehicleInsurance{ get; set;}//kasko değeri
        public string Status { get; set; } = string.Empty;
        public GearType? GearType{ get; set;}//şanzıman
        public VehicleBrandModelPackageYear? Year{ get; set;}

        public double DeclarationLimit{ get; set;} = default;//beyan limiti
        public bool IsVehicleOptions{ get; set;} = default;//araçları opsiyonlayacak mıyız ?
        public QuotePriceParameter? QuotePriceParameter{ get; set;}
        public double PoolKilometer{ get; set;} = default;
    }
}