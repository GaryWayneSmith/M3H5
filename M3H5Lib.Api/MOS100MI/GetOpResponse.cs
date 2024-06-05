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

namespace M3H5Lib.Api.MOS100MI
{
	public partial class GetOpResponse : M3BaseRecord 
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
		/// Description: Product number
		/// FieldName: PRNO
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Product number")]
		public string M3_PRNO => GetString("PRNO");

		/// <summary>
		/// Description: Work order number
		/// FieldName: MWNO
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Work order number")]
		public string M3_MWNO => GetString("MWNO");

		/// <summary>
		/// Description: Operation number
		/// FieldName: OPNO
		/// FieldType: N
		/// Length: 4
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Operation number")]
		public int? M3_OPNO => GetNullableInt("OPNO");

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
		/// Description: Status
		/// FieldName: WOST
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Status")]
		public string M3_WOST => GetString("WOST");

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
		/// Description: Work center
		/// FieldName: PLGR
		/// FieldType: A
		/// Length: 8
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Work center")]
		public string M3_PLGR => GetString("PLGR");

		/// <summary>
		/// Description: Operation description
		/// FieldName: OPDS
		/// FieldType: A
		/// Length: 30
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Operation description")]
		public string M3_OPDS => GetString("OPDS");

		/// <summary>
		/// Description: Text line 1
		/// FieldName: TXT1
		/// FieldType: A
		/// Length: 60
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Text line 1")]
		public string M3_TXT1 => GetString("TXT1");

		/// <summary>
		/// Description: Text line 2
		/// FieldName: TXT2
		/// FieldType: A
		/// Length: 60
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Text line 2")]
		public string M3_TXT2 => GetString("TXT2");

		/// <summary>
		/// Description: Department
		/// FieldName: DEPT
		/// FieldType: A
		/// Length: 8
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Department")]
		public string M3_DEPT => GetString("DEPT");

		/// <summary>
		/// Description: Planning area
		/// FieldName: REAR
		/// FieldType: A
		/// Length: 8
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Planning area")]
		public string M3_REAR => GetString("REAR");

		/// <summary>
		/// Description: Document identity
		/// FieldName: DOID
		/// FieldType: A
		/// Length: 20
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Document identity")]
		public string M3_DOID => GetString("DOID");

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
		/// Description: Actual start time
		/// FieldName: RSTI
		/// FieldType: N
		/// Length: 4
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Actual start time")]
		public int? M3_RSTI => GetNullableInt("RSTI");

		/// <summary>
		/// Description: Actual finish date
		/// FieldName: REFD
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Actual finish date")]
		public DateTime? M3_REFD => GetNullableDateTime("REFD");

		/// <summary>
		/// Description: Actual finish time
		/// FieldName: RFTI
		/// FieldType: N
		/// Length: 4
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Actual finish time")]
		public int? M3_RFTI => GetNullableInt("RFTI");

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
		/// Description: Reporting time
		/// FieldName: RTM1
		/// FieldType: N
		/// Length: 4
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Reporting time")]
		public int? M3_RTM1 => GetNullableInt("RTM1");

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
		/// Description: Ordered quantity - basic U/M
		/// FieldName: ORQT
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Ordered quantity - basic U/M")]
		public decimal? M3_ORQT => GetNullableDecimal("ORQT");

		/// <summary>
		/// Description: Manufactured quantity
		/// FieldName: MAQT
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Manufactured quantity")]
		public decimal? M3_MAQT => GetNullableDecimal("MAQT");

		/// <summary>
		/// Description: Responsible for reporting
		/// FieldName: RPRE
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Responsible for reporting")]
		public string M3_RPRE => GetString("RPRE");

		/// <summary>
		/// Description: Labor skill
		/// FieldName: LASK
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Labor skill")]
		public string M3_LASK => GetString("LASK");

		/// <summary>
		/// Description: Fixed time
		/// FieldName: FXTI
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Fixed time")]
		public int? M3_FXTI => GetNullableInt("FXTI");

		/// <summary>
		/// Description: Setup time
		/// FieldName: SETI
		/// FieldType: N
		/// Length: 9
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Setup time")]
		public int? M3_SETI => GetNullableInt("SETI");

