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

namespace M3H5Lib.Api.MWS422MI
{
	public partial class SelPickDetailResponse : M3BaseRecord 
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
		/// Description: Warehouse
		/// FieldName: WHLO
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Warehouse")]
		public string M3_WHLO => GetString("WHLO");

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
		/// Description: Lot number
		/// FieldName: BANO
		/// FieldType: A
		/// Length: 20
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Lot number")]
		public string M3_BANO => GetString("BANO");

		/// <summary>
		/// Description: Container
		/// FieldName: CAMU
		/// FieldType: A
		/// Length: 20
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Container")]
		public string M3_CAMU => GetString("CAMU");

		/// <summary>
		/// Description: Receiving number
		/// FieldName: REPN
		/// FieldType: N
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Receiving number")]
		public long? M3_REPN => GetNullableLong("REPN");

		/// <summary>
		/// Description: Stock transaction type
		/// FieldName: TTYP
		/// FieldType: N
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Stock transaction type")]
		public int? M3_TTYP => GetNullableInt("TTYP");

		/// <summary>
		/// Description: Order number
		/// FieldName: RIDN
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Order number")]
		public string M3_RIDN => GetString("RIDN");

		/// <summary>
		/// Description: Order operation
		/// FieldName: RIDO
		/// FieldType: N
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Order operation")]
		public int? M3_RIDO => GetNullableInt("RIDO");

		/// <summary>
		/// Description: Delivery number
		/// FieldName: RIDI
		/// FieldType: N
		/// Length: 11
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Delivery number")]
		public decimal? M3_RIDI => GetNullableDecimal("RIDI");

		/// <summary>
		/// Description: Picking list suffix
		/// FieldName: PLSX
		/// FieldType: N
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Picking list suffix")]
		public int? M3_PLSX => GetNullableInt("PLSX");

		/// <summary>
		/// Description: Order line
		/// FieldName: RIDL
		/// FieldType: N
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Order line")]
		public int? M3_RIDL => GetNullableInt("RIDL");

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
		/// Description: Stock zone
		/// FieldName: SLTP
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Stock zone")]
		public string M3_SLTP => GetString("SLTP");

		/// <summary>
		/// Description: Warehouse equipment
		/// FieldName: PISE
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Warehouse equipment")]
		public string M3_PISE => GetString("PISE");

		/// <summary>
		/// Description: Allocated quantity - basic U/M
		/// FieldName: ALQT
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Allocated quantity - basic U/M")]
		public decimal? M3_ALQT => GetNullableDecimal("ALQT");

		/// <summary>
		/// Description: Sort value
		/// FieldName: SORT
		/// FieldType: A
		/// Length: 20
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Sort value")]
		public string M3_SORT => GetString("SORT");

		/// <summary>
		/// Description: Transportation flow
		/// FieldName: TRFL
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Transportation flow")]
		public string M3_TRFL => GetString("TRFL");

		/// <summary>
		/// Description: Allocation origin
		/// FieldName: MAAL
		/// FieldType: A
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Allocation origin")]
		public string M3_MAAL => GetString("MAAL");

		/// <summary>
		/// Description: Reference text
		/// FieldName: RFTX
		/// FieldType: A
		/// Length: 40
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Reference text")]
		public string M3_RFTX => GetString("RFTX");

		/// <summary>
		/// Description: Program name
		/// FieldName: PGNM
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Program name")]
		public string M3_PGNM => GetString("PGNM");

		/// <summary>
		/// Description: Picking list round
		/// FieldName: PLPR
		/// FieldType: N
		/// Length: 7
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Picking list round")]
		public int? M3_PLPR => GetNullableInt("PLPR");

		/// <summary>
		/// Description: Packed quantity
		/// FieldName: PAQT
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Packed quantity")]
		public decimal? M3_PAQT => GetNullableDecimal("PAQT");

		/// <summary>
		/// Description: Catch weight
		/// FieldName: CAWE
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Catch weight")]
		public decimal? M3_CAWE => GetNullableDecimal("CAWE");

