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

namespace M3H5Lib.Api.APS050MI
{
	public partial class LstHeadByPayerPResponse : M3BaseRecord 
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
		public int? M3_CONO => GetNullableInt("CONO");

		/// <summary>
		/// Description: Division
		/// FieldName: DIVI
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Division")]
		public string M3_DIVI => GetString("DIVI");

		/// <summary>
		/// Description: Payee
		/// FieldName: SPYN
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Payee")]
		public string M3_SPYN => GetString("SPYN");

		/// <summary>
		/// Description: Supplier number
		/// FieldName: SUNO
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Supplier number")]
		public string M3_SUNO => GetString("SUNO");

		/// <summary>
		/// Description: Supplier invoice number
		/// FieldName: SINO
		/// FieldType: A
		/// Length: 24
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Supplier invoice number")]
		public string M3_SINO => GetString("SINO");

		/// <summary>
		/// Description: Type of automatically generated invoice
		/// FieldName: BITP
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Type of automatically generated invoice")]
		public string M3_BITP => GetString("BITP");

		/// <summary>
		/// Description: Invoice matching
		/// FieldName: IMCD
		/// FieldType: A
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Invoice matching")]
		public string M3_IMCD => GetString("IMCD");

		/// <summary>
		/// Description: EAN location code supplier
		/// FieldName: EALS
		/// FieldType: A
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("EAN location code supplier")]
		public string M3_EALS => GetString("EALS");

		/// <summary>
		/// Description: VAT registration number
		/// FieldName: VRNO
		/// FieldType: A
		/// Length: 16
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("VAT registration number")]
		public string M3_VRNO => GetString("VRNO");

		/// <summary>
		/// Description: EAN location code payee
		/// FieldName: EALP
		/// FieldType: A
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("EAN location code payee")]
		public string M3_EALP => GetString("EALP");

		/// <summary>
		/// Description: EAN location code consignee
		/// FieldName: EALR
		/// FieldType: A
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("EAN location code consignee")]
		public string M3_EALR => GetString("EALR");

		/// <summary>
		/// Description: Invoice date
		/// FieldName: IVDT
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Invoice date")]
		public DateTime? M3_IVDT => GetNullableDateTime("IVDT");

		/// <summary>
		/// Description: Due date
		/// FieldName: DUDT
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Due date")]
		public DateTime? M3_DUDT => GetNullableDateTime("DUDT");

		/// <summary>
		/// Description: Information type
		/// FieldName: IVTP
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Information type")]
		public string M3_IVTP => GetString("IVTP");

		/// <summary>
		/// Description: Document code
		/// FieldName: DNCO
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Document code")]
		public string M3_DNCO => GetString("DNCO");

		/// <summary>
		/// Description: VAT
		/// FieldName: VTAM
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("VAT")]
		public decimal? M3_VTAM => GetNullableDecimal("VTAM");

		/// <summary>
		/// Description: Currency
		/// FieldName: CUCD
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Currency")]
		public string M3_CUCD => GetString("CUCD");

		/// <summary>
		/// Description: Currency description
		/// FieldName: CUCT
		/// FieldType: A
		/// Length: 40
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Currency description")]
		public string M3_CUCT => GetString("CUCT");

		/// <summary>
		/// Description: Foreign currency amount
		/// FieldName: CUAM
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Foreign currency amount")]
		public decimal? M3_CUAM => GetNullableDecimal("CUAM");

		/// <summary>
		/// Description: Total line amount - net
		/// FieldName: TLNA
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Total line amount - net")]
		public decimal? M3_TLNA => GetNullableDecimal("TLNA");

		/// <summary>
		/// Description: Discount base amount
		/// FieldName: TASD
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Discount base amount")]
		public decimal? M3_TASD => GetNullableDecimal("TASD");

		/// <summary>
		/// Description: Total taxable amount
		/// FieldName: TTXA
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Total taxable amount")]
		public decimal? M3_TTXA => GetNullableDecimal("TTXA");

		/// <summary>
		/// Description: Total charges
		/// FieldName: TCHG
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Total charges")]
		public decimal? M3_TCHG => GetNullableDecimal("TCHG");

		/// <summary>
		/// Description: Total due
		/// FieldName: TOPA
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Total due")]
		public decimal? M3_TOPA => GetNullableDecimal("TOPA");

		/// <summary>
		/// Description: Prepaid amount
		/// FieldName: PRPA
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Prepaid amount")]
		public decimal? M3_PRPA => GetNullableDecimal("PRPA");

		/// <summary>
		/// Description: Cash discount term
		/// FieldName: TECD
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Cash discount term")]
		public string M3_TECD => GetString("TECD");

		/// <summary>
		/// Description: Cash discount term description
		/// FieldName: TECT
		/// FieldType: A
		/// Length: 40
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Cash discount term description")]
		public string M3_TECT => GetString("TECT");

		/// <summary>
		/// Description: Cash discount date 1
		/// FieldName: CDT1
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Cash discount date 1")]
		public DateTime? M3_CDT1 => GetNullableDateTime("CDT1");

		/// <summary>
		/// Description: Cash discount percentage
		/// FieldName: CDP1
		/// FieldType: N
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Cash discount percentage")]
		public int? M3_CDP1 => GetNullableInt("CDP1");

		/// <summary>
		/// Description: Cash discount amount 1
		/// FieldName: CDC1
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Cash discount amount 1")]
		public decimal? M3_CDC1 => GetNullableDecimal("CDC1");

		/// <summary>
		/// Description: Cash discount date 2
		/// FieldName: CDT2
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Cash discount date 2")]
		public DateTime? M3_CDT2 => GetNullableDateTime("CDT2");

		/// <summary>
		/// Description: Cash discount percentage 2
		/// FieldName: CDP2
		/// FieldType: N
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Cash discount percentage 2")]
		public int? M3_CDP2 => GetNullableInt("CDP2");

		/// <summary>
		/// Description: Cash discount amount 2
		/// FieldName: CDC2
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Cash discount amount 2")]
		public decimal? M3_CDC2 => GetNullableDecimal("CDC2");

		/// <summary>
		/// Description: Cash discount date 3
		/// FieldName: CDT3
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Cash discount date 3")]
		public DateTime? M3_CDT3 => GetNullableDateTime("CDT3");

		/// <summary>
		/// Description: Cash discount percentage 3
		/// FieldName: CDP3
		/// FieldType: N
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Cash discount percentage 3")]
		public int? M3_CDP3 => GetNullableInt("CDP3");

		/// <summary>
		/// Description: Cash discount amount 3
		/// FieldName: CDC3
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Cash discount amount 3")]
		public decimal? M3_CDC3 => GetNullableDecimal("CDC3");

		/// <summary>
		/// Description: Payment method - accounts payable
		/// FieldName: PYME
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Payment method - accounts payable")]
		public string M3_PYME => GetString("PYME");

		/// <summary>
		/// Description: Payment method description
		/// FieldName: PYMT
		/// FieldType: A
		/// Length: 40
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Payment method description")]
		public string M3_PYMT => GetString("PYMT");

		/// <summary>
		/// Description: Payment terms
		/// FieldName: TEPY
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Payment terms")]
		public string M3_TEPY => GetString("TEPY");

		/// <summary>
		/// Description: Payment terms description
		/// FieldName: TEPT
		/// FieldType: A
		/// Length: 40
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Payment terms description")]
		public string M3_TEPT => GetString("TEPT");

		/// <summary>
		/// Description: Exchange rate
		/// FieldName: ARAT
		/// FieldType: N
		/// Length: 12
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Exchange rate")]
		public decimal? M3_ARAT => GetNullableDecimal("ARAT");

		/// <summary>
		/// Description: Exchange rate type
		/// FieldName: CRTP
		/// FieldType: N
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Exchange rate type")]
		public int? M3_CRTP => GetNullableInt("CRTP");

		/// <summary>
		/// Description: Order date
		/// FieldName: PUDT
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Order date")]
		public DateTime? M3_PUDT => GetNullableDateTime("PUDT");

		/// <summary>
		/// Description: Future rate agreement number
		/// FieldName: FECN
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Future rate agreement number")]
		public string M3_FECN => GetString("FECN");

		/// <summary>
		/// Description: Service code
		/// FieldName: SERS
		/// FieldType: N
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Service code")]
		public int? M3_SERS => GetNullableInt("SERS");

		/// <summary>
		/// Description: Service code description
		/// FieldName: SERT
		/// FieldType: A
		/// Length: 40
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Service code description")]
		public string M3_SERT => GetString("SERT");

		/// <summary>
		/// Description: Voucher number series
		/// FieldName: VSER
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Voucher number series")]
		public string M3_VSER => GetString("VSER");

		/// <summary>
		/// Description: Voucher number
		/// FieldName: VONO
		/// FieldType: N
		/// Length: 8
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Voucher number")]
		public int? M3_VONO => GetNullableInt("VONO");

		/// <summary>
		/// Description: Accounting date
		/// FieldName: ACDT
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Accounting date")]
		public DateTime? M3_ACDT => GetNullableDateTime("ACDT");

		/// <summary>
		/// Description: Status - batch invoice
		/// FieldName: BIST
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Status - batch invoice")]
		public int? M3_BIST => GetNullableInt("BIST");

		/// <summary>
		/// Description: Status - invoice
		/// FieldName: INST
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Status - invoice")]
		public string M3_INST => GetString("INST");

		/// <summary>
		/// Description: Invoice per receiving number
		/// FieldName: UPBI
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Invoice per receiving number")]
		public int? M3_UPBI => GetNullableInt("UPBI");

		/// <summary>
		/// Description: Supplier acceptance
		/// FieldName: SUAC
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Supplier acceptance")]
		public int? M3_SUAC => GetNullableInt("SUAC");

		/// <summary>
		/// Description: Conditions for adding lines
		/// FieldName: SBAD
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Conditions for adding lines")]
		public int? M3_SBAD => GetNullableInt("SBAD");

		/// <summary>
		/// Description: Our invoicing address
		/// FieldName: PYAD
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Our invoicing address")]
		public string M3_PYAD => GetString("PYAD");

		/// <summary>
		/// Description: Authorized
		/// FieldName: APCD
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Authorized")]
		public string M3_APCD => GetString("APCD");

		/// <summary>
		/// Description: AP standard document
		/// FieldName: SDAP
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("AP standard document")]
		public string M3_SDAP => GetString("SDAP");

		/// <summary>
		/// Description: Debit note reason
		/// FieldName: DNRE
		/// FieldType: A
		/// Length: 8
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Debit note reason")]
		public string M3_DNRE => GetString("DNRE");

		/// <summary>
		/// Description: Debit note reason description
		/// FieldName: DNRT
		/// FieldType: A
		/// Length: 40
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Debit note reason description")]
		public string M3_DNRT => GetString("DNRT");

		/// <summary>
		/// Description: Base country code
		/// FieldName: BSCD
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Base country code")]
		public string M3_BSCD => GetString("BSCD");

		/// <summary>
		/// Description: From/To country
		/// FieldName: FTCO
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("From/To country")]
		public string M3_FTCO => GetString("FTCO");

		/// <summary>
		/// Description: Trade code
		/// FieldName: TDCD
		/// FieldType: A
		/// Length: 4
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Trade code")]
		public string M3_TDCD => GetString("TDCD");

		/// <summary>
		/// Description: Tax applicable
		/// FieldName: TXAP
		/// FieldType: A
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Tax applicable")]
		public string M3_TXAP => GetString("TXAP");

		/// <summary>
		/// Description: VAT summation method
		/// FieldName: VDME
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("VAT summation method")]
		public int? M3_VDME => GetNullableInt("VDME");

		/// <summary>
		/// Description: Purchase order number
		/// FieldName: PUNO
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Purchase order number")]
		public string M3_PUNO => GetString("PUNO");

		/// <summary>
		/// Description: Authorized description
		/// FieldName: APCT
		/// FieldType: A
		/// Length: 40
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Authorized description")]
		public string M3_APCT => GetString("APCT");

		/// <summary>
		/// Description: Delivery date
		/// FieldName: DEDA
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Delivery date")]
		public DateTime? M3_DEDA => GetNullableDateTime("DEDA");

		/// <summary>
		/// Description: Reference number
		/// FieldName: PPYR
		/// FieldType: A
		/// Length: 45
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Reference number")]
		public string M3_PPYR => GetString("PPYR");

		/// <summary>
		/// Description: Payment request  number
		/// FieldName: PPYN
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Payment request  number")]
		public string M3_PPYN => GetString("PPYN");

		/// <summary>
		/// Description: Year
		/// FieldName: YEA4
		/// FieldType: N
		/// Length: 4
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Year")]
		public int? M3_YEA4 => GetNullableInt("YEA4");
	}
}
// EOF
