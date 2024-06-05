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

namespace M3H5Lib.Api.GTCN10MI
{
	public partial class LstInvLinesResponse : M3BaseRecord 
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
		/// Description: Item line status
		/// FieldName: XSTS
		/// FieldType: N
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Item line status")]
		public int? M3XSTS => GetNullableInt("XSTS");

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
		/// Description: Invoice reference
		/// FieldName: IVRF
		/// FieldType: A
		/// Length: 30
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Invoice reference")]
		public string M3IVRF => GetString("IVRF");

		/// <summary>
		/// Description: Customer order number
		/// FieldName: ORNO
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Customer order number")]
		public string M3ORNO => GetString("ORNO");

		/// <summary>
		/// Description: Line number
		/// FieldName: PONR
		/// FieldType: N
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Line number")]
		public int? M3PONR => GetNullableInt("PONR");

		/// <summary>
		/// Description: Line suffix
		/// FieldName: POSX
		/// FieldType: N
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Line suffix")]
		public int? M3POSX => GetNullableInt("POSX");

		/// <summary>
		/// Description: Delivery number
		/// FieldName: DLIX
		/// FieldType: N
		/// Length: 11
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Delivery number")]
		public decimal? M3DLIX => GetNullableDecimal("DLIX");

		/// <summary>
		/// Description: Warehouse
		/// FieldName: WHLO
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Warehouse")]
		public string M3WHLO => GetString("WHLO");

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
		/// Length: 13
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Exchange rate")]
		public decimal? M3ARAT => GetNullableDecimal("ARAT");

		/// <summary>
		/// Description: Item number
		/// FieldName: XITO
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Item number")]
		public string M3XITO => GetString("XITO");

		/// <summary>
		/// Description: Item name
		/// FieldName: XITN
		/// FieldType: A
		/// Length: 60
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Item name")]
		public string M3XITN => GetString("XITN");

		/// <summary>
		/// Description: Spec. of item
		/// FieldName: XSPE
		/// FieldType: A
		/// Length: 30
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Spec. of item")]
		public string M3XSPE => GetString("XSPE");

		/// <summary>
		/// Description: Line amount
		/// FieldName: XLAM
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Line amount")]
		public decimal? M3XLAM => GetNullableDecimal("XLAM");

		/// <summary>
		/// Description: Line amount - local currency
		/// FieldName: XLAL
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Line amount - local currency")]
		public decimal? M3XLAL => GetNullableDecimal("XLAL");

		/// <summary>
		/// Description: Net amount
		/// FieldName: XNAM
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Net amount")]
		public decimal? M3XNAM => GetNullableDecimal("XNAM");

		/// <summary>
		/// Description: Net amount - local currency
		/// FieldName: XNAL
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Net amount - local currency")]
		public decimal? M3XNAL => GetNullableDecimal("XNAL");

