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
	public partial class EXPORTSMSResponse : M3BaseRecord 
	{

		/// <summary>
		/// Description: Record type
		/// FieldName: TPRE
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Record type")]
		public string M3TPRE => GetString("TPRE");

		/// <summary>
		/// Description: Option
		/// FieldName: OPT2
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Option")]
		public string M3OPT2 => GetString("OPT2");

		/// <summary>
		/// Description: Marketing ID - Movex SMS
		/// FieldName: CESA
		/// FieldType: A
		/// Length: 32
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Marketing ID - Movex SMS")]
		public string M3CESA => GetString("CESA");

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
		/// Description: Organization number 1
		/// FieldName: CORG
		/// FieldType: A
		/// Length: 11
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Organization number 1")]
		public string M3CORG => GetString("CORG");

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
		/// Description: Address
		/// FieldName: SMAD
		/// FieldType: A
		/// Length: 80
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Address")]
		public string M3SMAD => GetString("SMAD");

		/// <summary>
		/// Description: Postal code
		/// FieldName: PONO
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Postal code")]
		public string M3PONO => GetString("PONO");

		/// <summary>
		/// Description: City
		/// FieldName: SMCI
		/// FieldType: A
		/// Length: 24
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("City")]
		public string M3SMCI => GetString("SMCI");

		/// <summary>
		/// Description: County
		/// FieldName: SMCO
		/// FieldType: A
		/// Length: 36
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("County")]
		public string M3SMCO => GetString("SMCO");

		/// <summary>
		/// Description: Area/state
		/// FieldName: ECAR
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Area/state")]
		public string M3ECAR => GetString("ECAR");

		/// <summary>
		/// Description: Country
		/// FieldName: CSCD
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Country")]
		public string M3CSCD => GetString("CSCD");

		/// <summary>
		/// Description: Telephone number 1
		/// FieldName: PHNO
		/// FieldType: A
		/// Length: 16
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Telephone number 1")]
		public string M3PHNO => GetString("PHNO");

		/// <summary>
		/// Description: Facsimile transmission number
		/// FieldName: TFNO
		/// FieldType: A
		/// Length: 16
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Facsimile transmission number")]
		public string M3TFNO => GetString("TFNO");

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
		/// Description: Business area
		/// FieldName: BUAR
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Business area")]
		public string M3BUAR => GetString("BUAR");

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
		/// Description: Delivery terms
		/// FieldName: TEDL
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Delivery terms")]
		public string M3TEDL => GetString("TEDL");

		/// <summary>
		/// Description: Credit limit 1
		/// FieldName: CRLM
		/// FieldType: N
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Credit limit 1")]
		public decimal? M3CRLM => GetNullableDecimal("CRLM");

		/// <summary>
		/// Description: Credit limit 2
		/// FieldName: CRL2
		/// FieldType: N
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Credit limit 2")]
		public decimal? M3CRL2 => GetNullableDecimal("CRL2");

		/// <summary>
		/// Description: Credit limit 3
		/// FieldName: CRL3
		/// FieldType: N
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Credit limit 3")]
		public decimal? M3CRL3 => GetNullableDecimal("CRL3");

		/// <summary>
		/// Description: Credit limit 4
		/// FieldName: ODUD
		/// FieldType: N
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Credit limit 4")]
		public int? M3ODUD => GetNullableInt("ODUD");

		/// <summary>
		/// Description: Order value not invoiced
		/// FieldName: TBLG
		/// FieldType: N
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Order value not invoiced")]
		public decimal? M3TBLG => GetNullableDecimal("TBLG");

		/// <summary>
		/// Description: Outstanding invoice amount
		/// FieldName: TOIN
		/// FieldType: N
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Outstanding invoice amount")]
		public decimal? M3TOIN => GetNullableDecimal("TOIN");

		/// <summary>
		/// Description: Overdue invoice amount
		/// FieldName: TDIN
		/// FieldType: N
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Overdue invoice amount")]
		public decimal? M3TDIN => GetNullableDecimal("TDIN");

		/// <summary>
		/// Description: Last invoice date
		/// FieldName: LIDT
		/// FieldType: D
		/// Length: 8
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Last invoice date")]
		public DateTime? M3LIDT => GetNullableDateTime("LIDT");

		/// <summary>
		/// Description: User-defined field 1 - customer
		/// FieldName: CFC1
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("User-defined field 1 - customer")]
		public string M3CFC1 => GetString("CFC1");

		/// <summary>
		/// Description: User-defined field 2 - customer
		/// FieldName: CFC2
		/// FieldType: N
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("User-defined field 2 - customer")]
		public decimal? M3CFC2 => GetNullableDecimal("CFC2");

		/// <summary>
		/// Description: User-defined field 3 - customer
		/// FieldName: CFC3
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("User-defined field 3 - customer")]
		public string M3CFC3 => GetString("CFC3");

		/// <summary>
		/// Description: User-defined field 4 - customer
		/// FieldName: CFC4
		/// FieldType: A
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("User-defined field 4 - customer")]
		public string M3CFC4 => GetString("CFC4");

		/// <summary>
		/// Description: User-defined field 5 - customer
		/// FieldName: CFC5
		/// FieldType: A
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("User-defined field 5 - customer")]
		public string M3CFC5 => GetString("CFC5");

		/// <summary>
		/// Description: User-defined field 6 - customer
		/// FieldName: CFC6
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("User-defined field 6 - customer")]
		public string M3CFC6 => GetString("CFC6");

		/// <summary>
		/// Description: User-defined field 7 - customer
		/// FieldName: CFC7
		/// FieldType: N
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("User-defined field 7 - customer")]
		public decimal? M3CFC7 => GetNullableDecimal("CFC7");

		/// <summary>
		/// Description: User-defined field 8 - customer
		/// FieldName: CFC8
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("User-defined field 8 - customer")]
		public string M3CFC8 => GetString("CFC8");

		/// <summary>
		/// Description: User-defined field 9 - customer
		/// FieldName: CFC9
		/// FieldType: A
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("User-defined field 9 - customer")]
		public string M3CFC9 => GetString("CFC9");

		/// <summary>
		/// Description: User-defined field 10 - customer
		/// FieldName: CFC0
		/// FieldType: A
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("User-defined field 10 - customer")]
		public string M3CFC0 => GetString("CFC0");

		/// <summary>
		/// Description: Entry date
		/// FieldName: RGDT
		/// FieldType: D
		/// Length: 8
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Entry date")]
		public DateTime? M3RGDT => GetNullableDateTime("RGDT");

		/// <summary>
		/// Description: Change date
		/// FieldName: LMDT
		/// FieldType: D
		/// Length: 8
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Change date")]
		public DateTime? M3LMDT => GetNullableDateTime("LMDT");

		/// <summary>
		/// Description: Search key
		/// FieldName: ALCU
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Search key")]
		public string M3ALCU => GetString("ALCU");

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
		/// Description: Customer type
		/// FieldName: CUTP
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Customer type")]
		public int? M3CUTP => GetNullableInt("CUTP");

		/// <summary>
		/// Description: Customer address 4
		/// FieldName: CUA4
		/// FieldType: A
		/// Length: 36
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Customer address 4")]
		public string M3CUA4 => GetString("CUA4");
	}
}
// EOF
