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

namespace M3H5Lib.Api.MMS018MI
{
	public partial class ListResponse : M3BaseRecord 
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
		/// Description: Style number
		/// FieldName: STYN
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Style number")]
		public string M3_STYN => GetString("STYN");

		/// <summary>
		/// Description: Name
		/// FieldName: ITDS
		/// FieldType: A
		/// Length: 30
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Name")]
		public string M3_ITDS => GetString("ITDS");

		/// <summary>
		/// Description: Composition
		/// FieldName: XCDE
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Composition")]
		public string M3_XCDE => GetString("XCDE");

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
		/// Description: Composition percentage
		/// FieldName: XCDS
		/// FieldType: N
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Composition percentage")]
		public int? M3_XCDS => GetNullableInt("XCDS");
	}
}
// EOF
