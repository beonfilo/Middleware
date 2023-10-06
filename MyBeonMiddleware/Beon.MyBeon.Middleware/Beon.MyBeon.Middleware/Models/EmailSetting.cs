namespace Beon.MyBeon.Middleware.Models;

public class EmailSetting
{
    public string Name { get; set; } = string.Empty;
    public string FromMailAddress { get; set; } = string.Empty;
    public string FromMailAddressPassword { get; set; } = string.Empty;
    public int Port{ get; set; }
    public bool UseSSL { get; set; }
    public string SmtpAddress { get; set; } = string.Empty;
    public bool IsActive { get; set; }
}
