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

namespace M3H5Lib.Api.OIS100MI
{
	public partial class LstLineResponse : M3BaseRecord 
	{

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
		/// Description: Item description
		/// FieldName: ITDS
		/// FieldType: A
		/// Length: 30
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Item description")]
		public string M3ITDS => GetString("ITDS");

		/// <summary>
		/// Description: Ordered quantity
		/// FieldName: ORQT
		/// FieldType: A
		/// Length: 16
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Ordered quantity")]
		public string M3ORQT => GetString("ORQT");

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
		/// Description: Customer order line number
		/// FieldName: CUPO
		/// FieldType: A
		/// Length: 7
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Customer order line number")]
		public string M3CUPO => GetString("CUPO");

		/// <summary>
		/// Description: Requested delivery date
		/// FieldName: DWDT
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Requested delivery date")]
		public DateTime? M3DWDT => GetNullableDateTime("DWDT");

		/// <summary>
		/// Description: Joint delivery code
		/// FieldName: JDCD
		/// FieldType: A
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Joint delivery code")]
		public string M3JDCD => GetString("JDCD");

		/// <summary>
		/// Description: Salesprice
		/// FieldName: SAPR
		/// FieldType: A
		/// Length: 18
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Salesprice")]
		public string M3SAPR => GetString("SAPR");

		/// <summary>
		/// Description: Discount amount 1
		/// FieldName: DIA1
		/// FieldType: A
		/// Length: 16
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Discount amount 1")]
		public string M3DIA1 => GetString("DIA1");

		/// <summary>
		/// Description: Discount amount 2
		/// FieldName: DIA2
		/// FieldType: A
		/// Length: 16
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Discount amount 2")]
		public string M3DIA2 => GetString("DIA2");

		/// <summary>
		/// Description: Discount amount 3
		/// FieldName: DIA3
		/// FieldType: A
		/// Length: 16
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Discount amount 3")]
		public string M3DIA3 => GetString("DIA3");

		/// <summary>
		/// Description: Discount amount 4
		/// FieldName: DIA4
		/// FieldType: A
		/// Length: 16
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Discount amount 4")]
		public string M3DIA4 => GetString("DIA4");

		/// <summary>
		/// Description: Discount amount
		/// FieldName: DIA5
		/// FieldType: A
		/// Length: 16
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Discount amount")]
		public string M3DIA5 => GetString("DIA5");

		/// <summary>
		/// Description: Discount amount 6
		/// FieldName: DIA6
		/// FieldType: A
		/// Length: 16
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Discount amount 6")]
		public string M3DIA6 => GetString("DIA6");

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
		/// Description: Delivery specification text
		/// FieldName: DLSX
		/// FieldType: A
		/// Length: 36
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Delivery specification text")]
		public string M3DLSX => GetString("DLSX");

		/// <summary>
		/// Description: Line number
		/// FieldName: PONR
		/// FieldType: A
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Line number")]
		public string M3PONR => GetString("PONR");

		/// <summary>
		/// Description: Line suffix
		/// FieldName: POSX
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Line suffix")]
		public string M3POSX => GetString("POSX");

		/// <summary>
		/// Description: Highest status - Customer
		/// FieldName: ORST
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Highest status - Customer")]
		public string M3ORST => GetString("ORST");

		/// <summary>
		/// Description: Old CFIN
		/// FieldName: CFXX
		/// FieldType: N
		/// Length: 7
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Old CFIN")]
		public int? M3CFXX => GetNullableInt("CFXX");

		/// <summary>
		/// Description: Simulation number
		/// FieldName: ECVS
		/// FieldType: N
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Simulation number")]
		public int? M3ECVS => GetNullableInt("ECVS");

		/// <summary>
		/// Description: Net line amount
		/// FieldName: NLAM
		/// FieldType: N
		/// Length: 16
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Net line amount")]
		public decimal? M3NLAM => GetNullableDecimal("NLAM");

		/// <summary>
		/// Description: Alternate unit of measurement
		/// FieldName: ALUN
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Alternate unit of measurement")]
		public string M3ALUN => GetString("ALUN");

