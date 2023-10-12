using Beon.MyBeon.Middleware.Models.BaseModels;

namespace Beon.MyBeon.Middleware.Models;

public class PurchaseProformaLine : BaseProformaLine
{
	public string? PurchaseProformaModuleType { get; set; }  
	public PurchaseProforma? PurchaseProforma {  get; set; }
	public string? PurchaseProformaLineCardType { get; set; }  
	public ProductBrand? ProductBrand{get; set;}
	public string? ChargeoutType { get; set; }   //ücretlendirme türü oran mı tutar mı
	public double? ChargeoutPrice { get; set; } //yansıtılacak fiyat
	public double? ChargeoutRate { get; set; }  //yansıtılacak oran
	public string? ChargeoutStatus { get; set; }  
	public ChargeoutServiceCard? ChargeoutServiceCard { get; set; }
	public MaintenanceServiceCard? MaintenanceServiceCard { get; set; }
}
