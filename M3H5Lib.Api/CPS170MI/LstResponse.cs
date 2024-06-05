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

namespace M3H5Lib.Api.CPS170MI
{
	public partial class LstResponse : M3BaseRecord 
	{

		/// <summary>
		/// Description: Employee number
		/// FieldName: EMNO
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Employee number")]
		public string M3_EMNO => GetString("EMNO");

		/// <summary>
		/// Description: Calendar date
		/// FieldName: CADA
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Calendar date")]
		public DateTime? M3_CADA => GetNullableDateTime("CADA");

		/// <summary>
		/// Description: Capacity per unit and shift
		/// FieldName: CPTY
		/// FieldType: N
		/// Length: 11
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Capacity per unit and shift")]
		public decimal? M3_CPTY => GetNullableDecimal("CPTY");

		/// <summary>
		/// Description: Work hours from
		/// FieldName: STWT
		/// FieldType: N
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Work hours from")]
		public int? M3_STWT => GetNullableInt("STWT");

		/// <summary>
		/// Description: Work hours to
		/// FieldName: ENWT
		/// FieldType: N
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Work hours to")]
		public int? M3_ENWT => GetNullableInt("ENWT");

		/// <summary>
		/// Description: Work hours from
		/// FieldName: STW2
		/// FieldType: N
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Work hours from")]
		public int? M3_STW2 => GetNullableInt("STW2");

		/// <summary>
		/// Description: Work hours to
		/// FieldName: ENW2
		/// FieldType: N
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Work hours to")]
		public int? M3_ENW2 => GetNullableInt("ENW2");

		/// <summary>
		/// Description: Work hours from
		/// FieldName: STW3
		/// FieldType: N
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Work hours from")]
		public int? M3_STW3 => GetNullableInt("STW3");

		/// <summary>
		/// Description: Work hours to
		/// FieldName: ENW3
		/// FieldType: N
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Work hours to")]
		public int? M3_ENW3 => GetNullableInt("ENW3");

		/// <summary>
		/// Description: Work hours from
		/// FieldName: STW4
		/// FieldType: N
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Work hours from")]
		public int? M3_STW4 => GetNullableInt("STW4");

		/// <summary>
		/// Description: Work hours to
		/// FieldName: ENW4
		/// FieldType: N
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Work hours to")]
		public int? M3_ENW4 => GetNullableInt("ENW4");

		/// <summary>
		/// Description: Work hours from
		/// FieldName: STW5
		/// FieldType: N
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Work hours from")]
		public int? M3_STW5 => GetNullableInt("STW5");

		/// <summary>
		/// Description: Work hours to
		/// FieldName: ENW5
		/// FieldType: N
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Work hours to")]
		public int? M3_ENW5 => GetNullableInt("ENW5");
	}
}
// EOF
