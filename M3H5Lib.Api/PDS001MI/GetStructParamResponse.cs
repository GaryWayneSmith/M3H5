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

namespace M3H5Lib.Api.PDS001MI
{
	public partial class GetStructParamResponse : M3BaseRecord 
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
		/// Description: Structure types in use
		/// FieldName: STPU
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Structure types in use")]
		public int? M3STPU => GetNullableInt("STPU");

		/// <summary>
		/// Description: Product structure type - standard
		/// FieldName: STPM
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Product structure type - standard")]
		public string M3STPM => GetString("STPM");

		/// <summary>
		/// Description: Validity dates in use
		/// FieldName: EFDU
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Validity dates in use")]
		public int? M3EFDU => GetNullableInt("EFDU");

		/// <summary>
		/// Description: Phantom operation addition
		/// FieldName: PHOH
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Phantom operation addition")]
		public int? M3PHOH => GetNullableInt("PHOH");

		/// <summary>
		/// Description: Operation range for phantoms
		/// FieldName: PHOI
		/// FieldType: N
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Operation range for phantoms")]
		public int? M3PHOI => GetNullableInt("PHOI");

		/// <summary>
		/// Description: Calculate quantity
		/// FieldName: CALQ
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Calculate quantity")]
		public int? M3CALQ => GetNullableInt("CALQ");

		/// <summary>
		/// Description: Structure type - Critical mtrl/oper
		/// FieldName: STCM
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Structure type - Critical mtrl/oper")]
		public string M3STCM => GetString("STCM");

		/// <summary>
		/// Description: Product structure type for kit
		/// FieldName: STTK
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Product structure type for kit")]
		public string M3STTK => GetString("STTK");

		/// <summary>
		/// Description: Include by-products in lowest level
		/// FieldName: IBYL
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Include by-products in lowest level")]
		public int? M3IBYL => GetNullableInt("IBYL");

		/// <summary>
		/// Description: Structure type used in SCP
		/// FieldName: STSP
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Structure type used in SCP")]
		public string M3STSP => GetString("STSP");

		/// <summary>
		/// Description: Structure type - maintenance
		/// FieldName: STMA
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Structure type - maintenance")]
		public string M3STMA => GetString("STMA");
	}
}
// EOF
