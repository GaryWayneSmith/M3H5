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
	public partial class GetItmWhsBasicResponse : M3BaseRecord 
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
		/// Description: Warehouse description
		/// FieldName: WHNM
		/// FieldType: A
		/// Length: 36
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Warehouse description")]
		public string M3_WHNM => GetString("WHNM");

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
		/// Description: Allocation method
		/// FieldName: ALMT
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Allocation method")]
		public int? M3_ALMT => GetNullableInt("ALMT");

		/// <summary>
		/// Description: Storage method
		/// FieldName: STMT
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Storage method")]
		public int? M3_STMT => GetNullableInt("STMT");

		/// <summary>
		/// Description: Issue method
		/// FieldName: SPMT
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Issue method")]
		public int? M3_SPMT => GetNullableInt("SPMT");

		/// <summary>
		/// Description: Note
		/// FieldName: STTX
		/// FieldType: A
		/// Length: 30
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Note")]
		public string M3_STTX => GetString("STTX");

		/// <summary>
		/// Description: Physical inventory cycle
		/// FieldName: INCD
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Physical inventory cycle")]
		public string M3_INCD => GetString("INCD");

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
		/// Description: Buyer
		/// FieldName: BUYE
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Buyer")]
		public string M3_BUYE => GetString("BUYE");

		/// <summary>
		/// Description: Supplier number
		/// FieldName: SUNO
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Supplier number")]
		public string M3_SUNO => GetString("SUNO");

		/// <summary>
		/// Description: Warehouse type
		/// FieldName: WHTY
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Warehouse type")]
		public string M3_WHTY => GetString("WHTY");

		/// <summary>
		/// Description: Warehouse subtype
		/// FieldName: WHSY
		/// FieldType: A
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Warehouse subtype")]
		public string M3_WHSY => GetString("WHSY");

		/// <summary>
		/// Description: Statistics storage group
		/// FieldName: INSC
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Statistics storage group")]
		public int? M3_INSC => GetNullableInt("INSC");

		/// <summary>
		/// Description: Distribution group
		/// FieldName: DIGR
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Distribution group")]
		public string M3_DIGR => GetString("DIGR");

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
		/// Description: Issue multiple
		/// FieldName: TOMU
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Issue multiple")]
		public decimal? M3_TOMU => GetNullableDecimal("TOMU");

		/// <summary>
		/// Description: Location type
		/// FieldName: WHLT
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Location type")]
		public string M3_WHLT => GetString("WHLT");

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
		/// Description: Planning policy
		/// FieldName: PLCD
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Planning policy")]
		public string M3_PLCD => GetString("PLCD");

		/// <summary>
		/// Description: ABC class - manual
		/// FieldName: MABC
		/// FieldType: A
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("ABC class - manual")]
		public string M3_MABC => GetString("MABC");

		/// <summary>
		/// Description: ABC class - volume
		/// FieldName: ABCD
		/// FieldType: A
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("ABC class - volume")]
		public string M3_ABCD => GetString("ABCD");

		/// <summary>
		/// Description: ABC method  - volume
		/// FieldName: ABCM
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("ABC method  - volume")]
		public int? M3_ABCM => GetNullableInt("ABCM");

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
		/// Description: ABC method - frequency
		/// FieldName: ABFM
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("ABC method - frequency")]
		public int? M3_ABFM => GetNullableInt("ABFM");

		/// <summary>
		/// Description: ABC class - contribution
		/// FieldName: ACOC
		/// FieldType: A
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("ABC class - contribution")]
		public string M3_ACOC => GetString("ACOC");

		/// <summary>
		/// Description: ABC method - contribution
		/// FieldName: ACOM
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("ABC method - contribution")]
		public int? M3_ACOM => GetNullableInt("ACOM");

		/// <summary>
		/// Description: Reorder point
		/// FieldName: REOP
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Reorder point")]
		public decimal? M3_REOP => GetNullableDecimal("REOP");

		/// <summary>
		/// Description: Reorder point method
		/// FieldName: OPOM
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Reorder point method")]
		public int? M3_OPOM => GetNullableInt("OPOM");

		/// <summary>
		/// Description: Safety stock
		/// FieldName: SSQT
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Safety stock")]
		public decimal? M3_SSQT => GetNullableDecimal("SSQT");

		/// <summary>
		/// Description: Safety stock method
		/// FieldName: SSMT
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Safety stock method")]
		public int? M3_SSMT => GetNullableInt("SSMT");

		/// <summary>
		/// Description: Manual safety stock
		/// FieldName: MSSQ
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Manual safety stock")]
		public decimal? M3_MSSQ => GetNullableDecimal("MSSQ");

		/// <summary>
		/// Description: Safety stock unit
		/// FieldName: SSDA
		/// FieldType: N
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Safety stock unit")]
		public int? M3_SSDA => GetNullableInt("SSDA");

		/// <summary>
		/// Description: Service level
		/// FieldName: SCGR
		/// FieldType: N
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Service level")]
		public int? M3_SCGR => GetNullableInt("SCGR");

		/// <summary>
		/// Description: Maximum stock
		/// FieldName: MXST
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Maximum stock")]
		public decimal? M3_MXST => GetNullableDecimal("MXST");

		/// <summary>
		/// Description: Maximum stock method
		/// FieldName: MXSM
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Maximum stock method")]
		public int? M3_MXSM => GetNullableInt("MXSM");

		/// <summary>
		/// Description: Maximum stock percentage
		/// FieldName: MXPC
		/// FieldType: N
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Maximum stock percentage")]
		public int? M3_MXPC => GetNullableInt("MXPC");

		/// <summary>
		/// Description: Order quantity
		/// FieldName: EOQT
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Order quantity")]
		public decimal? M3_EOQT => GetNullableDecimal("EOQT");

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
		/// Description: Economical order quantity days
		/// FieldName: EQDA
		/// FieldType: N
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Economical order quantity days")]
		public int? M3_EQDA => GetNullableInt("EQDA");

		/// <summary>
		/// Description: Annual demand
		/// FieldName: YEQT
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Annual demand")]
		public decimal? M3_YEQT => GetNullableDecimal("YEQT");

		/// <summary>
		/// Description: Annual demand method
		/// FieldName: YEQM
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Annual demand method")]
		public int? M3_YEQM => GetNullableInt("YEQM");

		/// <summary>
		/// Description: Minimum order quantity
		/// FieldName: LOQT
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Minimum order quantity")]
		public decimal? M3_LOQT => GetNullableDecimal("LOQT");

		/// <summary>
		/// Description: Maximum order quantity
		/// FieldName: MOQT
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Maximum order quantity")]
		public decimal? M3_MOQT => GetNullableDecimal("MOQT");

		/// <summary>
		/// Description: Acquisition code
		/// FieldName: PUIT
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Acquisition code")]
		public int? M3_PUIT => GetNullableInt("PUIT");

		/// <summary>
		/// Description: Supplying warehouse
		/// FieldName: SUWH
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Supplying warehouse")]
		public string M3_SUWH => GetString("SUWH");

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
		/// Description: Forecast method
		/// FieldName: PRCD
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Forecast method")]
		public string M3_PRCD => GetString("PRCD");

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
		/// Description: Supply lead time
		/// FieldName: LEA1
		/// FieldType: N
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Supply lead time")]
		public int? M3_LEA1 => GetNullableInt("LEA1");

		/// <summary>
		/// Description: Inspection lead time
		/// FieldName: LEA2
		/// FieldType: N
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Inspection lead time")]
		public int? M3_LEA2 => GetNullableInt("LEA2");

		/// <summary>
		/// Description: Transportation lead time
		/// FieldName: LEA3
		/// FieldType: N
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Transportation lead time")]
		public int? M3_LEA3 => GetNullableInt("LEA3");

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
		/// Description: Transmission lead time - supplier
		/// FieldName: PODA
		/// FieldType: N
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Transmission lead time - supplier")]
		public int? M3_PODA => GetNullableInt("PODA");

		/// <summary>
		/// Description: Lead time
		/// FieldName: LEAT
		/// FieldType: N
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Lead time")]
		public int? M3_LEAT => GetNullableInt("LEAT");

		/// <summary>
		/// Description: Order multiple
		/// FieldName: UNMU
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Order multiple")]
		public decimal? M3_UNMU => GetNullableDecimal("UNMU");

		/// <summary>
		/// Description: Multiple supply
		/// FieldName: SVEI
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Multiple supply")]
		public int? M3_SVEI => GetNullableInt("SVEI");

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
		/// Description: Lowest level DO
		/// FieldName: LEVD
		/// FieldType: N
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Lowest level DO")]
		public int? M3_LEVD => GetNullableInt("LEVD");

		/// <summary>
		/// Description: Planning horizon
		/// FieldName: PLHZ
		/// FieldType: N
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Planning horizon")]
		public int? M3_PLHZ => GetNullableInt("PLHZ");

		/// <summary>
		/// Description: Demand time fence
		/// FieldName: DMFN
		/// FieldType: N
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Demand time fence")]
		public int? M3_DMFN => GetNullableInt("DMFN");

		/// <summary>
		/// Description: Order type
		/// FieldName: ORTY
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Order type")]
		public string M3_ORTY => GetString("ORTY");

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
		/// Description: Safety time
		/// FieldName: SATD
		/// FieldType: N
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Safety time")]
		public int? M3_SATD => GetNullableInt("SATD");

		/// <summary>
		/// Description: Quantity controlled allocation
		/// FieldName: ALQC
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Quantity controlled allocation")]
		public int? M3_ALQC => GetNullableInt("ALQC");

		/// <summary>
		/// Description: Planning method
		/// FieldName: OPLC
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Planning method")]
		public int? M3_OPLC => GetNullableInt("OPLC");

		/// <summary>
		/// Description: Master scheduled
		/// FieldName: MSCH
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Master scheduled")]
		public int? M3_MSCH => GetNullableInt("MSCH");

		/// <summary>
		/// Description: Distribution/supplier calendar check
		/// FieldName: SHCC
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Distribution/supplier calendar check")]
		public int? M3_SHCC => GetNullableInt("SHCC");

		/// <summary>
		/// Description: Inspection location
		/// FieldName: INSL
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Inspection location")]
		public string M3_INSL => GetString("INSL");

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
		/// Description: Time phased safety stock exists
		/// FieldName: DDEX
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Time phased safety stock exists")]
		public int? M3_DDEX => GetNullableInt("DDEX");

		/// <summary>
		/// Description: History storage method
		/// FieldName: STRL
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("History storage method")]
		public int? M3_STRL => GetNullableInt("STRL");

		/// <summary>
		/// Description: Picking list information control
		/// FieldName: PLIC
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Picking list information control")]
		public int? M3_PLIC => GetNullableInt("PLIC");

		/// <summary>
		/// Description: Pending planning method change
		/// FieldName: PPMC
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Pending planning method change")]
		public int? M3_PPMC => GetNullableInt("PPMC");

		/// <summary>
		/// Description: Responsible - PO proposal
		/// FieldName: RPOP
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Responsible - PO proposal")]
		public int? M3_RPOP => GetNullableInt("RPOP");

		/// <summary>
		/// Description: Standard cost - warehouse
		/// FieldName: BCOS
		/// FieldType: N
		/// Length: 19
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Standard cost - warehouse")]
		public decimal? M3_BCOS => GetNullableDecimal("BCOS");

		/// <summary>
		/// Description: Default packing location
		/// FieldName: DPLO
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Default packing location")]
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
		/// Description: Delivery split rule
		/// FieldName: SPLC
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Delivery split rule")]
		public string M3_SPLC => GetString("SPLC");

		/// <summary>
		/// Description: Allocate non-approved balance ID
		/// FieldName: ALS1
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Allocate non-approved balance ID")]
		public int? M3_ALS1 => GetNullableInt("ALS1");

		/// <summary>
		/// Description: Point of time table
		/// FieldName: POOT
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Point of time table")]
		public string M3_POOT => GetString("POOT");

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
		/// Description: VAT code - purchase
		/// FieldName: VTCP
		/// FieldType: N
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("VAT code - purchase")]
		public int? M3_VTCP => GetNullableInt("VTCP");

		/// <summary>
		/// Description: VAT code - sales
		/// FieldName: VTCS
		/// FieldType: N
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("VAT code - sales")]
		public int? M3_VTCS => GetNullableInt("VTCS");

		/// <summary>
		/// Description: Main unit of calculation
		/// FieldName: MNUN
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Main unit of calculation")]
		public string M3_MNUN => GetString("MNUN");

		/// <summary>
		/// Description: Distribution group technology
		/// FieldName: GRTS
		/// FieldType: A
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Distribution group technology")]
		public string M3_GRTS => GetString("GRTS");

		/// <summary>
		/// Description: Shelf life
		/// FieldName: SLDY
		/// FieldType: N
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Shelf life")]
		public int? M3_SLDY => GetNullableInt("SLDY");

		/// <summary>
		/// Description: Reinspection time
		/// FieldName: REDY
		/// FieldType: N
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Reinspection time")]
		public int? M3_REDY => GetNullableInt("REDY");

		/// <summary>
		/// Description: Sales time
		/// FieldName: SAEL
		/// FieldType: N
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Sales time")]
		public int? M3_SAEL => GetNullableInt("SAEL");

		/// <summary>
		/// Description: CTP policy
		/// FieldName: CPCD
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("CTP policy")]
		public string M3_CPCD => GetString("CPCD");

		/// <summary>
		/// Description: Quarantine lead-time
		/// FieldName: LEAQ
		/// FieldType: N
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Quarantine lead-time")]
		public int? M3_LEAQ => GetNullableInt("LEAQ");

		/// <summary>
		/// Description: Scheduled re-classification allowed
		/// FieldName: SCHT
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Scheduled re-classification allowed")]
		public int? M3_SCHT => GetNullableInt("SCHT");

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
		/// Description: Inventory planned
		/// FieldName: IPLA
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Inventory planned")]
		public string M3_IPLA => GetString("IPLA");

		/// <summary>
		/// Description: Best before time
		/// FieldName: BBTM
		/// FieldType: N
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Best before time")]
		public int? M3_BBTM => GetNullableInt("BBTM");

		/// <summary>
		/// Description: Frozen safety stock
		/// FieldName: FSSQ
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Frozen safety stock")]
		public int? M3_FSSQ => GetNullableInt("FSSQ");

		/// <summary>
		/// Description: Supply chain policy
		/// FieldName: SCPO
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Supply chain policy")]
		public string M3_SCPO => GetString("SCPO");

		/// <summary>
		/// Description: Returnable / non returnable indicator
		/// FieldName: RNRI
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Returnable / non returnable indicator")]
		public int? M3_RNRI => GetNullableInt("RNRI");

		/// <summary>
		/// Description: Returnable message
		/// FieldName: RMSG
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Returnable message")]
		public int? M3_RMSG => GetNullableInt("RMSG");

		/// <summary>
		/// Description: Surplus stock type
		/// FieldName: SURT
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Surplus stock type")]
		public string M3_SURT => GetString("SURT");

		/// <summary>
		/// Description: SS reason code
		/// FieldName: SSRE
		/// FieldType: A
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("SS reason code")]
		public string M3_SSRE => GetString("SSRE");

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
		/// Description: Secondary allocation method
		/// FieldName: SALM
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Secondary allocation method")]
		public int? M3_SALM => GetNullableInt("SALM");

		/// <summary>
		/// Description: Aging days
		/// FieldName: AGDY
		/// FieldType: N
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Aging days")]
		public int? M3_AGDY => GetNullableInt("AGDY");

		/// <summary>
		/// Description: Aging hours
		/// FieldName: AGHO
		/// FieldType: N
		/// Length: 4
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Aging hours")]
		public int? M3_AGHO => GetNullableInt("AGHO");

		/// <summary>
		/// Description: Aging minutes
		/// FieldName: AGMI
		/// FieldType: N
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Aging minutes")]
		public int? M3_AGMI => GetNullableInt("AGMI");

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
	}
}
// EOF