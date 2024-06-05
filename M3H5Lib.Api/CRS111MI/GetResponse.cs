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

namespace M3H5Lib.Api.CRS111MI
{
	public partial class GetResponse : M3BaseRecord 
	{

		/// <summary>
		/// Description: E-mail type
		/// FieldName: EMTP
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("E-mail type")]
		public string M3EMTP => GetString("EMTP");

		/// <summary>
		/// Description: E-mail key value
		/// FieldName: EMKY
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("E-mail key value")]
		public string M3EMKY => GetString("EMKY");

		/// <summary>
		/// Description: Electronic mail address
		/// FieldName: EMAL
		/// FieldType: A
		/// Length: 60
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Electronic mail address")]
		public string M3EMAL => GetString("EMAL");
	}
}
// EOF
