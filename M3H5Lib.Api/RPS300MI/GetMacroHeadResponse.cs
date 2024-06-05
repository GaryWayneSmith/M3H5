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

namespace M3H5Lib.Api.RPS300MI
{
	public partial class GetMacroHeadResponse : M3BaseRecord 
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
		/// Description: Macro order type
		/// FieldName: MOTY
		/// FieldType: N
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Macro order type")]
		public int? M3MOTY => GetNullableInt("MOTY");

		/// <summary>
		/// Description: Macro order number
		/// FieldName: MONO
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Macro order number")]
		public string M3MONO => GetString("MONO");

		/// <summary>
		/// Description: Macro order policy
		/// FieldName: MOPO
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Macro order policy")]
		public string M3MOPO => GetString("MOPO");

		/// <summary>
		/// Description: Macro order qualifier
		/// FieldName: MOQF
		/// FieldType: A
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Macro order qualifier")]
		public string M3MOQF => GetString("MOQF");

		/// <summary>
		/// Description: Macro order value
		/// FieldName: MOQV
		/// FieldType: A
		/// Length: 30
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Macro order value")]
		public string M3MOQV => GetString("MOQV");

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
		/// Description: Order category
		/// FieldName: ORCA
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Order category")]
		public string M3ORCA => GetString("ORCA");

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
		/// Description: Bucket start date
		/// FieldName: SDBU
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Bucket start date")]
		public DateTime? M3SDBU => GetNullableDateTime("SDBU");

		/// <summary>
		/// Description: Bucket end date
		/// FieldName: EDBU
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Bucket end date")]
		public DateTime? M3EDBU => GetNullableDateTime("EDBU");

		/// <summary>
		/// Description: Main attribute value alpha 1
		/// FieldName: AVA1
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Main attribute value alpha 1")]
		public string M3AVA1 => GetString("AVA1");

		/// <summary>
		/// Description: Main attribute value alpha 2
		/// FieldName: AVA2
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Main attribute value alpha 2")]
		public string M3AVA2 => GetString("AVA2");

		/// <summary>
		/// Description: Main attribute value alpha 3
		/// FieldName: AVA3
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Main attribute value alpha 3")]
		public string M3AVA3 => GetString("AVA3");

		/// <summary>
		/// Description: Main attribute value alpha 4
		/// FieldName: AVA4
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Main attribute value alpha 4")]
		public string M3AVA4 => GetString("AVA4");

		/// <summary>
		/// Description: Main attribute value alpha 5
		/// FieldName: AVA5
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Main attribute value alpha 5")]
		public string M3AVA5 => GetString("AVA5");

		/// <summary>
		/// Description: Main attribute value numeric 1
		/// FieldName: AVN1
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Main attribute value numeric 1")]
		public decimal? M3AVN1 => GetNullableDecimal("AVN1");

		/// <summary>
		/// Description: Main attribute value numeric 2
		/// FieldName: AVN2
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Main attribute value numeric 2")]
		public decimal? M3AVN2 => GetNullableDecimal("AVN2");

		/// <summary>
		/// Description: Main attribute value numeric 3
		/// FieldName: AVN3
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Main attribute value numeric 3")]
		public decimal? M3AVN3 => GetNullableDecimal("AVN3");

		/// <summary>
		/// Description: Main attribute value numeric 4
		/// FieldName: AVN4
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Main attribute value numeric 4")]
		public decimal? M3AVN4 => GetNullableDecimal("AVN4");

		/// <summary>
		/// Description: Main attribute value numeric 5
		/// FieldName: AVN5
		/// FieldType: A
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Main attribute value numeric 5")]
		public string M3AVN5 => GetString("AVN5");

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
		/// Description: Group technology class
		/// FieldName: GRTI
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Group technology class")]
		public string M3GRTI => GetString("GRTI");

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
		/// Description: Macro order status
		/// FieldName: MSTS
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Macro order status")]
		public string M3MSTS => GetString("MSTS");

		/// <summary>
		/// Description: Macro order next generation date
		/// FieldName: MNGD
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Macro order next generation date")]
		public DateTime? M3MNGD => GetNullableDateTime("MNGD");

		/// <summary>
		/// Description: Macro order next generation time
		/// FieldName: MNGT
		/// FieldType: N
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Macro order next generation time")]
		public int? M3MNGT => GetNullableInt("MNGT");

		/// <summary>
		/// Description: Safety time
		/// FieldName: SATD
		/// FieldType: N
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Safety time")]
		public int? M3SATD => GetNullableInt("SATD");

		/// <summary>
		/// Description: Planning date
		/// FieldName: PLDT
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Planning date")]
		public DateTime? M3PLDT => GetNullableDateTime("PLDT");

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
		/// Description: Ordered Quantity
		/// FieldName: ORQT
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Ordered Quantity")]
		public decimal? M3ORQT => GetNullableDecimal("ORQT");

