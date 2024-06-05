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

namespace M3H5Lib.Api.SOS100MI
{
	public partial class LstWorkScheduleResponse : M3BaseRecord 
	{

		/// <summary>
		/// Description: Division
		/// FieldName: DIVI
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Division")]
		public string M3DIVI => GetString("DIVI");

		/// <summary>
		/// Description: Work schedule
		/// FieldName: WOSC
		/// FieldType: N
		/// Length: 8
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Work schedule")]
		public int? M3WOSC => GetNullableInt("WOSC");

		/// <summary>
		/// Description: Date
		/// FieldName: DTUM
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Date")]
		public DateTime? M3DTUM => GetNullableDateTime("DTUM");

		/// <summary>
		/// Description: From time
		/// FieldName: FRTM
		/// FieldType: N
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("From time")]
		public int? M3FRTM => GetNullableInt("FRTM");

		/// <summary>
		/// Description: To time
		/// FieldName: TOTM
		/// FieldType: N
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("To time")]
		public int? M3TOTM => GetNullableInt("TOTM");

		/// <summary>
		/// Description: Break
		/// FieldName: BRCD
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Break")]
		public string M3BRCD => GetString("BRCD");

		/// <summary>
		/// Description: Ref field 0-2 allowed
		/// FieldName: REF4
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Ref field 0-2 allowed")]
		public int? M3REF4 => GetNullableInt("REF4");

		/// <summary>
		/// Description: Work hour definition
		/// FieldName: WTCD
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Work hour definition")]
		public string M3WTCD => GetString("WTCD");

		/// <summary>
		/// Description: Work hours per day
		/// FieldName: WTDY
		/// FieldType: N
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Work hours per day")]
		public int? M3WTDY => GetNullableInt("WTDY");
	}
}
// EOF
