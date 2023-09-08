using Beon.MyBeon.Middleware.Models.BaseModels;

namespace Beon.MyBeon.Middleware.Models
{
    public class MotorHorsePowerType : BaseModel
    {
        public MotorType? MotorType { get; set; } = default;
        public int HorsePower { get; set; } = default;
    }
}
