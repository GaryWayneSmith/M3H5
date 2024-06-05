/// **********************************************************************
/// This class is auto-generated.
/// Updated: 6/5/2024 3:52:20 PM
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

namespace M3H5Lib.Api.DRS100MI
{
	public partial class LstShipmentResponse : M3BaseRecord 
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
		/// Description: Division
		/// FieldName: DIVI
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Division")]
		public string M3DIVI => GetString("DIVI");

		/// <summary>
		/// Description: Shipment
		/// FieldName: CONN
		/// FieldType: N
		/// Length: 7
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Shipment")]
		public int? M3CONN => GetNullableInt("CONN");

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
		/// Description: Route type
		/// FieldName: RUTP
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Route type")]
		public int? M3RUTP => GetNullableInt("RUTP");

		/// <summary>
		/// Description: Route
		/// FieldName: ROUT
		/// FieldType: A
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Route")]
		public string M3ROUT => GetString("ROUT");

		/// <summary>
		/// Description: Route departure
		/// FieldName: RODN
		/// FieldType: N
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Route departure")]
		public int? M3RODN => GetNullableInt("RODN");

		/// <summary>
		/// Description: Loading platform
		/// FieldName: LODO
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Loading platform")]
		public string M3LODO => GetString("LODO");

		/// <summary>
		/// Description: Main delivery method
		/// FieldName: MMDL
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Main delivery method")]
		public string M3MMDL => GetString("MMDL");

		/// <summary>
		/// Description: Planned route departure date
		/// FieldName: RDDT
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Planned route departure date")]
		public DateTime? M3RDDT => GetNullableDateTime("RDDT");

		/// <summary>
		/// Description: Planned route departure time
		/// FieldName: RDTM
		/// FieldType: N
		/// Length: 4
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Planned route departure time")]
		public int? M3RDTM => GetNullableInt("RDTM");

		/// <summary>
		/// Description: Departure date
		/// FieldName: DSDT
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Departure date")]
		public DateTime? M3DSDT => GetNullableDateTime("DSDT");

		/// <summary>
		/// Description: Departure time
		/// FieldName: DSHM
		/// FieldType: N
		/// Length: 4
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Departure time")]
		public int? M3DSHM => GetNullableInt("DSHM");

		/// <summary>
		/// Description: Arrival date
		/// FieldName: ARDT
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Arrival date")]
		public DateTime? M3ARDT => GetNullableDateTime("ARDT");

		/// <summary>
		/// Description: Arrival time
		/// FieldName: ARHM
		/// FieldType: N
		/// Length: 4
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Arrival time")]
		public int? M3ARHM => GetNullableInt("ARHM");

		/// <summary>
		/// Description: Deadline date
		/// FieldName: CDLD
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Deadline date")]
		public DateTime? M3CDLD => GetNullableDateTime("CDLD");

		/// <summary>
		/// Description: Chr. delivery note nbr creation time
		/// FieldName: CDHM
		/// FieldType: N
		/// Length: 4
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Chr. delivery note nbr creation time")]
		public int? M3CDHM => GetNullableInt("CDHM");

		/// <summary>
		/// Description: Ignore deadline when connecting dely no
		/// FieldName: DLAC
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Ignore deadline when connecting dely no")]
		public int? M3DLAC => GetNullableInt("DLAC");

		/// <summary>
		/// Description: Highest status - shipment
		/// FieldName: CSTH
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Highest status - shipment")]
		public string M3CSTH => GetString("CSTH");

		/// <summary>
		/// Description: Lowest status - shipment
		/// FieldName: CSTL
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Lowest status - shipment")]
		public string M3CSTL => GetString("CSTL");

		/// <summary>
		/// Description: Highest document status
		/// FieldName: DSTH
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Highest document status")]
		public string M3DSTH => GetString("DSTH");

		/// <summary>
		/// Description: Lowest document status
		/// FieldName: DSTL
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Lowest document status")]
		public string M3DSTL => GetString("DSTL");

