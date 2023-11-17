namespace Beon.MyBeon.Middleware.Models.BaseModels;

public class BaseDocumentV2 : BaseModel
{
	public ApplicationUser? Owner { get; set; }
	public DateTime? CreatedOn { get; set; }
	public FileData? FileData { get; set; }
}