		/// <summary>
		/// Description: From picking location
		/// FieldName: FLOC
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("From picking location")]
		public string M3_FLOC => GetString("FLOC");

		/// <summary>
		/// Description: Printer
		/// FieldName: DEV
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Printer")]
		public string M3_DEV => GetString("DEV");

		/// <summary>
		/// Description: Inventory accounting
		/// FieldName: STCD
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Inventory accounting")]
		public int? M3_STCD => GetNullableInt("STCD");

		/// <summary>
		/// Description: Soft allocation
		/// FieldName: SOFT
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Soft allocation")]
		public int? M3_SOFT => GetNullableInt("SOFT");

		/// <summary>
		/// Description: Transaction quantity - basic U/M
		/// FieldName: TRQT
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Transaction quantity - basic U/M")]
		public decimal? M3_TRQT => GetNullableDecimal("TRQT");

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
		/// Description: To location pick line
		/// FieldName: TWS2
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("To location pick line")]
		public string M3_TWS2 => GetString("TWS2");

		/// <summary>
		/// Description: Flagged as completed
		/// FieldName: OEND
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Flagged as completed")]
		public int? M3_OEND => GetNullableInt("OEND");

		/// <summary>
		/// Description: Wave number
		/// FieldName: PLRI
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Wave number")]
		public string M3_PLRI => GetString("PLRI");

		/// <summary>
		/// Description: Transaction quantity in alt U/M
		/// FieldName: TRQA
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Transaction quantity in alt U/M")]
		public decimal? M3_TRQA => GetNullableDecimal("TRQA");

		/// <summary>
		/// Description: Allocated quantity - alternate U/M
		/// FieldName: ALQA
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Allocated quantity - alternate U/M")]
		public decimal? M3_ALQA => GetNullableDecimal("ALQA");

		/// <summary>
		/// Description: Allocated quantity - nominal
		/// FieldName: ALQN
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Allocated quantity - nominal")]
		public decimal? M3_ALQN => GetNullableDecimal("ALQN");

		/// <summary>
		/// Description: Packed quantity - alternate U/M
		/// FieldName: PAQA
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Packed quantity - alternate U/M")]
		public decimal? M3_PAQA => GetNullableDecimal("PAQA");

		/// <summary>
		/// Description: Detailed order requirement (DOR) number
		/// FieldName: CNNR
		/// FieldType: N
		/// Length: 11
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Detailed order requirement (DOR) number")]
		public decimal? M3_CNNR => GetNullableDecimal("CNNR");

		/// <summary>
		/// Description: Level sequence number
		/// FieldName: LSQN
		/// FieldType: N
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Level sequence number")]
		public int? M3_LSQN => GetNullableInt("LSQN");

		/// <summary>
		/// Description: Structure sequence number
		/// FieldName: SSEQ
		/// FieldType: N
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Structure sequence number")]
		public int? M3_SSEQ => GetNullableInt("SSEQ");

		/// <summary>
		/// Description: Reporting number - pick line
		/// FieldName: PLRN
		/// FieldType: N
		/// Length: 11
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Reporting number - pick line")]
		public decimal? M3_PLRN => GetNullableDecimal("PLRN");

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
		/// Description: Line suffix
		/// FieldName: RIDX
		/// FieldType: N
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Line suffix")]
		public int? M3_RIDX => GetNullableInt("RIDX");

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
		/// Description: Consignee
		/// FieldName: CONA
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Consignee")]
		public string M3_CONA => GetString("CONA");

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
		/// Description: Number of decimal places
		/// FieldName: DCCD
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Number of decimal places")]
		public int? M3_DCCD => GetNullableInt("DCCD");

		/// <summary>
		/// Description: Default pack location
		/// FieldName: DPLO
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Default pack location")]
		public string M3_DPLO => GetString("DPLO");

		/// <summary>
		/// Description: Default docking location
		/// FieldName: DDLO
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Default docking location")]
		public string M3_DDLO => GetString("DDLO");

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
		/// Description: Customer name
		/// FieldName: CUNM
		/// FieldType: A
		/// Length: 36
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Customer name")]
		public string M3_CUNM => GetString("CUNM");

		/// <summary>
		/// Description: Lot numbering method
		/// FieldName: BACD
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Lot numbering method")]
		public int? M3_BACD => GetNullableInt("BACD");

		/// <summary>
		/// Description: Lot control method
		/// FieldName: INDI
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Lot control method")]
		public int? M3_INDI => GetNullableInt("INDI");

		/// <summary>
		/// Description: Container management
		/// FieldName: COMG
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Container management")]
		public int? M3_COMG => GetNullableInt("COMG");

		/// <summary>
		/// Description: Load building
		/// FieldName: LOBL
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Load building")]
		public int? M3_LOBL => GetNullableInt("LOBL");

		/// <summary>
		/// Description: Loading platform
		/// FieldName: LODO
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Loading platform")]
		public string M3_LODO => GetString("LODO");

		/// <summary>
		/// Description: Active or catch weight item
		/// FieldName: ACTI
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Active or catch weight item")]
		public int? M3_ACTI => GetNullableInt("ACTI");

		/// <summary>
		/// Description: Scan required
		/// FieldName: SCRQ
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Scan required")]
		public int? M3_SCRQ => GetNullableInt("SCRQ");

		/// <summary>
		/// Description: Generic Item
		/// FieldName: GENE
		/// FieldType: A
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Generic Item")]
		public string M3_GENE => GetString("GENE");

		/// <summary>
		/// Description: Logistics U/M On
		/// FieldName: LGON
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Logistics U/M On")]
		public int? M3_LGON => GetNullableInt("LGON");

		/// <summary>
		/// Description: Cartonization U/M
		/// FieldName: AUCZ
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Cartonization U/M")]
		public string M3_AUCZ => GetString("AUCZ");

		/// <summary>
		/// Description: Original reporting number - picking line
		/// FieldName: ORRN
		/// FieldType: N
		/// Length: 11
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Original reporting number - picking line")]
		public decimal? M3_ORRN => GetNullableDecimal("ORRN");

		/// <summary>
		/// Description: Weight to pick
		/// FieldName: WTPI
		/// FieldType: N
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Weight to pick")]
		public decimal? M3_WTPI => GetNullableDecimal("WTPI");

		/// <summary>
		/// Description: Volume to pick
		/// FieldName: VTPI
		/// FieldType: N
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Volume to pick")]
		public decimal? M3_VTPI => GetNullableDecimal("VTPI");

		/// <summary>
		/// Description: Weight to pack
		/// FieldName: WTPA
		/// FieldType: N
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Weight to pack")]
		public decimal? M3_WTPA => GetNullableDecimal("WTPA");

		/// <summary>
		/// Description: Volume to pack
		/// FieldName: VTPA
		/// FieldType: N
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Volume to pack")]
		public decimal? M3_VTPA => GetNullableDecimal("VTPA");

		/// <summary>
		/// Description: Priority
		/// FieldName: PRIO
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Priority")]
		public int? M3_PRIO => GetNullableInt("PRIO");

		/// <summary>
		/// Description: Catch weight unit of measure
		/// FieldName: CWUN
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Catch weight unit of measure")]
		public string M3_CWUN => GetString("CWUN");

		/// <summary>
		/// Description: Package number
		/// FieldName: PANR
		/// FieldType: A
		/// Length: 20
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Package number")]
		public string M3_PANR => GetString("PANR");

		/// <summary>
		/// Description: New field description
		/// FieldName: MULS
		/// FieldType: N
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("New field description")]
		public int? M3_MULS => GetNullableInt("MULS");

		/// <summary>
		/// Description: Unloading sequence within place
		/// FieldName: SULS
		/// FieldType: N
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Unloading sequence within place")]
		public int? M3_SULS => GetNullableInt("SULS");

		/// <summary>
		/// Description: Picking sequence
		/// FieldName: SEEQ
		/// FieldType: N
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Picking sequence")]
		public int? M3_SEEQ => GetNullableInt("SEEQ");

		/// <summary>
		/// Description: Departure date
		/// FieldName: DSDT
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Departure date")]
		public DateTime? M3_DSDT => GetNullableDateTime("DSDT");

		/// <summary>
		/// Description: Departure time
		/// FieldName: DSHM
		/// FieldType: N
		/// Length: 4
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Departure time")]
		public int? M3_DSHM => GetNullableInt("DSHM");

		/// <summary>
		/// Description: Shipment
		/// FieldName: CONN
		/// FieldType: N
		/// Length: 7
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Shipment")]
		public int? M3_CONN => GetNullableInt("CONN");

		/// <summary>
		/// Description: Route
		/// FieldName: ROUT
		/// FieldType: A
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Route")]
		public string M3_ROUT => GetString("ROUT");

		/// <summary>
		/// Description: Route departure
		/// FieldName: RODN
		/// FieldType: N
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Route departure")]
		public int? M3_RODN => GetNullableInt("RODN");

		/// <summary>
		/// Description: Delivery method
		/// FieldName: MODL
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Delivery method")]
		public string M3_MODL => GetString("MODL");

		/// <summary>
		/// Description: Final delivery method
		/// FieldName: MODF
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Final delivery method")]
		public string M3_MODF => GetString("MODF");

		/// <summary>
		/// Description: Reference order category
		/// FieldName: RORC
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Reference order category")]
		public int? M3_RORC => GetNullableInt("RORC");

		/// <summary>
		/// Description: Inventory segment
		/// FieldName: ISEG
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Inventory segment")]
		public string M3_ISEG => GetString("ISEG");

		/// <summary>
		/// Description: ABC class - frequency
		/// FieldName: ABFC
		/// FieldType: A
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("ABC class - frequency")]
		public string M3_ABFC => GetString("ABFC");

		/// <summary>
		/// Description: Alternate U/M
		/// FieldName: ALUN
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Alternate U/M")]
		public string M3_ALUN => GetString("ALUN");

		/// <summary>
		/// Description: Gross weight
		/// FieldName: GRWE
		/// FieldType: N
		/// Length: 11
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Gross weight")]
		public decimal? M3_GRWE => GetNullableDecimal("GRWE");

		/// <summary>
		/// Description: Net weight
		/// FieldName: NEWE
		/// FieldType: N
		/// Length: 11
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Net weight")]
		public decimal? M3_NEWE => GetNullableDecimal("NEWE");

		/// <summary>
		/// Description: Volume
		/// FieldName: VOL3
		/// FieldType: N
		/// Length: 11
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Volume")]
		public decimal? M3_VOL3 => GetNullableDecimal("VOL3");

		/// <summary>
		/// Description: Estimated free unit of assigned goods
		/// FieldName: FCU1
		/// FieldType: N
		/// Length: 13
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Estimated free unit of assigned goods")]
		public decimal? M3_FCU1 => GetNullableDecimal("FCU1");

		/// <summary>
		/// Description: Fragility
		/// FieldName: FRAG
		/// FieldType: N
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Fragility")]
		public int? M3_FRAG => GetNullableInt("FRAG");

		/// <summary>
		/// Description: Length
		/// FieldName: ILEN
		/// FieldType: N
		/// Length: 7
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Length")]
		public int? M3_ILEN => GetNullableInt("ILEN");

		/// <summary>
		/// Description: Width
		/// FieldName: IWID
		/// FieldType: N
		/// Length: 7
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Width")]
		public int? M3_IWID => GetNullableInt("IWID");

		/// <summary>
		/// Description: Height
		/// FieldName: IHEI
		/// FieldType: N
		/// Length: 7
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Height")]
		public int? M3_IHEI => GetNullableInt("IHEI");

		/// <summary>
		/// Description: Measurement 1
		/// FieldName: DIM1
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Measurement 1")]
		public string M3_DIM1 => GetString("DIM1");

		/// <summary>
		/// Description: Measurement 2
		/// FieldName: DIM2
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Measurement 2")]
		public string M3_DIM2 => GetString("DIM2");

		/// <summary>
		/// Description: Measurement 3
		/// FieldName: DIM3
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Measurement 3")]
		public string M3_DIM3 => GetString("DIM3");
	}
}
// EOF
