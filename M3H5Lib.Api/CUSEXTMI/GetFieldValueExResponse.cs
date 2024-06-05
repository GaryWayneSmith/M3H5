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

namespace M3H5Lib.Api.CUSEXTMI
{
	public partial class GetFieldValueExResponse : M3BaseRecord 
	{

		/// <summary>
		/// Description: Yes/no
		/// FieldName: CHB1
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Yes/no")]
		public int? M3_CHB1 => GetNullableInt("CHB1");

		/// <summary>
		/// Description: Yes/no
		/// FieldName: CHB2
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Yes/no")]
		public int? M3_CHB2 => GetNullableInt("CHB2");

		/// <summary>
		/// Description: Yes/no
		/// FieldName: CHB3
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Yes/no")]
		public int? M3_CHB3 => GetNullableInt("CHB3");

		/// <summary>
		/// Description: Yes/no
		/// FieldName: CHB4
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Yes/no")]
		public int? M3_CHB4 => GetNullableInt("CHB4");

		/// <summary>
		/// Description: Yes/no
		/// FieldName: CHB5
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Yes/no")]
		public int? M3_CHB5 => GetNullableInt("CHB5");

		/// <summary>
		/// Description: Yes/no
		/// FieldName: CHB6
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Yes/no")]
		public int? M3_CHB6 => GetNullableInt("CHB6");

		/// <summary>
		/// Description: Yes/no
		/// FieldName: CHB7
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Yes/no")]
		public int? M3_CHB7 => GetNullableInt("CHB7");

		/// <summary>
		/// Description: Yes/no
		/// FieldName: CHB8
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Yes/no")]
		public int? M3_CHB8 => GetNullableInt("CHB8");

		/// <summary>
		/// Description: Yes/no
		/// FieldName: CHB9
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Yes/no")]
		public int? M3_CHB9 => GetNullableInt("CHB9");

		/// <summary>
		/// Description: Ref field for date
		/// FieldName: DAT1
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Ref field for date")]
		public DateTime? M3_DAT1 => GetNullableDateTime("DAT1");

		/// <summary>
		/// Description: Ref field for date
		/// FieldName: DAT2
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Ref field for date")]
		public DateTime? M3_DAT2 => GetNullableDateTime("DAT2");

		/// <summary>
		/// Description: Ref field for date
		/// FieldName: DAT3
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Ref field for date")]
		public DateTime? M3_DAT3 => GetNullableDateTime("DAT3");

		/// <summary>
		/// Description: Ref field for date
		/// FieldName: DAT4
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Ref field for date")]
		public DateTime? M3_DAT4 => GetNullableDateTime("DAT4");

		/// <summary>
		/// Description: Ref field for date
		/// FieldName: DAT5
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Ref field for date")]
		public DateTime? M3_DAT5 => GetNullableDateTime("DAT5");

		/// <summary>
		/// Description: Ref field for date
		/// FieldName: DAT6
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Ref field for date")]
		public DateTime? M3_DAT6 => GetNullableDateTime("DAT6");

		/// <summary>
		/// Description: Ref field for date
		/// FieldName: DAT7
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Ref field for date")]
		public DateTime? M3_DAT7 => GetNullableDateTime("DAT7");

		/// <summary>
		/// Description: Ref field for date
		/// FieldName: DAT8
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Ref field for date")]
		public DateTime? M3_DAT8 => GetNullableDateTime("DAT8");

		/// <summary>
		/// Description: Ref field for date
		/// FieldName: DAT9
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Ref field for date")]
		public DateTime? M3_DAT9 => GetNullableDateTime("DAT9");

		/// <summary>
		/// Description: Alphanumeric field 120 positions
		/// FieldName: A122
		/// FieldType: A
		/// Length: 120
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Alphanumeric field 120 positions")]
		public string M3_A122 => GetString("A122");

		/// <summary>
		/// Description: Alphanumeric field 256 positions
		/// FieldName: A256
		/// FieldType: A
		/// Length: 256
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Alphanumeric field 256 positions")]
		public string M3_A256 => GetString("A256");
	}
}
// EOF
