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

namespace M3H5Lib.Api.PPS310MI
{
	public partial class LstBalIDQIResponse : M3BaseRecord 
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
		/// Description: Warehouse description
		/// FieldName: WHNM
		/// FieldType: A
		/// Length: 30
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Warehouse description")]
		public string M3_WHNM => GetString("WHNM");

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
		/// Description: Last receipt date
		/// FieldName: IDDT
		/// FieldType: D
		/// Length: 8
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Last receipt date")]
		public DateTime? M3_IDDT => GetNullableDateTime("IDDT");

		/// <summary>
		/// Description: Last issue date
		/// FieldName: ODDT
		/// FieldType: D
		/// Length: 8
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Last issue date")]
		public DateTime? M3_ODDT => GetNullableDateTime("ODDT");

		/// <summary>
		/// Description: Latest physical inventory date
		/// FieldName: INDT
		/// FieldType: D
		/// Length: 8
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Latest physical inventory date")]
		public DateTime? M3_INDT => GetNullableDateTime("INDT");

		/// <summary>
		/// Description: Physical inventory in progress
		/// FieldName: INON
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Physical inventory in progress")]
		public int? M3_INON => GetNullableInt("INON");

		/// <summary>
		/// Description: Status - balance ID
		/// FieldName: STAS
		/// FieldType: A
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Status - balance ID")]
		public string M3_STAS => GetString("STAS");

		/// <summary>
		/// Description: Reclassification date
		/// FieldName: RCLS
		/// FieldType: N
		/// Length: 8
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Reclassification date")]
		public int? M3_RCLS => GetNullableInt("RCLS");

		/// <summary>
		/// Description: Priority date
		/// FieldName: PRDT
		/// FieldType: D
		/// Length: 8
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Priority date")]
		public DateTime? M3_PRDT => GetNullableDateTime("PRDT");

