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

namespace M3H5Lib.Api.CRS990MI
{
	public partial class InitBrowseResponse : M3BaseRecord 
	{

		/// <summary>
		/// Description: Field
		/// FieldName: FLDI
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Field")]
		public string M3_FLDI => GetString("FLDI");

		/// <summary>
		/// Description: Start position for field column
		/// FieldName: FLDC
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Start position for field column")]
		public string M3_FLDC => GetString("FLDC");

		/// <summary>
		/// Description: Field length
		/// FieldName: FLDB
		/// FieldType: N
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Field length")]
		public int? M3_FLDB => GetNullableInt("FLDB");

		/// <summary>
		/// Description: Justify right or left
		/// FieldName: FLDJ
		/// FieldType: A
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Justify right or left")]
		public string M3_FLDJ => GetString("FLDJ");

		/// <summary>
		/// Description: Key field
		/// FieldName: KEYI
		/// FieldType: A
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Key field")]
		public string M3_KEYI => GetString("KEYI");

		/// <summary>
		/// Description: Key position
		/// FieldName: KEYP
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Key position")]
		public string M3_KEYP => GetString("KEYP");

		/// <summary>
		/// Description: General word
		/// FieldName: MSI5
		/// FieldType: A
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("General word")]
		public string M3_MSI5 => GetString("MSI5");

		/// <summary>
		/// Description: Message text
		/// FieldName: MS15
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Message text")]
		public string M3_MS15 => GetString("MS15");

		/// <summary>
		/// Description: Message text
		/// FieldName: MS40
		/// FieldType: A
		/// Length: 40
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Message text")]
		public string M3_MS40 => GetString("MS40");

		/// <summary>
		/// Description: Description
		/// FieldName: MSC0
		/// FieldType: A
		/// Length: 40
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Description")]
		public string M3_MSC0 => GetString("MSC0");
	}
}
// EOF
