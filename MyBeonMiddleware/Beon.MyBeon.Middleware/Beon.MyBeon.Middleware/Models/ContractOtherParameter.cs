﻿namespace Beon.MyBeon.Middleware.Models;

public class ContractOtherParameter
{
    public DateTime CreatedOn { get; set; }
    public ApplicationUser Owner { get; set; }
    public int  LineNumber{ get; set; }
    public string  Name { get; set; }
    public string Desription { get; set; }
    public bool IsActive { get; set; }

}
