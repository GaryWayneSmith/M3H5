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

namespace M3H5Lib.Api.MMS240MI
{
	public partial class GetBasicResponse : M3BaseRecord 
	{

		/// <summary>
		/// Description: Fixed asset
		/// FieldName: ASID
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Fixed asset")]
		public string M3_ASID => GetString("ASID");

		/// <summary>
		/// Description: Subnumber
		/// FieldName: SBNO
		/// FieldType: N
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Subnumber")]
		public int? M3_SBNO => GetNullableInt("SBNO");

		/// <summary>
		/// Description: Buy-back date
		/// FieldName: ABBD
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Buy-back date")]
		public DateTime? M3_ABBD => GetNullableDateTime("ABBD");

		/// <summary>
		/// Description: Status
		/// FieldName: STAT
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Status")]
		public string M3_STAT => GetString("STAT");

		/// <summary>
		/// Description: Warranty date
		/// FieldName: WADT
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Warranty date")]
		public DateTime? M3_WADT => GetNullableDateTime("WADT");

		/// <summary>
		/// Description: Warranty agreement
		/// FieldName: WAGR
		/// FieldType: A
		/// Length: 7
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Warranty agreement")]
		public string M3_WAGR => GetString("WAGR");

		/// <summary>
		/// Description: Warranty limit 1
		/// FieldName: WAL1
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Warranty limit 1")]
		public decimal? M3_WAL1 => GetNullableDecimal("WAL1");

		/// <summary>
		/// Description: Warranty limit 2
		/// FieldName: WAL2
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Warranty limit 2")]
		public decimal? M3_WAL2 => GetNullableDecimal("WAL2");

		/// <summary>
		/// Description: Warranty limit 3
		/// FieldName: WAL3
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Warranty limit 3")]
		public decimal? M3_WAL3 => GetNullableDecimal("WAL3");

		/// <summary>
		/// Description: Warranty limit 4
		/// FieldName: WAL4
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Warranty limit 4")]
		public decimal? M3_WAL4 => GetNullableDecimal("WAL4");

		/// <summary>
		/// Description: Next shop action type
		/// FieldName: NESA
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Next shop action type")]
		public string M3_NESA => GetString("NESA");

		/// <summary>
		/// Description: Next service
		/// FieldName: NSUF
		/// FieldType: A
		/// Length: 20
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Next service")]
		public string M3_NSUF => GetString("NSUF");

		/// <summary>
		/// Description: Maintenance program
		/// FieldName: MPGM
		/// FieldType: A
		/// Length: 20
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Maintenance program")]
		public string M3_MPGM => GetString("MPGM");

		/// <summary>
		/// Description: Planner - maintenance
		/// FieldName: MAPL
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Planner - maintenance")]
		public string M3_MAPL => GetString("MAPL");

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
		/// Description: Forecast logic
		/// FieldName: FCCM
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Forecast logic")]
		public string M3_FCCM => GetString("FCCM");

		/// <summary>
		/// Description: Purchase price
		/// FieldName: PUPR
		/// FieldType: N
		/// Length: 18
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Purchase price")]
		public decimal? M3_PUPR => GetNullableDecimal("PUPR");

		/// <summary>
		/// Description: Currency
		/// FieldName: CUCD
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Currency")]
		public string M3_CUCD => GetString("CUCD");

		/// <summary>
		/// Description: Purchase price date
		/// FieldName: PPDT
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Purchase price date")]
		public DateTime? M3_PPDT => GetNullableDateTime("PPDT");

		/// <summary>
		/// Description: Origin identity
		/// FieldName: BIRT
		/// FieldType: N
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Origin identity")]
		public long? M3_BIRT => GetNullableLong("BIRT");

		/// <summary>
		/// Description: Date introduced into Movex
		/// FieldName: BIRS
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Date introduced into Movex")]
		public DateTime? M3_BIRS => GetNullableDateTime("BIRS");

		/// <summary>
		/// Description: Equipment description
		/// FieldName: ALII
		/// FieldType: A
		/// Length: 40
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Equipment description")]
		public string M3_ALII => GetString("ALII");

		/// <summary>
		/// Description: Period frame
		/// FieldName: DPID
		/// FieldType: N
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Period frame")]
		public int? M3_DPID => GetNullableInt("DPID");

		/// <summary>
		/// Description: Continuous net change
		/// FieldName: CONC
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Continuous net change")]
		public int? M3_CONC => GetNullableInt("CONC");

