using Beon.MyBeon.Middleware.Models.BaseModels;
using System.ComponentModel.DataAnnotations;

namespace Beon.MyBeon.Middleware.Models;

public class ContractTransactionVehicle : BaseModel
{
    public string Code { get; set; } = string.Empty;
    public ContractTransaction? ContractTransaction { get; set; }
    public int LineNumber { get; set; } = default;
    public string Status { get; set; }=string.Empty;
   // public VehicleTollFeeStatus _tollFeeStatus;//hgs var/yok varsa beon öder, yoksa müşteri öder
    public Vehicle? Vehicle{get; set;}
    public VehicleBrand? Brand{get; set;}
    public VehicleBrandModel? Model{get;set;}
    public VehicleBrandModelPackage? Package{get; set;}
    public VehicleBrandModelPackageYear? Year{get; set;}
    public GearType? GearType{get; set;}
    //public OrderTransactionVehicle _orderTransactionVehicle;
    public DateTime InvoiceStartDate { get; set; }
    public DateTime InvoiceEndDate { get; set; }
    public DateTime EstimatedRetrievalOn { get; set; }
    public DateTime ActualRetrievalOn { get; set; }
    public double PoolKilometer { get; set; } = default;
    public bool IsPoolKilometer { get; set; } = default;
    public double ExtraKilometerPrice { get; set; } = default; //fazla km bedeli
    public double MissingKilometerPrice { get; set; } = default;//eksik km bedlei
    public double UnitPrice { get; set; } = default;
    public double Kilometer { get; set; } = default;
    public int Month { get; set; } = default;
    public int TotalDay { get; set; } = default;
    //public VatType _vatType;
    public int VatRate { get; set; } = default;
    public double Total { get; set; } = default;
    public double TotalDiscount { get; set; } = default;
    public double TotalVat { get; set; } = default;
    public double LineNet { get; set; } = default;
    //public ContractTransactionVehicleRevision _revision;
    public int RevisionNumber { get; set; } = default;
    public ContractTransactionVehicle? HandoverContractTransactionVehicle { get; set; }
}
