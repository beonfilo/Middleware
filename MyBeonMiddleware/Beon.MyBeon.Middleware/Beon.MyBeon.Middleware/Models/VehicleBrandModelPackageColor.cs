using Beon.MyBeon.Middleware.Models.BaseModels;

namespace Beon.MyBeon.Middleware.Models
{
    public class VehicleBrandModelPackageColor : BaseModel
    {
        public VehicleBrandModel? VehicleBrandModel { get; set; } 
        public BrandModelType? BrandModelType { get; set; }
        public BrandModelPackageType? PackageType { get; set; } 
        public TyreDimension? TyreDimension { get; set; } 
        public MotorType? MotorType { get; set; } 
        public MotorHorsePowerType? HorsePowerType { get; set; } 
        public FuelType? FuelType { get; set; } 
        public BodyType? BodyType { get; set; } 
        public byte[]? FrontView { get; set; } 
        public byte[]? BackView { get; set; } 
        public int Width { get; set; } = default;
        public int Height { get; set; } = default; 
        public int Length { get; set; } = default;
        public int TrunkVolume { get; set; } = default;
        public int FuelTankVolume { get; set; } = default;
        public int NumberOfSeats { get; set; } = default;
        public int NumberOfDoors { get; set; } = default;
        public int Weight { get; set; } = default;
        public int WheelBase { get; set; } = default;
        public TractionSystemType? TractionSystemType { get; set; }
        public double UrbanFuelConsumption { get; set; } = default;
        public double ExtraUrbanFuelConsumption { get; set; } = default;
        public double AverageFuelConsumption { get; set; } = default;
        public GearType? GearType { get; set; } 

    }
}
