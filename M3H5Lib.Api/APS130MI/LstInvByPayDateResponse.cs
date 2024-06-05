/// **********************************************************************
/// This class is auto-generated.
/// Updated: 6/5/2024 3:52:20 PM
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

namespace M3H5Lib.Api.APS130MI
{
	public partial class LstInvByPayDateResponse : M3BaseRecord 
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
		/// Description: Payment proposal
		/// FieldName: PRPN
		/// FieldType: N
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Payment proposal")]
		public long? M3PRPN => GetNullableLong("PRPN");

		/// <summary>
		/// Description: Payment order
		/// FieldName: PYON
		/// FieldType: N
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Payment order")]
		public int? M3PYON => GetNullableInt("PYON");

		/// <summary>
		/// Description: Payment document number
		/// FieldName: PDNB
		/// FieldType: N
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Payment document number")]
		public int? M3PDNB => GetNullableInt("PDNB");

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
		/// Description: Supplier customer number
		/// FieldName: SCNO
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Supplier customer number")]
		public string M3SCNO => GetString("SCNO");

		/// <summary>
		/// Description: Original division
		/// FieldName: ODIV
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Original division")]
		public string M3ODIV => GetString("ODIV");

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
		/// Description: Invoice year
		/// FieldName: INYR
		/// FieldType: N
		/// Length: 4
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Invoice year")]
		public int? M3INYR => GetNullableInt("INYR");

		/// <summary>
		/// Description: Bank account identity
		/// FieldName: BKID
		/// FieldType: A
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Bank account identity")]
		public string M3BKID => GetString("BKID");

		/// <summary>
		/// Description: Customer stop
		/// FieldName: BLCD
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Customer stop")]
		public int? M3BLCD => GetNullableInt("BLCD");

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
		/// Description: Follow-up date
		/// FieldName: RVDT
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Follow-up date")]
		public DateTime? M3RVDT => GetNullableDateTime("RVDT");

		/// <summary>
		/// Description: Additional credit days
		/// FieldName: ADCR
		/// FieldType: N
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Additional credit days")]
		public int? M3ADCR => GetNullableInt("ADCR");

		/// <summary>
		/// Description: Adjustment days payment day
		/// FieldName: BDAD
		/// FieldType: N
		/// Length: 4
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Adjustment days payment day")]
		public int? M3BDAD => GetNullableInt("BDAD");

		/// <summary>
		/// Description: Payment date
		/// FieldName: PYDT
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Payment date")]
		public DateTime? M3PYDT => GetNullableDateTime("PYDT");

		/// <summary>
		/// Description: Invoice amount - currency
		/// FieldName: IVCU
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Invoice amount - currency")]
		public decimal? M3IVCU => GetNullableDecimal("IVCU");

		/// <summary>
		/// Description: Invoice amount - foreign currency
		/// FieldName: IVAM
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Invoice amount - foreign currency")]
		public decimal? M3IVAM => GetNullableDecimal("IVAM");

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
		/// Description: Original exchange rate
		/// FieldName: ORAT
		/// FieldType: N
		/// Length: 14
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Original exchange rate")]
		public decimal? M3ORAT => GetNullableDecimal("ORAT");

		/// <summary>
		/// Description: Ref field for amount
		/// FieldName: PRCU
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Ref field for amount")]
		public decimal? M3PRCU => GetNullableDecimal("PRCU");

		/// <summary>
		/// Description: Ref field for amount
		/// FieldName: PRAM
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Ref field for amount")]
		public decimal? M3PRAM => GetNullableDecimal("PRAM");

		/// <summary>
		/// Description: Amount due
		/// FieldName: RECU
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Amount due")]
		public decimal? M3RECU => GetNullableDecimal("RECU");

		/// <summary>
		/// Description: Outstanding amount recorded
		/// FieldName: REAM
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Outstanding amount recorded")]
		public decimal? M3REAM => GetNullableDecimal("REAM");

		/// <summary>
		/// Description: Cash discount date
		/// FieldName: CDDT
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Cash discount date")]
		public DateTime? M3CDDT => GetNullableDateTime("CDDT");

		/// <summary>
		/// Description: Cash discount percentage
		/// FieldName: CDPC
		/// FieldType: N
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Cash discount percentage")]
		public int? M3CDPC => GetNullableInt("CDPC");

