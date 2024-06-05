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

namespace M3H5Lib.Api.SES400MI
{
	public partial class LstAuthByRoleResponse : M3BaseRecord 
	{

		/// <summary>
		/// Description: Role
		/// FieldName: ROLL
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Role")]
		public string M3ROLL => GetString("ROLL");

		/// <summary>
		/// Description: Function
		/// FieldName: FNID
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Function")]
		public string M3FNID => GetString("FNID");

		/// <summary>
		/// Description: Company
		/// FieldName: CONO
		/// FieldType: N
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Company")]
		public int? M3CONO => GetNullableInt("CONO");

		/// <summary>
		/// Description: Division
		/// FieldName: DIVI
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Division")]
		public string M3DIVI => GetString("DIVI");

		/// <summary>
		/// Description: Alpha field 1 positions
		/// FieldName: AL01
		/// FieldType: A
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Alpha field 1 positions")]
		public string M3AL01 => GetString("AL01");

		/// <summary>
		/// Description: Alpha field 2 positions
		/// FieldName: AL02
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Alpha field 2 positions")]
		public string M3AL02 => GetString("AL02");

		/// <summary>
		/// Description: Alpha field 3 positions
		/// FieldName: AL03
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Alpha field 3 positions")]
		public string M3AL03 => GetString("AL03");

		/// <summary>
		/// Description: Alpha field 4 positions
		/// FieldName: AL04
		/// FieldType: A
		/// Length: 4
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Alpha field 4 positions")]
		public string M3AL04 => GetString("AL04");

		/// <summary>
		/// Description: Alpha field 5 positions
		/// FieldName: AL05
		/// FieldType: A
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Alpha field 5 positions")]
		public string M3AL05 => GetString("AL05");

		/// <summary>
		/// Description: Alpha field 6 positions
		/// FieldName: AL06
		/// FieldType: A
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Alpha field 6 positions")]
		public string M3AL06 => GetString("AL06");

		/// <summary>
		/// Description: Alpha field 7 positions
		/// FieldName: AL07
		/// FieldType: A
		/// Length: 7
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Alpha field 7 positions")]
		public string M3AL07 => GetString("AL07");

		/// <summary>
		/// Description: Alpha field 8 positions
		/// FieldName: AL08
		/// FieldType: A
		/// Length: 8
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Alpha field 8 positions")]
		public string M3AL08 => GetString("AL08");

		/// <summary>
		/// Description: Alpha field 9 positions
		/// FieldName: AL09
		/// FieldType: A
		/// Length: 9
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Alpha field 9 positions")]
		public string M3AL09 => GetString("AL09");
	}
}
// EOF
