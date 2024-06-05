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

namespace M3H5Lib.Api.MWS410MI
{
	public partial class LstPackagesResponse : M3BaseRecord 
	{

		/// <summary>
		/// Description: Package number
		/// FieldName: PANR
		/// FieldType: A
		/// Length: 20
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Package number")]
		public string M3_PANR => GetString("PANR");

		/// <summary>
		/// Description: SSCC number
		/// FieldName: SSCC
		/// FieldType: A
		/// Length: 18
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("SSCC number")]
		public string M3_SSCC => GetString("SSCC");

		/// <summary>
		/// Description: Packaging
		/// FieldName: PACT
		/// FieldType: A
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Packaging")]
		public string M3_PACT => GetString("PACT");

		/// <summary>
		/// Description: Number of packages
		/// FieldName: NUPA
		/// FieldType: N
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Number of packages")]
		public int? M3_NUPA => GetNullableInt("NUPA");

		/// <summary>
		/// Description: Packaging code
		/// FieldName: GRTP
		/// FieldType: A
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Packaging code")]
		public string M3_GRTP => GetString("GRTP");

		/// <summary>
		/// Description: Remark
		/// FieldName: DLRM
		/// FieldType: A
		/// Length: 40
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Remark")]
		public string M3_DLRM => GetString("DLRM");

		/// <summary>
		/// Description: Goods mark Odette standard
		/// FieldName: DLMO
		/// FieldType: A
		/// Length: 40
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Goods mark Odette standard")]
		public string M3_DLMO => GetString("DLMO");

		/// <summary>
		/// Description: Package content
		/// FieldName: PCON
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Package content")]
		public int? M3_PCON => GetNullableInt("PCON");
	}
}
// EOF
