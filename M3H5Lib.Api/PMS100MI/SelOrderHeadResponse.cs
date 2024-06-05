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

namespace M3H5Lib.Api.PMS100MI
{
	public partial class SelOrderHeadResponse : M3BaseRecord 
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
		/// Description: Facility
		/// FieldName: FACI
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Facility")]
		public string M3_FACI => GetString("FACI");

		/// <summary>
		/// Description: Manufacturing order number
		/// FieldName: MFNO
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Manufacturing order number")]
		public string M3_MFNO => GetString("MFNO");

		/// <summary>
		/// Description: Product number
		/// FieldName: PRNO
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Product number")]
		public string M3_PRNO => GetString("PRNO");

		/// <summary>
		/// Description: Product description
		/// FieldName: ITDS
		/// FieldType: A
		/// Length: 30
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Product description")]
		public string M3_ITDS => GetString("ITDS");

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
		/// Description: Reference order number
		/// FieldName: RORN
		/// FieldType: N
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Reference order number")]
		public long? M3_RORN => GetNullableLong("RORN");

		/// <summary>
		/// Description: Reference order line
		/// FieldName: RORL
		/// FieldType: N
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Reference order line")]
		public int? M3_RORL => GetNullableInt("RORL");

		/// <summary>
		/// Description: Line suffix
		/// FieldName: RORX
		/// FieldType: N
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Line suffix")]
		public int? M3_RORX => GetNullableInt("RORX");

		/// <summary>
		/// Description: Status
		/// FieldName: WHST
		/// FieldType: N
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Status")]
		public int? M3_WHST => GetNullableInt("WHST");

		/// <summary>
		/// Description: Higher-level order number same as curren
		/// FieldName: MFCD
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Higher-level order number same as curren")]
		public int? M3_MFCD => GetNullableInt("MFCD");

		/// <summary>
		/// Description: Ordered quantity
		/// FieldName: ORQT
		/// FieldType: N
		/// Length: 16
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Ordered quantity")]
		public decimal? M3_ORQT => GetNullableDecimal("ORQT");

		/// <summary>
		/// Description: Manufactured quantity
		/// FieldName: MAQT
		/// FieldType: N
		/// Length: 16
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Manufactured quantity")]
		public decimal? M3_MAQT => GetNullableDecimal("MAQT");

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
		/// Description: Planned start date
		/// FieldName: STDT
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Planned start date")]
		public DateTime? M3_STDT => GetNullableDateTime("STDT");

		/// <summary>
		/// Description: Planned start time
		/// FieldName: MSTI
		/// FieldType: N
		/// Length: 4
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Planned start time")]
		public int? M3_MSTI => GetNullableInt("MSTI");

		/// <summary>
		/// Description: Planned finish date
		/// FieldName: FIDT
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Planned finish date")]
		public DateTime? M3_FIDT => GetNullableDateTime("FIDT");

		/// <summary>
		/// Description: Planned finish time
		/// FieldName: MFTI
		/// FieldType: N
		/// Length: 4
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Planned finish time")]
		public int? M3_MFTI => GetNullableInt("MFTI");

		/// <summary>
		/// Description: Alternate planning date
		/// FieldName: NNDT
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Alternate planning date")]
		public DateTime? M3_NNDT => GetNullableDateTime("NNDT");

		/// <summary>
		/// Description: Pull-up code delayed
		/// FieldName: PULD
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Pull-up code delayed")]
		public int? M3_PULD => GetNullableInt("PULD");

		/// <summary>
		/// Description: Pull-up code non-delayed
		/// FieldName: PULN
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Pull-up code non-delayed")]
		public int? M3_PULN => GetNullableInt("PULN");

		/// <summary>
		/// Description: Filter date reschedule in
		/// FieldName: RIFD
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Filter date reschedule in")]
		public DateTime? M3_RIFD => GetNullableDateTime("RIFD");

		/// <summary>
		/// Description: Filter date reschedule out
		/// FieldName: ROFD
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Filter date reschedule out")]
		public DateTime? M3_ROFD => GetNullableDateTime("ROFD");

		/// <summary>
		/// Description: Color group
		/// FieldName: CLGP
		/// FieldType: N
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Color group")]
		public int? M3_CLGP => GetNullableInt("CLGP");

		/// <summary>
		/// Description: Timestamp - date
		/// FieldName: TSDA
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Timestamp - date")]
		public DateTime? M3_TSDA => GetNullableDateTime("TSDA");

		/// <summary>
		/// Description: Timestamp - time
		/// FieldName: TSTE
		/// FieldType: N
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Timestamp - time")]
		public int? M3_TSTE => GetNullableInt("TSTE");

		/// <summary>
		/// Description: Text line
		/// FieldName: TXT1
		/// FieldType: A
		/// Length: 60
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Text line")]
		public string M3_TXT1 => GetString("TXT1");

		/// <summary>
		/// Description: Text line
		/// FieldName: TXT2
		/// FieldType: A
		/// Length: 60
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Text line")]
		public string M3_TXT2 => GetString("TXT2");

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
		/// Description: Sub-network
		/// FieldName: SUBN
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Sub-network")]
		public int? M3_SUBN => GetNullableInt("SUBN");

