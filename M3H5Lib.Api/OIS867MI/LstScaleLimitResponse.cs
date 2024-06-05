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

namespace M3H5Lib.Api.OIS867MI
{
	public partial class LstScaleLimitResponse : M3BaseRecord 
	{

		/// <summary>
		/// Description: Limit value
		/// FieldName: LIMT
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Limit value")]
		public decimal? M3LIMT => GetNullableDecimal("LIMT");

		/// <summary>
		/// Description: Rebate percentage
		/// FieldName: SREP
		/// FieldType: N
		/// Length: 11
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Rebate percentage")]
		public decimal? M3SREP => GetNullableDecimal("SREP");

		/// <summary>
		/// Description: Rebate amount
		/// FieldName: SREA
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Rebate amount")]
		public decimal? M3SREA => GetNullableDecimal("SREA");
	}
}
// EOF
