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

namespace M3H5Lib.Api.CRS230MI
{
	public partial class LstDocEffectResponse : M3BaseRecord 
	{

		/// <summary>
		/// Description: Document identity
		/// FieldName: DOID
		/// FieldType: A
		/// Length: 20
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Document identity")]
		public string M3DOID => GetString("DOID");

		/// <summary>
		/// Description: Document effectivity 1
		/// FieldName: DSQ1
		/// FieldType: N
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Document effectivity 1")]
		public int? M3DSQ1 => GetNullableInt("DSQ1");

		/// <summary>
		/// Description: Document effectivity 2
		/// FieldName: DSQ2
		/// FieldType: N
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Document effectivity 2")]
		public int? M3DSQ2 => GetNullableInt("DSQ2");

		/// <summary>
		/// Description: Document effectivity 3
		/// FieldName: DSQ3
		/// FieldType: N
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Document effectivity 3")]
		public int? M3DSQ3 => GetNullableInt("DSQ3");

		/// <summary>
		/// Description: Not valid
		/// FieldName: DNOT
		/// FieldType: A
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Not valid")]
		public string M3DNOT => GetString("DNOT");

		/// <summary>
		/// Description: Value 1
		/// FieldName: DVA1
		/// FieldType: A
		/// Length: 30
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Value 1")]
		public string M3DVA1 => GetString("DVA1");

		/// <summary>
		/// Description: Value 2
		/// FieldName: DVA2
		/// FieldType: A
		/// Length: 30
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Value 2")]
		public string M3DVA2 => GetString("DVA2");

		/// <summary>
		/// Description: Condition
		/// FieldName: DRAN
		/// FieldType: A
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Condition")]
		public string M3DRAN => GetString("DRAN");

		/// <summary>
		/// Description: Field
		/// FieldName: FLDI
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Field")]
		public string M3FLDI => GetString("FLDI");

		/// <summary>
		/// Description: Number of levels
		/// FieldName: DNLV
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Number of levels")]
		public int? M3DNLV => GetNullableInt("DNLV");

		/// <summary>
		/// Description: Number of right brackets
		/// FieldName: DNRB
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Number of right brackets")]
		public int? M3DNRB => GetNullableInt("DNRB");

		/// <summary>
		/// Description: Number of left brackets
		/// FieldName: DNLB
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Number of left brackets")]
		public int? M3DNLB => GetNullableInt("DNLB");
	}
}
// EOF
