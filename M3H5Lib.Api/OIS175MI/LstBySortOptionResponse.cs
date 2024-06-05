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

namespace M3H5Lib.Api.OIS175MI
{
	public partial class LstBySortOptionResponse : M3BaseRecord 
	{

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
		/// Description: Highest status - customer order
		/// FieldName: ORST
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Highest status - customer order")]
		public string M3ORST => GetString("ORST");

		/// <summary>
		/// Description: Lowest status - customer order
		/// FieldName: ORSL
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Lowest status - customer order")]
		public string M3ORSL => GetString("ORSL");

		/// <summary>
		/// Description: Business chain - level 1
		/// FieldName: CHL1
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Business chain - level 1")]
		public string M3CHL1 => GetString("CHL1");

		/// <summary>
		/// Description: Business chain - level 2
		/// FieldName: CHL2
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Business chain - level 2")]
		public string M3CHL2 => GetString("CHL2");

		/// <summary>
		/// Description: Business chain - level 3
		/// FieldName: CHL3
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Business chain - level 3")]
		public string M3CHL3 => GetString("CHL3");

		/// <summary>
		/// Description: Business chain - level 4
		/// FieldName: CHL4
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Business chain - level 4")]
		public string M3CHL4 => GetString("CHL4");

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
		/// Description: Order date
		/// FieldName: ORDT
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Order date")]
		public DateTime? M3ORDT => GetNullableDateTime("ORDT");

		/// <summary>
		/// Description: Customer´s purchase order date
		/// FieldName: CUDT
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Customer´s purchase order date")]
		public DateTime? M3CUDT => GetNullableDateTime("CUDT");

		/// <summary>
		/// Description: Requested delivery date
		/// FieldName: RLDT
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Requested delivery date")]
		public DateTime? M3RLDT => GetNullableDateTime("RLDT");

		/// <summary>
		/// Description: Requested delivery time
		/// FieldName: RLHM
		/// FieldType: N
		/// Length: 4
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Requested delivery time")]
		public int? M3RLHM => GetNullableInt("RLHM");

		/// <summary>
		/// Description: Requested delivery date
		/// FieldName: RLDZ
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Requested delivery date")]
		public DateTime? M3RLDZ => GetNullableDateTime("RLDZ");

		/// <summary>
		/// Description: Requested delivery time
		/// FieldName: RLHZ
		/// FieldType: N
		/// Length: 4
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Requested delivery time")]
		public int? M3RLHZ => GetNullableInt("RLHZ");

		/// <summary>
		/// Description: Manual due date
		/// FieldName: DMDT
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Manual due date")]
		public DateTime? M3DMDT => GetNullableDateTime("DMDT");

		/// <summary>
		/// Description: Value date
		/// FieldName: CURD
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Value date")]
		public DateTime? M3CURD => GetNullableDateTime("CURD");

		/// <summary>
		/// Description: Earliest delivery date
		/// FieldName: FDDT
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Earliest delivery date")]
		public DateTime? M3FDDT => GetNullableDateTime("FDDT");

		/// <summary>
		/// Description: Priority
		/// FieldName: OPRI
		/// FieldType: N
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Priority")]
		public int? M3OPRI => GetNullableInt("OPRI");

		/// <summary>
		/// Description: Summary invoice
		/// FieldName: AICD
		/// FieldType: N
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Summary invoice")]
		public int? M3AICD => GetNullableInt("AICD");

		/// <summary>
		/// Description: Customer order stop
		/// FieldName: OBLC
		/// FieldType: N
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Customer order stop")]
		public int? M3OBLC => GetNullableInt("OBLC");

		/// <summary>
		/// Description: EU triangular trade
		/// FieldName: ECTT
		/// FieldType: N
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("EU triangular trade")]
		public int? M3ECTT => GetNullableInt("ECTT");

		/// <summary>
		/// Description: Update order received statistics
		/// FieldName: OT38
		/// FieldType: N
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Update order received statistics")]
		public int? M3OT38 => GetNullableInt("OT38");

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
		/// Description: Cash discount term
		/// FieldName: TECD
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Cash discount term")]
		public string M3TECD => GetString("TECD");

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
		/// Description: Terms text
		/// FieldName: TEL2
		/// FieldType: A
		/// Length: 36
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Terms text")]
		public string M3TEL2 => GetString("TEL2");

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
		/// Description: Quotation number
		/// FieldName: OFNO
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Quotation number")]
		public string M3OFNO => GetString("OFNO");

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
		/// Description: Your reference 1
		/// FieldName: YREF
		/// FieldType: A
		/// Length: 30
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Your reference 1")]
		public string M3YREF => GetString("YREF");

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
		/// Description: Project number
		/// FieldName: PROJ
		/// FieldType: A
		/// Length: 7
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Project number")]
		public string M3PROJ => GetString("PROJ");

