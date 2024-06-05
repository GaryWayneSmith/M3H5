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

namespace M3H5Lib.Api.MOS057MI
{
	public partial class GetTextResponse : M3BaseRecord 
	{

		/// <summary>
		/// Description: Reference order category
		/// FieldName: RORC
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Reference order category")]
		public int? M3RORC => GetNullableInt("RORC");

		/// <summary>
		/// Description: Reference order number
		/// FieldName: RORN
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Reference order number")]
		public string M3RORN => GetString("RORN");

		/// <summary>
		/// Description: Reference order line
		/// FieldName: RORL
		/// FieldType: N
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Reference order line")]
		public int? M3RORL => GetNullableInt("RORL");

		/// <summary>
		/// Description: Line suffix
		/// FieldName: RORX
		/// FieldType: N
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Line suffix")]
		public int? M3RORX => GetNullableInt("RORX");

		/// <summary>
		/// Description: Product structure type
		/// FieldName: STRT
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Product structure type")]
		public string M3STRT => GetString("STRT");

		/// <summary>
		/// Description: Service
		/// FieldName: SUFI
		/// FieldType: A
		/// Length: 20
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Service")]
		public string M3SUFI => GetString("SUFI");

		/// <summary>
		/// Description: Sequence number
		/// FieldName: SQNR
		/// FieldType: N
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Sequence number")]
		public int? M3SQNR => GetNullableInt("SQNR");

		/// <summary>
		/// Description: Text identity
		/// FieldName: TXIF
		/// FieldType: N
		/// Length: 13
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Text identity")]
		public decimal? M3TXIF => GetNullableDecimal("TXIF");

		/// <summary>
		/// Description: Text identity
		/// FieldName: TXI1
		/// FieldType: N
		/// Length: 13
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Text identity")]
		public decimal? M3TXI1 => GetNullableDecimal("TXI1");

		/// <summary>
		/// Description: Text-ID 2
		/// FieldName: TXI2
		/// FieldType: N
		/// Length: 13
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Text-ID 2")]
		public decimal? M3TXI2 => GetNullableDecimal("TXI2");

		/// <summary>
		/// Description: Text ID description
		/// FieldName: TXI3
		/// FieldType: N
		/// Length: 13
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Text ID description")]
		public decimal? M3TXI3 => GetNullableDecimal("TXI3");

		/// <summary>
		/// Description: Text identity
		/// FieldName: TXIR
		/// FieldType: N
		/// Length: 13
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Text identity")]
		public decimal? M3TXIR => GetNullableDecimal("TXIR");

		/// <summary>
		/// Description: Text
		/// FieldName: TXL1
		/// FieldType: A
		/// Length: 60
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Text")]
		public string M3TXL1 => GetString("TXL1");

		/// <summary>
		/// Description: Text
		/// FieldName: TXL2
		/// FieldType: A
		/// Length: 60
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Text")]
		public string M3TXL2 => GetString("TXL2");

		/// <summary>
		/// Description: Text
		/// FieldName: TXL3
		/// FieldType: A
		/// Length: 60
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Text")]
		public string M3TXL3 => GetString("TXL3");

		/// <summary>
		/// Description: Text
		/// FieldName: TXL4
		/// FieldType: A
		/// Length: 60
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Text")]
		public string M3TXL4 => GetString("TXL4");

		/// <summary>
		/// Description: Text
		/// FieldName: TXL5
		/// FieldType: A
		/// Length: 60
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Text")]
		public string M3TXL5 => GetString("TXL5");

		/// <summary>
		/// Description: Text
		/// FieldName: TXL6
		/// FieldType: A
		/// Length: 60
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Text")]
		public string M3TXL6 => GetString("TXL6");

		/// <summary>
		/// Description: Text
		/// FieldName: TXL7
		/// FieldType: A
		/// Length: 60
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Text")]
		public string M3TXL7 => GetString("TXL7");

		/// <summary>
		/// Description: Text
		/// FieldName: TXL8
		/// FieldType: A
		/// Length: 60
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Text")]
		public string M3TXL8 => GetString("TXL8");

		/// <summary>
		/// Description: Text
		/// FieldName: TXL9
		/// FieldType: A
		/// Length: 60
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Text")]
		public string M3TXL9 => GetString("TXL9");

		/// <summary>
		/// Description: Text
		/// FieldName: TXL0
		/// FieldType: A
		/// Length: 60
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Text")]
		public string M3TXL0 => GetString("TXL0");

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
		/// Description: Change number
		/// FieldName: CHNO
		/// FieldType: N
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Change number")]
		public int? M3CHNO => GetNullableInt("CHNO");
	}
}
// EOF
