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

namespace M3H5Lib.Api.MWS410MI
{
	public partial class GetPackageResponse : M3BaseRecord 
	{

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
		/// Description: SSCC number
		/// FieldName: SSCC
		/// FieldType: A
		/// Length: 18
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("SSCC number")]
		public string M3SSCC => GetString("SSCC");

		/// <summary>
		/// Description: Included in package number
		/// FieldName: PAII
		/// FieldType: A
		/// Length: 20
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Included in package number")]
		public string M3PAII => GetString("PAII");

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
		/// Description: Package level
		/// FieldName: PACO
		/// FieldType: N
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Package level")]
		public int? M3PACO => GetNullableInt("PACO");

		/// <summary>
		/// Description: Packaging code
		/// FieldName: GRTP
		/// FieldType: A
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Packaging code")]
		public string M3GRTP => GetString("GRTP");

		/// <summary>
		/// Description: Remark
		/// FieldName: DLRM
		/// FieldType: A
		/// Length: 40
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Remark")]
		public string M3DLRM => GetString("DLRM");

		/// <summary>
		/// Description: Goods mark Odette standard
		/// FieldName: DLMO
		/// FieldType: A
		/// Length: 40
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Goods mark Odette standard")]
		public string M3DLMO => GetString("DLMO");

		/// <summary>
		/// Description: Net weight
		/// FieldName: NEWE
		/// FieldType: N
		/// Length: 11
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Net weight")]
		public decimal? M3NEWE => GetNullableDecimal("NEWE");

		/// <summary>
		/// Description: Gross weight
		/// FieldName: GRWE
		/// FieldType: N
		/// Length: 11
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Gross weight")]
		public decimal? M3GRWE => GetNullableDecimal("GRWE");

		/// <summary>
		/// Description: Volume
		/// FieldName: VOL3
		/// FieldType: N
		/// Length: 11
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Volume")]
		public decimal? M3VOL3 => GetNullableDecimal("VOL3");

		/// <summary>
		/// Description: Packaging length
		/// FieldName: PACL
		/// FieldType: N
		/// Length: 7
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Packaging length")]
		public int? M3PACL => GetNullableInt("PACL");

		/// <summary>
		/// Description: Packaging width
		/// FieldName: PACW
		/// FieldType: N
		/// Length: 7
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Packaging width")]
		public int? M3PACW => GetNullableInt("PACW");

		/// <summary>
		/// Description: Packaging height
		/// FieldName: PACH
		/// FieldType: N
		/// Length: 7
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Packaging height")]
		public int? M3PACH => GetNullableInt("PACH");

		/// <summary>
		/// Description: Content description
		/// FieldName: PCON
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Content description")]
		public int? M3PCON => GetNullableInt("PCON");

		/// <summary>
		/// Description: Kanban Card Number
		/// FieldName: RSKN
		/// FieldType: A
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Kanban Card Number")]
		public string M3RSKN => GetString("RSKN");

		/// <summary>
		/// Description: Loading platform
		/// FieldName: LODO
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Loading platform")]
		public string M3LODO => GetString("LODO");
	}
}
// EOF
