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

namespace M3H5Lib.Api.MMS200MI
{
	public partial class GetResponse : M3BaseRecord 
	{

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
		/// Description: Item number
		/// FieldName: ITNO
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Item number")]
		public string M3ITNO => GetString("ITNO");

		/// <summary>
		/// Description: Name
		/// FieldName: ITDS
		/// FieldType: A
		/// Length: 30
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Name")]
		public string M3ITDS => GetString("ITDS");

		/// <summary>
		/// Description: Description 2
		/// FieldName: FUDS
		/// FieldType: A
		/// Length: 60
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Description 2")]
		public string M3FUDS => GetString("FUDS");

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
		/// Description: Basic unit of measure
		/// FieldName: UNMS
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Basic unit of measure")]
		public string M3UNMS => GetString("UNMS");

		/// <summary>
		/// Description: Item group
		/// FieldName: ITGR
		/// FieldType: A
		/// Length: 8
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Item group")]
		public string M3ITGR => GetString("ITGR");

		/// <summary>
		/// Description: Product group
		/// FieldName: ITCL
		/// FieldType: A
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Product group")]
		public string M3ITCL => GetString("ITCL");

		/// <summary>
		/// Description: Business area
		/// FieldName: BUAR
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Business area")]
		public string M3BUAR => GetString("BUAR");

		/// <summary>
		/// Description: Item type
		/// FieldName: ITTY
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Item type")]
		public string M3ITTY => GetString("ITTY");

		/// <summary>
		/// Description: Item category
		/// FieldName: TPCD
		/// FieldType: N
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Item category")]
		public int? M3TPCD => GetNullableInt("TPCD");

		/// <summary>
		/// Description: Make/buy code
		/// FieldName: MABU
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Make/buy code")]
		public int? M3MABU => GetNullableInt("MABU");

		/// <summary>
		/// Description: Configuration code
		/// FieldName: CHCD
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Configuration code")]
		public int? M3CHCD => GetNullableInt("CHCD");

		/// <summary>
		/// Description: Inventory accounting
		/// FieldName: STCD
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Inventory accounting")]
		public int? M3STCD => GetNullableInt("STCD");

		/// <summary>
		/// Description: Lot numbering method
		/// FieldName: BACD
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Lot numbering method")]
		public int? M3BACD => GetNullableInt("BACD");

		/// <summary>
		/// Description: Volume
		/// FieldName: VOL3
		/// FieldType: N
		/// Length: 11
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Volume")]
		public decimal? M3VOL3 => GetNullableDecimal("VOL3");

		/// <summary>
		/// Description: Net weight
		/// FieldName: NEWE
		/// FieldType: N
		/// Length: 11
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Net weight")]
		public decimal? M3NEWE => GetNullableDecimal("NEWE");

		/// <summary>
		/// Description: Gross weight
		/// FieldName: GRWE
		/// FieldType: N
		/// Length: 11
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Gross weight")]
		public decimal? M3GRWE => GetNullableDecimal("GRWE");

		/// <summary>
		/// Description: Purchase price U/M
		/// FieldName: PPUN
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Purchase price U/M")]
		public string M3PPUN => GetString("PPUN");

		/// <summary>
		/// Description: By/co-product code
		/// FieldName: BYPR
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("By/co-product code")]
		public int? M3BYPR => GetNullableInt("BYPR");

		/// <summary>
		/// Description: Normal waste percentage
		/// FieldName: WAPC
		/// FieldType: N
		/// Length: 7
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Normal waste percentage")]
		public int? M3WAPC => GetNullableInt("WAPC");

		/// <summary>
		/// Description: Inspection code
		/// FieldName: QACD
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Inspection code")]
		public int? M3QACD => GetNullableInt("QACD");

		/// <summary>
		/// Description: Yield calculation
		/// FieldName: EPCD
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Yield calculation")]
		public int? M3EPCD => GetNullableInt("EPCD");

		/// <summary>
		/// Description: Normal potency
		/// FieldName: POCY
		/// FieldType: N
		/// Length: 7
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Normal potency")]
		public int? M3POCY => GetNullableInt("POCY");

