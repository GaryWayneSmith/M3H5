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

namespace M3H5Lib.Api.MOS306MI
{
	public partial class GetResponse : M3BaseRecord 
	{

		/// <summary>
		/// Description: Service price
		/// FieldName: SERP
		/// FieldType: N
		/// Length: 19
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Service price")]
		public decimal? M3SERP => GetNullableDecimal("SERP");

		/// <summary>
		/// Description: Exchange rate type
		/// FieldName: CRTP
		/// FieldType: N
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Exchange rate type")]
		public int? M3CRTP => GetNullableInt("CRTP");

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
		/// Description: Price in labor currency
		/// FieldName: ADF1
		/// FieldType: N
		/// Length: 19
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Price in labor currency")]
		public decimal? M3ADF1 => GetNullableDecimal("ADF1");

		/// <summary>
		/// Description: Price in material currency
		/// FieldName: ADF2
		/// FieldType: N
		/// Length: 19
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Price in material currency")]
		public decimal? M3ADF2 => GetNullableDecimal("ADF2");

		/// <summary>
		/// Description: Price in subcontracting currency
		/// FieldName: ADF3
		/// FieldType: N
		/// Length: 19
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Price in subcontracting currency")]
		public decimal? M3ADF3 => GetNullableDecimal("ADF3");

		/// <summary>
		/// Description: Price in miscellaneous currency
		/// FieldName: ADF4
		/// FieldType: N
		/// Length: 19
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Price in miscellaneous currency")]
		public decimal? M3ADF4 => GetNullableDecimal("ADF4");

		/// <summary>
		/// Description: Fixed amount
		/// FieldName: ADY1
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Fixed amount")]
		public int? M3ADY1 => GetNullableInt("ADY1");

		/// <summary>
		/// Description: Fixed amount
		/// FieldName: ADY2
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Fixed amount")]
		public int? M3ADY2 => GetNullableInt("ADY2");

		/// <summary>
		/// Description: Fixed amount
		/// FieldName: ADY3
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Fixed amount")]
		public int? M3ADY3 => GetNullableInt("ADY3");

		/// <summary>
		/// Description: Fixed amount
		/// FieldName: ADY4
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Fixed amount")]
		public int? M3ADY4 => GetNullableInt("ADY4");
	}
}
// EOF
