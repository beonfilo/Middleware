using Beon.MyBeon.Middleware.Models.BaseModels;

namespace Beon.MyBeon.Middleware.Models
{
    public class Lead : BaseModel
    {
        public string Status { get; set; } = string.Empty;
        public string RiskStatus { get; set; } = string.Empty;
        public DateTime? CreatedOn { get; set; }
        //public ApplicationUser _owner;
        public string Code { get; set; } = string.Empty;
        public string Title { get; set; } = string.Empty;
        public string TaxOffice { get; set; } = string.Empty;
        public string TaxNumber { get; set; } = string.Empty;
        public Country? Country { get; set; }
        public City? City { get; set; }
        public County? County { get; set; }
        public Currency? Currency { get; set; }
        public string Telephone { get; set; } = string.Empty;
        public string OtherTelephone { get; set; } = string.Empty;
        public string Fax { get; set; } = string.Empty;
        public string EMail { get; set; } = string.Empty;
        public string WebAddress { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
        public bool IsActive;
        public bool IsPersonal;
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string Tckn { get; set; } = string.Empty;
        public LeadSource? LeadSource { get; set; }
        public Sector? ParentSector { get; set; }
        public Sector? SubSector { get; set; }
        public Customer? Customer { get; set; }
        public DateTime? StatusChangeDate { get; set; }
        //public ApplicationUser _statusChanger;
    }
}