using Beon.MyBeon.Middleware.Models.BaseModels;

namespace Beon.MyBeon.Middleware.Models;

public class VehicleDelivery : BaseModel
{
    public string Status { get; set; } = string.Empty;
    public DateTime? CreatedOn { get; set; }
    public ApplicationUser? Owner { get; set; }
    public string Code { get; set; } = string.Empty;
    public Customer? Customer { get; set; }
    public Contract? Contract { get; set; }
    public ContractTransaction? ContractTransaction { get; set; }
    public ContractTransactionVehicle? ContractTransactionVehicle { get; set; }
    public Vehicle? Vehicle { get; set; }
    public VehicleBrand? Brand { get; set; }
    public VehicleBrandModel? Model { get; set; }
    public VehicleBrandModelPackage? Package { get; set; }
    public DateTime? DeliveryDate { get; set; }
    public double DeliveryKilometer { get; set; } = default;
    public ApplicationUser? DelivererBy { get; set; }
    public CustomerContact? Recipient { get; set; }
    public FileData? DeliveryDocument { get; set; }
    public double TyreChangeKilometer { get; set; } = default;
    public DateTime? InvoiceStartDate { get; set; }
    public DateTime? EstimatedDeliveryDate { get; set; }
}
