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

namespace M3H5Lib.Api.MRS001MI
{
	public partial class LstLogicalFilesResponse : M3BaseRecord 
	{

		/// <summary>
		/// Description: Logical file index name
		/// FieldName: FLIX
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Logical file index name")]
		public string M3FLIX => GetString("FLIX");

		/// <summary>
		/// Description: First key field
		/// FieldName: FLD1
		/// FieldType: A
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("First key field")]
		public string M3FLD1 => GetString("FLD1");

		/// <summary>
		/// Description: Second key field
		/// FieldName: FLD2
		/// FieldType: A
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Second key field")]
		public string M3FLD2 => GetString("FLD2");

		/// <summary>
		/// Description: Third key field
		/// FieldName: FLD3
		/// FieldType: A
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Third key field")]
		public string M3FLD3 => GetString("FLD3");

		/// <summary>
		/// Description: Fourth key field
		/// FieldName: FLD4
		/// FieldType: A
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Fourth key field")]
		public string M3FLD4 => GetString("FLD4");

		/// <summary>
		/// Description: Fifth key field
		/// FieldName: FLD5
		/// FieldType: A
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Fifth key field")]
		public string M3FLD5 => GetString("FLD5");

		/// <summary>
		/// Description: Sixth key field
		/// FieldName: FLD6
		/// FieldType: A
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Sixth key field")]
		public string M3FLD6 => GetString("FLD6");

		/// <summary>
		/// Description: Seventh key field
		/// FieldName: FLD7
		/// FieldType: A
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Seventh key field")]
		public string M3FLD7 => GetString("FLD7");

		/// <summary>
		/// Description: Eight key field
		/// FieldName: FLD8
		/// FieldType: A
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Eight key field")]
		public string M3FLD8 => GetString("FLD8");

		/// <summary>
		/// Description: Ninth key field
		/// FieldName: FLD9
		/// FieldType: A
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Ninth key field")]
		public string M3FLD9 => GetString("FLD9");

		/// <summary>
		/// Description: Tenth key field
		/// FieldName: FL10
		/// FieldType: A
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Tenth key field")]
		public string M3FL10 => GetString("FL10");

		/// <summary>
		/// Description: Eleventh key field
		/// FieldName: FL11
		/// FieldType: A
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Eleventh key field")]
		public string M3FL11 => GetString("FL11");

		/// <summary>
		/// Description: Twelfth key field
		/// FieldName: FL12
		/// FieldType: A
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Twelfth key field")]
		public string M3FL12 => GetString("FL12");

		/// <summary>
		/// Description: Thirteenth key field
		/// FieldName: FL13
		/// FieldType: A
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Thirteenth key field")]
		public string M3FL13 => GetString("FL13");

		/// <summary>
		/// Description: Fourteenth key field
		/// FieldName: FL14
		/// FieldType: A
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Fourteenth key field")]
		public string M3FL14 => GetString("FL14");

		/// <summary>
		/// Description: Fifteenth key field
		/// FieldName: FL15
		/// FieldType: A
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Fifteenth key field")]
		public string M3FL15 => GetString("FL15");

		/// <summary>
		/// Description: Sixteenth key field
		/// FieldName: FL16
		/// FieldType: A
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Sixteenth key field")]
		public string M3FL16 => GetString("FL16");
	}
}
// EOF
