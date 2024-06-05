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

namespace M3H5Lib.Api.MHS200MI
{
	public partial class LstIntStyleResponse : M3BaseRecord 
	{

		/// <summary>
		/// Description: Partner
		/// FieldName: E0PA
		/// FieldType: A
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Partner")]
		public string M3E0PA => GetString("E0PA");

		/// <summary>
		/// Description: Message type
		/// FieldName: E065
		/// FieldType: A
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Message type")]
		public string M3E065 => GetString("E065");

		/// <summary>
		/// Description: Interface item number
		/// FieldName: IFIN
		/// FieldType: A
		/// Length: 32
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Interface item number")]
		public string M3IFIN => GetString("IFIN");

		/// <summary>
		/// Description: User-defined field heading 1 - style
		/// FieldName: FM01
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("User-defined field heading 1 - style")]
		public string M3FM01 => GetString("FM01");

		/// <summary>
		/// Description: User-defined field heading 2 - style
		/// FieldName: FM02
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("User-defined field heading 2 - style")]
		public string M3FM02 => GetString("FM02");

		/// <summary>
		/// Description: User-defined field heading 3 - style
		/// FieldName: FM03
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("User-defined field heading 3 - style")]
		public string M3FM03 => GetString("FM03");

		/// <summary>
		/// Description: User-defined field heading 4 - style
		/// FieldName: FM04
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("User-defined field heading 4 - style")]
		public string M3FM04 => GetString("FM04");

		/// <summary>
		/// Description: User-defined field heading 5 - style
		/// FieldName: FM05
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("User-defined field heading 5 - style")]
		public string M3FM05 => GetString("FM05");

		/// <summary>
		/// Description: User-defined field heading 6 - style
		/// FieldName: FM06
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("User-defined field heading 6 - style")]
		public string M3FM06 => GetString("FM06");

		/// <summary>
		/// Description: User-defined field heading 7 - style
		/// FieldName: FM07
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("User-defined field heading 7 - style")]
		public string M3FM07 => GetString("FM07");

		/// <summary>
		/// Description: User-defined field heading 8 - style
		/// FieldName: FM08
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("User-defined field heading 8 - style")]
		public string M3FM08 => GetString("FM08");

		/// <summary>
		/// Description: User-defined field heading 9 - style
		/// FieldName: FM09
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("User-defined field heading 9 - style")]
		public string M3FM09 => GetString("FM09");

		/// <summary>
		/// Description: User-defined field heading 10 - style
		/// FieldName: FM10
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("User-defined field heading 10 - style")]
		public string M3FM10 => GetString("FM10");

		/// <summary>
		/// Description: User-defined field heading 11 - style
		/// FieldName: FM11
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("User-defined field heading 11 - style")]
		public string M3FM11 => GetString("FM11");

		/// <summary>
		/// Description: User-defined field heading 12 - style
		/// FieldName: FM12
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("User-defined field heading 12 - style")]
		public string M3FM12 => GetString("FM12");

		/// <summary>
		/// Description: User-defined field heading 13 - style
		/// FieldName: FM13
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("User-defined field heading 13 - style")]
		public string M3FM13 => GetString("FM13");

		/// <summary>
		/// Description: User-defined field heading 14 - style
		/// FieldName: FM14
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("User-defined field heading 14 - style")]
		public string M3FM14 => GetString("FM14");

		/// <summary>
		/// Description: User-defined field heading 15 - style
		/// FieldName: FM15
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("User-defined field heading 15 - style")]
		public string M3FM15 => GetString("FM15");

		/// <summary>
		/// Description: User-defined field heading 16 - style
		/// FieldName: FM16
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("User-defined field heading 16 - style")]
		public string M3FM16 => GetString("FM16");

		/// <summary>
		/// Description: User-defined field heading 17 - style
		/// FieldName: FM17
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("User-defined field heading 17 - style")]
		public string M3FM17 => GetString("FM17");

		/// <summary>
		/// Description: User-defined field heading 18 - style
		/// FieldName: FM18
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("User-defined field heading 18 - style")]
		public string M3FM18 => GetString("FM18");

		/// <summary>
		/// Description: User-defined field heading 19 - style
		/// FieldName: FM19
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("User-defined field heading 19 - style")]
		public string M3FM19 => GetString("FM19");

		/// <summary>
		/// Description: User-defined field heading 20 - style
		/// FieldName: FM20
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("User-defined field heading 20 - style")]
		public string M3FM20 => GetString("FM20");
	}
}
// EOF
