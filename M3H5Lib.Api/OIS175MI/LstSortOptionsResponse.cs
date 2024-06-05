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

namespace M3H5Lib.Api.OIS175MI
{
	public partial class LstSortOptionsResponse : M3BaseRecord 
	{

		/// <summary>
		/// Description: Description
		/// FieldName: TX40
		/// FieldType: A
		/// Length: 40
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Description")]
		public string M3TX40 => GetString("TX40");

		/// <summary>
		/// Description: Sorting option
		/// FieldName: SOPT
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Sorting option")]
		public string M3SOPT => GetString("SOPT");

		/// <summary>
		/// Description: Key 1 - intranet statistics
		/// FieldName: KEY1
		/// FieldType: A
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Key 1 - intranet statistics")]
		public string M3KEY1 => GetString("KEY1");

		/// <summary>
		/// Description: Key 1 - description
		/// FieldName: TXK1
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Key 1 - description")]
		public string M3TXK1 => GetString("TXK1");

		/// <summary>
		/// Description: Key 2 - intranet statistics
		/// FieldName: KEY2
		/// FieldType: A
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Key 2 - intranet statistics")]
		public string M3KEY2 => GetString("KEY2");

		/// <summary>
		/// Description: Key 2 - description
		/// FieldName: TXK2
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Key 2 - description")]
		public string M3TXK2 => GetString("TXK2");

		/// <summary>
		/// Description: Key 3 - intranet statistics
		/// FieldName: KEY3
		/// FieldType: A
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Key 3 - intranet statistics")]
		public string M3KEY3 => GetString("KEY3");

		/// <summary>
		/// Description: Key 3 - description
		/// FieldName: TXK3
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Key 3 - description")]
		public string M3TXK3 => GetString("TXK3");

		/// <summary>
		/// Description: Key 4 - intranet statistics
		/// FieldName: KEY4
		/// FieldType: A
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Key 4 - intranet statistics")]
		public string M3KEY4 => GetString("KEY4");

		/// <summary>
		/// Description: Key 4 - description
		/// FieldName: TXK4
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Key 4 - description")]
		public string M3TXK4 => GetString("TXK4");

		/// <summary>
		/// Description: Key 5 - intranet statistics
		/// FieldName: KEY5
		/// FieldType: A
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Key 5 - intranet statistics")]
		public string M3KEY5 => GetString("KEY5");

		/// <summary>
		/// Description: Key 5 - description
		/// FieldName: TXK5
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Key 5 - description")]
		public string M3TXK5 => GetString("TXK5");
	}
}
// EOF
