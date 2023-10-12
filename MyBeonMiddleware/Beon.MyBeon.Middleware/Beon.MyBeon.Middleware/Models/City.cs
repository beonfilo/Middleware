using Beon.MyBeon.Middleware.Models.BaseModels;

namespace Beon.MyBeon.Middleware.Models
{
    public class City : BaseModel
    {
        public Country? Country { get; set; }  
        public string? Name { get; set; }  
        public string? Code { get; set; } 
        public double? Longitude { get; set; }  
        public double? Latitude { get; set; }  
    }
}
