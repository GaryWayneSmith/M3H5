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

namespace M3H5Lib.Api.PDS001MI
{
	public partial class GetResponse : M3BaseRecord 
	{

		/// <summary>
		/// Description: Company Number
		/// FieldName: CONO
		/// FieldType: N
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Company Number")]
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
		/// Description: Product structure type
		/// FieldName: STRT
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Product structure type")]
		public string M3_STRT => GetString("STRT");

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
		/// Description: Product text
		/// FieldName: PRTX
		/// FieldType: A
		/// Length: 30
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Product text")]
		public string M3_PRTX => GetString("PRTX");

		/// <summary>
		/// Description: Drawing number
		/// FieldName: DWNO
		/// FieldType: A
		/// Length: 20
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Drawing number")]
		public string M3_DWNO => GetString("DWNO");

		/// <summary>
		/// Description: Structure complexity
		/// FieldName: SCOM
		/// FieldType: N
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Structure complexity")]
		public int? M3_SCOM => GetNullableInt("SCOM");

		/// <summary>
		/// Description: Revision number
		/// FieldName: ECVE
		/// FieldType: A
		/// Length: 4
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Revision number")]
		public string M3_ECVE => GetString("ECVE");

		/// <summary>
		/// Description: ECO managed
		/// FieldName: ECMA
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("ECO managed")]
		public int? M3_ECMA => GetNullableInt("ECMA");

		/// <summary>
		/// Description: Engineering change order number
		/// FieldName: ECON
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Engineering change order number")]
		public string M3_ECON => GetString("ECON");

