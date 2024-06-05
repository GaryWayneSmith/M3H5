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

namespace M3H5Lib.Api.MOS446MI
{
	public partial class GetPositionResponse : M3BaseRecord 
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
		/// Description: Site
		/// FieldName: MOTP
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Site")]
		public string M3MOTP => GetString("MOTP");

		/// <summary>
		/// Description: Position
		/// FieldName: CFGL
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Position")]
		public string M3CFGL => GetString("CFGL");

		/// <summary>
		/// Description: Component type
		/// FieldName: MATP
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Component type")]
		public string M3MATP => GetString("MATP");

		/// <summary>
		/// Description: Location
		/// FieldName: POS0
		/// FieldType: A
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Location")]
		public string M3POS0 => GetString("POS0");

		/// <summary>
		/// Description: Mandatory
		/// FieldName: MAND
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Mandatory")]
		public int? M3MAND => GetNullableInt("MAND");

		/// <summary>
		/// Description: Config position category
		/// FieldName: CAT0
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Config position category")]
		public string M3CAT0 => GetString("CAT0");

		/// <summary>
		/// Description: Highest in structure
		/// FieldName: HIGH
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Highest in structure")]
		public int? M3HIGH => GetNullableInt("HIGH");

		/// <summary>
		/// Description: Essentiality class
		/// FieldName: AESC
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Essentiality class")]
		public int? M3AESC => GetNullableInt("AESC");

		/// <summary>
		/// Description: Extended-range twin-engine
		/// FieldName: AES2
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Extended-range twin-engine")]
		public int? M3AES2 => GetNullableInt("AES2");

		/// <summary>
		/// Description: Removal concept
		/// FieldName: REMC
		/// FieldType: A
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Removal concept")]
		public string M3REMC => GetString("REMC");

		/// <summary>
		/// Description: Failure protection concept
		/// FieldName: FPCO
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Failure protection concept")]
		public string M3FPCO => GetString("FPCO");

		/// <summary>
		/// Description: Maintenance/overhaul/repair
		/// FieldName: AMOR
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Maintenance/overhaul/repair")]
		public int? M3AMOR => GetNullableInt("AMOR");

		/// <summary>
		/// Description: Exchange conditions
		/// FieldName: ASRS
		/// FieldType: A
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Exchange conditions")]
		public string M3ASRS => GetString("ASRS");