		/// <summary>
		/// Description: Project element
		/// FieldName: ELNO
		/// FieldType: A
		/// Length: 8
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Project element")]
		public string M3ELNO => GetString("ELNO");

		/// <summary>
		/// Description: Contact method
		/// FieldName: WCON
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Contact method")]
		public string M3WCON => GetString("WCON");

		/// <summary>
		/// Description: Business type - trade statistics (TST)
		/// FieldName: VRCD
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Business type - trade statistics (TST)")]
		public string M3VRCD => GetString("VRCD");

		/// <summary>
		/// Description: Statistics identity 1 customer
		/// FieldName: FRE1
		/// FieldType: A
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Statistics identity 1 customer")]
		public string M3FRE1 => GetString("FRE1");

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
		/// Description: Invoice recipient
		/// FieldName: INRC
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Invoice recipient")]
		public string M3INRC => GetString("INRC");

		/// <summary>
		/// Description: Blanket agreement number
		/// FieldName: AGNO
		/// FieldType: A
		/// Length: 7
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Blanket agreement number")]
		public string M3AGNO => GetString("AGNO");

		/// <summary>
		/// Description: Customer - blanket agreement
		/// FieldName: BAGC
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Customer - blanket agreement")]
		public string M3BAGC => GetString("BAGC");

		/// <summary>
		/// Description: Start date - blanket agreement
		/// FieldName: BAGD
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Start date - blanket agreement")]
		public DateTime? M3BAGD => GetNullableDateTime("BAGD");

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
		/// Description: Service charge
		/// FieldName: EXCD
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Service charge")]
		public string M3EXCD => GetString("EXCD");

