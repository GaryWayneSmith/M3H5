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

namespace M3H5Lib.Api.MWSLWMMI
{
	public partial class LstMOMatResponse : M3BaseRecord 
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
		/// Description: Facility
		/// FieldName: FACI
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Facility")]
		public string M3FACI => GetString("FACI");

		/// <summary>
		/// Description: Product number
		/// FieldName: PRNO
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Product number")]
		public string M3PRNO => GetString("PRNO");

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
		/// Description: Manufacturing order number
		/// FieldName: MFNO
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Manufacturing order number")]
		public string M3MFNO => GetString("MFNO");

		/// <summary>
		/// Description: Sequence number
		/// FieldName: MSEQ
		/// FieldType: N
		/// Length: 4
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Sequence number")]
		public int? M3MSEQ => GetNullableInt("MSEQ");

		/// <summary>
		/// Description: Operation number
		/// FieldName: OPNO
		/// FieldType: N
		/// Length: 4
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Operation number")]
		public int? M3OPNO => GetNullableInt("OPNO");

		/// <summary>
		/// Description: Drawing position
		/// FieldName: DWPO
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Drawing position")]
		public string M3DWPO => GetString("DWPO");

		/// <summary>
		/// Description: Priority
		/// FieldName: PRIO
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Priority")]
		public int? M3PRIO => GetNullableInt("PRIO");

		/// <summary>
		/// Description: Material status
		/// FieldName: WMST
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Material status")]
		public string M3WMST => GetString("WMST");

		/// <summary>
		/// Description: Subcontract control
		/// FieldName: STGS
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Subcontract control")]
		public int? M3STGS => GetNullableInt("STGS");

		/// <summary>
		/// Description: Component number
		/// FieldName: MTNO
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Component number")]
		public string M3MTNO => GetString("MTNO");

		/// <summary>
		/// Description: Name
		/// FieldName: ITDM
		/// FieldType: A
		/// Length: 30
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Name")]
		public string M3ITDM => GetString("ITDM");

		/// <summary>
		/// Description: Reporting number
		/// FieldName: WOSQ
		/// FieldType: N
		/// Length: 12
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Reporting number")]
		public decimal? M3WOSQ => GetNullableDecimal("WOSQ");

		/// <summary>
		/// Description: Text
		/// FieldName: FMT1
		/// FieldType: A
		/// Length: 30
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Text")]
		public string M3FMT1 => GetString("FMT1");

		/// <summary>
		/// Description: Technical reference
		/// FieldName: FMT2
		/// FieldType: A
		/// Length: 30
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Technical reference")]
		public string M3FMT2 => GetString("FMT2");

		/// <summary>
		/// Description: Quantity
		/// FieldName: CNQT
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Quantity")]
		public decimal? M3CNQT => GetNullableDecimal("CNQT");

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
		/// Description: Quantity relation
		/// FieldName: FXCD
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Quantity relation")]
		public int? M3FXCD => GetNullableInt("FXCD");

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
		/// Description: Inheritance control
		/// FieldName: CMCD
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Inheritance control")]
		public int? M3CMCD => GetNullableInt("CMCD");

		/// <summary>
		/// Description: Product engineering U/M
		/// FieldName: PEUN
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Product engineering U/M")]
		public string M3PEUN => GetString("PEUN");

		/// <summary>
		/// Description: Length
		/// FieldName: LGTH
		/// FieldType: N
		/// Length: 7
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Length")]
		public int? M3LGTH => GetNullableInt("LGTH");

		/// <summary>
		/// Description: Width
		/// FieldName: WDTH
		/// FieldType: N
		/// Length: 7
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Width")]
		public int? M3WDTH => GetNullableInt("WDTH");

		/// <summary>
		/// Description: Factor 1
		/// FieldName: LWF1
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Factor 1")]
		public decimal? M3LWF1 => GetNullableDecimal("LWF1");

		/// <summary>
		/// Description: Factor 2
		/// FieldName: LWF2
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Factor 2")]
		public decimal? M3LWF2 => GetNullableDecimal("LWF2");

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
		/// Description: Cumulative scrap percentage
		/// FieldName: ASPC
		/// FieldType: N
		/// Length: 7
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Cumulative scrap percentage")]
		public int? M3ASPC => GetNullableInt("ASPC");

		/// <summary>
		/// Description: Reservation date
		/// FieldName: RDAT
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Reservation date")]
		public DateTime? M3RDAT => GetNullableDateTime("RDAT");

		/// <summary>
		/// Description: Time hours & minutes
		/// FieldName: TIHM
		/// FieldType: N
		/// Length: 4
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Time hours & minutes")]
		public int? M3TIHM => GetNullableInt("TIHM");

