namespace Beon.MyBeon.Middleware.Models;

public class AuthenticateModel
{
    public string Token { get; set; } = string.Empty;
    public DateTimeOffset Expiration{ get; set; }
}
