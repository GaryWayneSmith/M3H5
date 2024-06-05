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

namespace M3H5Lib.Api.MMS015MI
{
	public partial class LstResponse : M3BaseRecord 
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
		public string M3ITNO => GetString("ITNO");

		/// <summary>
		/// Description: Alternate U/M type
		/// FieldName: AUTP
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Alternate U/M type")]
		public int? M3AUTP => GetNullableInt("AUTP");

		/// <summary>
		/// Description: Alternate U/M
		/// FieldName: ALUN
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Alternate U/M")]
		public string M3ALUN => GetString("ALUN");

		/// <summary>
		/// Description: Number of decimal places
		/// FieldName: DCCD
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Number of decimal places")]
		public int? M3DCCD => GetNullableInt("DCCD");

		/// <summary>
		/// Description: Conversion factor
		/// FieldName: COFA
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Conversion factor")]
		public decimal? M3COFA => GetNullableDecimal("COFA");

		/// <summary>
		/// Description: Conversion form
		/// FieldName: DMCF
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Conversion form")]
		public int? M3DMCF => GetNullableInt("DMCF");

		/// <summary>
		/// Description: Price adjustment factor
		/// FieldName: PCOF
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Price adjustment factor")]
		public decimal? M3PCOF => GetNullableDecimal("PCOF");

		/// <summary>
		/// Description: Standard U/M - purchase order
		/// FieldName: AUS1
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Standard U/M - purchase order")]
		public int? M3AUS1 => GetNullableInt("AUS1");

		/// <summary>
		/// Description: Standard U/M - customer order sales
		/// FieldName: AUS2
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Standard U/M - customer order sales")]
		public int? M3AUS2 => GetNullableInt("AUS2");

		/// <summary>
		/// Description: Standard U/M - manufacturing
		/// FieldName: AUS3
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Standard U/M - manufacturing")]
		public int? M3AUS3 => GetNullableInt("AUS3");

		/// <summary>
		/// Description: Standard U/M - production engineering
		/// FieldName: AUS4
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Standard U/M - production engineering")]
		public int? M3AUS4 => GetNullableInt("AUS4");

		/// <summary>
		/// Description: Standard U/M - purchase price
		/// FieldName: AUS5
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Standard U/M - purchase price")]
		public int? M3AUS5 => GetNullableInt("AUS5");

		/// <summary>
		/// Description: Standard U/M - statistics
		/// FieldName: AUS6
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Standard U/M - statistics")]
		public int? M3AUS6 => GetNullableInt("AUS6");

		/// <summary>
		/// Description: Default U/M - sales price
		/// FieldName: AUS9
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Default U/M - sales price")]
		public int? M3AUS9 => GetNullableInt("AUS9");

		/// <summary>
		/// Description: Order multiple
		/// FieldName: UNMU
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Order multiple")]
		public decimal? M3UNMU => GetNullableDecimal("UNMU");

		/// <summary>
		/// Description: Formula
		/// FieldName: FMID
		/// FieldType: A
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Formula")]
		public string M3FMID => GetString("FMID");

		/// <summary>
		/// Description: Result identity
		/// FieldName: RESI
		/// FieldType: A
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Result identity")]
		public string M3RESI => GetString("RESI");

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
		/// Description: Standard U/M - catch weight
		/// FieldName: AUSC
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Standard U/M - catch weight")]
		public int? M3AUSC => GetNullableInt("AUSC");

		/// <summary>
		/// Description: Standard U/M - cost
		/// FieldName: AUSB
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Standard U/M - cost")]
		public int? M3AUSB => GetNullableInt("AUSB");

		/// <summary>
		/// Description: Logistics U/M
		/// FieldName: LGUN
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Logistics U/M")]
		public int? M3LGUN => GetNullableInt("LGUN");

		/// <summary>
		/// Description: Catch weight price U/M
		/// FieldName: CWPU
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Catch weight price U/M")]
		public int? M3CWPU => GetNullableInt("CWPU");

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
	}
}
// EOF
