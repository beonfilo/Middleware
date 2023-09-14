﻿namespace Beon.MyBeon.Middleware.Models.BaseModels
{
	public class BaseDemand : BaseModel
	{
		public string DemandType { get; set; } = string.Empty;
		public string Status { get; set; } = string.Empty;
		public DateTime CreatedOn { get; set; } = DateTime.Now;
		//public ApplicationUser _owner;
		public BaseAppointment? BaseAppointment { get; set; }
		public BaseProforma? BaseProforma { get; set; }
		public string Code { get; set; } = string.Empty;
		public Vehicle? Vehicle { get; set; }
		public Contract? Contract { get; set; }
		public Customer? Customer { get; set; }
		public CustomerContact? CustomerContact { get; set; }

		public City? City { get; set; }
		public County? County { get; set; }

		public string DemandCause { get; set; } = string.Empty;
		public string Description { get; set; } = string.Empty;

		public double ProjectedCost { get; set; } = default;
		public double RealizedCost { get; set; } = default;

		public ReasonForRejection? ReasonForRejection { get; set; }
		public string RejectionDescription { get; set; } = string.Empty;
		public DateTime RejectionOn { get; set; } = DateTime.Now;
		//public ApplicationUser _rejectionOwner;
	}
}
