namespace Beon.MyBeon.Middleware.Models
{
    public class Sector : SectorTree
    {
        public string? Code { get; set; }  
        public Sector? ParentSector { get; set; }
        public bool? IsActive { get; set; } 
    }
}