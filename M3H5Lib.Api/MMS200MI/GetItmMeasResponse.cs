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

namespace M3H5Lib.Api.MMS200MI
{
	public partial class GetItmMeasResponse : M3BaseRecord 
	{

		/// <summary>
		/// Description: UN number
		/// FieldName: UNNN
		/// FieldType: N
		/// Length: 4
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("UN number")]
		public int? M3UNNN => GetNullableInt("UNNN");

		/// <summary>
		/// Description: UN pack code
		/// FieldName: UNPA
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("UN pack code")]
		public string M3UNPA => GetString("UNPA");

		/// <summary>
		/// Description: Danger class 1
		/// FieldName: HAC1
		/// FieldType: A
		/// Length: 4
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Danger class 1")]
		public string M3HAC1 => GetString("HAC1");

		/// <summary>
		/// Description: Danger class 2
		/// FieldName: HAC2
		/// FieldType: A
		/// Length: 4
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Danger class 2")]
		public string M3HAC2 => GetString("HAC2");

		/// <summary>
		/// Description: Danger class 3
		/// FieldName: HAC3
		/// FieldType: A
		/// Length: 4
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Danger class 3")]
		public string M3HAC3 => GetString("HAC3");

		/// <summary>
		/// Description: Measurement 1
		/// FieldName: DIM1
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Measurement 1")]
		public string M3DIM1 => GetString("DIM1");

		/// <summary>
		/// Description: Description 1
		/// FieldName: VAR1
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Description 1")]
		public string M3VAR1 => GetString("VAR1");

		/// <summary>
		/// Description: Measurement 2
		/// FieldName: DIM2
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Measurement 2")]
		public string M3DIM2 => GetString("DIM2");

		/// <summary>
		/// Description: Description 2
		/// FieldName: VAR2
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Description 2")]
		public string M3VAR2 => GetString("VAR2");

		/// <summary>
		/// Description: Measurement 3
		/// FieldName: DIM3
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Measurement 3")]
		public string M3DIM3 => GetString("DIM3");

		/// <summary>
		/// Description: Description 3
		/// FieldName: VAR3
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Description 3")]
		public string M3VAR3 => GetString("VAR3");

		/// <summary>
		/// Description: Specification 1
		/// FieldName: SPE1
		/// FieldType: A
		/// Length: 25
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Specification 1")]
		public string M3SPE1 => GetString("SPE1");

		/// <summary>
		/// Description: Specification 2
		/// FieldName: SPE2
		/// FieldType: A
		/// Length: 25
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Specification 2")]
		public string M3SPE2 => GetString("SPE2");

		/// <summary>
		/// Description: Specification 3
		/// FieldName: SPE3
		/// FieldType: A
		/// Length: 25
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Specification 3")]
		public string M3SPE3 => GetString("SPE3");

		/// <summary>
		/// Description: Specification 4
		/// FieldName: SPE4
		/// FieldType: A
		/// Length: 25
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Specification 4")]
		public string M3SPE4 => GetString("SPE4");

		/// <summary>
		/// Description: Specification 5
		/// FieldName: SPE5
		/// FieldType: A
		/// Length: 25
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Specification 5")]
		public string M3SPE5 => GetString("SPE5");

		/// <summary>
		/// Description: Lot restricted release
		/// FieldName: CETY
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Lot restricted release")]
		public string M3CETY => GetString("CETY");

		/// <summary>
		/// Description: Storage requirements
		/// FieldName: STCN
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Storage requirements")]
		public string M3STCN => GetString("STCN");

		/// <summary>
		/// Description: Storage packaging
		/// FieldName: SPAC
		/// FieldType: A
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Storage packaging")]
		public string M3SPAC => GetString("SPAC");

		/// <summary>
		/// Description: Transportation packaging
		/// FieldName: TRPA
		/// FieldType: A
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Transportation packaging")]
		public string M3TRPA => GetString("TRPA");

		/// <summary>
		/// Description: Manufacturer
		/// FieldName: PROD
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Manufacturer")]
		public string M3PROD => GetString("PROD");

		/// <summary>
		/// Description: Single manufacturer
		/// FieldName: SMFI
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Single manufacturer")]
		public int? M3SMFI => GetNullableInt("SMFI");

		/// <summary>
		/// Description: Bulk item
		/// FieldName: TANK
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Bulk item")]
		public int? M3TANK => GetNullableInt("TANK");

		/// <summary>
		/// Description: Change date
		/// FieldName: LMDT
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Change date")]
		public DateTime? M3LMDT => GetNullableDateTime("LMDT");
	}
}
// EOF
