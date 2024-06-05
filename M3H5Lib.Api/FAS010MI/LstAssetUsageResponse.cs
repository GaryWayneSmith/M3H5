/// **********************************************************************
/// This class is auto-generated.
/// Updated: 6/5/2024 3:52:20 PM
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

namespace M3H5Lib.Api.FAS010MI
{
	public partial class LstAssetUsageResponse : M3BaseRecord 
	{

		/// <summary>
		/// Description: Distribution unit
		/// FieldName: DMTS
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Distribution unit")]
		public string M3DMTS => GetString("DMTS");

		/// <summary>
		/// Description: Value period
		/// FieldName: VPER
		/// FieldType: N
		/// Length: 7
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Value period")]
		public int? M3VPER => GetNullableInt("VPER");

		/// <summary>
		/// Description: Share
		/// FieldName: ADSH
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Share")]
		public decimal? M3ADSH => GetNullableDecimal("ADSH");

		/// <summary>
		/// Description: Used share
		/// FieldName: USSH
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Used share")]
		public decimal? M3USSH => GetNullableDecimal("USSH");
	}
}
// EOF