		/// <summary>
		/// Description: Sales price unit of measurement
		/// FieldName: SPUN
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Sales price unit of measurement")]
		public string M3SPUN => GetString("SPUN");

		/// <summary>
		/// Description: Sales price per alternate U/M
		/// FieldName: SAP2
		/// FieldType: N
		/// Length: 18
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Sales price per alternate U/M")]
		public decimal? M3SAP2 => GetNullableDecimal("SAP2");

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
		/// Description: Alias qualifier
		/// FieldName: ALWQ
		/// FieldType: A
		/// Length: 4
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Alias qualifier")]
		public string M3ALWQ => GetString("ALWQ");

		/// <summary>
		/// Description: Ordered quantity - alternate U/M
		/// FieldName: ORQA
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Ordered quantity - alternate U/M")]
		public decimal? M3ORQA => GetNullableDecimal("ORQA");

		/// <summary>
		/// Description: Confirmed delivery date
		/// FieldName: CODT
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Confirmed delivery date")]
		public DateTime? M3CODT => GetNullableDateTime("CODT");

		/// <summary>
		/// Description: Sales price quantity
		/// FieldName: SACD
		/// FieldType: N
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Sales price quantity")]
		public int? M3SACD => GetNullableInt("SACD");

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
		/// Description: Net price
		/// FieldName: NEPR
		/// FieldType: N
		/// Length: 18
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Net price")]
		public decimal? M3NEPR => GetNullableDecimal("NEPR");

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
		/// Description: Price list
		/// FieldName: PRRF
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Price list")]
		public string M3PRRF => GetString("PRRF");

		/// <summary>
		/// Description: Reference price
		/// FieldName: EDFP
		/// FieldType: N
		/// Length: 18
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Reference price")]
		public decimal? M3EDFP => GetNullableDecimal("EDFP");

		/// <summary>
		/// Description: Discount 1
		/// FieldName: DIP1
		/// FieldType: N
		/// Length: 7
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Discount 1")]
		public int? M3DIP1 => GetNullableInt("DIP1");

		/// <summary>
		/// Description: Discount 2
		/// FieldName: DIP2
		/// FieldType: N
		/// Length: 7
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Discount 2")]
		public int? M3DIP2 => GetNullableInt("DIP2");

		/// <summary>
		/// Description: Discount 3
		/// FieldName: DIP3
		/// FieldType: N
		/// Length: 7
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Discount 3")]
		public int? M3DIP3 => GetNullableInt("DIP3");

		/// <summary>
		/// Description: Discount 4
		/// FieldName: DIP4
		/// FieldType: N
		/// Length: 7
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Discount 4")]
		public int? M3DIP4 => GetNullableInt("DIP4");

		/// <summary>
		/// Description: Discount 5
		/// FieldName: DIP5
		/// FieldType: N
		/// Length: 7
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Discount 5")]
		public int? M3DIP5 => GetNullableInt("DIP5");

		/// <summary>
		/// Description: Discount 6
		/// FieldName: DIP6
		/// FieldType: N
		/// Length: 7
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Discount 6")]
		public int? M3DIP6 => GetNullableInt("DIP6");

		/// <summary>
		/// Description: Requested delivery time
		/// FieldName: DWHM
		/// FieldType: N
		/// Length: 4
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Requested delivery time")]
		public int? M3DWHM => GetNullableInt("DWHM");

		/// <summary>
		/// Description: Confirmed delivery time
		/// FieldName: COHM
		/// FieldType: N
		/// Length: 4
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Confirmed delivery time")]
		public int? M3COHM => GetNullableInt("COHM");

		/// <summary>
		/// Description: Attribute number
		/// FieldName: ATNR
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Attribute number")]
		public decimal? M3ATNR => GetNullableDecimal("ATNR");

		/// <summary>
		/// Description: Allocated quantity - basic U/M
		/// FieldName: ALQT
		/// FieldType: A
		/// Length: 16
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Allocated quantity - basic U/M")]
		public string M3ALQT => GetString("ALQT");

