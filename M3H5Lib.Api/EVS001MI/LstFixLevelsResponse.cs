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

namespace M3H5Lib.Api.EVS001MI
{
	public partial class LstFixLevelsResponse : M3BaseRecord 
	{

		/// <summary>
		/// Description: Fix level, Jira action number
		/// FieldName: FIXL
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Fix level, Jira action number")]
		public string M3FIXL => GetString("FIXL");

		/// <summary>
		/// Description: Entry date
		/// FieldName: DATE
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Entry date")]
		public DateTime? M3DATE => GetNullableDateTime("DATE");

		/// <summary>
		/// Description: User
		/// FieldName: USER
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("User")]
		public string M3USER => GetString("USER");

		/// <summary>
		/// Description: Fix description
		/// FieldName: TEXT
		/// FieldType: A
		/// Length: 200
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Fix description")]
		public string M3TEXT => GetString("TEXT");
	}
}
// EOF
