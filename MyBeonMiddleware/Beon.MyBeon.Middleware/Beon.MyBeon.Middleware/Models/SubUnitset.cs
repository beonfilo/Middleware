using Beon.MyBeon.Middleware.Models.BaseModels;

namespace Beon.MyBeon.Middleware.Models;

public class SubUnitset : BaseModel
{
	public string Code { get; set; } = string.Empty;
	public string Name { get; set; } = string.Empty;
	public double ConversionFactor { get; set; } = default;
	public double OtherConversionFactor { get; set; } = default;
	public bool IsMainUnit { get; set; } = default;
	public Unitset? Unitset { get; set; }
	public int ReferenceId { get; set; } = default;
	public IntegrationResult? IntegrationResult{get; set; }
}
