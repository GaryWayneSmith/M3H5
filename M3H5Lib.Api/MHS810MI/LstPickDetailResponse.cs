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

namespace M3H5Lib.Api.MHS810MI
{
	public partial class LstPickDetailResponse : M3BaseRecord 
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
		/// Description: Container
		/// FieldName: CAMU
		/// FieldType: A
		/// Length: 20
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Container")]
		public string M3CAMU => GetString("CAMU");

		/// <summary>
		/// Description: Receiving number
		/// FieldName: REPN
		/// FieldType: N
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Receiving number")]
		public long? M3REPN => GetNullableLong("REPN");

		/// <summary>
		/// Description: Stock transaction type
		/// FieldName: TTYP
		/// FieldType: N
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Stock transaction type")]
		public int? M3TTYP => GetNullableInt("TTYP");

		/// <summary>
		/// Description: Order number
		/// FieldName: RIDN
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Order number")]
		public string M3RIDN => GetString("RIDN");

		/// <summary>
		/// Description: Order line
		/// FieldName: RIDL
		/// FieldType: N
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Order line")]
		public int? M3RIDL => GetNullableInt("RIDL");

		/// <summary>
		/// Description: Line suffix
		/// FieldName: RIDX
		/// FieldType: N
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Line suffix")]
		public int? M3RIDX => GetNullableInt("RIDX");

		/// <summary>
		/// Description: Order operation
		/// FieldName: RIDO
		/// FieldType: N
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Order operation")]
		public int? M3RIDO => GetNullableInt("RIDO");

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
		/// Description: Picking list suffix
		/// FieldName: PLSX
		/// FieldType: N
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Picking list suffix")]
		public int? M3PLSX => GetNullableInt("PLSX");

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
		/// Description: Stock zone
		/// FieldName: SLTP
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Stock zone")]
		public string M3SLTP => GetString("SLTP");

		/// <summary>
		/// Description: Warehouse equipment
		/// FieldName: PISE
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Warehouse equipment")]
		public string M3PISE => GetString("PISE");

		/// <summary>
		/// Description: Allocation origin
		/// FieldName: MAAL
		/// FieldType: A
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Allocation origin")]
		public string M3MAAL => GetString("MAAL");

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
		/// Description: Sort value
		/// FieldName: SORT
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Sort value")]
		public string M3SORT => GetString("SORT");

		/// <summary>
		/// Description: Transportation flow
		/// FieldName: TRFL
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Transportation flow")]
		public string M3TRFL => GetString("TRFL");

		/// <summary>
		/// Description: Reference text
		/// FieldName: RFTX
		/// FieldType: A
		/// Length: 40
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Reference text")]
		public string M3RFTX => GetString("RFTX");

		/// <summary>
		/// Description: Program name
		/// FieldName: PGNM
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Program name")]
		public string M3PGNM => GetString("PGNM");

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
		/// Description: Packed quantity                 amount
		/// FieldName: PAQT
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Packed quantity                 amount")]
		public decimal? M3PAQT => GetNullableDecimal("PAQT");

		/// <summary>
		/// Description: Catch weight
		/// FieldName: CAWE
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Catch weight")]
		public decimal? M3CAWE => GetNullableDecimal("CAWE");

