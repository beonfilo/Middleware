using Beon.MyBeon.Middleware.Models.BaseModels;

namespace Beon.MyBeon.Middleware.Models;

public class VehicleReturnDocumentV2 : BaseDocumentV2
{
	public BaseVehicleReturnTransaction? BaseVehicleReturnTransaction {  get; set; }	
}
