namespace Beon.MyBeon.Middleware.Models;

public class ContractOtherParameter
{
    public DateTime CreatedOn { get; set; }
    public ApplicationUser? Owner { get; set; }
    public int  LineNumber{ get; set; }
    public string Name { get; set; } = string.Empty;
    public string Desription { get; set; } = string.Empty;
    public bool IsActive { get; set; }

}
