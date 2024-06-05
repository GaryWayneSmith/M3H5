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

namespace M3H5Lib.Api.APS050MI
{
	public partial class GetBatchHeadPreResponse : M3BaseRecord 
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
		/// Description: Payee
		/// FieldName: SPYN
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Payee")]
		public string M3SPYN => GetString("SPYN");

		/// <summary>
		/// Description: Supplier number
		/// FieldName: SUNO
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Supplier number")]
		public string M3SUNO => GetString("SUNO");

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
		/// Description: Type of automatically generated invoice
		/// FieldName: BITP
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Type of automatically generated invoice")]
		public string M3BITP => GetString("BITP");

		/// <summary>
		/// Description: Invoice matching
		/// FieldName: IMCD
		/// FieldType: A
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Invoice matching")]
		public string M3IMCD => GetString("IMCD");

		/// <summary>
		/// Description: EAN location code supplier
		/// FieldName: EALS
		/// FieldType: A
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("EAN location code supplier")]
		public string M3EALS => GetString("EALS");

		/// <summary>
		/// Description: VAT registration number
		/// FieldName: VRNO
		/// FieldType: A
		/// Length: 16
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("VAT registration number")]
		public string M3VRNO => GetString("VRNO");

		/// <summary>
		/// Description: EAN location code payee
		/// FieldName: EALP
		/// FieldType: A
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("EAN location code payee")]
		public string M3EALP => GetString("EALP");

		/// <summary>
		/// Description: EAN location code consignee
		/// FieldName: EALR
		/// FieldType: A
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("EAN location code consignee")]
		public string M3EALR => GetString("EALR");

		/// <summary>
		/// Description: Invoice date
		/// FieldName: IVDT
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Invoice date")]
		public DateTime? M3IVDT => GetNullableDateTime("IVDT");

		/// <summary>
		/// Description: Due date
		/// FieldName: DUDT
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Due date")]
		public DateTime? M3DUDT => GetNullableDateTime("DUDT");

		/// <summary>
		/// Description: Information type
		/// FieldName: IVTP
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Information type")]
		public string M3IVTP => GetString("IVTP");

		/// <summary>
		/// Description: Document code
		/// FieldName: DNCO
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Document code")]
		public string M3DNCO => GetString("DNCO");

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
		/// Description: Currency description
		/// FieldName: CUCT
		/// FieldType: A
		/// Length: 40
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Currency description")]
		public string M3CUCT => GetString("CUCT");

		/// <summary>
		/// Description: Foreign currency amount
		/// FieldName: CUAM
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Foreign currency amount")]
		public decimal? M3CUAM => GetNullableDecimal("CUAM");

		/// <summary>
		/// Description: Total line amount - net
		/// FieldName: TLNA
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Total line amount - net")]
		public decimal? M3TLNA => GetNullableDecimal("TLNA");

		/// <summary>
		/// Description: Discount base amount
		/// FieldName: TASD
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Discount base amount")]
		public decimal? M3TASD => GetNullableDecimal("TASD");

		/// <summary>
		/// Description: Total taxable amount
		/// FieldName: TTXA
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Total taxable amount")]
		public decimal? M3TTXA => GetNullableDecimal("TTXA");

		/// <summary>
		/// Description: Total charges
		/// FieldName: TCHG
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Total charges")]
		public decimal? M3TCHG => GetNullableDecimal("TCHG");

		/// <summary>
		/// Description: Total due
		/// FieldName: TOPA
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Total due")]
		public decimal? M3TOPA => GetNullableDecimal("TOPA");

		/// <summary>
		/// Description: Prepaid amount
		/// FieldName: PRPA
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Prepaid amount")]
		public decimal? M3PRPA => GetNullableDecimal("PRPA");

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
		/// Description: Cash discount term description
		/// FieldName: TECT
		/// FieldType: A
		/// Length: 40
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Cash discount term description")]
		public string M3TECT => GetString("TECT");

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
		/// FieldName: CDP1
		/// FieldType: N
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Cash discount percentage")]
		public int? M3CDP1 => GetNullableInt("CDP1");

		/// <summary>
		/// Description: Cash discount amount 1
		/// FieldName: CDC1
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Cash discount amount 1")]
		public decimal? M3CDC1 => GetNullableDecimal("CDC1");

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
		/// Description: Cash discount percentage 2
		/// FieldName: CDP2
		/// FieldType: N
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Cash discount percentage 2")]
		public int? M3CDP2 => GetNullableInt("CDP2");

		/// <summary>
		/// Description: Cash discount amount 2
		/// FieldName: CDC2
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Cash discount amount 2")]
		public decimal? M3CDC2 => GetNullableDecimal("CDC2");

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
		/// Description: Cash discount percentage 3
		/// FieldName: CDP3
		/// FieldType: N
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Cash discount percentage 3")]
		public int? M3CDP3 => GetNullableInt("CDP3");

		/// <summary>
		/// Description: Cash discount amount 3
		/// FieldName: CDC3
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Cash discount amount 3")]
		public decimal? M3CDC3 => GetNullableDecimal("CDC3");

		/// <summary>
		/// Description: Payment method - accounts payable
		/// FieldName: PYME
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Payment method - accounts payable")]
		public string M3PYME => GetString("PYME");

		/// <summary>
		/// Description: Payment method description
		/// FieldName: PYMT
		/// FieldType: A
		/// Length: 40
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Payment method description")]
		public string M3PYMT => GetString("PYMT");

		/// <summary>
		/// Description: Payment terms
		/// FieldName: TEPY
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Payment terms")]
		public string M3TEPY => GetString("TEPY");

		/// <summary>
		/// Description: Payment terms description
		/// FieldName: TEPT
		/// FieldType: A
		/// Length: 40
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Payment terms description")]
		public string M3TEPT => GetString("TEPT");

		/// <summary>
		/// Description: Exchange rate
		/// FieldName: ARAT
		/// FieldType: N
		/// Length: 12
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Exchange rate")]
		public decimal? M3ARAT => GetNullableDecimal("ARAT");

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
		/// Description: Order date
		/// FieldName: PUDT
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Order date")]
		public DateTime? M3PUDT => GetNullableDateTime("PUDT");

		/// <summary>
		/// Description: Future rate agreement number
		/// FieldName: FECN
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Future rate agreement number")]
		public string M3FECN => GetString("FECN");

		/// <summary>
		/// Description: Service code
		/// FieldName: SERS
		/// FieldType: N
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Service code")]
		public int? M3SERS => GetNullableInt("SERS");

		/// <summary>
		/// Description: Service code description
		/// FieldName: SERT
		/// FieldType: A
		/// Length: 40
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Service code description")]
		public string M3SERT => GetString("SERT");

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
		/// Description: Accounting date
		/// FieldName: ACDT
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Accounting date")]
		public DateTime? M3ACDT => GetNullableDateTime("ACDT");

		/// <summary>
		/// Description: Status - batch invoice
		/// FieldName: BIST
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Status - batch invoice")]
		public int? M3BIST => GetNullableInt("BIST");

		/// <summary>
		/// Description: Status - invoice
		/// FieldName: INST
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Status - invoice")]
		public string M3INST => GetString("INST");

		/// <summary>
		/// Description: Invoice per receiving number
		/// FieldName: UPBI
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Invoice per receiving number")]
		public int? M3UPBI => GetNullableInt("UPBI");

		/// <summary>
		/// Description: Supplier acceptance
		/// FieldName: SUAC
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Supplier acceptance")]
		public int? M3SUAC => GetNullableInt("SUAC");

		/// <summary>
		/// Description: Conditions for adding lines
		/// FieldName: SBAD
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Conditions for adding lines")]
		public int? M3SBAD => GetNullableInt("SBAD");

		/// <summary>
		/// Description: Our invoicing address
		/// FieldName: PYAD
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Our invoicing address")]
		public string M3PYAD => GetString("PYAD");

		/// <summary>
		/// Description: Authorized
		/// FieldName: APCD
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Authorized")]
		public string M3APCD => GetString("APCD");

		/// <summary>
		/// Description: AP standard document
		/// FieldName: SDAP
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("AP standard document")]
		public string M3SDAP => GetString("SDAP");

		/// <summary>
		/// Description: Debit note reason
		/// FieldName: DNRE
		/// FieldType: A
		/// Length: 8
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Debit note reason")]
		public string M3DNRE => GetString("DNRE");

		/// <summary>
		/// Description: Debit note reason description
		/// FieldName: DNRT
		/// FieldType: A
		/// Length: 40
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Debit note reason description")]
		public string M3DNRT => GetString("DNRT");

		/// <summary>
		/// Description: Base country code
		/// FieldName: BSCD
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Base country code")]
		public string M3BSCD => GetString("BSCD");

		/// <summary>
		/// Description: From/To country
		/// FieldName: FTCO
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("From/To country")]
		public string M3FTCO => GetString("FTCO");

		/// <summary>
		/// Description: Trade code
		/// FieldName: TDCD
		/// FieldType: A
		/// Length: 4
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Trade code")]
		public string M3TDCD => GetString("TDCD");

		/// <summary>
		/// Description: Tax applicable
		/// FieldName: TXAP
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Tax applicable")]
		public int? M3TXAP => GetNullableInt("TXAP");

		/// <summary>
		/// Description: VAT summation method
		/// FieldName: VDME
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("VAT summation method")]
		public int? M3VDME => GetNullableInt("VDME");

		/// <summary>
		/// Description: Purchase order number
		/// FieldName: PUNO
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Purchase order number")]
		public string M3PUNO => GetString("PUNO");

		/// <summary>
		/// Description: Authorized description
		/// FieldName: APCT
		/// FieldType: A
		/// Length: 40
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Authorized description")]
		public string M3APCT => GetString("APCT");

		/// <summary>
		/// Description: Delivery date
		/// FieldName: DEDA
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Delivery date")]
		public DateTime? M3DEDA => GetNullableDateTime("DEDA");

		/// <summary>
		/// Description: Reference number
		/// FieldName: PPYR
		/// FieldType: A
		/// Length: 45
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Reference number")]
		public string M3PPYR => GetString("PPYR");

		/// <summary>
		/// Description: Payment request  number
		/// FieldName: PPYN
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Payment request  number")]
		public string M3PPYN => GetString("PPYN");

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
	}
}
// EOF
