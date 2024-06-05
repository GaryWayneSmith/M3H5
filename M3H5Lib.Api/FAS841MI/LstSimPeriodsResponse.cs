/// **********************************************************************
/// This class is auto-generated.
/// Updated: 6/5/2024 3:52:20 PM
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

namespace M3H5Lib.Api.FAS841MI
{
	public partial class LstSimPeriodsResponse : M3BaseRecord 
	{

		/// <summary>
		/// Description: Value type
		/// FieldName: VATP
		/// FieldType: N
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Value type")]
		public int? M3VATP => GetNullableInt("VATP");

		/// <summary>
		/// Description: Value period
		/// FieldName: VPER
		/// FieldType: N
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Value period")]
		public int? M3VPER => GetNullableInt("VPER");

		/// <summary>
		/// Description: Depreciation plan simulation difference
		/// FieldName: DPSB
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Depreciation plan simulation difference")]
		public int? M3DPSB => GetNullableInt("DPSB");

		/// <summary>
		/// Description: Simulated depreciation amount
		/// FieldName: DPSA
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Simulated depreciation amount")]
		public decimal? M3DPSA => GetNullableDecimal("DPSA");

		/// <summary>
		/// Description: Simulated depreciation amount currency
		/// FieldName: DPSC
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Simulated depreciation amount currency")]
		public decimal? M3DPSC => GetNullableDecimal("DPSC");

		/// <summary>
		/// Description: Simulated remaining value
		/// FieldName: DPSR
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Simulated remaining value")]
		public decimal? M3DPSR => GetNullableDecimal("DPSR");

		/// <summary>
		/// Description: Fixed asset value currency
		/// FieldName: FAVA
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Fixed asset value currency")]
		public decimal? M3FAVA => GetNullableDecimal("FAVA");

		/// <summary>
		/// Description: Fixed asset value currency
		/// FieldName: FAVC
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Fixed asset value currency")]
		public decimal? M3FAVC => GetNullableDecimal("FAVC");

		/// <summary>
		/// Description: Remaining value
		/// FieldName: FAVR
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Remaining value")]
		public decimal? M3FAVR => GetNullableDecimal("FAVR");

		/// <summary>
		/// Description: Entry date
		/// FieldName: RGDT
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Entry date")]
		public DateTime? M3RGDT => GetNullableDateTime("RGDT");

		/// <summary>
		/// Description: Change date
		/// FieldName: LMDT
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Change date")]
		public DateTime? M3LMDT => GetNullableDateTime("LMDT");

		/// <summary>
		/// Description: Changed by
		/// FieldName: CHID
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Changed by")]
		public string M3CHID => GetString("CHID");
	}
}
// EOF
