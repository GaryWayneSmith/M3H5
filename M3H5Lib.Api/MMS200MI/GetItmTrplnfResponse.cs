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

namespace M3H5Lib.Api.MMS200MI
{
	public partial class GetItmTrplnfResponse : M3BaseRecord 
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
		public string M3_ITNO => GetString("ITNO");

		/// <summary>
		/// Description: UN number
		/// FieldName: UNNN
		/// FieldType: N
		/// Length: 4
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("UN number")]
		public int? M3_UNNN => GetNullableInt("UNNN");

		/// <summary>
		/// Description: NA number
		/// FieldName: NNNN
		/// FieldType: A
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("NA number")]
		public string M3_NNNN => GetString("NNNN");

		/// <summary>
		/// Description: CAS number
		/// FieldName: CASN
		/// FieldType: A
		/// Length: 16
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("CAS number")]
		public string M3_CASN => GetString("CASN");

		/// <summary>
		/// Description: EU number
		/// FieldName: ECNM
		/// FieldType: A
		/// Length: 18
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("EU number")]
		public string M3_ECNM => GetString("ECNM");

		/// <summary>
		/// Description: EINECS number
		/// FieldName: EINM
		/// FieldType: A
		/// Length: 18
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("EINECS number")]
		public string M3_EINM => GetString("EINM");

		/// <summary>
		/// Description: Atomic number
		/// FieldName: ATOM
		/// FieldType: A
		/// Length: 12
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Atomic number")]
		public string M3_ATOM => GetString("ATOM");

		/// <summary>
		/// Description: CEA number
		/// FieldName: CEAN
		/// FieldType: A
		/// Length: 16
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("CEA number")]
		public string M3_CEAN => GetString("CEAN");

		/// <summary>
		/// Description: NAICS code
		/// FieldName: NAIC
		/// FieldType: N
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("NAICS code")]
		public int? M3_NAIC => GetNullableInt("NAIC");

		/// <summary>
		/// Description: Item equipment profile
		/// FieldName: ITEQ
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Item equipment profile")]
		public string M3_ITEQ => GetString("ITEQ");

		/// <summary>
		/// Description: Freight commodity code
		/// FieldName: CMMC
		/// FieldType: A
		/// Length: 9
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Freight commodity code")]
		public string M3_CMMC => GetString("CMMC");

		/// <summary>
		/// Description: Hazardous material
		/// FieldName: HAZM
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Hazardous material")]
		public int? M3_HAZM => GetNullableInt("HAZM");

		/// <summary>
		/// Description: Commodity class
		/// FieldName: CMCL
		/// FieldType: A
		/// Length: 4
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Commodity class")]
		public string M3_CMCL => GetString("CMCL");
	}
}
// EOF
