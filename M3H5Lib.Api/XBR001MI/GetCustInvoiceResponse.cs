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

namespace M3H5Lib.Api.XBR001MI
{
	public partial class GetCustInvoiceResponse : M3BaseRecord 
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
		/// Description: Invoice prefix
		/// FieldName: INPX
		/// FieldType: A
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Invoice prefix")]
		public string M3_INPX => GetString("INPX");

		/// <summary>
		/// Description: Invoice number
		/// FieldName: IVNO
		/// FieldType: N
		/// Length: 9
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Invoice number")]
		public int? M3_IVNO => GetNullableInt("IVNO");

		/// <summary>
		/// Description: Invoice series
		/// FieldName: OT34
		/// FieldType: A
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Invoice series")]
		public string M3_OT34 => GetString("OT34");

		/// <summary>
		/// Description: Customer number
		/// FieldName: CUNO
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Customer number")]
		public string M3_CUNO => GetString("CUNO");

		/// <summary>
		/// Description: Entry date
		/// FieldName: DTEM
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Entry date")]
		public string M3_DTEM => GetString("DTEM");

		/// <summary>
		/// Description: Invoice delete date
		/// FieldName: XDDT
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Invoice delete date")]
		public DateTime? M3_XDDT => GetNullableDateTime("XDDT");

		/// <summary>
		/// Description: Forwarding agent
		/// FieldName: TRAN
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Forwarding agent")]
		public string M3_TRAN => GetString("TRAN");

		/// <summary>
		/// Description: Invoice source
		/// FieldName: XIVS
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Invoice source")]
		public int? M3_XIVS => GetNullableInt("XIVS");

		/// <summary>
		/// Description: Gross goods value
		/// FieldName: VLTM
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Gross goods value")]
		public decimal? M3_VLTM => GetNullableDecimal("VLTM");

		/// <summary>
		/// Description: Discount amount 1
		/// FieldName: DIA1
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Discount amount 1")]
		public decimal? M3_DIA1 => GetNullableDecimal("DIA1");

		/// <summary>
		/// Description: Discount amount 2
		/// FieldName: DIA2
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Discount amount 2")]
		public decimal? M3_DIA2 => GetNullableDecimal("DIA2");

		/// <summary>
		/// Description: Discount amount 3
		/// FieldName: DIA3
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Discount amount 3")]
		public decimal? M3_DIA3 => GetNullableDecimal("DIA3");

		/// <summary>
		/// Description: Discount amount 4
		/// FieldName: DIA4
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Discount amount 4")]
		public decimal? M3_DIA4 => GetNullableDecimal("DIA4");

		/// <summary>
		/// Description: Discount amount 5
		/// FieldName: DIA5
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Discount amount 5")]
		public decimal? M3_DIA5 => GetNullableDecimal("DIA5");

		/// <summary>
		/// Description: Discount amount 6
		/// FieldName: DIA6
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Discount amount 6")]
		public decimal? M3_DIA6 => GetNullableDecimal("DIA6");

		/// <summary>
		/// Description: Net goods value
		/// FieldName: NTVM
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Net goods value")]
		public decimal? M3_NTVM => GetNullableDecimal("NTVM");

		/// <summary>
		/// Description: Freight amount
		/// FieldName: VLFR
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Freight amount")]
		public decimal? M3_VLFR => GetNullableDecimal("VLFR");

		/// <summary>
		/// Description: Insurance amount
		/// FieldName: HFN5
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Insurance amount")]
		public decimal? M3_HFN5 => GetNullableDecimal("HFN5");

		/// <summary>
		/// Description: Other expenses
		/// FieldName: HFN6
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Other expenses")]
		public decimal? M3_HFN6 => GetNullableDecimal("HFN6");

