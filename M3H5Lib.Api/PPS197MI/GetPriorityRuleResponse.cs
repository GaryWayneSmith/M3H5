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

namespace M3H5Lib.Api.PPS197MI
{
	public partial class GetPriorityRuleResponse : M3BaseRecord 
	{

		/// <summary>
		/// Description: Rule
		/// FieldName: RULE
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Rule")]
		public string M3_RULE => GetString("RULE");

		/// <summary>
		/// Description: Value alpha-numerical
		/// FieldName: VALA
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Value alpha-numerical")]
		public string M3_VALA => GetString("VALA");

		/// <summary>
		/// Description: AND operator
		/// FieldName: ANDO
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("AND operator")]
		public int? M3_ANDO => GetNullableInt("ANDO");

		/// <summary>
		/// Description: Priority
		/// FieldName: PPRN
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Priority")]
		public int? M3_PPRN => GetNullableInt("PPRN");
	}
}
// EOF
