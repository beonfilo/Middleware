using Beon.MyBeon.Middleware.Models.BaseModels;

namespace Beon.MyBeon.Middleware.Models
{
    public class VehicleBrand : BaseModel
    {
        public byte[]? BrandImage { get; set; }
        public string Code { get; set; } = string.Empty;
		public string Name { get; set; } = string.Empty;
		public BrandType? BrandType { get; set; }
        public string History { get; set; } = string.Empty;
        public string CustomerService { get; set; } = string.Empty;
        public DateTime EstablishmentDate { get; set; } = DateTime.Now;
        public string WebAddress { get; set; } = string.Empty;
        public bool IsActive { get; set; } = default;

    }
}
