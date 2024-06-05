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

namespace M3H5Lib.Api.CRS610MI
{
	public partial class LstByNameResponse : M3BaseRecord 
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
		/// Description: Language
		/// FieldName: LNCD
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Language")]
		public string M3_LNCD => GetString("LNCD");

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
		/// Description: Customer name
		/// FieldName: CUNM
		/// FieldType: A
		/// Length: 36
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Customer name")]
		public string M3_CUNM => GetString("CUNM");

		/// <summary>
		/// Description: Customer address 1
		/// FieldName: CUA1
		/// FieldType: A
		/// Length: 36
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Customer address 1")]
		public string M3_CUA1 => GetString("CUA1");

		/// <summary>
		/// Description: Customer address 2
		/// FieldName: CUA2
		/// FieldType: A
		/// Length: 36
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Customer address 2")]
		public string M3_CUA2 => GetString("CUA2");

		/// <summary>
		/// Description: Customer address 3
		/// FieldName: CUA3
		/// FieldType: A
		/// Length: 36
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Customer address 3")]
		public string M3_CUA3 => GetString("CUA3");

		/// <summary>
		/// Description: Customer address 4
		/// FieldName: CUA4
		/// FieldType: A
		/// Length: 36
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Customer address 4")]
		public string M3_CUA4 => GetString("CUA4");

		/// <summary>
		/// Description: Postal code
		/// FieldName: PONO
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Postal code")]
		public string M3_PONO => GetString("PONO");

		/// <summary>
		/// Description: Telephone number 1
		/// FieldName: PHNO
		/// FieldType: A
		/// Length: 16
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Telephone number 1")]
		public string M3_PHNO => GetString("PHNO");

		/// <summary>
		/// Description: Telephone number 2
		/// FieldName: PHN2
		/// FieldType: A
		/// Length: 16
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Telephone number 2")]
		public string M3_PHN2 => GetString("PHN2");

		/// <summary>
		/// Description: Facsimile number
		/// FieldName: TFNO
		/// FieldType: A
		/// Length: 16
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Facsimile number")]
		public string M3_TFNO => GetString("TFNO");

		/// <summary>
		/// Description: Customer type
		/// FieldName: CUTP
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Customer type")]
		public int? M3_CUTP => GetNullableInt("CUTP");

		/// <summary>
		/// Description: Search key
		/// FieldName: ALCU
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Search key")]
		public string M3_ALCU => GetString("ALCU");

		/// <summary>
		/// Description: Your reference 1
		/// FieldName: YREF
		/// FieldType: A
		/// Length: 30
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Your reference 1")]
		public string M3_YREF => GetString("YREF");

		/// <summary>
		/// Description: Your reference 2
		/// FieldName: YRE2
		/// FieldType: A
		/// Length: 30
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Your reference 2")]
		public string M3_YRE2 => GetString("YRE2");

