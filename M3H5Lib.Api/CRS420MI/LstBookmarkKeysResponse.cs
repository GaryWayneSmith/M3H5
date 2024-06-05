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

namespace M3H5Lib.Api.CRS420MI
{
	public partial class LstBookmarkKeysResponse : M3BaseRecord 
	{

		/// <summary>
		/// Description: Mail
		/// FieldName: MLID
		/// FieldType: N
		/// Length: 13
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Mail")]
		public decimal? M3MLID => GetNullableDecimal("MLID");

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
		/// Description: Data identity reference
		/// FieldName: DTRF
		/// FieldType: N
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Data identity reference")]
		public int? M3DTRF => GetNullableInt("DTRF");

		/// <summary>
		/// Description: Data identity subnumber
		/// FieldName: DTIS
		/// FieldType: N
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Data identity subnumber")]
		public int? M3DTIS => GetNullableInt("DTIS");

		/// <summary>
		/// Description: Table
		/// FieldName: FILE
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Table")]
		public string M3FILE => GetString("FILE");

		/// <summary>
		/// Description: Keystring
		/// FieldName: KSTR
		/// FieldType: A
		/// Length: 480
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Keystring")]
		public string M3KSTR => GetString("KSTR");
	}
}
// EOF
