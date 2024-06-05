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

namespace M3H5Lib.Api.PDS250MI
{
	public partial class LstLearnIDResponse : M3BaseRecord 
	{

		/// <summary>
		/// Description: Learning curve
		/// FieldName: LECU
		/// FieldType: A
		/// Length: 12
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Learning curve")]
		public string M3LECU => GetString("LECU");

		/// <summary>
		/// Description: Name
		/// FieldName: TX15
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Name")]
		public string M3TX15 => GetString("TX15");

		/// <summary>
		/// Description: Description
		/// FieldName: TX40
		/// FieldType: A
		/// Length: 40
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Description")]
		public string M3TX40 => GetString("TX40");

		/// <summary>
		/// Description: Grace period
		/// FieldName: GRAC
		/// FieldType: N
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Grace period")]
		public int? M3GRAC => GetNullableInt("GRAC");

		/// <summary>
		/// Description: Standard hours per day
		/// FieldName: STHU
		/// FieldType: N
		/// Length: 9
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Standard hours per day")]
		public int? M3STHU => GetNullableInt("STHU");

		/// <summary>
		/// Description: Number of levels
		/// FieldName: DNLV
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Number of levels")]
		public int? M3DNLV => GetNullableInt("DNLV");

		/// <summary>
		/// Description: Efficiency
		/// FieldName: EFF1
		/// FieldType: N
		/// Length: 7
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Efficiency")]
		public int? M3EFF1 => GetNullableInt("EFF1");

		/// <summary>
		/// Description: Efficiency
		/// FieldName: EFF2
		/// FieldType: N
		/// Length: 7
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Efficiency")]
		public int? M3EFF2 => GetNullableInt("EFF2");

		/// <summary>
		/// Description: Efficiency
		/// FieldName: EFF3
		/// FieldType: N
		/// Length: 7
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Efficiency")]
		public int? M3EFF3 => GetNullableInt("EFF3");

		/// <summary>
		/// Description: Efficiency
		/// FieldName: EFF4
		/// FieldType: N
		/// Length: 7
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Efficiency")]
		public int? M3EFF4 => GetNullableInt("EFF4");

		/// <summary>
		/// Description: Efficiency
		/// FieldName: EFF5
		/// FieldType: N
		/// Length: 7
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Efficiency")]
		public int? M3EFF5 => GetNullableInt("EFF5");

		/// <summary>
		/// Description: Efficiency
		/// FieldName: EFF6
		/// FieldType: N
		/// Length: 7
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Efficiency")]
		public int? M3EFF6 => GetNullableInt("EFF6");

		/// <summary>
		/// Description: Efficiency
		/// FieldName: EFF7
		/// FieldType: N
		/// Length: 7
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Efficiency")]
		public int? M3EFF7 => GetNullableInt("EFF7");

		/// <summary>
		/// Description: Efficiency
		/// FieldName: EFF8
		/// FieldType: N
		/// Length: 7
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Efficiency")]
		public int? M3EFF8 => GetNullableInt("EFF8");

		/// <summary>
		/// Description: Efficiency
		/// FieldName: EFF9
		/// FieldType: N
		/// Length: 7
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Efficiency")]
		public int? M3EFF9 => GetNullableInt("EFF9");

		/// <summary>
		/// Description: Days used
		/// FieldName: UDA1
		/// FieldType: N
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Days used")]
		public int? M3UDA1 => GetNullableInt("UDA1");

		/// <summary>
		/// Description: Days used
		/// FieldName: UDA2
		/// FieldType: N
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Days used")]
		public int? M3UDA2 => GetNullableInt("UDA2");

		/// <summary>
		/// Description: Days used
		/// FieldName: UDA3
		/// FieldType: N
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Days used")]
		public int? M3UDA3 => GetNullableInt("UDA3");

		/// <summary>
		/// Description: Days used
		/// FieldName: UDA4
		/// FieldType: N
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Days used")]
		public int? M3UDA4 => GetNullableInt("UDA4");

		/// <summary>
		/// Description: Days used
		/// FieldName: UDA5
		/// FieldType: N
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Days used")]
		public int? M3UDA5 => GetNullableInt("UDA5");

		/// <summary>
		/// Description: Days used
		/// FieldName: UDA6
		/// FieldType: N
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Days used")]
		public int? M3UDA6 => GetNullableInt("UDA6");

		/// <summary>
		/// Description: Days used
		/// FieldName: UDA7
		/// FieldType: N
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Days used")]
		public int? M3UDA7 => GetNullableInt("UDA7");

		/// <summary>
		/// Description: Days used
		/// FieldName: UDA8
		/// FieldType: N
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Days used")]
		public int? M3UDA8 => GetNullableInt("UDA8");

		/// <summary>
		/// Description: Days used
		/// FieldName: UDA9
		/// FieldType: N
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Days used")]
		public int? M3UDA9 => GetNullableInt("UDA9");
	}
}
// EOF
