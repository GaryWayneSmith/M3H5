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

namespace M3H5Lib.Api.MMS200MI
{
	public partial class LstItmAltUnitMsResponse : M3BaseRecord 
	{

		/// <summary>
		/// Description: Item number
		/// FieldName: ITNO
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Item number")]
		public string M3_ITNO => GetString("ITNO");

		/// <summary>
		/// Description: Item description
		/// FieldName: ITDS
		/// FieldType: A
		/// Length: 30
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Item description")]
		public string M3_ITDS => GetString("ITDS");

		/// <summary>
		/// Description: Description 2
		/// FieldName: FUDS
		/// FieldType: A
		/// Length: 60
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Description 2")]
		public string M3_FUDS => GetString("FUDS");

		/// <summary>
		/// Description: Alternate U/M type
		/// FieldName: AUTP
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Alternate U/M type")]
		public int? M3_AUTP => GetNullableInt("AUTP");

		/// <summary>
		/// Description: Alternate U/M
		/// FieldName: ALUN
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Alternate U/M")]
		public string M3_ALUN => GetString("ALUN");

		/// <summary>
		/// Description: Alternate U/M description
		/// FieldName: TX40
		/// FieldType: A
		/// Length: 40
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Alternate U/M description")]
		public string M3_TX40 => GetString("TX40");

		/// <summary>
		/// Description: Number of decimal places
		/// FieldName: DCCD
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Number of decimal places")]
		public int? M3_DCCD => GetNullableInt("DCCD");

		/// <summary>
		/// Description: Conversion factor
		/// FieldName: COFA
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Conversion factor")]
		public decimal? M3_COFA => GetNullableDecimal("COFA");

		/// <summary>
		/// Description: Conversion form
		/// FieldName: DMCF
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Conversion form")]
		public int? M3_DMCF => GetNullableInt("DMCF");

		/// <summary>
		/// Description: Price adjustment factor
		/// FieldName: PCOF
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Price adjustment factor")]
		public decimal? M3_PCOF => GetNullableDecimal("PCOF");

		/// <summary>
		/// Description: Standard U/M - purchase order
		/// FieldName: AUS1
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Standard U/M - purchase order")]
		public int? M3_AUS1 => GetNullableInt("AUS1");

		/// <summary>
		/// Description: Standard U/M - sales
		/// FieldName: AUS2
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Standard U/M - sales")]
		public int? M3_AUS2 => GetNullableInt("AUS2");

		/// <summary>
		/// Description: Standard U/M - manufacturing
		/// FieldName: AUS3
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Standard U/M - manufacturing")]
		public int? M3_AUS3 => GetNullableInt("AUS3");

		/// <summary>
		/// Description: Standard U/M - production engineering
		/// FieldName: AUS4
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Standard U/M - production engineering")]
		public int? M3_AUS4 => GetNullableInt("AUS4");

		/// <summary>
		/// Description: Standard U/M - purchase price
		/// FieldName: AUS5
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Standard U/M - purchase price")]
		public int? M3_AUS5 => GetNullableInt("AUS5");

		/// <summary>
		/// Description: Standard U/M - statistics
		/// FieldName: AUS6
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Standard U/M - statistics")]
		public int? M3_AUS6 => GetNullableInt("AUS6");

		/// <summary>
		/// Description: Standard U/M - sales price
		/// FieldName: AUS9
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Standard U/M - sales price")]
		public int? M3_AUS9 => GetNullableInt("AUS9");

		/// <summary>
		/// Description: Order multiple
		/// FieldName: UNMU
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Order multiple")]
		public decimal? M3_UNMU => GetNullableDecimal("UNMU");

		/// <summary>
		/// Description: Formula
		/// FieldName: FMID
		/// FieldType: A
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Formula")]
		public string M3_FMID => GetString("FMID");

		/// <summary>
		/// Description: Result identity
		/// FieldName: RESI
		/// FieldType: A
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Result identity")]
		public string M3_RESI => GetString("RESI");

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
		/// Description: Standard U/M - costing
		/// FieldName: AUSB
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Standard U/M - costing")]
		public int? M3_AUSB => GetNullableInt("AUSB");

		/// <summary>
		/// Description: Standard U/M - catch weight
		/// FieldName: AUSC
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Standard U/M - catch weight")]
		public int? M3_AUSC => GetNullableInt("AUSC");

		/// <summary>
		/// Description: Extended item number
		/// FieldName: ITNE
		/// FieldType: A
		/// Length: 40
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Extended item number")]
		public string M3_ITNE => GetString("ITNE");

		/// <summary>
		/// Description: Logistics U/M
		/// FieldName: LGUN
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Logistics U/M")]
		public int? M3_LGUN => GetNullableInt("LGUN");

		/// <summary>
		/// Description: Catch weight price U/M
		/// FieldName: CWPU
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Catch weight price U/M")]
		public int? M3_CWPU => GetNullableInt("CWPU");

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
	}
}
// EOF
