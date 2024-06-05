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

namespace M3H5Lib.Api.MMS022MI
{
	public partial class GetSearchGrpSetResponse : M3BaseRecord 
	{

		/// <summary>
		/// Description: Hierarchylevel1
		/// FieldName: DHI1
		/// FieldType: N
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Hierarchylevel1")]
		public int? M3DHI1 => GetNullableInt("DHI1");

		/// <summary>
		/// Description: Hierarchylevel2
		/// FieldName: DHI2
		/// FieldType: N
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Hierarchylevel2")]
		public int? M3DHI2 => GetNullableInt("DHI2");

		/// <summary>
		/// Description: Hierarchylevel3
		/// FieldName: DHI3
		/// FieldType: N
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Hierarchylevel3")]
		public int? M3DHI3 => GetNullableInt("DHI3");

		/// <summary>
		/// Description: Hierarchylevel4
		/// FieldName: DHI4
		/// FieldType: N
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Hierarchylevel4")]
		public int? M3DHI4 => GetNullableInt("DHI4");

		/// <summary>
		/// Description: Hierarchylevel5
		/// FieldName: DHI5
		/// FieldType: N
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Hierarchylevel5")]
		public int? M3DHI5 => GetNullableInt("DHI5");

		/// <summary>
		/// Description: Numberofpositions
		/// FieldName: DHI6
		/// FieldType: N
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Numberofpositions")]
		public int? M3DHI6 => GetNullableInt("DHI6");

		/// <summary>
		/// Description: Useofsearchgroup
		/// FieldName: DHI7
		/// FieldType: N
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Useofsearchgroup")]
		public int? M3DHI7 => GetNullableInt("DHI7");

		/// <summary>
		/// Description: Defaulttext
		/// FieldName: DHI8
		/// FieldType: N
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Defaulttext")]
		public int? M3DHI8 => GetNullableInt("DHI8");
	}
}
// EOF
