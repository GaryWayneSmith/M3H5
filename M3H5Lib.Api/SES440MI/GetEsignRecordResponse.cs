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

namespace M3H5Lib.Api.SES440MI
{
	public partial class GetEsignRecordResponse : M3BaseRecord 
	{

		/// <summary>
		/// Description: Program
		/// FieldName: PGNM
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Program")]
		public string M3_PGNM => GetString("PGNM");

		/// <summary>
		/// Description: File
		/// FieldName: FILE
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("File")]
		public string M3_FILE => GetString("FILE");

		/// <summary>
		/// Description: Reason
		/// FieldName: TX60
		/// FieldType: A
		/// Length: 60
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Reason")]
		public string M3_TX60 => GetString("TX60");

		/// <summary>
		/// Description: Status
		/// FieldName: STAT
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Status")]
		public string M3_STAT => GetString("STAT");

		/// <summary>
		/// Description: Old value
		/// FieldName: OVAL
		/// FieldType: A
		/// Length: 60
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Old value")]
		public string M3_OVAL => GetString("OVAL");

		/// <summary>
		/// Description: New value
		/// FieldName: NVAL
		/// FieldType: A
		/// Length: 60
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("New value")]
		public string M3_NVAL => GetString("NVAL");

		/// <summary>
		/// Description: Changed by
		/// FieldName: USID
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Changed by")]
		public string M3_USID => GetString("USID");

		/// <summary>
		/// Description: Change date
		/// FieldName: CHDA
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Change date")]
		public DateTime? M3_CHDA => GetNullableDateTime("CHDA");

		/// <summary>
		/// Description: Change time
		/// FieldName: LMTM
		/// FieldType: N
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Change time")]
		public int? M3_LMTM => GetNullableInt("LMTM");

		/// <summary>
		/// Description: Sign date
		/// FieldName: SIDA
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Sign date")]
		public DateTime? M3_SIDA => GetNullableDateTime("SIDA");

		/// <summary>
		/// Description: Sign time
		/// FieldName: SITM
		/// FieldType: N
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Sign time")]
		public int? M3_SITM => GetNullableInt("SITM");

		/// <summary>
		/// Description: Signatory
		/// FieldName: USI0
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Signatory")]
		public string M3_USI0 => GetString("USI0");

		/// <summary>
		/// Description: Name
		/// FieldName: NAME
		/// FieldType: A
		/// Length: 36
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Name")]
		public string M3_NAME => GetString("NAME");

		/// <summary>
		/// Description: Opening panel
		/// FieldName: PICC
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Opening panel")]
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
		/// Description: Key string
		/// FieldName: KSTR
		/// FieldType: A
		/// Length: 480
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Key string")]
		public string M3_KSTR => GetString("KSTR");

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

		/// <summary>
		/// Description: Signature method
		/// FieldName: ESMT
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Signature method")]
		public int? M3_ESMT => GetNullableInt("ESMT");

		/// <summary>
		/// Description: Signature strategy
		/// FieldName: ESST
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Signature strategy")]
		public int? M3_ESST => GetNullableInt("ESST");

		/// <summary>
		/// Description: Signature process
		/// FieldName: ESP1
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Signature process")]
		public int? M3_ESP1 => GetNullableInt("ESP1");

		/// <summary>
		/// Description: Comment input
		/// FieldName: ECIN
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Comment input")]
		public int? M3_ECIN => GetNullableInt("ECIN");
	}
}
// EOF
