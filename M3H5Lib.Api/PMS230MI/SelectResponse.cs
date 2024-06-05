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

namespace M3H5Lib.Api.PMS230MI
{
	public partial class SelectResponse : M3BaseRecord 
	{

		/// <summary>
		/// Description: Facility
		/// FieldName: FAC1
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Facility")]
		public string M3_FAC1 => GetString("FAC1");

		/// <summary>
		/// Description: Product number
		/// FieldName: PRN1
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Product number")]
		public string M3_PRN1 => GetString("PRN1");

		/// <summary>
		/// Description: Manufacturing order number
		/// FieldName: MFN1
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Manufacturing order number")]
		public string M3_MFN1 => GetString("MFN1");

		/// <summary>
		/// Description: Operation number
		/// FieldName: OPN1
		/// FieldType: N
		/// Length: 4
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Operation number")]
		public int? M3_OPN1 => GetNullableInt("OPN1");

		/// <summary>
		/// Description: Reporting number
		/// FieldName: WOS1
		/// FieldType: N
		/// Length: 9
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Reporting number")]
		public int? M3_WOS1 => GetNullableInt("WOS1");

		/// <summary>
		/// Description: Ordered quantity - Alt U/M
		/// FieldName: ORQ1
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Ordered quantity - Alt U/M")]
		public decimal? M3_ORQ1 => GetNullableDecimal("ORQ1");

		/// <summary>
		/// Description: Manufactured quantity
		/// FieldName: MAQ1
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Manufactured quantity")]
		public decimal? M3_MAQ1 => GetNullableDecimal("MAQ1");

		/// <summary>
		/// Description: Status
		/// FieldName: WOS2
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Status")]
		public string M3_WOS2 => GetString("WOS2");

		/// <summary>
		/// Description: Work Center
		/// FieldName: PLG1
		/// FieldType: A
		/// Length: 8
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Work Center")]
		public string M3_PLG1 => GetString("PLG1");

		/// <summary>
		/// Description: Operation description
		/// FieldName: OPD1
		/// FieldType: A
		/// Length: 30
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Operation description")]
		public string M3_OPD1 => GetString("OPD1");

		/// <summary>
		/// Description: Start date
		/// FieldName: STD1
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Start date")]
		public DateTime? M3_STD1 => GetNullableDateTime("STD1");

		/// <summary>
		/// Description: Start time
		/// FieldName: MST1
		/// FieldType: N
		/// Length: 4
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Start time")]
		public int? M3_MST1 => GetNullableInt("MST1");

		/// <summary>
		/// Description: Finish date
		/// FieldName: FID1
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Finish date")]
		public DateTime? M3_FID1 => GetNullableDateTime("FID1");

		/// <summary>
		/// Description: Finish time
		/// FieldName: MFT1
		/// FieldType: N
		/// Length: 4
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Finish time")]
		public int? M3_MFT1 => GetNullableInt("MFT1");

		/// <summary>
		/// Description: Automatic receipt Auto op
		/// FieldName: AUI1
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Automatic receipt Auto op")]
		public int? M3_AUI1 => GetNullableInt("AUI1");

		/// <summary>
		/// Description: Reporting
		/// FieldName: AUR1
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Reporting")]
		public int? M3_AUR1 => GetNullableInt("AUR1");

		/// <summary>
		/// Description: Price and time qty
		/// FieldName: CTC1
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Price and time qty")]
		public decimal? M3_CTC1 => GetNullableDecimal("CTC1");

		/// <summary>
		/// Description: Department
		/// FieldName: DEP1
		/// FieldType: A
		/// Length: 8
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Department")]
		public string M3_DEP1 => GetString("DEP1");

		/// <summary>
		/// Description: Document Identity
		/// FieldName: DOI1
		/// FieldType: A
		/// Length: 20
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Document Identity")]
		public string M3_DOI1 => GetString("DOI1");

		/// <summary>
		/// Description: Deviating work center
		/// FieldName: DPL1
		/// FieldType: A
		/// Length: 8
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Deviating work center")]
		public string M3_DPL1 => GetString("DPL1");

		/// <summary>
		/// Description: From work center
		/// FieldName: FPL1
		/// FieldType: A
		/// Length: 8
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("From work center")]
		public string M3_FPL1 => GetString("FPL1");

