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

namespace M3H5Lib.Api.MNS150MI
{
	public partial class SelUsersResponse : M3BaseRecord 
	{

		/// <summary>
		/// Description: Company
		/// FieldName: CONO
		/// FieldType: N
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Company")]
		public int? M3_CONO => GetNullableInt("CONO");

		/// <summary>
		/// Description: Division
		/// FieldName: DIVI
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Division")]
		public string M3_DIVI => GetString("DIVI");

		/// <summary>
		/// Description: Responsible (User)
		/// FieldName: RESP
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Responsible (User)")]
		public string M3_RESP => GetString("RESP");

		/// <summary>
		/// Description: User name
		/// FieldName: RENM
		/// FieldType: A
		/// Length: 36
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("User name")]
		public string M3_RENM => GetString("RENM");

		/// <summary>
		/// Description: Date format
		/// FieldName: DTFM
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Date format")]
		public string M3_DTFM => GetString("DTFM");

		/// <summary>
		/// Description: System language
		/// FieldName: LANC
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("System language")]
		public string M3_LANC => GetString("LANC");

		/// <summary>
		/// Description: User group - object access
		/// FieldName: USIG
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("User group - object access")]
		public string M3_USIG => GetString("USIG");

		/// <summary>
		/// Description: Equipment alias search sequense
		/// FieldName: EQAL
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Equipment alias search sequense")]
		public string M3_EQAL => GetString("EQAL");

		/// <summary>
		/// Description: User status
		/// FieldName: USTA
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("User status")]
		public string M3_USTA => GetString("USTA");

		/// <summary>
		/// Description: Free field 1
		/// FieldName: FRF6
		/// FieldType: A
		/// Length: 30
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Free field 1")]
		public string M3_FRF6 => GetString("FRF6");

		/// <summary>
		/// Description: Free field 2
		/// FieldName: FRF7
		/// FieldType: A
		/// Length: 30
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Free field 2")]
		public string M3_FRF7 => GetString("FRF7");

		/// <summary>
		/// Description: Free field 3
		/// FieldName: FRF8
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Free field 3")]
		public decimal? M3_FRF8 => GetNullableDecimal("FRF8");
	}
}
// EOF
