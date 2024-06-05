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

namespace M3H5Lib.Api.DRS100MI
{
	public partial class GetShipmentResponse : M3BaseRecord 
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
		/// Description: Division
		/// FieldName: DIVI
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Division")]
		public string M3_DIVI => GetString("DIVI");

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
		/// Description: Route type
		/// FieldName: RUTP
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Route type")]
		public int? M3_RUTP => GetNullableInt("RUTP");

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
		/// Description: Main delivery method
		/// FieldName: MMDL
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Main delivery method")]
		public string M3_MMDL => GetString("MMDL");

		/// <summary>
		/// Description: Name
		/// FieldName: MNAM
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Name")]
		public string M3_MNAM => GetString("MNAM");

		/// <summary>
		/// Description: Planned route departure date
		/// FieldName: RDDT
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Planned route departure date")]
		public DateTime? M3_RDDT => GetNullableDateTime("RDDT");

		/// <summary>
		/// Description: Planned route departure time
		/// FieldName: RDTM
		/// FieldType: N
		/// Length: 4
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Planned route departure time")]
		public int? M3_RDTM => GetNullableInt("RDTM");

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
		/// Description: Arrival date
		/// FieldName: ARDT
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Arrival date")]
		public DateTime? M3_ARDT => GetNullableDateTime("ARDT");

		/// <summary>
		/// Description: Arrival time
		/// FieldName: ARHM
		/// FieldType: N
		/// Length: 4
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Arrival time")]
		public int? M3_ARHM => GetNullableInt("ARHM");

		/// <summary>
		/// Description: Deadline date
		/// FieldName: CDLD
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Deadline date")]
		public DateTime? M3_CDLD => GetNullableDateTime("CDLD");

		/// <summary>
		/// Description: Chr. delivery note nbr creation time
		/// FieldName: CDHM
		/// FieldType: N
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Chr. delivery note nbr creation time")]
		public int? M3_CDHM => GetNullableInt("CDHM");

		/// <summary>
		/// Description: Ignore deadline when connecting dely no
		/// FieldName: DLAC
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Ignore deadline when connecting dely no")]
		public int? M3_DLAC => GetNullableInt("DLAC");

		/// <summary>
		/// Description: Highest status - shipment
		/// FieldName: CSTH
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Highest status - shipment")]
		public string M3_CSTH => GetString("CSTH");

		/// <summary>
		/// Description: Lowest status - shipment
		/// FieldName: CSTL
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Lowest status - shipment")]
		public string M3_CSTL => GetString("CSTL");

		/// <summary>
		/// Description: Highest document status
		/// FieldName: DSTH
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Highest document status")]
		public string M3_DSTH => GetString("DSTH");

		/// <summary>
		/// Description: Lowest document status
		/// FieldName: DSTL
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Lowest document status")]
		public string M3_DSTL => GetString("DSTL");

		/// <summary>
		/// Description: Forwarding agent
		/// FieldName: FWNO
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Forwarding agent")]
		public string M3_FWNO => GetString("FWNO");

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
		/// Description: Transportation equipment
		/// FieldName: TRCA
		/// FieldType: A
		/// Length: 8
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Transportation equipment")]
		public string M3_TRCA => GetString("TRCA");

		/// <summary>
		/// Description: Place of loading
		/// FieldName: SDES
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Place of loading")]
		public string M3_SDES => GetString("SDES");

		/// <summary>
		/// Description: Name
		/// FieldName: ENAM
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Name")]
		public string M3_ENAM => GetString("ENAM");

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
		/// Description: Estimated volume of assigned goods
		/// FieldName: VOL3
		/// FieldType: N
		/// Length: 11
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Estimated volume of assigned goods")]
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
		/// Description: Estimated gross weight packed goods
		/// FieldName: GWTE
		/// FieldType: N
		/// Length: 11
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Estimated gross weight packed goods")]
		public decimal? M3_GWTE => GetNullableDecimal("GWTE");

		/// <summary>
		/// Description: Estimated volume
		/// FieldName: VLME
		/// FieldType: N
		/// Length: 11
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Estimated volume")]
		public decimal? M3_VLME => GetNullableDecimal("VLME");

		/// <summary>
		/// Description: Estimated free unit packed goods
		/// FieldName: FRCE
		/// FieldType: N
		/// Length: 13
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Estimated free unit packed goods")]
		public decimal? M3_FRCE => GetNullableDecimal("FRCE");

		/// <summary>
		/// Description: Packed gross weight
		/// FieldName: GRW2
		/// FieldType: N
		/// Length: 11
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Packed gross weight")]
		public decimal? M3_GRW2 => GetNullableDecimal("GRW2");

		/// <summary>
		/// Description: Packed volume
		/// FieldName: WM32
		/// FieldType: N
		/// Length: 11
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Packed volume")]
		public decimal? M3_WM32 => GetNullableDecimal("WM32");

		/// <summary>
		/// Description: Packed  - free capacity
		/// FieldName: PFCP
		/// FieldType: N
		/// Length: 13
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Packed  - free capacity")]
		public decimal? M3_PFCP => GetNullableDecimal("PFCP");

		/// <summary>
		/// Description: Shipment capacity - gross weight
		/// FieldName: GRW3
		/// FieldType: N
		/// Length: 11
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Shipment capacity - gross weight")]
		public decimal? M3_GRW3 => GetNullableDecimal("GRW3");

		/// <summary>
		/// Description: Capacitu - volume
		/// FieldName: VM33
		/// FieldType: N
		/// Length: 11
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Capacitu - volume")]
		public decimal? M3_VM33 => GetNullableDecimal("VM33");

