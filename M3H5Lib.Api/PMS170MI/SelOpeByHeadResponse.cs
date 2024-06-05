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

namespace M3H5Lib.Api.PMS170MI
{
	public partial class SelOpeByHeadResponse : M3BaseRecord 
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
		/// Description: Proposal number
		/// FieldName: PLPN
		/// FieldType: N
		/// Length: 7
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Proposal number")]
		public int? M3PLPN => GetNullableInt("PLPN");

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
		/// Description: Sequencing status
		/// FieldName: SEQS
		/// FieldType: N
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Sequencing status")]
		public int? M3SEQS => GetNullableInt("SEQS");

		/// <summary>
		/// Description: APP work center
		/// FieldName: PLG1
		/// FieldType: A
		/// Length: 8
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("APP work center")]
		public string M3PLG1 => GetString("PLG1");

		/// <summary>
		/// Description: Finite scheduled resource
		/// FieldName: PLGR
		/// FieldType: A
		/// Length: 8
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Finite scheduled resource")]
		public string M3PLGR => GetString("PLGR");

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
		/// Description: Planning area priority
		/// FieldName: PRIO
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Planning area priority")]
		public int? M3PRIO => GetNullableInt("PRIO");

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
		/// Description: Setup time expressed in W/C time U/M
		/// FieldName: SETI
		/// FieldType: N
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Setup time expressed in W/C time U/M")]
		public long? M3SETI => GetNullableLong("SETI");

		/// <summary>
		/// Description: Filler
		/// FieldName: FILL
		/// FieldType: A
		/// Length: 20
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Filler")]
		public string M3FILL => GetString("FILL");

		/// <summary>
		/// Description: Co-sorting key
		/// FieldName: PSSQ
		/// FieldType: A
		/// Length: 20
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Co-sorting key")]
		public string M3PSSQ => GetString("PSSQ");

		/// <summary>
		/// Description: Ordered quantity - basic U/M
		/// FieldName: ORQT
		/// FieldType: N
		/// Length: 16
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Ordered quantity - basic U/M")]
		public decimal? M3ORQT => GetNullableDecimal("ORQT");

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
		/// Description: Transit U/M / Overlap's code
		/// FieldName: SLAT
		/// FieldType: A
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Transit U/M / Overlap's code")]
		public string M3SLAT => GetString("SLAT");

		/// <summary>
		/// Description: Transport days / Overlap base
		/// FieldName: SLAC
		/// FieldType: N
		/// Length: 16
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Transport days / Overlap base")]
		public decimal? M3SLAC => GetNullableDecimal("SLAC");

		/// <summary>
		/// Description: Next operation number
		/// FieldName: NXOP
		/// FieldType: N
		/// Length: 4
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Next operation number")]
		public int? M3NXOP => GetNullableInt("NXOP");

		/// <summary>
		/// Description: APP primary operation number
		/// FieldName: APON
		/// FieldType: N
		/// Length: 4
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("APP primary operation number")]
		public int? M3APON => GetNullableInt("APON");

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
		/// Description: Number of operations after split
		/// FieldName: SPLN
		/// FieldType: A
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Number of operations after split")]
		public string M3SPLN => GetString("SPLN");

		/// <summary>
		/// Description: Splitting key - operation
		/// FieldName: SPLK
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Splitting key - operation")]
		public int? M3SPLK => GetNullableInt("SPLK");

		/// <summary>
		/// Description: Split quantity
		/// FieldName: SPSZ
		/// FieldType: N
		/// Length: 16
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Split quantity")]
		public decimal? M3SPSZ => GetNullableDecimal("SPSZ");

		/// <summary>
		/// Description: APP-processed
		/// FieldName: PRAP
		/// FieldType: A
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("APP-processed")]
		public string M3PRAP => GetString("PRAP");

		/// <summary>
		/// Description: Split quantity
		/// FieldName: SPLT
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Split quantity")]
		public int? M3SPLT => GetNullableInt("SPLT");

		/// <summary>
		/// Description: Planned start date
		/// FieldName: STDT
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Planned start date")]
		public DateTime? M3STDT => GetNullableDateTime("STDT");

		/// <summary>
		/// Description: Planned start time
		/// FieldName: MSTI
		/// FieldType: N
		/// Length: 4
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Planned start time")]
		public int? M3MSTI => GetNullableInt("MSTI");

		/// <summary>
		/// Description: Planned finish date
		/// FieldName: FIDT
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Planned finish date")]
		public DateTime? M3FIDT => GetNullableDateTime("FIDT");

		/// <summary>
		/// Description: Planned finish time
		/// FieldName: MFTI
		/// FieldType: N
		/// Length: 4
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Planned finish time")]
		public int? M3MFTI => GetNullableInt("MFTI");

		/// <summary>
		/// Description: Forced start date
		/// FieldName: FRCD
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Forced start date")]
		public DateTime? M3FRCD => GetNullableDateTime("FRCD");

		/// <summary>
		/// Description: Forced start time
		/// FieldName: FRCT
		/// FieldType: N
		/// Length: 4
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Forced start time")]
		public int? M3FRCT => GetNullableInt("FRCT");

		/// <summary>
		/// Description: Text line
		/// FieldName: TXT1
		/// FieldType: A
		/// Length: 60
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Text line")]
		public string M3TXT1 => GetString("TXT1");

		/// <summary>
		/// Description: Text line
		/// FieldName: TXT2
		/// FieldType: A
		/// Length: 60
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Text line")]
		public string M3TXT2 => GetString("TXT2");

		/// <summary>
		/// Description: Planned number of machines
		/// FieldName: PRNM
		/// FieldType: A
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Planned number of machines")]
		public string M3PRNM => GetString("PRNM");

		/// <summary>
		/// Description: Planned number of persons - setup
		/// FieldName: SENP
		/// FieldType: N
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Planned number of persons - setup")]
		public int? M3SENP => GetNullableInt("SENP");

		/// <summary>
		/// Description: Planned number of persons - runtime
		/// FieldName: PRNP
		/// FieldType: A
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Planned number of persons - runtime")]
		public string M3PRNP => GetString("PRNP");

		/// <summary>
		/// Description: Planned number of resources
		/// FieldName: PLNR
		/// FieldType: A
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Planned number of resources")]
		public string M3PLNR => GetString("PLNR");

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
		/// Description: Change number
		/// FieldName: CHNO
		/// FieldType: N
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Change number")]
		public int? M3CHNO => GetNullableInt("CHNO");

		/// <summary>
		/// Description: Changed by
		/// FieldName: CHID
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Changed by")]
		public string M3CHID => GetString("CHID");

		/// <summary>
		/// Description: Run time
		/// FieldName: PITI
		/// FieldType: N
		/// Length: 12
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Run time")]
		public decimal? M3PITI => GetNullableDecimal("PITI");

		/// <summary>
		/// Description: Run time expressed in hours
		/// FieldName: PIT2
		/// FieldType: N
		/// Length: 12
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Run time expressed in hours")]
		public decimal? M3PIT2 => GetNullableDecimal("PIT2");

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
		/// Description: Product number
		/// FieldName: PRN1
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Product number")]
		public string M3PRN1 => GetString("PRN1");

		/// <summary>
		/// Description: Setup time expressed in hours
		/// FieldName: SET2
		/// FieldType: N
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Setup time expressed in hours")]
		public long? M3SET2 => GetNullableLong("SET2");

		/// <summary>
		/// Description: Efficiency factor
		/// FieldName: EFFA
		/// FieldType: N
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Efficiency factor")]
		public int? M3EFFA => GetNullableInt("EFFA");

		/// <summary>
		/// Description: Preparation time
		/// FieldName: PRET
		/// FieldType: N
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Preparation time")]
		public int? M3PRET => GetNullableInt("PRET");

		/// <summary>
		/// Description: Post-operation time
		/// FieldName: POTM
		/// FieldType: N
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Post-operation time")]
		public int? M3POTM => GetNullableInt("POTM");

		/// <summary>
		/// Description: Alternate routing 01
		/// FieldName: AO01
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Alternate routing 01")]
		public string M3AO01 => GetString("AO01");

		/// <summary>
		/// Description: Alternate routing 02
		/// FieldName: AO02
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Alternate routing 02")]
		public string M3AO02 => GetString("AO02");

		/// <summary>
		/// Description: Alternate routing 03
		/// FieldName: AO03
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Alternate routing 03")]
		public string M3AO03 => GetString("AO03");

		/// <summary>
		/// Description: Alternate routing 04
		/// FieldName: AO04
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Alternate routing 04")]
		public string M3AO04 => GetString("AO04");

		/// <summary>
		/// Description: Alternate routing 05
		/// FieldName: AO05
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Alternate routing 05")]
		public string M3AO05 => GetString("AO05");

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
		/// Description: Sequence number in schedule
		/// FieldName: SCHS
		/// FieldType: N
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Sequence number in schedule")]
		public long? M3SCHS => GetNullableLong("SCHS");

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
		/// Description: Run time adjusted for subcontracting
		/// FieldName: PIT3
		/// FieldType: N
		/// Length: 12
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Run time adjusted for subcontracting")]
		public decimal? M3PIT3 => GetNullableDecimal("PIT3");

		/// <summary>
		/// Description: Max percentage duration of operation
		/// FieldName: MDOP
		/// FieldType: N
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Max percentage duration of operation")]
		public int? M3MDOP => GetNullableInt("MDOP");

		/// <summary>
		/// Description: Subcontracted control
		/// FieldName: SUBC
		/// FieldType: A
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Subcontracted control")]
		public string M3SUBC => GetString("SUBC");

		/// <summary>
		/// Description: Runtime(hours) for altrouting 01
		/// FieldName: PI01
		/// FieldType: N
		/// Length: 12
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Runtime(hours) for altrouting 01")]
		public decimal? M3PI01 => GetNullableDecimal("PI01");

		/// <summary>
		/// Description: Runtime(hours) for altrouting 02
		/// FieldName: PI02
		/// FieldType: N
		/// Length: 12
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Runtime(hours) for altrouting 02")]
		public decimal? M3PI02 => GetNullableDecimal("PI02");

		/// <summary>
		/// Description: Runtime(hours) for altrouting 03
		/// FieldName: PI03
		/// FieldType: N
		/// Length: 12
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Runtime(hours) for altrouting 03")]
		public decimal? M3PI03 => GetNullableDecimal("PI03");

		/// <summary>
		/// Description: Runtime(hours) for altrouting 04
		/// FieldName: PI04
		/// FieldType: N
		/// Length: 12
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Runtime(hours) for altrouting 04")]
		public decimal? M3PI04 => GetNullableDecimal("PI04");

		/// <summary>
		/// Description: Runtime(hours) for altrouting 05
		/// FieldName: PI05
		/// FieldType: N
		/// Length: 12
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Runtime(hours) for altrouting 05")]
		public decimal? M3PI05 => GetNullableDecimal("PI05");

		/// <summary>
		/// Description: Remaining buffer percentage
		/// FieldName: RBUP
		/// FieldType: N
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Remaining buffer percentage")]
		public int? M3RBUP => GetNullableInt("RBUP");

		/// <summary>
		/// Description: Alternate routing 06
		/// FieldName: AO06
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Alternate routing 06")]
		public string M3AO06 => GetString("AO06");

		/// <summary>
		/// Description: Alternate routing 07
		/// FieldName: AO07
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Alternate routing 07")]
		public string M3AO07 => GetString("AO07");

		/// <summary>
		/// Description: Alternate routing 08
		/// FieldName: AO08
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Alternate routing 08")]
		public string M3AO08 => GetString("AO08");

		/// <summary>
		/// Description: Alternate routing 09
		/// FieldName: AO09
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Alternate routing 09")]
		public string M3AO09 => GetString("AO09");

		/// <summary>
		/// Description: Alternate routing 10
		/// FieldName: AO10
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Alternate routing 10")]
		public string M3AO10 => GetString("AO10");

		/// <summary>
		/// Description: Alternate routing 11
		/// FieldName: AO11
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Alternate routing 11")]
		public string M3AO11 => GetString("AO11");

		/// <summary>
		/// Description: Alternate routing 12
		/// FieldName: AO12
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Alternate routing 12")]
		public string M3AO12 => GetString("AO12");

		/// <summary>
		/// Description: Alternate routing 13
		/// FieldName: AO13
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Alternate routing 13")]
		public string M3AO13 => GetString("AO13");

		/// <summary>
		/// Description: Alternate routing 14
		/// FieldName: AO14
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Alternate routing 14")]
		public string M3AO14 => GetString("AO14");

		/// <summary>
		/// Description: Alternate routing 15
		/// FieldName: AO15
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Alternate routing 15")]
		public string M3AO15 => GetString("AO15");

		/// <summary>
		/// Description: Alternate routing 16
		/// FieldName: AO16
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Alternate routing 16")]
		public string M3AO16 => GetString("AO16");

		/// <summary>
		/// Description: Alternate routing 17
		/// FieldName: AO17
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Alternate routing 17")]
		public string M3AO17 => GetString("AO17");

		/// <summary>
		/// Description: Alternate routing 18
		/// FieldName: AO18
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Alternate routing 18")]
		public string M3AO18 => GetString("AO18");

		/// <summary>
		/// Description: Alternate routing 19
		/// FieldName: AO19
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Alternate routing 19")]
		public string M3AO19 => GetString("AO19");

		/// <summary>
		/// Description: Alternate routing 20
		/// FieldName: AO20
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Alternate routing 20")]
		public string M3AO20 => GetString("AO20");

		/// <summary>
		/// Description: Alternate routing 21
		/// FieldName: AO21
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Alternate routing 21")]
		public string M3AO21 => GetString("AO21");

		/// <summary>
		/// Description: Alternate routing 22
		/// FieldName: AO22
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Alternate routing 22")]
		public string M3AO22 => GetString("AO22");

		/// <summary>
		/// Description: Alternate routing 23
		/// FieldName: AO23
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Alternate routing 23")]
		public string M3AO23 => GetString("AO23");

		/// <summary>
		/// Description: Alternate routing 24
		/// FieldName: AO24
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Alternate routing 24")]
		public string M3AO24 => GetString("AO24");

		/// <summary>
		/// Description: Alternate routing 25
		/// FieldName: AO25
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Alternate routing 25")]
		public string M3AO25 => GetString("AO25");

		/// <summary>
		/// Description: Alternate routing 26
		/// FieldName: AO26
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Alternate routing 26")]
		public string M3AO26 => GetString("AO26");

		/// <summary>
		/// Description: Alternate routing 27
		/// FieldName: AO27
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Alternate routing 27")]
		public string M3AO27 => GetString("AO27");

		/// <summary>
		/// Description: Alternate routing 28
		/// FieldName: AO28
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Alternate routing 28")]
		public string M3AO28 => GetString("AO28");

		/// <summary>
		/// Description: Alternate routing 29
		/// FieldName: AO29
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Alternate routing 29")]
		public string M3AO29 => GetString("AO29");

		/// <summary>
		/// Description: Alternate routing 30
		/// FieldName: AO30
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Alternate routing 30")]
		public string M3AO30 => GetString("AO30");
	}
}
// EOF