		/// <summary>
		/// Description: Planning horizon
		/// FieldName: PLMZ
		/// FieldType: N
		/// Length: 4
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Planning horizon")]
		public int? M3_PLMZ => GetNullableInt("PLMZ");

		/// <summary>
		/// Description: Percentage of cost price
		/// FieldName: SHRE
		/// FieldType: N
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Percentage of cost price")]
		public int? M3_SHRE => GetNullableInt("SHRE");

		/// <summary>
		/// Description: Insurance number
		/// FieldName: INSN
		/// FieldType: A
		/// Length: 20
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Insurance number")]
		public string M3_INSN => GetString("INSN");

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
		/// Description: Field not used
		/// FieldName: EQNL
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Field not used")]
		public int? M3_EQNL => GetNullableInt("EQNL");

		/// <summary>
		/// Description: Priority
		/// FieldName: PRIP
		/// FieldType: A
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Priority")]
		public string M3_PRIP => GetString("PRIP");

		/// <summary>
		/// Description: Process
		/// FieldName: PRSS
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Process")]
		public string M3_PRSS => GetString("PRSS");

		/// <summary>
		/// Description: Subprocess
		/// FieldName: SBPR
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Subprocess")]
		public string M3_SBPR => GetString("SBPR");

		/// <summary>
		/// Description: Criticality class
		/// FieldName: AESC
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Criticality class")]
		public int? M3_AESC => GetNullableInt("AESC");

		/// <summary>
		/// Description: Target effectivity
		/// FieldName: TEFF
		/// FieldType: N
		/// Length: 11
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Target effectivity")]
		public decimal? M3_TEFF => GetNullableDecimal("TEFF");

		/// <summary>
		/// Description: Downtime cost
		/// FieldName: DWTC
		/// FieldType: N
		/// Length: 18
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Downtime cost")]
		public decimal? M3_DWTC => GetNullableDecimal("DWTC");

		/// <summary>
		/// Description: Commission date
		/// FieldName: CMDD
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Commission date")]
		public DateTime? M3_CMDD => GetNullableDateTime("CMDD");

		/// <summary>
		/// Description: Data identity
		/// FieldName: DTID
		/// FieldType: N
		/// Length: 13
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Data identity")]
		public decimal? M3_DTID => GetNullableDecimal("DTID");

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
		/// Description: Year model
		/// FieldName: MLYR
		/// FieldType: A
		/// Length: 4
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Year model")]
		public string M3_MLYR => GetString("MLYR");

		/// <summary>
		/// Description: Location description
		/// FieldName: AREA
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Location description")]
		public string M3_AREA => GetString("AREA");

		/// <summary>
		/// Description: Location
		/// FieldName: LOCS
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Location")]
		public string M3_LOCS => GetString("LOCS");

		/// <summary>
		/// Description: Brand
		/// FieldName: BRAN
		/// FieldType: A
		/// Length: 8
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Brand")]
		public string M3_BRAN => GetString("BRAN");

		/// <summary>
		/// Description: Equipment type
		/// FieldName: EQTP
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Equipment type")]
		public string M3_EQTP => GetString("EQTP");

		/// <summary>
		/// Description: Equipment group
		/// FieldName: EQGR
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Equipment group")]
		public string M3_EQGR => GetString("EQGR");

		/// <summary>
		/// Description: Project number
		/// FieldName: PROJ
		/// FieldType: A
		/// Length: 7
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Project number")]
		public string M3_PROJ => GetString("PROJ");

		/// <summary>
		/// Description: Project element
		/// FieldName: ELNO
		/// FieldType: A
		/// Length: 8
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Project element")]
		public string M3_ELNO => GetString("ELNO");

		/// <summary>
		/// Description: Equipment group category
		/// FieldName: EQGC
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Equipment group category")]
		public string M3_EQGC => GetString("EQGC");

		/// <summary>
		/// Description: Installation date
		/// FieldName: INDA
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Installation date")]
		public DateTime? M3_INDA => GetNullableDateTime("INDA");

		/// <summary>
		/// Description: Asset tag
		/// FieldName: RFIA
		/// FieldType: A
		/// Length: 20
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Asset tag")]
		public string M3_RFIA => GetString("RFIA");

		/// <summary>
		/// Description: Fleet number
		/// FieldName: FLNO
		/// FieldType: A
		/// Length: 20
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Fleet number")]
		public string M3_FLNO => GetString("FLNO");

		/// <summary>
		/// Description: Search key equipment
		/// FieldName: SKEY
		/// FieldType: A
		/// Length: 20
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Search key equipment")]
		public string M3_SKEY => GetString("SKEY");

