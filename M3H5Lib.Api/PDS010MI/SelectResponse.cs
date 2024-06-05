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

namespace M3H5Lib.Api.PDS010MI
{
	public partial class SelectResponse : M3BaseRecord 
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
		/// Description: Resource type
		/// FieldName: PLTP
		/// FieldType: A
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Resource type")]
		public string M3_PLTP => GetString("PLTP");

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
		/// Description: Work center name
		/// FieldName: PLNM
		/// FieldType: A
		/// Length: 36
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Work center name")]
		public string M3_PLNM => GetString("PLNM");

		/// <summary>
		/// Description: Production line
		/// FieldName: PRLN
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Production line")]
		public int? M3_PRLN => GetNullableInt("PRLN");

		/// <summary>
		/// Description: Efficiency control
		/// FieldName: EFCH
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Efficiency control")]
		public int? M3_EFCH => GetNullableInt("EFCH");

		/// <summary>
		/// Description: Efficiency rate
		/// FieldName: EFFA
		/// FieldType: N
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Efficiency rate")]
		public int? M3_EFFA => GetNullableInt("EFFA");

		/// <summary>
		/// Description: Utilization rate
		/// FieldName: AVEF
		/// FieldType: A
		/// Length: 4
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Utilization rate")]
		public string M3_AVEF => GetString("AVEF");

