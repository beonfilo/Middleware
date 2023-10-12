using Beon.MyBeon.Middleware.Models.BaseModels;

namespace Beon.MyBeon.Middleware.Models
{
    public class QuoteTransactionVehicle : BaseModel
    {
        public QuoteTransaction? QuoteTransaction { get; set; }
        public int? LineNumber { get; set; }
        public DateTime? OptionDate { get; set; }
        public Vehicle? Vehicle { get; set; }
        public VehicleBrand? Brand { get; set; }
        public VehicleBrandModel? Model { get; set; }
        public VehicleBrandModelPackage? Package { get; set; }
        public VehicleBrandModelPackageYear? Year { get; set; }
        public GearType? GearType { get; set; }
    }
}