		/// <summary>
		/// Description: SOS indicator
		/// FieldName: ASSI
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("SOS indicator")]
		public int? M3ASSI => GetNullableInt("ASSI");

		/// <summary>
		/// Description: Effectivity indicator
		/// FieldName: AEFI
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Effectivity indicator")]
		public int? M3AEFI => GetNullableInt("AEFI");

		/// <summary>
		/// Description: Maintenance percent
		/// FieldName: MPEC
		/// FieldType: N
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Maintenance percent")]
		public int? M3MPEC => GetNullableInt("MPEC");

		/// <summary>
		/// Description: Service lead time
		/// FieldName: MSPT
		/// FieldType: N
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Service lead time")]
		public int? M3MSPT => GetNullableInt("MSPT");

		/// <summary>
		/// Description: Time between scheduled shop visit
		/// FieldName: TBSR
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Time between scheduled shop visit")]
		public decimal? M3TBSR => GetNullableDecimal("TBSR");

		/// <summary>
		/// Description: Meter - scheduled shop visit
		/// FieldName: MBSR
		/// FieldType: A
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Meter - scheduled shop visit")]
		public string M3MBSR => GetString("MBSR");

		/// <summary>
		/// Description: Unscheduled removal rate
		/// FieldName: TBUR
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Unscheduled removal rate")]
		public decimal? M3TBUR => GetNullableDecimal("TBUR");

		/// <summary>
		/// Description: Meter - unscheduled removal rate
		/// FieldName: MBUR
		/// FieldType: A
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Meter - unscheduled removal rate")]
		public string M3MBUR => GetString("MBUR");

		/// <summary>
		/// Description: Configuration position category
		/// FieldName: RCFG
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Configuration position category")]
		public int? M3RCFG => GetNullableInt("RCFG");

		/// <summary>
		/// Description: Standard numbering system
		/// FieldName: STNC
		/// FieldType: A
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Standard numbering system")]
		public string M3STNC => GetString("STNC");

		/// <summary>
		/// Description: Maintenance code
		/// FieldName: MCDE
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Maintenance code")]
		public int? M3MCDE => GetNullableInt("MCDE");

		/// <summary>
		/// Description: Status
		/// FieldName: STAT
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Status")]
		public string M3STAT => GetString("STAT");

		/// <summary>
		/// Description: Description
		/// FieldName: TX40
		/// FieldType: A
		/// Length: 40
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Description")]
		public string M3TX40 => GetString("TX40");

		/// <summary>
		/// Description: Name
		/// FieldName: TX15
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Name")]
		public string M3TX15 => GetString("TX15");

		/// <summary>
		/// Description: Load position
		/// FieldName: LPOS
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Load position")]
		public int? M3LPOS => GetNullableInt("LPOS");

		/// <summary>
		/// Description: Number of units for position
		/// FieldName: NUCP
		/// FieldType: N
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Number of units for position")]
		public int? M3NUCP => GetNullableInt("NUCP");

		/// <summary>
		/// Description: Engine
		/// FieldName: ENGI
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Engine")]
		public int? M3ENGI => GetNullableInt("ENGI");

		/// <summary>
		/// Description: Location history
		/// FieldName: LOCH
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Location history")]
		public int? M3LOCH => GetNullableInt("LOCH");

		/// <summary>
		/// Description: User-defined accounting code
		/// FieldName: ACRF
		/// FieldType: A
		/// Length: 8
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("User-defined accounting code")]
		public string M3ACRF => GetString("ACRF");

		/// <summary>
		/// Description: Planning position
		/// FieldName: PPOS
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Planning position")]
		public int? M3PPOS => GetNullableInt("PPOS");

		/// <summary>
		/// Description: Downtime cost
		/// FieldName: DWTC
		/// FieldType: N
		/// Length: 19
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Downtime cost")]
		public decimal? M3DWTC => GetNullableDecimal("DWTC");

		/// <summary>
		/// Description: Target effectivity
		/// FieldName: TEFF
		/// FieldType: N
		/// Length: 11
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Target effectivity")]
		public decimal? M3TEFF => GetNullableDecimal("TEFF");

		/// <summary>
		/// Description: Process
		/// FieldName: PRSS
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Process")]
		public string M3PRSS => GetString("PRSS");

		/// <summary>
		/// Description: Subprocess
		/// FieldName: SBPR
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Subprocess")]
		public string M3SBPR => GetString("SBPR");

		/// <summary>
		/// Description: Priority
		/// FieldName: PRIP
		/// FieldType: A
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Priority")]
		public string M3PRIP => GetString("PRIP");

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
		/// Description: Drawing number
		/// FieldName: DWNO
		/// FieldType: A
		/// Length: 20
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Drawing number")]
		public string M3DWNO => GetString("DWNO");

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
		/// Description: Configuration position group
		/// FieldName: POCA
		/// FieldType: A
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Configuration position group")]
		public string M3POCA => GetString("POCA");

		/// <summary>
		/// Description: Fixed asset
		/// FieldName: ASID
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Fixed asset")]
		public string M3ASID => GetString("ASID");

		/// <summary>
		/// Description: Subnumber
		/// FieldName: SBNO
		/// FieldType: N
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Subnumber")]
		public int? M3SBNO => GetNullableInt("SBNO");

		/// <summary>
		/// Description: Data identity
		/// FieldName: DTID
		/// FieldType: N
		/// Length: 13
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Data identity")]
		public decimal? M3DTID => GetNullableDecimal("DTID");

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
		/// Description: Entry date
		/// FieldName: RGDT
		/// FieldType: D
		/// Length: 8
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Entry date")]
		public DateTime? M3RGDT => GetNullableDateTime("RGDT");

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
		/// Description: Change date
		/// FieldName: LMDT
		/// FieldType: D
		/// Length: 8
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
	}
}
// EOF
