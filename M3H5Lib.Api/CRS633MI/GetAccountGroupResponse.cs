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

namespace M3H5Lib.Api.CRS633MI
{
	public partial class GetAccountGroupResponse : M3BaseRecord 
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
		public string M3DIVI => GetString("DIVI");

		/// <summary>
		/// Description: Account group
		/// FieldName: AICL
		/// FieldType: A
		/// Length: 8
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Account group")]
		public string M3AICL => GetString("AICL");

		/// <summary>
		/// Description: Level
		/// FieldName: LVEL
		/// FieldType: N
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Level")]
		public int? M3LVEL => GetNullableInt("LVEL");

		/// <summary>
		/// Description: Sequence within level
		/// FieldName: LVLS
		/// FieldType: N
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Sequence within level")]
		public int? M3LVLS => GetNullableInt("LVLS");

		/// <summary>
		/// Description: Account group type
		/// FieldName: ACLT
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Account group type")]
		public int? M3ACLT => GetNullableInt("ACLT");

		/// <summary>
		/// Description: Page break
		/// FieldName: QRYB
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Page break")]
		public int? M3QRYB => GetNullableInt("QRYB");

		/// <summary>
		/// Description: Account group level 1
		/// FieldName: AIC1
		/// FieldType: A
		/// Length: 8
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Account group level 1")]
		public string M3AIC1 => GetString("AIC1");

		/// <summary>
		/// Description: Account group level 2
		/// FieldName: AIC2
		/// FieldType: A
		/// Length: 8
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Account group level 2")]
		public string M3AIC2 => GetString("AIC2");

		/// <summary>
		/// Description: Account group level 3
		/// FieldName: AIC3
		/// FieldType: A
		/// Length: 8
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Account group level 3")]
		public string M3AIC3 => GetString("AIC3");

		/// <summary>
		/// Description: Account group level 4
		/// FieldName: AIC4
		/// FieldType: A
		/// Length: 8
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Account group level 4")]
		public string M3AIC4 => GetString("AIC4");

		/// <summary>
		/// Description: Country description
		/// FieldName: TX40
		/// FieldType: A
		/// Length: 40
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Country description")]
		public string M3TX40 => GetString("TX40");

		/// <summary>
		/// Description: Country name
		/// FieldName: TX15
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Country name")]
		public string M3TX15 => GetString("TX15");
	}
}
// EOF
