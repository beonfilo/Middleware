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
        public int? Width { get; set; }  
        public int? Height { get; set; }   
        public int? Length { get; set; }  
        public int? TrunkVolume { get; set; }  
        public int? FuelTankVolume { get; set; }  
        public int? NumberOfSeats { get; set; }  
        public int? NumberOfDoors { get; set; }  
        public int? Weight { get; set; }  
        public int? WheelBase { get; set; }  
        public TractionSystemType? TractionSystemType { get; set; }
        public double? UrbanFuelConsumption { get; set; }  
        public double? ExtraUrbanFuelConsumption { get; set; }  
        public double? AverageFuelConsumption { get; set; }  
        public GearType? GearType { get; set; } 

    }
}