		/// <summary>
		/// Description: Fixed time
		/// FieldName: FXT1
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Fixed time")]
		public int? M3_FXT1 => GetNullableInt("FXT1");

		/// <summary>
		/// Description: Pay element
		/// FieldName: KIW1
		/// FieldType: N
		/// Length: 4
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Pay element")]
		public int? M3_KIW1 => GetNullableInt("KIW1");

		/// <summary>
		/// Description: Labor skill
		/// FieldName: LAS1
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Labor skill")]
		public string M3_LAS1 => GetString("LAS1");

		/// <summary>
		/// Description: Operation element exists
		/// FieldName: OAD1
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Operation element exists")]
		public int? M3_OAD1 => GetNullableInt("OAD1");

		/// <summary>
		/// Description: Lead time offset
		/// FieldName: ODB1
		/// FieldType: N
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Lead time offset")]
		public int? M3_ODB1 => GetNullableInt("ODB1");

		/// <summary>
		/// Description: Operation started
		/// FieldName: OPS1
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Operation started")]
		public int? M3_OPS1 => GetNullableInt("OPS1");

		/// <summary>
		/// Description: Operation volume
		/// FieldName: OPV1
		/// FieldType: N
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Operation volume")]
		public long? M3_OPV1 => GetNullableLong("OPV1");

