using Beon.MyBeon.Middleware.Models.BaseModels;

namespace Beon.MyBeon.Middleware.Models
{
    public class Country : BaseModel
    {
        public int? Number { get; set; } 
        public string? Name { get; set; }  
        public string? Code { get; set; }  
    }
}
