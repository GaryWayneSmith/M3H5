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

namespace M3H5Lib.Api.GTCN10MI
{
	public partial class LstInvDetailsResponse : M3BaseRecord 
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
		/// Description: Division
		/// FieldName: DIVI
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Division")]
		public string M3DIVI => GetString("DIVI");

		/// <summary>
		/// Description: Year
		/// FieldName: YEA4
		/// FieldType: N
		/// Length: 4
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Year")]
		public int? M3YEA4 => GetNullableInt("YEA4");

		/// <summary>
		/// Description: Extended Invoice Number
		/// FieldName: EXIN
		/// FieldType: A
		/// Length: 14
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Extended Invoice Number")]
		public string M3EXIN => GetString("EXIN");

		/// <summary>
		/// Description: Facility
		/// FieldName: FACI
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Facility")]
		public string M3FACI => GetString("FACI");

		/// <summary>
		/// Description: Invoice Prefix
		/// FieldName: INPX
		/// FieldType: A
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Invoice Prefix")]
		public string M3INPX => GetString("INPX");

		/// <summary>
		/// Description: Invoice number
		/// FieldName: IVNO
		/// FieldType: N
		/// Length: 9
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Invoice number")]
		public int? M3IVNO => GetNullableInt("IVNO");

		/// <summary>
		/// Description: Subnumber
		/// FieldName: SBNO
		/// FieldType: N
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Subnumber")]
		public int? M3SBNO => GetNullableInt("SBNO");

		/// <summary>
		/// Description: Invoice type
		/// FieldName: XITP
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Invoice type")]
		public int? M3XITP => GetNullableInt("XITP");

		/// <summary>
		/// Description: Invoice number
		/// FieldName: XGTI
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Invoice number")]
		public string M3XGTI => GetString("XGTI");

		/// <summary>
		/// Description: Invoice amount - local currency
		/// FieldName: IVAM
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Invoice amount - local currency")]
		public decimal? M3IVAM => GetNullableDecimal("IVAM");

		/// <summary>
		/// Description: Invoice amount - local currency
		/// FieldName: IVLA
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Invoice amount - local currency")]
		public decimal? M3IVLA => GetNullableDecimal("IVLA");

		/// <summary>
		/// Description: VAT
		/// FieldName: VTAM
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("VAT")]
		public decimal? M3VTAM => GetNullableDecimal("VTAM");

		/// <summary>
		/// Description: VAT
		/// FieldName: VTLA
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("VAT")]
		public decimal? M3VTLA => GetNullableDecimal("VTLA");

		/// <summary>
		/// Description: Number of lines
		/// FieldName: XINL
		/// FieldType: N
		/// Length: 4
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Number of lines")]
		public int? M3XINL => GetNullableInt("XINL");

		/// <summary>
		/// Description: Line status
		/// FieldName: XLST
		/// FieldType: N
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Line status")]
		public int? M3XLST => GetNullableInt("XLST");

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
		/// Description: Checker
		/// FieldName: XCEK
		/// FieldType: A
		/// Length: 8
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Checker")]
		public string M3XCEK => GetString("XCEK");

		/// <summary>
		/// Description: Comments
		/// FieldName: XCOM
		/// FieldType: A
		/// Length: 160
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Comments")]
		public string M3XCOM => GetString("XCOM");

		/// <summary>
		/// Description: Original Golden Tax Invoice number
		/// FieldName: XOGT
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Original Golden Tax Invoice number")]
		public string M3XOGT => GetString("XOGT");

		/// <summary>
		/// Description: Original transfer date
		/// FieldName: XOTD
		/// FieldType: N
		/// Length: 8
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Original transfer date")]
		public int? M3XOTD => GetNullableInt("XOTD");

		/// <summary>
		/// Description: Reject date
		/// FieldName: XRDT
		/// FieldType: D
		/// Length: 8
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Reject date")]
		public DateTime? M3XRDT => GetNullableDateTime("XRDT");

		/// <summary>
		/// Description: VAT monitor list
		/// FieldName: XVTN
		/// FieldType: A
		/// Length: 20
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("VAT monitor list")]
		public string M3XVTN => GetString("XVTN");

		/// <summary>
		/// Description: Additional invoice number
		/// FieldName: XAIV
		/// FieldType: A
		/// Length: 20
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Additional invoice number")]
		public string M3XAIV => GetString("XAIV");
	}
}
// EOF
