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

namespace M3H5Lib.Api.MWS423MI
{
	public partial class RtvLastPkgResponse : M3BaseRecord 
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
		public int? M3CONO => GetNullableInt("CONO");

		/// <summary>
		/// Description: Delivery number
		/// FieldName: DLIX
		/// FieldType: N
		/// Length: 11
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Delivery number")]
		public decimal? M3DLIX => GetNullableDecimal("DLIX");

		/// <summary>
		/// Description: Picking list suffix
		/// FieldName: PLSX
		/// FieldType: N
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Picking list suffix")]
		public int? M3PLSX => GetNullableInt("PLSX");

		/// <summary>
		/// Description: Package number
		/// FieldName: PANR
		/// FieldType: A
		/// Length: 20
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Package number")]
		public string M3PANR => GetString("PANR");

		/// <summary>
		/// Description: Latest time stamp
		/// FieldName: LMTS
		/// FieldType: N
		/// Length: 18
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Latest time stamp")]
		public decimal? M3LMTS => GetNullableDecimal("LMTS");

		/// <summary>
		/// Description: Packaging
		/// FieldName: PACT
		/// FieldType: A
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Packaging")]
		public string M3PACT => GetString("PACT");

		/// <summary>
		/// Description: Packaging name
		/// FieldName: PANM
		/// FieldType: A
		/// Length: 30
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Packaging name")]
		public string M3PANM => GetString("PANM");
	}
}
// EOF
