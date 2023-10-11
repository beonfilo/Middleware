namespace Beon.MyBeon.Middleware.Models;

public class CleaningType
{
    public DateTime CreatedOn { get; set; }
    public ApplicationUser? Owner { get; set; }
    public string Name { get; set; } = string.Empty;
    public bool IsActive { get; set; } = default;
}
