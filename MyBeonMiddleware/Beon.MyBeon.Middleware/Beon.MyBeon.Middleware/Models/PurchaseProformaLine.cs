using Beon.MyBeon.Middleware.Models.BaseModels;

namespace Beon.MyBeon.Middleware.Models;

public class PurchaseProformaLine : BaseProformaLine
{
	public string PurchaseProformaModuleType { get; set; } = string.Empty;
	public PurchaseProforma? PurchaseProforma {  get; set; }
	public string PurchaseProformaLineCardType { get; set; } = string.Empty;
	public ProductBrand? ProductBrand{get; set;}
	public string ChargeoutType { get; set; } = string.Empty; //ücretlendirme türü oran mı tutar mı
	public double ChargeoutPrice { get; set; } = default;//yansıtılacak fiyat
	public double ChargeoutRate { get; set; } = default; //yansıtılacak oran
	public string ChargeoutStatus { get; set; } = string.Empty;
	public ChargeoutServiceCard? ChargeoutServiceCard { get; set; }
	public MaintenanceServiceCard? MaintenanceServiceCard { get; set; }
}
