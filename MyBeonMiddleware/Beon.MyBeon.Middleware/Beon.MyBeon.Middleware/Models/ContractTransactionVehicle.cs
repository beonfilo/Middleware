﻿using Beon.MyBeon.Middleware.Models.BaseModels;

namespace Beon.MyBeon.Middleware.Models;

public class ContractTransactionVehicle : BaseModel
{
    public string? Code { get; set; } 
    public ContractTransaction? ContractTransaction { get; set; }
    public int? LineNumber { get; set; }  
    // public ContractTransactionVehicleStatus _status;
    // public VehicleTollFeeStatus _tollFeeStatus;//hgs var/yok varsa beon öder, yoksa müşteri öder
    public Vehicle? Vehicle { get; set; }
    public VehicleBrand? Brand { get; set; }
    public VehicleBrandModel? Model { get; set; }
    public VehicleBrandModelPackage? Package { get; set; }
    public VehicleBrandModelPackageYear? Year { get; set; }
    public GearType? GearType { get; set; }
    //public OrderTransactionVehicle _orderTransactionVehicle;
    public DateTime? InvoiceStartDate { get; set; }
    public DateTime? InvoiceEndDate { get; set; }
    public DateTime? EstimatedRetrievalOn { get; set; }
    public DateTime? ActualRetrievalOn { get; set; }
    public double? PoolKilometer { get; set; }  
    public bool? IsPoolKilometer { get; set; }  
    public double? ExtraKilometerPrice { get; set; } 
    public double? MissingKilometerPrice { get; set; } 
    public double? UnitPrice { get; set; }  
    public double? Kilometer { get; set; } 
    public int? Month { get; set; } 
    public int? TotalDay { get; set; }  
    //public VatType _vatType;
    public int? VatRate { get; set; } 
    public double? Total { get; set; }  
    public double? TotalDiscount { get; set; }  
    public double? TotalVat { get; set; }  
    public double? LineNet { get; set; }  
    //public ContractTransactionVehicleRevision _revision;
    public int? RevisionNumber { get; set; }  
    public ContractTransactionVehicle? HandoverContractTransactionVehicle { get; set; }
}
