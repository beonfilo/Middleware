using Beon.MyBeon.Middleware.Models.BaseModels;

namespace Beon.MyBeon.Middleware.Models;

public class ConnectionParameter
{
    public string ConnectionString { get; set; }
    public  string ServerName { get; set; }
    public string  UserId { get; set; }
    public string Password { get; set; }
    public string  InitialCatalog { get; set; }
    public int DefaultFirmNumber { get; set; }
    public int DefaultPeriodNumber { get; set; }
    public BaseCustomer DefaultCustomer { get; set; }
    public  bool IsActive { get; set; }
}
