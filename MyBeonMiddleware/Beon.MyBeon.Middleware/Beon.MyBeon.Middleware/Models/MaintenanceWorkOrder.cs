using Beon.MyBeon.Middleware.Models.BaseModels;

namespace Beon.MyBeon.Middleware.Models;

public class MaintenanceWorkOrder : BaseWorkOrder
{
	public MaintenanceDemand? Demand { get; set; }
	public MaintenanceAppointment? Appointment { get; set; }
	public MaintenanceProforma? Proforma { get; set; }
	public string MaintenanceType { get; set; }= string.Empty;
	public double Kilometer { get; set; } = default;
	public MaintenanceCategory? MaintenanceCategory { get; set; }
	public PeriodicMaintenanceParameter? PeriodicMaintenanceParameter { get; set; }

	public int InvoiceReferenceId { get; set; } = default;
	public string InvoiceNumber { get; set; } = string.Empty;
	public string InvoiceStatus { get; set; } = string.Empty;

	public FileData? ChargeoutDocumentData { get; set; }//yanıtma Belgesi

	public MaintenanceTransaction? MaintenanceTransaction { get; set; }

	public bool IsSubstitutionVehicle { get; set; } = default;
	public MaintenanceSubstitutionVehicle? SubstitutionVehicle { get; set; }

}
