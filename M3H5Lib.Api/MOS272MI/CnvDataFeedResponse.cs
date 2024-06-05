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

namespace M3H5Lib.Api.MOS272MI
{
	public partial class CnvDataFeedResponse : M3BaseRecord 
	{

		/// <summary>
		/// Description: Converted Received date
		/// FieldName: CVRD
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Converted Received date")]
		public DateTime? M3CVRD => GetNullableDateTime("CVRD");

		/// <summary>
		/// Description: Converted Received time (HHMMSS)
		/// FieldName: CVRT
		/// FieldType: N
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Converted Received time (HHMMSS)")]
		public int? M3CVRT => GetNullableInt("CVRT");

		/// <summary>
		/// Description: Converted Module Date
		/// FieldName: CVMD
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Converted Module Date")]
		public DateTime? M3CVMD => GetNullableDateTime("CVMD");

		/// <summary>
		/// Description: Converted Module Time (HHMMSS)
		/// FieldName: CVMT
		/// FieldType: N
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Converted Module Time (HHMMSS)")]
		public int? M3CVMT => GetNullableInt("CVMT");

		/// <summary>
		/// Description: From Time zone
		/// FieldName: FTZN
		/// FieldType: A
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("From Time zone")]
		public string M3FTZN => GetString("FTZN");

		/// <summary>
		/// Description: To Time zone
		/// FieldName: TTZN
		/// FieldType: A
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("To Time zone")]
		public string M3TTZN => GetString("TTZN");

		/// <summary>
		/// Description: Number of hours from UTC
		/// FieldName: TGMT
		/// FieldType: A
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Number of hours from UTC")]
		public string M3TGMT => GetString("TGMT");

		/// <summary>
		/// Description: Adjustment
		/// FieldName: DSAD
		/// FieldType: A
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Adjustment")]
		public string M3DSAD => GetString("DSAD");
	}
}
// EOF
