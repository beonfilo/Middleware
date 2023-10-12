using Beon.MyBeon.Middleware.Models.BaseModels;

namespace Beon.MyBeon.Middleware.Models;

public class ContractTransaction : BaseModel
{
    public DateTime? CreatedOn { get; set; }
    public string? Code { get; set; }  
    public Contract? Contract { get; set; }
    public Customer? Customer { get; set; }
    public int? LineNumber { get; set; }  
    public VehicleBrand? Brand{ get; set; }
    public VehicleBrandModel? Model{ get; set; }
    public VehicleBrandModelPackage? Package { get; set; }
    public double? Quantity { get; set; }  
    public double? UnitPrice { get; set; }  
    public double? Kilometer { get; set; }  
    public int? Month { get; set; }  
    public int? TotalDay { get; set; }  
    public int? VatRate { get; set; }  
    public double? Discount { get; set; }  
    public double? Total { get; set; }  
    public double? TotalDiscount { get; set; }  
    public double? TotalVat { get; set; }  
    public double? LineNet { get; set; }  
    public string? Description { get; set; }  
    public DateTime? StatusChangeDate{ get; set; }
    public string? RejectedDescription { get; set; }  
    public double? ExtraKilometerPrice { get; set; }  
    public double? MissingKilometerPrice { get; set; }  
    public double? DeclarationLimit { get; set; }  
    public double? PoolKilometer { get; set; }  
    public ContractTransaction? HandoverContractTransaction { get; set; }
    public ApplicationUser? Owner { get; set; }


}
