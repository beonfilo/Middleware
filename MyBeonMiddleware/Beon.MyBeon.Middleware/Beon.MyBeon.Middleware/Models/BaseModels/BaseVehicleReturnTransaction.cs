using System.Text.Json.Serialization;

namespace Beon.MyBeon.Middleware.Models.BaseModels
{
	public class BaseVehicleReturnTransaction : BaseModel
	{
		public string? TargetType { get; set; }
		public DateTime? CreatedOn { get; set; }
		public ApplicationUser? Owner { get; set; }
		public string? Code { get; set; }

		public DateTime? ReturnDate { get; set; }

		[JsonIgnore]
		public TimeSpan? ReturnTime { get; set; }
		public double? ReturnKilometer { get; set; }
		public ApplicationUser? ReturnedBy { get; set; }
		public Customer? Customer { get; set; }
		public string? ReturnedContactType { get; set; }
		public CustomerContact? ReturnedContact { get; set; }
		public string? ReturnedContactFirstname { get; set; }
		public string? ReturnedContactLastname { get; set; }
		public string? ReturnedContactTelephone { get; set; }
		public string? ReturnedContactTCKN { get; set; }

		public Vehicle? Vehicle { get; set; }

		public Contract? Contract { get; set; }
		public ContractTransaction? ContractTransaction { get; set; }
		public int? Month { get; set; } //vade
		public double? Kilometer { get; set; }//anlaşılan km
		public double? ExtraKilometerPrice { get; set; }//fazla km bedeli

		public ContractTransactionVehicle? ContractTransactionVehicle { get; set; }
		public VehicleDelivery? VehicleDelivery { get; set; }
		public Quote? Quote { get; set; }
		public QuoteTransaction? QuoteTransaction { get; set; }

		public DateTime? DeliveryDate { get; set; }
		public double? DeliveryKilometer { get; set; }
		public ApplicationUser? DelivererBy { get; set; }//teslim eden
		public CustomerContact? Recipient { get; set; }//teslim alan
		public bool? DeliveryIsRegistration { get; set; }//ruhsat
		public bool? DeliveryIsSpareKey { get; set; }//yedek anahtar
		public bool? DeliveryIsUserManuel { get; set; }//kullanıcı el kitabı
		public bool? DeliveryIsWarrantyCertificate { get; set; }//garanti belgesi
		public bool? DeliveryIsInsurancePolicy { get; set; }//trafik poliçesi
		public bool? DeliveryIsToolKit { get; set; }//avadanlık
		public bool? DeliveryIsMop { get; set; }//paspas
		public bool? DeliveryIsExtinguisher { get; set; }//yangın söndürücü
		public bool? DeliveryIsCompressor { get; set; }//protatif kompresör

		public double? FuelPercentage { get; set; }//yakıt durumu %
		public bool? IsDamage { get; set; }//hasar var mı ?

		public bool? IsClening { get; set; }//temizlik gerekiyor mu
		public CleaningType? CleningType { get; set; }
		public CleaningCause? CleaningCause { get; set; }

		public bool? IsRegistration { get; set; }//ruhsat
		public bool? IsSpareKey { get; set; }//yedek anahtar
		public bool? IsUserManuel { get; set; }//kullanıcı el kitabı
		public bool? IsWarrantyCertificate { get; set; }//garanti belgesi
		public bool? IsInsurancePolicy { get; set; }//trafik poliçesi
		public bool? IsToolKit { get; set; }//avadanlık
		public bool? IsMop { get; set; }//paspas
		public bool? IsExtinguisher { get; set; }//yangın söndürücü
		public bool? IsCompressor { get; set; }//protatif kompresör

		public bool? IsExtraKilometer { get; set; }//fazla km var mı ?
		public double? ExtraKilometer { get; set; } //fazla km
		public double? ExtraKilometerTotal { get; set; }//fazla kilometre tutarı
		public string? ExtraKilometerChargeoutStatus { get; set; }//ekstra km yansıtılacak mı ?

		public bool? IsOtherChargeout { get; set; }//diğer yansıtma var mı ?
		public string? OtherChargeoutStatus { get; set; }//teslim ettiğim elemanlardan biri bile gelmediyse yansıtmak isteyebilirim.
		public double? OtherChargeoutTotal { get; set; }

		public CleaningDemand? CleaningDemand { get; set; }
		public KilometerExceedingTransaction? KilometerExceedingTransaction { get; set; }
		public ChargeoutTransaction? ChargeoutTransaction { get; set; }

		public FileData? RetrievalDocument { get; set; }
	}
}
