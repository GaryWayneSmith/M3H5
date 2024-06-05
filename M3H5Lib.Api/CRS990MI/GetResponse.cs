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

namespace M3H5Lib.Api.CRS990MI
{
	public partial class GetResponse : M3BaseRecord 
	{

		/// <summary>
		/// Description: Field value
		/// FieldName: FV01
		/// FieldType: A
		/// Length: 80
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Field value")]
		public string M3_FV01 => GetString("FV01");

		/// <summary>
		/// Description: Field value
		/// FieldName: FV02
		/// FieldType: A
		/// Length: 40
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Field value")]
		public string M3_FV02 => GetString("FV02");

		/// <summary>
		/// Description: Field value
		/// FieldName: FV03
		/// FieldType: A
		/// Length: 40
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Field value")]
		public string M3_FV03 => GetString("FV03");

		/// <summary>
		/// Description: Field value
		/// FieldName: FV04
		/// FieldType: A
		/// Length: 40
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Field value")]
		public string M3_FV04 => GetString("FV04");

		/// <summary>
		/// Description: Field value
		/// FieldName: FV05
		/// FieldType: A
		/// Length: 40
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Field value")]
		public string M3_FV05 => GetString("FV05");

		/// <summary>
		/// Description: Field value
		/// FieldName: FV06
		/// FieldType: A
		/// Length: 40
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Field value")]
		public string M3_FV06 => GetString("FV06");

		/// <summary>
		/// Description: Field value
		/// FieldName: FV07
		/// FieldType: A
		/// Length: 40
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Field value")]
		public string M3_FV07 => GetString("FV07");

		/// <summary>
		/// Description: Field value
		/// FieldName: FV08
		/// FieldType: A
		/// Length: 40
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Field value")]
		public string M3_FV08 => GetString("FV08");

		/// <summary>
		/// Description: Field value
		/// FieldName: FV09
		/// FieldType: A
		/// Length: 40
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Field value")]
		public string M3_FV09 => GetString("FV09");

		/// <summary>
		/// Description: Field value
		/// FieldName: FV10
		/// FieldType: A
		/// Length: 40
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Field value")]
		public string M3_FV10 => GetString("FV10");

		/// <summary>
		/// Description: Field value
		/// FieldName: FV11
		/// FieldType: A
		/// Length: 40
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Field value")]
		public string M3_FV11 => GetString("FV11");

		/// <summary>
		/// Description: Field value
		/// FieldName: FV12
		/// FieldType: A
		/// Length: 40
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Field value")]
		public string M3_FV12 => GetString("FV12");

		/// <summary>
		/// Description: Field value
		/// FieldName: FV13
		/// FieldType: A
		/// Length: 40
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Field value")]
		public string M3_FV13 => GetString("FV13");

		/// <summary>
		/// Description: Field value
		/// FieldName: FV14
		/// FieldType: A
		/// Length: 40
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Field value")]
		public string M3_FV14 => GetString("FV14");

		/// <summary>
		/// Description: Field value
		/// FieldName: FV15
		/// FieldType: A
		/// Length: 40
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Field value")]
		public string M3_FV15 => GetString("FV15");
	}
}
// EOF
