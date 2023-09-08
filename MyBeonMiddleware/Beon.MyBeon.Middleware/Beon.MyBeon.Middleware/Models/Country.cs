using Beon.MyBeon.Middleware.Models.BaseModels;

namespace Beon.MyBeon.Middleware.Models
{
    public class Country : BaseModel
    {
        //public int _referenceId;
        public int Number { get; set; } =default;
        public string Name { get; set; } = string.Empty;
        public string Code { get; set; } = string.Empty;
    }
}
