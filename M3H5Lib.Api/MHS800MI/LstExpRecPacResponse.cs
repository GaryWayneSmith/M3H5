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

namespace M3H5Lib.Api.MHS800MI
{
	public partial class LstExpRecPacResponse : M3BaseRecord 
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
		/// Description: Disconnected package
		/// FieldName: DIPA
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Disconnected package")]
		public int? M3_DIPA => GetNullableInt("DIPA");

		/// <summary>
		/// Description: Direction
		/// FieldName: INOU
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Direction")]
		public int? M3_INOU => GetNullableInt("INOU");

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
		/// Description: Supplier type
		/// FieldName: SUTY
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Supplier type")]
		public int? M3_SUTY => GetNullableInt("SUTY");

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
		/// Description: Delivery note date
		/// FieldName: DNDT
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Delivery note date")]
		public DateTime? M3_DNDT => GetNullableDateTime("DNDT");

		/// <summary>
		/// Description: Package number
		/// FieldName: PANR
		/// FieldType: A
		/// Length: 20
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Package number")]
		public string M3_PANR => GetString("PANR");

		/// <summary>
		/// Description: Package level
		/// FieldName: PACO
		/// FieldType: N
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Package level")]
		public int? M3_PACO => GetNullableInt("PACO");

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
		/// Description: Address number
		/// FieldName: ADID
		/// FieldType: A
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Address number")]
		public string M3_ADID => GetString("ADID");

		/// <summary>
		/// Description: Bulk package
		/// FieldName: PACU
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Bulk package")]
		public int? M3_PACU => GetNullableInt("PACU");

		/// <summary>
		/// Description: Included in package number
		/// FieldName: PAII
		/// FieldType: A
		/// Length: 20
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Included in package number")]
		public string M3_PAII => GetString("PAII");

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
		/// Description: Packaging code
		/// FieldName: GRTP
		/// FieldType: A
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Packaging code")]
		public string M3_GRTP => GetString("GRTP");

		/// <summary>
		/// Description: Packaging terms
		/// FieldName: TEPA
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Packaging terms")]
		public string M3_TEPA => GetString("TEPA");

		/// <summary>
		/// Description: Sort value
		/// FieldName: SORT
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Sort value")]
		public string M3_SORT => GetString("SORT");

		/// <summary>
		/// Description: Remark
		/// FieldName: DLRM
		/// FieldType: A
		/// Length: 40
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Remark")]
		public string M3_DLRM => GetString("DLRM");

		/// <summary>
		/// Description: Goods mark Odette standard
		/// FieldName: DLMO
		/// FieldType: A
		/// Length: 40
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Goods mark Odette standard")]
		public string M3_DLMO => GetString("DLMO");

		/// <summary>
		/// Description: Volume
		/// FieldName: VOL3
		/// FieldType: N
		/// Length: 9
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Volume")]
		public int? M3_VOL3 => GetNullableInt("VOL3");

		/// <summary>
		/// Description: Gross volume
		/// FieldName: VOGR
		/// FieldType: N
		/// Length: 9
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Gross volume")]
		public int? M3_VOGR => GetNullableInt("VOGR");

		/// <summary>
		/// Description: Net weight
		/// FieldName: NEWE
		/// FieldType: N
		/// Length: 9
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Net weight")]
		public int? M3_NEWE => GetNullableInt("NEWE");

		/// <summary>
		/// Description: Gross weight
		/// FieldName: GRWE
		/// FieldType: N
		/// Length: 9
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Gross weight")]
		public int? M3_GRWE => GetNullableInt("GRWE");

		/// <summary>
		/// Description: Capacity - free capacity
		/// FieldName: FRCP
		/// FieldType: N
		/// Length: 11
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Capacity - free capacity")]
		public decimal? M3_FRCP => GetNullableDecimal("FRCP");

		/// <summary>
		/// Description: Packaging weight
		/// FieldName: TARW
		/// FieldType: N
		/// Length: 9
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Packaging weight")]
		public int? M3_TARW => GetNullableInt("TARW");

		/// <summary>
		/// Description: Standard quantity
		/// FieldName: D1QT
		/// FieldType: N
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Standard quantity")]
		public decimal? M3_D1QT => GetNullableDecimal("D1QT");

		/// <summary>
		/// Description: Delivered quantity - basic unit
		/// FieldName: DLQT
		/// FieldType: N
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Delivered quantity - basic unit")]
		public decimal? M3_DLQT => GetNullableDecimal("DLQT");

		/// <summary>
		/// Description: Delivery specification
		/// FieldName: DLSP
		/// FieldType: A
		/// Length: 12
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Delivery specification")]
		public string M3_DLSP => GetString("DLSP");

		/// <summary>
		/// Description: Data identity
		/// FieldName: DTID
		/// FieldType: N
		/// Length: 13
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Data identity")]
		public decimal? M3_DTID => GetNullableDecimal("DTID");