		/// <summary>
		/// Description: Active or catch weight item
		/// FieldName: ACTI
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Active or catch weight item")]
		public int? M3ACTI => GetNullableInt("ACTI");

		/// <summary>
		/// Description: Hierachy level 1
		/// FieldName: HIE1
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Hierachy level 1")]
		public string M3HIE1 => GetString("HIE1");

		/// <summary>
		/// Description: Hierachy level 2
		/// FieldName: HIE2
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Hierachy level 2")]
		public string M3HIE2 => GetString("HIE2");

		/// <summary>
		/// Description: Hierachy level 3
		/// FieldName: HIE3
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Hierachy level 3")]
		public string M3HIE3 => GetString("HIE3");

		/// <summary>
		/// Description: Hierachy level 4
		/// FieldName: HIE4
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Hierachy level 4")]
		public string M3HIE4 => GetString("HIE4");

		/// <summary>
		/// Description: Hierachy level 5
		/// FieldName: HIE5
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Hierachy level 5")]
		public string M3HIE5 => GetString("HIE5");

		/// <summary>
		/// Description: Search group 1
		/// FieldName: GRP1
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Search group 1")]
		public string M3GRP1 => GetString("GRP1");

		/// <summary>
		/// Description: Search group 2
		/// FieldName: GRP2
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Search group 2")]
		public string M3GRP2 => GetString("GRP2");

		/// <summary>
		/// Description: Search group 3
		/// FieldName: GRP3
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Search group 3")]
		public string M3GRP3 => GetString("GRP3");

		/// <summary>
		/// Description: Search group 4
		/// FieldName: GRP4
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Search group 4")]
		public string M3GRP4 => GetString("GRP4");

		/// <summary>
		/// Description: Search group 5
		/// FieldName: GRP5
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Search group 5")]
		public string M3GRP5 => GetString("GRP5");

