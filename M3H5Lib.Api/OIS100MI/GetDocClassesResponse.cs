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

namespace M3H5Lib.Api.OIS100MI
{
	public partial class GetDocClassesResponse : M3BaseRecord 
	{

		/// <summary>
		/// Description: Document class 1
		/// FieldName: CO01
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Document class 1")]
		public int? M3CO01 => GetNullableInt("CO01");

		/// <summary>
		/// Description: Document class 2
		/// FieldName: CO02
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Document class 2")]
		public int? M3CO02 => GetNullableInt("CO02");

		/// <summary>
		/// Description: Document class 3
		/// FieldName: CO03
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Document class 3")]
		public int? M3CO03 => GetNullableInt("CO03");

		/// <summary>
		/// Description: Document class 4
		/// FieldName: CO04
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Document class 4")]
		public int? M3CO04 => GetNullableInt("CO04");

		/// <summary>
		/// Description: Document class 5
		/// FieldName: CO05
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Document class 5")]
		public int? M3CO05 => GetNullableInt("CO05");
	}
}
// EOF
