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

namespace M3H5Lib.Api.OIS345MI
{
	public partial class GetSelSimFieldsResponse : M3BaseRecord 
	{

		/// <summary>
		/// Description: Selected price simulation field 1
		/// FieldName: SPS1
		/// FieldType: A
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Selected price simulation field 1")]
		public string M3_SPS1 => GetString("SPS1");

		/// <summary>
		/// Description: Description
		/// FieldName: DES1
		/// FieldType: A
		/// Length: 40
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Description")]
		public string M3_DES1 => GetString("DES1");

		/// <summary>
		/// Description: Selected price simulation field 2
		/// FieldName: SPS2
		/// FieldType: A
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Selected price simulation field 2")]
		public string M3_SPS2 => GetString("SPS2");

		/// <summary>
		/// Description: Description
		/// FieldName: DES2
		/// FieldType: A
		/// Length: 40
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Description")]
		public string M3_DES2 => GetString("DES2");

		/// <summary>
		/// Description: Selected price simulation field 3
		/// FieldName: SPS3
		/// FieldType: A
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Selected price simulation field 3")]
		public string M3_SPS3 => GetString("SPS3");

		/// <summary>
		/// Description: Description
		/// FieldName: DES3
		/// FieldType: A
		/// Length: 40
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Description")]
		public string M3_DES3 => GetString("DES3");

		/// <summary>
		/// Description: Selected price simulation field 4
		/// FieldName: SPS4
		/// FieldType: A
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Selected price simulation field 4")]
		public string M3_SPS4 => GetString("SPS4");

		/// <summary>
		/// Description: Description
		/// FieldName: DES4
		/// FieldType: A
		/// Length: 40
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Description")]
		public string M3_DES4 => GetString("DES4");

		/// <summary>
		/// Description: Selected price simulation field 5
		/// FieldName: SPS5
		/// FieldType: A
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Selected price simulation field 5")]
		public string M3_SPS5 => GetString("SPS5");

		/// <summary>
		/// Description: Description
		/// FieldName: DES5
		/// FieldType: A
		/// Length: 40
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Description")]
		public string M3_DES5 => GetString("DES5");

		/// <summary>
		/// Description: Selected price simulation field 6
		/// FieldName: SPS6
		/// FieldType: A
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Selected price simulation field 6")]
		public string M3_SPS6 => GetString("SPS6");

		/// <summary>
		/// Description: Description
		/// FieldName: DES6
		/// FieldType: A
		/// Length: 40
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Description")]
		public string M3_DES6 => GetString("DES6");
	}
}
// EOF