		/// <summary>
		/// Description: Cash discount amount currency
		/// FieldName: CDCU
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Cash discount amount currency")]
		public decimal? M3CDCU => GetNullableDecimal("CDCU");

		/// <summary>
		/// Description: Cash discount amount accounted
		/// FieldName: CDAM
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Cash discount amount accounted")]
		public decimal? M3CDAM => GetNullableDecimal("CDAM");

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
		/// Description: Payment type
		/// FieldName: PYTP
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Payment type")]
		public string M3PYTP => GetString("PYTP");

		/// <summary>
		/// Description: Paid amount currency
		/// FieldName: PYCU
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Paid amount currency")]
		public decimal? M3PYCU => GetNullableDecimal("PYCU");

		/// <summary>
		/// Description: Payment amount
		/// FieldName: PYAM
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Payment amount")]
		public decimal? M3PYAM => GetNullableDecimal("PYAM");

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
		/// Description: Accounting dimension 1
		/// FieldName: AIT1
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Accounting dimension 1")]
		public string M3AIT1 => GetString("AIT1");

		/// <summary>
		/// Description: Accounting dimension 2
		/// FieldName: AIT2
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Accounting dimension 2")]
		public string M3AIT2 => GetString("AIT2");

		/// <summary>
		/// Description: Accounting dimension 3
		/// FieldName: AIT3
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Accounting dimension 3")]
		public string M3AIT3 => GetString("AIT3");

		/// <summary>
		/// Description: Accounting dimension 4
		/// FieldName: AIT4
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Accounting dimension 4")]
		public string M3AIT4 => GetString("AIT4");

		/// <summary>
		/// Description: Accounting dimension 5
		/// FieldName: AIT5
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Accounting dimension 5")]
		public string M3AIT5 => GetString("AIT5");

		/// <summary>
		/// Description: Accounting dimension 6
		/// FieldName: AIT6
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Accounting dimension 6")]
		public string M3AIT6 => GetString("AIT6");

		/// <summary>
		/// Description: Accounting dimension 7
		/// FieldName: AIT7
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Accounting dimension 7")]
		public string M3AIT7 => GetString("AIT7");

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
		/// Description: Supplier group
		/// FieldName: SUCL
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Supplier group")]
		public string M3SUCL => GetString("SUCL");

		/// <summary>
		/// Description: Status
		/// FieldName: STCF
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Status")]
		public int? M3STCF => GetNullableInt("STCF");

		/// <summary>
		/// Description: Quota validity year
		/// FieldName: QUYE
		/// FieldType: N
		/// Length: 4
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Quota validity year")]
		public int? M3QUYE => GetNullableInt("QUYE");

		/// <summary>
		/// Description: Quota validity month
		/// FieldName: QUMO
		/// FieldType: N
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Quota validity month")]
		public int? M3QUMO => GetNullableInt("QUMO");

		/// <summary>
		/// Description: Quota priority
		/// FieldName: QUPR
		/// FieldType: N
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Quota priority")]
		public int? M3QUPR => GetNullableInt("QUPR");

		/// <summary>
		/// Description: Quota validity payment method
		/// FieldName: QUPM
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Quota validity payment method")]
		public string M3QUPM => GetString("QUPM");

		/// <summary>
		/// Description: Quota validity currency code
		/// FieldName: QUCC
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Quota validity currency code")]
		public string M3QUCC => GetString("QUCC");

		/// <summary>
		/// Description: Type of payment
		/// FieldName: TYPP
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Type of payment")]
		public string M3TYPP => GetString("TYPP");

		/// <summary>
		/// Description: Recurring payment type
		/// FieldName: SPTY
		/// FieldType: A
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Recurring payment type")]
		public string M3SPTY => GetString("SPTY");

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
		/// Description: Invoice reference field 1
		/// FieldName: IRE1
		/// FieldType: A
		/// Length: 20
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Invoice reference field 1")]
		public string M3IRE1 => GetString("IRE1");

		/// <summary>
		/// Description: Invoice reference field 2
		/// FieldName: IRE2
		/// FieldType: A
		/// Length: 20
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Invoice reference field 2")]
		public string M3IRE2 => GetString("IRE2");

