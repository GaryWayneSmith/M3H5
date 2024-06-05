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

namespace M3H5Lib.Api.OIS100MI
{
	public partial class GetQuotResponse : M3BaseRecord 
	{

		/// <summary>
		/// Description: Customer
		/// FieldName: CUNO
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Customer")]
		public string M3_CUNO => GetString("CUNO");

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
		/// Description: Quotation reason
		/// FieldName: ORCD
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Quotation reason")]
		public string M3_ORCD => GetString("ORCD");

		/// <summary>
		/// Description: Ordering method
		/// FieldName: BECD
		/// FieldType: A
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Ordering method")]
		public string M3_BECD => GetString("BECD");

		/// <summary>
		/// Description: Valid to date
		/// FieldName: GIDT
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Valid to date")]
		public DateTime? M3_GIDT => GetNullableDateTime("GIDT");

		/// <summary>
		/// Description: Follow-up date 1
		/// FieldName: BVD1
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Follow-up date 1")]
		public DateTime? M3_BVD1 => GetNullableDateTime("BVD1");

		/// <summary>
		/// Description: Follow-up activity 1
		/// FieldName: BVC1
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Follow-up activity 1")]
		public string M3_BVC1 => GetString("BVC1");

		/// <summary>
		/// Description: Follow-up date 2
		/// FieldName: BVD2
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Follow-up date 2")]
		public DateTime? M3_BVD2 => GetNullableDateTime("BVD2");

		/// <summary>
		/// Description: Follow-up activity 2
		/// FieldName: BVC2
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Follow-up activity 2")]
		public string M3_BVC2 => GetString("BVC2");

		/// <summary>
		/// Description: Description follow-up activity 1
		/// FieldName: BVT1
		/// FieldType: A
		/// Length: 40
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Description follow-up activity 1")]
		public string M3_BVT1 => GetString("BVT1");

		/// <summary>
		/// Description: Description follow-up activity 2
		/// FieldName: BVT2
		/// FieldType: A
		/// Length: 40
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Description follow-up activity 2")]
		public string M3_BVT2 => GetString("BVT2");

		/// <summary>
		/// Description: Reference object - search key
		/// FieldName: REFO
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Reference object - search key")]
		public string M3_REFO => GetString("REFO");

		/// <summary>
		/// Description: Delivery time in days
		/// FieldName: DLDA
		/// FieldType: N
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Delivery time in days")]
		public int? M3_DLDA => GetNullableInt("DLDA");

		/// <summary>
		/// Description: User defined field 1
		/// FieldName: FFI1
		/// FieldType: A
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("User defined field 1")]
		public string M3_FFI1 => GetString("FFI1");

		/// <summary>
		/// Description: User defined field 2
		/// FieldName: FFI2
		/// FieldType: A
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("User defined field 2")]
		public string M3_FFI2 => GetString("FFI2");

		/// <summary>
		/// Description: User defined field 3
		/// FieldName: FFI3
		/// FieldType: A
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("User defined field 3")]
		public string M3_FFI3 => GetString("FFI3");

		/// <summary>
		/// Description: User defined field 4
		/// FieldName: FFI4
		/// FieldType: A
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("User defined field 4")]
		public string M3_FFI4 => GetString("FFI4");

		/// <summary>
		/// Description: User defined field 5
		/// FieldName: FFI5
		/// FieldType: A
		/// Length: 20
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("User defined field 5")]
		public string M3_FFI5 => GetString("FFI5");

		/// <summary>
		/// Description: User defined field 6
		/// FieldName: FFI6
		/// FieldType: A
		/// Length: 30
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("User defined field 6")]
		public string M3_FFI6 => GetString("FFI6");

		/// <summary>
		/// Description: Entry Date
		/// FieldName: RGDT
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Entry Date")]
		public DateTime? M3_RGDT => GetNullableDateTime("RGDT");

		/// <summary>
		/// Description: Entry Time
		/// FieldName: RGTM
		/// FieldType: N
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Entry Time")]
		public int? M3_RGTM => GetNullableInt("RGTM");
	}
}
// EOF
