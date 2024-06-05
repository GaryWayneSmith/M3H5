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

namespace M3H5Lib.Api.CRS610MI
{
	public partial class GetOrderInfoResponse : M3BaseRecord 
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
		/// Description: Language
		/// FieldName: LNCD
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Language")]
		public string M3LNCD => GetString("LNCD");

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
		/// Description: Customer name
		/// FieldName: CUNM
		/// FieldType: A
		/// Length: 36
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Customer name")]
		public string M3CUNM => GetString("CUNM");

		/// <summary>
		/// Description: Customer group
		/// FieldName: CUCL
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Customer group")]
		public string M3CUCL => GetString("CUCL");

		/// <summary>
		/// Description: Our reference
		/// FieldName: OREF
		/// FieldType: A
		/// Length: 30
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Our reference")]
		public string M3OREF => GetString("OREF");

		/// <summary>
		/// Description: Salesperson
		/// FieldName: SMCD
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Salesperson")]
		public string M3SMCD => GetString("SMCD");

		/// <summary>
		/// Description: District
		/// FieldName: SDST
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("District")]
		public string M3SDST => GetString("SDST");

		/// <summary>
		/// Description: Customer order type
		/// FieldName: ORTP
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Customer order type")]
		public string M3ORTP => GetString("ORTP");

		/// <summary>
		/// Description: Service model
		/// FieldName: EXCD
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Service model")]
		public string M3EXCD => GetString("EXCD");

		/// <summary>
		/// Description: Charge model
		/// FieldName: CHSY
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Charge model")]
		public string M3CHSY => GetString("CHSY");

		/// <summary>
		/// Description: Term of delivery
		/// FieldName: TEDL
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Term of delivery")]
		public string M3TEDL => GetString("TEDL");

		/// <summary>
		/// Description: Delivery method
		/// FieldName: MODL
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Delivery method")]
		public string M3MODL => GetString("MODL");

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
		/// Description: Discount model
		/// FieldName: DISY
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Discount model")]
		public string M3DISY => GetString("DISY");

		/// <summary>
		/// Description: Discount group - customer
		/// FieldName: DIGC
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Discount group - customer")]
		public string M3DIGC => GetString("DIGC");

		/// <summary>
		/// Description: Discount - percentage
		/// FieldName: DIPC
		/// FieldType: N
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Discount - percentage")]
		public int? M3DIPC => GetNullableInt("DIPC");

		/// <summary>
		/// Description: Place-replaced by EDE2
		/// FieldName: EDES
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Place-replaced by EDE2")]
		public string M3EDES => GetString("EDES");

		/// <summary>
		/// Description: Commission group
		/// FieldName: PRVG
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Commission group")]
		public string M3PRVG => GetString("PRVG");

		/// <summary>
		/// Description: Bonus group
		/// FieldName: BGRP
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Bonus group")]
		public string M3BGRP => GetString("BGRP");

		/// <summary>
		/// Description: Term of payment
		/// FieldName: TEPY
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Term of payment")]
		public string M3TEPY => GetString("TEPY");

		/// <summary>
		/// Description: Payer
		/// FieldName: PYNO
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Payer")]
		public string M3PYNO => GetString("PYNO");

		/// <summary>
		/// Description: Change date for customer
		/// FieldName: LMDT
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Change date for customer")]
		public DateTime? M3LMDT => GetNullableDateTime("LMDT");

		/// <summary>
		/// Description: Invoicing group
		/// FieldName: IVGP
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Invoicing group")]
		public string M3IVGP => GetString("IVGP");

		/// <summary>
		/// Description: Place
		/// FieldName: EDE2
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Place")]
		public string M3EDE2 => GetString("EDE2");

		/// <summary>
		/// Description: Address number
		/// FieldName: ADID
		/// FieldType: A
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Address number")]
		public string M3ADID => GetString("ADID");

		/// <summary>
		/// Description: Price list table
		/// FieldName: PLTB
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Price list table")]
		public string M3PLTB => GetString("PLTB");

		/// <summary>
		/// Description: Summary invoice
		/// FieldName: AICD
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Summary invoice")]
		public int? M3AICD => GetNullableInt("AICD");

		/// <summary>
		/// Description: Bonus/Commission Active
		/// FieldName: BUSE
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Bonus/Commission Active")]
		public int? M3BUSE => GetNullableInt("BUSE");

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
		/// Description: Assortment check
		/// FieldName: ACHK
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Assortment check")]
		public int? M3ACHK => GetNullableInt("ACHK");

		/// <summary>
		/// Description: Ship-via
		/// FieldName: ADVI
		/// FieldType: A
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Ship-via")]
		public string M3ADVI => GetString("ADVI");

		/// <summary>
		/// Description: Statistic identity 1 customer
		/// FieldName: FRE1
		/// FieldType: A
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Statistic identity 1 customer")]
		public string M3FRE1 => GetString("FRE1");

		/// <summary>
		/// Description: Statistic identity 2 customer
		/// FieldName: FRE2
		/// FieldType: A
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Statistic identity 2 customer")]
		public string M3FRE2 => GetString("FRE2");

		/// <summary>
		/// Description: Customer document group
		/// FieldName: DOGR
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Customer document group")]
		public string M3DOGR => GetString("DOGR");

		/// <summary>
		/// Description: Separate invoices
		/// FieldName: ADBO
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Separate invoices")]
		public int? M3ADBO => GetNullableInt("ADBO");

		/// <summary>
		/// Description: VAT included
		/// FieldName: TINC
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("VAT included")]
		public int? M3TINC => GetNullableInt("TINC");

		/// <summary>
		/// Description: Responsible
		/// FieldName: RESP
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Responsible")]
		public string M3RESP => GetString("RESP");

		/// <summary>
		/// Description: Statistics customer
		/// FieldName: CUST
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Statistics customer")]
		public string M3CUST => GetString("CUST");

		/// <summary>
		/// Description: Packaging terms
		/// FieldName: TEPA
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Packaging terms")]
		public string M3TEPA => GetString("TEPA");

		/// <summary>
		/// Description: Priority
		/// FieldName: PRIO
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Priority")]
		public int? M3PRIO => GetNullableInt("PRIO");

		/// <summary>
		/// Description: User-defined accounting control object
		/// FieldName: ACRF
		/// FieldType: A
		/// Length: 8
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("User-defined accounting control object")]
		public string M3ACRF => GetString("ACRF");

		/// <summary>
		/// Description: Agreement check - order header
		/// FieldName: AGCH
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Agreement check - order header")]
		public int? M3AGCH => GetNullableInt("AGCH");

		/// <summary>
		/// Description: Agreement check - order lines
		/// FieldName: AGCT
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Agreement check - order lines")]
		public int? M3AGCT => GetNullableInt("AGCT");

		/// <summary>
		/// Description: Unloading zone
		/// FieldName: ULZO
		/// FieldType: A
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Unloading zone")]
		public string M3ULZO => GetString("ULZO");

		/// <summary>
		/// Description: Labor code - trade statistics (TST)
		/// FieldName: ECLC
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Labor code - trade statistics (TST)")]
		public string M3ECLC => GetString("ECLC");

		/// <summary>
		/// Description: Group invoice
		/// FieldName: GRPY
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Group invoice")]
		public int? M3GRPY => GetNullableInt("GRPY");

		/// <summary>
		/// Description: Alias category
		/// FieldName: ALWT
		/// FieldType: N
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Alias category")]
		public int? M3ALWT => GetNullableInt("ALWT");

		/// <summary>
		/// Description: Alias number
		/// FieldName: POPN
		/// FieldType: A
		/// Length: 30
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Alias number")]
		public string M3POPN => GetString("POPN");

		/// <summary>
		/// Description: Print delivery information
		/// FieldName: PRDL
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Print delivery information")]
		public int? M3PRDL => GetNullableInt("PRDL");

		/// <summary>
		/// Description: CO number mandatory
		/// FieldName: MCOS
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("CO number mandatory")]
		public int? M3MCOS => GetNullableInt("MCOS");

		/// <summary>
		/// Description: Backorder
		/// FieldName: BCKO
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Backorder")]
		public int? M3BCKO => GetNullableInt("BCKO");

		/// <summary>
		/// Description: Partial delivery
		/// FieldName: PADL
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Partial delivery")]
		public int? M3PADL => GetNullableInt("PADL");

		/// <summary>
		/// Description: Delivery regrouping
		/// FieldName: SCED
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Delivery regrouping")]
		public int? M3SCED => GetNullableInt("SCED");

		/// <summary>
		/// Description: Automatic closing
		/// FieldName: BOP1
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Automatic closing")]
		public int? M3BOP1 => GetNullableInt("BOP1");
	}
}
// EOF
