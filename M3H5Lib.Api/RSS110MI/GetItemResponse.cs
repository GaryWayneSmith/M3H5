/// **********************************************************************
/// This class is auto-generated.
/// Updated: 6/5/2024 7:41:31 PM
/// **********************************************************************
///
/// All property types here are derived from existing A, N, or D from M3
/// with minimal logic for verification.  Generally if it's N under 10
/// digits it was treated as an int, 10 digits long, and more than 10 as
/// as a decimal.  This means some smaller decimals might be missed, and
/// in this case, will throw a conversion error.  If there is specific
/// conversions that were missed, please correct and notify for mainline
/// inclusion.
///
/// All fields are prefixed with M3 as C# doesn't not handle numeric leading
/// digits and some return values fall into this category.  So it was decided
/// that we standardize on a leading prefix

using M3H5Lib.Models;
using Newtonsoft.Json;
using System.ComponentModel;
using System;

namespace M3H5Lib.Api.RSS110MI
{
	public partial class GetItemResponse : M3BaseRecord 
	{

		/// <summary>
		/// Description: Alias number
		/// FieldName: POPN
		/// FieldType: A
		/// Length: 30
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Alias number")]
		public string M3POPN => GetString("POPN");

		/// <summary>
		/// Description: Alias category
		/// FieldName: ALWT
		/// FieldType: N
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Alias category")]
		public int? M3ALWT => GetNullableInt("ALWT");

		/// <summary>
		/// Description: Alias qualifier
		/// FieldName: ALWQ
		/// FieldType: A
		/// Length: 4
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Alias qualifier")]
		public string M3ALWQ => GetString("ALWQ");

		/// <summary>
		/// Description: Item number
		/// FieldName: ITNO
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Item number")]
		public string M3ITNO => GetString("ITNO");

		/// <summary>
		/// Description: Name
		/// FieldName: ITDS
		/// FieldType: A
		/// Length: 30
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Name")]
		public string M3ITDS => GetString("ITDS");

		/// <summary>
		/// Description: Unit of measure
		/// FieldName: UNIT
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Unit of measure")]
		public string M3UNIT => GetString("UNIT");

		/// <summary>
		/// Description: Country of origin
		/// FieldName: ORCO
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Country of origin")]
		public string M3ORCO => GetString("ORCO");

		/// <summary>
		/// Description: Warehouse
		/// FieldName: WHLO
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Warehouse")]
		public string M3WHLO => GetString("WHLO");

		/// <summary>
		/// Description: Facility
		/// FieldName: FACI
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Facility")]
		public string M3FACI => GetString("FACI");

		/// <summary>
		/// Description: Customers order number
		/// FieldName: CUOR
		/// FieldType: A
		/// Length: 20
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Customers order number")]
		public string M3CUOR => GetString("CUOR");

		/// <summary>
		/// Description: Customer´s purchase order date
		/// FieldName: CUDT
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Customer´s purchase order date")]
		public DateTime? M3CUDT => GetNullableDateTime("CUDT");

		/// <summary>
		/// Description: Delivery contract number
		/// FieldName: RSAG
		/// FieldType: A
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Delivery contract number")]
		public string M3RSAG => GetString("RSAG");

		/// <summary>
		/// Description: Update method
		/// FieldName: RSAC
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Update method")]
		public int? M3RSAC => GetNullableInt("RSAC");

		/// <summary>
		/// Description: Delivery note reference
		/// FieldName: PUSN
		/// FieldType: A
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Delivery note reference")]
		public string M3PUSN => GetString("PUSN");

		/// <summary>
		/// Description: Delivery note reference qualifier
		/// FieldName: PUTP
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Delivery note reference qualifier")]
		public int? M3PUTP => GetNullableInt("PUTP");

		/// <summary>
		/// Description: Old CFIN
		/// FieldName: CFXX
		/// FieldType: N
		/// Length: 7
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Old CFIN")]
		public int? M3CFXX => GetNullableInt("CFXX");

