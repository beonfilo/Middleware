using Beon.MyBeon.Middleware.Models.BaseModels;

namespace Beon.MyBeon.Middleware.Models
{
    public class Unitset : BaseModel
    {
        //public int _referenceId;
        public string Code { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
       // public IntegrationResult _integrationResult;
    }
}
