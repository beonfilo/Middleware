namespace Beon.MyBeon.Middleware.Models
{
    public class Sector : SectorTree
    {
        public string Code { get; set; } = string.Empty;
        public Sector? ParentSector { get; set; }
        public bool IsActive { get; set; } = default;
    }
}