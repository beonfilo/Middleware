namespace Beon.MyBeon.Middleware.DTOs;

public record MaintenanceDemandDTO
(
    double? Kilometer,
    Guid? MaintenanceServiceCard,
    Guid? Appointment,
    Guid? Proforma,
    int? MaintenanceType,
    Guid? MaintenanceCategory,
    Guid? DemandedServiceShop,
    Guid? PeriodicMaintenanceParameter,
    short? IsSubstitutionVehicle,
    Guid? DemandedServiceShopBranch
    
);
