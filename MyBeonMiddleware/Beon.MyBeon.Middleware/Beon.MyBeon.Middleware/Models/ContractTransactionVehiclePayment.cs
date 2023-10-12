using Beon.MyBeon.Middleware.Models.BaseModels;

namespace Beon.MyBeon.Middleware.Models;

public class ContractTransactionVehiclePayment : BaseModel
{
	public ContractTransactionVehicle? ContractTransactionVehicle { get; set; }
	public string? InvoiceStatus { get; set; } 
	public int? InstallmentNumber { get; set; }  
	public DateTime? StartDate { get; set; }
	public DateTime? EndDate { get; set; } 
	public DateTime? InstallmentDate { get; set; }
	public int? Year { get; set; }   
	public int? Month { get; set; } 
	public double? Total { get; set; } 
	public double? TotalVat { get; set; } 
	public double? NetTotal { get; set; } 
	public int? TotalDay { get; set; } 
	public double? DailyPrice { get; set; }  
	public RentalFeeTransaction? RentalFeeTransaction { get; set; }
}
