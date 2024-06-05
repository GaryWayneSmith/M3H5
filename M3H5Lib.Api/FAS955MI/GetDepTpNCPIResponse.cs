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

namespace M3H5Lib.Api.FAS955MI
{
	public partial class GetDepTpNCPIResponse : M3BaseRecord 
	{

		/// <summary>
		/// Description: Depreciation type
		/// FieldName: DPTP
		/// FieldType: N
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Depreciation type")]
		public int? M3_DPTP => GetNullableInt("DPTP");

		/// <summary>
		/// Description: Update factor
		/// FieldName: UPFC
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Update factor")]
		public int? M3_UPFC => GetNullableInt("UPFC");

		/// <summary>
		/// Description: Adjust cost
		/// FieldName: ADCS
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Adjust cost")]
		public int? M3_ADCS => GetNullableInt("ADCS");

		/// <summary>
		/// Description: Cost adjustment value type
		/// FieldName: CVTP
		/// FieldType: N
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Cost adjustment value type")]
		public int? M3_CVTP => GetNullableInt("CVTP");

		/// <summary>
		/// Description: Previous years depreciation
		/// FieldName: PDVT
		/// FieldType: N
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Previous years depreciation")]
		public int? M3_PDVT => GetNullableInt("PDVT");

		/// <summary>
		/// Description: Year-to-date depciation value
		/// FieldName: YVTP
		/// FieldType: N
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Year-to-date depciation value")]
		public int? M3_YVTP => GetNullableInt("YVTP");

		/// <summary>
		/// Description: Index table
		/// FieldName: IXTB
		/// FieldType: A
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Index table")]
		public string M3_IXTB => GetString("IXTB");
	}
}
// EOF