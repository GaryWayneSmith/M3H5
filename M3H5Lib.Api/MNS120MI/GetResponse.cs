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

namespace M3H5Lib.Api.MNS120MI
{
	public partial class GetResponse : M3BaseRecord 
	{

		/// <summary>
		/// Description: Table
		/// FieldName: FILE
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Table")]
		public string M3_FILE => GetString("FILE");

		/// <summary>
		/// Description: Format
		/// FieldName: RFMT
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Format")]
		public string M3_RFMT => GetString("RFMT");

		/// <summary>
		/// Description: Table type
		/// FieldName: FTYP
		/// FieldType: A
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Table type")]
		public string M3_FTYP => GetString("FTYP");

		/// <summary>
		/// Description: Sequence number
		/// FieldName: SEQ1
		/// FieldType: N
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Sequence number")]
		public int? M3_SEQ1 => GetNullableInt("SEQ1");

		/// <summary>
		/// Description: Reference
		/// FieldName: RFID
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Reference")]
		public string M3_RFID => GetString("RFID");

		/// <summary>
		/// Description: Max key length
		/// FieldName: MXKL
		/// FieldType: N
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Max key length")]
		public int? M3_MXKL => GetNullableInt("MXKL");

		/// <summary>
		/// Description: Max record length
		/// FieldName: MXRL
		/// FieldType: N
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Max record length")]
		public int? M3_MXRL => GetNullableInt("MXRL");

		/// <summary>
		/// Description: Physical file
		/// FieldName: BOFI
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Physical file")]
		public string M3_BOFI => GetString("BOFI");

		/// <summary>
		/// Description: Key field
		/// FieldName: KEY1
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Key field")]
		public string M3_KEY1 => GetString("KEY1");

		/// <summary>
		/// Description: Key field
		/// FieldName: KEY2
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Key field")]
		public string M3_KEY2 => GetString("KEY2");

		/// <summary>
		/// Description: Key field
		/// FieldName: KEY3
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Key field")]
		public string M3_KEY3 => GetString("KEY3");

		/// <summary>
		/// Description: Key field
		/// FieldName: KEY4
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Key field")]
		public string M3_KEY4 => GetString("KEY4");

		/// <summary>
		/// Description: Key field
		/// FieldName: KEY5
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Key field")]
		public string M3_KEY5 => GetString("KEY5");

		/// <summary>
		/// Description: Key field
		/// FieldName: KEY6
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Key field")]
		public string M3_KEY6 => GetString("KEY6");

		/// <summary>
		/// Description: Key field
		/// FieldName: KEY7
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Key field")]
		public string M3_KEY7 => GetString("KEY7");

		/// <summary>
		/// Description: Key field
		/// FieldName: KEY8
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Key field")]
		public string M3_KEY8 => GetString("KEY8");

		/// <summary>
		/// Description: Key field
		/// FieldName: KEY9
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Key field")]
		public string M3_KEY9 => GetString("KEY9");

		/// <summary>
		/// Description: Reference field
		/// FieldName: RFL1
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Reference field")]
		public string M3_RFL1 => GetString("RFL1");

		/// <summary>
		/// Description: Reference field
		/// FieldName: RFL2
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Reference field")]
		public string M3_RFL2 => GetString("RFL2");

		/// <summary>
		/// Description: Reference field
		/// FieldName: RFL3
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Reference field")]
		public string M3_RFL3 => GetString("RFL3");

		/// <summary>
		/// Description: Reference field
		/// FieldName: RFL4
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Reference field")]
		public string M3_RFL4 => GetString("RFL4");

		/// <summary>
		/// Description: Reference field
		/// FieldName: RFL5
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Reference field")]
		public string M3_RFL5 => GetString("RFL5");

		/// <summary>
		/// Description: Reference field
		/// FieldName: RFL6
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Reference field")]
		public string M3_RFL6 => GetString("RFL6");

		/// <summary>
		/// Description: Reference field
		/// FieldName: RFL7
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Reference field")]
		public string M3_RFL7 => GetString("RFL7");

		/// <summary>
		/// Description: Reference field
		/// FieldName: RFL8
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Reference field")]
		public string M3_RFL8 => GetString("RFL8");

		/// <summary>
		/// Description: Reference field
		/// FieldName: RFL9
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Reference field")]
		public string M3_RFL9 => GetString("RFL9");

		/// <summary>
		/// Description: Entry date
		/// FieldName: RGDT
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Entry date")]
		public DateTime? M3_RGDT => GetNullableDateTime("RGDT");

		/// <summary>
		/// Description: Entry time
		/// FieldName: RGTM
		/// FieldType: N
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Entry time")]
		public int? M3_RGTM => GetNullableInt("RGTM");

		/// <summary>
		/// Description: Change date
		/// FieldName: LMDT
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Change date")]
		public DateTime? M3_LMDT => GetNullableDateTime("LMDT");

		/// <summary>
		/// Description: Change number
		/// FieldName: CHNO
		/// FieldType: N
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Change number")]
		public int? M3_CHNO => GetNullableInt("CHNO");

		/// <summary>
		/// Description: Changed by
		/// FieldName: CHID
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Changed by")]
		public string M3_CHID => GetString("CHID");

		/// <summary>
		/// Description: Browse function
		/// FieldName: BPGM
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Browse function")]
		public string M3_BPGM => GetString("BPGM");

		/// <summary>
		/// Description: Archiving function
		/// FieldName: FNAR
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Archiving function")]
		public string M3_FNAR => GetString("FNAR");

		/// <summary>
		/// Description: Mass delete function
		/// FieldName: FNMD
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Mass delete function")]
		public string M3_FNMD => GetString("FNMD");

		/// <summary>
		/// Description: Security function
		/// FieldName: APGM
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Security function")]
		public string M3_APGM => GetString("APGM");

		/// <summary>
		/// Description: Message ID
		/// FieldName: MSID
		/// FieldType: A
		/// Length: 7
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Message ID")]
		public string M3_MSID => GetString("MSID");

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
	}
}
// EOF
