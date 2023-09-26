namespace Beon.MyBeon.Middleware.Models;

public class EmailSetting
{
    public string Name { get; set; }
    public string FromMailAddress{ get; set; }
    public string  FromMailAddressPassword{ get; set; }
    public int Port{ get; set; }
    public bool UseSSL { get; set; }
    public string SmtpAddress { get; set; }
    public bool IsActive { get; set; }
}
