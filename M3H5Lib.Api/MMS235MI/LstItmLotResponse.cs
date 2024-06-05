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

namespace M3H5Lib.Api.MMS235MI
{
	public partial class LstItmLotResponse : M3BaseRecord 
	{

		/// <summary>
		/// Description: Company
		/// FieldName: CONO
		/// FieldType: N
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Company")]
		public int? M3CONO => GetNullableInt("CONO");

		/// <summary>
		/// Description: Itemnumber
		/// FieldName: ITNO
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Itemnumber")]
		public string M3ITNO => GetString("ITNO");

		/// <summary>
		/// Description: Lotnumber
		/// FieldName: BANO
		/// FieldType: A
		/// Length: 20
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Lotnumber")]
		public string M3BANO => GetString("BANO");

		/// <summary>
		/// Description: Lotreference1
		/// FieldName: BREF
		/// FieldType: A
		/// Length: 20
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Lotreference1")]
		public string M3BREF => GetString("BREF");

		/// <summary>
		/// Description: Lotreference2
		/// FieldName: BRE2
		/// FieldType: A
		/// Length: 20
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Lotreference2")]
		public string M3BRE2 => GetString("BRE2");

		/// <summary>
		/// Description: Lasttransactiondate
		/// FieldName: LATD
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Lasttransactiondate")]
		public DateTime? M3LATD => GetNullableDateTime("LATD");

		/// <summary>
		/// Description: Status-balanceID
		/// FieldName: STAS
		/// FieldType: A
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Status-balanceID")]
		public string M3STAS => GetString("STAS");

		/// <summary>
		/// Description: On-handbalanceapproved
		/// FieldName: STQT
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("On-handbalanceapproved")]
		public decimal? M3STQT => GetNullableDecimal("STQT");

		/// <summary>
		/// Description: Allocatableon-handbalance
		/// FieldName: AVAL
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Allocatableon-handbalance")]
		public decimal? M3AVAL => GetNullableDecimal("AVAL");

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
		/// Description: Potency
		/// FieldName: LPCY
		/// FieldType: N
		/// Length: 7
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Potency")]
		public int? M3LPCY => GetNullableInt("LPCY");

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
		/// Description: Filing address
		/// FieldName: ARLA
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Filing address")]
		public string M3ARLA => GetString("ARLA");

		/// <summary>
		/// Description: Tagging type
		/// FieldName: IDET
		/// FieldType: A
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Tagging type")]
		public string M3IDET => GetString("IDET");

		/// <summary>
		/// Description: Owner
		/// FieldName: OWNC
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Owner")]
		public string M3OWNC => GetString("OWNC");

