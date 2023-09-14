using Beon.MyBeon.Middleware.Models.BaseModels;

namespace Beon.MyBeon.Middleware.Models
{
	public class ProformaRevision : BaseModel
	{
		public DateTime CreatedOn { get; set; } = DateTime.Now;
		//public ApplicationUser _owner;
		public string Code { get; set; } = string.Empty;
		public int RevisionNumber { get; set; } = 0;
		public BaseProforma? BaseProforma { get; set; }
		public ProformaRevision? PreviousRevision { get; set; }
	}
}