		/// <summary>
		/// Description: Delivered quantity - basic U/M
		/// FieldName: DLQT
		/// FieldType: A
		/// Length: 16
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Delivered quantity - basic U/M")]
		public string M3DLQT => GetString("DLQT");

		/// <summary>
		/// Description: Invoiced quantity - basic U/M
		/// FieldName: IVQT
		/// FieldType: A
		/// Length: 16
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Invoiced quantity - basic U/M")]
		public string M3IVQT => GetString("IVQT");

		/// <summary>
		/// Description: Net price used
		/// FieldName: NTCD
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Net price used")]
		public int? M3NTCD => GetNullableInt("NTCD");

		/// <summary>
		/// Description: Price origin
		/// FieldName: PRMO
		/// FieldType: A
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Price origin")]
		public string M3PRMO => GetString("PRMO");

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
		/// Description: Supplier number
		/// FieldName: SUNO
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Supplier number")]
		public string M3SUNO => GetString("SUNO");

		/// <summary>
		/// Description: Status discount 1
		/// FieldName: DIC1
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Status discount 1")]
		public int? M3DIC1 => GetNullableInt("DIC1");

		/// <summary>
		/// Description: Status discount 2
		/// FieldName: DIC2
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Status discount 2")]
		public int? M3DIC2 => GetNullableInt("DIC2");

		/// <summary>
		/// Description: Status discount 3
		/// FieldName: DIC3
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Status discount 3")]
		public int? M3DIC3 => GetNullableInt("DIC3");

		/// <summary>
		/// Description: Status discount 4
		/// FieldName: DIC4
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Status discount 4")]
		public int? M3DIC4 => GetNullableInt("DIC4");

		/// <summary>
		/// Description: Status discount 5
		/// FieldName: DIC5
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Status discount 5")]
		public int? M3DIC5 => GetNullableInt("DIC5");

		/// <summary>
		/// Description: Status discount 6
		/// FieldName: DIC6
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Status discount 6")]
		public int? M3DIC6 => GetNullableInt("DIC6");

		/// <summary>
		/// Description: Cost price
		/// FieldName: UCOS
		/// FieldType: N
		/// Length: 19
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Cost price")]
		public decimal? M3UCOS => GetNullableDecimal("UCOS");

		/// <summary>
		/// Description: Item cost quantity
		/// FieldName: COCD
		/// FieldType: N
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Item cost quantity")]
		public int? M3COCD => GetNullableInt("COCD");

		/// <summary>
		/// Description: Sales campaign
		/// FieldName: CMNO
		/// FieldType: A
		/// Length: 4
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Sales campaign")]
		public string M3CMNO => GetString("CMNO");

		/// <summary>
		/// Description: Transaction reason
		/// FieldName: RSCD
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Transaction reason")]
		public string M3RSCD => GetString("RSCD");

		/// <summary>
		/// Description: Lot number
		/// FieldName: BANO
		/// FieldType: A
		/// Length: 20
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Lot number")]
		public string M3BANO => GetString("BANO");

		/// <summary>
		/// Description: Description 1
		/// FieldName: TEDS
		/// FieldType: A
		/// Length: 60
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Description 1")]
		public string M3TEDS => GetString("TEDS");

		/// <summary>
		/// Description: Configuration number
		/// FieldName: CFIN
		/// FieldType: N
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Configuration number")]
		public long? M3CFIN => GetNullableLong("CFIN");

		/// <summary>
		/// Description: Location
		/// FieldName: WHSL
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Location")]
		public string M3WHSL => GetString("WHSL");

		/// <summary>
		/// Description: Container Id
		/// FieldName: CAMU
		/// FieldType: A
		/// Length: 20
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Container Id")]
		public string M3CAMU => GetString("CAMU");

		/// <summary>
		/// Description: Material price method
		/// FieldName: APBA
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Material price method")]
		public int? M3APBA => GetNullableInt("APBA");

