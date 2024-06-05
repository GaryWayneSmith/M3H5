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

namespace M3H5Lib.Api.DRS100MI
{
	public partial class GetLoadingStatResponse : M3BaseRecord 
	{

		/// <summary>
		/// Description: Number of loaded pick lines
		/// FieldName: NBLL
		/// FieldType: N
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Number of loaded pick lines")]
		public int? M3NBLL => GetNullableInt("NBLL");

		/// <summary>
		/// Description: Number of pick lines
		/// FieldName: NBPL
		/// FieldType: N
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Number of pick lines")]
		public int? M3NBPL => GetNullableInt("NBPL");

		/// <summary>
		/// Description: Number of loaded packages
		/// FieldName: NBLP
		/// FieldType: N
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Number of loaded packages")]
		public int? M3NBLP => GetNullableInt("NBLP");

		/// <summary>
		/// Description: Number of packages
		/// FieldName: NBRP
		/// FieldType: N
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Number of packages")]
		public int? M3NBRP => GetNullableInt("NBRP");
	}
}
// EOF
