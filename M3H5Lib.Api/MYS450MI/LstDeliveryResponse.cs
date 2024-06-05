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

namespace M3H5Lib.Api.MYS450MI
{
	public partial class LstDeliveryResponse : M3BaseRecord 
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
		/// Description: Partner
		/// FieldName: E0PA
		/// FieldType: A
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Partner")]
		public string M3E0PA => GetString("E0PA");

		/// <summary>
		/// Description: Message number
		/// FieldName: MSGN
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Message number")]
		public string M3MSGN => GetString("MSGN");

		/// <summary>
		/// Description: Direction
		/// FieldName: INOU
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Direction")]
		public int? M3INOU => GetNullableInt("INOU");

		/// <summary>
		/// Description: Delivery number
		/// FieldName: DLIX
		/// FieldType: N
		/// Length: 11
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Delivery number")]
		public decimal? M3DLIX => GetNullableDecimal("DLIX");

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
		/// Description: Dispatch policy
		/// FieldName: DPOL
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Dispatch policy")]
		public string M3DPOL => GetString("DPOL");

		/// <summary>
		/// Description: Consignee
		/// FieldName: CONA
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Consignee")]
		public string M3CONA => GetString("CONA");

		/// <summary>
		/// Description: Consignee address number
		/// FieldName: COAA
		/// FieldType: A
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Consignee address number")]
		public string M3COAA => GetString("COAA");

		/// <summary>
		/// Description: Consignor
		/// FieldName: CONB
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Consignor")]
		public string M3CONB => GetString("CONB");

		/// <summary>
		/// Description: Consignor address number
		/// FieldName: COBB
		/// FieldType: A
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Consignor address number")]
		public string M3COBB => GetString("COBB");

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
		/// Description: Requested route
		/// FieldName: SROT
		/// FieldType: A
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Requested route")]
		public string M3SROT => GetString("SROT");

		/// <summary>
		/// Description: Requested route departure
		/// FieldName: SROD
		/// FieldType: N
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Requested route departure")]
		public int? M3SROD => GetNullableInt("SROD");

		/// <summary>
		/// Description: Delivery method
		/// FieldName: MODL
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Delivery method")]
		public string M3MODL => GetString("MODL");

		/// <summary>
		/// Description: Delivery terms
		/// FieldName: TEDL
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Delivery terms")]
		public string M3TEDL => GetString("TEDL");

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
		/// Description: Transaction type
		/// FieldName: TTYP
		/// FieldType: N
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Transaction type")]
		public int? M3TTYP => GetNullableInt("TTYP");

		/// <summary>
		/// Description: Reference order number
		/// FieldName: RIDN
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Reference order number")]
		public string M3RIDN => GetString("RIDN");

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
		/// Description: Delivery note reference qualifier
		/// FieldName: PUTP
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Delivery note reference qualifier")]
		public int? M3PUTP => GetNullableInt("PUTP");

		/// <summary>
		/// Description: Delivery note reference
		/// FieldName: PUSN
		/// FieldType: A
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Delivery note reference")]
		public string M3PUSN => GetString("PUSN");

		/// <summary>
		/// Description: Packaging action
		/// FieldName: PCKA
		/// FieldType: A
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Packaging action")]
		public string M3PCKA => GetString("PCKA");

		/// <summary>
		/// Description: Net weight
		/// FieldName: NEWE
		/// FieldType: N
		/// Length: 9
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Net weight")]
		public int? M3NEWE => GetNullableInt("NEWE");

		/// <summary>
		/// Description: Gross weight
		/// FieldName: GRWE
		/// FieldType: N
		/// Length: 9
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Gross weight")]
		public int? M3GRWE => GetNullableInt("GRWE");

		/// <summary>
		/// Description: Volume
		/// FieldName: VOL3
		/// FieldType: N
		/// Length: 9
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Volume")]
		public int? M3VOL3 => GetNullableInt("VOL3");

		/// <summary>
		/// Description: Free capacity unit
		/// FieldName: FCU1
		/// FieldType: N
		/// Length: 11
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Free capacity unit")]
		public decimal? M3FCU1 => GetNullableDecimal("FCU1");

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
		/// Description: Requested forwarding agent
		/// FieldName: FWNS
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Requested forwarding agent")]
		public string M3FWNS => GetString("FWNS");

		/// <summary>
		/// Description: Place sequence number for unloading
		/// FieldName: MULS
		/// FieldType: N
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Place sequence number for unloading")]
		public int? M3MULS => GetNullableInt("MULS");

		/// <summary>
		/// Description: Unloading sequence within place
		/// FieldName: SULS
		/// FieldType: N
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Unloading sequence within place")]
		public int? M3SULS => GetNullableInt("SULS");

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
		/// Description: User defined field
		/// FieldName: USD1
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("User defined field")]
		public string M3USD1 => GetString("USD1");

		/// <summary>
		/// Description: User defined field
		/// FieldName: USD2
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("User defined field")]
		public string M3USD2 => GetString("USD2");

		/// <summary>
		/// Description: User defined field
		/// FieldName: USD3
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("User defined field")]
		public string M3USD3 => GetString("USD3");

		/// <summary>
		/// Description: User defined field
		/// FieldName: USD4
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("User defined field")]
		public string M3USD4 => GetString("USD4");

		/// <summary>
		/// Description: User defined field
		/// FieldName: USD5
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("User defined field")]
		public string M3USD5 => GetString("USD5");

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
	}
}
// EOF
