using Beon.MyBeon.Middleware.Models.BaseModels;

namespace Beon.MyBeon.Middleware.Models
{
    public class MaintenanceDemand : BaseDemand
	{
		public PurchaseMaintenanceServiceCard? PurchaseMaintenanceServiceCard { get; set; } 
		public MaintenanceServiceCard? MaintenanceServiceCard { get; set; }
		public MaintenanceAppointment? Appointment { get; set; }
		public MaintenanceProforma? Proforma { get; set; }
		public string? MaintenanceType { get; set; }  
		public PeriodicMaintenanceParameter? PeriodicMaintenanceParameter { get; set; }
		public double? Kilometer { get; set; }  
		public MaintenanceCategory? MaintenanceCategory { get; set; }
		public AuthorizedServiceShop? DemandedServiceShop { get; set; }
		public AuthorizedServiceShopBranch? DemandedServiceShopBranch { get; set; }

		public bool? IsSubstitutionVehicle { get; set; }  
		public MaintenanceSubstitutionVehicle? SubstitutionVehicle { get; set; }
	}
}
