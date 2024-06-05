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

namespace M3H5Lib.Api.PMS100MI
{
	public partial class GetOperationResponse : M3BaseRecord 
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
		/// Description: Product
		/// FieldName: PRNO
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Product")]
		public string M3PRNO => GetString("PRNO");

		/// <summary>
		/// Description: Manufacturing order number
		/// FieldName: MFNO
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Manufacturing order number")]
		public string M3MFNO => GetString("MFNO");

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
		/// Description: Yield quantity
		/// FieldName: BAQT
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Yield quantity")]
		public decimal? M3BAQT => GetNullableDecimal("BAQT");

		/// <summary>
		/// Description: Reporting number
		/// FieldName: WOSQ
		/// FieldType: N
		/// Length: 12
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Reporting number")]
		public decimal? M3WOSQ => GetNullableDecimal("WOSQ");

		/// <summary>
		/// Description: Status
		/// FieldName: WOST
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Status")]
		public string M3WOST => GetString("WOST");

		/// <summary>
		/// Description: Operation number
		/// FieldName: OPNO
		/// FieldType: N
		/// Length: 4
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Operation number")]
		public int? M3OPNO => GetNullableInt("OPNO");

		/// <summary>
		/// Description: Capacity type
		/// FieldName: PCAP
		/// FieldType: A
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Capacity type")]
		public string M3PCAP => GetString("PCAP");

		/// <summary>
		/// Description: Work center
		/// FieldName: PLGR
		/// FieldType: A
		/// Length: 8
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Work center")]
		public string M3PLGR => GetString("PLGR");

		/// <summary>
		/// Description: Operation description
		/// FieldName: OPDS
		/// FieldType: A
		/// Length: 30
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Operation description")]
		public string M3OPDS => GetString("OPDS");

		/// <summary>
		/// Description: Quantity per time unit
		/// FieldName: QTHR
		/// FieldType: N
		/// Length: 11
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Quantity per time unit")]
		public decimal? M3QTHR => GetNullableDecimal("QTHR");

		/// <summary>
		/// Description: Department
		/// FieldName: DEPT
		/// FieldType: A
		/// Length: 8
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Department")]
		public string M3DEPT => GetString("DEPT");

		/// <summary>
		/// Description: Planning area
		/// FieldName: REAR
		/// FieldType: A
		/// Length: 8
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Planning area")]
		public string M3REAR => GetString("REAR");

		/// <summary>
		/// Description: Run time
		/// FieldName: PITI
		/// FieldType: N
		/// Length: 9
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Run time")]
		public int? M3PITI => GetNullableInt("PITI");

		/// <summary>
		/// Description: Time U/M
		/// FieldName: PTUN
		/// FieldType: A
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Time U/M")]
		public string M3PTUN => GetString("PTUN");

		/// <summary>
		/// Description: Price and time quantity
		/// FieldName: CTCD
		/// FieldType: N
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Price and time quantity")]
		public int? M3CTCD => GetNullableInt("CTCD");

		/// <summary>
		/// Description: Setup time
		/// FieldName: SETI
		/// FieldType: N
		/// Length: 9
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Setup time")]
		public int? M3SETI => GetNullableInt("SETI");