		/// <summary>
		/// Description: Capacity - free capacity unit
		/// FieldName: FRCP
		/// FieldType: N
		/// Length: 13
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Capacity - free capacity unit")]
		public decimal? M3_FRCP => GetNullableDecimal("FRCP");

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
		/// Description: Auto attach of several deliveries
		/// FieldName: AUTO
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Auto attach of several deliveries")]
		public int? M3_AUTO => GetNullableInt("AUTO");

		/// <summary>
		/// Description: Manual connection only
		/// FieldName: MANC
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Manual connection only")]
		public int? M3_MANC => GetNullableInt("MANC");

		/// <summary>
		/// Description: Shipment closed
		/// FieldName: CLOS
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Shipment closed")]
		public int? M3_CLOS => GetNullableInt("CLOS");

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
		/// Description: Invoicing status
		/// FieldName: IVSS
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Invoicing status")]
		public int? M3_IVSS => GetNullableInt("IVSS");

		/// <summary>
		/// Description: Shipment ready for loading
		/// FieldName: SILO
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Shipment ready for loading")]
		public int? M3_SILO => GetNullableInt("SILO");

		/// <summary>
		/// Description: Number of loaded pick lines
		/// FieldName: NBLL
		/// FieldType: N
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Number of loaded pick lines")]
		public int? M3_NBLL => GetNullableInt("NBLL");

		/// <summary>
		/// Description: Number of pick lines
		/// FieldName: NBPL
		/// FieldType: N
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Number of pick lines")]
		public int? M3_NBPL => GetNullableInt("NBPL");

		/// <summary>
		/// Description: Number of loaded packages
		/// FieldName: NBLP
		/// FieldType: N
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Number of loaded packages")]
		public int? M3_NBLP => GetNullableInt("NBLP");

		/// <summary>
		/// Description: Number of packages
		/// FieldName: NBRP
		/// FieldType: N
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Number of packages")]
		public int? M3_NBRP => GetNullableInt("NBRP");

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
		/// Description: Agreement number
		/// FieldName: AGNB
		/// FieldType: A
		/// Length: 7
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Agreement number")]
		public string M3_AGNB => GetString("AGNB");

		/// <summary>
		/// Description: Transportation service ID
		/// FieldName: TSID
		/// FieldType: A
		/// Length: 4
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Transportation service ID")]
		public string M3_TSID => GetString("TSID");

		/// <summary>
		/// Description: Detention reason code
		/// FieldName: DRCD
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Detention reason code")]
		public string M3_DRCD => GetString("DRCD");

		/// <summary>
		/// Description: Actual detention date
		/// FieldName: DFDT
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Actual detention date")]
		public DateTime? M3_DFDT => GetNullableDateTime("DFDT");

		/// <summary>
		/// Description: Actual detention time
		/// FieldName: DFHM
		/// FieldType: N
		/// Length: 4
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Actual detention time")]
		public int? M3_DFHM => GetNullableInt("DFHM");

		/// <summary>
		/// Description: Forwarders planned arrival date
		/// FieldName: PWDT
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Forwarders planned arrival date")]
		public DateTime? M3_PWDT => GetNullableDateTime("PWDT");

		/// <summary>
		/// Description: Forwarders planned arrival time
		/// FieldName: PWHM
		/// FieldType: N
		/// Length: 4
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Forwarders planned arrival time")]
		public int? M3_PWHM => GetNullableInt("PWHM");

		/// <summary>
		/// Description: Forwarders actual arrival date
		/// FieldName: AWDT
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Forwarders actual arrival date")]
		public DateTime? M3_AWDT => GetNullableDateTime("AWDT");

		/// <summary>
		/// Description: Forwarders actual arrival time
		/// FieldName: AWHM
		/// FieldType: N
		/// Length: 4
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Forwarders actual arrival time")]
		public int? M3_AWHM => GetNullableInt("AWHM");

		/// <summary>
		/// Description: Detention time - days
		/// FieldName: DETD
		/// FieldType: N
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Detention time - days")]
		public int? M3_DETD => GetNullableInt("DETD");

		/// <summary>
		/// Description: Detention time - hours
		/// FieldName: DEHT
		/// FieldType: N
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Detention time - hours")]
		public int? M3_DEHT => GetNullableInt("DEHT");

		/// <summary>
		/// Description: Detention time - minutes
		/// FieldName: DEMT
		/// FieldType: N
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Detention time - minutes")]
		public int? M3_DEMT => GetNullableInt("DEMT");

		/// <summary>
		/// Description: Seal number
		/// FieldName: SEAL
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Seal number")]
		public string M3_SEAL => GetString("SEAL");

		/// <summary>
		/// Description: number of stopped deliveries
		/// FieldName: NBDS
		/// FieldType: N
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("number of stopped deliveries")]
		public int? M3_NBDS => GetNullableInt("NBDS");

		/// <summary>
		/// Description: transportation interface indicator ID
		/// FieldName: TRFI
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("transportation interface indicator ID")]
		public string M3_TRFI => GetString("TRFI");

		/// <summary>
		/// Description: Transport identity - departure
		/// FieldName: E0B4
		/// FieldType: A
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Transport identity - departure")]
		public string M3_E0B4 => GetString("E0B4");

		/// <summary>
		/// Description: Timestamp
		/// FieldName: LMTS
		/// FieldType: N
		/// Length: 18
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Timestamp")]
		public decimal? M3_LMTS => GetNullableDecimal("LMTS");
	}
}
// EOF
