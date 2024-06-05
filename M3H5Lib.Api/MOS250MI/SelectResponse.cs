/// **********************************************************************
/// This class is auto-generated.
/// Updated: 6/5/2024 3:52:20 PM
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

namespace M3H5Lib.Api.MOS250MI
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
		/// Description: Resource type
		/// FieldName: PLTP
		/// FieldType: A
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Resource type")]
		public string M3PLTP => GetString("PLTP");

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
		/// Description: Work center name
		/// FieldName: PLNM
		/// FieldType: A
		/// Length: 36
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Work center name")]
		public string M3PLNM => GetString("PLNM");

		/// <summary>
		/// Description: Production line
		/// FieldName: PRLN
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Production line")]
		public int? M3PRLN => GetNullableInt("PRLN");

		/// <summary>
		/// Description: Efficiency control
		/// FieldName: EFCH
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Efficiency control")]
		public int? M3EFCH => GetNullableInt("EFCH");

		/// <summary>
		/// Description: Efficiency rate
		/// FieldName: EFFA
		/// FieldType: N
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Efficiency rate")]
		public int? M3EFFA => GetNullableInt("EFFA");

		/// <summary>
		/// Description: Utilization rate
		/// FieldName: AVEF
		/// FieldType: A
		/// Length: 4
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Utilization rate")]
		public string M3AVEF => GetString("AVEF");

		/// <summary>
		/// Description: W/C Responsible
		/// FieldName: WCRE
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("W/C Responsible")]
		public string M3WCRE => GetString("WCRE");

		/// <summary>
		/// Description: Capacity type (man/machine)
		/// FieldName: PCAP
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Capacity type (man/machine)")]
		public int? M3PCAP => GetNullableInt("PCAP");

		/// <summary>
		/// Description: W/C time init of measurement
		/// FieldName: PTUN
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("W/C time init of measurement")]
		public int? M3PTUN => GetNullableInt("PTUN");

		/// <summary>
		/// Description: Number of machines
		/// FieldName: WCNM
		/// FieldType: A
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Number of machines")]
		public string M3WCNM => GetString("WCNM");

		/// <summary>
		/// Description: Number of people
		/// FieldName: WCNP
		/// FieldType: A
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Number of people")]
		public string M3WCNP => GetString("WCNP");

		/// <summary>
		/// Description: Shift pattern
		/// FieldName: SHPA
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Shift pattern")]
		public string M3SHPA => GetString("SHPA");

		/// <summary>
		/// Description: Transit U/M
		/// FieldName: SLAT
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Transit U/M")]
		public int? M3SLAT => GetNullableInt("SLAT");

		/// <summary>
		/// Description: Co-sorting identity
		/// FieldName: PSQT
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Co-sorting identity")]
		public int? M3PSQT => GetNullableInt("PSQT");

		/// <summary>
		/// Description: Load reduction method
		/// FieldName: RWCD
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Load reduction method")]
		public int? M3RWCD => GetNullableInt("RWCD");

		/// <summary>
		/// Description: Queue days
		/// FieldName: QUDY
		/// FieldType: A
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Queue days")]
		public string M3QUDY => GetString("QUDY");

		/// <summary>
		/// Description: Flow Resource
		/// FieldName: KYRE
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Flow Resource")]
		public int? M3KYRE => GetNullableInt("KYRE");

		/// <summary>
		/// Description: Finite/infinite
		/// FieldName: WLDE
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Finite/infinite")]
		public int? M3WLDE => GetNullableInt("WLDE");

		/// <summary>
		/// Description: Transport value
		/// FieldName: SLAC
		/// FieldType: N
		/// Length: 16
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Transport value")]
		public decimal? M3SLAC => GetNullableDecimal("SLAC");

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
		/// Description: Sequencing priority
		/// FieldName: SEQP
		/// FieldType: A
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Sequencing priority")]
		public string M3SEQP => GetString("SEQP");

		/// <summary>
		/// Description: Activity color
		/// FieldName: ACOL
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Activity color")]
		public string M3ACOL => GetString("ACOL");

		/// <summary>
		/// Description: Set-up time standard
		/// FieldName: SETI
		/// FieldType: A
		/// Length: 8
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Set-up time standard")]
		public string M3SETI => GetString("SETI");

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
		/// Description: Continuous post-operation time
		/// FieldName: CPOT
		/// FieldType: N
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Continuous post-operation time")]
		public int? M3CPOT => GetNullableInt("CPOT");

		/// <summary>
		/// Description: Operator time factor
		/// FieldName: MPTF
		/// FieldType: N
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Operator time factor")]
		public int? M3MPTF => GetNullableInt("MPTF");

		/// <summary>
		/// Description: Load principle
		/// FieldName: LDPR
		/// FieldType: A
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Load principle")]
		public string M3LDPR => GetString("LDPR");

		/// <summary>
		/// Description: Fill method
		/// FieldName: FUMT
		/// FieldType: A
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Fill method")]
		public string M3FUMT => GetString("FUMT");

		/// <summary>
		/// Description: Max hours/day
		/// FieldName: MAHD
		/// FieldType: N
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Max hours/day")]
		public int? M3MAHD => GetNullableInt("MAHD");

		/// <summary>
		/// Description: Minimum restriction
		/// FieldName: MINR
		/// FieldType: A
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Minimum restriction")]
		public string M3MINR => GetString("MINR");

		/// <summary>
		/// Description: Maximum restriction
		/// FieldName: MAXR
		/// FieldType: A
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Maximum restriction")]
		public string M3MAXR => GetString("MAXR");

		/// <summary>
		/// Description: Group max
		/// FieldName: GRMX
		/// FieldType: A
		/// Length: 9
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Group max")]
		public string M3GRMX => GetString("GRMX");

		/// <summary>
		/// Description: Group max U/M
		/// FieldName: GRMU
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Group max U/M")]
		public int? M3GRMU => GetNullableInt("GRMU");

		/// <summary>
		/// Description: Average load percent
		/// FieldName: AVFL
		/// FieldType: N
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Average load percent")]
		public int? M3AVFL => GetNullableInt("AVFL");

		/// <summary>
		/// Description: Average queue time
		/// FieldName: AVQT
		/// FieldType: N
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Average queue time")]
		public int? M3AVQT => GetNullableInt("AVQT");

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
		/// Description: Capacity level
		/// FieldName: CAPL
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Capacity level")]
		public string M3CAPL => GetString("CAPL");

		/// <summary>
		/// Description: Bottleneck planning
		/// FieldName: BONE
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Bottleneck planning")]
		public int? M3BONE => GetNullableInt("BONE");

		/// <summary>
		/// Description: Work Zone
		/// FieldName: APLC
		/// FieldType: A
		/// Length: 8
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Work Zone")]
		public string M3APLC => GetString("APLC");

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
		/// Description: Number of resources
		/// FieldName: WCNR
		/// FieldType: N
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Number of resources")]
		public int? M3WCNR => GetNullableInt("WCNR");

		/// <summary>
		/// Description: Planned number of machines
		/// FieldName: PRNM
		/// FieldType: N
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Planned number of machines")]
		public int? M3PRNM => GetNullableInt("PRNM");

		/// <summary>
		/// Description: Planned number of workers
		/// FieldName: PRNP
		/// FieldType: N
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Planned number of workers")]
		public int? M3PRNP => GetNullableInt("PRNP");

		/// <summary>
		/// Description: Planned number of resources
		/// FieldName: PRNR
		/// FieldType: N
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Planned number of resources")]
		public int? M3PRNR => GetNullableInt("PRNR");

		/// <summary>
		/// Description: Included-in-work center
		/// FieldName: IIWC
		/// FieldType: A
		/// Length: 8
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Included-in-work center")]
		public string M3IIWC => GetString("IIWC");
	}
}
// EOF
