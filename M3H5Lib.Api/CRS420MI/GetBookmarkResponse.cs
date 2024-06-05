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

namespace M3H5Lib.Api.CRS420MI
{
	public partial class GetBookmarkResponse : M3BaseRecord 
	{

		/// <summary>
		/// Description: Mail
		/// FieldName: MLID
		/// FieldType: N
		/// Length: 13
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Mail")]
		public decimal? M3_MLID => GetNullableDecimal("MLID");

		/// <summary>
		/// Description: Data identity
		/// FieldName: DTID
		/// FieldType: N
		/// Length: 13
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Data identity")]
		public decimal? M3_DTID => GetNullableDecimal("DTID");

		/// <summary>
		/// Description: Data identity reference
		/// FieldName: DTRF
		/// FieldType: N
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Data identity reference")]
		public int? M3_DTRF => GetNullableInt("DTRF");

		/// <summary>
		/// Description: Data identity subnumber
		/// FieldName: DTIS
		/// FieldType: N
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Data identity subnumber")]
		public int? M3_DTIS => GetNullableInt("DTIS");

		/// <summary>
		/// Description: Table
		/// FieldName: FILE
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Table")]
		public string M3_FILE => GetString("FILE");

		/// <summary>
		/// Description: Keystring
		/// FieldName: KSTR
		/// FieldType: A
		/// Length: 480
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Keystring")]
		public string M3_KSTR => GetString("KSTR");

		/// <summary>
		/// Description: Program name
		/// FieldName: PGNM
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Program name")]
		public string M3_PGNM => GetString("PGNM");

		/// <summary>
		/// Description: Panel check ID
		/// FieldName: PICC
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Panel check ID")]
		public string M3_PICC => GetString("PICC");

		/// <summary>
		/// Description: Sorting order
		/// FieldName: QTTP
		/// FieldType: N
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Sorting order")]
		public int? M3_QTTP => GetNullableInt("QTTP");

		/// <summary>
		/// Description: Option
		/// FieldName: OPT2
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Option")]
		public string M3_OPT2 => GetString("OPT2");

		/// <summary>
		/// Description: Field
		/// FieldName: FL01
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Field")]
		public string M3_FL01 => GetString("FL01");

		/// <summary>
		/// Description: Field
		/// FieldName: FL02
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Field")]
		public string M3_FL02 => GetString("FL02");

		/// <summary>
		/// Description: Field
		/// FieldName: FL03
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Field")]
		public string M3_FL03 => GetString("FL03");

		/// <summary>
		/// Description: Field
		/// FieldName: FL04
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Field")]
		public string M3_FL04 => GetString("FL04");

		/// <summary>
		/// Description: Field
		/// FieldName: FL05
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Field")]
		public string M3_FL05 => GetString("FL05");

		/// <summary>
		/// Description: Field
		/// FieldName: FL06
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Field")]
		public string M3_FL06 => GetString("FL06");

		/// <summary>
		/// Description: Field
		/// FieldName: FL07
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Field")]
		public string M3_FL07 => GetString("FL07");

		/// <summary>
		/// Description: Field
		/// FieldName: FL08
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Field")]
		public string M3_FL08 => GetString("FL08");

		/// <summary>
		/// Description: Field
		/// FieldName: FL09
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Field")]
		public string M3_FL09 => GetString("FL09");

		/// <summary>
		/// Description: Field
		/// FieldName: FL10
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Field")]
		public string M3_FL10 => GetString("FL10");

		/// <summary>
		/// Description: Transfer data area
		/// FieldName: DT01
		/// FieldType: A
		/// Length: 30
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Transfer data area")]
		public string M3_DT01 => GetString("DT01");

		/// <summary>
		/// Description: Transfer data area
		/// FieldName: DT02
		/// FieldType: A
		/// Length: 30
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Transfer data area")]
		public string M3_DT02 => GetString("DT02");

		/// <summary>
		/// Description: Transfer data area
		/// FieldName: DT03
		/// FieldType: A
		/// Length: 30
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Transfer data area")]
		public string M3_DT03 => GetString("DT03");

		/// <summary>
		/// Description: Transfer data area
		/// FieldName: DT04
		/// FieldType: A
		/// Length: 30
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Transfer data area")]
		public string M3_DT04 => GetString("DT04");

		/// <summary>
		/// Description: Transfer data area
		/// FieldName: DT05
		/// FieldType: A
		/// Length: 30
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Transfer data area")]
		public string M3_DT05 => GetString("DT05");

		/// <summary>
		/// Description: Transfer data area
		/// FieldName: DT06
		/// FieldType: A
		/// Length: 30
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Transfer data area")]
		public string M3_DT06 => GetString("DT06");

		/// <summary>
		/// Description: Transfer data area
		/// FieldName: DT07
		/// FieldType: A
		/// Length: 30
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Transfer data area")]
		public string M3_DT07 => GetString("DT07");

		/// <summary>
		/// Description: Transfer data area
		/// FieldName: DT08
		/// FieldType: A
		/// Length: 30
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Transfer data area")]
		public string M3_DT08 => GetString("DT08");

		/// <summary>
		/// Description: Transfer data area
		/// FieldName: DT09
		/// FieldType: A
		/// Length: 30
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Transfer data area")]
		public string M3_DT09 => GetString("DT09");

		/// <summary>
		/// Description: Transfer data area
		/// FieldName: DT10
		/// FieldType: A
		/// Length: 30
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Transfer data area")]
		public string M3_DT10 => GetString("DT10");

		/// <summary>
		/// Description: Overriding function
		/// FieldName: OFNC
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Overriding function")]
		public string M3_OFNC => GetString("OFNC");

		/// <summary>
		/// Description: Bookmark focus field
		/// FieldName: BFFL
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Bookmark focus field")]
		public string M3_BFFL => GetString("BFFL");
	}
}
// EOF
