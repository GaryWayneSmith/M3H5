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

namespace M3H5Lib.Api.EQINFOMI
{
	public partial class GetServiceHistResponse : M3BaseRecord 
	{

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
		/// Description: Planned order
		/// FieldName: PLPN
		/// FieldType: N
		/// Length: 7
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Planned order")]
		public int? M3PLPN => GetNullableInt("PLPN");

		/// <summary>
		/// Description: Subnumber - planned order
		/// FieldName: PLPS
		/// FieldType: N
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Subnumber - planned order")]
		public int? M3PLPS => GetNullableInt("PLPS");

		/// <summary>
		/// Description: Subnumber - order proposal
		/// FieldName: PLP2
		/// FieldType: N
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Subnumber - order proposal")]
		public int? M3PLP2 => GetNullableInt("PLP2");

		/// <summary>
		/// Description: Generation reference
		/// FieldName: GETY
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Generation reference")]
		public string M3GETY => GetString("GETY");

		/// <summary>
		/// Description: Action message (AM)
		/// FieldName: ACTP
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Action message (AM)")]
		public string M3ACTP => GetString("ACTP");

		/// <summary>
		/// Description: Release date
		/// FieldName: RELD
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Release date")]
		public DateTime? M3RELD => GetNullableDateTime("RELD");

		/// <summary>
		/// Description: Release time
		/// FieldName: RELT
		/// FieldType: N
		/// Length: 4
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Release time")]
		public int? M3RELT => GetNullableInt("RELT");

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
		/// Description: Planning date
		/// FieldName: PLDT
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Planning date")]
		public DateTime? M3PLDT => GetNullableDateTime("PLDT");

		/// <summary>
		/// Description: Planned quantity
		/// FieldName: PPQT
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Planned quantity")]
		public decimal? M3PPQT => GetNullableDecimal("PPQT");

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
		/// Description: Status - planned MO
		/// FieldName: PSTS
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Status - planned MO")]
		public string M3PSTS => GetString("PSTS");

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
		/// Description: Reference order category
		/// FieldName: RORC
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Reference order category")]
		public int? M3RORC => GetNullableInt("RORC");

		/// <summary>
		/// Description: Status - manufacturing order
		/// FieldName: WHST
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Status - manufacturing order")]
		public string M3WHST => GetString("WHST");

		/// <summary>
		/// Description: Order type
		/// FieldName: ORTY
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Order type")]
		public string M3ORTY => GetString("ORTY");

		/// <summary>
		/// Description: Program name
		/// FieldName: PGNM
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Program name")]
		public string M3PGNM => GetString("PGNM");

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
		/// Description: Group technology class
		/// FieldName: GRTI
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Group technology class")]
		public string M3GRTI => GetString("GRTI");

		/// <summary>
		/// Description: Schedule number
		/// FieldName: SCHN
		/// FieldType: N
		/// Length: 11
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Schedule number")]
		public decimal? M3SCHN => GetNullableDecimal("SCHN");

		/// <summary>
		/// Description: Engineering order number
		/// FieldName: AECN
		/// FieldType: A
		/// Length: 7
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Engineering order number")]
		public string M3AECN => GetString("AECN");

		/// <summary>
		/// Description: Next item number
		/// FieldName: NHAI
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Next item number")]
		public string M3NHAI => GetString("NHAI");

		/// <summary>
		/// Description: Next serial number
		/// FieldName: NHSN
		/// FieldType: A
		/// Length: 20
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Next serial number")]
		public string M3NHSN => GetString("NHSN");

		/// <summary>
		/// Description: Approved by
		/// FieldName: APRB
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Approved by")]
		public string M3APRB => GetString("APRB");

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
		/// Description: Meter value 1
		/// FieldName: MVA1
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Meter value 1")]
		public decimal? M3MVA1 => GetNullableDecimal("MVA1");

		/// <summary>
		/// Description: Meter value 2
		/// FieldName: MVA2
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Meter value 2")]
		public decimal? M3MVA2 => GetNullableDecimal("MVA2");

		/// <summary>
		/// Description: Meter value 3
		/// FieldName: MVA3
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Meter value 3")]
		public decimal? M3MVA3 => GetNullableDecimal("MVA3");

		/// <summary>
		/// Description: Meter value 4
		/// FieldName: MVA4
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Meter value 4")]
		public decimal? M3MVA4 => GetNullableDecimal("MVA4");

		/// <summary>
		/// Description: Selected meter
		/// FieldName: METE
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Selected meter")]
		public int? M3METE => GetNullableInt("METE");

		/// <summary>
		/// Description: Actual meter value 1
		/// FieldName: MVB1
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Actual meter value 1")]
		public decimal? M3MVB1 => GetNullableDecimal("MVB1");

		/// <summary>
		/// Description: Actual meter value 2
		/// FieldName: MVB2
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Actual meter value 2")]
		public decimal? M3MVB2 => GetNullableDecimal("MVB2");

		/// <summary>
		/// Description: Actual meter value 3
		/// FieldName: MVB3
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Actual meter value 3")]
		public decimal? M3MVB3 => GetNullableDecimal("MVB3");

		/// <summary>
		/// Description: Actual meter value 4
		/// FieldName: MVB4
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Actual meter value 4")]
		public decimal? M3MVB4 => GetNullableDecimal("MVB4");

		/// <summary>
		/// Description: Meter 1
		/// FieldName: MES1
		/// FieldType: A
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Meter 1")]
		public string M3MES1 => GetString("MES1");

