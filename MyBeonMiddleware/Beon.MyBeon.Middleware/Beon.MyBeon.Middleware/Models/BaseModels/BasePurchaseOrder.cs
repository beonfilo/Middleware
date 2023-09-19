namespace Beon.MyBeon.Middleware.Models.BaseModels
{
    public class BasePurchaseOrder : BaseModel
    {
        public string TargetType { get; set; } = string.Empty;
        public DateTime? CreatedOn { get; set; }
        public DateTime? OrderDate { get; set; }
        public DateTime? DueDate { get; set; }
        //public ApplicationUser _owner{get;set;}
        public string Code { get; set; } = string.Empty;
        public string DocumentNumber { get; set; } = string.Empty;
        public Supplier? Supplier { get; set; }
        public Currency? Currency { get; set; }
        public string Description { get; set; } = string.Empty;
    }
}
