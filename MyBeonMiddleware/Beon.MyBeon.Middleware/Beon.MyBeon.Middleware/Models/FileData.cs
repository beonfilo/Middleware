using Beon.MyBeon.Middleware.Models.BaseModels;

namespace Beon.MyBeon.Middleware.Models;

public class FileData : BaseModel
{
    public string FileName { get; set; } = string.Empty;
    public int Size { get; set; } = default;
    public byte[]? Content { get; set; }
}