		/// <summary>
		/// Description: Product number highest level
		/// FieldName: PRHL
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Product number highest level")]
		public string M3PRHL => GetString("PRHL");

		/// <summary>
		/// Description: Serial number
		/// FieldName: SERN
		/// FieldType: A
		/// Length: 20
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Serial number")]
		public string M3SERN => GetString("SERN");

		/// <summary>
		/// Description: Agreement number
		/// FieldName: CTNO
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Agreement number")]
		public string M3CTNO => GetString("CTNO");

		/// <summary>
		/// Description: Configuration position
		/// FieldName: CFGL
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Configuration position")]
		public string M3CFGL => GetString("CFGL");

		/// <summary>
		/// Description: Warranty type
		/// FieldName: WATP
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Warranty type")]
		public string M3WATP => GetString("WATP");

		/// <summary>
		/// Description: Granted warranty type
		/// FieldName: GWTP
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Granted warranty type")]
		public string M3GWTP => GetString("GWTP");

		/// <summary>
		/// Description: Product number highest level
		/// FieldName: PRHW
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Product number highest level")]
		public string M3PRHW => GetString("PRHW");

		/// <summary>
		/// Description: Serial number
		/// FieldName: SERW
		/// FieldType: A
		/// Length: 20
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Serial number")]
		public string M3SERW => GetString("SERW");

		/// <summary>
		/// Description: Order line number
		/// FieldName: PWNR
		/// FieldType: N
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Order line number")]
		public int? M3PWNR => GetNullableInt("PWNR");

		/// <summary>
		/// Description: Line suffix
		/// FieldName: PWSX
		/// FieldType: N
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Line suffix")]
		public int? M3PWSX => GetNullableInt("PWSX");

		/// <summary>
		/// Description: Extended warranty start
		/// FieldName: EWST
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Extended warranty start")]
		public int? M3EWST => GetNullableInt("EWST");

		/// <summary>
		/// Description: Agreement number
		/// FieldName: AGNB
		/// FieldType: A
		/// Length: 7
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Agreement number")]
		public string M3AGNB => GetString("AGNB");

		/// <summary>
		/// Description: Agreement number
		/// FieldName: CTNS
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Agreement number")]
		public string M3CTNS => GetString("CTNS");

		/// <summary>
		/// Description: Tax exemption contract number
		/// FieldName: TECN
		/// FieldType: A
		/// Length: 20
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Tax exemption contract number")]
		public string M3TECN => GetString("TECN");

		/// <summary>
		/// Description: Industry Application
		/// FieldName: INAP
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Industry Application")]
		public string M3INAP => GetString("INAP");

		/// <summary>
		/// Description: Replaced item number
		/// FieldName: REPI
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Replaced item number")]
		public string M3REPI => GetString("REPI");

		/// <summary>
		/// Description: Order number
		/// FieldName: RIDN
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Order number")]
		public string M3RIDN => GetString("RIDN");

		/// <summary>
		/// Description: Order line
		/// FieldName: RIDL
		/// FieldType: N
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Order line")]
		public int? M3RIDL => GetNullableInt("RIDL");

		/// <summary>
		/// Description: Line suffix
		/// FieldName: RIDX
		/// FieldType: N
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Line suffix")]
		public int? M3RIDX => GetNullableInt("RIDX");

		/// <summary>
		/// Description: Demand order number
		/// FieldName: DRDN
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Demand order number")]
		public string M3DRDN => GetString("DRDN");

		/// <summary>
		/// Description: Demand order line
		/// FieldName: DRDL
		/// FieldType: N
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Demand order line")]
		public int? M3DRDL => GetNullableInt("DRDL");

		/// <summary>
		/// Description: Line suffix
		/// FieldName: DRDX
		/// FieldType: N
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Line suffix")]
		public int? M3DRDX => GetNullableInt("DRDX");

		/// <summary>
		/// Description: Line classification
		/// FieldName: LNCL
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Line classification")]
		public int? M3LNCL => GetNullableInt("LNCL");

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
	}
}
// EOF
