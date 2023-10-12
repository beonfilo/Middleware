using Beon.MyBeon.Middleware.Models.BaseModels;

namespace Beon.MyBeon.Middleware.Models
{
    public class VehicleView : BaseModel
    {
        public string? Status { get; set; }
        public string? Plate { get; set; }
        public Guid? CustomerOid { get; set; }
        public string? Customer { get; set; }
        public string? ParentCustomer { get; set; }
        public DateTime? InvoiceStartDate { get; set; }
        public DateTime? InvoiceEndDate { get; set; }
        public double? UnitPrice { get; set; }
        public int? Kilometer { get; set; }
        public int? Month { get; set; }
        public double? DeclarationLimit { get; set; }
        public double? ExtraKilometerPrice { get; set; }
        public int? PoolKilometer { get; set; }
        public bool? IsVehiclePledge { get; set; }
        public string? BrandName { get; set; }
        public string? ModelName { get; set; }
        public string? PackageName { get; set; }
        public string? ModelYear { get; set; }
        public string? FuelType { get; set; }
        public string? GearType { get; set; }
        public string? Color { get; set; }
        public bool? IsActive { get; set; }
    }
}
