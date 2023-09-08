using System.Diagnostics.Metrics;

namespace Beon.MyBeon.Middleware.Models.BaseModels
{
    public class BaseCustomer : BaseModel
    {
        public string BaseCustomerCardType { get; set; } = string.Empty;
        public string Code { get; set; } = string.Empty;        
        public string Title { get; set; } = string.Empty;
        public string TaxOffice { get; set; } = string.Empty;
        public string TaxNumber { get; set; } = string.Empty;
        public Country? Country { get; set; }
        public City? City { get; set; }
        public County? County { get; set; }
        public Currency? Currency { get; set; }
        public string PostCode { get; set; } = string.Empty;
        public bool EInvoice { get; set; } = default;
        public string Telephone { get; set; } = string.Empty;
        public string OtherTelephone { get; set; } = string.Empty;
        public string Fax { get; set; } = string.Empty;
        public string EMail { get; set; } = string.Empty;
        public string WebAddress { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
        public int ReferenceId { get; set; } =default;
        public int ParentReferenceId { get; set; } = default;
        public bool IsActive { get; set; } = default;
        public bool IsPersonal { get; set; } = default;
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string Fullname { get; set; } = string.Empty;
        public double BaseCustomerDiscountRate;
        public string TCKN { get; set; } = string.Empty;
        public Currency? CurrencyToBeValued { get; set; }
        //private PaymentPlan _paymentPlan;
        private BaseCustomer? ParentBaseCustomer { get; set; }
    }
}
