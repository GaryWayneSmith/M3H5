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

namespace M3H5Lib.Api.CRS175MI
{
	public partial class GetGeneralCodeResponse : M3BaseRecord 
	{

		/// <summary>
		/// Description: Constant value
		/// FieldName: STCO
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Constant value")]
		public string M3_STCO => GetString("STCO");

		/// <summary>
		/// Description: Key value for code
		/// FieldName: STKY
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Key value for code")]
		public string M3_STKY => GetString("STKY");

		/// <summary>
		/// Description: Name
		/// FieldName: TX15
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Name")]
		public string M3_TX15 => GetString("TX15");

		/// <summary>
		/// Description: Description
		/// FieldName: TX40
		/// FieldType: A
		/// Length: 40
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Description")]
		public string M3_TX40 => GetString("TX40");

		/// <summary>
		/// Description: Parameter value
		/// FieldName: PARM
		/// FieldType: A
		/// Length: 200
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Parameter value")]
		public string M3_PARM => GetString("PARM");

		/// <summary>
		/// Description: Language specific name
		/// FieldName: LT15
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Language specific name")]
		public string M3_LT15 => GetString("LT15");

		/// <summary>
		/// Description: Language specific description
		/// FieldName: LT60
		/// FieldType: A
		/// Length: 60
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Language specific description")]
		public string M3_LT60 => GetString("LT60");
	}
}
// EOF
