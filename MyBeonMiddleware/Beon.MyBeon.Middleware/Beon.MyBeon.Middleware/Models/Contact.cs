using Beon.MyBeon.Middleware.Models.BaseModels;

namespace Beon.MyBeon.Middleware.Models
{
    public class Contact : BaseModel
	{
		public string? Firstname { get; set; }   
		public string? Lastname { get; set; }  
		public string? Tckn { get; set; }  
		public string? Telephone { get; set; }  
		public string? Email { get; set; }  
		public string? Address { get; set; }  
		public bool? IsActive { get; set; } = default;
	}
}