using Beon.MyBeon.Middleware.Models.BaseModels;

namespace Beon.MyBeon.Middleware.Models
{
    public class Unitset : BaseModel
    {
        public string? Code { get; set; }
        public string? Name { get; set; }
        public string? IntegrationResult { get; set; }
    }
}
