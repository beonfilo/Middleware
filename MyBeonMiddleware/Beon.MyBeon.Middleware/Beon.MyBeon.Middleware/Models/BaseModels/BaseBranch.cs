namespace Beon.MyBeon.Middleware.Models.BaseModels
{
	public class BaseBranch :BaseModel
	{
		public string CardType { get; set; } = string.Empty;
		public BaseCustomer? BaseCustomer { get; set; }
		public string Code { get; set; } = string.Empty;
		public string Name { get; set; } = string.Empty;
		public City? City { get; set; }
		public County? County { get; set; }
		public string Telephone { get; set; } = string.Empty;
		public string OtherTelephone { get; set; } = string.Empty;
		public string EMail { get; set; } = string.Empty;
		public bool IsActive { get; set; } = default;
	}
}
