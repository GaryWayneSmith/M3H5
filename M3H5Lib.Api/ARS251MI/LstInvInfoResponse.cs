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

namespace M3H5Lib.Api.ARS251MI
{
	public partial class LstInvInfoResponse : M3BaseRecord 
	{

		/// <summary>
		/// Description: GL information number
		/// FieldName: SEXN
		/// FieldType: N
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("GL information number")]
		public int? M3_SEXN => GetNullableInt("SEXN");

		/// <summary>
		/// Description: GL additional information
		/// FieldName: SEXI
		/// FieldType: A
		/// Length: 45
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("GL additional information")]
		public string M3_SEXI => GetString("SEXI");

		/// <summary>
		/// Description: GL information sequence number
		/// FieldName: SEXS
		/// FieldType: N
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("GL information sequence number")]
		public int? M3_SEXS => GetNullableInt("SEXS");
	}
}
// EOF
