using Beon.MyBeon.Middleware.Models.BaseModels;

namespace Beon.MyBeon.Middleware.Models;

public class SubUnitset : BaseModel
{
	public string? Code { get; set; }  
	public string? Name { get; set; }  
	public double? ConversionFactor { get; set; }  
	public double? OtherConversionFactor { get; set; }  
	public bool? IsMainUnit { get; set; }  
	public Unitset? Unitset { get; set; }
	public int? ReferenceId { get; set; }  
	public string? IntegrationResult{get; set; }
}
