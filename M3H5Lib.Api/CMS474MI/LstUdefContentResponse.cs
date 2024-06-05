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

namespace M3H5Lib.Api.CMS474MI
{
	public partial class LstUdefContentResponse : M3BaseRecord 
	{

		/// <summary>
		/// Description: Data identity
		/// FieldName: DTID
		/// FieldType: N
		/// Length: 13
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Data identity")]
		public decimal? M3DTID => GetNullableDecimal("DTID");

		/// <summary>
		/// Description: Field group
		/// FieldName: CFMG
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Field group")]
		public string M3CFMG => GetString("CFMG");

		/// <summary>
		/// Description: Field
		/// FieldName: CFMF
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Field")]
		public string M3CFMF => GetString("CFMF");

		/// <summary>
		/// Description: Field alpha
		/// FieldName: CFMA
		/// FieldType: A
		/// Length: 40
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Field alpha")]
		public string M3CFMA => GetString("CFMA");

		/// <summary>
		/// Description: Field num
		/// FieldName: CFMN
		/// FieldType: N
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Field num")]
		public decimal? M3CFMN => GetNullableDecimal("CFMN");

		/// <summary>
		/// Description: Field date
		/// FieldName: CFMD
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Field date")]
		public DateTime? M3CFMD => GetNullableDateTime("CFMD");
	}
}
// EOF
