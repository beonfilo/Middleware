using Beon.MyBeon.Middleware.Models.BaseModels;

namespace Beon.MyBeon.Middleware.Models;

public class ContractProtocol : BaseModel
{
    public Contact? Contact { get; set; }
    public string? FileName { get; set; } 
    public ApplicationUser? Owner { get; set; }
    public DateTime? CreatedOn { get; set; }
    public DateTime? SigningDate { get; set; }
    public FileData? ProtocolFile { get; set; }
    public string? Description { get; set; } 
}
