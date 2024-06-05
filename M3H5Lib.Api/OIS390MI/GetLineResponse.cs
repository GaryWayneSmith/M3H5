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

namespace M3H5Lib.Api.OIS390MI
{
	public partial class GetLineResponse : M3BaseRecord 
	{

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
		/// Description: Receiving number
		/// FieldName: REPN
		/// FieldType: N
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Receiving number")]
		public long? M3_REPN => GetNullableLong("REPN");

		/// <summary>
		/// Description: Line number
		/// FieldName: RELI
		/// FieldType: N
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Line number")]
		public int? M3_RELI => GetNullableInt("RELI");

		/// <summary>
		/// Description: Facility
		/// FieldName: FACI
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Facility")]
		public string M3_FACI => GetString("FACI");

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
		/// Description: Status - customer order return
		/// FieldName: REST
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Status - customer order return")]
		public string M3_REST => GetString("REST");

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
		/// Description: Location
		/// FieldName: WHSL
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Location")]
		public string M3_WHSL => GetString("WHSL");

		/// <summary>
		/// Description: Lot number
		/// FieldName: BANO
		/// FieldType: A
		/// Length: 20
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Lot number")]
		public string M3_BANO => GetString("BANO");

		/// <summary>
		/// Description: Inspection officer
		/// FieldName: RPA5
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Inspection officer")]
		public string M3_RPA5 => GetString("RPA5");

		/// <summary>
		/// Description: Return date
		/// FieldName: EPDT
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Return date")]
		public DateTime? M3_EPDT => GetNullableDateTime("EPDT");

		/// <summary>
		/// Description: Advised quantity
		/// FieldName: REQ0
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Advised quantity")]
		public decimal? M3_REQ0 => GetNullableDecimal("REQ0");

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
		/// Description: Inspection quantity
		/// FieldName: REQ2
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Inspection quantity")]
		public decimal? M3_REQ2 => GetNullableDecimal("REQ2");

		/// <summary>
		/// Description: Approved quantity
		/// FieldName: REQ3
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Approved quantity")]
		public decimal? M3_REQ3 => GetNullableDecimal("REQ3");

		/// <summary>
		/// Description: Returned to supplier
		/// FieldName: REQ4
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Returned to supplier")]
		public decimal? M3_REQ4 => GetNullableDecimal("REQ4");

		/// <summary>
		/// Description: Returned to customer
		/// FieldName: REQ5
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Returned to customer")]
		public decimal? M3_REQ5 => GetNullableDecimal("REQ5");

		/// <summary>
		/// Description: Rejected quantity
		/// FieldName: REQ6
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Rejected quantity")]
		public decimal? M3_REQ6 => GetNullableDecimal("REQ6");

		/// <summary>
		/// Description: Credited quantity
		/// FieldName: REQ7
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Credited quantity")]
		public decimal? M3_REQ7 => GetNullableDecimal("REQ7");

		/// <summary>
		/// Description: Repairable quantity
		/// FieldName: REQ8
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Repairable quantity")]
		public decimal? M3_REQ8 => GetNullableDecimal("REQ8");

		/// <summary>
		/// Description: Sales price
		/// FieldName: SAPR
		/// FieldType: N
		/// Length: 19
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Sales price")]
		public decimal? M3_SAPR => GetNullableDecimal("SAPR");

		/// <summary>
		/// Description: Cost price
		/// FieldName: UCOS
		/// FieldType: N
		/// Length: 19
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Cost price")]
		public decimal? M3_UCOS => GetNullableDecimal("UCOS");

		/// <summary>
		/// Description: Transaction reason
		/// FieldName: RSCD
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Transaction reason")]
		public string M3_RSCD => GetString("RSCD");

		/// <summary>
		/// Description: Status - credit
		/// FieldName: CRES
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Status - credit")]
		public int? M3_CRES => GetNullableInt("CRES");

		/// <summary>
		/// Description: Inventory accounting
		/// FieldName: STCD
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Inventory accounting")]
		public int? M3_STCD => GetNullableInt("STCD");

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
		/// Description: Catch weight
		/// FieldName: CAWE
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Catch weight")]
		public decimal? M3_CAWE => GetNullableDecimal("CAWE");

		/// <summary>
		/// Description: Catch weight for credit
		/// FieldName: CAW2
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Catch weight for credit")]
		public decimal? M3_CAW2 => GetNullableDecimal("CAW2");

