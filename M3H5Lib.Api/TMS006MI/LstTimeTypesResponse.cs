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

namespace M3H5Lib.Api.TMS006MI
{
	public partial class LstTimeTypesResponse : M3BaseRecord 
	{

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
		/// Description: Time type
		/// FieldName: TTPE
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Time type")]
		public string M3TTPE => GetString("TTPE");

		/// <summary>
		/// Description: Pay element
		/// FieldName: KIWA
		/// FieldType: N
		/// Length: 4
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Pay element")]
		public int? M3KIWA => GetNullableInt("KIWA");

		/// <summary>
		/// Description: Time category
		/// FieldName: GLCD
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Time category")]
		public int? M3GLCD => GetNullableInt("GLCD");

		/// <summary>
		/// Description: Time type overtime to time off
		/// FieldName: TTOF
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Time type overtime to time off")]
		public string M3TTOF => GetString("TTOF");

		/// <summary>
		/// Description: Time type remaining time
		/// FieldName: RTBL
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Time type remaining time")]
		public string M3RTBL => GetString("RTBL");

		/// <summary>
		/// Description: Automatic generation time type
		/// FieldName: AUTT
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Automatic generation time type")]
		public string M3AUTT => GetString("AUTT");

		/// <summary>
		/// Description: Time factor
		/// FieldName: TMAU
		/// FieldType: N
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Time factor")]
		public int? M3TMAU => GetNullableInt("TMAU");

		/// <summary>
		/// Description: Balance
		/// FieldName: STFD
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Balance")]
		public string M3STFD => GetString("STFD");

		/// <summary>
		/// Description: Balance time factor
		/// FieldName: TMCF
		/// FieldType: N
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Balance time factor")]
		public int? M3TMCF => GetNullableInt("TMCF");

		/// <summary>
		/// Description: Minimum number of hours
		/// FieldName: MNTM
		/// FieldType: N
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Minimum number of hours")]
		public int? M3MNTM => GetNullableInt("MNTM");

		/// <summary>
		/// Description: Maximum number of hours
		/// FieldName: MXHO
		/// FieldType: N
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Maximum number of hours")]
		public int? M3MXHO => GetNullableInt("MXHO");

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
	}
}
// EOF
