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

namespace M3H5Lib.Api.CRS137MI
{
	public partial class GetGeoCodeResponse : M3BaseRecord 
	{

		/// <summary>
		/// Description: Geographical code
		/// FieldName: GEOC
		/// FieldType: N
		/// Length: 9
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Geographical code")]
		public int? M3_GEOC => GetNullableInt("GEOC");

		/// <summary>
		/// Description: Tax jurisdiction 1
		/// FieldName: TAJ1
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Tax jurisdiction 1")]
		public string M3_TAJ1 => GetString("TAJ1");

		/// <summary>
		/// Description: Tax jurisdiction 2
		/// FieldName: TAJ2
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Tax jurisdiction 2")]
		public string M3_TAJ2 => GetString("TAJ2");

		/// <summary>
		/// Description: Tax jurisdiction 3
		/// FieldName: TAJ3
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Tax jurisdiction 3")]
		public string M3_TAJ3 => GetString("TAJ3");

		/// <summary>
		/// Description: Tax jurisdiction 4
		/// FieldName: TAJ4
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Tax jurisdiction 4")]
		public string M3_TAJ4 => GetString("TAJ4");

		/// <summary>
		/// Description: Tax jurisdiction 5
		/// FieldName: TAJ5
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Tax jurisdiction 5")]
		public string M3_TAJ5 => GetString("TAJ5");
	}
}
// EOF
