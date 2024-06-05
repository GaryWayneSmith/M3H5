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

namespace M3H5Lib.Api.OPS200MI
{
	public partial class ChkVCLdgTendResponse : M3BaseRecord 
	{

		/// <summary>
		/// Description: Record status
		/// FieldName: RDST
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Record status")]
		public string M3_RDST => GetString("RDST");

		/// <summary>
		/// Description: Description
		/// FieldName: STDE
		/// FieldType: D
		/// Length: 30
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Description")]
		public DateTime? M3_STDE => GetNullableDateTime("STDE");

		/// <summary>
		/// Description: Valid code
		/// FieldName: VCVC
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Valid code")]
		public int? M3_VCVC => GetNullableInt("VCVC");

		/// <summary>
		/// Description: Amount due - local currency
		/// FieldName: REAM
		/// FieldType: N
		/// Length: 16
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Amount due - local currency")]
		public decimal? M3_REAM => GetNullableDecimal("REAM");

		/// <summary>
		/// Description: Due date
		/// FieldName: DUDT
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Due date")]
		public DateTime? M3_DUDT => GetNullableDateTime("DUDT");

		/// <summary>
		/// Description: Comment
		/// FieldName: COME
		/// FieldType: A
		/// Length: 80
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Comment")]
		public string M3_COME => GetString("COME");
	}
}
// EOF