		/// <summary>
		/// Description: External setup time
		/// FieldName: OSET
		/// FieldType: N
		/// Length: 9
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("External setup time")]
		public int? M3_OSET => GetNullableInt("OSET");

		/// <summary>
		/// Description: Run time
		/// FieldName: PITI
		/// FieldType: N
		/// Length: 9
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Run time")]
		public int? M3_PITI => GetNullableInt("PITI");

		/// <summary>
		/// Description: Used machine setup time
		/// FieldName: USET
		/// FieldType: N
		/// Length: 9
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Used machine setup time")]
		public int? M3_USET => GetNullableInt("USET");

		/// <summary>
		/// Description: Used machine run time
		/// FieldName: UPIT
		/// FieldType: N
		/// Length: 9
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Used machine run time")]
		public int? M3_UPIT => GetNullableInt("UPIT");

		/// <summary>
		/// Description: Used labor run time
		/// FieldName: UMAT
		/// FieldType: N
		/// Length: 9
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Used labor run time")]
		public int? M3_UMAT => GetNullableInt("UMAT");

		/// <summary>
		/// Description: Used labor setup time
		/// FieldName: UMAS
		/// FieldType: N
		/// Length: 9
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Used labor setup time")]
		public int? M3_UMAS => GetNullableInt("UMAS");

		/// <summary>
		/// Description: Planned number of workers - setup
		/// FieldName: SENP
		/// FieldType: N
		/// Length: 7
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Planned number of workers - setup")]
		public int? M3_SENP => GetNullableInt("SENP");

		/// <summary>
		/// Description: Planned number of workers - run time
		/// FieldName: PRNP
		/// FieldType: N
		/// Length: 7
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Planned number of workers - run time")]
		public int? M3_PRNP => GetNullableInt("PRNP");

		/// <summary>
		/// Description: Planned number of machines
		/// FieldName: PRNM
		/// FieldType: N
		/// Length: 7
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Planned number of machines")]
		public int? M3_PRNM => GetNullableInt("PRNM");

		/// <summary>
		/// Description: Tool number
		/// FieldName: TOOL
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Tool number")]
		public string M3_TOOL => GetString("TOOL");

		/// <summary>
		/// Description: Number of labor tickets
		/// FieldName: CAMP
		/// FieldType: N
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Number of labor tickets")]
		public int? M3_CAMP => GetNullableInt("CAMP");

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
		/// Description: Queue days
		/// FieldName: QUDY
		/// FieldType: N
		/// Length: 7
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Queue days")]
		public int? M3_QUDY => GetNullableInt("QUDY");

		/// <summary>
		/// Description: Transport value in days
		/// FieldName: SLAC
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Transport value in days")]
		public decimal? M3_SLAC => GetNullableDecimal("SLAC");

		/// <summary>
		/// Description: Lead time offset
		/// FieldName: ODBF
		/// FieldType: N
		/// Length: 7
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Lead time offset")]
		public int? M3_ODBF => GetNullableInt("ODBF");

		/// <summary>
		/// Description: Production days
		/// FieldName: PRDY
		/// FieldType: N
		/// Length: 7
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Production days")]
		public int? M3_PRDY => GetNullableInt("PRDY");

		/// <summary>
		/// Description: Supplier number
		/// FieldName: SUNO
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Supplier number")]
		public string M3_SUNO => GetString("SUNO");

		/// <summary>
		/// Description: Co-sorting key
		/// FieldName: PSSQ
		/// FieldType: A
		/// Length: 20
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Co-sorting key")]
		public string M3_PSSQ => GetString("PSSQ");

		/// <summary>
		/// Description: Schedule number
		/// FieldName: SCHN
		/// FieldType: N
		/// Length: 11
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Schedule number")]
		public decimal? M3_SCHN => GetNullableDecimal("SCHN");

		/// <summary>
		/// Description: Schedule number sequence
		/// FieldName: SCHS
		/// FieldType: N
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Schedule number sequence")]
		public long? M3_SCHS => GetNullableLong("SCHS");

		/// <summary>
		/// Description: To work center
		/// FieldName: TPLG
		/// FieldType: A
		/// Length: 8
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("To work center")]
		public string M3_TPLG => GetString("TPLG");

		/// <summary>
		/// Description: From work center
		/// FieldName: FPLG
		/// FieldType: A
		/// Length: 8
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("From work center")]
		public string M3_FPLG => GetString("FPLG");

		/// <summary>
		/// Description: Automatic receipt
		/// FieldName: AUIN
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Automatic receipt")]
		public int? M3_AUIN => GetNullableInt("AUIN");

		/// <summary>
		/// Description: Automatic operation reporting
		/// FieldName: AURP
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Automatic operation reporting")]
		public int? M3_AURP => GetNullableInt("AURP");

		/// <summary>
		/// Description: Deviating work center
		/// FieldName: DPLG
		/// FieldType: A
		/// Length: 8
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Deviating work center")]
		public string M3_DPLG => GetString("DPLG");

		/// <summary>
		/// Description: Infinite/finite
		/// FieldName: WLDE
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Infinite/finite")]
		public int? M3_WLDE => GetNullableInt("WLDE");

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
		/// Description: Operation started
		/// FieldName: OPST
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Operation started")]
		public int? M3_OPST => GetNullableInt("OPST");

		/// <summary>
		/// Description: Subcontract control
		/// FieldName: SUBC
		/// FieldType: A
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Subcontract control")]
		public string M3_SUBC => GetString("SUBC");

		/// <summary>
		/// Description: Operation element exists
		/// FieldName: OADS
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Operation element exists")]
		public int? M3_OADS => GetNullableInt("OADS");

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
		/// Description: Equipment number
		/// FieldName: EQNO
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Equipment number")]
		public string M3_EQNO => GetString("EQNO");

		/// <summary>
		/// Description: Service
		/// FieldName: SUFI
		/// FieldType: A
		/// Length: 20
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Service")]
		public string M3_SUFI => GetString("SUFI");

		/// <summary>
		/// Description: Specific requirement category
		/// FieldName: SPRQ
		/// FieldType: A
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Specific requirement category")]
		public string M3_SPRQ => GetString("SPRQ");

		/// <summary>
		/// Description: Specific requirements
		/// FieldName: SPRT
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Specific requirements")]
		public string M3_SPRT => GetString("SPRT");

		/// <summary>
		/// Description: Exchange
		/// FieldName: EXCH
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Exchange")]
		public int? M3_EXCH => GetNullableInt("EXCH");

		/// <summary>
		/// Description: Material shortage purchase/manufacturing
		/// FieldName: MSPM
		/// FieldType: N
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Material shortage purchase/manufacturing")]
		public int? M3_MSPM => GetNullableInt("MSPM");

		/// <summary>
		/// Description: Tool shortage
		/// FieldName: TSPM
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Tool shortage")]
		public int? M3_TSPM => GetNullableInt("TSPM");

		/// <summary>
		/// Description: Tool allocation
		/// FieldName: TOAL
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Tool allocation")]
		public int? M3_TOAL => GetNullableInt("TOAL");

		/// <summary>
		/// Description: Automatic approval of service
		/// FieldName: ACNF
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Automatic approval of service")]
		public int? M3_ACNF => GetNullableInt("ACNF");

		/// <summary>
		/// Description: Completion flag
		/// FieldName: AZSE
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Completion flag")]
		public int? M3_AZSE => GetNullableInt("AZSE");

		/// <summary>
		/// Description: Automatic approval of modification
		/// FieldName: ACMO
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Automatic approval of modification")]
		public int? M3_ACMO => GetNullableInt("ACMO");

		/// <summary>
		/// Description: Removal
		/// FieldName: INSR
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Removal")]
		public int? M3_INSR => GetNullableInt("INSR");

		/// <summary>
		/// Description: Assembly operation
		/// FieldName: ASOP
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Assembly operation")]
		public int? M3_ASOP => GetNullableInt("ASOP");

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
		/// Description: Downtime
		/// FieldName: DOWT
		/// FieldType: N
		/// Length: 9
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Downtime")]
		public int? M3_DOWT => GetNullableInt("DOWT");

		/// <summary>
		/// Description: Delay time 1
		/// FieldName: DLY1
		/// FieldType: N
		/// Length: 9
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Delay time 1")]
		public int? M3_DLY1 => GetNullableInt("DLY1");

		/// <summary>
		/// Description: Delay time 2
		/// FieldName: DLY2
		/// FieldType: N
		/// Length: 9
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Delay time 2")]
		public int? M3_DLY2 => GetNullableInt("DLY2");

		/// <summary>
		/// Description: Error code 1
		/// FieldName: FCLA
		/// FieldType: A
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Error code 1")]
		public string M3_FCLA => GetString("FCLA");

		/// <summary>
		/// Description: Error code 2
		/// FieldName: FCL2
		/// FieldType: A
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Error code 2")]
		public string M3_FCL2 => GetString("FCL2");

		/// <summary>
		/// Description: Error code 3
		/// FieldName: FCL3
		/// FieldType: A
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Error code 3")]
		public string M3_FCL3 => GetString("FCL3");

		/// <summary>
		/// Description: Complaint
		/// FieldName: DEID
		/// FieldType: N
		/// Length: 7
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Complaint")]
		public int? M3_DEID => GetNullableInt("DEID");

		/// <summary>
		/// Description: Revision number
		/// FieldName: REVN
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Revision number")]
		public string M3_REVN => GetString("REVN");

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
		/// Description: Entry date
		/// FieldName: RGDT
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Entry date")]
		public DateTime? M3_RGDT => GetNullableDateTime("RGDT");

		/// <summary>
		/// Description: Entry time
		/// FieldName: RGTM
		/// FieldType: N
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Entry time")]
		public int? M3_RGTM => GetNullableInt("RGTM");

		/// <summary>
		/// Description: Change date
		/// FieldName: LMDT
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Change date")]
		public DateTime? M3_LMDT => GetNullableDateTime("LMDT");

		/// <summary>
		/// Description: Change number
		/// FieldName: CHNO
		/// FieldType: N
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Change number")]
		public int? M3_CHNO => GetNullableInt("CHNO");

		/// <summary>
		/// Description: Changed by
		/// FieldName: CHID
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Changed by")]
		public string M3_CHID => GetString("CHID");

		/// <summary>
		/// Description: Setup price
		/// FieldName: SEPR
		/// FieldType: N
		/// Length: 19
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Setup price")]
		public decimal? M3_SEPR => GetNullableDecimal("SEPR");

		/// <summary>
		/// Description: Unit price
		/// FieldName: PIPR
		/// FieldType: N
		/// Length: 19
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Unit price")]
		public decimal? M3_PIPR => GetNullableDecimal("PIPR");

		/// <summary>
		/// Description: Estimated cost
		/// FieldName: ESBU
		/// FieldType: N
		/// Length: 19
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Estimated cost")]
		public decimal? M3_ESBU => GetNullableDecimal("ESBU");

		/// <summary>
		/// Description: Cost center
		/// FieldName: COCE
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Cost center")]
		public string M3_COCE => GetString("COCE");

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
		/// Description: Discount amount
		/// FieldName: DIAL
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Discount amount")]
		public decimal? M3_DIAL => GetNullableDecimal("DIAL");

		/// <summary>
		/// Description: Discount
		/// FieldName: DIPL
		/// FieldType: N
		/// Length: 7
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Discount")]
		public int? M3_DIPL => GetNullableInt("DIPL");

		/// <summary>
		/// Description: Net price
		/// FieldName: NEPR
		/// FieldType: N
		/// Length: 19
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Net price")]
		public decimal? M3_NEPR => GetNullableDecimal("NEPR");

		/// <summary>
		/// Description: Sales price
		/// FieldName: ASP1
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Sales price")]
		public decimal? M3_ASP1 => GetNullableDecimal("ASP1");

		/// <summary>
		/// Description: Man-hour price
		/// FieldName: ALP1
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Man-hour price")]
		public decimal? M3_ALP1 => GetNullableDecimal("ALP1");
	}
}
// EOF
