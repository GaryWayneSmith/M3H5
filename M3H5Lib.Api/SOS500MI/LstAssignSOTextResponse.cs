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

namespace M3H5Lib.Api.SOS500MI
{
	public partial class LstAssignSOTextResponse : M3BaseRecord 
	{

		/// <summary>
		/// Description: Error symptom
		/// FieldName: ESCO
		/// FieldType: A
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Error symptom")]
		public string M3ESCO => GetString("ESCO");

		/// <summary>
		/// Description: Error symptom text
		/// FieldName: ETX1
		/// FieldType: A
		/// Length: 60
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Error symptom text")]
		public string M3ETX1 => GetString("ETX1");

		/// <summary>
		/// Description: Error symptom text
		/// FieldName: ETX2
		/// FieldType: A
		/// Length: 60
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Error symptom text")]
		public string M3ETX2 => GetString("ETX2");

		/// <summary>
		/// Description: Error symptom text
		/// FieldName: ETX3
		/// FieldType: A
		/// Length: 60
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Error symptom text")]
		public string M3ETX3 => GetString("ETX3");

		/// <summary>
		/// Description: Error symptom text
		/// FieldName: ETX4
		/// FieldType: A
		/// Length: 60
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Error symptom text")]
		public string M3ETX4 => GetString("ETX4");

		/// <summary>
		/// Description: Action text
		/// FieldName: MTCO
		/// FieldType: A
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Action text")]
		public string M3MTCO => GetString("MTCO");

		/// <summary>
		/// Description: Text
		/// FieldName: MTX1
		/// FieldType: A
		/// Length: 60
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Text")]
		public string M3MTX1 => GetString("MTX1");

		/// <summary>
		/// Description: Text
		/// FieldName: MTX2
		/// FieldType: A
		/// Length: 60
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Text")]
		public string M3MTX2 => GetString("MTX2");

		/// <summary>
		/// Description: Text
		/// FieldName: MTX3
		/// FieldType: A
		/// Length: 60
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Text")]
		public string M3MTX3 => GetString("MTX3");

		/// <summary>
		/// Description: Text
		/// FieldName: MTX4
		/// FieldType: A
		/// Length: 60
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Text")]
		public string M3MTX4 => GetString("MTX4");
	}
}
// EOF
