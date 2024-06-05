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
	public partial class GetInvTotInfoResponse : M3BaseRecord 
	{

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
		/// Description: Transaction code
		/// FieldName: TRCD
		/// FieldType: N
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Transaction code")]
		public int? M3TRCD => GetNullableInt("TRCD");

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
		/// Description: Supplier
		/// FieldName: SUNO
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Supplier")]
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
		/// Description: Transaction description
		/// FieldName: TDSC
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Transaction description")]
		public string M3TDSC => GetString("TDSC");

		/// <summary>
		/// Description: Authorized user
		/// FieldName: APCD
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Authorized user")]
		public string M3APCD => GetString("APCD");

		/// <summary>
		/// Description: Payment stop
		/// FieldName: IVBL
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Payment stop")]
		public int? M3IVBL => GetNullableInt("IVBL");

		/// <summary>
		/// Description: Stopped by
		/// FieldName: BLBY
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Stopped by")]
		public string M3BLBY => GetString("BLBY");

		/// <summary>
		/// Description: Stop date
		/// FieldName: BLDT
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Stop date")]
		public DateTime? M3BLDT => GetNullableDateTime("BLDT");

		/// <summary>
		/// Description: Approved for payment
		/// FieldName: APRV
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Approved for payment")]
		public int? M3APRV => GetNullableInt("APRV");

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
		/// Description: Decimal places for amount
		/// FieldName: DCAM
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Decimal places for amount")]
		public int? M3DCAM => GetNullableInt("DCAM");

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
		/// Description: Internal reconciliation code
		/// FieldName: RECO
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Internal reconciliation code")]
		public int? M3RECO => GetNullableInt("RECO");

		/// <summary>
		/// Description: Internal reconciliation date
		/// FieldName: REDE
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Internal reconciliation date")]
		public DateTime? M3REDE => GetNullableDateTime("REDE");

		/// <summary>
		/// Description: Accounting option - payt rcvd variances
		/// FieldName: SLOP
		/// FieldType: N
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Accounting option - payt rcvd variances")]
		public int? M3SLOP => GetNullableInt("SLOP");

		/// <summary>
		/// Description: Status - payment
		/// FieldName: PYST
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Status - payment")]
		public int? M3PYST => GetNullableInt("PYST");

		/// <summary>
		/// Description: Remittance status
		/// FieldName: PYRS
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Remittance status")]
		public string M3PYRS => GetString("PYRS");

		/// <summary>
		/// Description: Filing code
		/// FieldName: ARCD
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Filing code")]
		public int? M3ARCD => GetNullableInt("ARCD");

		/// <summary>
		/// Description: Entry method
		/// FieldName: ENME
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Entry method")]
		public int? M3ENME => GetNullableInt("ENME");

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
		/// Description: Invoice class
		/// FieldName: IVCL
		/// FieldType: A
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Invoice class")]
		public string M3IVCL => GetString("IVCL");

		/// <summary>
		/// Description: Recorded amount
		/// FieldName: ACAM
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Recorded amount")]
		public decimal? M3ACAM => GetNullableDecimal("ACAM");

		/// <summary>
		/// Description: Paid currency amount
		/// FieldName: PCUA
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Paid currency amount")]
		public decimal? M3PCUA => GetNullableDecimal("PCUA");

		/// <summary>
		/// Description: Paid accounted amount
		/// FieldName: PAMT
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Paid accounted amount")]
		public decimal? M3PAMT => GetNullableDecimal("PAMT");

		/// <summary>
		/// Description: Outstanding currency amount
		/// FieldName: OCUA
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Outstanding currency amount")]
		public decimal? M3OCUA => GetNullableDecimal("OCUA");

		/// <summary>
		/// Description: Outstanding accounted amount
		/// FieldName: OAMT
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Outstanding accounted amount")]
		public decimal? M3OAMT => GetNullableDecimal("OAMT");

		/// <summary>
		/// Description: Taxable currency amount
		/// FieldName: TBCU
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Taxable currency amount")]
		public decimal? M3TBCU => GetNullableDecimal("TBCU");

		/// <summary>
		/// Description: Taxable accounted amount
		/// FieldName: TBAM
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Taxable accounted amount")]
		public decimal? M3TBAM => GetNullableDecimal("TBAM");

		/// <summary>
		/// Description: Tax currency amount
		/// FieldName: TXCU
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Tax currency amount")]
		public decimal? M3TXCU => GetNullableDecimal("TXCU");

		/// <summary>
		/// Description: Tax accounted amount
		/// FieldName: TXAM
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Tax accounted amount")]
		public decimal? M3TXAM => GetNullableDecimal("TXAM");

		/// <summary>
		/// Description: Cash Discount Currency Amount
		/// FieldName: CDCU
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Cash Discount Currency Amount")]
		public decimal? M3CDCU => GetNullableDecimal("CDCU");

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
		/// Description: Cash Discount Taken Accounted Amount
		/// FieldName: CDAM
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Cash Discount Taken Accounted Amount")]
		public decimal? M3CDAM => GetNullableDecimal("CDAM");
	}
}
// EOF
