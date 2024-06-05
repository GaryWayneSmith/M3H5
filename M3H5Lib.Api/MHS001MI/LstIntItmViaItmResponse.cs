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

namespace M3H5Lib.Api.MHS001MI
{
	public partial class LstIntItmViaItmResponse : M3BaseRecord 
	{

		/// <summary>
		/// Description: Partner
		/// FieldName: E0PA
		/// FieldType: A
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Partner")]
		public string M3_E0PA => GetString("E0PA");

		/// <summary>
		/// Description: Message type
		/// FieldName: E065
		/// FieldType: A
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Message type")]
		public string M3_E065 => GetString("E065");

		/// <summary>
		/// Description: Interface item number
		/// FieldName: IFIN
		/// FieldType: A
		/// Length: 32
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Interface item number")]
		public string M3_IFIN => GetString("IFIN");

		/// <summary>
		/// Description: External message number
		/// FieldName: PMSN
		/// FieldType: A
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("External message number")]
		public string M3_PMSN => GetString("PMSN");

		/// <summary>
		/// Description: Status
		/// FieldName: STAI
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Status")]
		public string M3_STAI => GetString("STAI");

		/// <summary>
		/// Description: Lowest status child table
		/// FieldName: STOT
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Lowest status child table")]
		public string M3_STOT => GetString("STOT");

		/// <summary>
		/// Description: Exist in BE
		/// FieldName: EXBE
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Exist in BE")]
		public int? M3_EXBE => GetNullableInt("EXBE");

		/// <summary>
		/// Description: Message ID
		/// FieldName: MSID
		/// FieldType: A
		/// Length: 7
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Message ID")]
		public string M3_MSID => GetString("MSID");

		/// <summary>
		/// Description: Message
		/// FieldName: MSGD
		/// FieldType: A
		/// Length: 78
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Message")]
		public string M3_MSGD => GetString("MSGD");

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
		/// Description: Description 2
		/// FieldName: FUDS
		/// FieldType: A
		/// Length: 60
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Description 2")]
		public string M3_FUDS => GetString("FUDS");

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
		/// Description: Item type
		/// FieldName: ITTY
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Item type")]
		public string M3_ITTY => GetString("ITTY");

		/// <summary>
		/// Description: Item group
		/// FieldName: ITGR
		/// FieldType: A
		/// Length: 8
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Item group")]
		public string M3_ITGR => GetString("ITGR");

		/// <summary>
		/// Description: Product group
		/// FieldName: ITCL
		/// FieldType: A
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Product group")]
		public string M3_ITCL => GetString("ITCL");

		/// <summary>
		/// Description: Business area
		/// FieldName: BUAR
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Business area")]
		public string M3_BUAR => GetString("BUAR");

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
		/// Description: Make/buy code
		/// FieldName: MABU
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Make/buy code")]
		public int? M3_MABU => GetNullableInt("MABU");

		/// <summary>
		/// Description: Procurement group
		/// FieldName: PRGP
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Procurement group")]
		public string M3_PRGP => GetString("PRGP");

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
		/// Description: Alternate U/M in use
		/// FieldName: ALUC
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Alternate U/M in use")]
		public int? M3_ALUC => GetNullableInt("ALUC");

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
		/// Description: Expiration date method
		/// FieldName: EXPD
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Expiration date method")]
		public int? M3_EXPD => GetNullableInt("EXPD");

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
		/// Description: Sales item
		/// FieldName: SALE
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Sales item")]
		public int? M3_SALE => GetNullableInt("SALE");

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
		/// Description: Purchase price
		/// FieldName: PUPR
		/// FieldType: N
		/// Length: 19
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Purchase price")]
		public decimal? M3_PUPR => GetNullableDecimal("PUPR");

		/// <summary>
		/// Description: Purchase price quantity
		/// FieldName: PUCD
		/// FieldType: N
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Purchase price quantity")]
		public int? M3_PUCD => GetNullableInt("PUCD");

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
		/// Description: Sales price
		/// FieldName: SAPR
		/// FieldType: N
		/// Length: 19
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Sales price")]
		public decimal? M3_SAPR => GetNullableDecimal("SAPR");

		/// <summary>
		/// Description: Sales price quantity
		/// FieldName: SACD
		/// FieldType: N
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Sales price quantity")]
		public int? M3_SACD => GetNullableInt("SACD");

		/// <summary>
		/// Description: Currency - sales price
		/// FieldName: CUCS
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Currency - sales price")]
		public string M3_CUCS => GetString("CUCS");

		/// <summary>
		/// Description: Warehouse table
		/// FieldName: WHTA
		/// FieldType: A
		/// Length: 4
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Warehouse table")]
		public string M3_WHTA => GetString("WHTA");

