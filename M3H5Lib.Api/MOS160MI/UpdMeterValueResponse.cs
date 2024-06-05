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

namespace M3H5Lib.Api.MOS160MI
{
	public partial class UpdMeterValueResponse : M3BaseRecord 
	{

		/// <summary>
		/// Description: Meter
		/// FieldName: MES0
		/// FieldType: A
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Meter")]
		public string M3MES0 => GetString("MES0");

		/// <summary>
		/// Description: MeterValue
		/// FieldName: MVA0
		/// FieldType: N
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("MeterValue")]
		public decimal? M3MVA0 => GetNullableDecimal("MVA0");

		/// <summary>
		/// Description: Repl Mtr Val
		/// FieldName: MVAX
		/// FieldType: N
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Repl Mtr Val")]
		public decimal? M3MVAX => GetNullableDecimal("MVAX");
	}
}
// EOF
