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

namespace M3H5Lib.Api.GLS200MI
{
	public partial class LstVouchersByDtResponse : M3BaseRecord 
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
		/// Description: FAM function
		/// FieldName: FEID
		/// FieldType: A
		/// Length: 4
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("FAM function")]
		public string M3_FEID => GetString("FEID");

		/// <summary>
		/// Description: FAM function
		/// FieldName: FNCN
		/// FieldType: N
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("FAM function")]
		public int? M3_FNCN => GetNullableInt("FNCN");

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
		/// Description: Voucher name
		/// FieldName: VDSC
		/// FieldType: A
		/// Length: 7
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Voucher name")]
		public string M3_VDSC => GetString("VDSC");

		/// <summary>
		/// Description: Transaction code
		/// FieldName: TRCD
		/// FieldType: N
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Transaction code")]
		public int? M3_TRCD => GetNullableInt("TRCD");

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
		/// Description: External/internal transaction
		/// FieldName: EICD
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("External/internal transaction")]
		public int? M3_EICD => GetNullableInt("EICD");

		/// <summary>
		/// Description: Transaction date
		/// FieldName: OCDT
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Transaction date")]
		public DateTime? M3_OCDT => GetNullableDateTime("OCDT");

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
		/// Description: External reconciliation date
		/// FieldName: ERDT
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("External reconciliation date")]
		public DateTime? M3_ERDT => GetNullableDateTime("ERDT");

		/// <summary>
		/// Description: VAT date
		/// FieldName: VATD
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("VAT date")]
		public DateTime? M3_VATD => GetNullableDateTime("VATD");

		/// <summary>
		/// Description: Check mark
		/// FieldName: TOCD
		/// FieldType: A
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Check mark")]
		public string M3_TOCD => GetString("TOCD");

		/// <summary>
		/// Description: Accounting dimension 1
		/// FieldName: AIT1
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Accounting dimension 1")]
		public string M3_AIT1 => GetString("AIT1");

		/// <summary>
		/// Description: Accounting dimension 2
		/// FieldName: AIT2
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Accounting dimension 2")]
		public string M3_AIT2 => GetString("AIT2");

		/// <summary>
		/// Description: Accounting dimension 3
		/// FieldName: AIT3
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Accounting dimension 3")]
		public string M3_AIT3 => GetString("AIT3");

		/// <summary>
		/// Description: Accounting dimension 4
		/// FieldName: AIT4
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Accounting dimension 4")]
		public string M3_AIT4 => GetString("AIT4");

		/// <summary>
		/// Description: Accounting dimension 5
		/// FieldName: AIT5
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Accounting dimension 5")]
		public string M3_AIT5 => GetString("AIT5");

		/// <summary>
		/// Description: Accounting dimension 6
		/// FieldName: AIT6
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Accounting dimension 6")]
		public string M3_AIT6 => GetString("AIT6");

		/// <summary>
		/// Description: Accounting dimension 7
		/// FieldName: AIT7
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Accounting dimension 7")]
		public string M3_AIT7 => GetString("AIT7");

		/// <summary>
		/// Description: Quantity
		/// FieldName: ACQT
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Quantity")]
		public decimal? M3_ACQT => GetNullableDecimal("ACQT");

		/// <summary>
		/// Description: Decimal places for quantities
		/// FieldName: DCQT
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Decimal places for quantities")]
		public int? M3_DCQT => GetNullableInt("DCQT");

		/// <summary>
		/// Description: Unit of measure
		/// FieldName: UNIT
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Unit of measure")]
		public string M3_UNIT => GetString("UNIT");

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
		/// Description: Third currency
		/// FieldName: THCC
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Third currency")]
		public string M3_THCC => GetString("THCC");

		/// <summary>
		/// Description: Third currency rate type
		/// FieldName: TCRT
		/// FieldType: N
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Third currency rate type")]
		public int? M3_TCRT => GetNullableInt("TCRT");

		/// <summary>
		/// Description: Third exchange rate
		/// FieldName: TCAR
		/// FieldType: N
		/// Length: 13
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Third exchange rate")]
		public decimal? M3_TCAR => GetNullableDecimal("TCAR");

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
		/// Description: Debit/credit code
		/// FieldName: DBCR
		/// FieldType: A
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Debit/credit code")]
		public string M3_DBCR => GetString("DBCR");

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
		/// Description: Transferred to group consolidation
		/// FieldName: TGCD
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Transferred to group consolidation")]
		public int? M3_TGCD => GetNullableInt("TGCD");

		/// <summary>
		/// Description: VAT rate 1
		/// FieldName: VTP1
		/// FieldType: N
		/// Length: 7
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("VAT rate 1")]
		public int? M3_VTP1 => GetNullableInt("VTP1");

		/// <summary>
		/// Description: Calculated VAT amount 1
		/// FieldName: CVT1
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Calculated VAT amount 1")]
		public decimal? M3_CVT1 => GetNullableDecimal("CVT1");

		/// <summary>
		/// Description: VAT rate 2
		/// FieldName: VTP2
		/// FieldType: N
		/// Length: 7
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("VAT rate 2")]
		public int? M3_VTP2 => GetNullableInt("VTP2");

		/// <summary>
		/// Description: Calculated VAT amount 2
		/// FieldName: CVT2
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Calculated VAT amount 2")]
		public decimal? M3_CVT2 => GetNullableDecimal("CVT2");

		/// <summary>
		/// Description: Calculated VAT amount 3
		/// FieldName: CVT3
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Calculated VAT amount 3")]
		public decimal? M3_CVT3 => GetNullableDecimal("CVT3");

		/// <summary>
		/// Description: Calculated VAT amount 4
		/// FieldName: CVT4
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Calculated VAT amount 4")]
		public decimal? M3_CVT4 => GetNullableDecimal("CVT4");

		/// <summary>
		/// Description: VAT reported
		/// FieldName: VATR
		/// FieldType: A
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("VAT reported")]
		public string M3_VATR => GetString("VATR");

		/// <summary>
		/// Description: VAT registration no existed
		/// FieldName: VRNE
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("VAT registration no existed")]
		public int? M3_VRNE => GetNullableInt("VRNE");

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
		/// Description: 1 position for miscellaneous use in GL
		/// FieldName: GFL1
		/// FieldType: A
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("1 position for miscellaneous use in GL")]
		public string M3_GFL1 => GetString("GFL1");

		/// <summary>
		/// Description: 1 position for miscellaneous use in GL
		/// FieldName: GFL2
		/// FieldType: A
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("1 position for miscellaneous use in GL")]
		public string M3_GFL2 => GetString("GFL2");

		/// <summary>
		/// Description: 1 position for miscellaneous use in GL
		/// FieldName: GFL3
		/// FieldType: A
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("1 position for miscellaneous use in GL")]
		public string M3_GFL3 => GetString("GFL3");

		/// <summary>
		/// Description: 1 position for miscellaneous use in GL
		/// FieldName: GFL4
		/// FieldType: A
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("1 position for miscellaneous use in GL")]
		public string M3_GFL4 => GetString("GFL4");

		/// <summary>
		/// Description: 1 position for miscellaneous use in GL
		/// FieldName: GFL5
		/// FieldType: A
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("1 position for miscellaneous use in GL")]
		public string M3_GFL5 => GetString("GFL5");

		/// <summary>
		/// Description: Base country
		/// FieldName: BSCD
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Base country")]
		public string M3_BSCD => GetString("BSCD");

		/// <summary>
		/// Description: From/to country
		/// FieldName: FTCO
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("From/to country")]
		public string M3_FTCO => GetString("FTCO");

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
		/// Description: Accounting period
		/// FieldName: ACYP
		/// FieldType: N
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Accounting period")]
		public int? M3_ACYP => GetNullableInt("ACYP");

		/// <summary>
		/// Description: Third currency amount
		/// FieldName: TCAM
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Third currency amount")]
		public decimal? M3_TCAM => GetNullableDecimal("TCAM");

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
		/// Description: Voucher text
		/// FieldName: VTXT
		/// FieldType: A
		/// Length: 40
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Voucher text")]
		public string M3_VTXT => GetString("VTXT");

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
		/// Description: Authorized user
		/// FieldName: APCD
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Authorized user")]
		public string M3_APCD => GetString("APCD");

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
		/// Description: State
		/// FieldName: ECAR
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("State")]
		public string M3_ECAR => GetString("ECAR");

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
		/// Description: Voucher sequence number
		/// FieldName: VSNO
		/// FieldType: N
		/// Length: 7
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Voucher sequence number")]
		public int? M3_VSNO => GetNullableInt("VSNO");

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
		/// Description: Period
		/// FieldName: CYP6
		/// FieldType: N
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Period")]
		public int? M3_CYP6 => GetNullableInt("CYP6");

		/// <summary>
		/// Description: Debit/Credit flag
		/// FieldName: DCFG
		/// FieldType: A
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Debit/Credit flag")]
		public string M3_DCFG => GetString("DCFG");

		/// <summary>
		/// Description: Quebec sales tax rate
		/// FieldName: VTPQ
		/// FieldType: N
		/// Length: 8
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Quebec sales tax rate")]
		public int? M3_VTPQ => GetNullableInt("VTPQ");

		/// <summary>
		/// Description: Deductable VAT 1
		/// FieldName: VTD1
		/// FieldType: N
		/// Length: 7
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Deductable VAT 1")]
		public int? M3_VTD1 => GetNullableInt("VTD1");

		/// <summary>
		/// Description: Cross authorizer
		/// FieldName: CRAU
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Cross authorizer")]
		public string M3_CRAU => GetString("CRAU");

		/// <summary>
		/// Description: Approved for payment by cross authorizer
		/// FieldName: CRAY
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Approved for payment by cross authorizer")]
		public int? M3_CRAY => GetNullableInt("CRAY");
	}
}
// EOF