		/// <summary>
		/// Description: Discount group - item
		/// FieldName: DIGI
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Discount group - item")]
		public string M3_DIGI => GetString("DIGI");

		/// <summary>
		/// Description: Season control
		/// FieldName: SECH
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Season control")]
		public int? M3_SECH => GetNullableInt("SECH");

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
		/// Description: User-defined field
		/// FieldName: USD1
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("User-defined field")]
		public string M3_USD1 => GetString("USD1");

		/// <summary>
		/// Description: User-defined field
		/// FieldName: USD2
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("User-defined field")]
		public string M3_USD2 => GetString("USD2");

		/// <summary>
		/// Description: User-defined field
		/// FieldName: USD3
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("User-defined field")]
		public string M3_USD3 => GetString("USD3");

		/// <summary>
		/// Description: User-defined field
		/// FieldName: USD4
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("User-defined field")]
		public string M3_USD4 => GetString("USD4");

		/// <summary>
		/// Description: User-defined field
		/// FieldName: USD5
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("User-defined field")]
		public string M3_USD5 => GetString("USD5");

		/// <summary>
		/// Description: Configuration code
		/// FieldName: CHCD
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Configuration code")]
		public int? M3_CHCD => GetNullableInt("CHCD");

		/// <summary>
		/// Description: Fixed or dynamic sales price U/M
		/// FieldName: SPUC
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Fixed or dynamic sales price U/M")]
		public int? M3_SPUC => GetNullableInt("SPUC");

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
		/// Description: Change log exists
		/// FieldName: CHLG
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Change log exists")]
		public int? M3_CHLG => GetNullableInt("CHLG");

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
		/// Description: Specification 1
		/// FieldName: SPE1
		/// FieldType: A
		/// Length: 25
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Specification 1")]
		public string M3_SPE1 => GetString("SPE1");

		/// <summary>
		/// Description: Specification 2
		/// FieldName: SPE2
		/// FieldType: A
		/// Length: 25
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Specification 2")]
		public string M3_SPE2 => GetString("SPE2");

		/// <summary>
		/// Description: Specification 3
		/// FieldName: SPE3
		/// FieldType: A
		/// Length: 25
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Specification 3")]
		public string M3_SPE3 => GetString("SPE3");

		/// <summary>
		/// Description: Specification 4
		/// FieldName: SPE4
		/// FieldType: A
		/// Length: 25
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Specification 4")]
		public string M3_SPE4 => GetString("SPE4");

		/// <summary>
		/// Description: Specification 5
		/// FieldName: SPE5
		/// FieldType: A
		/// Length: 25
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Specification 5")]
		public string M3_SPE5 => GetString("SPE5");

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
		/// Description: Suppliers ABC code
		/// FieldName: SAFC
		/// FieldType: A
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Suppliers ABC code")]
		public string M3_SAFC => GetString("SAFC");

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
		/// Description: Attribute managed
		/// FieldName: ATMN
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Attribute managed")]
		public int? M3_ATMN => GetNullableInt("ATMN");

		/// <summary>
		/// Description: Attribute model
		/// FieldName: ATMO
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Attribute model")]
		public string M3_ATMO => GetString("ATMO");

		/// <summary>
		/// Description: Included in territorial roll-up
		/// FieldName: ITRU
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Included in territorial roll-up")]
		public int? M3_ITRU => GetNullableInt("ITRU");

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
		/// Description: Tank
		/// FieldName: TANK
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Tank")]
		public int? M3_TANK => GetNullableInt("TANK");

		/// <summary>
		/// Description: Specific gravity
		/// FieldName: SPGV
		/// FieldType: N
		/// Length: 11
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Specific gravity")]
		public decimal? M3_SPGV => GetNullableDecimal("SPGV");

		/// <summary>
		/// Description: Ruleset ID
		/// FieldName: RUID
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Ruleset ID")]
		public string M3_RUID => GetString("RUID");

		/// <summary>
		/// Description: Product line
		/// FieldName: PDLN
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Product line")]
		public string M3_PDLN => GetString("PDLN");

		/// <summary>
		/// Description: Composition group
		/// FieldName: CPGR
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Composition group")]
		public string M3_CPGR => GetString("CPGR");

		/// <summary>
		/// Description: Sublot method
		/// FieldName: SUME
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Sublot method")]
		public int? M3_SUME => GetNullableInt("SUME");

		/// <summary>
		/// Description: Location-based catch weight
		/// FieldName: CAWP
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Location-based catch weight")]
		public int? M3_CAWP => GetNullableInt("CAWP");

		/// <summary>
		/// Description: Sublot policy
		/// FieldName: SUMP
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Sublot policy")]
		public string M3_SUMP => GetString("SUMP");
	}
}
// EOF
