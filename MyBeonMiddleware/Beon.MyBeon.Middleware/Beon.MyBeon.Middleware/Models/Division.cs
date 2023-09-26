using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beon.MyBeon.Middleware.Models;

public class Division
{
    public int Number { get; set; }
    public string Name { get; set; }
    public  int  ReferenceId{ get; set; }
    public IntegrationResult  IntegrationResult { get; set; }
}