		/// <summary>
		/// Description: Meter 2
		/// FieldName: MES2
		/// FieldType: A
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Meter 2")]
		public string M3MES2 => GetString("MES2");

		/// <summary>
		/// Description: Meter 3
		/// FieldName: MES3
		/// FieldType: A
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Meter 3")]
		public string M3MES3 => GetString("MES3");

		/// <summary>
		/// Description: Meter 4
		/// FieldName: MES4
		/// FieldType: A
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Meter 4")]
		public string M3MES4 => GetString("MES4");

		/// <summary>
		/// Description: Origin identity
		/// FieldName: BIRT
		/// FieldType: N
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Origin identity")]
		public long? M3BIRT => GetNullableLong("BIRT");

		/// <summary>
		/// Description: Main product number
		/// FieldName: MPRN
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Main product number")]
		public string M3MPRN => GetString("MPRN");

		/// <summary>
		/// Description: Main structure type
		/// FieldName: MSTR
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Main structure type")]
		public string M3MSTR => GetString("MSTR");

		/// <summary>
		/// Description: Main service
		/// FieldName: MSUF
		/// FieldType: A
		/// Length: 20
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Main service")]
		public string M3MSUF => GetString("MSUF");

		/// <summary>
		/// Description: Work order number
		/// FieldName: MWNO
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Work order number")]
		public string M3MWNO => GetString("MWNO");

		/// <summary>
		/// Description: NHA configuration position
		/// FieldName: CFGH
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("NHA configuration position")]
		public string M3CFGH => GetString("CFGH");

		/// <summary>
		/// Description: Request budget amount
		/// FieldName: RBAM
		/// FieldType: N
		/// Length: 19
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Request budget amount")]
		public decimal? M3RBAM => GetNullableDecimal("RBAM");

		/// <summary>
		/// Description: Event type
		/// FieldName: EVTY
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Event type")]
		public string M3EVTY => GetString("EVTY");

		/// <summary>
		/// Description: Requester
		/// FieldName: RREQ
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Requester")]
		public string M3RREQ => GetString("RREQ");

		/// <summary>
		/// Description: Estimated cost
		/// FieldName: ESBU
		/// FieldType: N
		/// Length: 19
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Estimated cost")]
		public decimal? M3ESBU => GetNullableDecimal("ESBU");

		/// <summary>
		/// Description: Original start date
		/// FieldName: QSDT
		/// FieldType: D
		/// Length: 8
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Original start date")]
		public DateTime? M3QSDT => GetNullableDateTime("QSDT");

		/// <summary>
		/// Description: Original start time
		/// FieldName: QSTT
		/// FieldType: N
		/// Length: 4
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Original start time")]
		public int? M3QSTT => GetNullableInt("QSTT");

		/// <summary>
		/// Description: Original finish date
		/// FieldName: QFID
		/// FieldType: N
		/// Length: 8
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Original finish date")]
		public int? M3QFID => GetNullableInt("QFID");

		/// <summary>
		/// Description: Original finish time
		/// FieldName: QFIT
		/// FieldType: N
		/// Length: 4
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Original finish time")]
		public int? M3QFIT => GetNullableInt("QFIT");

		/// <summary>
		/// Description: Planner receipt date
		/// FieldName: PLRD
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Planner receipt date")]
		public DateTime? M3PLRD => GetNullableDateTime("PLRD");

		/// <summary>
		/// Description: Planner receipt time
		/// FieldName: PLRT
		/// FieldType: N
		/// Length: 4
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Planner receipt time")]
		public int? M3PLRT => GetNullableInt("PLRT");

		/// <summary>
		/// Description: Approval date
		/// FieldName: AAPD
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Approval date")]
		public DateTime? M3AAPD => GetNullableDateTime("AAPD");

		/// <summary>
		/// Description: Approval time
		/// FieldName: AAPT
		/// FieldType: N
		/// Length: 4
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Approval time")]
		public int? M3AAPT => GetNullableInt("AAPT");

		/// <summary>
		/// Description: Rejection date
		/// FieldName: REJD
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Rejection date")]
		public DateTime? M3REJD => GetNullableDateTime("REJD");

		/// <summary>
		/// Description: Rejection time
		/// FieldName: REJT
		/// FieldType: N
		/// Length: 4
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Rejection time")]
		public int? M3REJT => GetNullableInt("REJT");

		/// <summary>
		/// Description: Timestamp
		/// FieldName: LMTS
		/// FieldType: N
		/// Length: 18
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Timestamp")]
		public decimal? M3LMTS => GetNullableDecimal("LMTS");

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
		/// Description: Requested start date
		/// FieldName: RRSD
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Requested start date")]
		public DateTime? M3RRSD => GetNullableDateTime("RRSD");

		/// <summary>
		/// Description: Requested start time
		/// FieldName: RRST
		/// FieldType: N
		/// Length: 4
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Requested start time")]
		public int? M3RRST => GetNullableInt("RRST");

		/// <summary>
		/// Description: Requested finish date
		/// FieldName: RRFD
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Requested finish date")]
		public DateTime? M3RRFD => GetNullableDateTime("RRFD");

		/// <summary>
		/// Description: Requested finish time
		/// FieldName: RRFT
		/// FieldType: N
		/// Length: 4
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Requested finish time")]
		public int? M3RRFT => GetNullableInt("RRFT");

		/// <summary>
		/// Description: Estimated downtime
		/// FieldName: EDWT
		/// FieldType: N
		/// Length: 9
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Estimated downtime")]
		public int? M3EDWT => GetNullableInt("EDWT");
	}
}
// EOF
