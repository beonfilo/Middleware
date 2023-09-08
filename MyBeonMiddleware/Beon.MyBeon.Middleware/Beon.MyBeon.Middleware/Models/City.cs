using Beon.MyBeon.Middleware.Models.BaseModels;

namespace Beon.MyBeon.Middleware.Models
{
    public class City : BaseModel
    {
        //public int ReferenceId { get; set; } = default;
        public Country? Country { get; set; } = default;
        public string Name { get; set; } = string.Empty;
        public string Code { get; set; } = string.Empty;
        public double Longitude { get; set; } = default;
        public double Latitude { get; set; } = default;
    }
}
