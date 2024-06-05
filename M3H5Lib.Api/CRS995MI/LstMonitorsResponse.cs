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

namespace M3H5Lib.Api.CRS995MI
{
	public partial class LstMonitorsResponse : M3BaseRecord 
	{

		/// <summary>
		/// Description: Monitor Id
		/// FieldName: MONI
		/// FieldType: A
		/// Length: 40
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Monitor Id")]
		public string M3MONI => GetString("MONI");

		/// <summary>
		/// Description: Key/result
		/// FieldName: KRES
		/// FieldType: A
		/// Length: 40
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Key/result")]
		public string M3KRES => GetString("KRES");

		/// <summary>
		/// Description: Message
		/// FieldName: MSGD
		/// FieldType: A
		/// Length: 78
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Message")]
		public string M3MSGD => GetString("MSGD");

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
		/// Description: Compare value
		/// FieldName: CMP1
		/// FieldType: A
		/// Length: 30
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Compare value")]
		public string M3CMP1 => GetString("CMP1");

		/// <summary>
		/// Description: Operand
		/// FieldName: OPE1
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Operand")]
		public string M3OPE1 => GetString("OPE1");

		/// <summary>
		/// Description: Status
		/// FieldName: STA1
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Status")]
		public string M3STA1 => GetString("STA1");

		/// <summary>
		/// Description: Compare value
		/// FieldName: CMP2
		/// FieldType: A
		/// Length: 30
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Compare value")]
		public string M3CMP2 => GetString("CMP2");

		/// <summary>
		/// Description: Operand
		/// FieldName: OPE2
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Operand")]
		public string M3OPE2 => GetString("OPE2");

		/// <summary>
		/// Description: Status
		/// FieldName: STA2
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Status")]
		public string M3STA2 => GetString("STA2");
	}
}
// EOF
