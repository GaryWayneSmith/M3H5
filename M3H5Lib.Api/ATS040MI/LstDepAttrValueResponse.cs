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

namespace M3H5Lib.Api.ATS040MI
{
	public partial class LstDepAttrValueResponse : M3BaseRecord 
	{

		/// <summary>
		/// Description: Attribute model
		/// FieldName: ATMO
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Attribute model")]
		public string M3ATMO => GetString("ATMO");

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
		/// Description: Validate Attribute 1
		/// FieldName: VAT1
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Validate Attribute 1")]
		public string M3VAT1 => GetString("VAT1");

		/// <summary>
		/// Description: Validate Attribute 2
		/// FieldName: VAT2
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Validate Attribute 2")]
		public string M3VAT2 => GetString("VAT2");

		/// <summary>
		/// Description: Validate Attribute 3
		/// FieldName: VAT3
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Validate Attribute 3")]
		public string M3VAT3 => GetString("VAT3");

		/// <summary>
		/// Description: Validate Attribute 4
		/// FieldName: VAT4
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Validate Attribute 4")]
		public string M3VAT4 => GetString("VAT4");

		/// <summary>
		/// Description: Result Attribute
		/// FieldName: RAT1
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Result Attribute")]
		public string M3RAT1 => GetString("RAT1");

		/// <summary>
		/// Description: Mandatory attribute
		/// FieldName: MANA
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Mandatory attribute")]
		public int? M3MANA => GetNullableInt("MANA");

		/// <summary>
		/// Description: Validate Attribute  value 1
		/// FieldName: VAV1
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Validate Attribute  value 1")]
		public string M3VAV1 => GetString("VAV1");

		/// <summary>
		/// Description: Validate Attribute  value 2
		/// FieldName: VAV2
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Validate Attribute  value 2")]
		public string M3VAV2 => GetString("VAV2");

		/// <summary>
		/// Description: Validate Attribute  value 3
		/// FieldName: VAV3
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Validate Attribute  value 3")]
		public string M3VAV3 => GetString("VAV3");

		/// <summary>
		/// Description: Validate Attribute  value 4
		/// FieldName: VAV4
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Validate Attribute  value 4")]
		public string M3VAV4 => GetString("VAV4");

		/// <summary>
		/// Description: Result attribute value fr
		/// FieldName: RAVF
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Result attribute value fr")]
		public string M3RAVF => GetString("RAVF");

		/// <summary>
		/// Description: Result attribute value to
		/// FieldName: RAVT
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Result attribute value to")]
		public string M3RAVT => GetString("RAVT");

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
		/// Description: Default value
		/// FieldName: DEFV
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Default value")]
		public int? M3DEFV => GetNullableInt("DEFV");
	}
}
// EOF
