using Beon.MyBeon.Middleware.Models.BaseModels;

namespace Beon.MyBeon.Middleware.Models;

public class MediaDataObject : BaseModel
{
    public string? MediaDataKey { get; set; } 
    public byte[]? MediaData { get; set; }
}
