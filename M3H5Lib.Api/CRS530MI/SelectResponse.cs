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

namespace M3H5Lib.Api.CRS530MI
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
		/// Description: Name
		/// FieldName: PLNM
		/// FieldType: A
		/// Length: 36
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Name")]
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
		/// Description: Work center responsible
		/// FieldName: WCRE
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Work center responsible")]
		public string M3_WCRE => GetString("WCRE");

		/// <summary>
		/// Description: Capacity type
		/// FieldName: PCAP
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Capacity type")]
		public int? M3_PCAP => GetNullableInt("PCAP");

		/// <summary>
		/// Description: Time U/M
		/// FieldName: PTUN
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Time U/M")]
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
		/// Description: Number of persons
		/// FieldName: WCNP
		/// FieldType: A
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Number of persons")]
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
		/// Description: Transit unit of measure/Overlap code
		/// FieldName: SLAT
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Transit unit of measure/Overlap code")]
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
		/// Description: Flow order resource
		/// FieldName: KYRE
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Flow order resource")]
		public int? M3_KYRE => GetNullableInt("KYRE");

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
		/// Description: Transport value in days
		/// FieldName: SLAC
		/// FieldType: N
		/// Length: 16
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Transport value in days")]
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
		/// Description: Setup time
		/// FieldName: SETI
		/// FieldType: A
		/// Length: 8
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Setup time")]
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
		/// Description: Continuous post-opr time
		/// FieldName: CPOT
		/// FieldType: N
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Continuous post-opr time")]
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
		/// Description: Loading principle
		/// FieldName: LDPR
		/// FieldType: A
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Loading principle")]
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
		/// Description: Planned number of resources
		/// FieldName: MAHD
		/// FieldType: N
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Planned number of resources")]
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
		/// Description: Maximum oven load
		/// FieldName: GRMX
		/// FieldType: A
		/// Length: 9
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Maximum oven load")]
		public string M3_GRMX => GetString("GRMX");

		/// <summary>
		/// Description: Oven load U/M
		/// FieldName: GRMU
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Oven load U/M")]
		public int? M3_GRMU => GetNullableInt("GRMU");

		/// <summary>
		/// Description: Average load percentage
		/// FieldName: AVFL
		/// FieldType: N
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Average load percentage")]
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
		/// Description: APP location
		/// FieldName: APLC
		/// FieldType: A
		/// Length: 8
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("APP location")]
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
		/// FieldName: PRNR
		/// FieldType: N
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Planned number of resources")]
		public int? M3_PRNR => GetNullableInt("PRNR");

		/// <summary>
		/// Description: Included in work center
		/// FieldName: IIWC
		/// FieldType: A
		/// Length: 8
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Included in work center")]
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
		/// Description: Filler
		/// FieldName: FIL1
		/// FieldType: A
		/// Length: 69
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Filler")]
		public string M3_FIL1 => GetString("FIL1");

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
		/// Description: Work schedule
		/// FieldName: WOSC
		/// FieldType: N
		/// Length: 8
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Work schedule")]
		public int? M3_WOSC => GetNullableInt("WOSC");
	}
}
// EOF