		/// <summary>
		/// Description: User-defined field 1 - item
		/// FieldName: CFI1
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("User-defined field 1 - item")]
		public string M3CFI1 => GetString("CFI1");

		/// <summary>
		/// Description: User-defined field 2 - item
		/// FieldName: CFI2
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("User-defined field 2 - item")]
		public decimal? M3CFI2 => GetNullableDecimal("CFI2");

		/// <summary>
		/// Description: User-defined field 3 - item
		/// FieldName: CFI3
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("User-defined field 3 - item")]
		public string M3CFI3 => GetString("CFI3");

		/// <summary>
		/// Description: User-defined field 4 - item
		/// FieldName: CFI4
		/// FieldType: A
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("User-defined field 4 - item")]
		public string M3CFI4 => GetString("CFI4");

		/// <summary>
		/// Description: User-defined field 5 - item
		/// FieldName: CFI5
		/// FieldType: A
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("User-defined field 5 - item")]
		public string M3CFI5 => GetString("CFI5");

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
		/// Description: ECO managed
		/// FieldName: ECMA
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("ECO managed")]
		public int? M3ECMA => GetNullableInt("ECMA");

		/// <summary>
		/// Description: Procurement group
		/// FieldName: PRGP
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Procurement group")]
		public string M3PRGP => GetString("PRGP");

		/// <summary>
		/// Description: Lot control method
		/// FieldName: INDI
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Lot control method")]
		public int? M3INDI => GetNullableInt("INDI");

		/// <summary>
		/// Description: Purchase order U/M
		/// FieldName: PUUN
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Purchase order U/M")]
		public string M3PUUN => GetString("PUUN");

		/// <summary>
		/// Description: Alternate U/M in use
		/// FieldName: ALUC
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Alternate U/M in use")]
		public int? M3ALUC => GetNullableInt("ALUC");

		/// <summary>
		/// Description: Item exists as alias identity
		/// FieldName: IEAA
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Item exists as alias identity")]
		public int? M3IEAA => GetNullableInt("IEAA");

		/// <summary>
		/// Description: Expiration date method
		/// FieldName: EXPD
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Expiration date method")]
		public int? M3EXPD => GetNullableInt("EXPD");

		/// <summary>
		/// Description: Goods receiving method
		/// FieldName: GRMT
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Goods receiving method")]
		public string M3GRMT => GetString("GRMT");

		/// <summary>
		/// Description: Danger indicator
		/// FieldName: HAZI
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Danger indicator")]
		public int? M3HAZI => GetNullableInt("HAZI");

		/// <summary>
		/// Description: Sales item
		/// FieldName: SALE
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Sales item")]
		public int? M3SALE => GetNullableInt("SALE");

		/// <summary>
		/// Description: Tax code customer/address
		/// FieldName: TAXC
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Tax code customer/address")]
		public string M3TAXC => GetString("TAXC");

		/// <summary>
		/// Description: Attribute model
		/// FieldName: ATMO
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Attribute model")]
		public string M3ATMO => GetString("ATMO");

		/// <summary>
		/// Description: Attribute managed
		/// FieldName: ATMN
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Attribute managed")]
		public int? M3ATMN => GetNullableInt("ATMN");

		/// <summary>
		/// Description: Template item number
		/// FieldName: TPLI
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Template item number")]
		public string M3TPLI => GetString("TPLI");

		/// <summary>
		/// Description: Estimated free unit of assigned goods
		/// FieldName: FCU1
		/// FieldType: N
		/// Length: 13
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Estimated free unit of assigned goods")]
		public decimal? M3FCU1 => GetNullableDecimal("FCU1");

		/// <summary>
		/// Description: Alternate U/M
		/// FieldName: ALUN
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Alternate U/M")]
		public string M3ALUN => GetString("ALUN");

		/// <summary>
		/// Description: Attribute-controlled item
		/// FieldName: IACP
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Attribute-controlled item")]
		public int? M3IACP => GetNullableInt("IACP");

		/// <summary>
		/// Description: Main product
		/// FieldName: HDPR
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Main product")]
		public string M3HDPR => GetString("HDPR");

		/// <summary>
		/// Description: Extended QA used
		/// FieldName: AAD0
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Extended QA used")]
		public int? M3AAD0 => GetNullableInt("AAD0");

		/// <summary>
		/// Description: Generate txt from text template
		/// FieldName: AAD1
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Generate txt from text template")]
		public int? M3AAD1 => GetNullableInt("AAD1");

		/// <summary>
		/// Description: Charge calculation
		/// FieldName: CHCL
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Charge calculation")]
		public int? M3CHCL => GetNullableInt("CHCL");

		/// <summary>
		/// Description: Individual item tracing
		/// FieldName: ITRC
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Individual item tracing")]
		public int? M3ITRC => GetNullableInt("ITRC");

		/// <summary>
		/// Description: VAT code - purchase
		/// FieldName: VTCP
		/// FieldType: N
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("VAT code - purchase")]
		public int? M3VTCP => GetNullableInt("VTCP");

		/// <summary>
		/// Description: VAT code - sales
		/// FieldName: VTCS
		/// FieldType: N
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("VAT code - sales")]
		public int? M3VTCS => GetNullableInt("VTCS");

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
		/// Description: Number of decimal places
		/// FieldName: DCCD
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Number of decimal places")]
		public int? M3DCCD => GetNullableInt("DCCD");

		/// <summary>
		/// Description: Number of price decimal places
		/// FieldName: PDCC
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Number of price decimal places")]
		public int? M3PDCC => GetNullableInt("PDCC");

		/// <summary>
		/// Description: Sales price unit of measure
		/// FieldName: SPUN
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Sales price unit of measure")]
		public string M3SPUN => GetString("SPUN");

		/// <summary>
		/// Description: Group Technology Class
		/// FieldName: GRTI
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Group Technology Class")]
		public string M3GRTI => GetString("GRTI");

		/// <summary>
		/// Description: Distribution Group Technology
		/// FieldName: GRTS
		/// FieldType: A
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Distribution Group Technology")]
		public string M3GRTS => GetString("GRTS");

		/// <summary>
		/// Description: Assortment check
		/// FieldName: ACHK
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Assortment check")]
		public int? M3ACHK => GetNullableInt("ACHK");

		/// <summary>
		/// Description: Catch weight mode
		/// FieldName: CAWP
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Catch weight mode")]
		public int? M3CAWP => GetNullableInt("CAWP");

		/// <summary>
		/// Description: Catch weight unit of measure
		/// FieldName: CWUN
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Catch weight unit of measure")]
		public string M3CWUN => GetString("CWUN");

		/// <summary>
		/// Description: Standard cost price unit of measure
		/// FieldName: CPUN
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Standard cost price unit of measure")]
		public string M3CPUN => GetString("CPUN");

		/// <summary>
		/// Description: Attribute number
		/// FieldName: ATNR
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Attribute number")]
		public decimal? M3ATNR => GetNullableDecimal("ATNR");

		/// <summary>
		/// Description: Non-material type
		/// FieldName: NMIT
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Non-material type")]
		public string M3NMIT => GetString("NMIT");

		/// <summary>
		/// Description: Core terms
		/// FieldName: TECR
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Core terms")]
		public string M3TECR => GetString("TECR");

		/// <summary>
		/// Description: Exchangeable
		/// FieldName: EXCA
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Exchangeable")]
		public int? M3EXCA => GetNullableInt("EXCA");

		/// <summary>
		/// Description: Model/site
		/// FieldName: MOTP
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Model/site")]
		public string M3MOTP => GetString("MOTP");

		/// <summary>
		/// Description: Compatibility code
		/// FieldName: ACMC
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Compatibility code")]
		public string M3ACMC => GetString("ACMC");

		/// <summary>
		/// Description: Included in territorial roll-up
		/// FieldName: ITRU
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Included in territorial roll-up")]
		public int? M3ITRU => GetNullableInt("ITRU");

		/// <summary>
		/// Description: Acceptance group
		/// FieldName: ACCG
		/// FieldType: A
		/// Length: 8
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Acceptance group")]
		public string M3ACCG => GetString("ACCG");

		/// <summary>
		/// Description: Costing model - core charge
		/// FieldName: CCCM
		/// FieldType: A
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Costing model - core charge")]
		public string M3CCCM => GetString("CCCM");

		/// <summary>
		/// Description: Core charge item number
		/// FieldName: CCI1
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Core charge item number")]
		public string M3CCI1 => GetString("CCI1");

		/// <summary>
		/// Description: Core remain item number
		/// FieldName: CRI1
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Core remain item number")]
		public string M3CRI1 => GetString("CRI1");

		/// <summary>
		/// Description: Harvest Method
		/// FieldName: HVMT
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Harvest Method")]
		public int? M3HVMT => GetNullableInt("HVMT");

		/// <summary>
		/// Description: Extended item number
		/// FieldName: ITNE
		/// FieldType: A
		/// Length: 40
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Extended item number")]
		public string M3ITNE => GetString("ITNE");

		/// <summary>
		/// Description: Specific gravity
		/// FieldName: SPGV
		/// FieldType: N
		/// Length: 11
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Specific gravity")]
		public decimal? M3SPGV => GetNullableDecimal("SPGV");

		/// <summary>
		/// Description: Product line
		/// FieldName: PDLN
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Product line")]
		public string M3PDLN => GetString("PDLN");

		/// <summary>
		/// Description: Composition group
		/// FieldName: CPGR
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Composition group")]
		public string M3CPGR => GetString("CPGR");

		/// <summary>
		/// Description: Sublot method
		/// FieldName: SUME
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Sublot method")]
		public int? M3SUME => GetNullableInt("SUME");

		/// <summary>
		/// Description: Sublot policy
		/// FieldName: SUMP
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Sublot policy")]
		public string M3SUMP => GetString("SUMP");

		/// <summary>
		/// Description: Environment group
		/// FieldName: EVGR
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Environment group")]
		public string M3EVGR => GetString("EVGR");

		/// <summary>
		/// Description: Quality group
		/// FieldName: QMGP
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Quality group")]
		public string M3QMGP => GetString("QMGP");
	}
}
// EOF
