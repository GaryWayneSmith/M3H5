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

namespace M3H5Lib.Api.ARS200MI
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
		public int? M3_YEA4 => GetNullableInt("YEA4");

		/// <summary>
		/// Description: Journal number
		/// FieldName: JRNO
		/// FieldType: N
		/// Length: 7
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Journal number")]
		public int? M3_JRNO => GetNullableInt("JRNO");

		/// <summary>
		/// Description: Journal sequence number
		/// FieldName: JSNO
		/// FieldType: N
		/// Length: 7
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Journal sequence number")]
		public int? M3_JSNO => GetNullableInt("JSNO");

		/// <summary>
		/// Description: Payer
		/// FieldName: PYNO
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Payer")]
		public string M3_PYNO => GetString("PYNO");

		/// <summary>
		/// Description: Customer
		/// FieldName: CUNO
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Customer")]
		public string M3_CUNO => GetString("CUNO");

		/// <summary>
		/// Description: Invoice number
		/// FieldName: CINO
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Invoice number")]
		public string M3_CINO => GetString("CINO");

		/// <summary>
		/// Description: Invoice year
		/// FieldName: INYR
		/// FieldType: N
		/// Length: 4
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Invoice year")]
		public int? M3_INYR => GetNullableInt("INYR");

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
		/// Description: Transaction description
		/// FieldName: TDSC
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Transaction description")]
		public string M3_TDSC => GetString("TDSC");

		/// <summary>
		/// Description: Salesperson
		/// FieldName: SMCD
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Salesperson")]
		public string M3_SMCD => GetString("SMCD");

		/// <summary>
		/// Description: Customer group
		/// FieldName: CUCL
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Customer group")]
		public string M3_CUCL => GetString("CUCL");

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
		/// Description: Exchange rate
		/// FieldName: ARAT
		/// FieldType: N
		/// Length: 13
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Exchange rate")]
		public decimal? M3_ARAT => GetNullableDecimal("ARAT");

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
		/// Description: Decimal places for amount
		/// FieldName: DCAM
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Decimal places for amount")]
		public int? M3_DCAM => GetNullableInt("DCAM");

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
		/// Description: Follow-up date
		/// FieldName: RVDT
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Follow-up date")]
		public DateTime? M3_RVDT => GetNullableDateTime("RVDT");

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
		/// Description: Bank account identity
		/// FieldName: BKID
		/// FieldType: A
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Bank account identity")]
		public string M3_BKID => GetString("BKID");

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
		/// Description: Payment type
		/// FieldName: PYTP
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Payment type")]
		public string M3_PYTP => GetString("PYTP");

		/// <summary>
		/// Description: Payment method - accounts receivable
		/// FieldName: PYCD
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Payment method - accounts receivable")]
		public string M3_PYCD => GetString("PYCD");

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
		/// Description: Internal reconciliation code
		/// FieldName: RECO
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Internal reconciliation code")]
		public int? M3_RECO => GetNullableInt("RECO");

		/// <summary>
		/// Description: Internal reconciliation date
		/// FieldName: REDE
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Internal reconciliation date")]
		public DateTime? M3_REDE => GetNullableDateTime("REDE");

		/// <summary>
		/// Description: Accounting option - payt rcvd variances
		/// FieldName: SLOP
		/// FieldType: N
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Accounting option - payt rcvd variances")]
		public int? M3_SLOP => GetNullableInt("SLOP");

		/// <summary>
		/// Description: Receipt status
		/// FieldName: CRST
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Receipt status")]
		public int? M3_CRST => GetNullableInt("CRST");

		/// <summary>
		/// Description: Remittance status
		/// FieldName: PYRS
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Remittance status")]
		public string M3_PYRS => GetString("PYRS");

		/// <summary>
		/// Description: Advice code
		/// FieldName: ACBL
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Advice code")]
		public int? M3_ACBL => GetNullableInt("ACBL");

		/// <summary>
		/// Description: Status - payment reminder
		/// FieldName: RMST
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Status - payment reminder")]
		public int? M3_RMST => GetNullableInt("RMST");

		/// <summary>
		/// Description: Last reminder date
		/// FieldName: LRDT
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Last reminder date")]
		public DateTime? M3_LRDT => GetNullableDateTime("LRDT");

		/// <summary>
		/// Description: Payment reminder stop
		/// FieldName: RMBL
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Payment reminder stop")]
		public int? M3_RMBL => GetNullableInt("RMBL");

		/// <summary>
		/// Description: Stopped by
		/// FieldName: BLBY
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Stopped by")]
		public string M3_BLBY => GetString("BLBY");

		/// <summary>
		/// Description: Stop date
		/// FieldName: BLDT
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Stop date")]
		public DateTime? M3_BLDT => GetNullableDateTime("BLDT");

		/// <summary>
		/// Description: Number of payment reminders
		/// FieldName: RMQT
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Number of payment reminders")]
		public int? M3_RMQT => GetNullableInt("RMQT");

		/// <summary>
		/// Description: Interest invoice block
		/// FieldName: IIST
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Interest invoice block")]
		public int? M3_IIST => GetNullableInt("IIST");

		/// <summary>
		/// Description: Interest invoice stop
		/// FieldName: IICD
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Interest invoice stop")]
		public int? M3_IICD => GetNullableInt("IICD");

		/// <summary>
		/// Description: Payment date
		/// FieldName: DTP5
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Payment date")]
		public DateTime? M3_DTP5 => GetNullableDateTime("DTP5");

		/// <summary>
		/// Description: Cumulative interest amount
		/// FieldName: IIAM
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Cumulative interest amount")]
		public decimal? M3_IIAM => GetNullableDecimal("IIAM");

		/// <summary>
		/// Description: Debt collection status
		/// FieldName: CLST
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Debt collection status")]
		public int? M3_CLST => GetNullableInt("CLST");

		/// <summary>
		/// Description: Collection
		/// FieldName: CLCD
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Collection")]
		public int? M3_CLCD => GetNullableInt("CLCD");

		/// <summary>
		/// Description: Filing code
		/// FieldName: ARCD
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Filing code")]
		public int? M3_ARCD => GetNullableInt("ARCD");

		/// <summary>
		/// Description: Status - group invoice
		/// FieldName: SAGS
		/// FieldType: N
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Status - group invoice")]
		public int? M3_SAGS => GetNullableInt("SAGS");

		/// <summary>
		/// Description: Grouping of invoices date
		/// FieldName: GRPD
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Grouping of invoices date")]
		public DateTime? M3_GRPD => GetNullableDateTime("GRPD");

		/// <summary>
		/// Description: Text identity
		/// FieldName: TXID
		/// FieldType: N
		/// Length: 13
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Text identity")]
		public decimal? M3_TXID => GetNullableDecimal("TXID");

		/// <summary>
		/// Description: Draft printed
		/// FieldName: DFPT
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Draft printed")]
		public int? M3_DFPT => GetNullableInt("DFPT");

		/// <summary>
		/// Description: Draft printed date
		/// FieldName: DFPD
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Draft printed date")]
		public DateTime? M3_DFPD => GetNullableDateTime("DFPD");

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
		/// Description: Timestamp
		/// FieldName: LMTS
		/// FieldType: N
		/// Length: 18
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Timestamp")]
		public decimal? M3_LMTS => GetNullableDecimal("LMTS");

		/// <summary>
		/// Description: Responsible
		/// FieldName: RESP
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Responsible")]
		public string M3_RESP => GetString("RESP");

		/// <summary>
		/// Description: Action date
		/// FieldName: ADAT
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Action date")]
		public DateTime? M3_ADAT => GetNullableDateTime("ADAT");

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
		/// Description: Approved for payment
		/// FieldName: APRV
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Approved for payment")]
		public int? M3_APRV => GetNullableInt("APRV");

		/// <summary>
		/// Description: Invoice class
		/// FieldName: IVCL
		/// FieldType: A
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Invoice class")]
		public string M3_IVCL => GetString("IVCL");

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
		/// Description: Recorded amount
		/// FieldName: ACAM
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Recorded amount")]
		public decimal? M3_ACAM => GetNullableDecimal("ACAM");

		/// <summary>
		/// Description: Paid currency amount
		/// FieldName: PCUA
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Paid currency amount")]
		public decimal? M3_PCUA => GetNullableDecimal("PCUA");

		/// <summary>
		/// Description: Paid accounted amount
		/// FieldName: PAMT
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Paid accounted amount")]
		public decimal? M3_PAMT => GetNullableDecimal("PAMT");

		/// <summary>
		/// Description: Outstanding currency amount
		/// FieldName: OCUA
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Outstanding currency amount")]
		public decimal? M3_OCUA => GetNullableDecimal("OCUA");

		/// <summary>
		/// Description: Outstanding accounted amount
		/// FieldName: OAMT
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Outstanding accounted amount")]
		public decimal? M3_OAMT => GetNullableDecimal("OAMT");

		/// <summary>
		/// Description: Taxable currency amount
		/// FieldName: TBCU
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Taxable currency amount")]
		public decimal? M3_TBCU => GetNullableDecimal("TBCU");

		/// <summary>
		/// Description: Taxable accounted amount
		/// FieldName: TBAM
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Taxable accounted amount")]
		public decimal? M3_TBAM => GetNullableDecimal("TBAM");

		/// <summary>
		/// Description: Tax currency amount
		/// FieldName: TXCU
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Tax currency amount")]
		public decimal? M3_TXCU => GetNullableDecimal("TXCU");

		/// <summary>
		/// Description: Tax accounted amount
		/// FieldName: TXAM
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Tax accounted amount")]
		public decimal? M3_TXAM => GetNullableDecimal("TXAM");

		/// <summary>
		/// Description: Bill Back currency amount
		/// FieldName: BBCU
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Bill Back currency amount")]
		public decimal? M3_BBCU => GetNullableDecimal("BBCU");

		/// <summary>
		/// Description: Bill Back accounted amount
		/// FieldName: BBAM
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Bill Back accounted amount")]
		public decimal? M3_BBAM => GetNullableDecimal("BBAM");

		/// <summary>
		/// Description: Debit Note currency amount
		/// FieldName: DNCU
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Debit Note currency amount")]
		public decimal? M3_DNCU => GetNullableDecimal("DNCU");

		/// <summary>
		/// Description: Debit Note Accounted Amount
		/// FieldName: DNAM
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Debit Note Accounted Amount")]
		public decimal? M3_DNAM => GetNullableDecimal("DNAM");

		/// <summary>
		/// Description: Cash Discount Taken Currency Amount
		/// FieldName: CDCU
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Cash Discount Taken Currency Amount")]
		public decimal? M3_CDCU => GetNullableDecimal("CDCU");

		/// <summary>
		/// Description: Cash Discount Taken Accounted amount
		/// FieldName: CDAM
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Cash Discount Taken Accounted amount")]
		public decimal? M3_CDAM => GetNullableDecimal("CDAM");

		/// <summary>
		/// Description: Write Off Currency Amount
		/// FieldName: WRCU
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Write Off Currency Amount")]
		public decimal? M3_WRCU => GetNullableDecimal("WRCU");

		/// <summary>
		/// Description: Write Off Accounted Amount
		/// FieldName: WRAM
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Write Off Accounted Amount")]
		public decimal? M3_WRAM => GetNullableDecimal("WRAM");

		/// <summary>
		/// Description: Rounded Off Currency Amount
		/// FieldName: ROCU
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Rounded Off Currency Amount")]
		public decimal? M3_ROCU => GetNullableDecimal("ROCU");

		/// <summary>
		/// Description: Rounded Off
		/// FieldName: ROAM
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Rounded Off")]
		public decimal? M3_ROAM => GetNullableDecimal("ROAM");

		/// <summary>
		/// Description: Local currency
		/// FieldName: LOCD
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Local currency")]
		public string M3_LOCD => GetString("LOCD");

		/// <summary>
		/// Description: Transaction description
		/// FieldName: TDS1
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Transaction description")]
		public string M3_TDS1 => GetString("TDS1");
	}
}
// EOF
