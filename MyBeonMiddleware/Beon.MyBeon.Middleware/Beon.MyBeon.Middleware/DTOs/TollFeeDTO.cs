using System.Security.Cryptography;

namespace Beon.MyBeon.Middleware.DTOs
{
    public class TollFeeDTO
    {
		public string? TollNumberDesc { get; set; }
		public Guid? Vehicle { get; set; }
		public Guid? Roadway { get; set; }
		public string? EntryTollPointDesc { get; set; }
		public string? ExitTollPointDesc { get; set; }
		public DateTime? EntryDate { get; set; }
		public DateTime? ExitDate { get; set; }
		public DateTime? TransactionOn { get; set; }
		public Guid? ContractTransactionVehicle { get; set; }
		public Guid? ContractTransaction { get; set; }
		public Guid? Owner { get; set; }
		public Guid? Customer { get; set; }
		public double ChargeOutPrice { get; set; } = 0;
		public int? ChargeOutStatus { get; set; } = 1;

	}
}
