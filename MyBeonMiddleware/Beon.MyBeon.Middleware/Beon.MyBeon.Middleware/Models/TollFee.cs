using Beon.MyBeon.Middleware.Models.BaseModels;

namespace Beon.MyBeon.Middleware.Models;

public class TollFee : BaseFollowUpTransaction
{
    public string? TollFeeId { get; set; }  
    public string? TollFeeServiceCard { get; set; }
    public TollNumber? TollNumber { get; set; }
    public City? EntryCity { get; set; }
    public TollPoint? EntryTollPoint { get; set; }
    public TollPoint? ExitTollPoint { get; set; }
	public string? EntryTollPointDesc { get; set; }  
	public string? ExitTollPointDesc { get; set; }  
	public City? ExitCity { get; set; }
    public DateTimeOffset? EntryDate { get; set; }
    public DateTimeOffset? ExitDate{ get; set; }
    public Roadway? Roadway { get; set; }
	public string? RoadWayDesc { get; set; }  
	public string? TollFeeInvoicePool { get; set; }
	public DateTime? ToolFeeRegistrationDate { get; set; }
    public DateTime? TerviceRegistrationDate { get; set; }
}
