namespace Beon.MyBeon.Middleware.Models;

public class CleaningType
{
    public DateTime CreatedOn { get; set; }
    public ApplicationUser Owner { get; set; }
    public string Name { get; set; }
    public bool  IsActive { get; set; }
}