		/// <summary>
		/// Description: Invoice reference field 3
		/// FieldName: IRE3
		/// FieldType: A
		/// Length: 20
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Invoice reference field 3")]
		public string M3IRE3 => GetString("IRE3");

		/// <summary>
		/// Description: Product name
		/// FieldName: AV03
		/// FieldType: A
		/// Length: 30
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Product name")]
		public string M3AV03 => GetString("AV03");

		/// <summary>
		/// Description: Product list
		/// FieldName: AV04
		/// FieldType: N
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Product list")]
		public int? M3AV04 => GetNullableInt("AV04");

		/// <summary>
		/// Description: Country code - description
		/// FieldName: AV05
		/// FieldType: A
		/// Length: 7
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Country code - description")]
		public string M3AV05 => GetString("AV05");

		/// <summary>
		/// Description: Country code - trade statistics (TST)
		/// FieldName: AV06
		/// FieldType: N
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Country code - trade statistics (TST)")]
		public int? M3AV06 => GetNullableInt("AV06");

		/// <summary>
		/// Description: Country code - description
		/// FieldName: AV15
		/// FieldType: A
		/// Length: 7
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Country code - description")]
		public string M3AV15 => GetString("AV15");

		/// <summary>
		/// Description: Country code - trade statistics (TST)
		/// FieldName: AV16
		/// FieldType: N
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Country code - trade statistics (TST)")]
		public int? M3AV16 => GetNullableInt("AV16");

		/// <summary>
		/// Description: Country code - description
		/// FieldName: AW07
		/// FieldType: A
		/// Length: 7
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Country code - description")]
		public string M3AW07 => GetString("AW07");

		/// <summary>
		/// Description: Country code - trade statistics (TST)
		/// FieldName: AW08
		/// FieldType: N
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Country code - trade statistics (TST)")]
		public int? M3AW08 => GetNullableInt("AW08");

		/// <summary>
		/// Description: Transit
		/// FieldName: AV08
		/// FieldType: A
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Transit")]
		public string M3AV08 => GetString("AV08");

		/// <summary>
		/// Description: Interrupt transit
		/// FieldName: AV09
		/// FieldType: A
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Interrupt transit")]
		public string M3AV09 => GetString("AV09");

		/// <summary>
		/// Description: Unsold transit goods domestic warehouse
		/// FieldName: AV10
		/// FieldType: A
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Unsold transit goods domestic warehouse")]
		public string M3AV10 => GetString("AV10");

		/// <summary>
		/// Description: Unsold transit goods - foreign warehouse
		/// FieldName: AV11
		/// FieldType: A
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Unsold transit goods - foreign warehouse")]
		public string M3AV11 => GetString("AV11");

		/// <summary>
		/// Description: Due date sale
		/// FieldName: AV13
		/// FieldType: A
		/// Length: 4
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Due date sale")]
		public string M3AV13 => GetString("AV13");

		/// <summary>
		/// Description: Sales price for transit trade
		/// FieldName: AV17
		/// FieldType: N
		/// Length: 13
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Sales price for transit trade")]
		public decimal? M3AV17 => GetNullableDecimal("AV17");

		/// <summary>
		/// Description: Return type
		/// FieldName: AW03
		/// FieldType: N
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Return type")]
		public int? M3AW03 => GetNullableInt("AW03");

		/// <summary>
		/// Description: Code service ID
		/// FieldName: AW04
		/// FieldType: N
		/// Length: 4
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Code service ID")]
		public int? M3AW04 => GetNullableInt("AW04");

		/// <summary>
		/// Description: Withheld tax - foreign currency
		/// FieldName: WACA
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Withheld tax - foreign currency")]
		public decimal? M3WACA => GetNullableDecimal("WACA");

		/// <summary>
		/// Description: Withheld tax - local currency
		/// FieldName: WAAM
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Withheld tax - local currency")]
		public decimal? M3WAAM => GetNullableDecimal("WAAM");

		/// <summary>
		/// Description: Reference number
		/// FieldName: PPYR
		/// FieldType: A
		/// Length: 25
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Reference number")]
		public string M3PPYR => GetString("PPYR");

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
		/// Description: Net amount reported
		/// FieldName: VTAN
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Net amount reported")]
		public decimal? M3VTAN => GetNullableDecimal("VTAN");
	}
}
// EOF