		/// <summary>
		/// Description: Forwarding agent
		/// FieldName: FWNO
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Forwarding agent")]
		public string M3FWNO => GetString("FWNO");

		/// <summary>
		/// Description: Transportation equipment
		/// FieldName: TRCA
		/// FieldType: A
		/// Length: 8
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Transportation equipment")]
		public string M3TRCA => GetString("TRCA");

		/// <summary>
		/// Description: Place of loading
		/// FieldName: SDES
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Place of loading")]
		public string M3SDES => GetString("SDES");

		/// <summary>
		/// Description: Place
		/// FieldName: EDES
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Place")]
		public string M3EDES => GetString("EDES");

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
		/// Description: Estimated volume of assigned goods
		/// FieldName: VOL3
		/// FieldType: N
		/// Length: 11
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Estimated volume of assigned goods")]
		public decimal? M3VOL3 => GetNullableDecimal("VOL3");

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
		/// Description: Estimated gross weight packed goods
		/// FieldName: GWTE
		/// FieldType: N
		/// Length: 11
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Estimated gross weight packed goods")]
		public decimal? M3GWTE => GetNullableDecimal("GWTE");

		/// <summary>
		/// Description: Estimated volume
		/// FieldName: VLME
		/// FieldType: N
		/// Length: 11
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Estimated volume")]
		public decimal? M3VLME => GetNullableDecimal("VLME");

		/// <summary>
		/// Description: Estimated free unit packed goods
		/// FieldName: FRCE
		/// FieldType: N
		/// Length: 13
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Estimated free unit packed goods")]
		public decimal? M3FRCE => GetNullableDecimal("FRCE");

		/// <summary>
		/// Description: Packed gross weight
		/// FieldName: GRW2
		/// FieldType: N
		/// Length: 11
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Packed gross weight")]
		public decimal? M3GRW2 => GetNullableDecimal("GRW2");

		/// <summary>
		/// Description: Packed volume
		/// FieldName: WM32
		/// FieldType: N
		/// Length: 11
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Packed volume")]
		public decimal? M3WM32 => GetNullableDecimal("WM32");

		/// <summary>
		/// Description: Packed  - free capacity
		/// FieldName: PFCP
		/// FieldType: N
		/// Length: 13
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Packed  - free capacity")]
		public decimal? M3PFCP => GetNullableDecimal("PFCP");

		/// <summary>
		/// Description: Shipment capacity - gross weight
		/// FieldName: GRW3
		/// FieldType: N
		/// Length: 11
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Shipment capacity - gross weight")]
		public decimal? M3GRW3 => GetNullableDecimal("GRW3");

		/// <summary>
		/// Description: Capacitu - volume
		/// FieldName: VM33
		/// FieldType: N
		/// Length: 11
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Capacitu - volume")]
		public decimal? M3VM33 => GetNullableDecimal("VM33");

		/// <summary>
		/// Description: Capacity - free capacity unit
		/// FieldName: FRCP
		/// FieldType: N
		/// Length: 13
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Capacity - free capacity unit")]
		public decimal? M3FRCP => GetNullableDecimal("FRCP");

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
		/// Description: Auto attach of several deliveries
		/// FieldName: AUTO
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Auto attach of several deliveries")]
		public int? M3AUTO => GetNullableInt("AUTO");

		/// <summary>
		/// Description: Manual connection only
		/// FieldName: MANC
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Manual connection only")]
		public int? M3MANC => GetNullableInt("MANC");

		/// <summary>
		/// Description: Shipment closed
		/// FieldName: CLOS
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Shipment closed")]
		public int? M3CLOS => GetNullableInt("CLOS");

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
		/// Description: Invoicing status
		/// FieldName: IVSS
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Invoicing status")]
		public int? M3IVSS => GetNullableInt("IVSS");

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
		/// Description: Shipment ready for loading
		/// FieldName: SILO
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Shipment ready for loading")]
		public int? M3SILO => GetNullableInt("SILO");

