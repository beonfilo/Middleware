using Beon.MyBeon.Middleware.Models.BaseModels;

namespace Beon.MyBeon.Middleware.Models;

public class ContractTransactionVehiclePayment : BaseModel
{
	public ContractTransactionVehicle? ContractTransactionVehicle { get; set; }
	public string ContractTransactionVehiclePaymentInvoiceStatus { get; set; } = string.Empty;
	public int InstallmentNumber { get; set; } = default;
	public DateTime StartDate { get; set; } = default;
	public DateTime EndDate { get; set; } = default;
	public DateTime InstallmentDate { get; set; } = default;
	public int Year { get; set; } = default;
	public int Month { get; set; } = default;
	public double Total { get; set; } = default;
	public double TotalVat { get; set; } = default;
	public double NetTotal { get; set; } = default;
	public int TotalDay { get; set; } = default;
	public double DailyPrice { get; set; } = default;
	public RentalFeeTransaction? RentalFeeTransaction { get; set; }
}
