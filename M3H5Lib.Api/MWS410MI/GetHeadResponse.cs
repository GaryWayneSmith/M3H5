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

namespace M3H5Lib.Api.MWS410MI
{
	public partial class GetHeadResponse : M3BaseRecord 
	{

		/// <summary>
		/// Description: Delivery number
		/// FieldName: DLIX
		/// FieldType: N
		/// Length: 11
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Delivery number")]
		public decimal? M3_DLIX => GetNullableDecimal("DLIX");

		/// <summary>
		/// Description: Document number
		/// FieldName: DONR
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Document number")]
		public string M3_DONR => GetString("DONR");

		/// <summary>
		/// Description: Document variant
		/// FieldName: DOVA
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Document variant")]
		public string M3_DOVA => GetString("DOVA");

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
		/// Description: Delivery document number
		/// FieldName: FDNO
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Delivery document number")]
		public string M3_FDNO => GetString("FDNO");

		/// <summary>
		/// Description: Invoice number
		/// FieldName: IVNO
		/// FieldType: N
		/// Length: 9
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Invoice number")]
		public int? M3_IVNO => GetNullableInt("IVNO");

		/// <summary>
		/// Description: Invoice date
		/// FieldName: IVDT
		/// FieldType: D
		/// Length: 8
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Invoice date")]
		public DateTime? M3_IVDT => GetNullableDateTime("IVDT");

		/// <summary>
		/// Description: Document identity
		/// FieldName: DONO
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Document identity")]
		public string M3_DONO => GetString("DONO");

		/// <summary>
		/// Description: Date generated
		/// FieldName: GEDT
		/// FieldType: D
		/// Length: 8
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Date generated")]
		public DateTime? M3_GEDT => GetNullableDateTime("GEDT");

		/// <summary>
		/// Description: Electronic mail date
		/// FieldName: ELDT
		/// FieldType: D
		/// Length: 8
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Electronic mail date")]
		public DateTime? M3_ELDT => GetNullableDateTime("ELDT");

		/// <summary>
		/// Description: E-mail time
		/// FieldName: ELTM
		/// FieldType: A
		/// Length: 4
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("E-mail time")]
		public string M3_ELTM => GetString("ELTM");

		/// <summary>
		/// Description: Requested departure date
		/// FieldName: SHD4
		/// FieldType: D
		/// Length: 8
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Requested departure date")]
		public DateTime? M3_SHD4 => GetNullableDateTime("SHD4");

		/// <summary>
		/// Description: Requested departure time
		/// FieldName: SHTM
		/// FieldType: N
		/// Length: 4
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Requested departure time")]
		public int? M3_SHTM => GetNullableInt("SHTM");

		/// <summary>
		/// Description: Customers order number
		/// FieldName: CUOR
		/// FieldType: A
		/// Length: 20
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Customers order number")]
		public string M3_CUOR => GetString("CUOR");

		/// <summary>
		/// Description: Delivery note reference
		/// FieldName: PUSN
		/// FieldType: A
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Delivery note reference")]
		public string M3_PUSN => GetString("PUSN");

		/// <summary>
		/// Description: Delivery note reference qualifier
		/// FieldName: PUTP
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Delivery note reference qualifier")]
		public int? M3_PUTP => GetNullableInt("PUTP");

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
		/// Description: Trailer registration number
		/// FieldName: E0BH
		/// FieldType: A
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Trailer registration number")]
		public string M3_E0BH => GetString("E0BH");

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
		/// Description: Delivery via
		/// FieldName: E0BI
		/// FieldType: A
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Delivery via")]
		public string M3_E0BI => GetString("E0BI");

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
		/// Description: Our supplier number at customer
		/// FieldName: CUSU
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Our supplier number at customer")]
		public string M3_CUSU => GetString("CUSU");

