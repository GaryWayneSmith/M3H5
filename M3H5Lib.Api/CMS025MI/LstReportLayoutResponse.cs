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

namespace M3H5Lib.Api.CMS025MI
{
	public partial class LstReportLayoutResponse : M3BaseRecord 
	{

		/// <summary>
		/// Description: Printer file
		/// FieldName: PRTF
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Printer file")]
		public string M3_PRTF => GetString("PRTF");

		/// <summary>
		/// Description: Report layout
		/// FieldName: RLAY
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Report layout")]
		public string M3_RLAY => GetString("RLAY");

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
		/// Description: XML structure
		/// FieldName: RPLY
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("XML structure")]
		public string M3_RPLY => GetString("RPLY");

		/// <summary>
		/// Description: Display update panel
		/// FieldName: DUCO
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Display update panel")]
		public int? M3_DUCO => GetNullableInt("DUCO");

		/// <summary>
		/// Description: External ID
		/// FieldName: PDOC
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("External ID")]
		public string M3_PDOC => GetString("PDOC");

		/// <summary>
		/// Description: Cover information
		/// FieldName: COVR
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Cover information")]
		public int? M3_COVR => GetNullableInt("COVR");

		/// <summary>
		/// Description: Formatting information
		/// FieldName: FOIN
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Formatting information")]
		public int? M3_FOIN => GetNullableInt("FOIN");

		/// <summary>
		/// Description: Label information
		/// FieldName: LAIN
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Label information")]
		public int? M3_LAIN => GetNullableInt("LAIN");

		/// <summary>
		/// Description: Media information
		/// FieldName: MEIN
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Media information")]
		public int? M3_MEIN => GetNullableInt("MEIN");

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
