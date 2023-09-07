namespace Beon.MyBeon.Middleware.Models.BaseModels
{
    public class BaseCustomer : BaseModel
    {
        public string BaseCustomerCardType { get; set; } = string.Empty;
        public string Code { get; set; } = string.Empty;        
        public string Title { get; set; } = string.Empty;
        public string TaxOffice { get; set; } = string.Empty;
        public string TaxNumber { get; set; } = string.Empty;

    }
}
