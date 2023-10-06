namespace Beon.MyBeon.Middleware.Models;

public class CleaningDemand
{
    public CleaningDemand? Status { get; set; }
    public DateTime CreatedOn { get; set; }
    public ApplicationUser? Owner{ get; set; }
    public string Code { get; set; } = string.Empty;
    public Vehicle? Vehicle { get; set; }
    public CleaningType? CleaningType { get; set; }
    public CleaningCause? CleaningCause{ get; set; }
}
