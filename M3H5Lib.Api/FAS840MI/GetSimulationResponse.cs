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

namespace M3H5Lib.Api.FAS840MI
{
	public partial class GetSimulationResponse : M3BaseRecord 
	{

		/// <summary>
		/// Description: Fixed asset type
		/// FieldName: FATP
		/// FieldType: A
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Fixed asset type")]
		public string M3_FATP => GetString("FATP");

		/// <summary>
		/// Description: Fixed asset group
		/// FieldName: ACAT
		/// FieldType: A
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Fixed asset group")]
		public string M3_ACAT => GetString("ACAT");

		/// <summary>
		/// Description: Depreciation plan simulation date
		/// FieldName: DPSD
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Depreciation plan simulation date")]
		public DateTime? M3_DPSD => GetNullableDateTime("DPSD");

		/// <summary>
		/// Description: Depreciation plan simulation status
		/// FieldName: DPSS
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Depreciation plan simulation status")]
		public string M3_DPSS => GetString("DPSS");

		/// <summary>
		/// Description: Depreciation plan simulation difference
		/// FieldName: DPSB
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Depreciation plan simulation difference")]
		public int? M3_DPSB => GetNullableInt("DPSB");

		/// <summary>
		/// Description: Entry date
		/// FieldName: RGDT
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Entry date")]
		public DateTime? M3_RGDT => GetNullableDateTime("RGDT");

		/// <summary>
		/// Description: Change date
		/// FieldName: LMDT
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Change date")]
		public DateTime? M3_LMDT => GetNullableDateTime("LMDT");

		/// <summary>
		/// Description: Changed by
		/// FieldName: CHID
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Changed by")]
		public string M3_CHID => GetString("CHID");
	}
}
// EOF