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

namespace M3H5Lib.Api.XBR001MI
{
	public partial class LstCustInvLinesResponse : M3BaseRecord 
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
		/// Description: Line suffix
		/// FieldName: NOIF
		/// FieldType: A
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Line suffix")]
		public string M3NOIF => GetString("NOIF");

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
		/// Description: Item number
		/// FieldName: ITNO
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Item number")]
		public string M3ITNO => GetString("ITNO");

		/// <summary>
		/// Description: Item name
		/// FieldName: ITDS
		/// FieldType: A
		/// Length: 30
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Item name")]
		public string M3ITDS => GetString("ITDS");

		/// <summary>
		/// Description: Internal CFOP Code
		/// FieldName: ICFO
		/// FieldType: A
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Internal CFOP Code")]
		public string M3ICFO => GetString("ICFO");

		/// <summary>
		/// Description: CFOP
		/// FieldName: CFOP
		/// FieldType: A
		/// Length: 4
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("CFOP")]
		public string M3CFOP => GetString("CFOP");

		/// <summary>
		/// Description: ICMS tribute code
		/// FieldName: XCCS
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("ICMS tribute code")]
		public string M3XCCS => GetString("XCCS");

		/// <summary>
		/// Description: Classificacao Fiscal
		/// FieldName: CFIS
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Classificacao Fiscal")]
		public string M3CFIS => GetString("CFIS");

		/// <summary>
		/// Description: Invoiced quantity - sales price U/M
		/// FieldName: IVQS
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Invoiced quantity - sales price U/M")]
		public decimal? M3IVQS => GetNullableDecimal("IVQS");

		/// <summary>
		/// Description: Basic unit of measure
		/// FieldName: SQUN
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Basic unit of measure")]
		public string M3SQUN => GetString("SQUN");

		/// <summary>
		/// Description: Sales price unit of measure
		/// FieldName: SPUN
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Sales price unit of measure")]
		public string M3SPUN => GetString("SPUN");

		/// <summary>
		/// Description: % IPI
		/// FieldName: PIPI
		/// FieldType: N
		/// Length: 7
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("% IPI")]
		public int? M3PIPI => GetNullableInt("PIPI");

		/// <summary>
		/// Description: % ICMS
		/// FieldName: PICM
		/// FieldType: N
		/// Length: 7
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("% ICMS")]
		public int? M3PICM => GetNullableInt("PICM");

		/// <summary>
		/// Description: % tax subst
		/// FieldName: ASTR
		/// FieldType: N
		/// Length: 7
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("% tax subst")]
		public int? M3ASTR => GetNullableInt("ASTR");

		/// <summary>
		/// Description: % ISS
		/// FieldName: CISS
		/// FieldType: N
		/// Length: 7
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("% ISS")]
		public int? M3CISS => GetNullableInt("CISS");

		/// <summary>
		/// Description: % IRRF
		/// FieldName: IRRF
		/// FieldType: N
		/// Length: 7
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("% IRRF")]
		public int? M3IRRF => GetNullableInt("IRRF");

		/// <summary>
		/// Description: % PIS
		/// FieldName: XPI1
		/// FieldType: N
		/// Length: 7
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("% PIS")]
		public int? M3XPI1 => GetNullableInt("XPI1");

		/// <summary>
		/// Description: COFINS percentage
		/// FieldName: XPCO
		/// FieldType: N
		/// Length: 7
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("COFINS percentage")]
		public int? M3XPCO => GetNullableInt("XPCO");

		/// <summary>
		/// Description: Insurance amount overdue
		/// FieldName: FL06
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Insurance amount overdue")]
		public int? M3FL06 => GetNullableInt("FL06");

		/// <summary>
		/// Description: Returned quantity
		/// FieldName: REQ1
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Returned quantity")]
		public decimal? M3REQ1 => GetNullableDecimal("REQ1");

		/// <summary>
		/// Description: Invoice amount - local currency
		/// FieldName: IVAM
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Invoice amount - local currency")]
		public decimal? M3IVAM => GetNullableDecimal("IVAM");

		/// <summary>
		/// Description: Invoice amount - local currency
		/// FieldName: IVLA
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Invoice amount - local currency")]
		public decimal? M3IVLA => GetNullableDecimal("IVLA");

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
		/// Description: NF-e key
		/// FieldName: RKEY
		/// FieldType: A
		/// Length: 44
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("NF-e key")]
		public string M3RKEY => GetString("RKEY");

		/// <summary>
		/// Description: Issuer IBGE UF code
		/// FieldName: RCFU
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Issuer IBGE UF code")]
		public string M3RCFU => GetString("RCFU");

		/// <summary>
		/// Description: Year
		/// FieldName: RAME
		/// FieldType: N
		/// Length: 4
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Year")]
		public int? M3RAME => GetNullableInt("RAME");

		/// <summary>
		/// Description: Issuer CNPJ code
		/// FieldName: RCNP
		/// FieldType: A
		/// Length: 14
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Issuer CNPJ code")]
		public string M3RCNP => GetString("RCNP");

		/// <summary>
		/// Description: Referenced Document modell
		/// FieldName: RMOD
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Referenced Document modell")]
		public string M3RMOD => GetString("RMOD");

		/// <summary>
		/// Description: Referenced Document series
		/// FieldName: RSER
		/// FieldType: A
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Referenced Document series")]
		public string M3RSER => GetString("RSER");

		/// <summary>
		/// Description: Referenced Document number
		/// FieldName: RNDF
		/// FieldType: A
		/// Length: 9
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Referenced Document number")]
		public string M3RNDF => GetString("RNDF");

		/// <summary>
		/// Description: DI item
		/// FieldName: ADNR
		/// FieldType: N
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("DI item")]
		public int? M3ADNR => GetNullableInt("ADNR");

		/// <summary>
		/// Description: Line number
		/// FieldName: ADLN
		/// FieldType: N
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Line number")]
		public int? M3ADLN => GetNullableInt("ADLN");

		/// <summary>
		/// Description: Foreign maker code
		/// FieldName: FMCD
		/// FieldType: A
		/// Length: 60
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Foreign maker code")]
		public string M3FMCD => GetString("FMCD");

		/// <summary>
		/// Description: Discount value
		/// FieldName: ADDV
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Discount value")]
		public decimal? M3ADDV => GetNullableDecimal("ADDV");

		/// <summary>
		/// Description: Customers order number
		/// FieldName: CUOR
		/// FieldType: A
		/// Length: 20
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Customers order number")]
		public string M3CUOR => GetString("CUOR");

		/// <summary>
		/// Description: Line number
		/// FieldName: CUPO
		/// FieldType: N
		/// Length: 7
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Line number")]
		public int? M3CUPO => GetNullableInt("CUPO");

		/// <summary>
		/// Description: Withheld ICMS ST base amount
		/// FieldName: WSTB
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Withheld ICMS ST base amount")]
		public decimal? M3WSTB => GetNullableDecimal("WSTB");

		/// <summary>
		/// Description: Withheld ICMS ST amount
		/// FieldName: WSTV
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Withheld ICMS ST amount")]
		public decimal? M3WSTV => GetNullableDecimal("WSTV");
	}
}
// EOF
