using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beon.MyBeon.Middleware.Models;

public class ContractParameter
{
    public DateTime CreadOn { get; set; }
    public ApplicationUser Owner { get; set; }
    public int LineNumber { get; set; }
    public string Name { get; set; }
    public  string Desription { get; set; }
    public bool IsActive  { get; set; }
}
