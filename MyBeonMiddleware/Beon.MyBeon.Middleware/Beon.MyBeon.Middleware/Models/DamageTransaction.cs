using Beon.MyBeon.Middleware.Models.BaseModels;
using System.Text.Json.Serialization;

namespace Beon.MyBeon.Middleware.Models
{
    public class DamageTransaction : BaseFollowUpTransaction
    {
        public string? ServiceCard { get; set; }
        public AuthorizedServiceShop? AuthorizedServiceShop { get; set; }
        public AuthorizedServiceShopBranch? Branch { get; set; }
        public double? DefectRate { get; set; } // kusur oranı
        public string? DamageCause { get; set; }
        public DateTime? DamageDate { get; set; } //hasar tarihi
        [JsonIgnore]
        public TimeSpan? DamageTime { get; set; } //hasar saati
        public City? City { get; set; }
        public County? County { get; set; }
        public DamageInvoicePool? DamageInvoicePool { get; set; }
        public DamageWorkOrder? WorkOrder { get; set; }
        public DamageWorkOrderLine? DamageWorkOrderLine { get; set; }
        public DamageDemand? Demand { get; set; }
    }
}
