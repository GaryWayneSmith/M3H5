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

namespace M3H5Lib.Api.CMS009MI
{
	public partial class GetXmlAttributeResponse : M3BaseRecord 
	{

		/// <summary>
		/// Description: Attribute name
		/// FieldName: ATN1
		/// FieldType: A
		/// Length: 70
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Attribute name")]
		public string M3ATN1 => GetString("ATN1");

		/// <summary>
		/// Description: Source of data
		/// FieldName: BDA1
		/// FieldType: N
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Source of data")]
		public int? M3BDA1 => GetNullableInt("BDA1");

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
		/// Description: Specific value
		/// FieldName: SPV1
		/// FieldType: A
		/// Length: 100
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Specific value")]
		public string M3SPV1 => GetString("SPV1");
	}
}
// EOF
