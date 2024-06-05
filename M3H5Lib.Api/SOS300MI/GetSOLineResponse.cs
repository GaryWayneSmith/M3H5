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

namespace M3H5Lib.Api.SOS300MI
{
	public partial class GetSOLineResponse : M3BaseRecord 
	{

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
		/// Description: Name
		/// FieldName: ITDS
		/// FieldType: A
		/// Length: 30
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Name")]
		public string M3ITDS => GetString("ITDS");

		/// <summary>
		/// Description: Ordered quantity - basic U/M
		/// FieldName: ORQT
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Ordered quantity - basic U/M")]
		public decimal? M3ORQT => GetNullableDecimal("ORQT");

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
		/// Description: Sales price
		/// FieldName: SAPR
		/// FieldType: N
		/// Length: 19
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Sales price")]
		public decimal? M3SAPR => GetNullableDecimal("SAPR");

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
		/// Description: Reported quantity
		/// FieldName: RAQT
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Reported quantity")]
		public decimal? M3RAQT => GetNullableDecimal("RAQT");

		/// <summary>
		/// Description: Planned start date
		/// FieldName: PLSD
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Planned start date")]
		public DateTime? M3PLSD => GetNullableDateTime("PLSD");

		/// <summary>
		/// Description: Planned start time
		/// FieldName: PLST
		/// FieldType: N
		/// Length: 4
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Planned start time")]
		public int? M3PLST => GetNullableInt("PLST");

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
		/// Description: Line type
		/// FieldName: LTYP
		/// FieldType: A
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Line type")]
		public string M3LTYP => GetString("LTYP");

		/// <summary>
		/// Description: Remaining quantity - basic U/M
		/// FieldName: RNQT
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Remaining quantity - basic U/M")]
		public decimal? M3RNQT => GetNullableDecimal("RNQT");

		/// <summary>
		/// Description: Allocated quantity - basic U/M
		/// FieldName: ALQT
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Allocated quantity - basic U/M")]
		public decimal? M3ALQT => GetNullableDecimal("ALQT");

		/// <summary>
		/// Description: Delivered quantity - basic U/M
		/// FieldName: DLQT
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Delivered quantity - basic U/M")]
		public decimal? M3DLQT => GetNullableDecimal("DLQT");

		/// <summary>
		/// Description: Invoiced quantity - basic U/M
		/// FieldName: IVQT
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Invoiced quantity - basic U/M")]
		public decimal? M3IVQT => GetNullableDecimal("IVQT");

		/// <summary>
		/// Description: Quantity 1
		/// FieldName: QTY1
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Quantity 1")]
		public decimal? M3QTY1 => GetNullableDecimal("QTY1");

		/// <summary>
		/// Description: Change date
		/// FieldName: LMDT
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Change date")]
		public DateTime? M3LMDT => GetNullableDateTime("LMDT");

		/// <summary>
		/// Description: Technician
		/// FieldName: TECH
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Technician")]
		public string M3TECH => GetString("TECH");

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
		/// Description: Serial number
		/// FieldName: SERI
		/// FieldType: A
		/// Length: 30
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Serial number")]
		public string M3SERI => GetString("SERI");

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
		/// Description: Quantity to invoice
		/// FieldName: TIQT
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Quantity to invoice")]
		public decimal? M3TIQT => GetNullableDecimal("TIQT");

		/// <summary>
		/// Description: Alternate U/M
		/// FieldName: ALUN
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Alternate U/M")]
		public string M3ALUN => GetString("ALUN");

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
		/// Description: Discount origin
		/// FieldName: DICD
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Discount origin")]
		public int? M3DICD => GetNullableInt("DICD");

		/// <summary>
		/// Description: Planned finish date
		/// FieldName: PLFD
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Planned finish date")]
		public DateTime? M3PLFD => GetNullableDateTime("PLFD");

		/// <summary>
		/// Description: Planned finish time
		/// FieldName: PLFT
		/// FieldType: N
		/// Length: 4
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Planned finish time")]
		public int? M3PLFT => GetNullableInt("PLFT");

		/// <summary>
		/// Description: Inventory accounting
		/// FieldName: STCD
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Inventory accounting")]
		public int? M3STCD => GetNullableInt("STCD");

		/// <summary>
		/// Description: Purchase order number
		/// FieldName: PUNO
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Purchase order number")]
		public string M3PUNO => GetString("PUNO");

		/// <summary>
		/// Description: Purchase order line
		/// FieldName: PNLI
		/// FieldType: N
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Purchase order line")]
		public int? M3PNLI => GetNullableInt("PNLI");

		/// <summary>
		/// Description: Flagged as completed
		/// FieldName: OEND
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Flagged as completed")]
		public int? M3OEND => GetNullableInt("OEND");

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
		/// Description: Standard cost code
		/// FieldName: UCCD
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Standard cost code")]
		public int? M3UCCD => GetNullableInt("UCCD");

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
		/// Description: Joint delivery
		/// FieldName: JDCD
		/// FieldType: A
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Joint delivery")]
		public string M3JDCD => GetString("JDCD");

		/// <summary>
		/// Description: Line amount - order currency
		/// FieldName: LNAM
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Line amount - order currency")]
		public decimal? M3LNAM => GetNullableDecimal("LNAM");