		/// <summary>
		/// Description: Unit
		/// FieldName: UNMS
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Unit")]
		public string M3UNMS => GetString("UNMS");

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
		/// Description: Content type
		/// FieldName: CONT
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Content type")]
		public string M3CONT => GetString("CONT");

		/// <summary>
		/// Description: User-defined field 1 - item
		/// FieldName: CFI1
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("User-defined field 1 - item")]
		public string M3CFI1 => GetString("CFI1");

		/// <summary>
		/// Description: User-defined field 2 - item
		/// FieldName: CFI2
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("User-defined field 2 - item")]
		public decimal? M3CFI2 => GetNullableDecimal("CFI2");

		/// <summary>
		/// Description: User-defined field 3 - item
		/// FieldName: CFI3
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("User-defined field 3 - item")]
		public string M3CFI3 => GetString("CFI3");

		/// <summary>
		/// Description: User-defined field 4 - item
		/// FieldName: CFI4
		/// FieldType: A
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("User-defined field 4 - item")]
		public string M3CFI4 => GetString("CFI4");

		/// <summary>
		/// Description: User-defined field 5 - item
		/// FieldName: CFI5
		/// FieldType: A
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("User-defined field 5 - item")]
		public string M3CFI5 => GetString("CFI5");

		/// <summary>
		/// Description: Planning Entity
		/// FieldName: CCIT
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Planning Entity")]
		public string M3CCIT => GetString("CCIT");

		/// <summary>
		/// Description: Alternate Planning date
		/// FieldName: NNDT
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Alternate Planning date")]
		public DateTime? M3NNDT => GetNullableDateTime("NNDT");

		/// <summary>
		/// Description: Planner
		/// FieldName: PLAN
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Planner")]
		public string M3PLAN => GetString("PLAN");

		/// <summary>
		/// Description: Last Transfer Date
		/// FieldName: LTDA
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Last Transfer Date")]
		public DateTime? M3LTDA => GetNullableDateTime("LTDA");

		/// <summary>
		/// Description: Last Transfer Time
		/// FieldName: LTTM
		/// FieldType: N
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Last Transfer Time")]
		public int? M3LTTM => GetNullableInt("LTTM");

		/// <summary>
		/// Description: Last Change Date
		/// FieldName: LCHD
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Last Change Date")]
		public DateTime? M3LCHD => GetNullableDateTime("LCHD");

		/// <summary>
		/// Description: Last Change Time
		/// FieldName: LCHT
		/// FieldType: N
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Last Change Time")]
		public int? M3LCHT => GetNullableInt("LCHT");

		/// <summary>
		/// Description: Procurement group
		/// FieldName: PRGP
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Procurement group")]
		public string M3PRGP => GetString("PRGP");

		/// <summary>
		/// Description: Latest planning date
		/// FieldName: LPLD
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Latest planning date")]
		public DateTime? M3LPLD => GetNullableDateTime("LPLD");

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
		/// Description: Serial number
		/// FieldName: SERN
		/// FieldType: A
		/// Length: 20
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Serial number")]
		public string M3SERN => GetString("SERN");

		/// <summary>
		/// Description: Service
		/// FieldName: SUFI
		/// FieldType: A
		/// Length: 20
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Service")]
		public string M3SUFI => GetString("SUFI");

		/// <summary>
		/// Description: Project number
		/// FieldName: PROJ
		/// FieldType: A
		/// Length: 7
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Project number")]
		public string M3PROJ => GetString("PROJ");

		/// <summary>
		/// Description: Reference order category
		/// FieldName: R1RC
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Reference order category")]
		public int? M3R1RC => GetNullableInt("R1RC");

		/// <summary>
		/// Description: Reference order number
		/// FieldName: R1RN
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Reference order number")]
		public string M3R1RN => GetString("R1RN");

		/// <summary>
		/// Description: Reference order line
		/// FieldName: R1RL
		/// FieldType: N
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Reference order line")]
		public int? M3R1RL => GetNullableInt("R1RL");

		/// <summary>
		/// Description: Line suffix
		/// FieldName: R1RX
		/// FieldType: N
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Line suffix")]
		public int? M3R1RX => GetNullableInt("R1RX");

		/// <summary>
		/// Description: Description
		/// FieldName: TX40
		/// FieldType: A
		/// Length: 40
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Description")]
		public string M3TX40 => GetString("TX40");

		/// <summary>
		/// Description: Equipment number
		/// FieldName: EQNO
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Equipment number")]
		public string M3EQNO => GetString("EQNO");

		/// <summary>
		/// Description: Product structure type
		/// FieldName: STRT
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Product structure type")]
		public string M3STRT => GetString("STRT");

		/// <summary>
		/// Description: Planned quantity
		/// FieldName: PPQT
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Planned quantity")]
		public decimal? M3PPQT => GetNullableDecimal("PPQT");

		/// <summary>
		/// Description: Include order initiated
		/// FieldName: INOI
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Include order initiated")]
		public int? M3INOI => GetNullableInt("INOI");
	}
}
// EOF