		/// <summary>
		/// Description: Lot reference 1
		/// FieldName: BREF
		/// FieldType: A
		/// Length: 20
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Lot reference 1")]
		public string M3_BREF => GetString("BREF");

		/// <summary>
		/// Description: Lot reference 2
		/// FieldName: BRE2
		/// FieldType: A
		/// Length: 20
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Lot reference 2")]
		public string M3_BRE2 => GetString("BRE2");

		/// <summary>
		/// Description: Product text
		/// FieldName: PRTX
		/// FieldType: A
		/// Length: 30
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Product text")]
		public string M3_PRTX => GetString("PRTX");

		/// <summary>
		/// Description: Text identity
		/// FieldName: POTX
		/// FieldType: N
		/// Length: 13
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Text identity")]
		public decimal? M3_POTX => GetNullableDecimal("POTX");

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
		/// Description: Line type
		/// FieldName: LTYP
		/// FieldType: A
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Line type")]
		public string M3_LTYP => GetString("LTYP");

		/// <summary>
		/// Description: Sales price quantity
		/// FieldName: SACD
		/// FieldType: N
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Sales price quantity")]
		public int? M3_SACD => GetNullableInt("SACD");

		/// <summary>
		/// Description: Internal transfer price
		/// FieldName: INPR
		/// FieldType: N
		/// Length: 19
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Internal transfer price")]
		public decimal? M3_INPR => GetNullableDecimal("INPR");

		/// <summary>
		/// Description: Internal transfer currency
		/// FieldName: CUCT
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Internal transfer currency")]
		public string M3_CUCT => GetString("CUCT");

		/// <summary>
		/// Description: Product number highest level
		/// FieldName: PRHL
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Product number highest level")]
		public string M3_PRHL => GetString("PRHL");

		/// <summary>
		/// Description: Serial number
		/// FieldName: SERN
		/// FieldType: A
		/// Length: 20
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Serial number")]
		public string M3_SERN => GetString("SERN");

		/// <summary>
		/// Description: Agreement number
		/// FieldName: CTNO
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Agreement number")]
		public string M3_CTNO => GetString("CTNO");

		/// <summary>
		/// Description: Material price method
		/// FieldName: APBA
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Material price method")]
		public int? M3_APBA => GetNullableInt("APBA");

		/// <summary>
		/// Description: Configuration position
		/// FieldName: CFGL
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Configuration position")]
		public string M3_CFGL => GetString("CFGL");

		/// <summary>
		/// Description: Granted warranty type
		/// FieldName: GWTP
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Granted warranty type")]
		public string M3_GWTP => GetString("GWTP");

		/// <summary>
		/// Description: Warranty type
		/// FieldName: WATP
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Warranty type")]
		public string M3_WATP => GetString("WATP");

		/// <summary>
		/// Description: Agreement number
		/// FieldName: AGNB
		/// FieldType: A
		/// Length: 7
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Agreement number")]
		public string M3_AGNB => GetString("AGNB");

		/// <summary>
		/// Description: Agreement number
		/// FieldName: CTNS
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Agreement number")]
		public string M3_CTNS => GetString("CTNS");

		/// <summary>
		/// Description: Attribute number
		/// FieldName: ATNR
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Attribute number")]
		public decimal? M3_ATNR => GetNullableDecimal("ATNR");

		/// <summary>
		/// Description: Tax exemption contract number
		/// FieldName: TECN
		/// FieldType: A
		/// Length: 20
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Tax exemption contract number")]
		public string M3_TECN => GetString("TECN");

		/// <summary>
		/// Description: Industry Application
		/// FieldName: INAP
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Industry Application")]
		public string M3_INAP => GetString("INAP");

		/// <summary>
		/// Description: Basic unit of measure
		/// FieldName: UNMS
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Basic unit of measure")]
		public string M3_UNMS => GetString("UNMS");

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
		/// Description: Sales price in local currency
		/// FieldName: CUPR
		/// FieldType: N
		/// Length: 19
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Sales price in local currency")]
		public decimal? M3_CUPR => GetNullableDecimal("CUPR");

		/// <summary>
		/// Description: Reference order category
		/// FieldName: RORC
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Reference order category")]
		public int? M3_RORC => GetNullableInt("RORC");
	}
}
// EOF