		/// <summary>
		/// Description: Price list SO
		/// FieldName: PRS1
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Price list SO")]
		public string M3PRS1 => GetString("PRS1");

		/// <summary>
		/// Description: Quantity
		/// FieldName: CNQT
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Quantity")]
		public decimal? M3CNQT => GetNullableDecimal("CNQT");

		/// <summary>
		/// Description: Error cause
		/// FieldName: ERCO
		/// FieldType: A
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Error cause")]
		public string M3ERCO => GetString("ERCO");

		/// <summary>
		/// Description: Action
		/// FieldName: MECO
		/// FieldType: A
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Action")]
		public string M3MECO => GetString("MECO");

		/// <summary>
		/// Description: Error symptom
		/// FieldName: ESCO
		/// FieldType: A
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Error symptom")]
		public string M3ESCO => GetString("ESCO");

		/// <summary>
		/// Description: Reference order number
		/// FieldName: RORN
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Reference order number")]
		public string M3RORN => GetString("RORN");

		/// <summary>
		/// Description: Reference order line
		/// FieldName: RORL
		/// FieldType: N
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Reference order line")]
		public int? M3RORL => GetNullableInt("RORL");

		/// <summary>
		/// Description: Line suffix
		/// FieldName: RORX
		/// FieldType: N
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Line suffix")]
		public int? M3RORX => GetNullableInt("RORX");

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
		/// Description: Status - discount 1
		/// FieldName: DIC1
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Status - discount 1")]
		public int? M3DIC1 => GetNullableInt("DIC1");

		/// <summary>
		/// Description: Status - discount 2
		/// FieldName: DIC2
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Status - discount 2")]
		public int? M3DIC2 => GetNullableInt("DIC2");

		/// <summary>
		/// Description: Status - discount 3
		/// FieldName: DIC3
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Status - discount 3")]
		public int? M3DIC3 => GetNullableInt("DIC3");

		/// <summary>
		/// Description: Status - discount 4
		/// FieldName: DIC4
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Status - discount 4")]
		public int? M3DIC4 => GetNullableInt("DIC4");

		/// <summary>
		/// Description: Status - discount 5
		/// FieldName: DIC5
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Status - discount 5")]
		public int? M3DIC5 => GetNullableInt("DIC5");

		/// <summary>
		/// Description: Status - discount 6
		/// FieldName: DIC6
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Status - discount 6")]
		public int? M3DIC6 => GetNullableInt("DIC6");

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
		/// Description: Function area
		/// FieldName: FCTN
		/// FieldType: A
		/// Length: 4
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Function area")]
		public string M3FCTN => GetString("FCTN");

		/// <summary>
		/// Description: Tax code customer/address
		/// FieldName: TAXC
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Tax code customer/address")]
		public string M3TAXC => GetString("TAXC");

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
		/// Description: Post-text
		/// FieldName: POTX
		/// FieldType: N
		/// Length: 13
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Post-text")]
		public decimal? M3POTX => GetNullableDecimal("POTX");

		/// <summary>
		/// Description: Pre-text
		/// FieldName: PRTX
		/// FieldType: A
		/// Length: 30
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Pre-text")]
		public string M3PRTX => GetString("PRTX");

		/// <summary>
		/// Description: Kit control
		/// FieldName: FSCD
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Kit control")]
		public int? M3FSCD => GetNullableInt("FSCD");

		/// <summary>
		/// Description: Fixed quantity
		/// FieldName: FQCD
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Fixed quantity")]
		public int? M3FQCD => GetNullableInt("FQCD");

		/// <summary>
		/// Description: Fixed price
		/// FieldName: FPCD
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Fixed price")]
		public int? M3FPCD => GetNullableInt("FPCD");

		/// <summary>
		/// Description: Pricing method
		/// FieldName: PSET
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Pricing method")]
		public int? M3PSET => GetNullableInt("PSET");

		/// <summary>
		/// Description: Full cost summation
		/// FieldName: UPCO
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Full cost summation")]
		public int? M3UPCO => GetNullableInt("UPCO");

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
		/// Description: Service expense category
		/// FieldName: SCOD
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Service expense category")]
		public int? M3SCOD => GetNullableInt("SCOD");

		/// <summary>
		/// Description: Service order job number
		/// FieldName: JOBN
		/// FieldType: N
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Service order job number")]
		public int? M3JOBN => GetNullableInt("JOBN");

		/// <summary>
		/// Description: Assignment suffix
		/// FieldName: JBSX
		/// FieldType: N
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Assignment suffix")]
		public int? M3JBSX => GetNullableInt("JBSX");

		/// <summary>
		/// Description: Line value
		/// FieldName: LNA2
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Line value")]
		public decimal? M3LNA2 => GetNullableDecimal("LNA2");

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
		/// Description: Entry time
		/// FieldName: RGTM
		/// FieldType: N
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Entry time")]
		public int? M3RGTM => GetNullableInt("RGTM");

		/// <summary>
		/// Description: Supplier name
		/// FieldName: SUNM
		/// FieldType: A
		/// Length: 36
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Supplier name")]
		public string M3SUNM => GetString("SUNM");
	}
}
// EOF
