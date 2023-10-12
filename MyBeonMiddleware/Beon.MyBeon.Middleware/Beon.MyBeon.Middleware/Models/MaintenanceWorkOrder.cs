using Beon.MyBeon.Middleware.Models.BaseModels;

namespace Beon.MyBeon.Middleware.Models;

public class MaintenanceWorkOrder : BaseWorkOrder
{
	public MaintenanceDemand? Demand { get; set; }
	public MaintenanceAppointment? Appointment { get; set; }
	public MaintenanceProforma? Proforma { get; set; }
	public string? MaintenanceType { get; set; } 
	public double? Kilometer { get; set; }  
	public MaintenanceCategory? MaintenanceCategory { get; set; }
	public PeriodicMaintenanceParameter? PeriodicMaintenanceParameter { get; set; }
	public int? InvoiceReferenceId { get; set; }  
	public string? InvoiceNumber { get; set; }   
	public string? InvoiceStatus { get; set; }   
	public FileData? ChargeoutDocumentData { get; set; }//yanıtma Belgesi
	public MaintenanceTransaction? MaintenanceTransaction { get; set; }

	public bool? IsSubstitutionVehicle { get; set; }  
	public MaintenanceSubstitutionVehicle? SubstitutionVehicle { get; set; }

}
