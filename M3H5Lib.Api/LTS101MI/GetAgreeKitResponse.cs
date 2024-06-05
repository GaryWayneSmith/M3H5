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

namespace M3H5Lib.Api.LTS101MI
{
	public partial class GetAgreeKitResponse : M3BaseRecord 
	{

		/// <summary>
		/// Description: Kit number
		/// FieldName: KTNO
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Kit number")]
		public string M3_KTNO => GetString("KTNO");

		/// <summary>
		/// Description: Index adjustment line
		/// FieldName: INAL
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Index adjustment line")]
		public int? M3_INAL => GetNullableInt("INAL");

		/// <summary>
		/// Description: Price type
		/// FieldName: AFPT
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Price type")]
		public int? M3_AFPT => GetNullableInt("AFPT");

		/// <summary>
		/// Description: Name
		/// FieldName: KTDS
		/// FieldType: A
		/// Length: 30
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Name")]
		public string M3_KTDS => GetString("KTDS");

		/// <summary>
		/// Description: Feature 1
		/// FieldName: FT01
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Feature 1")]
		public string M3_FT01 => GetString("FT01");

		/// <summary>
		/// Description: Feature 2
		/// FieldName: FT02
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Feature 2")]
		public string M3_FT02 => GetString("FT02");

		/// <summary>
		/// Description: Feature 3
		/// FieldName: FT03
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Feature 3")]
		public string M3_FT03 => GetString("FT03");

		/// <summary>
		/// Description: Feature 4
		/// FieldName: FT04
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Feature 4")]
		public string M3_FT04 => GetString("FT04");

		/// <summary>
		/// Description: Feature 5
		/// FieldName: FT05
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Feature 5")]
		public string M3_FT05 => GetString("FT05");

		/// <summary>
		/// Description: Feature 6
		/// FieldName: FT06
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Feature 6")]
		public string M3_FT06 => GetString("FT06");

		/// <summary>
		/// Description: Feature 7
		/// FieldName: FT07
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Feature 7")]
		public string M3_FT07 => GetString("FT07");

		/// <summary>
		/// Description: Feature 8
		/// FieldName: FT08
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Feature 8")]
		public string M3_FT08 => GetString("FT08");

		/// <summary>
		/// Description: Feature 9
		/// FieldName: FT09
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Feature 9")]
		public string M3_FT09 => GetString("FT09");

		/// <summary>
		/// Description: Feature 10
		/// FieldName: FT10
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Feature 10")]
		public string M3_FT10 => GetString("FT10");

		/// <summary>
		/// Description: Feature 11
		/// FieldName: FT11
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Feature 11")]
		public string M3_FT11 => GetString("FT11");

		/// <summary>
		/// Description: Feature 12
		/// FieldName: FT12
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Feature 12")]
		public string M3_FT12 => GetString("FT12");

		/// <summary>
		/// Description: Feature 13
		/// FieldName: FT13
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Feature 13")]
		public string M3_FT13 => GetString("FT13");

		/// <summary>
		/// Description: Feature 14
		/// FieldName: FT14
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Feature 14")]
		public string M3_FT14 => GetString("FT14");
	}
}
// EOF