		/// <summary>
		/// Description: Number of loaded pick lines
		/// FieldName: NBLL
		/// FieldType: N
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Number of loaded pick lines")]
		public int? M3NBLL => GetNullableInt("NBLL");

		/// <summary>
		/// Description: Number of pick lines
		/// FieldName: NBPL
		/// FieldType: N
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Number of pick lines")]
		public int? M3NBPL => GetNullableInt("NBPL");

		/// <summary>
		/// Description: Number of loaded packages
		/// FieldName: NBLP
		/// FieldType: N
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Number of loaded packages")]
		public int? M3NBLP => GetNullableInt("NBLP");

		/// <summary>
		/// Description: Number of packages
		/// FieldName: NBRP
		/// FieldType: N
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Number of packages")]
		public int? M3NBRP => GetNullableInt("NBRP");

		/// <summary>
		/// Description: Agreement number
		/// FieldName: AGNB
		/// FieldType: A
		/// Length: 7
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Agreement number")]
		public string M3AGNB => GetString("AGNB");

		/// <summary>
		/// Description: Transportation service ID
		/// FieldName: TSID
		/// FieldType: A
		/// Length: 4
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Transportation service ID")]
		public string M3TSID => GetString("TSID");

		/// <summary>
		/// Description: Detention reason code
		/// FieldName: DRCD
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Detention reason code")]
		public string M3DRCD => GetString("DRCD");

		/// <summary>
		/// Description: Actual detention date
		/// FieldName: DFDT
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Actual detention date")]
		public DateTime? M3DFDT => GetNullableDateTime("DFDT");

		/// <summary>
		/// Description: Actual detention time
		/// FieldName: DFHM
		/// FieldType: N
		/// Length: 4
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Actual detention time")]
		public int? M3DFHM => GetNullableInt("DFHM");

		/// <summary>
		/// Description: Forwarders planned arrival date
		/// FieldName: PWDT
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Forwarders planned arrival date")]
		public DateTime? M3PWDT => GetNullableDateTime("PWDT");

		/// <summary>
		/// Description: Forwarders planned arrival time
		/// FieldName: PWHM
		/// FieldType: N
		/// Length: 4
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Forwarders planned arrival time")]
		public int? M3PWHM => GetNullableInt("PWHM");

		/// <summary>
		/// Description: Forwarders actual arrival date
		/// FieldName: AWDT
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Forwarders actual arrival date")]
		public DateTime? M3AWDT => GetNullableDateTime("AWDT");

		/// <summary>
		/// Description: Forwarders actual arrival time
		/// FieldName: AWHM
		/// FieldType: N
		/// Length: 4
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Forwarders actual arrival time")]
		public int? M3AWHM => GetNullableInt("AWHM");

		/// <summary>
		/// Description: Detention time - days
		/// FieldName: DETD
		/// FieldType: N
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Detention time - days")]
		public int? M3DETD => GetNullableInt("DETD");

		/// <summary>
		/// Description: Detention time - hours
		/// FieldName: DEHT
		/// FieldType: N
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Detention time - hours")]
		public int? M3DEHT => GetNullableInt("DEHT");

		/// <summary>
		/// Description: Detention time - minutes
		/// FieldName: DEMT
		/// FieldType: N
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Detention time - minutes")]
		public int? M3DEMT => GetNullableInt("DEMT");

		/// <summary>
		/// Description: Number of stopped deliveries
		/// FieldName: NBDS
		/// FieldType: N
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Number of stopped deliveries")]
		public int? M3NBDS => GetNullableInt("NBDS");

		/// <summary>
		/// Description: Transport interface indicator ID
		/// FieldName: TRFI
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Transport interface indicator ID")]
		public string M3TRFI => GetString("TRFI");
	}
}
// EOF
