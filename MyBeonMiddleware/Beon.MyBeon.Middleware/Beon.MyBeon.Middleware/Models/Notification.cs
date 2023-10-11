namespace Beon.MyBeon.Middleware.Models
{
    public class Notification : BaseObject
    {
        public string? Title { get; set; }
        public string? Description { get; set; }
        public bool? IsRead { get; set; }
        public ApplicationUser? ApplicationUser { get; set; }
    }
}
