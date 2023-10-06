using Beon.MyBeon.Middleware.Models.BaseModels;

namespace Beon.MyBeon.Middleware.Models;

public class TollFee : BaseFollowUpTransaction
{
    public string TollFeeId { get; set; } = string.Empty;
    //public TollFeeServiceCard _tollFeeServiceCard;
    public TollNumber? TollNumber { get; set; }
    public City? EntryCity { get; set; }
    public TollPoint? EntryTollPoint { get; set; }
    public TollPoint? ExitTollPoint { get; set; }
	public string EntryTollPointDesc { get; set; } = string.Empty;
	public string ExitTollPointDesc { get; set; } = string.Empty;
	public City? ExitCity { get; set; }
    public DateTime? EntryDate { get; set; }
    public DateTime? ExitDate{ get; set; }
    public Roadway? Roadway { get; set; }
	public string RoadWayDesc { get; set; } = string.Empty;
	//public TollFeeInvoicePool _tollFeeInvoicePool;
	public DateTime? ToolFeeRegistrationDate { get; set; }
    public DateTime? TerviceRegistrationDate { get; set; }
}
