using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beon.MyBeon.Middleware.Models;

public class Division
{
    public int Number { get; set; } = default;
    public string Name { get; set; } = string.Empty;
    public int ReferenceId { get; set; } = default;
    public IntegrationResult?  IntegrationResult { get; set; }
}
