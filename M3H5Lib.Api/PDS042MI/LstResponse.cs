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

namespace M3H5Lib.Api.PDS042MI
{
	public partial class LstResponse : M3BaseRecord 
	{

		/// <summary>
		/// Description: Result identity
		/// FieldName: RSIY
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Result identity")]
		public string M3_RSIY => GetString("RSIY");

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
		/// Description: Result type
		/// FieldName: RSTE
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Result type")]
		public int? M3_RSTE => GetNullableInt("RSTE");

		/// <summary>
		/// Description: Number of decimal places
		/// FieldName: DCCD
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Number of decimal places")]
		public int? M3_DCCD => GetNullableInt("DCCD");

		/// <summary>
		/// Description: Expected value
		/// FieldName: EVAL
		/// FieldType: A
		/// Length: 12
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Expected value")]
		public string M3_EVAL => GetString("EVAL");

		/// <summary>
		/// Description: Operator
		/// FieldName: OPE1
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Operator")]
		public string M3_OPE1 => GetString("OPE1");

		/// <summary>
		/// Description: Range value
		/// FieldName: RBFR
		/// FieldType: A
		/// Length: 12
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Range value")]
		public string M3_RBFR => GetString("RBFR");

		/// <summary>
		/// Description: Operator
		/// FieldName: OPE2
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Operator")]
		public string M3_OPE2 => GetString("OPE2");

		/// <summary>
		/// Description: Range value
		/// FieldName: RBTO
		/// FieldType: A
		/// Length: 12
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Range value")]
		public string M3_RBTO => GetString("RBTO");

		/// <summary>
		/// Description: Operator
		/// FieldName: OPE3
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Operator")]
		public string M3_OPE3 => GetString("OPE3");

		/// <summary>
		/// Description: External limit
		/// FieldName: EAFR
		/// FieldType: A
		/// Length: 12
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("External limit")]
		public string M3_EAFR => GetString("EAFR");

		/// <summary>
		/// Description: Operator
		/// FieldName: OPE4
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Operator")]
		public string M3_OPE4 => GetString("OPE4");

		/// <summary>
		/// Description: External limit
		/// FieldName: EATO
		/// FieldType: A
		/// Length: 12
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("External limit")]
		public string M3_EATO => GetString("EATO");

		/// <summary>
		/// Description: Operator
		/// FieldName: OPE5
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Operator")]
		public string M3_OPE5 => GetString("OPE5");

		/// <summary>
		/// Description: Alarm limit
		/// FieldName: AAFR
		/// FieldType: A
		/// Length: 12
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Alarm limit")]
		public string M3_AAFR => GetString("AAFR");

		/// <summary>
		/// Description: Operator
		/// FieldName: OPE6
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Operator")]
		public string M3_OPE6 => GetString("OPE6");

		/// <summary>
		/// Description: Alarm limit
		/// FieldName: AATO
		/// FieldType: A
		/// Length: 12
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Alarm limit")]
		public string M3_AATO => GetString("AATO");

		/// <summary>
		/// Description: Operator
		/// FieldName: OPE7
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Operator")]
		public string M3_OPE7 => GetString("OPE7");

		/// <summary>
		/// Description: Trend limit
		/// FieldName: AATR
		/// FieldType: A
		/// Length: 12
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Trend limit")]
		public string M3_AATR => GetString("AATR");

		/// <summary>
		/// Description: Text identity
		/// FieldName: TXID
		/// FieldType: N
		/// Length: 13
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Text identity")]
		public decimal? M3_TXID => GetNullableDecimal("TXID");
	}
}
// EOF
