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

namespace M3H5Lib.Api.MMS010MI
{
	public partial class LstLocGrpResponse : M3BaseRecord 
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
		/// Description: Stock location description
		/// FieldName: SLDS
		/// FieldType: A
		/// Length: 30
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Stock location description")]
		public string M3SLDS => GetString("SLDS");

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
		/// Description: Multi-storage location
		/// FieldName: SLDV
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Multi-storage location")]
		public int? M3SLDV => GetNullableInt("SLDV");

		/// <summary>
		/// Description: Allocatable
		/// FieldName: ALOC
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Allocatable")]
		public int? M3ALOC => GetNullableInt("ALOC");

		/// <summary>
		/// Description: Single allocation
		/// FieldName: SALO
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Single allocation")]
		public int? M3SALO => GetNullableInt("SALO");

		/// <summary>
		/// Description: Delay
		/// FieldName: DEHO
		/// FieldType: N
		/// Length: 7
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Delay")]
		public int? M3DEHO => GetNullableInt("DEHO");

		/// <summary>
		/// Description: Status proposal
		/// FieldName: DEST
		/// FieldType: A
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Status proposal")]
		public string M3DEST => GetString("DEST");

		/// <summary>
		/// Description: Automatic deletion
		/// FieldName: AUDE
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Automatic deletion")]
		public int? M3AUDE => GetNullableInt("AUDE");

		/// <summary>
		/// Description: Automatic deletion delay
		/// FieldName: AUDD
		/// FieldType: N
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Automatic deletion delay")]
		public int? M3AUDD => GetNullableInt("AUDD");

		/// <summary>
		/// Description: Last receipt date
		/// FieldName: IDDT
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Last receipt date")]
		public DateTime? M3IDDT => GetNullableDateTime("IDDT");

		/// <summary>
		/// Description: Last issue date
		/// FieldName: ODDT
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Last issue date")]
		public DateTime? M3ODDT => GetNullableDateTime("ODDT");

		/// <summary>
		/// Description: Number of balance identities
		/// FieldName: NBRL
		/// FieldType: N
		/// Length: 7
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Number of balance identities")]
		public int? M3NBRL => GetNullableInt("NBRL");

		/// <summary>
		/// Description: Maximum storage volume
		/// FieldName: MVOL
		/// FieldType: N
		/// Length: 11
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Maximum storage volume")]
		public decimal? M3MVOL => GetNullableDecimal("MVOL");

		/// <summary>
		/// Description: Current storage volume
		/// FieldName: AVOL
		/// FieldType: N
		/// Length: 11
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Current storage volume")]
		public decimal? M3AVOL => GetNullableDecimal("AVOL");

		/// <summary>
		/// Description: Maximum storage weight
		/// FieldName: MAXW
		/// FieldType: N
		/// Length: 11
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Maximum storage weight")]
		public decimal? M3MAXW => GetNullableDecimal("MAXW");

		/// <summary>
		/// Description: Current storage weight
		/// FieldName: ACTW
		/// FieldType: N
		/// Length: 11
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Current storage weight")]
		public decimal? M3ACTW => GetNullableDecimal("ACTW");

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
		/// Description: Editing position 1
		/// FieldName: EDP1
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Editing position 1")]
		public int? M3EDP1 => GetNullableInt("EDP1");

		/// <summary>
		/// Description: Editing position 2
		/// FieldName: EDP2
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Editing position 2")]
		public int? M3EDP2 => GetNullableInt("EDP2");

		/// <summary>
		/// Description: Editing character 1
		/// FieldName: EDS1
		/// FieldType: A
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Editing character 1")]
		public string M3EDS1 => GetString("EDS1");

		/// <summary>
		/// Description: Editing character 2
		/// FieldName: EDS2
		/// FieldType: A
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Editing character 2")]
		public string M3EDS2 => GetString("EDS2");

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
		/// Description: ABC class - frequency
		/// FieldName: ABFC
		/// FieldType: A
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("ABC class - frequency")]
		public string M3ABFC => GetString("ABFC");

		/// <summary>
		/// Description: Distribution identity
		/// FieldName: SPID
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Distribution identity")]
		public string M3SPID => GetString("SPID");

		/// <summary>
		/// Description: Location type
		/// FieldName: WHLT
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Location type")]
		public string M3WHLT => GetString("WHLT");

		/// <summary>
		/// Description: Transaction statistics
		/// FieldName: STFU
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Transaction statistics")]
		public int? M3STFU => GetNullableInt("STFU");

		/// <summary>
		/// Description: Max filling rate
		/// FieldName: MFRT
		/// FieldType: N
		/// Length: 7
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Max filling rate")]
		public int? M3MFRT => GetNullableInt("MFRT");

		/// <summary>
		/// Description: Current filling rate
		/// FieldName: FRTE
		/// FieldType: N
		/// Length: 7
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Current filling rate")]
		public int? M3FRTE => GetNullableInt("FRTE");

		/// <summary>
		/// Description: Packaging length
		/// FieldName: PACL
		/// FieldType: N
		/// Length: 7
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Packaging length")]
		public int? M3PACL => GetNullableInt("PACL");

		/// <summary>
		/// Description: Packaging width
		/// FieldName: PACW
		/// FieldType: N
		/// Length: 7
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Packaging width")]
		public int? M3PACW => GetNullableInt("PACW");

		/// <summary>
		/// Description: Packaging height
		/// FieldName: PACH
		/// FieldType: N
		/// Length: 7
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Packaging height")]
		public int? M3PACH => GetNullableInt("PACH");

		/// <summary>
		/// Description: Container management
		/// FieldName: CMNG
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Container management")]
		public int? M3CMNG => GetNullableInt("CMNG");

		/// <summary>
		/// Description: Customer number
		/// FieldName: CUNO
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Customer number")]
		public string M3CUNO => GetString("CUNO");

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
		/// Description: Check code
		/// FieldName: CHKC
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Check code")]
		public int? M3CHKC => GetNullableInt("CHKC");

		/// <summary>
		/// Description: Location group
		/// FieldName: LOCG
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Location group")]
		public string M3LOCG => GetString("LOCG");

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
		/// Description: Geographic cod X
		/// FieldName: GEOX
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Geographic cod X")]
		public decimal? M3GEOX => GetNullableDecimal("GEOX");

		/// <summary>
		/// Description: Geographic code Y
		/// FieldName: GEOY
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Geographic code Y")]
		public decimal? M3GEOY => GetNullableDecimal("GEOY");

		/// <summary>
		/// Description: Geographic cod  Z
		/// FieldName: GEOZ
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Geographic cod  Z")]
		public decimal? M3GEOZ => GetNullableDecimal("GEOZ");

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
		/// Description: Location characteristic
		/// FieldName: WHLC
		/// FieldType: N
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Location characteristic")]
		public int? M3WHLC => GetNullableInt("WHLC");
	}
}
// EOF
