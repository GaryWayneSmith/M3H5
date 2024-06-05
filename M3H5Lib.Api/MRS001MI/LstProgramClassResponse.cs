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

namespace M3H5Lib.Api.MRS001MI
{
	public partial class LstProgramClassResponse : M3BaseRecord 
	{

		/// <summary>
		/// Description: Classification
		/// FieldName: MNID
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Classification")]
		public string M3_MNID => GetString("MNID");

		/// <summary>
		/// Description: Associated MI-program
		/// FieldName: MINM
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Associated MI-program")]
		public string M3_MINM => GetString("MINM");

		/// <summary>
		/// Description: Component name
		/// FieldName: OBNM
		/// FieldType: A
		/// Length: 30
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Component name")]
		public string M3_OBNM => GetString("OBNM");

		/// <summary>
		/// Description: Description
		/// FieldName: MIDS
		/// FieldType: A
		/// Length: 60
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Description")]
		public string M3_MIDS => GetString("MIDS");

		/// <summary>
		/// Description: Text ID for leading description
		/// FieldName: TXT1
		/// FieldType: N
		/// Length: 13
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Text ID for leading description")]
		public decimal? M3_TXT1 => GetNullableDecimal("TXT1");

		/// <summary>
		/// Description: Text ID for trailing description
		/// FieldName: TXT2
		/// FieldType: N
		/// Length: 13
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Text ID for trailing description")]
		public decimal? M3_TXT2 => GetNullableDecimal("TXT2");
	}
}
// EOF