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

namespace M3H5Lib.Api.MMS200MI
{
	public partial class GetItmFacResponse : M3BaseRecord 
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
		/// Description: Name
		/// FieldName: FACN
		/// FieldType: A
		/// Length: 30
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Name")]
		public string M3_FACN => GetString("FACN");

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
		/// Description: Name
		/// FieldName: ITDS
		/// FieldType: A
		/// Length: 30
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Name")]
		public string M3_ITDS => GetString("ITDS");

		/// <summary>
		/// Description: Administrative lead time
		/// FieldName: LEA4
		/// FieldType: N
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Administrative lead time")]
		public int? M3_LEA4 => GetNullableInt("LEA4");

		/// <summary>
		/// Description: Customs statistical number
		/// FieldName: CSNO
		/// FieldType: A
		/// Length: 16
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Customs statistical number")]
		public string M3_CSNO => GetString("CSNO");

		/// <summary>
		/// Description: Country of origin
		/// FieldName: ORCO
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Country of origin")]
		public string M3_ORCO => GetString("ORCO");

		/// <summary>
		/// Description: Average cost
		/// FieldName: APPR
		/// FieldType: N
		/// Length: 19
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Average cost")]
		public decimal? M3_APPR => GetNullableDecimal("APPR");

		/// <summary>
		/// Description: Cost price
		/// FieldName: UCOS
		/// FieldType: N
		/// Length: 19
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Cost price")]
		public decimal? M3_UCOS => GetNullableDecimal("UCOS");

		/// <summary>
		/// Description: Ordering cost
		/// FieldName: SOCO
		/// FieldType: N
		/// Length: 19
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Ordering cost")]
		public decimal? M3_SOCO => GetNullableDecimal("SOCO");

		/// <summary>
		/// Description: Batch quantity method
		/// FieldName: BQTM
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Batch quantity method")]
		public int? M3_BQTM => GetNullableInt("BQTM");

