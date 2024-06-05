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

namespace M3H5Lib.Api.CRS990MI
{
	public partial class InitBrowseWHeadResponse : M3BaseRecord 
	{

		/// <summary>
		/// Description: Data returned
		/// FieldName: DATR
		/// FieldType: A
		/// Length: 900
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Data returned")]
		public string M3_DATR => GetString("DATR");

		/// <summary>
		/// Description: Start position for field column
		/// FieldName: FLDC
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Start position for field column")]
		public string M3_FLDC => GetString("FLDC");

		/// <summary>
		/// Description: Field length
		/// FieldName: FLDB
		/// FieldType: N
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Field length")]
		public int? M3_FLDB => GetNullableInt("FLDB");
	}
}
// EOF