		/// <summary>
		/// Description: External setup time
		/// FieldName: OSET
		/// FieldType: N
		/// Length: 9
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("External setup time")]
		public int? M3OSET => GetNullableInt("OSET");

		/// <summary>
		/// Description: Fixed time
		/// FieldName: FXTI
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Fixed time")]
		public int? M3FXTI => GetNullableInt("FXTI");

		/// <summary>
		/// Description: Planned number of machines
		/// FieldName: PRNM
		/// FieldType: N
		/// Length: 7
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Planned number of machines")]
		public int? M3PRNM => GetNullableInt("PRNM");

		/// <summary>
		/// Description: Planned number of workers - run time
		/// FieldName: PRNP
		/// FieldType: N
		/// Length: 7
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Planned number of workers - run time")]
		public int? M3PRNP => GetNullableInt("PRNP");

		/// <summary>
		/// Description: Planned number of workers - setup
		/// FieldName: SENP
		/// FieldType: N
		/// Length: 7
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Planned number of workers - setup")]
		public int? M3SENP => GetNullableInt("SENP");

		/// <summary>
		/// Description: Lead time offset
		/// FieldName: ODBF
		/// FieldType: N
		/// Length: 7
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Lead time offset")]
		public int? M3ODBF => GetNullableInt("ODBF");

		/// <summary>
		/// Description: Production days
		/// FieldName: PRDY
		/// FieldType: N
		/// Length: 7
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Production days")]
		public int? M3PRDY => GetNullableInt("PRDY");

		/// <summary>
		/// Description: Automatic receipt
		/// FieldName: AUIN
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Automatic receipt")]
		public int? M3AUIN => GetNullableInt("AUIN");

		/// <summary>
		/// Description: Automatic operation reporting
		/// FieldName: AURP
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Automatic operation reporting")]
		public int? M3AURP => GetNullableInt("AURP");

		/// <summary>
		/// Description: Scrap percentage
		/// FieldName: SCPC
		/// FieldType: N
		/// Length: 7
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Scrap percentage")]
		public int? M3SCPC => GetNullableInt("SCPC");

		/// <summary>
		/// Description: Infinite/finite
		/// FieldName: WLDE
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Infinite/finite")]
		public int? M3WLDE => GetNullableInt("WLDE");

		/// <summary>
		/// Description: Document identity
		/// FieldName: DOID
		/// FieldType: A
		/// Length: 20
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Document identity")]
		public string M3DOID => GetString("DOID");

		/// <summary>
		/// Description: Tool number
		/// FieldName: TOOL
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Tool number")]
		public string M3TOOL => GetString("TOOL");

		/// <summary>
		/// Description: Lot number control
		/// FieldName: PLLT
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Lot number control")]
		public int? M3PLLT => GetNullableInt("PLLT");

		/// <summary>
		/// Description: Critical resource
		/// FieldName: CRTR
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Critical resource")]
		public int? M3CRTR => GetNullableInt("CRTR");

		/// <summary>
		/// Description: Labor skill
		/// FieldName: LASK
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Labor skill")]
		public string M3LASK => GetString("LASK");

		/// <summary>
		/// Description: Setup scrap
		/// FieldName: SWQT
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Setup scrap")]
		public decimal? M3SWQT => GetNullableDecimal("SWQT");

		/// <summary>
		/// Description: Number of labor tickets
		/// FieldName: CAMP
		/// FieldType: N
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Number of labor tickets")]
		public int? M3CAMP => GetNullableInt("CAMP");

		/// <summary>
		/// Description: Unit price
		/// FieldName: PIPR
		/// FieldType: N
		/// Length: 19
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Unit price")]
		public decimal? M3PIPR => GetNullableDecimal("PIPR");

		/// <summary>
		/// Description: Time rate
		/// FieldName: WAFA
		/// FieldType: N
		/// Length: 19
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Time rate")]
		public decimal? M3WAFA => GetNullableDecimal("WAFA");

		/// <summary>
		/// Description: Setup price
		/// FieldName: SEPR
		/// FieldType: N
		/// Length: 19
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Setup price")]
		public decimal? M3SEPR => GetNullableDecimal("SEPR");

		/// <summary>
		/// Description: Time reference
		/// FieldName: WCRF
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Time reference")]
		public string M3WCRF => GetString("WCRF");

		/// <summary>
		/// Description: Pay element
		/// FieldName: KIWG
		/// FieldType: N
		/// Length: 4
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Pay element")]
		public int? M3KIWG => GetNullableInt("KIWG");

		/// <summary>
		/// Description: Supplier
		/// FieldName: SUNO
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Supplier")]
		public string M3SUNO => GetString("SUNO");

		/// <summary>
		/// Description: Initial weight
		/// FieldName: INWE
		/// FieldType: N
		/// Length: 11
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Initial weight")]
		public decimal? M3INWE => GetNullableDecimal("INWE");

		/// <summary>
		/// Description: Operation volume
		/// FieldName: OPV3
		/// FieldType: N
		/// Length: 11
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Operation volume")]
		public decimal? M3OPV3 => GetNullableDecimal("OPV3");

		/// <summary>
		/// Description: Multiplication factor - manufacturing
		/// FieldName: MFPR
		/// FieldType: N
		/// Length: 7
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Multiplication factor - manufacturing")]
		public int? M3MFPR => GetNullableInt("MFPR");

		/// <summary>
		/// Description: Operation cost multiplier
		/// FieldName: OPCM
		/// FieldType: N
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Operation cost multiplier")]
		public int? M3OPCM => GetNullableInt("OPCM");

		/// <summary>
		/// Description: Text line 1
		/// FieldName: TXT1
		/// FieldType: A
		/// Length: 60
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Text line 1")]
		public string M3TXT1 => GetString("TXT1");

		/// <summary>
		/// Description: Text line 2
		/// FieldName: TXT2
		/// FieldType: A
		/// Length: 60
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Text line 2")]
		public string M3TXT2 => GetString("TXT2");

		/// <summary>
		/// Description: Work center resource
		/// FieldName: PLG6
		/// FieldType: A
		/// Length: 8
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Work center resource")]
		public string M3PLG6 => GetString("PLG6");

		/// <summary>
		/// Description: App operation number
		/// FieldName: APON
		/// FieldType: N
		/// Length: 4
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("App operation number")]
		public int? M3APON => GetNullableInt("APON");

		/// <summary>
		/// Description: Next APP operation number
		/// FieldName: NXOP
		/// FieldType: N
		/// Length: 4
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Next APP operation number")]
		public int? M3NXOP => GetNullableInt("NXOP");

		/// <summary>
		/// Description: Transit unit of measure/Overlap code
		/// FieldName: SLAT
		/// FieldType: A
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Transit unit of measure/Overlap code")]
		public string M3SLAT => GetString("SLAT");

		/// <summary>
		/// Description: Transport value in days
		/// FieldName: SLAC
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Transport value in days")]
		public decimal? M3SLAC => GetNullableDecimal("SLAC");

		/// <summary>
		/// Description: Parallel operation overlap code
		/// FieldName: POOC
		/// FieldType: N
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Parallel operation overlap code")]
		public int? M3POOC => GetNullableInt("POOC");

		/// <summary>
		/// Description: Resource restriction
		/// FieldName: RESR
		/// FieldType: A
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Resource restriction")]
		public string M3RESR => GetString("RESR");

		/// <summary>
		/// Description: Forced resource
		/// FieldName: PLGF
		/// FieldType: A
		/// Length: 8
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Forced resource")]
		public string M3PLGF => GetString("PLGF");

		/// <summary>
		/// Description: Preparation time
		/// FieldName: PRET
		/// FieldType: N
		/// Length: 7
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Preparation time")]
		public int? M3PRET => GetNullableInt("PRET");

		/// <summary>
		/// Description: Post-operation time
		/// FieldName: POTM
		/// FieldType: N
		/// Length: 7
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Post-operation time")]
		public int? M3POTM => GetNullableInt("POTM");

		/// <summary>
		/// Description: Split method - operation
		/// FieldName: SPLK
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Split method - operation")]
		public int? M3SPLK => GetNullableInt("SPLK");

		/// <summary>
		/// Description: Split fixed rate
		/// FieldName: SPLF
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Split fixed rate")]
		public int? M3SPLF => GetNullableInt("SPLF");

		/// <summary>
		/// Description: Number of operations after split
		/// FieldName: SPLN
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Number of operations after split")]
		public int? M3SPLN => GetNullableInt("SPLN");

		/// <summary>
		/// Description: Split quantity
		/// FieldName: SPSZ
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Split quantity")]
		public decimal? M3SPSZ => GetNullableDecimal("SPSZ");

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
		/// Description: Manufactured quantity
		/// FieldName: MAQA
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Manufactured quantity")]
		public decimal? M3MAQA => GetNullableDecimal("MAQA");

		/// <summary>
		/// Description: Scrap quantity alternative unit
		/// FieldName: SCQA
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Scrap quantity alternative unit")]
		public decimal? M3SCQA => GetNullableDecimal("SCQA");

		/// <summary>
		/// Description: Rejection reason
		/// FieldName: SCRE
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Rejection reason")]
		public string M3SCRE => GetString("SCRE");

		/// <summary>
		/// Description: Remaining time
		/// FieldName: RETI
		/// FieldType: N
		/// Length: 9
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Remaining time")]
		public int? M3RETI => GetNullableInt("RETI");

		/// <summary>
		/// Description: Used labor run time
		/// FieldName: UMAT
		/// FieldType: N
		/// Length: 9
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Used labor run time")]
		public int? M3UMAT => GetNullableInt("UMAT");

		/// <summary>
		/// Description: Used labor setup time
		/// FieldName: UMAS
		/// FieldType: N
		/// Length: 9
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Used labor setup time")]
		public int? M3UMAS => GetNullableInt("UMAS");

		/// <summary>
		/// Description: Used machine run time
		/// FieldName: UPIT
		/// FieldType: N
		/// Length: 9
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Used machine run time")]
		public int? M3UPIT => GetNullableInt("UPIT");

		/// <summary>
		/// Description: Used machine setup time
		/// FieldName: USET
		/// FieldType: N
		/// Length: 9
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Used machine setup time")]
		public int? M3USET => GetNullableInt("USET");

		/// <summary>
		/// Description: Start date
		/// FieldName: STDT
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Start date")]
		public DateTime? M3STDT => GetNullableDateTime("STDT");

		/// <summary>
		/// Description: Start time
		/// FieldName: MSTI
		/// FieldType: N
		/// Length: 4
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Start time")]
		public int? M3MSTI => GetNullableInt("MSTI");

		/// <summary>
		/// Description: Finish date
		/// FieldName: FIDT
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Finish date")]
		public DateTime? M3FIDT => GetNullableDateTime("FIDT");

		/// <summary>
		/// Description: Finish time
		/// FieldName: MFTI
		/// FieldType: N
		/// Length: 4
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Finish time")]
		public int? M3MFTI => GetNullableInt("MFTI");

		/// <summary>
		/// Description: Actual start date
		/// FieldName: RSDT
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Actual start date")]
		public DateTime? M3RSDT => GetNullableDateTime("RSDT");

		/// <summary>
		/// Description: Actual finish date
		/// FieldName: REFD
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Actual finish date")]
		public DateTime? M3REFD => GetNullableDateTime("REFD");

		/// <summary>
		/// Description: Reporting date
		/// FieldName: RPDT
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Reporting date")]
		public DateTime? M3RPDT => GetNullableDateTime("RPDT");

		/// <summary>
		/// Description: Order documents printed
		/// FieldName: WODP
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Order documents printed")]
		public int? M3WODP => GetNullableInt("WODP");

		/// <summary>
		/// Description: Deviating work center
		/// FieldName: DPLG
		/// FieldType: A
		/// Length: 8
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Deviating work center")]
		public string M3DPLG => GetString("DPLG");
	}
}
// EOF