		/// <summary>
		/// Description: On-hand balance approved
		/// FieldName: STQT
		/// FieldType: A
		/// Length: 11
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("On-hand balance approved")]
		public string M3_STQT => GetString("STQT");

		/// <summary>
		/// Description: On-hand balance
		/// FieldName: PHSQ
		/// FieldType: A
		/// Length: 11
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("On-hand balance")]
		public string M3_PHSQ => GetString("PHSQ");

		/// <summary>
		/// Description: Allocatable
		/// FieldName: ALOC
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Allocatable")]
		public int? M3_ALOC => GetNullableInt("ALOC");

		/// <summary>
		/// Description: Allocated quantity - basic U/M
		/// FieldName: ALQT
		/// FieldType: A
		/// Length: 11
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Allocated quantity - basic U/M")]
		public string M3_ALQT => GetString("ALQT");

		/// <summary>
		/// Description: Allocated quantity
		/// FieldName: PHAQ
		/// FieldType: A
		/// Length: 11
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Allocated quantity")]
		public string M3_PHAQ => GetString("PHAQ");

		/// <summary>
		/// Description: Automatic deletion
		/// FieldName: AUDE
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Automatic deletion")]
		public int? M3_AUDE => GetNullableInt("AUDE");

		/// <summary>
		/// Description: Automatic deletion delay
		/// FieldName: AUDD
		/// FieldType: N
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Automatic deletion delay")]
		public int? M3_AUDD => GetNullableInt("AUDD");

		/// <summary>
		/// Description: Active physical inventory lines
		/// FieldName: STAQ
		/// FieldType: A
		/// Length: 11
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Active physical inventory lines")]
		public string M3_STAQ => GetString("STAQ");

		/// <summary>
		/// Description: Active physical
		/// FieldName: PHA2
		/// FieldType: A
		/// Length: 11
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Active physical")]
		public string M3_PHA2 => GetString("PHA2");

		/// <summary>
		/// Description: Normal potency
		/// FieldName: POCY
		/// FieldType: N
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Normal potency")]
		public int? M3_POCY => GetNullableInt("POCY");

		/// <summary>
		/// Description: Catch weight
		/// FieldName: CAWE
		/// FieldType: A
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Catch weight")]
		public string M3_CAWE => GetString("CAWE");

		/// <summary>
		/// Description: Potency
		/// FieldName: LPCY
		/// FieldType: N
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Potency")]
		public int? M3_LPCY => GetNullableInt("LPCY");

		/// <summary>
		/// Description: Purchase price U/M
		/// FieldName: PPUN
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Purchase price U/M")]
		public string M3_PPUN => GetString("PPUN");

		/// <summary>
		/// Description: Lot reference 1
		/// FieldName: BREF
		/// FieldType: A
		/// Length: 20
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Lot reference 1")]
		public string M3_BREF => GetString("BREF");

		/// <summary>
		/// Description: Packaging
		/// FieldName: PACT
		/// FieldType: A
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Packaging")]
		public string M3_PACT => GetString("PACT");

		/// <summary>
		/// Description: Lot reference 2
		/// FieldName: BRE2
		/// FieldType: A
		/// Length: 20
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Lot reference 2")]
		public string M3_BRE2 => GetString("BRE2");

		/// <summary>
		/// Description: Remark
		/// FieldName: BREM
		/// FieldType: A
		/// Length: 20
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Remark")]
		public string M3_BREM => GetString("BREM");

		/// <summary>
		/// Description: Reorder point
		/// FieldName: REOP
		/// FieldType: A
		/// Length: 11
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Reorder point")]
		public string M3_REOP => GetString("REOP");

		/// <summary>
		/// Description: Attribute number
		/// FieldName: ATNR
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Attribute number")]
		public decimal? M3_ATNR => GetNullableDecimal("ATNR");

		/// <summary>
		/// Description: Attribute number lot
		/// FieldName: ATNB
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Attribute number lot")]
		public decimal? M3_ATNB => GetNullableDecimal("ATNB");

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
		/// Description: Catch weight
		/// FieldName: CAW2
		/// FieldType: A
		/// Length: 11
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Catch weight")]
		public string M3_CAW2 => GetString("CAW2");

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
		/// Description: Purchase order line
		/// FieldName: PNLI
		/// FieldType: N
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Purchase order line")]
		public int? M3_PNLI => GetNullableInt("PNLI");

		/// <summary>
		/// Description: Purchase order line subnumber
		/// FieldName: PNLS
		/// FieldType: N
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Purchase order line subnumber")]
		public int? M3_PNLS => GetNullableInt("PNLS");

		/// <summary>
		/// Description: Lowest status - purchase order
		/// FieldName: PUSL
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Lowest status - purchase order")]
		public string M3_PUSL => GetString("PUSL");

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
		/// Description: Receiving number
		/// FieldName: REP2
		/// FieldType: N
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Receiving number")]
		public long? M3_REP2 => GetNullableLong("REP2");

		/// <summary>
		/// Description: Warehouse
		/// FieldName: WHL2
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Warehouse")]
		public string M3_WHL2 => GetString("WHL2");

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
		/// Description: Requested delivery date
		/// FieldName: DWDT
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Requested delivery date")]
		public DateTime? M3_DWDT => GetNullableDateTime("DWDT");

		/// <summary>
		/// Description: Supplier
		/// FieldName: SUNO
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Supplier")]
		public string M3_SUNO => GetString("SUNO");

		/// <summary>
		/// Description: Supplier name
		/// FieldName: SUNM
		/// FieldType: A
		/// Length: 36
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Supplier name")]
		public string M3_SUNM => GetString("SUNM");

		/// <summary>
		/// Description: Item number
		/// FieldName: ITN2
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Item number")]
		public string M3_ITN2 => GetString("ITN2");

		/// <summary>
		/// Description: Name
		/// FieldName: ITD2
		/// FieldType: A
		/// Length: 30
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Name")]
		public string M3_ITD2 => GetString("ITD2");

		/// <summary>
		/// Description: Service process
		/// FieldName: PRCS
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Service process")]
		public string M3_PRCS => GetString("PRCS");

		/// <summary>
		/// Description: Service
		/// FieldName: SUFI
		/// FieldType: A
		/// Length: 20
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Service")]
		public string M3_SUFI => GetString("SUFI");

		/// <summary>
		/// Description: Purchase order item name
		/// FieldName: PITD
		/// FieldType: A
		/// Length: 30
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Purchase order item name")]
		public string M3_PITD => GetString("PITD");

		/// <summary>
		/// Description: Supplier item number
		/// FieldName: SITE
		/// FieldType: A
		/// Length: 30
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Supplier item number")]
		public string M3_SITE => GetString("SITE");

		/// <summary>
		/// Description: Purchase order item description
		/// FieldName: PITT
		/// FieldType: A
		/// Length: 60
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Purchase order item description")]
		public string M3_PITT => GetString("PITT");

		/// <summary>
		/// Description: Received quantity
		/// FieldName: RVQA
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Received quantity")]
		public decimal? M3_RVQA => GetNullableDecimal("RVQA");

		/// <summary>
		/// Description: Purchase order U/M
		/// FieldName: PUUN
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Purchase order U/M")]
		public string M3_PUUN => GetString("PUUN");

		/// <summary>
		/// Description: Receipt date
		/// FieldName: RCDT
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Receipt date")]
		public DateTime? M3_RCDT => GetNullableDateTime("RCDT");

		/// <summary>
		/// Description: Quality inspection result
		/// FieldName: QCRA
		/// FieldType: A
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Quality inspection result")]
		public string M3_QCRA => GetString("QCRA");

		/// <summary>
		/// Description: Approved quantity
		/// FieldName: AQTY
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Approved quantity")]
		public decimal? M3_AQTY => GetNullableDecimal("AQTY");

		/// <summary>
		/// Description: Approved location
		/// FieldName: AWHS
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Approved location")]
		public string M3_AWHS => GetString("AWHS");

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
		/// Description: Approved remark
		/// FieldName: AREM
		/// FieldType: A
		/// Length: 20
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Approved remark")]
		public string M3_AREM => GetString("AREM");

		/// <summary>
		/// Description: Approved lot number
		/// FieldName: ABAN
		/// FieldType: A
		/// Length: 20
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Approved lot number")]
		public string M3_ABAN => GetString("ABAN");

		/// <summary>
		/// Description: Approved lot reference 1
		/// FieldName: ABRF
		/// FieldType: A
		/// Length: 20
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Approved lot reference 1")]
		public string M3_ABRF => GetString("ABRF");

		/// <summary>
		/// Description: Approved lot reference 2
		/// FieldName: ABR2
		/// FieldType: A
		/// Length: 20
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Approved lot reference 2")]
		public string M3_ABR2 => GetString("ABR2");

		/// <summary>
		/// Description: Container
		/// FieldName: CAM2
		/// FieldType: A
		/// Length: 20
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Container")]
		public string M3_CAM2 => GetString("CAM2");

		/// <summary>
		/// Description: Follow-up date
		/// FieldName: CNDT
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Follow-up date")]
		public DateTime? M3_CNDT => GetNullableDateTime("CNDT");

		/// <summary>
		/// Description: Sales date
		/// FieldName: SEDT
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Sales date")]
		public DateTime? M3_SEDT => GetNullableDateTime("SEDT");

		/// <summary>
		/// Description: Number of packages
		/// FieldName: NOPK
		/// FieldType: N
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Number of packages")]
		public int? M3_NOPK => GetNullableInt("NOPK");

		/// <summary>
		/// Description: Rejection reason
		/// FieldName: SCRE
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Rejection reason")]
		public string M3_SCRE => GetString("SCRE");

		/// <summary>
		/// Description: Rejected quantity
		/// FieldName: RJQA
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Rejected quantity")]
		public decimal? M3_RJQA => GetNullableDecimal("RJQA");

		/// <summary>
		/// Description: Reject location
		/// FieldName: RWHS
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Reject location")]
		public string M3_RWHS => GetString("RWHS");

		/// <summary>
		/// Description: Reject lot number
		/// FieldName: RBAN
		/// FieldType: A
		/// Length: 20
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Reject lot number")]
		public string M3_RBAN => GetString("RBAN");

		/// <summary>
		/// Description: Reject remark
		/// FieldName: RREM
		/// FieldType: A
		/// Length: 20
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Reject remark")]
		public string M3_RREM => GetString("RREM");

		/// <summary>
		/// Description: Service not performed
		/// FieldName: WPRF
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Service not performed")]
		public int? M3_WPRF => GetNullableInt("WPRF");

		/// <summary>
		/// Description: Service date
		/// FieldName: SVDT
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Service date")]
		public DateTime? M3_SVDT => GetNullableDateTime("SVDT");
	}
}
// EOF
