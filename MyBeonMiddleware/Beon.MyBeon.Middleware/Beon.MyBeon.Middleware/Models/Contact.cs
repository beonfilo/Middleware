using Beon.MyBeon.Middleware.Models.BaseModels;

namespace Beon.MyBeon.Middleware.Models
{
	public class Contact : BaseModel
	{
		public string Firstname { get; set; }  = string.Empty;
		public string Lastname { get; set; } = string.Empty;
		public string Tckn { get; set; } = string.Empty;
		public string Telephone { get; set; } = string.Empty;
		public string Email { get; set; } = string.Empty;
		public string Address { get; set; } = string.Empty;
		public bool IsActive { get; set; } = default;
	}
}