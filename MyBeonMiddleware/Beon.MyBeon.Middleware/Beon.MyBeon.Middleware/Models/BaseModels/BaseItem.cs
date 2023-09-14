namespace Beon.MyBeon.Middleware.Models.BaseModels
{
	public class BaseItem : BaseModel
	{
		public string IntegrationResult { get;set; } = string.Empty;
		public string CardType { get;set; } = string.Empty;
		public string Code { get;set; } = string.Empty;
		public string Name { get; set; } = string.Empty;
		public string Specode { get; set; } = string.Empty;
		public string Specode2 { get; set; } = string.Empty;
		public string Specode3 { get; set; } = string.Empty;
		public string Specode4 { get; set; } = string.Empty;
		public string Specode5 { get; set; } = string.Empty;
		public string Cyphcode { get; set; } = string.Empty;
		public int Vat { get; set; } = 0;
		public Unitset? Unitset { get; set; }
		public bool IsActive { get; set; } = false;
	}
}
