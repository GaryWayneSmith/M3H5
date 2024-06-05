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

namespace M3H5Lib.Api.DRS045MI
{
	public partial class LstTimeZonesResponse : M3BaseRecord 
	{

		/// <summary>
		/// Description: Time zone
		/// FieldName: TIZO
		/// FieldType: A
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Time zone")]
		public string M3TIZO => GetString("TIZO");

		/// <summary>
		/// Description: Year
		/// FieldName: YEA4
		/// FieldType: N
		/// Length: 4
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Year")]
		public int? M3YEA4 => GetNullableInt("YEA4");

		/// <summary>
		/// Description: Hemisphere
		/// FieldName: HEMI
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Hemisphere")]
		public int? M3HEMI => GetNullableInt("HEMI");

		/// <summary>
		/// Description: Description
		/// FieldName: TX40
		/// FieldType: A
		/// Length: 40
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Description")]
		public string M3TX40 => GetString("TX40");

		/// <summary>
		/// Description: Name
		/// FieldName: TX15
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Name")]
		public string M3TX15 => GetString("TX15");

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
		/// Description: Daylight savings time
		/// FieldName: DLST
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Daylight savings time")]
		public int? M3DLST => GetNullableInt("DLST");

		/// <summary>
		/// Description: Valid from
		/// FieldName: VFDT
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Valid from")]
		public DateTime? M3VFDT => GetNullableDateTime("VFDT");

		/// <summary>
		/// Description: Valid to
		/// FieldName: VTDT
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Valid to")]
		public DateTime? M3VTDT => GetNullableDateTime("VTDT");

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
