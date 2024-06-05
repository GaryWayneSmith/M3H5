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

namespace M3H5Lib.Api.RMS440MI
{
	public partial class GetTickleNoteResponse : M3BaseRecord 
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
		public string M3_TX40 => GetString("TX40");

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
		/// Description: Text line  1
		/// FieldName: TXP1
		/// FieldType: A
		/// Length: 60
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Text line  1")]
		public string M3_TXP1 => GetString("TXP1");

		/// <summary>
		/// Description: Text line  2
		/// FieldName: TXP2
		/// FieldType: A
		/// Length: 60
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Text line  2")]
		public string M3_TXP2 => GetString("TXP2");

		/// <summary>
		/// Description: Text line  3
		/// FieldName: TXP3
		/// FieldType: A
		/// Length: 60
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Text line  3")]
		public string M3_TXP3 => GetString("TXP3");

		/// <summary>
		/// Description: Text line  4
		/// FieldName: TXP4
		/// FieldType: A
		/// Length: 60
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Text line  4")]
		public string M3_TXP4 => GetString("TXP4");

		/// <summary>
		/// Description: Text line  5
		/// FieldName: TXP5
		/// FieldType: A
		/// Length: 60
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Text line  5")]
		public string M3_TXP5 => GetString("TXP5");

		/// <summary>
		/// Description: Text line  6
		/// FieldName: TXP6
		/// FieldType: A
		/// Length: 60
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Text line  6")]
		public string M3_TXP6 => GetString("TXP6");

		/// <summary>
		/// Description: Text line  7
		/// FieldName: TXP7
		/// FieldType: A
		/// Length: 60
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Text line  7")]
		public string M3_TXP7 => GetString("TXP7");

		/// <summary>
		/// Description: Text line  8
		/// FieldName: TXP8
		/// FieldType: A
		/// Length: 60
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Text line  8")]
		public string M3_TXP8 => GetString("TXP8");

		/// <summary>
		/// Description: Text line  9
		/// FieldName: TXP9
		/// FieldType: A
		/// Length: 60
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Text line  9")]
		public string M3_TXP9 => GetString("TXP9");

		/// <summary>
		/// Description: Text line 10
		/// FieldName: TXPA
		/// FieldType: A
		/// Length: 60
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Text line 10")]
		public string M3_TXPA => GetString("TXPA");

		/// <summary>
		/// Description: Registration date
		/// FieldName: REGD
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Registration date")]
		public DateTime? M3_REGD => GetNullableDateTime("REGD");

		/// <summary>
		/// Description: Action date
		/// FieldName: ACTD
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Action date")]
		public DateTime? M3_ACTD => GetNullableDateTime("ACTD");

		/// <summary>
		/// Description: Action status
		/// FieldName: ACSS
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Action status")]
		public int? M3_ACSS => GetNullableInt("ACSS");

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

		/// <summary>
		/// Description: Credit department reference
		/// FieldName: CDRC
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Credit department reference")]
		public string M3_CDRC => GetString("CDRC");

		/// <summary>
		/// Description: Letter type
		/// FieldName: LTTP
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Letter type")]
		public int? M3_LTTP => GetNullableInt("LTTP");

		/// <summary>
		/// Description: Senior credit department manager
		/// FieldName: SCDR
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Senior credit department manager")]
		public string M3_SCDR => GetString("SCDR");

		/// <summary>
		/// Description: User
		/// FieldName: USER
		/// FieldType: A
		/// Length: 40
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("User")]
		public string M3_USER => GetString("USER");

		/// <summary>
		/// Description: Standard letter
		/// FieldName: STLC
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Standard letter")]
		public string M3_STLC => GetString("STLC");
	}
}
// EOF
