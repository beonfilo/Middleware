using Beon.MyBeon.Middleware.Models.BaseModels;

namespace Beon.MyBeon.Middleware.Models
{
    public class Bank : BaseModel
    {
        //public IntegrationResult _integrationResult;
       //public int _referenceId;
        public string Code { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public string BranchNumber { get; set; } = string.Empty;
        public string BranchName { get; set; } = string.Empty;
        public string EMailAddress { get; set; } = string.Empty;
        public string Incharge { get; set; } = string.Empty;
        public string Telephone { get; set; } = string.Empty;
        public string OtherTelephone { get; set; } = string.Empty;
        public bool IsActive { get; set; } = default;
    }
}
