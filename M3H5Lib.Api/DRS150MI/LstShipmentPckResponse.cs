/// **********************************************************************
/// Created by: Gary Smith
/// Updated: 3/9/2024 12:26:01 AM
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
/// All fields are prefixed with M3_ as C# doesn not handle numeric leading
/// digits and some return values fall into this category.  So it was decided
/// that we standardize on a leading prefix

using M3H5Lib.Models;
using Newtonsoft.Json;
using System.ComponentModel;
using System;

namespace M3H5Lib.Api.DRS150MI
{
	public partial class LstShipmentPckResponse : M3BaseRecord 
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
		public int? M3_CONO => GetNullableInt("CONO");

		/// <summary>
		/// Description: Shipment package number
		/// FieldName: SPNO
		/// FieldType: A
		/// Length: 20
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Shipment package number")]
		public string M3_SPNO => GetString("SPNO");

		/// <summary>
		/// Description: Shipment
		/// FieldName: CONN
		/// FieldType: N
		/// Length: 7
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Shipment")]
		public int? M3_CONN => GetNullableInt("CONN");

		/// <summary>
		/// Description: Via address
		/// FieldName: ADVI
		/// FieldType: A
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Via address")]
		public string M3_ADVI => GetString("ADVI");

		/// <summary>
		/// Description: Packaging
		/// FieldName: PACT
		/// FieldType: A
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Packaging")]
		public string M3_PACT => GetString("PACT");

		/// <summary>
		/// Description: Package status
		/// FieldName: SPSS
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Package status")]
		public string M3_SPSS => GetString("SPSS");

		/// <summary>
		/// Description: Lowest Pick status
		/// FieldName: PISL
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Lowest Pick status")]
		public string M3_PISL => GetString("PISL");

		/// <summary>
		/// Description: Highest Pick status
		/// FieldName: PISH
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Highest Pick status")]
		public string M3_PISH => GetString("PISH");

		/// <summary>
		/// Description: Lowest Pack status
		/// FieldName: PSTL
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Lowest Pack status")]
		public string M3_PSTL => GetString("PSTL");

		/// <summary>
		/// Description: Highest Pack status
		/// FieldName: PSTH
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Highest Pack status")]
		public string M3_PSTH => GetString("PSTH");

		/// <summary>
		/// Description: Actual gross weight
		/// FieldName: GWTM
		/// FieldType: N
		/// Length: 11
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Actual gross weight")]
		public decimal? M3_GWTM => GetNullableDecimal("GWTM");

		/// <summary>
		/// Description: Actual net weight
		/// FieldName: NTWM
		/// FieldType: N
		/// Length: 11
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Actual net weight")]
		public decimal? M3_NTWM => GetNullableDecimal("NTWM");

		/// <summary>
		/// Description: Actual quantity in free unit
		/// FieldName: FRCM
		/// FieldType: N
		/// Length: 13
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Actual quantity in free unit")]
		public decimal? M3_FRCM => GetNullableDecimal("FRCM");

		/// <summary>
		/// Description: Actual volume
		/// FieldName: VLMM
		/// FieldType: N
		/// Length: 11
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Actual volume")]
		public decimal? M3_VLMM => GetNullableDecimal("VLMM");

		/// <summary>
		/// Description: Packaging length
		/// FieldName: PACL
		/// FieldType: N
		/// Length: 7
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Packaging length")]
		public int? M3_PACL => GetNullableInt("PACL");

		/// <summary>
		/// Description: Packaging width
		/// FieldName: PACW
		/// FieldType: N
		/// Length: 7
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Packaging width")]
		public int? M3_PACW => GetNullableInt("PACW");

		/// <summary>
		/// Description: Packaging height
		/// FieldName: PACH
		/// FieldType: N
		/// Length: 7
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Packaging height")]
		public int? M3_PACH => GetNullableInt("PACH");

		/// <summary>
		/// Description: Packaging weight
		/// FieldName: TARW
		/// FieldType: N
		/// Length: 11
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Packaging weight")]
		public decimal? M3_TARW => GetNullableDecimal("TARW");

		/// <summary>
		/// Description: SEAL number
		/// FieldName: SEAL
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("SEAL number")]
		public string M3_SEAL => GetString("SEAL");

		/// <summary>
		/// Description: SSCC number
		/// FieldName: SSCC
		/// FieldType: A
		/// Length: 18
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("SSCC number")]
		public string M3_SSCC => GetString("SSCC");

		/// <summary>
		/// Description: External tracking number
		/// FieldName: ETRN
		/// FieldType: A
		/// Length: 30
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("External tracking number")]
		public string M3_ETRN => GetString("ETRN");

		/// <summary>
		/// Description: Package alias 1
		/// FieldName: PAN1
		/// FieldType: A
		/// Length: 30
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Package alias 1")]
		public string M3_PAN1 => GetString("PAN1");

		/// <summary>
		/// Description: Package alias 2
		/// FieldName: PAN2
		/// FieldType: A
		/// Length: 30
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Package alias 2")]
		public string M3_PAN2 => GetString("PAN2");

		/// <summary>
		/// Description: Package alias 3
		/// FieldName: PAN3
		/// FieldType: A
		/// Length: 30
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Package alias 3")]
		public string M3_PAN3 => GetString("PAN3");

		/// <summary>
		/// Description: Remark
		/// FieldName: DLRM
		/// FieldType: A
		/// Length: 40
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Remark")]
		public string M3_DLRM => GetString("DLRM");

		/// <summary>
		/// Description: Goods mark Odette standard
		/// FieldName: DLMO
		/// FieldType: A
		/// Length: 40
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Goods mark Odette standard")]
		public string M3_DLMO => GetString("DLMO");

		/// <summary>
		/// Description: Text identity
		/// FieldName: TXID
		/// FieldType: N
		/// Length: 13
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Text identity")]
		public decimal? M3_TXID => GetNullableDecimal("TXID");

		/// <summary>
		/// Description: Entry date
		/// FieldName: RGDT
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Entry date")]
		public DateTime? M3_RGDT => GetNullableDateTime("RGDT");

		/// <summary>
		/// Description: Entry time
		/// FieldName: RGTM
		/// FieldType: N
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Entry time")]
		public int? M3_RGTM => GetNullableInt("RGTM");

		/// <summary>
		/// Description: Change date
		/// FieldName: LMDT
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Change date")]
		public DateTime? M3_LMDT => GetNullableDateTime("LMDT");

		/// <summary>
		/// Description: Change number
		/// FieldName: CHNO
		/// FieldType: N
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Change number")]
		public int? M3_CHNO => GetNullableInt("CHNO");

		/// <summary>
		/// Description: Changed by
		/// FieldName: CHID
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Changed by")]
		public string M3_CHID => GetString("CHID");

		/// <summary>
		/// Description: Location
		/// FieldName: WHSL
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Location")]
		public string M3_WHSL => GetString("WHSL");
	}
}
// EOF
