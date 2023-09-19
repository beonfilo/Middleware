using Beon.MyBeon.Middleware.Models.BaseModels;

namespace Beon.MyBeon.Middleware.Models
{
    public class QuoteTransactionDetail :BaseModel
    {
        public string Status { get; set; } = string.Empty;
        public QuoteTransaction? QuoteTransaction{ get; set;}
        public int LineNumber { get; set; } = default;
        public double UnitPrice{ get; set;} = default;
        public double Kilometer{ get; set;} = default;
        public int Month{ get; set;} = default;
        public int TotalDay{ get; set;} = default;
        public string VatType { get; set;} = string.Empty;
        public int VatRate{ get; set;} = default;
        public string DiscountType { get; set;} = string.Empty;
        public double Discount{ get; set;} = default;
        public double Total{ get; set;} = default;
        public double TotalDiscount{ get; set;} = default;
        public double TotalVat{ get; set;} = default;
        public double LineNet{ get; set;} = default;
        public double ExtraKilometerPrice{ get; set;} = default;//fazla km bedeli
        public double MissingKilometerPrice{ get; set;} = default;//eksik km bedlei
        public double Factor{ get; set;} = default;//çarpan

        public double QuoteTransactionFactor{ get; set;} = default;
        public double PurchasePrice{ get; set;} = default;
        public double ValueOfvehicleInsurance{ get; set;} = default;

        public QuotePriceParameter? QuotePriceParameter{ get; set;}
        public QuotePriceParameterLine? QuotePriceParameterLine{ get; set;}
        public double PoolKilometer{ get; set;} = default;
    }
}