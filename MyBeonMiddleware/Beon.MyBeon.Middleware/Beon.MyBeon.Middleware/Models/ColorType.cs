namespace Beon.MyBeon.Middleware.Models;

public class ColorType
{
    public ColorType? Color { get; set; }
    public string Code { get; set; } = string.Empty;
    public string Name { get; set; } = string.Empty;
    public bool IsActive { get; set; } = default;
}
