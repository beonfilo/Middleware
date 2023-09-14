namespace Beon.MyBeon.Middleware.Models
{
	public class MaintenanceProforma : PurchaseProforma
	{
		public MaintenanceDemand? Demand { get; set; }
		public MaintenanceAppointment? Appointment { get; set; }
		public PurchaseMaintenanceServiceCard? PurchaseMaintenanceServiceCard { get; set; }
	}
}