		/// <summary>
		/// Description: From date
		/// FieldName: FDAT
		/// FieldType: N
		/// Length: 8
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("From date")]
		public int? M3_FDAT => GetNullableInt("FDAT");

		/// <summary>
		/// Description: Change type
		/// FieldName: ECEX
		/// FieldType: A
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Change type")]
		public string M3_ECEX => GetString("ECEX");

		/// <summary>
		/// Description: Planning time fence
		/// FieldName: PFTM
		/// FieldType: N
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Planning time fence")]
		public int? M3_PFTM => GetNullableInt("PFTM");

		/// <summary>
		/// Description: Order multiple
		/// FieldName: UNMU
		/// FieldType: A
		/// Length: 11
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Order multiple")]
		public string M3_UNMU => GetString("UNMU");

		/// <summary>
		/// Description: Leadtime 5 production time all levels
		/// FieldName: LEAA
		/// FieldType: N
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Leadtime 5 production time all levels")]
		public int? M3_LEAA => GetNullableInt("LEAA");

		/// <summary>
		/// Description: Order quantity
		/// FieldName: EOQT
		/// FieldType: A
		/// Length: 11
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Order quantity")]
		public string M3_EOQT => GetString("EOQT");

		/// <summary>
		/// Description: Order policy
		/// FieldName: EOQM
		/// FieldType: N
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Order policy")]
		public int? M3_EOQM => GetNullableInt("EOQM");

		/// <summary>
		/// Description: Lead time this level
		/// FieldName: LEAL
		/// FieldType: N
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Lead time this level")]
		public int? M3_LEAL => GetNullableInt("LEAL");

		/// <summary>
		/// Description: Basic unit of measure
		/// FieldName: UNMS
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Basic unit of measure")]
		public string M3_UNMS => GetString("UNMS");

		/// <summary>
		/// Description: Alternate routings
		/// FieldName: AOPL
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Alternate routings")]
		public int? M3_AOPL => GetNullableInt("AOPL");

		/// <summary>
		/// Description: Standard routing
		/// FieldName: SAOI
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Standard routing")]
		public string M3_SAOI => GetString("SAOI");

		/// <summary>
		/// Description: Name
		/// FieldName: TX15
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Name")]
		public string M3_TX15 => GetString("TX15");

		/// <summary>
		/// Description: Dynamic configurator
		/// FieldName: DCON
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Dynamic configurator")]
		public int? M3_DCON => GetNullableInt("DCON");

		/// <summary>
		/// Description: Cumulative scrap percentage
		/// FieldName: ASPC
		/// FieldType: N
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Cumulative scrap percentage")]
		public int? M3_ASPC => GetNullableInt("ASPC");

		/// <summary>
		/// Description: Batch recalculation
		/// FieldName: BACO
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Batch recalculation")]
		public int? M3_BACO => GetNullableInt("BACO");

		/// <summary>
		/// Description: Yield percentage
		/// FieldName: EXPC
		/// FieldType: N
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Yield percentage")]
		public int? M3_EXPC => GetNullableInt("EXPC");

		/// <summary>
		/// Description: Batch quantity
		/// FieldName: TEXQ
		/// FieldType: A
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Batch quantity")]
		public string M3_TEXQ => GetString("TEXQ");

		/// <summary>
		/// Description: Yield quantity
		/// FieldName: BAQT
		/// FieldType: A
		/// Length: 11
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Yield quantity")]
		public string M3_BAQT => GetString("BAQT");

		/// <summary>
		/// Description: Same date for batches
		/// FieldName: SDTB
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Same date for batches")]
		public int? M3_SDTB => GetNullableInt("SDTB");

		/// <summary>
		/// Description: Batch production
		/// FieldName: PRIB
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Batch production")]
		public int? M3_PRIB => GetNullableInt("PRIB");

		/// <summary>
		/// Description: Number of put-away cards
		/// FieldName: NUC1
		/// FieldType: N
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Number of put-away cards")]
		public int? M3_NUC1 => GetNullableInt("NUC1");

		/// <summary>
		/// Description: Number of material requisitions
		/// FieldName: NUC2
		/// FieldType: N
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Number of material requisitions")]
		public int? M3_NUC2 => GetNullableInt("NUC2");

		/// <summary>
		/// Description: Number of labor tickets
		/// FieldName: NUC3
		/// FieldType: N
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Number of labor tickets")]
		public int? M3_NUC3 => GetNullableInt("NUC3");

		/// <summary>
		/// Description: Number of shop travelers
		/// FieldName: NUC4
		/// FieldType: N
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Number of shop travelers")]
		public int? M3_NUC4 => GetNullableInt("NUC4");

		/// <summary>
		/// Description: Number of routing cards
		/// FieldName: NUC5
		/// FieldType: N
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Number of routing cards")]
		public int? M3_NUC5 => GetNullableInt("NUC5");

		/// <summary>
		/// Description: Number of picking lists
		/// FieldName: NUC6
		/// FieldType: N
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Number of picking lists")]
		public int? M3_NUC6 => GetNullableInt("NUC6");

		/// <summary>
		/// Description: Number of design documents
		/// FieldName: NUC7
		/// FieldType: N
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Number of design documents")]
		public int? M3_NUC7 => GetNullableInt("NUC7");

		/// <summary>
		/// Description: Number of components
		/// FieldName: NUMA
		/// FieldType: N
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Number of components")]
		public int? M3_NUMA => GetNullableInt("NUMA");

		/// <summary>
		/// Description: Number of explosion items
		/// FieldName: NUBD
		/// FieldType: N
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Number of explosion items")]
		public int? M3_NUBD => GetNullableInt("NUBD");

		/// <summary>
		/// Description: Number of operations
		/// FieldName: NUOP
		/// FieldType: N
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Number of operations")]
		public int? M3_NUOP => GetNullableInt("NUOP");

		/// <summary>
		/// Description: Number of phantom items
		/// FieldName: NUPH
		/// FieldType: N
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Number of phantom items")]
		public int? M3_NUPH => GetNullableInt("NUPH");

		/// <summary>
		/// Description: Number of subcontract operations
		/// FieldName: NUSC
		/// FieldType: N
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Number of subcontract operations")]
		public int? M3_NUSC => GetNullableInt("NUSC");

		/// <summary>
		/// Description: Number of yield components
		/// FieldName: NUEX
		/// FieldType: N
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Number of yield components")]
		public int? M3_NUEX => GetNullableInt("NUEX");

		/// <summary>
		/// Description: Lowest level
		/// FieldName: LEVL
		/// FieldType: N
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Lowest level")]
		public int? M3_LEVL => GetNullableInt("LEVL");

		/// <summary>
		/// Description: Kit control
		/// FieldName: FSCD
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Kit control")]
		public int? M3_FSCD => GetNullableInt("FSCD");

		/// <summary>
		/// Description: Full cost summation
		/// FieldName: UPCO
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Full cost summation")]
		public int? M3_UPCO => GetNullableInt("UPCO");

		/// <summary>
		/// Description: Pricing method
		/// FieldName: PSET
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Pricing method")]
		public int? M3_PSET => GetNullableInt("PSET");

		/// <summary>
		/// Description: Reservation level
		/// FieldName: SRCD
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Reservation level")]
		public int? M3_SRCD => GetNullableInt("SRCD");

		/// <summary>
		/// Description: Statistics level
		/// FieldName: SCCD
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Statistics level")]
		public int? M3_SCCD => GetNullableInt("SCCD");

		/// <summary>
		/// Description: Kit printout
		/// FieldName: KPCD
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Kit printout")]
		public int? M3_KPCD => GetNullableInt("KPCD");

		/// <summary>
		/// Description: Pull-up control - nondelayed orders
		/// FieldName: PULN
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Pull-up control - nondelayed orders")]
		public int? M3_PULN => GetNullableInt("PULN");

		/// <summary>
		/// Description: Pull-up control - delayed orders
		/// FieldName: PULD
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Pull-up control - delayed orders")]
		public int? M3_PULD => GetNullableInt("PULD");

		/// <summary>
		/// Description: Clock date
		/// FieldName: SDAT
		/// FieldType: N
		/// Length: 8
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Clock date")]
		public int? M3_SDAT => GetNullableInt("SDAT");

		/// <summary>
		/// Description: Clock time
		/// FieldName: STTE
		/// FieldType: N
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Clock time")]
		public int? M3_STTE => GetNullableInt("STTE");

		/// <summary>
		/// Description: Suppress Kit Screen
		/// FieldName: SKTS
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Suppress Kit Screen")]
		public int? M3_SKTS => GetNullableInt("SKTS");

		/// <summary>
		/// Description: Product structure class
		/// FieldName: PSCL
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Product structure class")]
		public string M3_PSCL => GetString("PSCL");

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
		/// Description: Number of production lot cards
		/// FieldName: NUC8
		/// FieldType: N
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Number of production lot cards")]
		public int? M3_NUC8 => GetNullableInt("NUC8");

		/// <summary>
		/// Description: Percentage BOM
		/// FieldName: PCBO
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Percentage BOM")]
		public int? M3_PCBO => GetNullableInt("PCBO");

		/// <summary>
		/// Description: Production lot controlled/op exist
		/// FieldName: PPMG
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Production lot controlled/op exist")]
		public int? M3_PPMG => GetNullableInt("PPMG");

		/// <summary>
		/// Description: Kit printout PO
		/// FieldName: KPPO
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Kit printout PO")]
		public int? M3_KPPO => GetNullableInt("KPPO");

		/// <summary>
		/// Description: WVRNF
		/// FieldName: VRNF
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("WVRNF")]
		public int? M3_VRNF => GetNullableInt("VRNF");

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
		/// Description: Maintained by external system
		/// FieldName: MNPL
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Maintained by external system")]
		public int? M3_MNPL => GetNullableInt("MNPL");

		/// <summary>
		/// Description: Allow date gap
		/// FieldName: AGAP
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Allow date gap")]
		public int? M3_AGAP => GetNullableInt("AGAP");
	}
}
// EOF