		/// <summary>
		/// Description: User-defined field 3 - item
		/// FieldName: CFI3
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("User-defined field 3 - item")]
		public string M3CFI3 => GetString("CFI3");

		/// <summary>
		/// Description: User-defined field 10 - serv agreement
		/// FieldName: CFJ0
		/// FieldType: A
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("User-defined field 10 - serv agreement")]
		public string M3CFJ0 => GetString("CFJ0");

		/// <summary>
		/// Description: User-defined field 2 - item
		/// FieldName: CFI2
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("User-defined field 2 - item")]
		public decimal? M3CFI2 => GetNullableDecimal("CFI2");

		/// <summary>
		/// Description: Manufacturing date
		/// FieldName: MFDT
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Manufacturing date")]
		public DateTime? M3MFDT => GetNullableDateTime("MFDT");

		/// <summary>
		/// Description: Receipt date
		/// FieldName: REDA
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Receipt date")]
		public DateTime? M3REDA => GetNullableDateTime("REDA");

		/// <summary>
		/// Description: Sales date
		/// FieldName: SEDT
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Sales date")]
		public DateTime? M3SEDT => GetNullableDateTime("SEDT");

		/// <summary>
		/// Description: Follow-up date
		/// FieldName: CNDT
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Follow-up date")]
		public DateTime? M3CNDT => GetNullableDateTime("CNDT");

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
		/// Description: Reference order category
		/// FieldName: RORC
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Reference order category")]
		public int? M3RORC => GetNullableInt("RORC");

		/// <summary>
		/// Description: Reference order number
		/// FieldName: RORN
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Reference order number")]
		public string M3RORN => GetString("RORN");

		/// <summary>
		/// Description: Lot type
		/// FieldName: LOTY
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Lot type")]
		public int? M3LOTY => GetNullableInt("LOTY");

		/// <summary>
		/// Description: Reference order line
		/// FieldName: RORL
		/// FieldType: N
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Reference order line")]
		public int? M3RORL => GetNullableInt("RORL");

		/// <summary>
		/// Description: Supplier number
		/// FieldName: SUNO
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Supplier number")]
		public string M3SUNO => GetString("SUNO");

		/// <summary>
		/// Description: Manufacturer
		/// FieldName: PROD
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Manufacturer")]
		public string M3PROD => GetString("PROD");

		/// <summary>
		/// Description: Supplier/manufacturer item number
		/// FieldName: MFIT
		/// FieldType: A
		/// Length: 30
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Supplier/manufacturer item number")]
		public string M3MFIT => GetString("MFIT");

		/// <summary>
		/// Description: Manufacturer serial number
		/// FieldName: MFSN
		/// FieldType: A
		/// Length: 25
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Manufacturer serial number")]
		public string M3MFSN => GetString("MFSN");

		/// <summary>
		/// Description: Revision number
		/// FieldName: ECVE
		/// FieldType: A
		/// Length: 4
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Revision number")]
		public string M3ECVE => GetString("ECVE");

		/// <summary>
		/// Description: Change date
		/// FieldName: LMDT
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Change date")]
		public DateTime? M3LMDT => GetNullableDateTime("LMDT");

		/// <summary>
		/// Description: Changed by
		/// FieldName: CHID
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Changed by")]
		public string M3CHID => GetString("CHID");

		/// <summary>
		/// Description: Change number
		/// FieldName: CHNO
		/// FieldType: N
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Change number")]
		public int? M3CHNO => GetNullableInt("CHNO");

		/// <summary>
		/// Description: Allocatable
		/// FieldName: ALOC
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Allocatable")]
		public int? M3ALOC => GetNullableInt("ALOC");

		/// <summary>
		/// Description: Reclassification date
		/// FieldName: RCLS
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Reclassification date")]
		public DateTime? M3RCLS => GetNullableDateTime("RCLS");

		/// <summary>
		/// Description: Quality inspection approval date
		/// FieldName: QIAD
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Quality inspection approval date")]
		public DateTime? M3QIAD => GetNullableDateTime("QIAD");

		/// <summary>
		/// Description: Lot cost
		/// FieldName: LOTC
		/// FieldType: N
		/// Length: 19
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Lot cost")]
		public decimal? M3LOTC => GetNullableDecimal("LOTC");

		/// <summary>
		/// Description: Internal release
		/// FieldName: INRE
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Internal release")]
		public int? M3INRE => GetNullableInt("INRE");

		/// <summary>
		/// Description: Receiving number
		/// FieldName: REPN
		/// FieldType: N
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Receiving number")]
		public long? M3REPN => GetNullableLong("REPN");

		/// <summary>
		/// Description: Agreement number
		/// FieldName: AAGN
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Agreement number")]
		public string M3AAGN => GetString("AAGN");

		/// <summary>
		/// Description: Text identity
		/// FieldName: TXID
		/// FieldType: N
		/// Length: 13
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Text identity")]
		public decimal? M3TXID => GetNullableDecimal("TXID");

		/// <summary>
		/// Description: Attribute number
		/// FieldName: ATNR
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Attribute number")]
		public decimal? M3ATNR => GetNullableDecimal("ATNR");

		/// <summary>
		/// Description: Entry date
		/// FieldName: RGDT
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Entry date")]
		public DateTime? M3RGDT => GetNullableDateTime("RGDT");

		/// <summary>
		/// Description: Entry time
		/// FieldName: RGTM
		/// FieldType: N
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Entry time")]
		public int? M3RGTM => GetNullableInt("RGTM");

		/// <summary>
		/// Description: Item Name
		/// FieldName: ITDS
		/// FieldType: A
		/// Length: 30
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Item Name")]
		public string M3ITDS => GetString("ITDS");

		/// <summary>
		/// Description: Purchase price U/M
		/// FieldName: PPUN
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Purchase price U/M")]
		public string M3PPUN => GetString("PPUN");

		/// <summary>
		/// Description: Basic unit of measure
		/// FieldName: UNMS
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Basic unit of measure")]
		public string M3UNMS => GetString("UNMS");

		/// <summary>
		/// Description: Facility Name
		/// FieldName: FACN
		/// FieldType: A
		/// Length: 30
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Facility Name")]
		public string M3FACN => GetString("FACN");

		/// <summary>
		/// Description: Supplier name
		/// FieldName: SUNM
		/// FieldType: A
		/// Length: 36
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Supplier name")]
		public string M3SUNM => GetString("SUNM");

		/// <summary>
		/// Description: Allocated quantity - basic U/M
		/// FieldName: ALQT
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Allocated quantity - basic U/M")]
		public decimal? M3ALQT => GetNullableDecimal("ALQT");

		/// <summary>
		/// Description: Country of origin
		/// FieldName: TORC
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Country of origin")]
		public string M3TORC => GetString("TORC");

		/// <summary>
		/// Description: Manufacturer
		/// FieldName: TPRO
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Manufacturer")]
		public string M3TPRO => GetString("TPRO");

		/// <summary>
		/// Description: Owner
		/// FieldName: TOWN
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Owner")]
		public string M3TOWN => GetString("TOWN");

		/// <summary>
		/// Description: Original item
		/// FieldName: ORIE
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Original item")]
		public string M3ORIE => GetString("ORIE");

		/// <summary>
		/// Description: Original lot number
		/// FieldName: ORBA
		/// FieldType: A
		/// Length: 20
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Original lot number")]
		public string M3ORBA => GetString("ORBA");

		/// <summary>
		/// Description: User-defined field 3 - item
		/// FieldName: TCF3
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("User-defined field 3 - item")]
		public string M3TCF3 => GetString("TCF3");

		/// <summary>
		/// Description: To User-defined field 10 - serv agreement
		/// FieldName: TCF0
		/// FieldType: A
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("To User-defined field 10 - serv agreement")]
		public string M3TCF0 => GetString("TCF0");

		/// <summary>
		/// Description: To User-defined field 2 - item
		/// FieldName: TCF2
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("To User-defined field 2 - item")]
		public decimal? M3TCF2 => GetNullableDecimal("TCF2");

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
		/// Description: Initial quantity
		/// FieldName: IQTY
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Initial quantity")]
		public decimal? M3IQTY => GetNullableDecimal("IQTY");

		/// <summary>
		/// Description: Cumulative usage quantity
		/// FieldName: ACUQ
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Cumulative usage quantity")]
		public decimal? M3ACUQ => GetNullableDecimal("ACUQ");

		/// <summary>
		/// Description: Cumulative usage weight
		/// FieldName: ACUW
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Cumulative usage weight")]
		public decimal? M3ACUW => GetNullableDecimal("ACUW");

		/// <summary>
		/// Description: Adjusted weight
		/// FieldName: ADJW
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Adjusted weight")]
		public decimal? M3ADJW => GetNullableDecimal("ADJW");

		/// <summary>
		/// Description: Initial catch weight
		/// FieldName: INCW
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Initial catch weight")]
		public decimal? M3INCW => GetNullableDecimal("INCW");

		/// <summary>
		/// Description: Catch weight
		/// FieldName: CAWE
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Catch weight")]
		public decimal? M3CAWE => GetNullableDecimal("CAWE");

		/// <summary>
		/// Description: Completion flag
		/// FieldName: FIFL
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Completion flag")]
		public int? M3FIFL => GetNullableInt("FIFL");

		/// <summary>
		/// Description: Warehouse description
		/// FieldName: WHNM
		/// FieldType: A
		/// Length: 36
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Warehouse description")]
		public string M3WHNM => GetString("WHNM");

		/// <summary>
		/// Description: LI request rule
		/// FieldName: LIRR
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("LI request rule")]
		public int? M3LIRR => GetNullableInt("LIRR");

		/// <summary>
		/// Description: Harvested date
		/// FieldName: HVDT
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Harvested date")]
		public DateTime? M3HVDT => GetNullableDateTime("HVDT");

		/// <summary>
		/// Description: Best before date
		/// FieldName: BBDT
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Best before date")]
		public DateTime? M3BBDT => GetNullableDateTime("BBDT");

		/// <summary>
		/// Description: Harvested item
		/// FieldName: HVIT
		/// FieldType: A
		/// Length: 20
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Harvested item")]
		public string M3HVIT => GetString("HVIT");

		/// <summary>
		/// Description: Harvested lot
		/// FieldName: HVLT
		/// FieldType: A
		/// Length: 20
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Harvested lot")]
		public string M3HVLT => GetString("HVLT");
	}
}
// EOF