		/// <summary>
		/// Description: Lead time offset
		/// FieldName: MDBF
		/// FieldType: N
		/// Length: 7
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Lead time offset")]
		public int? M3MDBF => GetNullableInt("MDBF");

		/// <summary>
		/// Description: MO reservations
		/// FieldName: MARC
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("MO reservations")]
		public int? M3MARC => GetNullableInt("MARC");

		/// <summary>
		/// Description: Reserved quantity
		/// FieldName: REQT
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Reserved quantity")]
		public decimal? M3REQT => GetNullableDecimal("REQT");

		/// <summary>
		/// Description: Reserved quantity in alternative unit
		/// FieldName: REQA
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Reserved quantity in alternative unit")]
		public decimal? M3REQA => GetNullableDecimal("REQA");

		/// <summary>
		/// Description: Compensation quantity
		/// FieldName: RCQA
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Compensation quantity")]
		public decimal? M3RCQA => GetNullableDecimal("RCQA");

		/// <summary>
		/// Description: Received quantity
		/// FieldName: RVQT
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Received quantity")]
		public decimal? M3RVQT => GetNullableDecimal("RVQT");

		/// <summary>
		/// Description: Received quantity
		/// FieldName: RVQA
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Received quantity")]
		public decimal? M3RVQA => GetNullableDecimal("RVQA");

		/// <summary>
		/// Description: Approved quantity - alternate U/M
		/// FieldName: CAQA
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Approved quantity - alternate U/M")]
		public decimal? M3CAQA => GetNullableDecimal("CAQA");

		/// <summary>
		/// Description: Reported quantity
		/// FieldName: RPQT
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Reported quantity")]
		public decimal? M3RPQT => GetNullableDecimal("RPQT");

		/// <summary>
		/// Description: Reported quantity in alternative unit
		/// FieldName: RPQA
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Reported quantity in alternative unit")]
		public decimal? M3RPQA => GetNullableDecimal("RPQA");

		/// <summary>
		/// Description: Responsible for reporting
		/// FieldName: RPRE
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Responsible for reporting")]
		public string M3RPRE => GetString("RPRE");

		/// <summary>
		/// Description: Manual completion flag
		/// FieldName: REND
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Manual completion flag")]
		public int? M3REND => GetNullableInt("REND");

		/// <summary>
		/// Description: Reporting date
		/// FieldName: RPDT
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Reporting date")]
		public DateTime? M3RPDT => GetNullableDateTime("RPDT");

		/// <summary>
		/// Description: Allocated quantity - basic U/M
		/// FieldName: ALQT
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Allocated quantity - basic U/M")]
		public decimal? M3ALQT => GetNullableDecimal("ALQT");

		/// <summary>
		/// Description: Allocated quantity - alternate U/M
		/// FieldName: ALQA
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Allocated quantity - alternate U/M")]
		public decimal? M3ALQA => GetNullableDecimal("ALQA");

		/// <summary>
		/// Description: Picking list quantity - basic U/M
		/// FieldName: PLQT
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Picking list quantity - basic U/M")]
		public decimal? M3PLQT => GetNullableDecimal("PLQT");

		/// <summary>
		/// Description: Picking list quantity - alternate U/M
		/// FieldName: PLQA
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Picking list quantity - alternate U/M")]
		public decimal? M3PLQA => GetNullableDecimal("PLQA");

		/// <summary>
		/// Description: Conversion factor
		/// FieldName: COFA
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Conversion factor")]
		public decimal? M3COFA => GetNullableDecimal("COFA");

		/// <summary>
		/// Description: Conversion form
		/// FieldName: DMCF
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Conversion form")]
		public int? M3DMCF => GetNullableInt("DMCF");

		/// <summary>
		/// Description: Order documents printed
		/// FieldName: WODP
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Order documents printed")]
		public int? M3WODP => GetNullableInt("WODP");

		/// <summary>
		/// Description: Component price
		/// FieldName: MPRC
		/// FieldType: N
		/// Length: 19
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Component price")]
		public decimal? M3MPRC => GetNullableDecimal("MPRC");

		/// <summary>
		/// Description: Warehouse
		/// FieldName: WHLO
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Warehouse")]
		public string M3WHLO => GetString("WHLO");

		/// <summary>
		/// Description: Location
		/// FieldName: WHSL
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Location")]
		public string M3WHSL => GetString("WHSL");

		/// <summary>
		/// Description: Lot number
		/// FieldName: BANO
		/// FieldType: A
		/// Length: 20
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Lot number")]
		public string M3BANO => GetString("BANO");

		/// <summary>
		/// Description: Picking list round
		/// FieldName: PLPR
		/// FieldType: N
		/// Length: 7
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Picking list round")]
		public int? M3PLPR => GetNullableInt("PLPR");

		/// <summary>
		/// Description: Work center
		/// FieldName: PLGR
		/// FieldType: A
		/// Length: 8
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Work center")]
		public string M3PLGR => GetString("PLGR");

		/// <summary>
		/// Description: Production days
		/// FieldName: PRDY
		/// FieldType: N
		/// Length: 7
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Production days")]
		public int? M3PRDY => GetNullableInt("PRDY");

		/// <summary>
		/// Description: Cumulative setup scrap
		/// FieldName: ASWQ
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Cumulative setup scrap")]
		public decimal? M3ASWQ => GetNullableDecimal("ASWQ");

		/// <summary>
		/// Description: Allocation method
		/// FieldName: ALMT
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Allocation method")]
		public int? M3ALMT => GetNullableInt("ALMT");

		/// <summary>
		/// Description: Issue method
		/// FieldName: SPMT
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Issue method")]
		public int? M3SPMT => GetNullableInt("SPMT");

		/// <summary>
		/// Description: Structure sequence number
		/// FieldName: STSQ
		/// FieldType: N
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Structure sequence number")]
		public long? M3STSQ => GetNullableLong("STSQ");

		/// <summary>
		/// Description: Order dependent
		/// FieldName: ORDP
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Order dependent")]
		public int? M3ORDP => GetNullableInt("ORDP");

		/// <summary>
		/// Description: Reference order category
		/// FieldName: RORC
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Reference order category")]
		public int? M3RORC => GetNullableInt("RORC");

		/// <summary>
		/// Description: Reference order number
		/// FieldName: RORN
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Reference order number")]
		public string M3RORN => GetString("RORN");

		/// <summary>
		/// Description: Reference order line
		/// FieldName: RORL
		/// FieldType: N
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Reference order line")]
		public int? M3RORL => GetNullableInt("RORL");

		/// <summary>
		/// Description: Overriding allocation method
		/// FieldName: NOAA
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Overriding allocation method")]
		public int? M3NOAA => GetNullableInt("NOAA");

		/// <summary>
		/// Description: Task element number
		/// FieldName: ACTS
		/// FieldType: N
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Task element number")]
		public int? M3ACTS => GetNullableInt("ACTS");

		/// <summary>
		/// Description: Schedule number
		/// FieldName: SCHN
		/// FieldType: N
		/// Length: 11
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Schedule number")]
		public decimal? M3SCHN => GetNullableDecimal("SCHN");

		/// <summary>
		/// Description: Scrapped quantity
		/// FieldName: SCQT
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Scrapped quantity")]
		public decimal? M3SCQT => GetNullableDecimal("SCQT");

		/// <summary>
		/// Description: Scrap quantity alternative unit
		/// FieldName: SCQA
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Scrap quantity alternative unit")]
		public decimal? M3SCQA => GetNullableDecimal("SCQA");

		/// <summary>
		/// Description: Hold MO
		/// FieldName: MOHD
		/// FieldType: A
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Hold MO")]
		public string M3MOHD => GetString("MOHD");

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
		/// Description: Main material line
		/// FieldName: MALN
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Main material line")]
		public int? M3MALN => GetNullableInt("MALN");

		/// <summary>
		/// Description: Entry date
		/// FieldName: RGDT
		/// FieldType: D
		/// Length: 10
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
		/// Length: 10
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

		/// <summary>
		/// Description: Critical material
		/// FieldName: CRTM
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Critical material")]
		public int? M3CRTM => GetNullableInt("CRTM");

		/// <summary>
		/// Description: Shipping buffer in production days
		/// FieldName: SHBP
		/// FieldType: N
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Shipping buffer in production days")]
		public int? M3SHBP => GetNullableInt("SHBP");

		/// <summary>
		/// Description: Line suffix
		/// FieldName: RORX
		/// FieldType: N
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Line suffix")]
		public int? M3RORX => GetNullableInt("RORX");

		/// <summary>
		/// Description: Timestamp
		/// FieldName: LMTS
		/// FieldType: N
		/// Length: 18
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Timestamp")]
		public decimal? M3LMTS => GetNullableDecimal("LMTS");

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
		/// Description: Operation description
		/// FieldName: OPDS
		/// FieldType: A
		/// Length: 30
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Operation description")]
		public string M3OPDS => GetString("OPDS");

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
		/// Description: Container management
		/// FieldName: COMG
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Container management")]
		public int? M3COMG => GetNullableInt("COMG");

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
		/// Description: Shelf life
		/// FieldName: SLDY
		/// FieldType: N
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Shelf life")]
		public int? M3SLDY => GetNullableInt("SLDY");
	}
}
// EOF
