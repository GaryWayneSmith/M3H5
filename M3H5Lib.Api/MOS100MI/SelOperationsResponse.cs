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
	public partial class SelOperationsResponse : M3BaseRecord 
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
		/// Description: Manufacturing order number
		/// FieldName: MFNO
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Manufacturing order number")]
		public string M3_MFNO => GetString("MFNO");

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
		/// Description: Item description
		/// FieldName: ITDS
		/// FieldType: A
		/// Length: 30
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Item description")]
		public string M3_ITDS => GetString("ITDS");

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
		/// Description: Operation status
		/// FieldName: WOST
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Operation status")]
		public string M3_WOST => GetString("WOST");

		/// <summary>
		/// Description: Sequencing status
		/// FieldName: SEQS
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Sequencing status")]
		public string M3_SEQS => GetString("SEQS");

		/// <summary>
		/// Description: APP work center
		/// FieldName: PLG1
		/// FieldType: A
		/// Length: 8
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("APP work center")]
		public string M3_PLG1 => GetString("PLG1");

		/// <summary>
		/// Description: Finite scheduled resource
		/// FieldName: PLGR
		/// FieldType: A
		/// Length: 8
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Finite scheduled resource")]
		public string M3_PLGR => GetString("PLGR");

		/// <summary>
		/// Description: Forced resource
		/// FieldName: PLGF
		/// FieldType: A
		/// Length: 8
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Forced resource")]
		public string M3_PLGF => GetString("PLGF");

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
		/// Description: Planning area priority
		/// FieldName: PRIO
		/// FieldType: A
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Planning area priority")]
		public string M3_PRIO => GetString("PRIO");

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
		/// Description: Price and time quantity
		/// FieldName: CTCD
		/// FieldType: A
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Price and time quantity")]
		public string M3_CTCD => GetString("CTCD");

		/// <summary>
		/// Description: Setup time
		/// FieldName: SETI
		/// FieldType: N
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Setup time")]
		public long? M3_SETI => GetNullableLong("SETI");

		/// <summary>
		/// Description: Filler
		/// FieldName: FILL
		/// FieldType: A
		/// Length: 20
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Filler")]
		public string M3_FILL => GetString("FILL");

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
		/// Description: Actual setup time
		/// FieldName: UMAS
		/// FieldType: N
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Actual setup time")]
		public long? M3_UMAS => GetNullableLong("UMAS");

		/// <summary>
		/// Description: Actual run time
		/// FieldName: UMAT
		/// FieldType: N
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Actual run time")]
		public long? M3_UMAT => GetNullableLong("UMAT");

		/// <summary>
		/// Description: Manufactured quantity
		/// FieldName: MAQT
		/// FieldType: N
		/// Length: 16
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Manufactured quantity")]
		public decimal? M3_MAQT => GetNullableDecimal("MAQT");

		/// <summary>
		/// Description: Scrapped quantity
		/// FieldName: SCQT
		/// FieldType: N
		/// Length: 16
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Scrapped quantity")]
		public decimal? M3_SCQT => GetNullableDecimal("SCQT");

		/// <summary>
		/// Description: Ordered quantity
		/// FieldName: ORQT
		/// FieldType: N
		/// Length: 16
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Ordered quantity")]
		public decimal? M3_ORQT => GetNullableDecimal("ORQT");

		/// <summary>
		/// Description: Completed quantity
		/// FieldName: NNQT
		/// FieldType: N
		/// Length: 16
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Completed quantity")]
		public decimal? M3_NNQT => GetNullableDecimal("NNQT");

		/// <summary>
		/// Description: Parallel operation overlap code
		/// FieldName: POOC
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Parallel operation overlap code")]
		public string M3_POOC => GetString("POOC");

		/// <summary>
		/// Description: Transit U/M / Overlap's code
		/// FieldName: SLAT
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Transit U/M / Overlap's code")]
		public int? M3_SLAT => GetNullableInt("SLAT");

		/// <summary>
		/// Description: Transport days / Overlap base
		/// FieldName: SLAC
		/// FieldType: N
		/// Length: 16
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Transport days / Overlap base")]
		public decimal? M3_SLAC => GetNullableDecimal("SLAC");

		/// <summary>
		/// Description: Next operation number
		/// FieldName: NXOP
		/// FieldType: N
		/// Length: 4
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Next operation number")]
		public int? M3_NXOP => GetNullableInt("NXOP");

		/// <summary>
		/// Description: APP primary operation number
		/// FieldName: APON
		/// FieldType: N
		/// Length: 4
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("APP primary operation number")]
		public int? M3_APON => GetNullableInt("APON");

		/// <summary>
		/// Description: Resource restriction
		/// FieldName: RESR
		/// FieldType: A
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Resource restriction")]
		public string M3_RESR => GetString("RESR");

		/// <summary>
		/// Description: Splitting key - operation
		/// FieldName: SPLK
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Splitting key - operation")]
		public int? M3_SPLK => GetNullableInt("SPLK");

		/// <summary>
		/// Description: Number of operations after split
		/// FieldName: SPLN
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Number of operations after split")]
		public int? M3_SPLN => GetNullableInt("SPLN");

		/// <summary>
		/// Description: Split quantity
		/// FieldName: SPSZ
		/// FieldType: N
		/// Length: 16
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Split quantity")]
		public decimal? M3_SPSZ => GetNullableDecimal("SPSZ");

		/// <summary>
		/// Description: APP-processed
		/// FieldName: PRAP
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("APP-processed")]
		public int? M3_PRAP => GetNullableInt("PRAP");

		/// <summary>
		/// Description: Change code
		/// FieldName: SPLT
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Change code")]
		public int? M3_SPLT => GetNullableInt("SPLT");

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
		/// FieldName: RPTM
		/// FieldType: N
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Reporting time")]
		public int? M3_RPTM => GetNullableInt("RPTM");

		/// <summary>
		/// Description: Planned start date
		/// FieldName: STDT
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Planned start date")]
		public DateTime? M3_STDT => GetNullableDateTime("STDT");

		/// <summary>
		/// Description: Planned start time
		/// FieldName: MSTI
		/// FieldType: N
		/// Length: 4
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Planned start time")]
		public int? M3_MSTI => GetNullableInt("MSTI");

		/// <summary>
		/// Description: Planned finish date
		/// FieldName: FIDT
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Planned finish date")]
		public DateTime? M3_FIDT => GetNullableDateTime("FIDT");

		/// <summary>
		/// Description: Planned finish time
		/// FieldName: MFTI
		/// FieldType: N
		/// Length: 4
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Planned finish time")]
		public int? M3_MFTI => GetNullableInt("MFTI");

		/// <summary>
		/// Description: Forced start date
		/// FieldName: FRCD
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Forced start date")]
		public DateTime? M3_FRCD => GetNullableDateTime("FRCD");

		/// <summary>
		/// Description: Forced start time
		/// FieldName: FRCT
		/// FieldType: N
		/// Length: 4
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Forced start time")]
		public int? M3_FRCT => GetNullableInt("FRCT");

		/// <summary>
		/// Description: Text line
		/// FieldName: TXT1
		/// FieldType: A
		/// Length: 60
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Text line")]
		public string M3_TXT1 => GetString("TXT1");

		/// <summary>
		/// Description: Text line
		/// FieldName: TXT2
		/// FieldType: A
		/// Length: 60
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Text line")]
		public string M3_TXT2 => GetString("TXT2");

		/// <summary>
		/// Description: Planned number of machines
		/// FieldName: PRNM
		/// FieldType: N
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Planned number of machines")]
		public int? M3_PRNM => GetNullableInt("PRNM");

		/// <summary>
		/// Description: Planned number of workers - setup
		/// FieldName: SENP
		/// FieldType: N
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Planned number of workers - setup")]
		public int? M3_SENP => GetNullableInt("SENP");

		/// <summary>
		/// Description: Planned number of workers - run time
		/// FieldName: PRNP
		/// FieldType: N
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Planned number of workers - run time")]
		public int? M3_PRNP => GetNullableInt("PRNP");

		/// <summary>
		/// Description: Planned number of resources
		/// FieldName: PLNR
		/// FieldType: N
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Planned number of resources")]
		public int? M3_PLNR => GetNullableInt("PLNR");

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
		/// Description: Run time
		/// FieldName: PITI
		/// FieldType: N
		/// Length: 12
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Run time")]
		public decimal? M3_PITI => GetNullableDecimal("PITI");

		/// <summary>
		/// Description: Run time expressed in hours
		/// FieldName: PIT2
		/// FieldType: N
		/// Length: 12
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Run time expressed in hours")]
		public decimal? M3_PIT2 => GetNullableDecimal("PIT2");

		/// <summary>
		/// Description: Infinite/finite
		/// FieldName: WLDE
		/// FieldType: A
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Infinite/finite")]
		public string M3_WLDE => GetString("WLDE");

		/// <summary>
		/// Description: Setup time expressed in hours
		/// FieldName: SET2
		/// FieldType: N
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Setup time expressed in hours")]
		public long? M3_SET2 => GetNullableLong("SET2");

		/// <summary>
		/// Description: Efficiency factor
		/// FieldName: EFFA
		/// FieldType: N
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Efficiency factor")]
		public int? M3_EFFA => GetNullableInt("EFFA");

		/// <summary>
		/// Description: Preparation time
		/// FieldName: PRET
		/// FieldType: N
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Preparation time")]
		public int? M3_PRET => GetNullableInt("PRET");

		/// <summary>
		/// Description: Post-operation time
		/// FieldName: POTM
		/// FieldType: N
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Post-operation time")]
		public int? M3_POTM => GetNullableInt("POTM");

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
		/// Description: Sequence number within schedule
		/// FieldName: SCHS
		/// FieldType: N
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Sequence number within schedule")]
		public long? M3_SCHS => GetNullableLong("SCHS");

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
		/// Description: Run time adjusted for subcontracting
		/// FieldName: PIT3
		/// FieldType: N
		/// Length: 12
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Run time adjusted for subcontracting")]
		public decimal? M3_PIT3 => GetNullableDecimal("PIT3");

		/// <summary>
		/// Description: Max duration of operation in percent
		/// FieldName: MDOP
		/// FieldType: N
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Max duration of operation in percent")]
		public int? M3_MDOP => GetNullableInt("MDOP");

		/// <summary>
		/// Description: Employee number
		/// FieldName: EMNO
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Employee number")]
		public string M3_EMNO => GetString("EMNO");

		/// <summary>
		/// Description: Role/organizational position
		/// FieldName: ROLE
		/// FieldType: A
		/// Length: 20
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Role/organizational position")]
		public string M3_ROLE => GetString("ROLE");

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
		/// Description: Event type
		/// FieldName: EVTY
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Event type")]
		public string M3_EVTY => GetString("EVTY");

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
		/// Description: Requested start date
		/// FieldName: RRSD
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Requested start date")]
		public DateTime? M3_RRSD => GetNullableDateTime("RRSD");

		/// <summary>
		/// Description: Requested start time
		/// FieldName: RRST
		/// FieldType: N
		/// Length: 4
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Requested start time")]
		public int? M3_RRST => GetNullableInt("RRST");

		/// <summary>
		/// Description: Requested finish date
		/// FieldName: RRFD
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Requested finish date")]
		public DateTime? M3_RRFD => GetNullableDateTime("RRFD");

		/// <summary>
		/// Description: Requested finish time
		/// FieldName: RRFT
		/// FieldType: N
		/// Length: 4
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Requested finish time")]
		public int? M3_RRFT => GetNullableInt("RRFT");

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
	}
}
// EOF