		/// <summary>
		/// Description: From picking location
		/// FieldName: FLOC
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("From picking location")]
		public string M3FLOC => GetString("FLOC");

		/// <summary>
		/// Description: Printer
		/// FieldName: DEV
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Printer")]
		public string M3DEV => GetString("DEV");

		/// <summary>
		/// Description: Alias number
		/// FieldName: POPN
		/// FieldType: A
		/// Length: 30
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Alias number")]
		public string M3POPN => GetString("POPN");

		/// <summary>
		/// Description: Alias category
		/// FieldName: ALWT
		/// FieldType: N
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Alias category")]
		public int? M3ALWT => GetNullableInt("ALWT");

		/// <summary>
		/// Description: Alias qualifier
		/// FieldName: ALWQ
		/// FieldType: A
		/// Length: 4
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Alias qualifier")]
		public string M3ALWQ => GetString("ALWQ");

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
		/// Description: Packaging terms
		/// FieldName: TEPA
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Packaging terms")]
		public string M3TEPA => GetString("TEPA");

		/// <summary>
		/// Description: Terms text
		/// FieldName: TEL5
		/// FieldType: A
		/// Length: 36
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Terms text")]
		public string M3TEL5 => GetString("TEL5");

		/// <summary>
		/// Description: Terms text
		/// FieldName: TEL6
		/// FieldType: A
		/// Length: 36
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Terms text")]
		public string M3TEL6 => GetString("TEL6");

		/// <summary>
		/// Description: Packaging
		/// FieldName: PACT
		/// FieldType: A
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Packaging")]
		public string M3PACT => GetString("PACT");

		/// <summary>
		/// Description: Name of packaging type
		/// FieldName: PANM
		/// FieldType: A
		/// Length: 30
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Name of packaging type")]
		public string M3PANM => GetString("PANM");

		/// <summary>
		/// Description: Packaging type
		/// FieldName: PACK
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Packaging type")]
		public string M3PACK => GetString("PACK");

		/// <summary>
		/// Description: Transaction reason
		/// FieldName: RSCD
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Transaction reason")]
		public string M3RSCD => GetString("RSCD");

		/// <summary>
		/// Description: Name
		/// FieldName: TX15
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Name")]
		public string M3TX15 => GetString("TX15");

		/// <summary>
		/// Description: Joint delivery
		/// FieldName: JDCD
		/// FieldType: A
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Joint delivery")]
		public string M3JDCD => GetString("JDCD");

		/// <summary>
		/// Description: Style number
		/// FieldName: STYN
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Style number")]
		public string M3STYN => GetString("STYN");

		/// <summary>
		/// Description: Standard seasonal influence
		/// FieldName: SEAS
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Standard seasonal influence")]
		public int? M3SEAS => GetNullableInt("SEAS");

		/// <summary>
		/// Description: Wave number
		/// FieldName: PLRI
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Wave number")]
		public string M3PLRI => GetString("PLRI");

		/// <summary>
		/// Description: Detailed order requirement (DOR)
		/// FieldName: CNNR
		/// FieldType: N
		/// Length: 11
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Detailed order requirement (DOR)")]
		public decimal? M3CNNR => GetNullableDecimal("CNNR");

		/// <summary>
		/// Description: Lev sno
		/// FieldName: LSQN
		/// FieldType: N
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Lev sno")]
		public int? M3LSQN => GetNullableInt("LSQN");

		/// <summary>
		/// Description: Ssn
		/// FieldName: SSEQ
		/// FieldType: N
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Ssn")]
		public int? M3SSEQ => GetNullableInt("SSEQ");

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
		/// Description: Text identity
		/// FieldName: PRTX
		/// FieldType: N
		/// Length: 13
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Text identity")]
		public decimal? M3PRTX => GetNullableDecimal("PRTX");

		/// <summary>
		/// Description: Text identity
		/// FieldName: POTX
		/// FieldType: N
		/// Length: 13
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Text identity")]
		public decimal? M3POTX => GetNullableDecimal("POTX");

		/// <summary>
		/// Description: User-defined field
		/// FieldName: USD1
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("User-defined field")]
		public string M3USD1 => GetString("USD1");

		/// <summary>
		/// Description: Use
		/// FieldName: USD2
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Use")]
		public string M3USD2 => GetString("USD2");

		/// <summary>
		/// Description: Use
		/// FieldName: USD3
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Use")]
		public string M3USD3 => GetString("USD3");

		/// <summary>
		/// Description: Use
		/// FieldName: USD4
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Use")]
		public string M3USD4 => GetString("USD4");

		/// <summary>
		/// Description: Use
		/// FieldName: USD5
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Use")]
		public string M3USD5 => GetString("USD5");

		/// <summary>
		/// Description: Operation code
		/// FieldName: CMND
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Operation code")]
		public string M3CMND => GetString("CMND");

		/// <summary>
		/// Description: 0/blank=Unprocessed, 1=Processed
		/// FieldName: DOWN
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("0/blank=Unprocessed, 1=Processed")]
		public int? M3DOWN => GetNullableInt("DOWN");

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
		/// Description: Reporting number
		/// FieldName: PLRN
		/// FieldType: N
		/// Length: 11
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Reporting number")]
		public decimal? M3PLRN => GetNullableDecimal("PLRN");

		/// <summary>
		/// Description: Check code - location
		/// FieldName: LCHK
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Check code - location")]
		public string M3LCHK => GetString("LCHK");
	}
}
// EOF