		/// <summary>
		/// Description: VAT registration number
		/// FieldName: VRNO
		/// FieldType: A
		/// Length: 16
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("VAT registration number")]
		public string M3_VRNO => GetString("VRNO");

		/// <summary>
		/// Description: EU VAT registration number 2
		/// FieldName: VRN2
		/// FieldType: A
		/// Length: 16
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("EU VAT registration number 2")]
		public string M3_VRN2 => GetString("VRN2");

		/// <summary>
		/// Description: Your reference 1
		/// FieldName: YREF
		/// FieldType: A
		/// Length: 30
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Your reference 1")]
		public string M3_YREF => GetString("YREF");

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
		/// Description: Delivery terms
		/// FieldName: TEDL
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Delivery terms")]
		public string M3_TEDL => GetString("TEDL");

		/// <summary>
		/// Description: Number of packages
		/// FieldName: NRUL
		/// FieldType: N
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Number of packages")]
		public int? M3_NRUL => GetNullableInt("NRUL");

		/// <summary>
		/// Description: Gross weight definitive order
		/// FieldName: GRW2
		/// FieldType: N
		/// Length: 11
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Gross weight definitive order")]
		public decimal? M3_GRW2 => GetNullableDecimal("GRW2");

		/// <summary>
		/// Description: Net weight definitive order
		/// FieldName: NEW2
		/// FieldType: N
		/// Length: 11
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Net weight definitive order")]
		public decimal? M3_NEW2 => GetNullableDecimal("NEW2");

		/// <summary>
		/// Description: Packed volume
		/// FieldName: PAV3
		/// FieldType: N
		/// Length: 11
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Packed volume")]
		public decimal? M3_PAV3 => GetNullableDecimal("PAV3");

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
		/// Description: Place
		/// FieldName: EDES
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Place")]
		public string M3_EDES => GetString("EDES");

		/// <summary>
		/// Description: Harbor or airport
		/// FieldName: HAFE
		/// FieldType: A
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Harbor or airport")]
		public string M3_HAFE => GetString("HAFE");

		/// <summary>
		/// Description: Transaction date
		/// FieldName: TRDT
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Transaction date")]
		public DateTime? M3_TRDT => GetNullableDateTime("TRDT");

		/// <summary>
		/// Description: Transaction time
		/// FieldName: TRTM
		/// FieldType: N
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Transaction time")]
		public int? M3_TRTM => GetNullableInt("TRTM");

		/// <summary>
		/// Description: Blocked delivery number
		/// FieldName: BLOP
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Blocked delivery number")]
		public int? M3_BLOP => GetNullableInt("BLOP");

		/// <summary>
		/// Description: Released for allocation
		/// FieldName: RLFA
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Released for allocation")]
		public int? M3_RLFA => GetNullableInt("RLFA");

		/// <summary>
		/// Description: Released for picking
		/// FieldName: RLTD
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Released for picking")]
		public int? M3_RLTD => GetNullableInt("RLTD");

		/// <summary>
		/// Description: Delivery status
		/// FieldName: PGRS
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Delivery status")]
		public string M3_PGRS => GetString("PGRS");

		/// <summary>
		/// Description: Packing status
		/// FieldName: PIST
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Packing status")]
		public string M3_PIST => GetString("PIST");

		/// <summary>
		/// Description: Packaging action
		/// FieldName: PCKA
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Packaging action")]
		public int? M3_PCKA => GetNullableInt("PCKA");

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
		/// Description: Time zone
		/// FieldName: TIZO
		/// FieldType: A
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Time zone")]
		public string M3_TIZO => GetString("TIZO");

		/// <summary>
		/// Description: Via address
		/// FieldName: ADVI
		/// FieldType: A
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Via address")]
		public string M3_ADVI => GetString("ADVI");

		/// <summary>
		/// Description: Requested departure date
		/// FieldName: DTDT
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Requested departure date")]
		public DateTime? M3_DTDT => GetNullableDateTime("DTDT");

		/// <summary>
		/// Description: Requested departure time
		/// FieldName: DTHM
		/// FieldType: N
		/// Length: 4
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Requested departure time")]
		public int? M3_DTHM => GetNullableInt("DTHM");

		/// <summary>
		/// Description: Shipment assembly point
		/// FieldName: TSIN
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Shipment assembly point")]
		public int? M3_TSIN => GetNullableInt("TSIN");

		/// <summary>
		/// Description: Point to connect delivery documents
		/// FieldName: DOCR
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Point to connect delivery documents")]
		public int? M3_DOCR => GetNullableInt("DOCR");

		/// <summary>
		/// Description: Delivery documents created
		/// FieldName: DOCE
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Delivery documents created")]
		public int? M3_DOCE => GetNullableInt("DOCE");

		/// <summary>
		/// Description: Packing reporting
		/// FieldName: SHLV
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Packing reporting")]
		public int? M3_SHLV => GetNullableInt("SHLV");

		/// <summary>
		/// Description: Auto connect to shipment
		/// FieldName: AUCO
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Auto connect to shipment")]
		public int? M3_AUCO => GetNullableInt("AUCO");

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
		/// Description: Receipt time
		/// FieldName: RCTM
		/// FieldType: N
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Receipt time")]
		public int? M3_RCTM => GetNullableInt("RCTM");

		/// <summary>
		/// Description: Delivery day number
		/// FieldName: DEWD
		/// FieldType: A
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Delivery day number")]
		public string M3_DEWD => GetString("DEWD");

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
		/// Description: Customer group
		/// FieldName: CUCL
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Customer group")]
		public string M3_CUCL => GetString("CUCL");

		/// <summary>
		/// Description: Country
		/// FieldName: CSCD
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Country")]
		public string M3_CSCD => GetString("CSCD");

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
		/// Description: Postal code
		/// FieldName: PONO
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Postal code")]
		public string M3_PONO => GetString("PONO");

		/// <summary>
		/// Description: Unloading zone
		/// FieldName: ULZO
		/// FieldType: A
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Unloading zone")]
		public string M3_ULZO => GetString("ULZO");

		/// <summary>
		/// Description: Original delivery number
		/// FieldName: OLIX
		/// FieldType: N
		/// Length: 11
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Original delivery number")]
		public decimal? M3_OLIX => GetNullableDecimal("OLIX");

		/// <summary>
		/// Description: Place sequence number for unloading
		/// FieldName: MULS
		/// FieldType: N
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Place sequence number for unloading")]
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
		/// Description: Loading platform
		/// FieldName: LODO
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Loading platform")]
		public string M3_LODO => GetString("LODO");

		/// <summary>
		/// Description: External tracking number
		/// FieldName: ETRN
		/// FieldType: A
		/// Length: 30
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("External tracking number")]
		public string M3_ETRN => GetString("ETRN");

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
		/// Description: Consignor pallet registration number
		/// FieldName: PALS
		/// FieldType: A
		/// Length: 12
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Consignor pallet registration number")]
		public string M3_PALS => GetString("PALS");

		/// <summary>
		/// Description: Pallet registration number
		/// FieldName: PALR
		/// FieldType: A
		/// Length: 12
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Pallet registration number")]
		public string M3_PALR => GetString("PALR");

		/// <summary>
		/// Description: Consignor GAN number
		/// FieldName: GANS
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Consignor GAN number")]
		public string M3_GANS => GetString("GANS");

		/// <summary>
		/// Description: Consignee GAN number
		/// FieldName: GANR
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Consignee GAN number")]
		public string M3_GANR => GetString("GANR");

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
		/// Description: Final delivery terms
		/// FieldName: TEDF
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Final delivery terms")]
		public string M3_TEDF => GetString("TEDF");

		/// <summary>
		/// Description: Bill of Lading number
		/// FieldName: NBOL
		/// FieldType: A
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Bill of Lading number")]
		public string M3_NBOL => GetString("NBOL");

		/// <summary>
		/// Description: Master Bill of Lading number
		/// FieldName: MBOL
		/// FieldType: A
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Master Bill of Lading number")]
		public string M3_MBOL => GetString("MBOL");

		/// <summary>
		/// Description: Freigth doc alias ID
		/// FieldName: FDAL
		/// FieldType: A
		/// Length: 30
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Freigth doc alias ID")]
		public string M3_FDAL => GetString("FDAL");

		/// <summary>
		/// Description: Invoice Prefix
		/// FieldName: INPX
		/// FieldType: A
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Invoice Prefix")]
		public string M3_INPX => GetString("INPX");

		/// <summary>
		/// Description: Extended Invoice Number
		/// FieldName: EXIN
		/// FieldType: A
		/// Length: 14
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Extended Invoice Number")]
		public string M3_EXIN => GetString("EXIN");

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
		/// Description: Loading platform
		/// FieldName: NLOD
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Loading platform")]
		public string M3_NLOD => GetString("NLOD");

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
		/// Description: County ID
		/// FieldName: FRCO
		/// FieldType: A
		/// Length: 7
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("County ID")]
		public string M3_FRCO => GetString("FRCO");

		/// <summary>
		/// Description: Standard point location code
		/// FieldName: SPLE
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Standard point location code")]
		public string M3_SPLE => GetString("SPLE");

		/// <summary>
		/// Description: Rail station
		/// FieldName: RASN
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Rail station")]
		public string M3_RASN => GetString("RASN");

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
		/// Description: Forwarder's actual arrival time
		/// FieldName: AWHM
		/// FieldType: N
		/// Length: 4
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Forwarder's actual arrival time")]
		public int? M3_AWHM => GetNullableInt("AWHM");

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
		/// Description: Delivery consolidation - field 1
		/// FieldName: DCF1
		/// FieldType: A
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Delivery consolidation - field 1")]
		public string M3_DCF1 => GetString("DCF1");

		/// <summary>
		/// Description: Delivery consolidation - field 2
		/// FieldName: DCF2
		/// FieldType: A
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Delivery consolidation - field 2")]
		public string M3_DCF2 => GetString("DCF2");

		/// <summary>
		/// Description: Delivery consolidation - field 1 content
		/// FieldName: DCC1
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Delivery consolidation - field 1 content")]
		public string M3_DCC1 => GetString("DCC1");

		/// <summary>
		/// Description: Delivery consolidation - field 2 content
		/// FieldName: DCC2
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Delivery consolidation - field 2 content")]
		public string M3_DCC2 => GetString("DCC2");

		/// <summary>
		/// Description: Delivery value check point
		/// FieldName: DVCP
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Delivery value check point")]
		public int? M3_DVCP => GetNullableInt("DVCP");

		/// <summary>
		/// Description: Issue reporting status
		/// FieldName: IRPS
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Issue reporting status")]
		public string M3_IRPS => GetString("IRPS");

		/// <summary>
		/// Description: Delivery value check amount
		/// FieldName: DVCA
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Delivery value check amount")]
		public decimal? M3_DVCA => GetNullableDecimal("DVCA");

		/// <summary>
		/// Description: Delivery value variance
		/// FieldName: DVDA
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Delivery value variance")]
		public decimal? M3_DVDA => GetNullableDecimal("DVDA");

		/// <summary>
		/// Description: Currency of payer used in delivery value
		/// FieldName: DVCU
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Currency of payer used in delivery value")]
		public string M3_DVCU => GetString("DVCU");

		/// <summary>
		/// Description: Delivery stop code
		/// FieldName: DSTC
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Delivery stop code")]
		public string M3_DSTC => GetString("DSTC");

		/// <summary>
		/// Description: Transportation delivery stop
		/// FieldName: TIIC
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Transportation delivery stop")]
		public int? M3_TIIC => GetNullableInt("TIIC");
	}
}
// EOF
