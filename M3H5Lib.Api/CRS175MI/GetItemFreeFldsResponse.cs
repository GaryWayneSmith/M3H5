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

namespace M3H5Lib.Api.CRS175MI
{
	public partial class GetItemFreeFldsResponse : M3BaseRecord 
	{

		/// <summary>
		/// Description: User-defined field 1 - item
		/// FieldName: CFI1
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("User-defined field 1 - item")]
		public string M3CFI1 => GetString("CFI1");

		/// <summary>
		/// Description: User-defined field 2 - item
		/// FieldName: CFI2
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("User-defined field 2 - item")]
		public string M3CFI2 => GetString("CFI2");

		/// <summary>
		/// Description: User-defined field 3 - item
		/// FieldName: CFI3
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("User-defined field 3 - item")]
		public string M3CFI3 => GetString("CFI3");

		/// <summary>
		/// Description: User-defined field 4 - item
		/// FieldName: CFI4
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("User-defined field 4 - item")]
		public string M3CFI4 => GetString("CFI4");

		/// <summary>
		/// Description: User-defined field 5 - item
		/// FieldName: CFI5
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("User-defined field 5 - item")]
		public string M3CFI5 => GetString("CFI5");

		/// <summary>
		/// Description: User-defined field 6 - item
		/// FieldName: CFI6
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("User-defined field 6 - item")]
		public string M3CFI6 => GetString("CFI6");

		/// <summary>
		/// Description: User-defined field 7 - item
		/// FieldName: CFI7
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("User-defined field 7 - item")]
		public string M3CFI7 => GetString("CFI7");

		/// <summary>
		/// Description: User-defined field 8 - item
		/// FieldName: CFI8
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("User-defined field 8 - item")]
		public string M3CFI8 => GetString("CFI8");

		/// <summary>
		/// Description: Weight unit
		/// FieldName: WEUN
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Weight unit")]
		public string M3WEUN => GetString("WEUN");

		/// <summary>
		/// Description: Volume unit
		/// FieldName: VOUN
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Volume unit")]
		public string M3VOUN => GetString("VOUN");

		/// <summary>
		/// Description: Free cap unit
		/// FieldName: FEUN
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Free cap unit")]
		public string M3FEUN => GetString("FEUN");

		/// <summary>
		/// Description: Length unit
		/// FieldName: LEUN
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Length unit")]
		public string M3LEUN => GetString("LEUN");
	}
}
// EOF
