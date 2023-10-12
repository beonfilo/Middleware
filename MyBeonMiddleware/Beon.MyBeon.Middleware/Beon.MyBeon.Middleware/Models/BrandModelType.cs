using Beon.MyBeon.Middleware.Models.BaseModels;

namespace Beon.MyBeon.Middleware.Models
{
    public class BrandModelType : BaseModel
    {
        public BrandType? BrandType { get; set; }
        public string? Name {  get; set; }  
    }
}
