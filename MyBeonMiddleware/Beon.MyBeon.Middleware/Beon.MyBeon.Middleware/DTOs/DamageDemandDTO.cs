namespace Beon.MyBeon.Middleware.DTOs;

public record DamageDemandDTO(Guid Vehicle, int Kilometer, int CoveredBy, int RepairType, Guid VehicleInsurancePolicy, Guid InsuranceCompany, int ExemptionTotal, int DefectRate, int DamageCause, DateTime DamageDate, TimeSpan DamageTime, Guid City, Guid County, int RecordType, int IsBodilyHarm, int IsContactedWithInsurance, int VehicleStatus, int BroughtByType, string BroughtByFirstname, string BroughtByLastname, string BroughtByTelephone, string BroughtByEMail);