		/// <summary>
		/// Description: E-mail address
		/// FieldName: MAIL
		/// FieldType: A
		/// Length: 50
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("E-mail address")]
		public string M3_MAIL => GetString("MAIL");

		/// <summary>
		/// Description: Country code
		/// FieldName: CSCD
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Country code")]
		public string M3_CSCD => GetString("CSCD");

		/// <summary>
		/// Description: Area/state
		/// FieldName: ECAR
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Area/state")]
		public string M3_ECAR => GetString("ECAR");

		/// <summary>
		/// Description: Organization number 1
		/// FieldName: CORG
		/// FieldType: A
		/// Length: 11
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Organization number 1")]
		public string M3_CORG => GetString("CORG");

		/// <summary>
		/// Description: Organization number 2
		/// FieldName: COR2
		/// FieldType: A
		/// Length: 11
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Organization number 2")]
		public string M3_COR2 => GetString("COR2");

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
		/// Description: VAT code
		/// FieldName: VTCD
		/// FieldType: N
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("VAT code")]
		public int? M3_VTCD => GetNullableInt("VTCD");

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
		/// Description: Credit limit 1 - max overdue invoices
		/// FieldName: CRLM
		/// FieldType: N
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Credit limit 1 - max overdue invoices")]
		public decimal? M3_CRLM => GetNullableDecimal("CRLM");

		/// <summary>
		/// Description: Credit limit 2 - max out.invoices
		/// FieldName: CRL2
		/// FieldType: N
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Credit limit 2 - max out.invoices")]
		public decimal? M3_CRL2 => GetNullableDecimal("CRL2");

		/// <summary>
		/// Description: Credit limit 3 - max out.invoices + ord.
		/// FieldName: CRL3
		/// FieldType: N
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Credit limit 3 - max out.invoices + ord.")]
		public decimal? M3_CRL3 => GetNullableDecimal("CRL3");

		/// <summary>
		/// Description: Credit limit 4 - max days on invoices
		/// FieldName: ODUD
		/// FieldType: N
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Credit limit 4 - max days on invoices")]
		public int? M3_ODUD => GetNullableInt("ODUD");

		/// <summary>
		/// Description: Overdue invoice amount
		/// FieldName: TDIN
		/// FieldType: N
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Overdue invoice amount")]
		public decimal? M3_TDIN => GetNullableDecimal("TDIN");

		/// <summary>
		/// Description: Insurance company
		/// FieldName: INCO
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Insurance company")]
		public string M3_INCO => GetString("INCO");

		/// <summary>
		/// Description: Insurance number
		/// FieldName: INSN
		/// FieldType: A
		/// Length: 20
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Insurance number")]
		public string M3_INSN => GetString("INSN");

		/// <summary>
		/// Description: Insurance limit
		/// FieldName: INLI
		/// FieldType: N
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Insurance limit")]
		public decimal? M3_INLI => GetNullableDecimal("INLI");

		/// <summary>
		/// Description: Payer - post giro
		/// FieldName: AGPY
		/// FieldType: A
		/// Length: 18
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Payer - post giro")]
		public string M3_AGPY => GetString("AGPY");

		/// <summary>
		/// Description: Clearing number -  post giro
		/// FieldName: AGCP
		/// FieldType: A
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Clearing number -  post giro")]
		public string M3_AGCP => GetString("AGCP");

		/// <summary>
		/// Description: Account number - post giro
		/// FieldName: AGAC
		/// FieldType: A
		/// Length: 12
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Account number - post giro")]
		public string M3_AGAC => GetString("AGAC");

		/// <summary>
		/// Description: Payer - bank giro
		/// FieldName: AGBP
		/// FieldType: A
		/// Length: 18
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Payer - bank giro")]
		public string M3_AGBP => GetString("AGBP");

		/// <summary>
		/// Description: Clearing number - bank giro
		/// FieldName: ACLB
		/// FieldType: A
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Clearing number - bank giro")]
		public string M3_ACLB => GetString("ACLB");

		/// <summary>
		/// Description: Account number - bank giro
		/// FieldName: AACB
		/// FieldType: A
		/// Length: 12
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Account number - bank giro")]
		public string M3_AACB => GetString("AACB");

		/// <summary>
		/// Description: Bank giro number
		/// FieldName: AGBG
		/// FieldType: N
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Bank giro number")]
		public long? M3_AGBG => GetNullableLong("AGBG");

		/// <summary>
		/// Description: Post giro number
		/// FieldName: AGPG
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Post giro number")]
		public string M3_AGPG => GetString("AGPG");

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
		/// Description: Our reference
		/// FieldName: OREF
		/// FieldType: A
		/// Length: 30
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Our reference")]
		public string M3_OREF => GetString("OREF");

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
		/// Description: District
		/// FieldName: SDST
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("District")]
		public string M3_SDST => GetString("SDST");

		/// <summary>
		/// Description: Customer order type
		/// FieldName: ORTP
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Customer order type")]
		public string M3_ORTP => GetString("ORTP");

		/// <summary>
		/// Description: Service model
		/// FieldName: EXCD
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Service model")]
		public string M3_EXCD => GetString("EXCD");

		/// <summary>
		/// Description: Charge model
		/// FieldName: CHSY
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Charge model")]
		public string M3_CHSY => GetString("CHSY");

		/// <summary>
		/// Description: Term of delivery
		/// FieldName: TEDL
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Term of delivery")]
		public string M3_TEDL => GetString("TEDL");

		/// <summary>
		/// Description: Delivery method
		/// FieldName: MODL
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Delivery method")]
		public string M3_MODL => GetString("MODL");

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
		/// Description: Discount model
		/// FieldName: DISY
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Discount model")]
		public string M3_DISY => GetString("DISY");

		/// <summary>
		/// Description: Discount group - customer
		/// FieldName: DIGC
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Discount group - customer")]
		public string M3_DIGC => GetString("DIGC");

		/// <summary>
		/// Description: Discount - percentage
		/// FieldName: DIPC
		/// FieldType: N
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Discount - percentage")]
		public int? M3_DIPC => GetNullableInt("DIPC");

		/// <summary>
		/// Description: Place-replaced by EDE2
		/// FieldName: EDES
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Place-replaced by EDE2")]
		public string M3_EDES => GetString("EDES");

		/// <summary>
		/// Description: Commission group
		/// FieldName: PRVG
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Commission group")]
		public string M3_PRVG => GetString("PRVG");

		/// <summary>
		/// Description: Bonus group
		/// FieldName: BGRP
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Bonus group")]
		public string M3_BGRP => GetString("BGRP");

		/// <summary>
		/// Description: Term of payment
		/// FieldName: TEPY
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Term of payment")]
		public string M3_TEPY => GetString("TEPY");

		/// <summary>
		/// Description: free field 1
		/// FieldName: CFC1
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("free field 1")]
		public string M3_CFC1 => GetString("CFC1");

		/// <summary>
		/// Description: Free field 2
		/// FieldName: CFC2
		/// FieldType: N
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Free field 2")]
		public decimal? M3_CFC2 => GetNullableDecimal("CFC2");

		/// <summary>
		/// Description: Free field 3
		/// FieldName: CFC3
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Free field 3")]
		public string M3_CFC3 => GetString("CFC3");

		/// <summary>
		/// Description: Free field 4
		/// FieldName: CFC4
		/// FieldType: A
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Free field 4")]
		public string M3_CFC4 => GetString("CFC4");

		/// <summary>
		/// Description: Free field 5
		/// FieldName: CFC5
		/// FieldType: A
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Free field 5")]
		public string M3_CFC5 => GetString("CFC5");

		/// <summary>
		/// Description: Free field 6
		/// FieldName: CFC6
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Free field 6")]
		public string M3_CFC6 => GetString("CFC6");

		/// <summary>
		/// Description: Free field 7
		/// FieldName: CFC7
		/// FieldType: N
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Free field 7")]
		public decimal? M3_CFC7 => GetNullableDecimal("CFC7");

		/// <summary>
		/// Description: Free field 8
		/// FieldName: CFC8
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Free field 8")]
		public string M3_CFC8 => GetString("CFC8");

		/// <summary>
		/// Description: Free field 9
		/// FieldName: CFC9
		/// FieldType: A
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Free field 9")]
		public string M3_CFC9 => GetString("CFC9");

		/// <summary>
		/// Description: Free field 10
		/// FieldName: CFC0
		/// FieldType: A
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Free field 10")]
		public string M3_CFC0 => GetString("CFC0");

		/// <summary>
		/// Description: SMS id
		/// FieldName: CESA
		/// FieldType: A
		/// Length: 32
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("SMS id")]
		public string M3_CESA => GetString("CESA");

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
		/// Description: Customer status
		/// FieldName: STAT
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Customer status")]
		public string M3_STAT => GetString("STAT");

		/// <summary>
		/// Description: Invoicing group
		/// FieldName: IVGP
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Invoicing group")]
		public string M3_IVGP => GetString("IVGP");

		/// <summary>
		/// Description: Quotation check
		/// FieldName: QUCK
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Quotation check")]
		public int? M3_QUCK => GetNullableInt("QUCK");

		/// <summary>
		/// Description: Tax applicable
		/// FieldName: TXAP
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Tax applicable")]
		public int? M3_TXAP => GetNullableInt("TXAP");

		/// <summary>
		/// Description: Place
		/// FieldName: EDE2
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Place")]
		public string M3_EDE2 => GetString("EDE2");

		/// <summary>
		/// Description: Ship-via
		/// FieldName: ADVI
		/// FieldType: A
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Ship-via")]
		public string M3_ADVI => GetString("ADVI");

		/// <summary>
		/// Description: City
		/// FieldName: TOWN
		/// FieldType: A
		/// Length: 20
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("City")]
		public string M3_TOWN => GetString("TOWN");

		/// <summary>
		/// Description: County ID
		/// FieldName: FRCO
		/// FieldType: A
		/// Length: 7
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("County ID")]
		public string M3_FRCO => GetString("FRCO");

		/// <summary>
		/// Description: Statistics customer
		/// FieldName: CUST
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Statistics customer")]
		public string M3_CUST => GetString("CUST");
	}
}
// EOF
