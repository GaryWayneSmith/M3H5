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

namespace M3H5Lib.Api.MMS060MI
{
	public partial class LstLotResponse : M3BaseRecord 
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
		/// Description: Warehouse description
		/// FieldName: WHNM
		/// FieldType: A
		/// Length: 30
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Warehouse description")]
		public string M3WHNM => GetString("WHNM");

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
		/// Description: Location
		/// FieldName: WHSL
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Location")]
		public string M3WHSL => GetString("WHSL");

		/// <summary>
		/// Description: Lot number
		/// FieldName: BANO
		/// FieldType: A
		/// Length: 20
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Lot number")]
		public string M3BANO => GetString("BANO");

		/// <summary>
		/// Description: Container
		/// FieldName: CAMU
		/// FieldType: A
		/// Length: 20
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Container")]
		public string M3CAMU => GetString("CAMU");

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
		/// Description: ABC class - volume
		/// FieldName: ABCD
		/// FieldType: A
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("ABC class - volume")]
		public string M3ABCD => GetString("ABCD");

		/// <summary>
		/// Description: Item type
		/// FieldName: ITTY
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Item type")]
		public string M3ITTY => GetString("ITTY");

		/// <summary>
		/// Description: Responsible
		/// FieldName: RESP
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Responsible")]
		public string M3RESP => GetString("RESP");

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
		/// Description: Item group
		/// FieldName: ITGR
		/// FieldType: A
		/// Length: 8
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Item group")]
		public string M3ITGR => GetString("ITGR");

		/// <summary>
		/// Description: Planning policy
		/// FieldName: PLCD
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Planning policy")]
		public string M3PLCD => GetString("PLCD");

		/// <summary>
		/// Description: Stock zone
		/// FieldName: SLTP
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Stock zone")]
		public string M3SLTP => GetString("SLTP");

		/// <summary>
		/// Description: Location type
		/// FieldName: WHLT
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Location type")]
		public string M3WHLT => GetString("WHLT");

		/// <summary>
		/// Description: Last receipt date
		/// FieldName: IDDT
		/// FieldType: D
		/// Length: 8
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Last receipt date")]
		public DateTime? M3IDDT => GetNullableDateTime("IDDT");

		/// <summary>
		/// Description: Last issue date
		/// FieldName: ODDT
		/// FieldType: D
		/// Length: 8
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Last issue date")]
		public DateTime? M3ODDT => GetNullableDateTime("ODDT");

		/// <summary>
		/// Description: Latest physical inventory date
		/// FieldName: INDT
		/// FieldType: D
		/// Length: 8
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Latest physical inventory date")]
		public DateTime? M3INDT => GetNullableDateTime("INDT");

		/// <summary>
		/// Description: Physical inventory in progress
		/// FieldName: INON
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Physical inventory in progress")]
		public int? M3INON => GetNullableInt("INON");

		/// <summary>
		/// Description: Status - balance ID
		/// FieldName: STAS
		/// FieldType: A
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Status - balance ID")]
		public string M3STAS => GetString("STAS");

		/// <summary>
		/// Description: Reclassification date
		/// FieldName: RCLS
		/// FieldType: N
		/// Length: 8
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Reclassification date")]
		public int? M3RCLS => GetNullableInt("RCLS");

		/// <summary>
		/// Description: Priority date
		/// FieldName: PRDT
		/// FieldType: D
		/// Length: 8
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Priority date")]
		public DateTime? M3PRDT => GetNullableDateTime("PRDT");

		/// <summary>
		/// Description: On-hand balance approved
		/// FieldName: STQT
		/// FieldType: N
		/// Length: 11
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("On-hand balance approved")]
		public decimal? M3STQT => GetNullableDecimal("STQT");

		/// <summary>
		/// Description: On-hand balance
		/// FieldName: PHSQ
		/// FieldType: N
		/// Length: 11
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("On-hand balance")]
		public decimal? M3PHSQ => GetNullableDecimal("PHSQ");

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
		/// Description: Allocated quantity - basic U/M
		/// FieldName: ALQT
		/// FieldType: N
		/// Length: 11
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Allocated quantity - basic U/M")]
		public decimal? M3ALQT => GetNullableDecimal("ALQT");

		/// <summary>
		/// Description: Allocated quantity
		/// FieldName: PHAQ
		/// FieldType: N
		/// Length: 11
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Allocated quantity")]
		public decimal? M3PHAQ => GetNullableDecimal("PHAQ");

		/// <summary>
		/// Description: Automatic deletion
		/// FieldName: AUDE
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Automatic deletion")]
		public int? M3AUDE => GetNullableInt("AUDE");

		/// <summary>
		/// Description: Automatic deletion delay
		/// FieldName: AUDD
		/// FieldType: N
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Automatic deletion delay")]
		public int? M3AUDD => GetNullableInt("AUDD");

		/// <summary>
		/// Description: Active physical inventory lines
		/// FieldName: STAQ
		/// FieldType: N
		/// Length: 11
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Active physical inventory lines")]
		public decimal? M3STAQ => GetNullableDecimal("STAQ");

		/// <summary>
		/// Description: Active physical
		/// FieldName: PHA2
		/// FieldType: N
		/// Length: 11
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Active physical")]
		public decimal? M3PHA2 => GetNullableDecimal("PHA2");

		/// <summary>
		/// Description: Normal potency
		/// FieldName: POCY
		/// FieldType: N
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Normal potency")]
		public int? M3POCY => GetNullableInt("POCY");

		/// <summary>
		/// Description: Catch weight
		/// FieldName: CAWE
		/// FieldType: A
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Catch weight")]
		public string M3CAWE => GetString("CAWE");

		/// <summary>
		/// Description: Potency
		/// FieldName: LPCY
		/// FieldType: N
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Potency")]
		public int? M3LPCY => GetNullableInt("LPCY");

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
		/// Description: Lot reference 1
		/// FieldName: BREF
		/// FieldType: A
		/// Length: 20
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Lot reference 1")]
		public string M3BREF => GetString("BREF");

		/// <summary>
		/// Description: Packaging
		/// FieldName: PACT
		/// FieldType: A
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Packaging")]
		public string M3PACT => GetString("PACT");

		/// <summary>
		/// Description: Lot reference 2
		/// FieldName: BRE2
		/// FieldType: A
		/// Length: 20
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Lot reference 2")]
		public string M3BRE2 => GetString("BRE2");

		/// <summary>
		/// Description: Remark
		/// FieldName: BREM
		/// FieldType: A
		/// Length: 20
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Remark")]
		public string M3BREM => GetString("BREM");

		/// <summary>
		/// Description: Reorder point
		/// FieldName: REOP
		/// FieldType: N
		/// Length: 11
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Reorder point")]
		public decimal? M3REOP => GetNullableDecimal("REOP");

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
		/// Description: Attribute number lot
		/// FieldName: ATNB
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Attribute number lot")]
		public decimal? M3ATNB => GetNullableDecimal("ATNB");

		/// <summary>
		/// Description: Status
		/// FieldName: STAT
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Status")]
		public string M3STAT => GetString("STAT");

		/// <summary>
		/// Description: Catch weight
		/// FieldName: CAW2
		/// FieldType: N
		/// Length: 11
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Catch weight")]
		public decimal? M3CAW2 => GetNullableDecimal("CAW2");

		/// <summary>
		/// Description: Lot control method
		/// FieldName: INDI
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Lot control method")]
		public int? M3INDI => GetNullableInt("INDI");

		/// <summary>
		/// Description: Lot numbering method
		/// FieldName: BACD
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Lot numbering method")]
		public int? M3BACD => GetNullableInt("BACD");

		/// <summary>
		/// Description: Expiration date method
		/// FieldName: EXPD
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Expiration date method")]
		public int? M3EXPD => GetNullableInt("EXPD");

		/// <summary>
		/// Description: Active or catch weight item
		/// FieldName: ACTI
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Active or catch weight item")]
		public int? M3ACTI => GetNullableInt("ACTI");

		/// <summary>
		/// Description: Attribute managed
		/// FieldName: ATMN
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Attribute managed")]
		public int? M3ATMN => GetNullableInt("ATMN");

		/// <summary>
		/// Description: Catch weight unit of measure
		/// FieldName: CWUN
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Catch weight unit of measure")]
		public string M3CWUN => GetString("CWUN");

		/// <summary>
		/// Description: Container management
		/// FieldName: COMG
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Container management")]
		public int? M3COMG => GetNullableInt("COMG");
	}
}
// EOF
