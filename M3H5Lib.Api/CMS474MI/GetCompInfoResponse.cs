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
	public partial class GetCompInfoResponse : M3BaseRecord 
	{

		/// <summary>
		/// Description: Item number
		/// FieldName: ITNO
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Item number")]
		public string M3ITNO => GetString("ITNO");

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
		/// Description: Custom field group
		/// FieldName: CFMG
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Custom field group")]
		public string M3CFMG => GetString("CFMG");

		/// <summary>
		/// Description: Custom field
		/// FieldName: CFMF
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Custom field")]
		public string M3CFMF => GetString("CFMF");

		/// <summary>
		/// Description: Sequence number
		/// FieldName: SQNR
		/// FieldType: N
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Sequence number")]
		public int? M3SQNR => GetNullableInt("SQNR");

		/// <summary>
		/// Description: Custom field - alphanumeric
		/// FieldName: CFMA
		/// FieldType: A
		/// Length: 40
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Custom field - alphanumeric")]
		public string M3CFMA => GetString("CFMA");

		/// <summary>
		/// Description: Custom field - numeric
		/// FieldName: CFMN
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Custom field - numeric")]
		public decimal? M3CFMN => GetNullableDecimal("CFMN");

		/// <summary>
		/// Description: Custom field - date
		/// FieldName: CFMD
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Custom field - date")]
		public DateTime? M3CFMD => GetNullableDateTime("CFMD");
	}
}
// EOF
