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

namespace M3H5Lib.Api.ATS020MI
{
	public partial class LstAttrValueResponse : M3BaseRecord 
	{

		/// <summary>
		/// Description: Attribute identity
		/// FieldName: ATID
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Attribute identity")]
		public string M3ATID => GetString("ATID");

		/// <summary>
		/// Description: Start value 1
		/// FieldName: OBV1
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Start value 1")]
		public string M3OBV1 => GetString("OBV1");

		/// <summary>
		/// Description: Start value 2
		/// FieldName: OBV2
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Start value 2")]
		public string M3OBV2 => GetString("OBV2");

		/// <summary>
		/// Description: Start value 3
		/// FieldName: OBV3
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Start value 3")]
		public string M3OBV3 => GetString("OBV3");

		/// <summary>
		/// Description: Attribute sequence number
		/// FieldName: ANSQ
		/// FieldType: N
		/// Length: 4
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Attribute sequence number")]
		public int? M3ANSQ => GetNullableInt("ANSQ");

		/// <summary>
		/// Description: From attribute value
		/// FieldName: AALF
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("From attribute value")]
		public string M3AALF => GetString("AALF");

		/// <summary>
		/// Description: To attribute value
		/// FieldName: AALT
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("To attribute value")]
		public string M3AALT => GetString("AALT");

		/// <summary>
		/// Description: Numeric range multiple
		/// FieldName: NRMU
		/// FieldType: N
		/// Length: 11
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Numeric range multiple")]
		public decimal? M3NRMU => GetNullableDecimal("NRMU");

		/// <summary>
		/// Description: Field
		/// FieldName: OBJ1
		/// FieldType: A
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Field")]
		public string M3OBJ1 => GetString("OBJ1");

		/// <summary>
		/// Description: Field
		/// FieldName: OBJ2
		/// FieldType: A
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Field")]
		public string M3OBJ2 => GetString("OBJ2");

		/// <summary>
		/// Description: Field
		/// FieldName: OBJ3
		/// FieldType: A
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Field")]
		public string M3OBJ3 => GetString("OBJ3");

		/// <summary>
		/// Description: Discontinued date
		/// FieldName: DCOD
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Discontinued date")]
		public DateTime? M3DCOD => GetNullableDateTime("DCOD");
	}
}
// EOF