		/// <summary>
		/// Description: external setup time
		/// FieldName: OSE1
		/// FieldType: N
		/// Length: 8
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("external setup time")]
		public int? M3_OSE1 => GetNullableInt("OSE1");

		/// <summary>
		/// Description: Unit price
		/// FieldName: PIP1
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Unit price")]
		public decimal? M3_PIP1 => GetNullableDecimal("PIP1");

		/// <summary>
		/// Description: Run time
		/// FieldName: PIT1
		/// FieldType: N
		/// Length: 8
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Run time")]
		public int? M3_PIT1 => GetNullableInt("PIT1");

		/// <summary>
		/// Description: Work center
		/// FieldName: PLG2
		/// FieldType: A
		/// Length: 8
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Work center")]
		public string M3_PLG2 => GetString("PLG2");

		/// <summary>
		/// Description: Production days
		/// FieldName: PRD1
		/// FieldType: N
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Production days")]
		public int? M3_PRD1 => GetNullableInt("PRD1");

		/// <summary>
		/// Description: Priority
		/// FieldName: PRI1
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Priority")]
		public int? M3_PRI1 => GetNullableInt("PRI1");

		/// <summary>
		/// Description: Planned number of machines
		/// FieldName: PRN2
		/// FieldType: N
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Planned number of machines")]
		public int? M3_PRN2 => GetNullableInt("PRN2");

		/// <summary>
		/// Description: Planned number of workers - run time
		/// FieldName: PRN3
		/// FieldType: N
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Planned number of workers - run time")]
		public int? M3_PRN3 => GetNullableInt("PRN3");

		/// <summary>
		/// Description: Co-sorting key
		/// FieldName: PSS1
		/// FieldType: A
		/// Length: 20
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Co-sorting key")]
		public string M3_PSS1 => GetString("PSS1");

		/// <summary>
		/// Description: Quality inspection
		/// FieldName: QUA1
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Quality inspection")]
		public int? M3_QUA1 => GetNullableInt("QUA1");

		/// <summary>
		/// Description: Queue days
		/// FieldName: QUD1
		/// FieldType: N
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Queue days")]
		public int? M3_QUD1 => GetNullableInt("QUD1");

		/// <summary>
		/// Description: Remaining buffer
		/// FieldName: RBU1
		/// FieldType: N
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Remaining buffer")]
		public int? M3_RBU1 => GetNullableInt("RBU1");

		/// <summary>
		/// Description: Planning area
		/// FieldName: REA1
		/// FieldType: A
		/// Length: 8
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Planning area")]
		public string M3_REA1 => GetString("REA1");

		/// <summary>
		/// Description: Manual completion flag
		/// FieldName: REN1
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Manual completion flag")]
		public int? M3_REN1 => GetNullableInt("REN1");

		/// <summary>
		/// Description: Reporting date
		/// FieldName: RPD1
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Reporting date")]
		public DateTime? M3_RPD1 => GetNullableDateTime("RPD1");

		/// <summary>
		/// Description: Responsible for reporting
		/// FieldName: RPR1
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Responsible for reporting")]
		public string M3_RPR1 => GetString("RPR1");

		/// <summary>
		/// Description: Reporting time
		/// FieldName: RPT1
		/// FieldType: N
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Reporting time")]
		public int? M3_RPT1 => GetNullableInt("RPT1");

		/// <summary>
		/// Description: Actual start date
		/// FieldName: RSD1
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Actual start date")]
		public DateTime? M3_RSD1 => GetNullableDateTime("RSD1");

		/// <summary>
		/// Description: Rework quantity - Alt unit
		/// FieldName: RWQ1
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Rework quantity - Alt unit")]
		public decimal? M3_RWQ1 => GetNullableDecimal("RWQ1");

		/// <summary>
		/// Description: Schedule number
		/// FieldName: SCH1
		/// FieldType: N
		/// Length: 11
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Schedule number")]
		public decimal? M3_SCH1 => GetNullableDecimal("SCH1");

		/// <summary>
		/// Description: Schedule number sequence
		/// FieldName: SCH2
		/// FieldType: N
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Schedule number sequence")]
		public long? M3_SCH2 => GetNullableLong("SCH2");

		/// <summary>
		/// Description: Scrap percentage
		/// FieldName: SCP1
		/// FieldType: N
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Scrap percentage")]
		public int? M3_SCP1 => GetNullableInt("SCP1");

		/// <summary>
		/// Description: Scrapped quantity
		/// FieldName: SCQ1
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Scrapped quantity")]
		public decimal? M3_SCQ1 => GetNullableDecimal("SCQ1");

		/// <summary>
		/// Description: Rejection reason
		/// FieldName: SCR1
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Rejection reason")]
		public string M3_SCR1 => GetString("SCR1");

		/// <summary>
		/// Description: Planned number of workers - setup
		/// FieldName: SEN1
		/// FieldType: N
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Planned number of workers - setup")]
		public int? M3_SEN1 => GetNullableInt("SEN1");

		/// <summary>
		/// Description: Setup price
		/// FieldName: SEP1
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Setup price")]
		public decimal? M3_SEP1 => GetNullableDecimal("SEP1");

		/// <summary>
		/// Description: Sequencing Status
		/// FieldName: SEQ1
		/// FieldType: N
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Sequencing Status")]
		public int? M3_SEQ1 => GetNullableInt("SEQ1");

		/// <summary>
		/// Description: Setup time
		/// FieldName: SET1
		/// FieldType: N
		/// Length: 8
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Setup time")]
		public int? M3_SET1 => GetNullableInt("SET1");

		/// <summary>
		/// Description: Transport value in days
		/// FieldName: SLA1
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Transport value in days")]
		public decimal? M3_SLA1 => GetNullableDecimal("SLA1");

		/// <summary>
		/// Description: Transit unit of measure/overlap code
		/// FieldName: SLA2
		/// FieldType: A
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Transit unit of measure/overlap code")]
		public string M3_SLA2 => GetString("SLA2");

		/// <summary>
		/// Description: Supplier number
		/// FieldName: SUN1
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Supplier number")]
		public string M3_SUN1 => GetString("SUN1");

		/// <summary>
		/// Description: Setup scrap
		/// FieldName: SWQ1
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Setup scrap")]
		public decimal? M3_SWQ1 => GetNullableDecimal("SWQ1");

		/// <summary>
		/// Description: Tool number
		/// FieldName: TOO1
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Tool number")]
		public string M3_TOO1 => GetString("TOO1");

		/// <summary>
		/// Description: To work center
		/// FieldName: TPL1
		/// FieldType: A
		/// Length: 8
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("To work center")]
		public string M3_TPL1 => GetString("TPL1");

		/// <summary>
		/// Description: Text ID / Operation
		/// FieldName: TXI1
		/// FieldType: N
		/// Length: 13
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Text ID / Operation")]
		public decimal? M3_TXI1 => GetNullableDecimal("TXI1");

		/// <summary>
		/// Description: Used Labor setup time
		/// FieldName: UMA1
		/// FieldType: N
		/// Length: 8
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Used Labor setup time")]
		public int? M3_UMA1 => GetNullableInt("UMA1");

		/// <summary>
		/// Description: Used labor run time
		/// FieldName: UMA2
		/// FieldType: N
		/// Length: 8
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Used labor run time")]
		public int? M3_UMA2 => GetNullableInt("UMA2");

		/// <summary>
		/// Description: Used machine run time
		/// FieldName: UPI1
		/// FieldType: N
		/// Length: 8
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Used machine run time")]
		public int? M3_UPI1 => GetNullableInt("UPI1");

		/// <summary>
		/// Description: Used machine setup time
		/// FieldName: USE1
		/// FieldType: N
		/// Length: 8
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Used machine setup time")]
		public int? M3_USE1 => GetNullableInt("USE1");

		/// <summary>
		/// Description: Time rate
		/// FieldName: WAF1
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Time rate")]
		public decimal? M3_WAF1 => GetNullableDecimal("WAF1");

		/// <summary>
		/// Description: Time reference
		/// FieldName: WCR1
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Time reference")]
		public string M3_WCR1 => GetString("WCR1");

		/// <summary>
		/// Description: Order documents printed
		/// FieldName: WOD1
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Order documents printed")]
		public int? M3_WOD1 => GetNullableInt("WOD1");

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
		/// Description: Order type
		/// FieldName: ORTY
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Order type")]
		public string M3_ORTY => GetString("ORTY");

		/// <summary>
		/// Description: Manufacturing U/M
		/// FieldName: MAUN
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Manufacturing U/M")]
		public string M3_MAUN => GetString("MAUN");

		/// <summary>
		/// Description: Responsible
		/// FieldName: RESP
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Responsible")]
		public string M3_RESP => GetString("RESP");

		/// <summary>
		/// Description: Status - manufacturing order
		/// FieldName: WHST
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Status - manufacturing order")]
		public string M3_WHST => GetString("WHST");

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

		/// <summary>
		/// Description: Reference order line
		/// FieldName: RORL
		/// FieldType: N
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Reference order line")]
		public int? M3_RORL => GetNullableInt("RORL");

		/// <summary>
		/// Description: Line suffix
		/// FieldName: RORX
		/// FieldType: N
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Line suffix")]
		public int? M3_RORX => GetNullableInt("RORX");

		/// <summary>
		/// Description: Reference order number
		/// FieldName: RORN
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Reference order number")]
		public string M3_RORN => GetString("RORN");

		/// <summary>
		/// Description: Reporting number
		/// FieldName: WOSQ
		/// FieldType: N
		/// Length: 9
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Reporting number")]
		public int? M3_WOSQ => GetNullableInt("WOSQ");

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
		/// Description: Configuration number
		/// FieldName: CFIN
		/// FieldType: N
		/// Length: 7
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Configuration number")]
		public int? M3_CFIN => GetNullableInt("CFIN");

		/// <summary>
		/// Description: Drawing number
		/// FieldName: DWNO
		/// FieldType: A
		/// Length: 20
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Drawing number")]
		public string M3_DWNO => GetString("DWNO");

		/// <summary>
		/// Description: Revision number
		/// FieldName: ECVE
		/// FieldType: A
		/// Length: 4
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Revision number")]
		public string M3_ECVE => GetString("ECVE");

		/// <summary>
		/// Description: Simulation round
		/// FieldName: ECVS
		/// FieldType: N
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Simulation round")]
		public int? M3_ECVS => GetNullableInt("ECVS");

		/// <summary>
		/// Description: Finish date
		/// FieldName: FIDT
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Finish date")]
		public DateTime? M3_FIDT => GetNullableDateTime("FIDT");

		/// <summary>
		/// Description: Origin
		/// FieldName: GETP
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Origin")]
		public int? M3_GETP => GetNullableInt("GETP");

		/// <summary>
		/// Description: Main product
		/// FieldName: HDPR
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Main product")]
		public string M3_HDPR => GetString("HDPR");

		/// <summary>
		/// Description: Lead time this level
		/// FieldName: LEAL
		/// FieldType: N
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Lead time this level")]
		public int? M3_LEAL => GetNullableInt("LEAL");

		/// <summary>
		/// Description: Finish time
		/// FieldName: MFTI
		/// FieldType: N
		/// Length: 4
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Finish time")]
		public int? M3_MFTI => GetNullableInt("MFTI");

		/// <summary>
		/// Description: Start time
		/// FieldName: MSTI
		/// FieldType: N
		/// Length: 4
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Start time")]
		public int? M3_MSTI => GetNullableInt("MSTI");

		/// <summary>
		/// Description: Number of lots
		/// FieldName: NUBA
		/// FieldType: N
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Number of lots")]
		public int? M3_NUBA => GetNullableInt("NUBA");

		/// <summary>
		/// Description: Priority
		/// FieldName: PRIO
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Priority")]
		public int? M3_PRIO => GetNullableInt("PRIO");

		/// <summary>
		/// Description: Manual completion flag
		/// FieldName: REND
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Manual completion flag")]
		public int? M3_REND => GetNullableInt("REND");

		/// <summary>
		/// Description: Reporting date
		/// FieldName: RPDT
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Reporting date")]
		public DateTime? M3_RPDT => GetNullableDateTime("RPDT");

		/// <summary>
		/// Description: Actual start date
		/// FieldName: RSDT
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Actual start date")]
		public DateTime? M3_RSDT => GetNullableDateTime("RSDT");

		/// <summary>
		/// Description: Start date
		/// FieldName: STDT
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Start date")]
		public DateTime? M3_STDT => GetNullableDateTime("STDT");

		/// <summary>
		/// Description: Product structure type
		/// FieldName: STRT
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Product structure type")]
		public string M3_STRT => GetString("STRT");

		/// <summary>
		/// Description: Text ID / Order
		/// FieldName: TXID
		/// FieldType: N
		/// Length: 13
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Text ID / Order")]
		public decimal? M3_TXID => GetNullableDecimal("TXID");

		/// <summary>
		/// Description: Product variant
		/// FieldName: VANO
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Product variant")]
		public string M3_VANO => GetString("VANO");

		/// <summary>
		/// Description: Highest operation status   order
		/// FieldName: WHHS
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Highest operation status   order")]
		public string M3_WHHS => GetString("WHHS");

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
		/// Description: Material status
		/// FieldName: WMST
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Material status")]
		public string M3_WMST => GetString("WMST");

		/// <summary>
		/// Description: Order documents printed
		/// FieldName: WODP
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Order documents printed")]
		public int? M3_WODP => GetNullableInt("WODP");

		/// <summary>
		/// Description: Product group
		/// FieldName: ITCL
		/// FieldType: A
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Product group")]
		public string M3_ITCL => GetString("ITCL");

		/// <summary>
		/// Description: Item group
		/// FieldName: ITGR
		/// FieldType: A
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Item group")]
		public string M3_ITGR => GetString("ITGR");

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
		/// Description: Name
		/// FieldName: CUNM
		/// FieldType: A
		/// Length: 36
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Name")]
		public string M3_CUNM => GetString("CUNM");

		/// <summary>
		/// Description: Item description
		/// FieldName: ITDS
		/// FieldType: A
		/// Length: 60
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Item description")]
		public string M3_ITDS => GetString("ITDS");

		/// <summary>
		/// Description: Lowest material status for this operatio
		/// FieldName: ATST
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Lowest material status for this operatio")]
		public string M3_ATST => GetString("ATST");

		/// <summary>
		/// Description: Pickinglist exist
		/// FieldName: PLEX
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Pickinglist exist")]
		public int? M3_PLEX => GetNullableInt("PLEX");

		/// <summary>
		/// Description: Lowest tool status for this operation
		/// FieldName: OLST
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Lowest tool status for this operation")]
		public string M3_OLST => GetString("OLST");

		/// <summary>
		/// Description: Text block exists
		/// FieldName: TXEX
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Text block exists")]
		public int? M3_TXEX => GetNullableInt("TXEX");

		/// <summary>
		/// Description: Text exists (not text block)
		/// FieldName: XEX2
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Text exists (not text block)")]
		public int? M3_XEX2 => GetNullableInt("XEX2");

		/// <summary>
		/// Description: App Processed
		/// FieldName: PRAP
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("App Processed")]
		public int? M3_PRAP => GetNullableInt("PRAP");
	}
}
// EOF
