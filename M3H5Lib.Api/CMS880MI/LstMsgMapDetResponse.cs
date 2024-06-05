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

namespace M3H5Lib.Api.CMS880MI
{
	public partial class LstMsgMapDetResponse : M3BaseRecord 
	{

		/// <summary>
		/// Description: Business message
		/// FieldName: BMSG
		/// FieldType: A
		/// Length: 20
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Business message")]
		public string M3BMSG => GetString("BMSG");

		/// <summary>
		/// Description: Parent element(s)
		/// FieldName: ELMP
		/// FieldType: A
		/// Length: 30
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Parent element(s)")]
		public string M3ELMP => GetString("ELMP");

		/// <summary>
		/// Description: Data element
		/// FieldName: ELMD
		/// FieldType: A
		/// Length: 30
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Data element")]
		public string M3ELMD => GetString("ELMD");

		/// <summary>
		/// Description: Base country
		/// FieldName: BSCD
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Base country")]
		public string M3BSCD => GetString("BSCD");

		/// <summary>
		/// Description: M3 Field
		/// FieldName: MBFL
		/// FieldType: A
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("M3 Field")]
		public string M3MBFL => GetString("MBFL");

		/// <summary>
		/// Description: M3 value From
		/// FieldName: MVLF
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("M3 value From")]
		public string M3MVLF => GetString("MVLF");

		/// <summary>
		/// Description: M3 value To
		/// FieldName: MVLT
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("M3 value To")]
		public string M3MVLT => GetString("MVLT");

		/// <summary>
		/// Description: Data element value
		/// FieldName: DELV
		/// FieldType: A
		/// Length: 35
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Data element value")]
		public string M3DELV => GetString("DELV");
	}
}
// EOF
