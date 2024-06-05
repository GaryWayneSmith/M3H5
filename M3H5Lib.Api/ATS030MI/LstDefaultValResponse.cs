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

namespace M3H5Lib.Api.ATS030MI
{
	public partial class LstDefaultValResponse : M3BaseRecord 
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
		/// Description: Priority
		/// FieldName: PREX
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Priority")]
		public string M3PREX => GetString("PREX");

		/// <summary>
		/// Description: Attribute type
		/// FieldName: ATVC
		/// FieldType: A
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Attribute type")]
		public string M3ATVC => GetString("ATVC");

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
		/// Description: Default value
		/// FieldName: DEVA
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Default value")]
		public string M3DEVA => GetString("DEVA");

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
		/// Description: Field
		/// FieldName: OBJC
		/// FieldType: A
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Field")]
		public string M3OBJC => GetString("OBJC");

		/// <summary>
		/// Description: Formula
		/// FieldName: FMID
		/// FieldType: A
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Formula")]
		public string M3FMID => GetString("FMID");

		/// <summary>
		/// Description: Formula result identity
		/// FieldName: FORI
		/// FieldType: A
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Formula result identity")]
		public string M3FORI => GetString("FORI");

		/// <summary>
		/// Description: Attribute value range - from percentage
		/// FieldName: AVRP
		/// FieldType: N
		/// Length: 7
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Attribute value range - from percentage")]
		public int? M3AVRP => GetNullableInt("AVRP");

		/// <summary>
		/// Description: Attribute value range - to percentage
		/// FieldName: ATRP
		/// FieldType: N
		/// Length: 7
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Attribute value range - to percentage")]
		public int? M3ATRP => GetNullableInt("ATRP");

		/// <summary>
		/// Description: Attribute range value - from
		/// FieldName: AVRV
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Attribute range value - from")]
		public decimal? M3AVRV => GetNullableDecimal("AVRV");

		/// <summary>
		/// Description: Attribute value range -  to value
		/// FieldName: ATRV
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Attribute value range -  to value")]
		public decimal? M3ATRV => GetNullableDecimal("ATRV");

		/// <summary>
		/// Description: From formula result identity
		/// FieldName: AFRF
		/// FieldType: A
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("From formula result identity")]
		public string M3AFRF => GetString("AFRF");

		/// <summary>
		/// Description: To formula result identity
		/// FieldName: ATRF
		/// FieldType: A
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("To formula result identity")]
		public string M3ATRF => GetString("ATRF");

		/// <summary>
		/// Description: Inheritance
		/// FieldName: INHC
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Inheritance")]
		public int? M3INHC => GetNullableInt("INHC");

		/// <summary>
		/// Description: Item attribute
		/// FieldName: IATT
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Item attribute")]
		public int? M3IATT => GetNullableInt("IATT");
	}
}
// EOF
