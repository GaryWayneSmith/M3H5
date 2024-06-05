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

namespace M3H5Lib.Api.SOS200MI
{
	public partial class LstWrkSchedHeadResponse : M3BaseRecord 
	{

		/// <summary>
		/// Description: Division
		/// FieldName: DIVI
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Division")]
		public string M3_DIVI => GetString("DIVI");

		/// <summary>
		/// Description: Year
		/// FieldName: YEID
		/// FieldType: N
		/// Length: 4
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Year")]
		public int? M3_YEID => GetNullableInt("YEID");

		/// <summary>
		/// Description: Work schedule
		/// FieldName: WOSC
		/// FieldType: N
		/// Length: 8
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Work schedule")]
		public int? M3_WOSC => GetNullableInt("WOSC");

		/// <summary>
		/// Description: Name
		/// FieldName: TX15
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Name")]
		public string M3_TX15 => GetString("TX15");

		/// <summary>
		/// Description: Description
		/// FieldName: TX40
		/// FieldType: A
		/// Length: 40
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Description")]
		public string M3_TX40 => GetString("TX40");

		/// <summary>
		/// Description: Basic schedule
		/// FieldName: BASC
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Basic schedule")]
		public int? M3_BASC => GetNullableInt("BASC");

		/// <summary>
		/// Description: Basic schedule number
		/// FieldName: WOSB
		/// FieldType: N
		/// Length: 12
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Basic schedule number")]
		public decimal? M3_WOSB => GetNullableDecimal("WOSB");

		/// <summary>
		/// Description: Interval - number of days
		/// FieldName: WPER
		/// FieldType: N
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Interval - number of days")]
		public int? M3_WPER => GetNullableInt("WPER");

		/// <summary>
		/// Description: Day number
		/// FieldName: DNBR
		/// FieldType: N
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Day number")]
		public int? M3_DNBR => GetNullableInt("DNBR");

		/// <summary>
		/// Description: Work hour type
		/// FieldName: PTTP
		/// FieldType: A
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Work hour type")]
		public string M3_PTTP => GetString("PTTP");

		/// <summary>
		/// Description: Part-time percent
		/// FieldName: PTPR
		/// FieldType: N
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Part-time percent")]
		public int? M3_PTPR => GetNullableInt("PTPR");

		/// <summary>
		/// Description: Work hours per week
		/// FieldName: WTWK
		/// FieldType: N
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Work hours per week")]
		public int? M3_WTWK => GetNullableInt("WTWK");

		/// <summary>
		/// Description: Capacity utilization rate
		/// FieldName: ACTL
		/// FieldType: N
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Capacity utilization rate")]
		public int? M3_ACTL => GetNullableInt("ACTL");

		/// <summary>
		/// Description: Workday percentage
		/// FieldName: HDCO
		/// FieldType: N
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Workday percentage")]
		public int? M3_HDCO => GetNullableInt("HDCO");

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
	}
}
// EOF
