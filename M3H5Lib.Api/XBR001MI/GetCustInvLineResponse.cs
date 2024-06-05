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
	public partial class GetCustInvLineResponse : M3BaseRecord 
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
		/// Description: Line suffix
		/// FieldName: NOIF
		/// FieldType: A
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Line suffix")]
		public string M3_NOIF => GetString("NOIF");

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
		/// Description: Invoice reference
		/// FieldName: IVRF
		/// FieldType: A
		/// Length: 30
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Invoice reference")]
		public string M3_IVRF => GetString("IVRF");

		/// <summary>
		/// Description: Customer order number
		/// FieldName: ORNO
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Customer order number")]
		public string M3_ORNO => GetString("ORNO");

		/// <summary>
		/// Description: Line number
		/// FieldName: PONR
		/// FieldType: N
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Line number")]
		public int? M3_PONR => GetNullableInt("PONR");

		/// <summary>
		/// Description: Line suffix
		/// FieldName: POSX
		/// FieldType: N
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Line suffix")]
		public int? M3_POSX => GetNullableInt("POSX");

		/// <summary>
		/// Description: Delivery number
		/// FieldName: DLIX
		/// FieldType: N
		/// Length: 11
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Delivery number")]
		public decimal? M3_DLIX => GetNullableDecimal("DLIX");

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
		/// Description: Item number
		/// FieldName: ITNO
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Item number")]
		public string M3_ITNO => GetString("ITNO");

		/// <summary>
		/// Description: Item name
		/// FieldName: ITDS
		/// FieldType: A
		/// Length: 30
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Item name")]
		public string M3_ITDS => GetString("ITDS");

		/// <summary>
		/// Description: Internal CFOP Code
		/// FieldName: ICFO
		/// FieldType: A
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Internal CFOP Code")]
		public string M3_ICFO => GetString("ICFO");

		/// <summary>
		/// Description: CFOP
		/// FieldName: CFOP
		/// FieldType: A
		/// Length: 4
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("CFOP")]
		public string M3_CFOP => GetString("CFOP");

		/// <summary>
		/// Description: ICMS tribute code
		/// FieldName: XCCS
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("ICMS tribute code")]
		public string M3_XCCS => GetString("XCCS");

		/// <summary>
		/// Description: Classificacao Fiscal
		/// FieldName: CFIS
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Classificacao Fiscal")]
		public string M3_CFIS => GetString("CFIS");

		/// <summary>
		/// Description: Invoiced quantity - sales price U/M
		/// FieldName: IVQS
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Invoiced quantity - sales price U/M")]
		public decimal? M3_IVQS => GetNullableDecimal("IVQS");

		/// <summary>
		/// Description: Basic unit of measure
		/// FieldName: SQUN
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Basic unit of measure")]
		public string M3_SQUN => GetString("SQUN");

		/// <summary>
		/// Description: Sales price unit of measure
		/// FieldName: SPUN
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Sales price unit of measure")]
		public string M3_SPUN => GetString("SPUN");

		/// <summary>
		/// Description: % IPI
		/// FieldName: PIPI
		/// FieldType: N
		/// Length: 7
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("% IPI")]
		public int? M3_PIPI => GetNullableInt("PIPI");

		/// <summary>
		/// Description: % ICMS
		/// FieldName: PICM
		/// FieldType: N
		/// Length: 7
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("% ICMS")]
		public int? M3_PICM => GetNullableInt("PICM");

		/// <summary>
		/// Description: % tax subst
		/// FieldName: ASTR
		/// FieldType: N
		/// Length: 7
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("% tax subst")]
		public int? M3_ASTR => GetNullableInt("ASTR");

		/// <summary>
		/// Description: % ISS
		/// FieldName: CISS
		/// FieldType: N
		/// Length: 7
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("% ISS")]
		public int? M3_CISS => GetNullableInt("CISS");

		/// <summary>
		/// Description: % IRRF
		/// FieldName: IRRF
		/// FieldType: N
		/// Length: 7
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("% IRRF")]
		public int? M3_IRRF => GetNullableInt("IRRF");

		/// <summary>
		/// Description: % PIS
		/// FieldName: XPI1
		/// FieldType: N
		/// Length: 7
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("% PIS")]
		public int? M3_XPI1 => GetNullableInt("XPI1");

		/// <summary>
		/// Description: COFINS percentage
		/// FieldName: XPCO
		/// FieldType: N
		/// Length: 7
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("COFINS percentage")]
		public int? M3_XPCO => GetNullableInt("XPCO");

		/// <summary>
		/// Description: Insurance amount overdue
		/// FieldName: FL06
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Insurance amount overdue")]
		public int? M3_FL06 => GetNullableInt("FL06");

		/// <summary>
		/// Description: Returned quantity
		/// FieldName: REQ1
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Returned quantity")]
		public decimal? M3_REQ1 => GetNullableDecimal("REQ1");

		/// <summary>
		/// Description: Invoice amount - local currency
		/// FieldName: IVAM
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Invoice amount - local currency")]
		public decimal? M3_IVAM => GetNullableDecimal("IVAM");

		/// <summary>
		/// Description: Invoice amount - local currency
		/// FieldName: IVLA
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Invoice amount - local currency")]
		public decimal? M3_IVLA => GetNullableDecimal("IVLA");

		/// <summary>
		/// Description: Warehouse
		/// FieldName: WHLO
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Warehouse")]
		public string M3_WHLO => GetString("WHLO");

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
		/// Description: NF-e key
		/// FieldName: RKEY
		/// FieldType: A
		/// Length: 44
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("NF-e key")]
		public string M3_RKEY => GetString("RKEY");

		/// <summary>
		/// Description: Issuer IBGE FU code
		/// FieldName: RCFU
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Issuer IBGE FU code")]
		public string M3_RCFU => GetString("RCFU");

		/// <summary>
		/// Description: Year
		/// FieldName: RAME
		/// FieldType: N
		/// Length: 4
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Year")]
		public int? M3_RAME => GetNullableInt("RAME");

		/// <summary>
		/// Description: Issuer CNPJ code
		/// FieldName: RCNP
		/// FieldType: A
		/// Length: 14
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Issuer CNPJ code")]
		public string M3_RCNP => GetString("RCNP");

		/// <summary>
		/// Description: Referenced Document model
		/// FieldName: RMOD
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Referenced Document model")]
		public string M3_RMOD => GetString("RMOD");

		/// <summary>
		/// Description: Referenced Document series
		/// FieldName: RSER
		/// FieldType: A
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Referenced Document series")]
		public string M3_RSER => GetString("RSER");

		/// <summary>
		/// Description: Referenced Document number
		/// FieldName: RNDF
		/// FieldType: A
		/// Length: 9
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Referenced Document number")]
		public string M3_RNDF => GetString("RNDF");

		/// <summary>
		/// Description: DI item
		/// FieldName: ADNR
		/// FieldType: N
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("DI item")]
		public int? M3_ADNR => GetNullableInt("ADNR");

		/// <summary>
		/// Description: Line number
		/// FieldName: ADLN
		/// FieldType: N
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Line number")]
		public int? M3_ADLN => GetNullableInt("ADLN");

		/// <summary>
		/// Description: Foreign maker code
		/// FieldName: FMCD
		/// FieldType: A
		/// Length: 60
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Foreign maker code")]
		public string M3_FMCD => GetString("FMCD");

		/// <summary>
		/// Description: Discount value
		/// FieldName: ADDV
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Discount value")]
		public decimal? M3_ADDV => GetNullableDecimal("ADDV");

		/// <summary>
		/// Description: Customers order number
		/// FieldName: CUOR
		/// FieldType: A
		/// Length: 20
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Customers order number")]
		public string M3_CUOR => GetString("CUOR");

		/// <summary>
		/// Description: Line number
		/// FieldName: CUPO
		/// FieldType: N
		/// Length: 7
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Line number")]
		public int? M3_CUPO => GetNullableInt("CUPO");

		/// <summary>
		/// Description: Withheld ICMS ST bas amount
		/// FieldName: WSTB
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Withheld ICMS ST bas amount")]
		public decimal? M3_WSTB => GetNullableDecimal("WSTB");

		/// <summary>
		/// Description: Withheld ICMS ST amount
		/// FieldName: WSTV
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Withheld ICMS ST amount")]
		public decimal? M3_WSTV => GetNullableDecimal("WSTV");
	}
}
// EOF
