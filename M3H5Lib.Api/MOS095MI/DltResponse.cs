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

namespace M3H5Lib.Api.MOS095MI
{
	public partial class DltResponse : M3BaseRecord 
	{

		/// <summary>
		/// Description: Scrapped quantity
		/// FieldName: SCQA
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Scrapped quantity")]
		public decimal? M3_SCQA => GetNullableDecimal("SCQA");

		/// <summary>
		/// Description: Used labor run time
		/// FieldName: UMAT
		/// FieldType: N
		/// Length: 9
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Used labor run time")]
		public int? M3_UMAT => GetNullableInt("UMAT");

		/// <summary>
		/// Description: Start date
		/// FieldName: STDT
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Start date")]
		public DateTime? M3_STDT => GetNullableDateTime("STDT");

		/// <summary>
		/// Description: Start time - operation
		/// FieldName: OSTM
		/// FieldType: N
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Start time - operation")]
		public int? M3_OSTM => GetNullableInt("OSTM");

		/// <summary>
		/// Description: Finish date
		/// FieldName: FIDT
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Finish date")]
		public DateTime? M3_FIDT => GetNullableDateTime("FIDT");

		/// <summary>
		/// Description: Stop time operation
		/// FieldName: OFTM
		/// FieldType: N
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Stop time operation")]
		public int? M3_OFTM => GetNullableInt("OFTM");

		/// <summary>
		/// Description: Labor charge code
		/// FieldName: LCDE
		/// FieldType: A
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Labor charge code")]
		public string M3_LCDE => GetString("LCDE");

		/// <summary>
		/// Description: Injury free
		/// FieldName: INFR
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Injury free")]
		public int? M3_INFR => GetNullableInt("INFR");

		/// <summary>
		/// Description: Rejection reason
		/// FieldName: SCRE
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Rejection reason")]
		public string M3_SCRE => GetString("SCRE");

		/// <summary>
		/// Description: Used labor setup time
		/// FieldName: UMAS
		/// FieldType: N
		/// Length: 9
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Used labor setup time")]
		public int? M3_UMAS => GetNullableInt("UMAS");

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
		/// Description: Costing type
		/// FieldName: PCTP
		/// FieldType: A
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Costing type")]
		public string M3_PCTP => GetString("PCTP");

		/// <summary>
		/// Description: Manual completion flag
		/// FieldName: REND
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Manual completion flag")]
		public int? M3_REND => GetNullableInt("REND");

		/// <summary>
		/// Description: Manufactured quantity
		/// FieldName: MAQA
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Manufactured quantity")]
		public decimal? M3_MAQA => GetNullableDecimal("MAQA");

		/// <summary>
		/// Description: Interface line suffix
		/// FieldName: IOSX
		/// FieldType: N
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Interface line suffix")]
		public int? M3_IOSX => GetNullableInt("IOSX");
	}
}
// EOF
