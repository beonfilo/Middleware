using Beon.MyBeon.Middleware.Models.BaseModels;
using System.Drawing;

namespace Beon.MyBeon.Middleware.Models;

public class ColorType : BaseModel
{
    public Color? Color { get; set; }
    public string? Code { get; set; } 
    public string? Name { get; set; } 
    public bool? IsActive { get; set; }  
}
