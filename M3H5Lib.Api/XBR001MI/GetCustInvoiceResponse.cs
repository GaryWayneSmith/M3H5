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
		/// Description: Invoice prefix
		/// FieldName: INPX
		/// FieldType: A
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Invoice prefix")]
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
		/// Description: Invoice series
		/// FieldName: OT34
		/// FieldType: A
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Invoice series")]
		public string M3OT34 => GetString("OT34");

		/// <summary>
		/// Description: Customer number
		/// FieldName: CUNO
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Customer number")]
		public string M3CUNO => GetString("CUNO");

		/// <summary>
		/// Description: Entry date
		/// FieldName: DTEM
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Entry date")]
		public string M3DTEM => GetString("DTEM");

		/// <summary>
		/// Description: Invoice delete date
		/// FieldName: XDDT
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Invoice delete date")]
		public DateTime? M3XDDT => GetNullableDateTime("XDDT");

		/// <summary>
		/// Description: Forwarding agent
		/// FieldName: TRAN
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Forwarding agent")]
		public string M3TRAN => GetString("TRAN");

		/// <summary>
		/// Description: Invoice source
		/// FieldName: XIVS
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Invoice source")]
		public int? M3XIVS => GetNullableInt("XIVS");

		/// <summary>
		/// Description: Gross goods value
		/// FieldName: VLTM
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Gross goods value")]
		public decimal? M3VLTM => GetNullableDecimal("VLTM");

		/// <summary>
		/// Description: Discount amount 1
		/// FieldName: DIA1
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Discount amount 1")]
		public decimal? M3DIA1 => GetNullableDecimal("DIA1");

		/// <summary>
		/// Description: Discount amount 2
		/// FieldName: DIA2
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Discount amount 2")]
		public decimal? M3DIA2 => GetNullableDecimal("DIA2");

		/// <summary>
		/// Description: Discount amount 3
		/// FieldName: DIA3
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Discount amount 3")]
		public decimal? M3DIA3 => GetNullableDecimal("DIA3");

		/// <summary>
		/// Description: Discount amount 4
		/// FieldName: DIA4
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Discount amount 4")]
		public decimal? M3DIA4 => GetNullableDecimal("DIA4");

		/// <summary>
		/// Description: Discount amount 5
		/// FieldName: DIA5
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Discount amount 5")]
		public decimal? M3DIA5 => GetNullableDecimal("DIA5");

		/// <summary>
		/// Description: Discount amount 6
		/// FieldName: DIA6
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Discount amount 6")]
		public decimal? M3DIA6 => GetNullableDecimal("DIA6");

		/// <summary>
		/// Description: Net goods value
		/// FieldName: NTVM
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Net goods value")]
		public decimal? M3NTVM => GetNullableDecimal("NTVM");

		/// <summary>
		/// Description: Freight amount
		/// FieldName: VLFR
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Freight amount")]
		public decimal? M3VLFR => GetNullableDecimal("VLFR");

		/// <summary>
		/// Description: Insurance amount
		/// FieldName: HFN5
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Insurance amount")]
		public decimal? M3HFN5 => GetNullableDecimal("HFN5");

		/// <summary>
		/// Description: Other expenses
		/// FieldName: HFN6
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Other expenses")]
		public decimal? M3HFN6 => GetNullableDecimal("HFN6");

		/// <summary>
		/// Description: IPI base calculation
		/// FieldName: VBIP
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("IPI base calculation")]
		public decimal? M3VBIP => GetNullableDecimal("VBIP");

		/// <summary>
		/// Description: ICMS base
		/// FieldName: VBIC
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("ICMS base")]
		public decimal? M3VBIC => GetNullableDecimal("VBIC");

		/// <summary>
		/// Description: Tax subst amount
		/// FieldName: VSBT
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Tax subst amount")]
		public decimal? M3VSBT => GetNullableDecimal("VSBT");

		/// <summary>
		/// Description: IPI amount
		/// FieldName: VIPI
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("IPI amount")]
		public decimal? M3VIPI => GetNullableDecimal("VIPI");

		/// <summary>
		/// Description: ICMS amount
		/// FieldName: VICM
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("ICMS amount")]
		public decimal? M3VICM => GetNullableDecimal("VICM");

		/// <summary>
		/// Description: ICMS tax sub amount
		/// FieldName: VLST
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("ICMS tax sub amount")]
		public decimal? M3VLST => GetNullableDecimal("VLST");

		/// <summary>
		/// Description: IPI not tributed amount
		/// FieldName: INIP
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("IPI not tributed amount")]
		public decimal? M3INIP => GetNullableDecimal("INIP");

		/// <summary>
		/// Description: ICMS not tributed amount
		/// FieldName: INIC
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("ICMS not tributed amount")]
		public decimal? M3INIC => GetNullableDecimal("INIC");

		/// <summary>
		/// Description: IPI other amount
		/// FieldName: OUIP
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("IPI other amount")]
		public decimal? M3OUIP => GetNullableDecimal("OUIP");

		/// <summary>
		/// Description: ICMS other amount
		/// FieldName: OUIC
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("ICMS other amount")]
		public decimal? M3OUIC => GetNullableDecimal("OUIC");

		/// <summary>
		/// Description: Gross service amount
		/// FieldName: VLTS
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Gross service amount")]
		public decimal? M3VLTS => GetNullableDecimal("VLTS");

		/// <summary>
		/// Description: Net service amount
		/// FieldName: VLNS
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Net service amount")]
		public decimal? M3VLNS => GetNullableDecimal("VLNS");

		/// <summary>
		/// Description: IRRF amount
		/// FieldName: VIRR
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("IRRF amount")]
		public decimal? M3VIRR => GetNullableDecimal("VIRR");

		/// <summary>
		/// Description: ISS amount
		/// FieldName: VISS
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("ISS amount")]
		public decimal? M3VISS => GetNullableDecimal("VISS");

		/// <summary>
		/// Description: PIS base
		/// FieldName: BPIS
		/// FieldType: A
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("PIS base")]
		public string M3BPIS => GetString("BPIS");

		/// <summary>
		/// Description: COFINS base
		/// FieldName: BCOF
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("COFINS base")]
		public decimal? M3BCOF => GetNullableDecimal("BCOF");

		/// <summary>
		/// Description: PIS amount
		/// FieldName: VPIS
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("PIS amount")]
		public decimal? M3VPIS => GetNullableDecimal("VPIS");

		/// <summary>
		/// Description: COFINS amount
		/// FieldName: VCOF
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("COFINS amount")]
		public decimal? M3VCOF => GetNullableDecimal("VCOF");

		/// <summary>
		/// Description: Invoice total amount
		/// FieldName: VLNT
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Invoice total amount")]
		public decimal? M3VLNT => GetNullableDecimal("VLNT");

		/// <summary>
		/// Description: Stopped customers
		/// FieldName: FL01
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Stopped customers")]
		public int? M3FL01 => GetNullableInt("FL01");

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
		/// Description: Extended invoice number
		/// FieldName: EXIN
		/// FieldType: A
		/// Length: 14
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Extended invoice number")]
		public string M3EXIN => GetString("EXIN");

		/// <summary>
		/// Description: NF-e Id
		/// FieldName: NFEI
		/// FieldType: A
		/// Length: 44
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("NF-e Id")]
		public string M3NFEI => GetString("NFEI");

		/// <summary>
		/// Description: NF-e type
		/// FieldName: NFYP
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("NF-e type")]
		public int? M3NFYP => GetNullableInt("NFYP");

		/// <summary>
		/// Description: Receipt number
		/// FieldName: RCPN
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Receipt number")]
		public string M3RCPN => GetString("RCPN");

		/// <summary>
		/// Description: Return status
		/// FieldName: RTNS
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Return status")]
		public string M3RTNS => GetString("RTNS");

		/// <summary>
		/// Description: invoice status
		/// FieldName: INST
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("invoice status")]
		public string M3INST => GetString("INST");

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
		/// Description: Invoice type
		/// FieldName: XITY
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Invoice type")]
		public int? M3XITY => GetNullableInt("XITY");

		/// <summary>
		/// Description: Recipient pays
		/// FieldName: RCPY
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Recipient pays")]
		public int? M3RCPY => GetNullableInt("RCPY");

		/// <summary>
		/// Description: Split due date
		/// FieldName: EFYN
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Split due date")]
		public int? M3EFYN => GetNullableInt("EFYN");

		/// <summary>
		/// Description: Import document number DI/DSI/DA
		/// FieldName: DINR
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Import document number DI/DSI/DA")]
		public string M3DINR => GetString("DINR");

		/// <summary>
		/// Description: DI/DSI/DA date
		/// FieldName: DIDT
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("DI/DSI/DA date")]
		public DateTime? M3DIDT => GetNullableDateTime("DIDT");

		/// <summary>
		/// Description: Customs house location
		/// FieldName: CHLC
		/// FieldType: A
		/// Length: 60
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Customs house location")]
		public string M3CHLC => GetString("CHLC");

		/// <summary>
		/// Description: Customs house UF code
		/// FieldName: CHUF
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Customs house UF code")]
		public string M3CHUF => GetString("CHUF");

		/// <summary>
		/// Description: Customs clearance date
		/// FieldName: CCDT
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Customs clearance date")]
		public DateTime? M3CCDT => GetNullableDateTime("CCDT");

		/// <summary>
		/// Description: Export code - supplier
		/// FieldName: EXCD
		/// FieldType: A
		/// Length: 60
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Export code - supplier")]
		public string M3EXCD => GetString("EXCD");

		/// <summary>
		/// Description: Voucher text
		/// FieldName: VTXT
		/// FieldType: A
		/// Length: 40
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Voucher text")]
		public string M3VTXT => GetString("VTXT");
	}
}
// EOF
