namespace Beon.MyBeon.Middleware.Models;

public class AuthenticateModel
{
    public string? Token { get; set; }  
    public DateTimeOffset? Expiration{ get; set; }
}
