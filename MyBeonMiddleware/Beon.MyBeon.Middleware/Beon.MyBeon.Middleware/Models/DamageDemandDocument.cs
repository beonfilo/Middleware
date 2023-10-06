namespace Beon.MyBeon.Middleware.Models;

public class DamageDemandDocument
{
    public DamageDemand? Demand { get; set; }
    public DamageDocumentType? DocumentType { get; set; }
    public FileData? DocumentData { get; set; }
    public string Description { get; set; } = string.Empty;
}
