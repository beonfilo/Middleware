using Beon.MyBeon.Middleware.Models.BaseModels;

namespace Beon.MyBeon.Middleware.Models
{
    public class DamageInvoicePool : BaseInvoicePool
    {
        public DamageTransaction? DamageTransaction { get; set; }
        public string? ServiceCard { get; set; }
    }
}
