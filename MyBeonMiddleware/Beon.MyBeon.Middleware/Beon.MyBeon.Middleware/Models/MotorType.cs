using Beon.MyBeon.Middleware.Models.BaseModels;

namespace Beon.MyBeon.Middleware.Models
{
    public class MotorType : BaseModel
    {
        public string? Name { get; set; }  
        public int? MotorVolume { get; set; }  
        public int? NumberOfCylinders { get; set; }  
        public int? MotorPower { get; set; }  
        public int? Torque { get; set; }  
        public int? MaximumSpeed { get; set; }  
        public bool? IsActive { get; set; }  
    }
}
