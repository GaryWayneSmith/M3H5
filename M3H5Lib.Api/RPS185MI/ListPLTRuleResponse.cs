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

namespace M3H5Lib.Api.RPS185MI
{
	public partial class ListPLTRuleResponse : M3BaseRecord 
	{

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
		/// Description: Start value 4
		/// FieldName: OBV4
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Start value 4")]
		public string M3OBV4 => GetString("OBV4");

		/// <summary>
		/// Description: Start value 5
		/// FieldName: OBV5
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Start value 5")]
		public string M3OBV5 => GetString("OBV5");

		/// <summary>
		/// Description: Sequence number
		/// FieldName: SEQN
		/// FieldType: N
		/// Length: 7
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Sequence number")]
		public int? M3SEQN => GetNullableInt("SEQN");
	}
}
// EOF
