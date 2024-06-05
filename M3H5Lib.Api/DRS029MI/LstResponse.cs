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

namespace M3H5Lib.Api.DRS029MI
{
	public partial class LstResponse : M3BaseRecord 
	{

		/// <summary>
		/// Description: Transport indicator ID
		/// FieldName: TRFI
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Transport indicator ID")]
		public string M3_TRFI => GetString("TRFI");

		/// <summary>
		/// Description: Description
		/// FieldName: TX40
		/// FieldType: A
		/// Length: 40
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Description")]
		public string M3_TX40 => GetString("TX40");

		/// <summary>
		/// Description: Name
		/// FieldName: TX15
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Name")]
		public string M3_TX15 => GetString("TX15");

		/// <summary>
		/// Description: Default indicator
		/// FieldName: DFLT
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Default indicator")]
		public int? M3_DFLT => GetNullableInt("DFLT");

		/// <summary>
		/// Description: Transportation delivery stop
		/// FieldName: TIIC
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Transportation delivery stop")]
		public int? M3_TIIC => GetNullableInt("TIIC");

		/// <summary>
		/// Description: Text identity
		/// FieldName: TXID
		/// FieldType: N
		/// Length: 13
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Text identity")]
		public decimal? M3_TXID => GetNullableDecimal("TXID");
	}
}
// EOF
