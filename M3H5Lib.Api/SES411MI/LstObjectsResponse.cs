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

namespace M3H5Lib.Api.SES411MI
{
	public partial class LstObjectsResponse : M3BaseRecord 
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
		public string M3PGNM => GetString("PGNM");

		/// <summary>
		/// Description: File
		/// FieldName: FILE
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("File")]
		public string M3FILE => GetString("FILE");

		/// <summary>
		/// Description: Field
		/// FieldName: FLDI
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Field")]
		public string M3FLDI => GetString("FLDI");

		/// <summary>
		/// Description: Reason
		/// FieldName: TX60
		/// FieldType: A
		/// Length: 60
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Reason")]
		public string M3TX60 => GetString("TX60");

		/// <summary>
		/// Description: Sign method
		/// FieldName: ESMT
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Sign method")]
		public int? M3ESMT => GetNullableInt("ESMT");

		/// <summary>
		/// Description: Sign strategy
		/// FieldName: ESST
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Sign strategy")]
		public int? M3ESST => GetNullableInt("ESST");

		/// <summary>
		/// Description: Sign process
		/// FieldName: ESP1
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Sign process")]
		public int? M3ESP1 => GetNullableInt("ESP1");

		/// <summary>
		/// Description: Comment input
		/// FieldName: ECIN
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Comment input")]
		public int? M3ECIN => GetNullableInt("ECIN");

		/// <summary>
		/// Description: Status
		/// FieldName: STAT
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Status")]
		public string M3STAT => GetString("STAT");

		/// <summary>
		/// Description: Text identity
		/// FieldName: TXID
		/// FieldType: N
		/// Length: 13
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Text identity")]
		public decimal? M3TXID => GetNullableDecimal("TXID");

		/// <summary>
		/// Description: Send application message - successful
		/// FieldName: SSND
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Send application message - successful")]
		public int? M3SSND => GetNullableInt("SSND");

		/// <summary>
		/// Description: Receiver - successful
		/// FieldName: SREC
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Receiver - successful")]
		public string M3SREC => GetString("SREC");

		/// <summary>
		/// Description: BOD enabled - successful
		/// FieldName: SBOD
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("BOD enabled - successful")]
		public int? M3SBOD => GetNullableInt("SBOD");

		/// <summary>
		/// Description: BOD message type - successful
		/// FieldName: SBDM
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("BOD message type - successful")]
		public int? M3SBDM => GetNullableInt("SBDM");

		/// <summary>
		/// Description: Workflow name - successful
		/// FieldName: SWFN
		/// FieldType: A
		/// Length: 60
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Workflow name - successful")]
		public string M3SWFN => GetString("SWFN");

		/// <summary>
		/// Description: Send application message - failed
		/// FieldName: FSND
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Send application message - failed")]
		public int? M3FSND => GetNullableInt("FSND");

		/// <summary>
		/// Description: Receiver - failed
		/// FieldName: FREC
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Receiver - failed")]
		public string M3FREC => GetString("FREC");

		/// <summary>
		/// Description: BOD enabled - failed
		/// FieldName: FBOD
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("BOD enabled - failed")]
		public int? M3FBOD => GetNullableInt("FBOD");

		/// <summary>
		/// Description: BOD message type - failed
		/// FieldName: FBDM
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("BOD message type - failed")]
		public int? M3FBDM => GetNullableInt("FBDM");

		/// <summary>
		/// Description: Workflow name - failed
		/// FieldName: FWFN
		/// FieldType: A
		/// Length: 60
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Workflow name - failed")]
		public string M3FWFN => GetString("FWFN");
	}
}
// EOF
