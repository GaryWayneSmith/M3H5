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

namespace M3H5Lib.Api.APS200MI
{
	public partial class GetCashDiscInfoResponse : M3BaseRecord 
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
		/// Description: Journal number
		/// FieldName: JRNO
		/// FieldType: N
		/// Length: 7
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Journal number")]
		public int? M3JRNO => GetNullableInt("JRNO");

		/// <summary>
		/// Description: Journal sequence number
		/// FieldName: JSNO
		/// FieldType: N
		/// Length: 7
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Journal sequence number")]
		public int? M3JSNO => GetNullableInt("JSNO");

		/// <summary>
		/// Description: Voucher number series
		/// FieldName: VSER
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Voucher number series")]
		public string M3VSER => GetString("VSER");

		/// <summary>
		/// Description: Voucher number
		/// FieldName: VONO
		/// FieldType: N
		/// Length: 8
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Voucher number")]
		public int? M3VONO => GetNullableInt("VONO");

		/// <summary>
		/// Description: Supplier invoice number
		/// FieldName: SINO
		/// FieldType: A
		/// Length: 24
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Supplier invoice number")]
		public string M3SINO => GetString("SINO");

		/// <summary>
		/// Description: Cash discount term
		/// FieldName: TECD
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Cash discount term")]
		public string M3TECD => GetString("TECD");

		/// <summary>
		/// Description: Cash discount - foreign currency
		/// FieldName: CDAM
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Cash discount - foreign currency")]
		public decimal? M3CDAM => GetNullableDecimal("CDAM");

		/// <summary>
		/// Description: Cash discount - local currency (converted from CDAM)
		/// FieldName: LDAM
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Cash discount - local currency (converted from CDAM)")]
		public decimal? M3LDAM => GetNullableDecimal("LDAM");

		/// <summary>
		/// Description: Cash discount percentage
		/// FieldName: CDP1
		/// FieldType: N
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Cash discount percentage")]
		public int? M3CDP1 => GetNullableInt("CDP1");

		/// <summary>
		/// Description: Cash discount date 1
		/// FieldName: CDT1
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Cash discount date 1")]
		public DateTime? M3CDT1 => GetNullableDateTime("CDT1");

		/// <summary>
		/// Description: Cash discount percentage
		/// FieldName: CDP2
		/// FieldType: N
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Cash discount percentage")]
		public int? M3CDP2 => GetNullableInt("CDP2");

		/// <summary>
		/// Description: Cash discount date 2
		/// FieldName: CDT2
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Cash discount date 2")]
		public DateTime? M3CDT2 => GetNullableDateTime("CDT2");

		/// <summary>
		/// Description: Cash discount percentage
		/// FieldName: CDP3
		/// FieldType: N
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Cash discount percentage")]
		public int? M3CDP3 => GetNullableInt("CDP3");

		/// <summary>
		/// Description: Cash discount date 3
		/// FieldName: CDT3
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Cash discount date 3")]
		public DateTime? M3CDT3 => GetNullableDateTime("CDT3");

		/// <summary>
		/// Description: Split code
		/// FieldName: SPLT
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Split code")]
		public int? M3SPLT => GetNullableInt("SPLT");

		/// <summary>
		/// Description: Currency
		/// FieldName: CUCD
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Currency")]
		public string M3CUCD => GetString("CUCD");

		/// <summary>
		/// Description: Exchange rate type
		/// FieldName: CRTP
		/// FieldType: N
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Exchange rate type")]
		public int? M3CRTP => GetNullableInt("CRTP");

		/// <summary>
		/// Description: Exchange rate
		/// FieldName: ARAT
		/// FieldType: N
		/// Length: 13
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Exchange rate")]
		public decimal? M3ARAT => GetNullableDecimal("ARAT");

		/// <summary>
		/// Description: Local currency
		/// FieldName: LOCD
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Local currency")]
		public string M3LOCD => GetString("LOCD");

		/// <summary>
		/// Description: Cash discount amount 1 - foreign currency
		/// FieldName: CDA1
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Cash discount amount 1 - foreign currency")]
		public decimal? M3CDA1 => GetNullableDecimal("CDA1");

		/// <summary>
		/// Description: Cash discount amount 2 - foreign currency
		/// FieldName: CDA2
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Cash discount amount 2 - foreign currency")]
		public decimal? M3CDA2 => GetNullableDecimal("CDA2");

		/// <summary>
		/// Description: Cash discount amount 3 - foreign currency
		/// FieldName: CDA3
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Cash discount amount 3 - foreign currency")]
		public decimal? M3CDA3 => GetNullableDecimal("CDA3");

		/// <summary>
		/// Description: Cash discount amount 1- local currency
		/// FieldName: LDA1
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Cash discount amount 1- local currency")]
		public decimal? M3LDA1 => GetNullableDecimal("LDA1");

		/// <summary>
		/// Description: Cash discount amount 2 - local currency
		/// FieldName: LDA2
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Cash discount amount 2 - local currency")]
		public decimal? M3LDA2 => GetNullableDecimal("LDA2");

		/// <summary>
		/// Description: Cash discount amount 3 - local currency
		/// FieldName: LDA3
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Cash discount amount 3 - local currency")]
		public decimal? M3LDA3 => GetNullableDecimal("LDA3");
	}
}
// EOF
