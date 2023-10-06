using Beon.MyBeon.Middleware.Models.BaseModels;

namespace Beon.MyBeon.Middleware.Models;

public class ConnectionParameter
{
    public string ConnectionString { get; set; } = string.Empty;
    public string ServerName { get; set; } = string.Empty;
    public string UserId { get; set; } = string.Empty;
    public string Password { get; set; } = string.Empty;
    public string InitialCatalog { get; set; } = string.Empty;
    public int DefaultFirmNumber { get; set; }
    public int DefaultPeriodNumber { get; set; }
    public BaseCustomer? DefaultCustomer { get; set; }
    public  bool IsActive { get; set; }
}
