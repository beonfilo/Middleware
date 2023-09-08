using Beon.MyBeon.Middleware.Models.BaseModels;

namespace Beon.MyBeon.Middleware.Models
{
    public class MotorType : BaseModel
    {
        public string Name { get; set; } = string.Empty;
        public int MotorVolume { get; set; } = default;
        public int NumberOfCylinders { get; set; } = default;
        public int MotorPower { get; set; } = default;
        public int Torque { get; set; } = default;
        public int MaximumSpeed { get; set; } = default;
        public bool IsActive { get; set; } = default;
    }
}
