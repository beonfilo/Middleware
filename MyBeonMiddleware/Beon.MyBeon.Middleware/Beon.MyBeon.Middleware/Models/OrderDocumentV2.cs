using Beon.MyBeon.Middleware.Models.BaseModels;

namespace Beon.MyBeon.Middleware.Models;

public class OrderDocumentV2 : BaseDocumentV2
{
	public Order? Order { get; set; }
}