		/// <summary>
		/// Description: Delivery schedule level
		/// FieldName: DSLV
		/// FieldType: N
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Delivery schedule level")]
		public int? M3DSLV => GetNullableInt("DSLV");

		/// <summary>
		/// Description: Date type
		/// FieldName: DTTP
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Date type")]
		public int? M3DTTP => GetNullableInt("DTTP");

		/// <summary>
		/// Description: Partner´s design revision number
		/// FieldName: RSRN
		/// FieldType: A
		/// Length: 30
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Partner´s design revision number")]
		public string M3RSRN => GetString("RSRN");

		/// <summary>
		/// Description: Partner´s engineering change order no
		/// FieldName: RSEC
		/// FieldType: A
		/// Length: 20
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Partner´s engineering change order no")]
		public string M3RSEC => GetString("RSEC");

		/// <summary>
		/// Description: Engineering change order date
		/// FieldName: RSED
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Engineering change order date")]
		public DateTime? M3RSED => GetNullableDateTime("RSED");

		/// <summary>
		/// Description: Previous delivery schedule number
		/// FieldName: RSPS
		/// FieldType: A
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Previous delivery schedule number")]
		public string M3RSPS => GetString("RSPS");

		/// <summary>
		/// Description: Status - item release
		/// FieldName: ITRL
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Status - item release")]
		public string M3ITRL => GetString("ITRL");

		/// <summary>
		/// Description: Net weight
		/// FieldName: NEWE
		/// FieldType: N
		/// Length: 11
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Net weight")]
		public decimal? M3NEWE => GetNullableDecimal("NEWE");

		/// <summary>
		/// Description: Gross weight
		/// FieldName: GRWE
		/// FieldType: N
		/// Length: 11
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Gross weight")]
		public decimal? M3GRWE => GetNullableDecimal("GRWE");

		/// <summary>
		/// Description: Volume
		/// FieldName: VOL3
		/// FieldType: N
		/// Length: 11
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Volume")]
		public decimal? M3VOL3 => GetNullableDecimal("VOL3");

		/// <summary>
		/// Description: Customers packaging identity
		/// FieldName: CUPA
		/// FieldType: A
		/// Length: 20
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Customers packaging identity")]
		public string M3CUPA => GetString("CUPA");

		/// <summary>
		/// Description: Standard quantity (Replaced by D1Q2)
		/// FieldName: D1QT
		/// FieldType: N
		/// Length: 11
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Standard quantity (Replaced by D1Q2)")]
		public decimal? M3D1QT => GetNullableDecimal("D1QT");

		/// <summary>
		/// Description: Package reference
		/// FieldName: PARE
		/// FieldType: A
		/// Length: 20
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Package reference")]
		public string M3PARE => GetString("PARE");

		/// <summary>
		/// Description: Number of packages
		/// FieldName: AMKO
		/// FieldType: N
		/// Length: 7
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Number of packages")]
		public int? M3AMKO => GetNullableInt("AMKO");

		/// <summary>
		/// Description: Customer´s model year
		/// FieldName: CUMY
		/// FieldType: A
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Customer´s model year")]
		public string M3CUMY => GetString("CUMY");

		/// <summary>
		/// Description: Sales price
		/// FieldName: SAPR
		/// FieldType: N
		/// Length: 18
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Sales price")]
		public decimal? M3SAPR => GetNullableDecimal("SAPR");

		/// <summary>
		/// Description: Sales price quantity
		/// FieldName: SACD
		/// FieldType: N
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Sales price quantity")]
		public int? M3SACD => GetNullableInt("SACD");

		/// <summary>
		/// Description: Currency - sales price
		/// FieldName: CUCS
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Currency - sales price")]
		public string M3CUCS => GetString("CUCS");

		/// <summary>
		/// Description: Sales price unit of measure
		/// FieldName: SPUN
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Sales price unit of measure")]
		public string M3SPUN => GetString("SPUN");

		/// <summary>
		/// Description: Expiration date
		/// FieldName: EXPI
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Expiration date")]
		public DateTime? M3EXPI => GetNullableDateTime("EXPI");