		/// <summary>
		/// Description: VAT
		/// FieldName: XVTA
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("VAT")]
		public decimal? M3XVTA => GetNullableDecimal("XVTA");

		/// <summary>
		/// Description: VAT - local currency
		/// FieldName: XVTL
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("VAT - local currency")]
		public decimal? M3XVTL => GetNullableDecimal("XVTL");

		/// <summary>
		/// Description: VAT code
		/// FieldName: VTCD
		/// FieldType: N
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("VAT code")]
		public int? M3VTCD => GetNullableInt("VTCD");

		/// <summary>
		/// Description: VAT rate 1
		/// FieldName: VTP1
		/// FieldType: N
		/// Length: 7
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("VAT rate 1")]
		public int? M3VTP1 => GetNullableInt("VTP1");

		/// <summary>
		/// Description: VAT rate 2
		/// FieldName: VTP2
		/// FieldType: N
		/// Length: 7
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("VAT rate 2")]
		public int? M3VTP2 => GetNullableInt("VTP2");

		/// <summary>
		/// Description: VAT registration number internal
		/// FieldName: VRIN
		/// FieldType: A
		/// Length: 16
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("VAT registration number internal")]
		public string M3VRIN => GetString("VRIN");

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
		/// Description: Unit
		/// FieldName: XSPU
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Unit")]
		public string M3XSPU => GetString("XSPU");

		/// <summary>
		/// Description: Unit description
		/// FieldName: XSPD
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Unit description")]
		public string M3XSPD => GetString("XSPD");

		/// <summary>
		/// Description: Type of price
		/// FieldName: XTPR
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Type of price")]
		public int? M3XTPR => GetNullableInt("XTPR");

		/// <summary>
		/// Description: Unit price
		/// FieldName: XUPR
		/// FieldType: N
		/// Length: 19
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Unit price")]
		public decimal? M3XUPR => GetNullableDecimal("XUPR");

		/// <summary>
		/// Description: Unit price - local currency
		/// FieldName: XUPL
		/// FieldType: N
		/// Length: 19
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Unit price - local currency")]
		public decimal? M3XUPL => GetNullableDecimal("XUPL");

		/// <summary>
		/// Description: Quantity
		/// FieldName: XQTY
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Quantity")]
		public decimal? M3XQTY => GetNullableDecimal("XQTY");

		/// <summary>
		/// Description: Discount amount
		/// FieldName: XDAM
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Discount amount")]
		public decimal? M3XDAM => GetNullableDecimal("XDAM");

		/// <summary>
		/// Description: Discount amount - local currency
		/// FieldName: XDLA
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Discount amount - local currency")]
		public decimal? M3XDLA => GetNullableDecimal("XDLA");

		/// <summary>
		/// Description: Discount amount of VAT
		/// FieldName: XDVA
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Discount amount of VAT")]
		public decimal? M3XDVA => GetNullableDecimal("XDVA");

		/// <summary>
		/// Description: Discount amount of VAT - local currency
		/// FieldName: XDVL
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Discount amount of VAT - local currency")]
		public decimal? M3XDVL => GetNullableDecimal("XDVL");

		/// <summary>
		/// Description: Discount rate
		/// FieldName: XDIP
		/// FieldType: N
		/// Length: 8
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Discount rate")]
		public int? M3XDIP => GetNullableInt("XDIP");

		/// <summary>
		/// Description: Discount status
		/// FieldName: XDST
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Discount status")]
		public int? M3XDST => GetNullableInt("XDST");

		/// <summary>
		/// Description: Line charges
		/// FieldName: XLCA
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Line charges")]
		public decimal? M3XLCA => GetNullableDecimal("XLCA");

		/// <summary>
		/// Description: Line charges
		/// FieldName: XLCL
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Line charges")]
		public decimal? M3XLCL => GetNullableDecimal("XLCL");

		/// <summary>
		/// Description: Line charges - VAT
		/// FieldName: XLVA
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Line charges - VAT")]
		public decimal? M3XLVA => GetNullableDecimal("XLVA");

		/// <summary>
		/// Description: Line charges - VAT - local currency
		/// FieldName: XLVL
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Line charges - VAT - local currency")]
		public decimal? M3XLVL => GetNullableDecimal("XLVL");

		/// <summary>
		/// Description: Line charges - status of VAT
		/// FieldName: XLCS
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Line charges - status of VAT")]
		public int? M3XLCS => GetNullableInt("XLCS");

		/// <summary>
		/// Description: Head charges
		/// FieldName: XHCA
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Head charges")]
		public decimal? M3XHCA => GetNullableDecimal("XHCA");

		/// <summary>
		/// Description: Head charges - local currency
		/// FieldName: XHCL
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Head charges - local currency")]
		public decimal? M3XHCL => GetNullableDecimal("XHCL");

		/// <summary>
		/// Description: Head charges - VAT
		/// FieldName: XHVA
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Head charges - VAT")]
		public decimal? M3XHVA => GetNullableDecimal("XHVA");

		/// <summary>
		/// Description: Head charges - VAT -  local currency
		/// FieldName: XHVL
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Head charges - VAT -  local currency")]
		public decimal? M3XHVL => GetNullableDecimal("XHVL");

		/// <summary>
		/// Description: Header charges - status of VAT
		/// FieldName: XHCS
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Header charges - status of VAT")]
		public int? M3XHCS => GetNullableInt("XHCS");

		/// <summary>
		/// Description: Header charges - distribution rate
		/// FieldName: XHCR
		/// FieldType: N
		/// Length: 8
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Header charges - distribution rate")]
		public int? M3XHCR => GetNullableInt("XHCR");

		/// <summary>
		/// Description: Split line
		/// FieldName: XSPL
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Split line")]
		public int? M3XSPL => GetNullableInt("XSPL");

		/// <summary>
		/// Description: Credit invoice
		/// FieldName: XCRI
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Credit invoice")]
		public int? M3XCRI => GetNullableInt("XCRI");

		/// <summary>
		/// Description: Advance invoice distribution rate
		/// FieldName: XAIR
		/// FieldType: N
		/// Length: 8
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Advance invoice distribution rate")]
		public int? M3XAIR => GetNullableInt("XAIR");

		/// <summary>
		/// Description: Advanced invoice - status of VAT
		/// FieldName: XAIS
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Advanced invoice - status of VAT")]
		public int? M3XAIS => GetNullableInt("XAIS");

		/// <summary>
		/// Description: Inv category
		/// FieldName: XIVC
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Inv category")]
		public string M3XIVC => GetString("XIVC");
	}
}
// EOF
