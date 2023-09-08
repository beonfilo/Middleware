using Beon.MyBeon.Middleware.Models.BaseModels;

namespace Beon.MyBeon.Middleware.Models;

public class ContractTransaction : BaseModel
{
    public DateTime CreatedOn { get; set; }
    public string Code { get; set; } = string.Empty;
    public Contract? Contract { get; set; }
    public Customer? Customer { get; set; }
    public int LineNumber { get; set; } = default;

    //public VehicleBrand? Brand{ get; set; }
    //public VehicleBrandModel? Brand{ get; set; }
    //public VehicleBrandModelPackage? Brand{ get; set; }
    public double Quantity { get; set; } = default;
    public double UnitPrice { get; set; } = default;
    public double Kilometer { get; set; } = default;
    public int Month { get; set; } = default;
    public int TotalDay { get; set; } = default;
    public int VatRate { get; set; } = default;
    public double Discount { get; set; } = default;
    public double Total { get; set; } = default;
    public double TotalDiscount { get; set; } = default;
    public double TotalVat { get; set; } = default;
    public double LineNet { get; set; } = default;
    public string Description { get; set; } = string.Empty;
    public DateTime StatusChangeDate{ get; set; }
    public string RejectedDescription { get; set; } = string.Empty;
    public double ExtraKilometerPrice { get; set; } = default;
    public double MissingKilometerPrice { get; set; } = default;
    public double DeclarationLimit { get; set; } = default;
    public double PoolKilometer { get; set; } = default;
    public ContractTransaction? HandoverContractTransaction { get; set; }
    // public ApplicationUser? Owner { get; set; }


}
