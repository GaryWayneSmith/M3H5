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

namespace M3H5Lib.Api.CLAIMSMI
{
	public partial class GetClaimHeadFFResponse : M3BaseRecord 
	{

		/// <summary>
		/// Description: Text
		/// FieldName: FRE1
		/// FieldType: A
		/// Length: 60
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Text")]
		public string M3_FRE1 => GetString("FRE1");

		/// <summary>
		/// Description: Text
		/// FieldName: FRE2
		/// FieldType: A
		/// Length: 60
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Text")]
		public string M3_FRE2 => GetString("FRE2");

		/// <summary>
		/// Description: Text
		/// FieldName: FRE3
		/// FieldType: A
		/// Length: 60
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Text")]
		public string M3_FRE3 => GetString("FRE3");

		/// <summary>
		/// Description: Text
		/// FieldName: FRE4
		/// FieldType: A
		/// Length: 60
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Text")]
		public string M3_FRE4 => GetString("FRE4");

		/// <summary>
		/// Description: Text
		/// FieldName: FRE5
		/// FieldType: A
		/// Length: 60
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Text")]
		public string M3_FRE5 => GetString("FRE5");

		/// <summary>
		/// Description: Text
		/// FieldName: FRE6
		/// FieldType: A
		/// Length: 60
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Text")]
		public string M3_FRE6 => GetString("FRE6");

		/// <summary>
		/// Description: Text
		/// FieldName: FRE7
		/// FieldType: A
		/// Length: 60
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Text")]
		public string M3_FRE7 => GetString("FRE7");

		/// <summary>
		/// Description: Text
		/// FieldName: FRE8
		/// FieldType: A
		/// Length: 60
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Text")]
		public string M3_FRE8 => GetString("FRE8");

		/// <summary>
		/// Description: Text
		/// FieldName: FRE9
		/// FieldType: A
		/// Length: 60
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Text")]
		public string M3_FRE9 => GetString("FRE9");

		/// <summary>
		/// Description: Text
		/// FieldName: FREA
		/// FieldType: A
		/// Length: 60
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Text")]
		public string M3_FREA => GetString("FREA");

		/// <summary>
		/// Description: Entry date
		/// FieldName: DT01
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Entry date")]
		public DateTime? M3_DT01 => GetNullableDateTime("DT01");

		/// <summary>
		/// Description: Entry date
		/// FieldName: DT02
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Entry date")]
		public DateTime? M3_DT02 => GetNullableDateTime("DT02");

		/// <summary>
		/// Description: Numeric field 19¤6 positions
		/// FieldName: NF01
		/// FieldType: N
		/// Length: 21
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Numeric field 19¤6 positions")]
		public decimal? M3_NF01 => GetNullableDecimal("NF01");

		/// <summary>
		/// Description: Numeric field 19¤6 positions
		/// FieldName: NF02
		/// FieldType: N
		/// Length: 21
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Numeric field 19¤6 positions")]
		public decimal? M3_NF02 => GetNullableDecimal("NF02");
	}
}
// EOF
