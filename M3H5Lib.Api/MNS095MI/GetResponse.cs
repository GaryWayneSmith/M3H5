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

namespace M3H5Lib.Api.MNS095MI
{
	public partial class GetResponse : M3BaseRecord 
	{

		/// <summary>
		/// Description: Company
		/// FieldName: CONO
		/// FieldType: N
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Company")]
		public int? M3CONO => GetNullableInt("CONO");

		/// <summary>
		/// Description: Description
		/// FieldName: TX40
		/// FieldType: A
		/// Length: 40
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Description")]
		public string M3TX40 => GetString("TX40");

		/// <summary>
		/// Description: Menu version
		/// FieldName: MNVR
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Menu version")]
		public string M3MNVR => GetString("MNVR");

		/// <summary>
		/// Description: Start menu
		/// FieldName: DFMN
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Start menu")]
		public string M3DFMN => GetString("DFMN");

		/// <summary>
		/// Description: Menu maintenance
		/// FieldName: MNMN
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Menu maintenance")]
		public int? M3MNMN => GetNullableInt("MNMN");

		/// <summary>
		/// Description: Statement number
		/// FieldName: STMN
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Statement number")]
		public string M3STMN => GetString("STMN");

		/// <summary>
		/// Description: Company type
		/// FieldName: CMTP
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Company type")]
		public int? M3CMTP => GetNullableInt("CMTP");

		/// <summary>
		/// Description: Central currency
		/// FieldName: CCUC
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Central currency")]
		public string M3CCUC => GetString("CCUC");

		/// <summary>
		/// Description: Central rate type
		/// FieldName: CCRT
		/// FieldType: N
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Central rate type")]
		public int? M3CCRT => GetNullableInt("CCRT");

		/// <summary>
		/// Description: Database
		/// FieldName: DBAS
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Database")]
		public string M3DBAS => GetString("DBAS");

		/// <summary>
		/// Description: Library 1
		/// FieldName: LIB1
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Library 1")]
		public string M3LIB1 => GetString("LIB1");

		/// <summary>
		/// Description: Library 2
		/// FieldName: LIB2
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Library 2")]
		public string M3LIB2 => GetString("LIB2");

		/// <summary>
		/// Description: Library 3
		/// FieldName: LIB3
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Library 3")]
		public string M3LIB3 => GetString("LIB3");

		/// <summary>
		/// Description: Library 4
		/// FieldName: LIB4
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Library 4")]
		public string M3LIB4 => GetString("LIB4");

		/// <summary>
		/// Description: Library 5
		/// FieldName: LIB5
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Library 5")]
		public string M3LIB5 => GetString("LIB5");

		/// <summary>
		/// Description: Library 6
		/// FieldName: LIB6
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Library 6")]
		public string M3LIB6 => GetString("LIB6");

		/// <summary>
		/// Description: Library 7
		/// FieldName: LIB7
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Library 7")]
		public string M3LIB7 => GetString("LIB7");

		/// <summary>
		/// Description: Library 8
		/// FieldName: LIB8
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Library 8")]
		public string M3LIB8 => GetString("LIB8");

		/// <summary>
		/// Description: Library 9
		/// FieldName: LIB9
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Library 9")]
		public string M3LIB9 => GetString("LIB9");

		/// <summary>
		/// Description: Library 10
		/// FieldName: LIB0
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Library 10")]
		public string M3LIB0 => GetString("LIB0");

		/// <summary>
		/// Description: Text identity
		/// FieldName: TXID
		/// FieldType: N
		/// Length: 13
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Text identity")]
		public decimal? M3TXID => GetNullableDecimal("TXID");

		/// <summary>
		/// Description: Entry date
		/// FieldName: RGDT
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Entry date")]
		public DateTime? M3RGDT => GetNullableDateTime("RGDT");

		/// <summary>
		/// Description: Entry time
		/// FieldName: RGTM
		/// FieldType: N
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Entry time")]
		public int? M3RGTM => GetNullableInt("RGTM");

		/// <summary>
		/// Description: Change date
		/// FieldName: LMDT
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Change date")]
		public DateTime? M3LMDT => GetNullableDateTime("LMDT");

		/// <summary>
		/// Description: Change number
		/// FieldName: CHNO
		/// FieldType: N
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Change number")]
		public int? M3CHNO => GetNullableInt("CHNO");

		/// <summary>
		/// Description: Changed by
		/// FieldName: CHID
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Changed by")]
		public string M3CHID => GetString("CHID");

		/// <summary>
		/// Description: Decimal format
		/// FieldName: DCFM
		/// FieldType: A
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Decimal format")]
		public string M3DCFM => GetString("DCFM");

		/// <summary>
		/// Description: I-SWITCH
		/// FieldName: MXV1
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("I-SWITCH")]
		public string M3MXV1 => GetString("MXV1");
	}
}
// EOF