		/// <summary>
		/// Description: VAT included
		/// FieldName: TINC
		/// FieldType: N
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("VAT included")]
		public int? M3TINC => GetNullableInt("TINC");

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
		/// Description: Local currency
		/// FieldName: LOCD
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Local currency")]
		public string M3LOCD => GetString("LOCD");

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
		/// Description: Number of decimal places
		/// FieldName: DCCD
		/// FieldType: N
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Number of decimal places")]
		public int? M3DCCD => GetNullableInt("DCCD");

		/// <summary>
		/// Description: Exchange rate type
		/// FieldName: CRTP
		/// FieldType: N
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Exchange rate type")]
		public int? M3CRTP => GetNullableInt("CRTP");

		/// <summary>
		/// Description: Future rate agreement number
		/// FieldName: FECN
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Future rate agreement number")]
		public string M3FECN => GetString("FECN");

		/// <summary>
		/// Description: Exchange rate
		/// FieldName: ARAT
		/// FieldType: N
		/// Length: 12
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Exchange rate")]
		public decimal? M3ARAT => GetNullableDecimal("ARAT");

		/// <summary>
		/// Description: Currency conversion method
		/// FieldName: DMCU
		/// FieldType: N
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Currency conversion method")]
		public int? M3DMCU => GetNullableInt("DMCU");

		/// <summary>
		/// Description: Recipient agreement type 9 - bonus
		/// FieldName: BREC
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Recipient agreement type 9 - bonus")]
		public string M3BREC => GetString("BREC");

		/// <summary>
		/// Description: Recipient agreement type 1 - commission
		/// FieldName: AGNT
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Recipient agreement type 1 - commission")]
		public string M3AGNT => GetString("AGNT");

		/// <summary>
		/// Description: Gross weight
		/// FieldName: GRWE
		/// FieldType: N
		/// Length: 11
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Gross weight")]
		public decimal? M3GRWE => GetNullableDecimal("GRWE");

		/// <summary>
		/// Description: Net weight
		/// FieldName: NEWE
		/// FieldType: N
		/// Length: 11
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Net weight")]
		public decimal? M3NEWE => GetNullableDecimal("NEWE");

		/// <summary>
		/// Description: Volume
		/// FieldName: VOL3
		/// FieldType: N
		/// Length: 11
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Volume")]
		public decimal? M3VOL3 => GetNullableDecimal("VOL3");

		/// <summary>
		/// Description: Total order cost
		/// FieldName: COAM
		/// FieldType: N
		/// Length: 19
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Total order cost")]
		public decimal? M3COAM => GetNullableDecimal("COAM");

		/// <summary>
		/// Description: Order value gross
		/// FieldName: BRAM
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Order value gross")]
		public decimal? M3BRAM => GetNullableDecimal("BRAM");

		/// <summary>
		/// Description: Total order value gross
		/// FieldName: BRLA
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Total order value gross")]
		public decimal? M3BRLA => GetNullableDecimal("BRLA");

		/// <summary>
		/// Description: Net order value
		/// FieldName: NTAM
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Net order value")]
		public decimal? M3NTAM => GetNullableDecimal("NTAM");

		/// <summary>
		/// Description: Total order value net
		/// FieldName: NTLA
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Total order value net")]
		public decimal? M3NTLA => GetNullableDecimal("NTLA");

		/// <summary>
		/// Description: Remains to invoice in advance
		/// FieldName: RPIV
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Remains to invoice in advance")]
		public decimal? M3RPIV => GetNullableDecimal("RPIV");

		/// <summary>
		/// Description: Advance invoiced amount
		/// FieldName: IPIV
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Advance invoiced amount")]
		public decimal? M3IPIV => GetNullableDecimal("IPIV");

		/// <summary>
		/// Description: Order total discount generating amount
		/// FieldName: OTBA
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Order total discount generating amount")]
		public decimal? M3OTBA => GetNullableDecimal("OTBA");

		/// <summary>
		/// Description: Order total discount - percentage
		/// FieldName: OTDP
		/// FieldType: N
		/// Length: 14
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Order total discount - percentage")]
		public decimal? M3OTDP => GetNullableDecimal("OTDP");

		/// <summary>
		/// Description: Discount origin
		/// FieldName: DICD
		/// FieldType: N
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Discount origin")]
		public int? M3DICD => GetNullableInt("DICD");

		/// <summary>
		/// Description: Discount campaign
		/// FieldName: CMPN
		/// FieldType: A
		/// Length: 4
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Discount campaign")]
		public string M3CMPN => GetString("CMPN");

		/// <summary>
		/// Description: Total price
		/// FieldName: TOPR
		/// FieldType: N
		/// Length: 18
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Total price")]
		public decimal? M3TOPR => GetNullableDecimal("TOPR");

		/// <summary>
		/// Description: Number of noninventory order lines
		/// FieldName: NBNS
		/// FieldType: N
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Number of noninventory order lines")]
		public int? M3NBNS => GetNullableInt("NBNS");

		/// <summary>
		/// Description: Order entry in progress
		/// FieldName: HOCD
		/// FieldType: N
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Order entry in progress")]
		public int? M3HOCD => GetNullableInt("HOCD");

		/// <summary>
		/// Description: Line charge model
		/// FieldName: CHSY
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Line charge model")]
		public string M3CHSY => GetString("CHSY");

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
		/// Description: Customs procedure - export
		/// FieldName: CPRE
		/// FieldType: A
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Customs procedure - export")]
		public string M3CPRE => GetString("CPRE");

		/// <summary>
		/// Description: Harbor or airport
		/// FieldName: HAFE
		/// FieldType: A
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Harbor or airport")]
		public string M3HAFE => GetString("HAFE");

		/// <summary>
		/// Description: Tax code
		/// FieldName: TAXC
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Tax code")]
		public string M3TAXC => GetString("TAXC");

		/// <summary>
		/// Description: Job name
		/// FieldName: JNA
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Job name")]
		public string M3JNA => GetString("JNA");

		/// <summary>
		/// Description: Job number
		/// FieldName: JNU
		/// FieldType: N
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Job number")]
		public int? M3JNU => GetNullableInt("JNU");

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
		/// Description: Pre text identity
		/// FieldName: PRTX
		/// FieldType: N
		/// Length: 13
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Pre text identity")]
		public decimal? M3PRTX => GetNullableDecimal("PRTX");

		/// <summary>
		/// Description: Post text identity
		/// FieldName: POTX
		/// FieldType: N
		/// Length: 13
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Post text identity")]
		public decimal? M3POTX => GetNullableDecimal("POTX");

		/// <summary>
		/// Description: Data identity
		/// FieldName: DTID
		/// FieldType: N
		/// Length: 13
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Data identity")]
		public decimal? M3DTID => GetNullableDecimal("DTID");

		/// <summary>
		/// Description: Route
		/// FieldName: ROUT
		/// FieldType: A
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Route")]
		public string M3ROUT => GetString("ROUT");

		/// <summary>
		/// Description: Route departure
		/// FieldName: RODN
		/// FieldType: N
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Route departure")]
		public int? M3RODN => GetNullableInt("RODN");

		/// <summary>
		/// Description: Delivery specification
		/// FieldName: DLSP
		/// FieldType: A
		/// Length: 12
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Delivery specification")]
		public string M3DLSP => GetString("DLSP");

		/// <summary>
		/// Description: Description
		/// FieldName: DSTX
		/// FieldType: A
		/// Length: 36
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Description")]
		public string M3DSTX => GetString("DSTX");

		/// <summary>
		/// Description: Entry date
		/// FieldName: RGDT
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Entry date")]
		public DateTime? M3RGDT => GetNullableDateTime("RGDT");

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
		/// Description: Customer address 1
		/// FieldName: CUA1
		/// FieldType: A
		/// Length: 36
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Customer address 1")]
		public string M3CUA1 => GetString("CUA1");

		/// <summary>
		/// Description: Customer address 2
		/// FieldName: CUA2
		/// FieldType: A
		/// Length: 36
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Customer address 2")]
		public string M3CUA2 => GetString("CUA2");

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
		/// Description: Rail station
		/// FieldName: RASN
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Rail station")]
		public string M3RASN => GetString("RASN");
	}
}
// EOF
