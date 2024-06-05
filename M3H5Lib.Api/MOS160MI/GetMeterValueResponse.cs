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

namespace M3H5Lib.Api.MOS160MI
{
	public partial class GetMeterValueResponse : M3BaseRecord 
	{

		/// <summary>
		/// Description: MeterValue
		/// FieldName: MVA0
		/// FieldType: N
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("MeterValue")]
		public decimal? M3_MVA0 => GetNullableDecimal("MVA0");

		/// <summary>
		/// Description: Unit
		/// FieldName: UNIT
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Unit")]
		public string M3_UNIT => GetString("UNIT");

		/// <summary>
		/// Description: Meter
		/// FieldName: MES0
		/// FieldType: A
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Meter")]
		public string M3_MES0 => GetString("MES0");

		/// <summary>
		/// Description: Log date
		/// FieldName: LOGD
		/// FieldType: A
		/// Length: 8
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Log date")]
		public string M3_LOGD => GetString("LOGD");

		/// <summary>
		/// Description: Log time
		/// FieldName: LOGT
		/// FieldType: A
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Log time")]
		public string M3_LOGT => GetString("LOGT");

		/// <summary>
		/// Description: Repl Mtr Val
		/// FieldName: MVAX
		/// FieldType: N
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Repl Mtr Val")]
		public decimal? M3_MVAX => GetNullableDecimal("MVAX");
	}
}
// EOF
