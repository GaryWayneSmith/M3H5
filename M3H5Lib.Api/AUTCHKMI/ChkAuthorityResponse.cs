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

namespace M3H5Lib.Api.AUTCHKMI
{
	public partial class ChkAuthorityResponse : M3BaseRecord 
	{

		/// <summary>
		/// Description: Function permitted
		/// FieldName: ALPG
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Function permitted")]
		public int? M3ALPG => GetNullableInt("ALPG");

		/// <summary>
		/// Description: Option 1 permitted
		/// FieldName: ALO1
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Option 1 permitted")]
		public int? M3ALO1 => GetNullableInt("ALO1");

		/// <summary>
		/// Description: Option 2 permitted
		/// FieldName: ALO2
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Option 2 permitted")]
		public int? M3ALO2 => GetNullableInt("ALO2");

		/// <summary>
		/// Description: Option 3 permitted
		/// FieldName: ALO3
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Option 3 permitted")]
		public int? M3ALO3 => GetNullableInt("ALO3");

		/// <summary>
		/// Description: Option 4 permitted
		/// FieldName: ALO4
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Option 4 permitted")]
		public int? M3ALO4 => GetNullableInt("ALO4");

		/// <summary>
		/// Description: Option 5 permitted
		/// FieldName: ALO5
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Option 5 permitted")]
		public int? M3ALO5 => GetNullableInt("ALO5");

		/// <summary>
		/// Description: Option 6 permitted
		/// FieldName: ALO6
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Option 6 permitted")]
		public int? M3ALO6 => GetNullableInt("ALO6");

		/// <summary>
		/// Description: Option 7 permitted
		/// FieldName: ALO7
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Option 7 permitted")]
		public int? M3ALO7 => GetNullableInt("ALO7");

		/// <summary>
		/// Description: Option 8 permitted
		/// FieldName: ALO8
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Option 8 permitted")]
		public int? M3ALO8 => GetNullableInt("ALO8");

		/// <summary>
		/// Description: Option 9 permitted
		/// FieldName: ALO9
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Option 9 permitted")]
		public int? M3ALO9 => GetNullableInt("ALO9");

		/// <summary>
		/// Description: Function key Fxx permitted
		/// FieldName: AF01
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Function key Fxx permitted")]
		public int? M3AF01 => GetNullableInt("AF01");

		/// <summary>
		/// Description: Function key Fxx permitted
		/// FieldName: AF02
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Function key Fxx permitted")]
		public int? M3AF02 => GetNullableInt("AF02");

		/// <summary>
		/// Description: Function key Fxx permitted
		/// FieldName: AF03
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Function key Fxx permitted")]
		public int? M3AF03 => GetNullableInt("AF03");

		/// <summary>
		/// Description: Function key Fxx permitted
		/// FieldName: AF04
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Function key Fxx permitted")]
		public int? M3AF04 => GetNullableInt("AF04");

		/// <summary>
		/// Description: Function key Fxx permitted
		/// FieldName: AF05
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Function key Fxx permitted")]
		public int? M3AF05 => GetNullableInt("AF05");

		/// <summary>
		/// Description: Function key Fxx permitted
		/// FieldName: AF06
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Function key Fxx permitted")]
		public int? M3AF06 => GetNullableInt("AF06");

		/// <summary>
		/// Description: Function key Fxx permitted
		/// FieldName: AF07
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Function key Fxx permitted")]
		public int? M3AF07 => GetNullableInt("AF07");

		/// <summary>
		/// Description: Function key Fxx permitted
		/// FieldName: AF08
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Function key Fxx permitted")]
		public int? M3AF08 => GetNullableInt("AF08");

		/// <summary>
		/// Description: Function key Fxx permitted
		/// FieldName: AF09
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Function key Fxx permitted")]
		public int? M3AF09 => GetNullableInt("AF09");

		/// <summary>
		/// Description: Function key Fxx permitted
		/// FieldName: AF10
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Function key Fxx permitted")]
		public int? M3AF10 => GetNullableInt("AF10");

		/// <summary>
		/// Description: Function key Fxx permitted
		/// FieldName: AF11
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Function key Fxx permitted")]
		public int? M3AF11 => GetNullableInt("AF11");

		/// <summary>
		/// Description: Function key Fxx permitted
		/// FieldName: AF12
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Function key Fxx permitted")]
		public int? M3AF12 => GetNullableInt("AF12");

		/// <summary>
		/// Description: Function key Fxx permitted
		/// FieldName: AF13
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Function key Fxx permitted")]
		public int? M3AF13 => GetNullableInt("AF13");

		/// <summary>
		/// Description: Function key Fxx permitted
		/// FieldName: AF14
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Function key Fxx permitted")]
		public int? M3AF14 => GetNullableInt("AF14");

		/// <summary>
		/// Description: Function key Fxx permitted
		/// FieldName: AF15
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Function key Fxx permitted")]
		public int? M3AF15 => GetNullableInt("AF15");

		/// <summary>
		/// Description: Function key Fxx permitted
		/// FieldName: AF16
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Function key Fxx permitted")]
		public int? M3AF16 => GetNullableInt("AF16");

		/// <summary>
		/// Description: Function key Fxx permitted
		/// FieldName: AF17
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Function key Fxx permitted")]
		public int? M3AF17 => GetNullableInt("AF17");

		/// <summary>
		/// Description: Function key Fxx permitted
		/// FieldName: AF18
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Function key Fxx permitted")]
		public int? M3AF18 => GetNullableInt("AF18");

		/// <summary>
		/// Description: Function key Fxx permitted
		/// FieldName: AF19
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Function key Fxx permitted")]
		public int? M3AF19 => GetNullableInt("AF19");

		/// <summary>
		/// Description: Function key Fxx permitted
		/// FieldName: AF20
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Function key Fxx permitted")]
		public int? M3AF20 => GetNullableInt("AF20");

		/// <summary>
		/// Description: Function key Fxx permitted
		/// FieldName: AF21
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Function key Fxx permitted")]
		public int? M3AF21 => GetNullableInt("AF21");

		/// <summary>
		/// Description: Function key Fxx permitted
		/// FieldName: AF22
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Function key Fxx permitted")]
		public int? M3AF22 => GetNullableInt("AF22");

		/// <summary>
		/// Description: Function key Fxx permitted
		/// FieldName: AF23
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Function key Fxx permitted")]
		public int? M3AF23 => GetNullableInt("AF23");

		/// <summary>
		/// Description: Function key Fxx permitted
		/// FieldName: AF24
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Function key Fxx permitted")]
		public int? M3AF24 => GetNullableInt("AF24");

		/// <summary>
		/// Description: Combined field for the last 90 options
		/// FieldName: OP90
		/// FieldType: A
		/// Length: 90
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Combined field for the last 90 options")]
		public string M3OP90 => GetString("OP90");
	}
}
// EOF