		/// <summary>
		/// Description: Supplier/manufacturer item number
		/// FieldName: MFIT
		/// FieldType: A
		/// Length: 30
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Supplier/manufacturer item number")]
		public string M3_MFIT => GetString("MFIT");

		/// <summary>
		/// Description: Manufacturer serial number
		/// FieldName: MFSN
		/// FieldType: A
		/// Length: 25
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Manufacturer serial number")]
		public string M3_MFSN => GetString("MFSN");

		/// <summary>
		/// Description: Minimum accepted contributn margin ratio
		/// FieldName: LAMA
		/// FieldType: N
		/// Length: 7
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Minimum accepted contributn margin ratio")]
		public int? M3_LAMA => GetNullableInt("LAMA");

		/// <summary>
		/// Description: Sales model
		/// FieldName: ASLM
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Sales model")]
		public string M3_ASLM => GetString("ASLM");

		/// <summary>
		/// Description: Price model
		/// FieldName: APRM
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Price model")]
		public string M3_APRM => GetString("APRM");

		/// <summary>
		/// Description: Dealer model
		/// FieldName: ADLM
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Dealer model")]
		public string M3_ADLM => GetString("ADLM");

		/// <summary>
		/// Description: Compatibility code
		/// FieldName: ACMC
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Compatibility code")]
		public string M3_ACMC => GetString("ACMC");

		/// <summary>
		/// Description: User-defined field 1 - item
		/// FieldName: CFI1
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("User-defined field 1 - item")]
		public string M3_CFI1 => GetString("CFI1");

		/// <summary>
		/// Description: User-defined field 2 - item
		/// FieldName: CFI2
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("User-defined field 2 - item")]
		public decimal? M3_CFI2 => GetNullableDecimal("CFI2");

		/// <summary>
		/// Description: User-defined field 3 - item
		/// FieldName: CFI3
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("User-defined field 3 - item")]
		public string M3_CFI3 => GetString("CFI3");

		/// <summary>
		/// Description: User-defined field 4 - item
		/// FieldName: CFI4
		/// FieldType: A
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("User-defined field 4 - item")]
		public string M3_CFI4 => GetString("CFI4");

		/// <summary>
		/// Description: User-defined field 5 - item
		/// FieldName: CFI5
		/// FieldType: A
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("User-defined field 5 - item")]
		public string M3_CFI5 => GetString("CFI5");

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
		/// Description: Owner
		/// FieldName: CUOW
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Owner")]
		public string M3_CUOW => GetString("CUOW");

		/// <summary>
		/// Description: Address number
		/// FieldName: ADID
		/// FieldType: A
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Address number")]
		public string M3_ADID => GetString("ADID");

		/// <summary>
		/// Description: Invoice date
		/// FieldName: IVDT
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Invoice date")]
		public DateTime? M3_IVDT => GetNullableDateTime("IVDT");

		/// <summary>
		/// Description: Extended invoice number
		/// FieldName: EXIN
		/// FieldType: A
		/// Length: 14
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Extended invoice number")]
		public string M3_EXIN => GetString("EXIN");

		/// <summary>
		/// Description: Year
		/// FieldName: YEA4
		/// FieldType: N
		/// Length: 4
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Year")]
		public int? M3_YEA4 => GetNullableInt("YEA4");

		/// <summary>
		/// Description: Ownership type
		/// FieldName: OWTP
		/// FieldType: A
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Ownership type")]
		public string M3_OWTP => GetString("OWTP");

		/// <summary>
		/// Description: Ref field for date
		/// FieldName: RBDT
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Ref field for date")]
		public DateTime? M3_RBDT => GetNullableDateTime("RBDT");

		/// <summary>
		/// Description: Publish External
		/// FieldName: PUEX
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Publish External")]
		public int? M3_PUEX => GetNullableInt("PUEX");

		/// <summary>
		/// Description: Purchase order number
		/// FieldName: PUNO
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Purchase order number")]
		public string M3_PUNO => GetString("PUNO");

		/// <summary>
		/// Description: Purchase order line number
		/// FieldName: PNLI
		/// FieldType: N
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Purchase order line number")]
		public int? M3_PNLI => GetNullableInt("PNLI");

		/// <summary>
		/// Description: Purchase order sub line number
		/// FieldName: PNLS
		/// FieldType: N
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Purchase order sub line number")]
		public int? M3_PNLS => GetNullableInt("PNLS");
	}
}
// EOF