		/// <summary>
		/// Description: SSCC number
		/// FieldName: SSCC
		/// FieldType: A
		/// Length: 18
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("SSCC number")]
		public string M3_SSCC => GetString("SSCC");

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
		/// Description: Owner
		/// FieldName: OWNC
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Owner")]
		public string M3_OWNC => GetString("OWNC");

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
		/// Description: New on-hand balance
		/// FieldName: NSTQ
		/// FieldType: N
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("New on-hand balance")]
		public decimal? M3_NSTQ => GetNullableDecimal("NSTQ");

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
		/// Description: Packaging quantity
		/// FieldName: PKQT
		/// FieldType: N
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Packaging quantity")]
		public decimal? M3_PKQT => GetNullableDecimal("PKQT");

		/// <summary>
		/// Description: Actual net weight
		/// FieldName: NTWM
		/// FieldType: N
		/// Length: 9
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Actual net weight")]
		public int? M3_NTWM => GetNullableInt("NTWM");

		/// <summary>
		/// Description: Actual gross weight
		/// FieldName: GWTM
		/// FieldType: N
		/// Length: 9
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Actual gross weight")]
		public int? M3_GWTM => GetNullableInt("GWTM");

		/// <summary>
		/// Description: Actual volume
		/// FieldName: VLMM
		/// FieldType: N
		/// Length: 9
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Actual volume")]
		public int? M3_VLMM => GetNullableInt("VLMM");

		/// <summary>
		/// Description: Actual quantity in free unit
		/// FieldName: FRCM
		/// FieldType: N
		/// Length: 11
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Actual quantity in free unit")]
		public decimal? M3_FRCM => GetNullableDecimal("FRCM");

		/// <summary>
		/// Description: Estimated net weight
		/// FieldName: NTWE
		/// FieldType: N
		/// Length: 9
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Estimated net weight")]
		public int? M3_NTWE => GetNullableInt("NTWE");

		/// <summary>
		/// Description: Estimated gross weight
		/// FieldName: GWTE
		/// FieldType: N
		/// Length: 9
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Estimated gross weight")]
		public int? M3_GWTE => GetNullableInt("GWTE");

		/// <summary>
		/// Description: Estimated volume
		/// FieldName: VLME
		/// FieldType: N
		/// Length: 9
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Estimated volume")]
		public int? M3_VLME => GetNullableInt("VLME");

		/// <summary>
		/// Description: Estimated free unit packed goods
		/// FieldName: FRCE
		/// FieldType: N
		/// Length: 11
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Estimated free unit packed goods")]
		public decimal? M3_FRCE => GetNullableDecimal("FRCE");

		/// <summary>
		/// Description: Included net weight
		/// FieldName: NTWI
		/// FieldType: N
		/// Length: 9
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Included net weight")]
		public int? M3_NTWI => GetNullableInt("NTWI");

		/// <summary>
		/// Description: Included gross weight
		/// FieldName: GWTI
		/// FieldType: N
		/// Length: 9
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Included gross weight")]
		public int? M3_GWTI => GetNullableInt("GWTI");

		/// <summary>
		/// Description: Included volume
		/// FieldName: VLMI
		/// FieldType: N
		/// Length: 9
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Included volume")]
		public int? M3_VLMI => GetNullableInt("VLMI");

		/// <summary>
		/// Description: Inclided entered number of free units
		/// FieldName: FRCI
		/// FieldType: N
		/// Length: 11
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Inclided entered number of free units")]
		public decimal? M3_FRCI => GetNullableDecimal("FRCI");

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
		/// Description: Highest status - purchase order
		/// FieldName: PUST
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Highest status - purchase order")]
		public string M3_PUST => GetString("PUST");

		/// <summary>
		/// Description: Packaging length
		/// FieldName: PACL
		/// FieldType: N
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Packaging length")]
		public int? M3_PACL => GetNullableInt("PACL");

		/// <summary>
		/// Description: Packaging width
		/// FieldName: PACW
		/// FieldType: N
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Packaging width")]
		public int? M3_PACW => GetNullableInt("PACW");

		/// <summary>
		/// Description: Packaging height
		/// FieldName: PACH
		/// FieldType: N
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Packaging height")]
		public int? M3_PACH => GetNullableInt("PACH");

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
		/// Description: Package content
		/// FieldName: PCON
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Package content")]
		public int? M3_PCON => GetNullableInt("PCON");

		/// <summary>
		/// Description: User-defined field 1
		/// FieldName: USD1
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("User-defined field 1")]
		public string M3_USD1 => GetString("USD1");

		/// <summary>
		/// Description: User-defined field 2
		/// FieldName: USD2
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("User-defined field 2")]
		public string M3_USD2 => GetString("USD2");

		/// <summary>
		/// Description: User-defined field 3
		/// FieldName: USD3
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("User-defined field 3")]
		public string M3_USD3 => GetString("USD3");

		/// <summary>
		/// Description: User-defined field 4
		/// FieldName: USD4
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("User-defined field 4")]
		public string M3_USD4 => GetString("USD4");

		/// <summary>
		/// Description: User-defined field 5
		/// FieldName: USD5
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("User-defined field 5")]
		public string M3_USD5 => GetString("USD5");

		/// <summary>
		/// Description: Process flag - download
		/// FieldName: DOWN
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Process flag - download")]
		public int? M3_DOWN => GetNullableInt("DOWN");

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
		/// Description: Delivery note number
		/// FieldName: SUDO
		/// FieldType: A
		/// Length: 20
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Delivery note number")]
		public string M3_SUDO => GetString("SUDO");

		/// <summary>
		/// Description: Number of packages
		/// FieldName: AMKO
		/// FieldType: N
		/// Length: 7
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Number of packages")]
		public int? M3_AMKO => GetNullableInt("AMKO");

		/// <summary>
		/// Description: Planned delivery date
		/// FieldName: DLDT
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Planned delivery date")]
		public DateTime? M3_DLDT => GetNullableDateTime("DLDT");

		/// <summary>
		/// Description: Package definition number
		/// FieldName: PPNB
		/// FieldType: A
		/// Length: 20
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Package definition number")]
		public string M3_PPNB => GetString("PPNB");
	}
}
// EOF
