using Beon.MyBeon.Middleware.Models.BaseModels;

namespace Beon.MyBeon.Middleware.Models;

public class FileData : BaseModel
{
    public string? FileName { get; set; } 
    public int? Size { get; set; }
    public byte[]? Content { get; set; }
}