		/// <summary>
		/// Description: MO lead time method
		/// FieldName: DLET
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("MO lead time method")]
		public int? M3_DLET => GetNullableInt("DLET");

		/// <summary>
		/// Description: Dynamic lead time fence - MO
		/// FieldName: DLEF
		/// FieldType: N
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Dynamic lead time fence - MO")]
		public int? M3_DLEF => GetNullableInt("DLEF");

		/// <summary>
		/// Description: Flow order planning
		/// FieldName: DIDY
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Flow order planning")]
		public int? M3_DIDY => GetNullableInt("DIDY");

		/// <summary>
		/// Description: Flow order fence
		/// FieldName: DIDF
		/// FieldType: N
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Flow order fence")]
		public int? M3_DIDF => GetNullableInt("DIDF");

		/// <summary>
		/// Description: Production rate
		/// FieldName: PRRA
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Production rate")]
		public int? M3_PRRA => GetNullableInt("PRRA");

		/// <summary>
		/// Description: MO reservations
		/// FieldName: MARC
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("MO reservations")]
		public int? M3_MARC => GetNullableInt("MARC");

		/// <summary>
		/// Description: Orderless production
		/// FieldName: JITF
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Orderless production")]
		public int? M3_JITF => GetNullableInt("JITF");

		/// <summary>
		/// Description: Main warehouse
		/// FieldName: REWH
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Main warehouse")]
		public string M3_REWH => GetString("REWH");

		/// <summary>
		/// Description: Optimal on-hand balance - facility
		/// FieldName: OPFQ
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Optimal on-hand balance - facility")]
		public decimal? M3_OPFQ => GetNullableDecimal("OPFQ");

		/// <summary>
		/// Description: On-hand balance - facility
		/// FieldName: FANO
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("On-hand balance - facility")]
		public decimal? M3_FANO => GetNullableDecimal("FANO");

		/// <summary>
		/// Description: On-hand balance for inspection -facility
		/// FieldName: FANQ
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("On-hand balance for inspection -facility")]
		public decimal? M3_FANQ => GetNullableDecimal("FANQ");

		/// <summary>
		/// Description: Rejected on-hand balance - facility
		/// FieldName: FANR
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Rejected on-hand balance - facility")]
		public decimal? M3_FANR => GetNullableDecimal("FANR");

		/// <summary>
		/// Description: On-hand balance method - facility
		/// FieldName: FATM
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("On-hand balance method - facility")]
		public int? M3_FATM => GetNullableInt("FATM");

		/// <summary>
		/// Description: Production line
		/// FieldName: WCLN
		/// FieldType: A
		/// Length: 8
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Production line")]
		public string M3_WCLN => GetString("WCLN");

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
		/// Description: Automatic creation of MO
		/// FieldName: AUGE
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Automatic creation of MO")]
		public int? M3_AUGE => GetNullableInt("AUGE");

		/// <summary>
		/// Description: Consumption code - trade stat (TST)
		/// FieldName: ECCC
		/// FieldType: A
		/// Length: 4
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Consumption code - trade stat (TST)")]
		public string M3_ECCC => GetString("ECCC");

		/// <summary>
		/// Description: Area/state
		/// FieldName: ECAR
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Area/state")]
		public string M3_ECAR => GetString("ECAR");

		/// <summary>
		/// Description: Customs procedure - import
		/// FieldName: CPRI
		/// FieldType: A
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Customs procedure - import")]
		public string M3_CPRI => GetString("CPRI");

		/// <summary>
		/// Description: Customs procedure - export
		/// FieldName: CPRE
		/// FieldType: A
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Customs procedure - export")]
		public string M3_CPRE => GetString("CPRE");

		/// <summary>
		/// Description: Costing model - purchasing
		/// FieldName: WSCA
		/// FieldType: A
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Costing model - purchasing")]
		public string M3_WSCA => GetString("WSCA");

		/// <summary>
		/// Description: Costing model - product costing
		/// FieldName: PRCM
		/// FieldType: A
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Costing model - product costing")]
		public string M3_PRCM => GetString("PRCM");

		/// <summary>
		/// Description: Planning process
		/// FieldName: PLAP
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Planning process")]
		public string M3_PLAP => GetString("PLAP");

		/// <summary>
		/// Description: Push process
		/// FieldName: PLUP
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Push process")]
		public string M3_PLUP => GetString("PLUP");

		/// <summary>
		/// Description: Costing model - sales price
		/// FieldName: SCMO
		/// FieldType: A
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Costing model - sales price")]
		public string M3_SCMO => GetString("SCMO");

		/// <summary>
		/// Description: Calculate price for line type 0
		/// FieldName: CPL0
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Calculate price for line type 0")]
		public int? M3_CPL0 => GetNullableInt("CPL0");

		/// <summary>
		/// Description: Calculate price for line type 1
		/// FieldName: CPL1
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Calculate price for line type 1")]
		public int? M3_CPL1 => GetNullableInt("CPL1");

		/// <summary>
		/// Description: Calculate price for line type 2
		/// FieldName: CPL2
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Calculate price for line type 2")]
		public int? M3_CPL2 => GetNullableInt("CPL2");

		/// <summary>
		/// Description: Preliminary price for line type 0
		/// FieldName: PPL0
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Preliminary price for line type 0")]
		public int? M3_PPL0 => GetNullableInt("PPL0");

		/// <summary>
		/// Description: Preliminary price for line type 1
		/// FieldName: PPL1
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Preliminary price for line type 1")]
		public int? M3_PPL1 => GetNullableInt("PPL1");

		/// <summary>
		/// Description: Preliminary price for line type 2
		/// FieldName: PPL2
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Preliminary price for line type 2")]
		public int? M3_PPL2 => GetNullableInt("PPL2");

		/// <summary>
		/// Description: Costing decimal places
		/// FieldName: CPDC
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Costing decimal places")]
		public int? M3_CPDC => GetNullableInt("CPDC");

		/// <summary>
		/// Description: Item cost quantity
		/// FieldName: COCD
		/// FieldType: N
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Item cost quantity")]
		public int? M3_COCD => GetNullableInt("COCD");

		/// <summary>
		/// Description: Environment group
		/// FieldName: EVGR
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Environment group")]
		public string M3_EVGR => GetString("EVGR");

		/// <summary>
		/// Description: Inventory accounting method
		/// FieldName: VAMT
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Inventory accounting method")]
		public int? M3_VAMT => GetNullableInt("VAMT");

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
		/// Description: Group technology class
		/// FieldName: GRTI
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Group technology class")]
		public string M3_GRTI => GetString("GRTI");

		/// <summary>
		/// Description: MO leadtime limit
		/// FieldName: MOLL
		/// FieldType: N
		/// Length: 7
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("MO leadtime limit")]
		public int? M3_MOLL => GetNullableInt("MOLL");

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
		/// Description: Critical material
		/// FieldName: CRTM
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Critical material")]
		public int? M3_CRTM => GetNullableInt("CRTM");

		/// <summary>
		/// Description: Costing model - distribution
		/// FieldName: DICM
		/// FieldType: A
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Costing model - distribution")]
		public string M3_DICM => GetString("DICM");

		/// <summary>
		/// Description: User-defined accounting control object
		/// FieldName: ACRF
		/// FieldType: A
		/// Length: 8
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("User-defined accounting control object")]
		public string M3_ACRF => GetString("ACRF");

		/// <summary>
		/// Description: Catch weight approved on hand balance
		/// FieldName: STCW
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Catch weight approved on hand balance")]
		public decimal? M3_STCW => GetNullableDecimal("STCW");

		/// <summary>
		/// Description: Catch weight rejected on hand balance
		/// FieldName: RJCW
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Catch weight rejected on hand balance")]
		public decimal? M3_RJCW => GetNullableDecimal("RJCW");

		/// <summary>
		/// Description: Catch weight for inspection on hand bal
		/// FieldName: QUCW
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Catch weight for inspection on hand bal")]
		public decimal? M3_QUCW => GetNullableDecimal("QUCW");

		/// <summary>
		/// Description: Catch weight cost
		/// FieldName: CAWC
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Catch weight cost")]
		public int? M3_CAWC => GetNullableInt("CAWC");

		/// <summary>
		/// Description: Standard cost price unit of measure
		/// FieldName: CPUN
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Standard cost price unit of measure")]
		public string M3_CPUN => GetString("CPUN");

		/// <summary>
		/// Description: Yield percentage
		/// FieldName: EXPC
		/// FieldType: N
		/// Length: 7
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Yield percentage")]
		public int? M3_EXPC => GetNullableInt("EXPC");

		/// <summary>
		/// Description: Batch quantity
		/// FieldName: BQTY
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Batch quantity")]
		public decimal? M3_BQTY => GetNullableDecimal("BQTY");

		/// <summary>
		/// Description: Lowest level - BoM
		/// FieldName: LLCM
		/// FieldType: N
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Lowest level - BoM")]
		public int? M3_LLCM => GetNullableInt("LLCM");

		/// <summary>
		/// Description: Throughput rate of capacity/day
		/// FieldName: TRHC
		/// FieldType: N
		/// Length: 7
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Throughput rate of capacity/day")]
		public int? M3_TRHC => GetNullableInt("TRHC");

		/// <summary>
		/// Description: Method for expiry date excess control
		/// FieldName: EDEC
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Method for expiry date excess control")]
		public string M3_EDEC => GetString("EDEC");

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
		/// Description: Conversion factor
		/// FieldName: COFA
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Conversion factor")]
		public decimal? M3_COFA => GetNullableDecimal("COFA");

		/// <summary>
		/// Description: Alternate structures
		/// FieldName: ALTS
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Alternate structures")]
		public int? M3_ALTS => GetNullableInt("ALTS");

		/// <summary>
		/// Description: Average costing per attribute
		/// FieldName: ATTC
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Average costing per attribute")]
		public int? M3_ATTC => GetNullableInt("ATTC");
	}
}
// EOF