		/// <summary>
		/// Description: W/C Responsible
		/// FieldName: WCRE
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("W/C Responsible")]
		public string M3_WCRE => GetString("WCRE");

		/// <summary>
		/// Description: Capacity type (man/machine)
		/// FieldName: PCAP
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Capacity type (man/machine)")]
		public int? M3_PCAP => GetNullableInt("PCAP");

		/// <summary>
		/// Description: W/C time init of measurement
		/// FieldName: PTUN
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("W/C time init of measurement")]
		public int? M3_PTUN => GetNullableInt("PTUN");

		/// <summary>
		/// Description: Number of machines
		/// FieldName: WCNM
		/// FieldType: A
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Number of machines")]
		public string M3_WCNM => GetString("WCNM");

		/// <summary>
		/// Description: Number of people
		/// FieldName: WCNP
		/// FieldType: A
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Number of people")]
		public string M3_WCNP => GetString("WCNP");

		/// <summary>
		/// Description: Shift pattern
		/// FieldName: SHPA
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Shift pattern")]
		public string M3_SHPA => GetString("SHPA");

		/// <summary>
		/// Description: Transit U/M
		/// FieldName: SLAT
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Transit U/M")]
		public int? M3_SLAT => GetNullableInt("SLAT");

		/// <summary>
		/// Description: Co-sorting identity
		/// FieldName: PSQT
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Co-sorting identity")]
		public int? M3_PSQT => GetNullableInt("PSQT");

		/// <summary>
		/// Description: Load reduction method
		/// FieldName: RWCD
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Load reduction method")]
		public int? M3_RWCD => GetNullableInt("RWCD");

		/// <summary>
		/// Description: Queue days
		/// FieldName: QUDY
		/// FieldType: A
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Queue days")]
		public string M3_QUDY => GetString("QUDY");

		/// <summary>
		/// Description: Flow Resource
		/// FieldName: KYRE
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Flow Resource")]
		public int? M3_KYRE => GetNullableInt("KYRE");

		/// <summary>
		/// Description: Finite/infinite
		/// FieldName: WLDE
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Finite/infinite")]
		public int? M3_WLDE => GetNullableInt("WLDE");

		/// <summary>
		/// Description: Transport value
		/// FieldName: SLAC
		/// FieldType: N
		/// Length: 16
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Transport value")]
		public decimal? M3_SLAC => GetNullableDecimal("SLAC");

		/// <summary>
		/// Description: Time reference
		/// FieldName: WCRF
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Time reference")]
		public string M3_WCRF => GetString("WCRF");

		/// <summary>
		/// Description: Sequencing priority
		/// FieldName: SEQP
		/// FieldType: A
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Sequencing priority")]
		public string M3_SEQP => GetString("SEQP");

		/// <summary>
		/// Description: Activity color
		/// FieldName: ACOL
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Activity color")]
		public string M3_ACOL => GetString("ACOL");

		/// <summary>
		/// Description: Set-up time standard
		/// FieldName: SETI
		/// FieldType: A
		/// Length: 8
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Set-up time standard")]
		public string M3_SETI => GetString("SETI");

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
		/// Description: Continuous post-operation time
		/// FieldName: CPOT
		/// FieldType: N
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Continuous post-operation time")]
		public int? M3_CPOT => GetNullableInt("CPOT");

		/// <summary>
		/// Description: Operator time factor
		/// FieldName: MPTF
		/// FieldType: N
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Operator time factor")]
		public int? M3_MPTF => GetNullableInt("MPTF");

		/// <summary>
		/// Description: Load principle
		/// FieldName: LDPR
		/// FieldType: A
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Load principle")]
		public string M3_LDPR => GetString("LDPR");

		/// <summary>
		/// Description: Fill method
		/// FieldName: FUMT
		/// FieldType: A
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Fill method")]
		public string M3_FUMT => GetString("FUMT");

		/// <summary>
		/// Description: Max hours/day
		/// FieldName: MAHD
		/// FieldType: N
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Max hours/day")]
		public int? M3_MAHD => GetNullableInt("MAHD");

		/// <summary>
		/// Description: Minimum restriction
		/// FieldName: MINR
		/// FieldType: A
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Minimum restriction")]
		public string M3_MINR => GetString("MINR");

		/// <summary>
		/// Description: Maximum restriction
		/// FieldName: MAXR
		/// FieldType: A
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Maximum restriction")]
		public string M3_MAXR => GetString("MAXR");

		/// <summary>
		/// Description: Group max
		/// FieldName: GRMX
		/// FieldType: A
		/// Length: 9
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Group max")]
		public string M3_GRMX => GetString("GRMX");

		/// <summary>
		/// Description: Group max U/M
		/// FieldName: GRMU
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Group max U/M")]
		public int? M3_GRMU => GetNullableInt("GRMU");

		/// <summary>
		/// Description: Average load percent
		/// FieldName: AVFL
		/// FieldType: N
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Average load percent")]
		public int? M3_AVFL => GetNullableInt("AVFL");

		/// <summary>
		/// Description: Average queue time
		/// FieldName: AVQT
		/// FieldType: N
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Average queue time")]
		public int? M3_AVQT => GetNullableInt("AVQT");

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
		/// Description: Capacity level
		/// FieldName: CAPL
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Capacity level")]
		public string M3_CAPL => GetString("CAPL");

		/// <summary>
		/// Description: Bottleneck planning
		/// FieldName: BONE
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Bottleneck planning")]
		public int? M3_BONE => GetNullableInt("BONE");

		/// <summary>
		/// Description: Work Zone
		/// FieldName: APLC
		/// FieldType: A
		/// Length: 8
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Work Zone")]
		public string M3_APLC => GetString("APLC");

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
		/// Description: Number of resources
		/// FieldName: WCNR
		/// FieldType: N
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Number of resources")]
		public int? M3_WCNR => GetNullableInt("WCNR");

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
		/// Description: Planned number of workers
		/// FieldName: PRNP
		/// FieldType: N
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Planned number of workers")]
		public int? M3_PRNP => GetNullableInt("PRNP");

		/// <summary>
		/// Description: Planned number of resources
		/// FieldName: PRNR
		/// FieldType: N
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Planned number of resources")]
		public int? M3_PRNR => GetNullableInt("PRNR");

		/// <summary>
		/// Description: Included-in-work center
		/// FieldName: IIWC
		/// FieldType: A
		/// Length: 8
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Included-in-work center")]
		public string M3_IIWC => GetString("IIWC");

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
		/// Description: Batch sizing method
		/// FieldName: BAME
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Batch sizing method")]
		public int? M3_BAME => GetNullableInt("BAME");

		/// <summary>
		/// Description: Minimum batch size
		/// FieldName: BAMI
		/// FieldType: N
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Minimum batch size")]
		public decimal? M3_BAMI => GetNullableDecimal("BAMI");

		/// <summary>
		/// Description: Minimum level percentage
		/// FieldName: BAML
		/// FieldType: N
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Minimum level percentage")]
		public int? M3_BAML => GetNullableInt("BAML");

		/// <summary>
		/// Description: Maximum batch size
		/// FieldName: BAMA
		/// FieldType: N
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Maximum batch size")]
		public decimal? M3_BAMA => GetNullableDecimal("BAMA");

		/// <summary>
		/// Description: Multiple batch size
		/// FieldName: BASS
		/// FieldType: N
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Multiple batch size")]
		public decimal? M3_BASS => GetNullableDecimal("BASS");

		/// <summary>
		/// Description: Step level percentage
		/// FieldName: BASL
		/// FieldType: N
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Step level percentage")]
		public int? M3_BASL => GetNullableInt("BASL");

		/// <summary>
		/// Description: Surplus rule
		/// FieldName: BARD
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Surplus rule")]
		public int? M3_BARD => GetNullableInt("BARD");

		/// <summary>
		/// Description: Frozen horizon
		/// FieldName: BAFD
		/// FieldType: N
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Frozen horizon")]
		public int? M3_BAFD => GetNullableInt("BAFD");

		/// <summary>
		/// Description: Sequence lock horizon
		/// FieldName: BALD
		/// FieldType: N
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Sequence lock horizon")]
		public int? M3_BALD => GetNullableInt("BALD");

		/// <summary>
		/// Description: Slushy horizon
		/// FieldName: BASD
		/// FieldType: N
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Slushy horizon")]
		public int? M3_BASD => GetNullableInt("BASD");

		/// <summary>
		/// Description: Grouping horizon
		/// FieldName: BAGH
		/// FieldType: N
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Grouping horizon")]
		public int? M3_BAGH => GetNullableInt("BAGH");

		/// <summary>
		/// Description: Cirtical resource
		/// FieldName: CRTR
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Cirtical resource")]
		public int? M3_CRTR => GetNullableInt("CRTR");

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
		/// Description: Geographic cod X
		/// FieldName: GEOX
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Geographic cod X")]
		public decimal? M3_GEOX => GetNullableDecimal("GEOX");

		/// <summary>
		/// Description: Geographic code Y
		/// FieldName: GEOY
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Geographic code Y")]
		public decimal? M3_GEOY => GetNullableDecimal("GEOY");

		/// <summary>
		/// Description: Geographic cod  Z
		/// FieldName: GEOZ
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Geographic cod  Z")]
		public decimal? M3_GEOZ => GetNullableDecimal("GEOZ");

		/// <summary>
		/// Description: Price and time quantity
		/// FieldName: CTCD
		/// FieldType: N
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Price and time quantity")]
		public int? M3_CTCD => GetNullableInt("CTCD");

		/// <summary>
		/// Description: Run time
		/// FieldName: PIT2
		/// FieldType: N
		/// Length: 9
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Run time")]
		public int? M3_PIT2 => GetNullableInt("PIT2");

		/// <summary>
		/// Description: Setup time
		/// FieldName: SET2
		/// FieldType: N
		/// Length: 9
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Setup time")]
		public int? M3_SET2 => GetNullableInt("SET2");

		/// <summary>
		/// Description: Run time (hours/piece)
		/// FieldName: PIT3
		/// FieldType: N
		/// Length: 9
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Run time (hours/piece)")]
		public int? M3_PIT3 => GetNullableInt("PIT3");

		/// <summary>
		/// Description: Setup time ( hours/piece)
		/// FieldName: SET3
		/// FieldType: N
		/// Length: 9
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Setup time ( hours/piece)")]
		public int? M3_SET3 => GetNullableInt("SET3");

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
		/// Description: To location
		/// FieldName: TWSL
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("To location")]
		public string M3_TWSL => GetString("TWSL");

		/// <summary>
		/// Description: Return location
		/// FieldName: RETL
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Return location")]
		public string M3_RETL => GetString("RETL");

		/// <summary>
		/// Description: Alternate capacity
		/// FieldName: ACAP
		/// FieldType: N
		/// Length: 11
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Alternate capacity")]
		public decimal? M3_ACAP => GetNullableDecimal("ACAP");

		/// <summary>
		/// Description: Alternate capacity U/M
		/// FieldName: RCUN
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Alternate capacity U/M")]
		public string M3_RCUN => GetString("RCUN");

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
	}
}
// EOF
