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

namespace M3H5Lib.Api.MWS420MI
{
	public partial class LstPickersPLResponse : M3BaseRecord 
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
		/// Description: Picking status
		/// FieldName: PISS
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Picking status")]
		public string M3_PISS => GetString("PISS");

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
		/// Description: Picking time
		/// FieldName: PLTM
		/// FieldType: N
		/// Length: 7
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Picking time")]
		public int? M3_PLTM => GetNullableInt("PLTM");

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
		/// Description: Estimated pick start date
		/// FieldName: ESPD
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Estimated pick start date")]
		public DateTime? M3_ESPD => GetNullableDateTime("ESPD");

		/// <summary>
		/// Description: Estimated pick start time
		/// FieldName: ESPT
		/// FieldType: N
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Estimated pick start time")]
		public int? M3_ESPT => GetNullableInt("ESPT");

		/// <summary>
		/// Description: Picking team
		/// FieldName: TEAM
		/// FieldType: A
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Picking team")]
		public string M3_TEAM => GetString("TEAM");

		/// <summary>
		/// Description: Picker
		/// FieldName: PICK
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Picker")]
		public string M3_PICK => GetString("PICK");

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
		/// Description: Workflow picker
		/// FieldName: WPIC
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Workflow picker")]
		public string M3_WPIC => GetString("WPIC");

		/// <summary>
		/// Description: Actual print date
		/// FieldName: ARLD
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Actual print date")]
		public DateTime? M3_ARLD => GetNullableDateTime("ARLD");

		/// <summary>
		/// Description: Actual print time
		/// FieldName: ARLT
		/// FieldType: N
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Actual print time")]
		public int? M3_ARLT => GetNullableInt("ARLT");

		/// <summary>
		/// Description: Picking start date
		/// FieldName: ARLE
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Picking start date")]
		public DateTime? M3_ARLE => GetNullableDateTime("ARLE");

		/// <summary>
		/// Description: Picking start time
		/// FieldName: ARLF
		/// FieldType: N
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Picking start time")]
		public int? M3_ARLF => GetNullableInt("ARLF");

		/// <summary>
		/// Description: Original number of picking list lines
		/// FieldName: NPLL
		/// FieldType: N
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Original number of picking list lines")]
		public int? M3_NPLL => GetNullableInt("NPLL");

		/// <summary>
		/// Description: Number of reported picking lines
		/// FieldName: NPLR
		/// FieldType: N
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Number of reported picking lines")]
		public int? M3_NPLR => GetNullableInt("NPLR");

		/// <summary>
		/// Description: Number of picked picking lines
		/// FieldName: NPLP
		/// FieldType: N
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Number of picked picking lines")]
		public int? M3_NPLP => GetNullableInt("NPLP");

		/// <summary>
		/// Description: Closing date
		/// FieldName: CLOD
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Closing date")]
		public DateTime? M3_CLOD => GetNullableDateTime("CLOD");

		/// <summary>
		/// Description: Closing time
		/// FieldName: CLOT
		/// FieldType: N
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Closing time")]
		public int? M3_CLOT => GetNullableInt("CLOT");

		/// <summary>
		/// Description: Printer
		/// FieldName: DEVI
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Printer")]
		public string M3_DEVI => GetString("DEVI");

		/// <summary>
		/// Description: Wave printer
		/// FieldName: DEVW
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Wave printer")]
		public string M3_DEVW => GetString("DEVW");

		/// <summary>
		/// Description: To warehouse
		/// FieldName: TWLO
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("To warehouse")]
		public string M3_TWLO => GetString("TWLO");

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
		/// Description: Route description
		/// FieldName: RODS
		/// FieldType: A
		/// Length: 40
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Route description")]
		public string M3_RODS => GetString("RODS");

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
		/// Description: Lines to pick
		/// FieldName: LPIC
		/// FieldType: N
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Lines to pick")]
		public int? M3_LPIC => GetNullableInt("LPIC");

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
		/// Description: Lines to pack
		/// FieldName: LPAC
		/// FieldType: N
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Lines to pack")]
		public int? M3_LPAC => GetNullableInt("LPAC");

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
	}
}
// EOF
