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

namespace M3H5Lib.Api.FACETMI
{
	public partial class LstFacetsResponse : M3BaseRecord 
	{

		/// <summary>
		/// Description: Facet name
		/// FieldName: TX30
		/// FieldType: A
		/// Length: 30
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Facet name")]
		public string M3TX30 => GetString("TX30");

		/// <summary>
		/// Description: Language constant
		/// FieldName: AL07
		/// FieldType: A
		/// Length: 7
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Language constant")]
		public string M3AL07 => GetString("AL07");

		/// <summary>
		/// Description: Field name
		/// FieldName: FLNA
		/// FieldType: A
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Field name")]
		public string M3FLNA => GetString("FLNA");

		/// <summary>
		/// Description: Facet value
		/// FieldName: TX60
		/// FieldType: A
		/// Length: 60
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Facet value")]
		public string M3TX60 => GetString("TX60");

		/// <summary>
		/// Description: Facet count
		/// FieldName: FFN1
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Facet count")]
		public decimal? M3FFN1 => GetNullableDecimal("FFN1");
	}
}
// EOF
