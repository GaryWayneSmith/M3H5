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

namespace M3H5Lib.Api.BOOKMKMI
{
	public partial class LstExtraParamsResponse : M3BaseRecord 
	{

		/// <summary>
		/// Description: Parameter ID
		/// FieldName: PARM
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Parameter ID")]
		public string M3PARM => GetString("PARM");

		/// <summary>
		/// Description: Parameter type
		/// FieldName: TYPE
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Parameter type")]
		public string M3TYPE => GetString("TYPE");

		/// <summary>
		/// Description: Parameter name
		/// FieldName: NAME
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Parameter name")]
		public string M3NAME => GetString("NAME");

		/// <summary>
		/// Description: Parameter description
		/// FieldName: DESC
		/// FieldType: A
		/// Length: 200
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Parameter description")]
		public string M3DESC => GetString("DESC");
	}
}
// EOF
