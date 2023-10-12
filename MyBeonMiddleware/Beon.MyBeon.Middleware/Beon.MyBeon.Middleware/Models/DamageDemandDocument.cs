using Beon.MyBeon.Middleware.Models.BaseModels;

namespace Beon.MyBeon.Middleware.Models;

public class DamageDemandDocument : BaseModel
{
    public DamageDemand? Demand { get; set; }
    public DamageDocumentType? DocumentType { get; set; }
    public FileData? DocumentData { get; set; }
    public string? Description { get; set; }  
}
