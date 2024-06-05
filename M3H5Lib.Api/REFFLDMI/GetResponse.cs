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

namespace M3H5Lib.Api.REFFLDMI
{
	public partial class GetResponse : M3BaseRecord 
	{

		/// <summary>
		/// Description: Field type
		/// FieldName: TYPE
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Field type")]
		public string M3_TYPE => GetString("TYPE");

		/// <summary>
		/// Description: Category
		/// FieldName: CTGY
		/// FieldType: A
		/// Length: 20
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Category")]
		public string M3_CTGY => GetString("CTGY");

		/// <summary>
		/// Description: Base category
		/// FieldName: BCTG
		/// FieldType: A
		/// Length: 20
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Base category")]
		public string M3_BCTG => GetString("BCTG");

		/// <summary>
		/// Description: Length
		/// FieldName: LNTH
		/// FieldType: N
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Length")]
		public int? M3_LNTH => GetNullableInt("LNTH");

		/// <summary>
		/// Description: Number of decimal places
		/// FieldName: DCCD
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Number of decimal places")]
		public int? M3_DCCD => GetNullableInt("DCCD");

		/// <summary>
		/// Description: Field heading
		/// FieldName: FLHD
		/// FieldType: A
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Field heading")]
		public string M3_FLHD => GetString("FLHD");

		/// <summary>
		/// Description: Language file prefix for field heading
		/// FieldName: LNF1
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Language file prefix for field heading")]
		public string M3_LNF1 => GetString("LNF1");

		/// <summary>
		/// Description: Field help
		/// FieldName: HELP
		/// FieldType: A
		/// Length: 8
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Field help")]
		public string M3_HELP => GetString("HELP");

		/// <summary>
		/// Description: Language file prefix for field help
		/// FieldName: LNF2
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Language file prefix for field help")]
		public string M3_LNF2 => GetString("LNF2");

		/// <summary>
		/// Description: Additional info length
		/// FieldName: AILN
		/// FieldType: N
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Additional info length")]
		public int? M3_AILN => GetNullableInt("AILN");

		/// <summary>
		/// Description: Additional info short length
		/// FieldName: AISL
		/// FieldType: N
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Additional info short length")]
		public int? M3_AISL => GetNullableInt("AISL");

		/// <summary>
		/// Description: Upper case
		/// FieldName: UCAS
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Upper case")]
		public int? M3_UCAS => GetNullableInt("UCAS");

		/// <summary>
		/// Description: Lower limit
		/// FieldName: LLIM
		/// FieldType: A
		/// Length: 30
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Lower limit")]
		public string M3_LLIM => GetString("LLIM");

		/// <summary>
		/// Description: Decimals for lower limit
		/// FieldName: LDCM
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Decimals for lower limit")]
		public int? M3_LDCM => GetNullableInt("LDCM");

		/// <summary>
		/// Description: Upper limit
		/// FieldName: ULIM
		/// FieldType: A
		/// Length: 30
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Upper limit")]
		public string M3_ULIM => GetString("ULIM");

		/// <summary>
		/// Description: Decimals for upper limit
		/// FieldName: UDCM
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Decimals for upper limit")]
		public int? M3_UDCM => GetNullableInt("UDCM");

		/// <summary>
		/// Description: Value map
		/// FieldName: VMAP
		/// FieldType: A
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Value map")]
		public string M3_VMAP => GetString("VMAP");

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
	}
}
// EOF