		/// <summary>
		/// Description: IPI base calculation
		/// FieldName: VBIP
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("IPI base calculation")]
		public decimal? M3_VBIP => GetNullableDecimal("VBIP");

		/// <summary>
		/// Description: ICMS base
		/// FieldName: VBIC
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("ICMS base")]
		public decimal? M3_VBIC => GetNullableDecimal("VBIC");

		/// <summary>
		/// Description: Tax subst amount
		/// FieldName: VSBT
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Tax subst amount")]
		public decimal? M3_VSBT => GetNullableDecimal("VSBT");

		/// <summary>
		/// Description: IPI amount
		/// FieldName: VIPI
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("IPI amount")]
		public decimal? M3_VIPI => GetNullableDecimal("VIPI");

		/// <summary>
		/// Description: ICMS amount
		/// FieldName: VICM
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("ICMS amount")]
		public decimal? M3_VICM => GetNullableDecimal("VICM");

		/// <summary>
		/// Description: ICMS tax sub amount
		/// FieldName: VLST
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("ICMS tax sub amount")]
		public decimal? M3_VLST => GetNullableDecimal("VLST");

		/// <summary>
		/// Description: IPI not tributed amount
		/// FieldName: INIP
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("IPI not tributed amount")]
		public decimal? M3_INIP => GetNullableDecimal("INIP");

		/// <summary>
		/// Description: ICMS not tributed amount
		/// FieldName: INIC
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("ICMS not tributed amount")]
		public decimal? M3_INIC => GetNullableDecimal("INIC");

		/// <summary>
		/// Description: IPI other amount
		/// FieldName: OUIP
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("IPI other amount")]
		public decimal? M3_OUIP => GetNullableDecimal("OUIP");

		/// <summary>
		/// Description: ICMS other amount
		/// FieldName: OUIC
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("ICMS other amount")]
		public decimal? M3_OUIC => GetNullableDecimal("OUIC");

		/// <summary>
		/// Description: Gross service amount
		/// FieldName: VLTS
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Gross service amount")]
		public decimal? M3_VLTS => GetNullableDecimal("VLTS");

		/// <summary>
		/// Description: Net service amount
		/// FieldName: VLNS
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Net service amount")]
		public decimal? M3_VLNS => GetNullableDecimal("VLNS");

		/// <summary>
		/// Description: IRRF amount
		/// FieldName: VIRR
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("IRRF amount")]
		public decimal? M3_VIRR => GetNullableDecimal("VIRR");

		/// <summary>
		/// Description: ISS amount
		/// FieldName: VISS
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("ISS amount")]
		public decimal? M3_VISS => GetNullableDecimal("VISS");

		/// <summary>
		/// Description: PIS base
		/// FieldName: BPIS
		/// FieldType: A
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("PIS base")]
		public string M3_BPIS => GetString("BPIS");

		/// <summary>
		/// Description: COFINS base
		/// FieldName: BCOF
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("COFINS base")]
		public decimal? M3_BCOF => GetNullableDecimal("BCOF");

		/// <summary>
		/// Description: PIS amount
		/// FieldName: VPIS
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("PIS amount")]
		public decimal? M3_VPIS => GetNullableDecimal("VPIS");

		/// <summary>
		/// Description: COFINS amount
		/// FieldName: VCOF
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("COFINS amount")]
		public decimal? M3_VCOF => GetNullableDecimal("VCOF");

		/// <summary>
		/// Description: Invoice total amount
		/// FieldName: VLNT
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Invoice total amount")]
		public decimal? M3_VLNT => GetNullableDecimal("VLNT");

		/// <summary>
		/// Description: Stopped customers
		/// FieldName: FL01
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Stopped customers")]
		public int? M3_FL01 => GetNullableInt("FL01");

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
		/// Description: Extended invoice number
		/// FieldName: EXIN
		/// FieldType: A
		/// Length: 14
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Extended invoice number")]
		public string M3_EXIN => GetString("EXIN");

		/// <summary>
		/// Description: NF-e Id
		/// FieldName: NFEI
		/// FieldType: A
		/// Length: 44
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("NF-e Id")]
		public string M3_NFEI => GetString("NFEI");

		/// <summary>
		/// Description: NF-e type
		/// FieldName: NFYP
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("NF-e type")]
		public int? M3_NFYP => GetNullableInt("NFYP");

		/// <summary>
		/// Description: Receipt number
		/// FieldName: RCPN
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Receipt number")]
		public string M3_RCPN => GetString("RCPN");

		/// <summary>
		/// Description: Return status
		/// FieldName: RTNS
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Return status")]
		public string M3_RTNS => GetString("RTNS");

		/// <summary>
		/// Description: invoice status
		/// FieldName: INST
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("invoice status")]
		public string M3_INST => GetString("INST");

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
		/// Description: Invoice type
		/// FieldName: XITY
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Invoice type")]
		public int? M3_XITY => GetNullableInt("XITY");

		/// <summary>
		/// Description: Recipient pays
		/// FieldName: RCPY
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Recipient pays")]
		public int? M3_RCPY => GetNullableInt("RCPY");

		/// <summary>
		/// Description: Split due date
		/// FieldName: EFYN
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Split due date")]
		public int? M3_EFYN => GetNullableInt("EFYN");

		/// <summary>
		/// Description: Import document number DI/DSI/DA
		/// FieldName: DINR
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Import document number DI/DSI/DA")]
		public string M3_DINR => GetString("DINR");

		/// <summary>
		/// Description: DI/DSI/DA date
		/// FieldName: DIDT
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("DI/DSI/DA date")]
		public DateTime? M3_DIDT => GetNullableDateTime("DIDT");

		/// <summary>
		/// Description: Customs house location
		/// FieldName: CHLC
		/// FieldType: A
		/// Length: 60
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Customs house location")]
		public string M3_CHLC => GetString("CHLC");

		/// <summary>
		/// Description: Customs house UF code
		/// FieldName: CHUF
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Customs house UF code")]
		public string M3_CHUF => GetString("CHUF");

		/// <summary>
		/// Description: Customs clearance date
		/// FieldName: CCDT
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Customs clearance date")]
		public DateTime? M3_CCDT => GetNullableDateTime("CCDT");

		/// <summary>
		/// Description: Export code - supplier
		/// FieldName: EXCD
		/// FieldType: A
		/// Length: 60
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Export code - supplier")]
		public string M3_EXCD => GetString("EXCD");

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
	}
}
// EOF
