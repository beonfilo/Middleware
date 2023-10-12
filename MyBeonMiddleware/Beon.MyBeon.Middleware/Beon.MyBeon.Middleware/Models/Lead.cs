using Beon.MyBeon.Middleware.Models.BaseModels;

namespace Beon.MyBeon.Middleware.Models
{
    public class Lead : BaseModel
    {
        public string? Status { get; set; }
        public string? RiskStatus { get; set; }
        public DateTime? CreatedOn { get; set; }
        public ApplicationUser? Owner { get; set; }
        public string? Code { get; set; }
        public string? Title { get; set; }
        public string? TaxOffice { get; set; }
        public string? TaxNumber { get; set; }
        public Country? Country { get; set; }
        public City? City { get; set; }
        public County? County { get; set; }
        public Currency? Currency { get; set; }
        public string? Telephone { get; set; }
        public string? OtherTelephone { get; set; }
        public string? Fax { get; set; }
        public string? EMail { get; set; }
        public string? WebAddress { get; set; }
        public string? Address { get; set; }
        public bool? IsActive { get; set; }
        public bool? IsPersonal { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Tckn { get; set; }
        public LeadSource? LeadSource { get; set; }
        public Sector? ParentSector { get; set; }
        public Sector? SubSector { get; set; }
        public Customer? Customer { get; set; }
        public DateTime? StatusChangeDate { get; set; }
        public ApplicationUser? StatusChanger { get; set; }
    }
}