		/// <summary>
		/// Description: APP-processed
		/// FieldName: PRAP
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("APP-processed")]
		public int? M3_PRAP => GetNullableInt("PRAP");

		/// <summary>
		/// Description: Main product
		/// FieldName: HDPR
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Main product")]
		public string M3_HDPR => GetString("HDPR");

		/// <summary>
		/// Description: Due date
		/// FieldName: DUED
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Due date")]
		public DateTime? M3_DUED => GetNullableDateTime("DUED");

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
		/// Length: 4
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Entry time")]
		public int? M3_RGTM => GetNullableInt("RGTM");

		/// <summary>
		/// Description: Action message
		/// FieldName: ACTP
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Action message")]
		public string M3_ACTP => GetString("ACTP");

		/// <summary>
		/// Description: External network priority
		/// FieldName: NTWP
		/// FieldType: N
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("External network priority")]
		public int? M3_NTWP => GetNullableInt("NTWP");

		/// <summary>
		/// Description: APP change date
		/// FieldName: ACHD
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("APP change date")]
		public DateTime? M3_ACHD => GetNullableDateTime("ACHD");

		/// <summary>
		/// Description: APP change time
		/// FieldName: ACHT
		/// FieldType: N
		/// Length: 4
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("APP change time")]
		public int? M3_ACHT => GetNullableInt("ACHT");

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
		/// Description: Surplus priority (VTBASP)
		/// FieldName: BASP
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Surplus priority (VTBASP)")]
		public int? M3_BASP => GetNullableInt("BASP");

		/// <summary>
		/// Description: Order type
		/// FieldName: ORTY
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Order type")]
		public string M3_ORTY => GetString("ORTY");

		/// <summary>
		/// Description: Number of decimal places (MMDCCD)
		/// FieldName: DCCD
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Number of decimal places (MMDCCD)")]
		public int? M3_DCCD => GetNullableInt("DCCD");

		/// <summary>
		/// Description: Attribute number
		/// FieldName: ATNR
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Attribute number")]
		public decimal? M3_ATNR => GetNullableDecimal("ATNR");

		/// <summary>
		/// Description: Time hours & minutes
		/// FieldName: TIHM
		/// FieldType: N
		/// Length: 4
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Time hours & minutes")]
		public int? M3_TIHM => GetNullableInt("TIHM");

		/// <summary>
		/// Description: Schedule number
		/// FieldName: SCHN
		/// FieldType: N
		/// Length: 11
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Schedule number")]
		public decimal? M3_SCHN => GetNullableDecimal("SCHN");

		/// <summary>
		/// Description: Product number highest level
		/// FieldName: PRHL
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Product number highest level")]
		public string M3_PRHL => GetString("PRHL");

		/// <summary>
		/// Description: MO number highest level
		/// FieldName: MFHL
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("MO number highest level")]
		public string M3_MFHL => GetString("MFHL");

		/// <summary>
		/// Description: Product number overlying level
		/// FieldName: PRLO
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Product number overlying level")]
		public string M3_PRLO => GetString("PRLO");

		/// <summary>
		/// Description: MO number nect higher level
		/// FieldName: MFLO
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("MO number nect higher level")]
		public string M3_MFLO => GetString("MFLO");

		/// <summary>
		/// Description: Process code
		/// FieldName: PCCO
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Process code")]
		public int? M3_PCCO => GetNullableInt("PCCO");

		/// <summary>
		/// Description: Process item number
		/// FieldName: PINR
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Process item number")]
		public string M3_PINR => GetString("PINR");

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
		/// Description: Project Number
		/// FieldName: PROJ
		/// FieldType: A
		/// Length: 7
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Project Number")]
		public string M3_PROJ => GetString("PROJ");

		/// <summary>
		/// Description: Project element
		/// FieldName: ELNO
		/// FieldType: A
		/// Length: 8
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Project element")]
		public string M3_ELNO => GetString("ELNO");

		/// <summary>
		/// Description: Order documents printed
		/// FieldName: WODP
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Order documents printed")]
		public int? M3_WODP => GetNullableInt("WODP");

		/// <summary>
		/// Description: Schedule number description
		/// FieldName: TX40
		/// FieldType: A
		/// Length: 40
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Schedule number description")]
		public string M3_TX40 => GetString("TX40");

		/// <summary>
		/// Description: Structure type
		/// FieldName: STRT
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Structure type")]
		public string M3_STRT => GetString("STRT");

		/// <summary>
		/// Description: Macro order number
		/// FieldName: MACN
		/// FieldType: N
		/// Length: 11
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Macro order number")]
		public decimal? M3_MACN => GetNullableDecimal("MACN");

		/// <summary>
		/// Description: Manufacturing U/M
		/// FieldName: MAUN
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Manufacturing U/M")]
		public string M3_MAUN => GetString("MAUN");

		/// <summary>
		/// Description: Configuration number
		/// FieldName: CFIN
		/// FieldType: N
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Configuration number")]
		public long? M3_CFIN => GetNullableLong("CFIN");

		/// <summary>
		/// Description: Alternative routing
		/// FieldName: AOID
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Alternative routing")]
		public string M3_AOID => GetString("AOID");

		/// <summary>
		/// Description: Supply chain number
		/// FieldName: SCNB
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Supply chain number")]
		public string M3_SCNB => GetString("SCNB");

		/// <summary>
		/// Description: Macro order number
		/// FieldName: MONO
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Macro order number")]
		public string M3_MONO => GetString("MONO");
	}
}
// EOF
