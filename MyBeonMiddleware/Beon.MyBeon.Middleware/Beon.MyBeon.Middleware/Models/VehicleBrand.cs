using Beon.MyBeon.Middleware.Models.BaseModels;

namespace Beon.MyBeon.Middleware.Models
{
    public class VehicleBrand : BaseModel
    {
        public byte[]? BrandImage { get; set; }
        public string? Code { get; set; }  
		public string? Name { get; set; }  
		public BrandType? BrandType { get; set; }
        public string? History { get; set; }  
        public string? CustomerService { get; set; }  
        public DateTime? EstablishmentDate { get; set; }
        public string? WebAddress { get; set; }  
        public bool? IsActive { get; set; } 

    }
}
