namespace Beon.MyBeon.Middleware.Models.BaseModels
{
	public class BaseSubstitutionVehicle : BaseModel
	{
		public string Status { get; set; } = string.Empty;
		public string SubstitutionType { get; set; } = string.Empty;
		public DateTime CreatedOn { get; set; } = DateTime.Now;
		//public ApplicationUser _owner;
		public string Code { get; set; } = string.Empty;
		public string CoveredBy { get; set; } = string.Empty;
		public Vehicle? Vehicle { get; set; }
		public Customer? Customer { get; set; }
		public CustomerContact? CustomerContact { get; set; }
		public SubstitutionVehicleCompany? SubstitutionVehicleCompany { get; set; }
		public SubstitutionVehicleServiceCard? SubstitutionVehicleServiceCard { get; set; }
		public double DailyPrice { get; set; } = default;
		public string SubstitutionPlate { get; set; } = string.Empty;
		public Vehicle? SubstitutionVehicle { get; set; }
		public DateTime StartOn { get; set; }
		public int PlanningDay { get; set; } = default;
		public DateTime PlanningEndOn { get; set; } = DateTime.Now;
		public DateTime ActualEndOn { get; set; } = DateTime.Now;
		public TimeSpan ActualEndTime { get; set; } = default;
		public City? City { get; set; }
		public County? County { get; set; }
		public string Description { get; set; } = string.Empty;
		//public ApplicationUser _completedBy;
		public string ChargeoutStatus { get; set; } = string.Empty;
		public double ChargeoutPrice { get; set; } = default;
		public string ChargeoutDocumentData { get; set; } = string.Empty;//yanıtma Belgesi
	}
}
