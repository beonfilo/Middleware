using Beon.MyBeon.Middleware.Models.BaseModels;

namespace Beon.MyBeon.Middleware.Models
{
    public class BrandModelPackageType : BaseModel
    {
        public BrandModelType? ModelType { get; set; } = default;
        public string Code { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public MotorType? MotorType { get; set; } = default;
        public MotorHorsePowerType? HorsePowerType { get; set; } = default;
        public FuelType? FuelType { get; set; } = default;
        public BodyType? BodyType { get; set; } = default;
        public byte[]? FrontView { get; set; } = default;
        public byte[]? BackView { get; set; } = default;
        public int Width { get; set; } = default;
        public int Height { get; set; } = default;
        public int Length { get; set; } = default;
        public int _TrunkVolume { get; set; } = default;
        public int FuelTankVolume { get; set; } = default;
        public int NumberOfSeats { get; set; } = default;
        public int NumberOfDoors { get; set; } = default;
        public int Weight { get; set; } = default;
        public int WheelBase { get; set; } = default;
        public TractionSystemType? TractionSystemType { get; set; } = default;
        public double UrbanFuelConsumption { get; set; } = default;
        public double ExtraUrbanFuelConsumption { get; set; } = default;
        public double AverageFuelConsumption { get; set; } = default;
    }
}
