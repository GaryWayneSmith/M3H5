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

namespace M3H5Lib.Api.CUSEXTMI
{
	public partial class LstFieldValueResponse : M3BaseRecord 
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
		public string M3FILE => GetString("FILE");

		/// <summary>
		/// Description: Primary key 1
		/// FieldName: PK01
		/// FieldType: A
		/// Length: 30
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Primary key 1")]
		public string M3PK01 => GetString("PK01");

		/// <summary>
		/// Description: Primary key 2
		/// FieldName: PK02
		/// FieldType: A
		/// Length: 30
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Primary key 2")]
		public string M3PK02 => GetString("PK02");

		/// <summary>
		/// Description: Primary key 3
		/// FieldName: PK03
		/// FieldType: A
		/// Length: 30
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Primary key 3")]
		public string M3PK03 => GetString("PK03");

		/// <summary>
		/// Description: Primary key 4
		/// FieldName: PK04
		/// FieldType: A
		/// Length: 30
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Primary key 4")]
		public string M3PK04 => GetString("PK04");

		/// <summary>
		/// Description: Primary key 5
		/// FieldName: PK05
		/// FieldType: A
		/// Length: 30
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Primary key 5")]
		public string M3PK05 => GetString("PK05");

		/// <summary>
		/// Description: Primary key 6
		/// FieldName: PK06
		/// FieldType: A
		/// Length: 30
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Primary key 6")]
		public string M3PK06 => GetString("PK06");

		/// <summary>
		/// Description: Primary key 7
		/// FieldName: PK07
		/// FieldType: A
		/// Length: 30
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Primary key 7")]
		public string M3PK07 => GetString("PK07");

		/// <summary>
		/// Description: Primary key 8
		/// FieldName: PK08
		/// FieldType: A
		/// Length: 30
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Primary key 8")]
		public string M3PK08 => GetString("PK08");

		/// <summary>
		/// Description: Alpha field 30 positions
		/// FieldName: A030
		/// FieldType: A
		/// Length: 30
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Alpha field 30 positions")]
		public string M3A030 => GetString("A030");

		/// <summary>
		/// Description: Alpha field 30 positions
		/// FieldName: A130
		/// FieldType: A
		/// Length: 30
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Alpha field 30 positions")]
		public string M3A130 => GetString("A130");

		/// <summary>
		/// Description: Alpha field 30 positions
		/// FieldName: A230
		/// FieldType: A
		/// Length: 30
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Alpha field 30 positions")]
		public string M3A230 => GetString("A230");

		/// <summary>
		/// Description: Alpha field 30 positions
		/// FieldName: A330
		/// FieldType: A
		/// Length: 30
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Alpha field 30 positions")]
		public string M3A330 => GetString("A330");

		/// <summary>
		/// Description: Alpha field 30 positions
		/// FieldName: A430
		/// FieldType: A
		/// Length: 30
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Alpha field 30 positions")]
		public string M3A430 => GetString("A430");

		/// <summary>
		/// Description: Alpha field 30 positions
		/// FieldName: A530
		/// FieldType: A
		/// Length: 30
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Alpha field 30 positions")]
		public string M3A530 => GetString("A530");

		/// <summary>
		/// Description: Alpha field 30 positions
		/// FieldName: A630
		/// FieldType: A
		/// Length: 30
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Alpha field 30 positions")]
		public string M3A630 => GetString("A630");

		/// <summary>
		/// Description: Alpha field 30 positions
		/// FieldName: A730
		/// FieldType: A
		/// Length: 30
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Alpha field 30 positions")]
		public string M3A730 => GetString("A730");

		/// <summary>
		/// Description: Alpha field 30 positions
		/// FieldName: A830
		/// FieldType: A
		/// Length: 30
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Alpha field 30 positions")]
		public string M3A830 => GetString("A830");

		/// <summary>
		/// Description: Alpha field 30 positions
		/// FieldName: A930
		/// FieldType: A
		/// Length: 30
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Alpha field 30 positions")]
		public string M3A930 => GetString("A930");

		/// <summary>
		/// Description: Numeric field 19,6 positions
		/// FieldName: N096
		/// FieldType: N
		/// Length: 21
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Numeric field 19,6 positions")]
		public decimal? M3N096 => GetNullableDecimal("N096");

		/// <summary>
		/// Description: Numeric field 19,6 positions
		/// FieldName: N196
		/// FieldType: N
		/// Length: 21
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Numeric field 19,6 positions")]
		public decimal? M3N196 => GetNullableDecimal("N196");

		/// <summary>
		/// Description: Numeric field 19,6 positions
		/// FieldName: N296
		/// FieldType: N
		/// Length: 21
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Numeric field 19,6 positions")]
		public decimal? M3N296 => GetNullableDecimal("N296");

		/// <summary>
		/// Description: Numeric field 19,6 positions
		/// FieldName: N396
		/// FieldType: N
		/// Length: 21
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Numeric field 19,6 positions")]
		public decimal? M3N396 => GetNullableDecimal("N396");

		/// <summary>
		/// Description: Numeric field 19,6 positions
		/// FieldName: N496
		/// FieldType: N
		/// Length: 21
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Numeric field 19,6 positions")]
		public decimal? M3N496 => GetNullableDecimal("N496");

		/// <summary>
		/// Description: Numeric field 19,6 positions
		/// FieldName: N596
		/// FieldType: N
		/// Length: 21
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Numeric field 19,6 positions")]
		public decimal? M3N596 => GetNullableDecimal("N596");

		/// <summary>
		/// Description: Numeric field 19,6 positions
		/// FieldName: N696
		/// FieldType: N
		/// Length: 21
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Numeric field 19,6 positions")]
		public decimal? M3N696 => GetNullableDecimal("N696");

		/// <summary>
		/// Description: Numeric field 19,6 positions
		/// FieldName: N796
		/// FieldType: N
		/// Length: 21
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Numeric field 19,6 positions")]
		public decimal? M3N796 => GetNullableDecimal("N796");

		/// <summary>
		/// Description: Numeric field 19,6 positions
		/// FieldName: N896
		/// FieldType: N
		/// Length: 21
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Numeric field 19,6 positions")]
		public decimal? M3N896 => GetNullableDecimal("N896");

		/// <summary>
		/// Description: Numeric field 19,6 positions
		/// FieldName: N996
		/// FieldType: N
		/// Length: 21
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Numeric field 19,6 positions")]
		public decimal? M3N996 => GetNullableDecimal("N996");

		/// <summary>
		/// Description: Migrated
		/// FieldName: MIGR
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Migrated")]
		public int? M3MIGR => GetNullableInt("MIGR");

		/// <summary>
		/// Description: Timestamp
		/// FieldName: LMTS
		/// FieldType: N
		/// Length: 18
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Timestamp")]
		public decimal? M3LMTS => GetNullableDecimal("LMTS");

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
		/// Description: Data identity
		/// FieldName: DTID
		/// FieldType: N
		/// Length: 13
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Data identity")]
		public decimal? M3DTID => GetNullableDecimal("DTID");

		/// <summary>
		/// Description: Alphanumeric field 120 positions
		/// FieldName: A121
		/// FieldType: A
		/// Length: 120
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Alphanumeric field 120 positions")]
		public string M3A121 => GetString("A121");
	}
}
// EOF
