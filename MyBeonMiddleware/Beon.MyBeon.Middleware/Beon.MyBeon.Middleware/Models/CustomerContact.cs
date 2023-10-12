using Beon.MyBeon.Middleware.Models.BaseModels;

namespace Beon.MyBeon.Middleware.Models;

public class CustomerContact : BaseContact
{
    public Customer? Customer { get; set; }
    public bool? IsPrivatePerson { get; set; }  
}