		/// <summary>
		/// Description: Customer´s delivery pattern
		/// FieldName: CDLP
		/// FieldType: A
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Customer´s delivery pattern")]
		public string M3CDLP => GetString("CDLP");

		/// <summary>
		/// Description: Customer´s internal kanban card number
		/// FieldName: RSK2
		/// FieldType: A
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Customer´s internal kanban card number")]
		public string M3RSK2 => GetString("RSK2");

		/// <summary>
		/// Description: EU number
		/// FieldName: ECNM
		/// FieldType: A
		/// Length: 18
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("EU number")]
		public string M3ECNM => GetString("ECNM");

		/// <summary>
		/// Description: Authorization firm to date
		/// FieldName: AUSD
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Authorization firm to date")]
		public DateTime? M3AUSD => GetNullableDateTime("AUSD");

		/// <summary>
		/// Description: Firm period qualifier
		/// FieldName: AUST
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Firm period qualifier")]
		public int? M3AUST => GetNullableInt("AUST");

		/// <summary>
		/// Description: Firm periods
		/// FieldName: AUSP
		/// FieldType: N
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Firm periods")]
		public int? M3AUSP => GetNullableInt("AUSP");

		/// <summary>
		/// Description: Authorization fabrication to date
		/// FieldName: AUFD
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Authorization fabrication to date")]
		public DateTime? M3AUFD => GetNullableDateTime("AUFD");

		/// <summary>
		/// Description: Fabrication period qualifier
		/// FieldName: AUFT
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Fabrication period qualifier")]
		public int? M3AUFT => GetNullableInt("AUFT");

		/// <summary>
		/// Description: Fabrication periods
		/// FieldName: AUFP
		/// FieldType: N
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Fabrication periods")]
		public int? M3AUFP => GetNullableInt("AUFP");

		/// <summary>
		/// Description: Authorization material to date
		/// FieldName: AUMD
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Authorization material to date")]
		public DateTime? M3AUMD => GetNullableDateTime("AUMD");

		/// <summary>
		/// Description: Material period qualifier
		/// FieldName: AUMT
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Material period qualifier")]
		public int? M3AUMT => GetNullableInt("AUMT");

		/// <summary>
		/// Description: Material periods
		/// FieldName: AUMP
		/// FieldType: N
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Material periods")]
		public int? M3AUMP => GetNullableInt("AUMP");

		/// <summary>
		/// Description: Forecast to date
		/// FieldName: AUUD
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Forecast to date")]
		public DateTime? M3AUUD => GetNullableDateTime("AUUD");

		/// <summary>
		/// Description: Forecast period qualifier
		/// FieldName: AUUT
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Forecast period qualifier")]
		public int? M3AUUT => GetNullableInt("AUUT");

		/// <summary>
		/// Description: Forecast periods
		/// FieldName: AUUP
		/// FieldType: N
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Forecast periods")]
		public int? M3AUUP => GetNullableInt("AUUP");

		/// <summary>
		/// Description: Reference agreement to date
		/// FieldName: AUXD
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Reference agreement to date")]
		public DateTime? M3AUXD => GetNullableDateTime("AUXD");

		/// <summary>
		/// Description: Total quantity reference agreement
		/// FieldName: AUXT
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Total quantity reference agreement")]
		public int? M3AUXT => GetNullableInt("AUXT");

		/// <summary>
		/// Description: Reference agreement period qualifier
		/// FieldName: AUXP
		/// FieldType: N
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Reference agreement period qualifier")]
		public int? M3AUXP => GetNullableInt("AUXP");

		/// <summary>
		/// Description: Configuration number
		/// FieldName: CFIN
		/// FieldType: N
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Configuration number")]
		public long? M3CFIN => GetNullableLong("CFIN");

		/// <summary>
		/// Description: Standard quantity
		/// FieldName: D1Q2
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Standard quantity")]
		public decimal? M3D1Q2 => GetNullableDecimal("D1Q2");
	}
}
// EOF
