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

namespace M3H5Lib.Api.MOS100MI
{
	public partial class SelectResponse : M3BaseRecord 
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
		/// Description: Manufacturing order number
		/// FieldName: MFNO
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Manufacturing order number")]
		public string M3MFNO => GetString("MFNO");

		/// <summary>
		/// Description: Product number
		/// FieldName: PRNO
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Product number")]
		public string M3PRNO => GetString("PRNO");

		/// <summary>
		/// Description: Product description
		/// FieldName: ITDS
		/// FieldType: A
		/// Length: 30
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Product description")]
		public string M3ITDS => GetString("ITDS");

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
		/// Description: Reference order number
		/// FieldName: RORN
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Reference order number")]
		public string M3RORN => GetString("RORN");

		/// <summary>
		/// Description: Reference order line
		/// FieldName: RORL
		/// FieldType: N
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Reference order line")]
		public int? M3RORL => GetNullableInt("RORL");

		/// <summary>
		/// Description: Line suffix
		/// FieldName: RORX
		/// FieldType: N
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Line suffix")]
		public int? M3RORX => GetNullableInt("RORX");

		/// <summary>
		/// Description: Higher-level order number same as curren
		/// FieldName: MFCD
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Higher-level order number same as curren")]
		public int? M3MFCD => GetNullableInt("MFCD");

		/// <summary>
		/// Description: Status
		/// FieldName: WHST
		/// FieldType: N
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Status")]
		public int? M3WHST => GetNullableInt("WHST");

		/// <summary>
		/// Description: Ordered quantity
		/// FieldName: ORQT
		/// FieldType: N
		/// Length: 16
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Ordered quantity")]
		public decimal? M3ORQT => GetNullableDecimal("ORQT");

		/// <summary>
		/// Description: Manufactured quantity
		/// FieldName: MAQT
		/// FieldType: N
		/// Length: 16
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Manufactured quantity")]
		public decimal? M3MAQT => GetNullableDecimal("MAQT");

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
		/// Description: Planned start date
		/// FieldName: STDT
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Planned start date")]
		public DateTime? M3STDT => GetNullableDateTime("STDT");

		/// <summary>
		/// Description: Planned start time
		/// FieldName: MSTI
		/// FieldType: N
		/// Length: 4
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Planned start time")]
		public int? M3MSTI => GetNullableInt("MSTI");

		/// <summary>
		/// Description: Planned finish date
		/// FieldName: FIDT
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Planned finish date")]
		public DateTime? M3FIDT => GetNullableDateTime("FIDT");

		/// <summary>
		/// Description: Planned finish time
		/// FieldName: MFTI
		/// FieldType: N
		/// Length: 4
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Planned finish time")]
		public int? M3MFTI => GetNullableInt("MFTI");

		/// <summary>
		/// Description: Alternate planning date
		/// FieldName: NNDT
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Alternate planning date")]
		public DateTime? M3NNDT => GetNullableDateTime("NNDT");

		/// <summary>
		/// Description: Pull-up code delayed
		/// FieldName: PULD
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Pull-up code delayed")]
		public int? M3PULD => GetNullableInt("PULD");

		/// <summary>
		/// Description: Pull-up code non-delayed
		/// FieldName: PULN
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Pull-up code non-delayed")]
		public int? M3PULN => GetNullableInt("PULN");

		/// <summary>
		/// Description: Filter date reschedule in
		/// FieldName: RIFD
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Filter date reschedule in")]
		public DateTime? M3RIFD => GetNullableDateTime("RIFD");

		/// <summary>
		/// Description: Filter date reschedule out
		/// FieldName: ROFD
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Filter date reschedule out")]
		public DateTime? M3ROFD => GetNullableDateTime("ROFD");

		/// <summary>
		/// Description: Color group
		/// FieldName: CLGP
		/// FieldType: N
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Color group")]
		public int? M3CLGP => GetNullableInt("CLGP");

		/// <summary>
		/// Description: Timestamp - date
		/// FieldName: TSDA
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Timestamp - date")]
		public DateTime? M3TSDA => GetNullableDateTime("TSDA");

		/// <summary>
		/// Description: Timestamp - time
		/// FieldName: TSTE
		/// FieldType: N
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Timestamp - time")]
		public int? M3TSTE => GetNullableInt("TSTE");

		/// <summary>
		/// Description: Text line
		/// FieldName: TXT1
		/// FieldType: A
		/// Length: 60
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Text line")]
		public string M3TXT1 => GetString("TXT1");

		/// <summary>
		/// Description: Text line
		/// FieldName: TXT2
		/// FieldType: A
		/// Length: 60
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Text line")]
		public string M3TXT2 => GetString("TXT2");

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
		/// Description: Sub-network
		/// FieldName: SUBN
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Sub-network")]
		public int? M3SUBN => GetNullableInt("SUBN");

		/// <summary>
		/// Description: APP-processed
		/// FieldName: PRAP
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("APP-processed")]
		public int? M3PRAP => GetNullableInt("PRAP");

		/// <summary>
		/// Description: Main product
		/// FieldName: HDPR
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Main product")]
		public string M3HDPR => GetString("HDPR");

		/// <summary>
		/// Description: Due date
		/// FieldName: DUED
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Due date")]
		public DateTime? M3DUED => GetNullableDateTime("DUED");

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
		/// Length: 4
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Entry time")]
		public int? M3RGTM => GetNullableInt("RGTM");

		/// <summary>
		/// Description: Action message
		/// FieldName: ACTP
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Action message")]
		public string M3ACTP => GetString("ACTP");

		/// <summary>
		/// Description: External network priority
		/// FieldName: NTWP
		/// FieldType: N
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("External network priority")]
		public int? M3NTWP => GetNullableInt("NTWP");

		/// <summary>
		/// Description: APP change date
		/// FieldName: ACHD
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("APP change date")]
		public DateTime? M3ACHD => GetNullableDateTime("ACHD");

		/// <summary>
		/// Description: APP change time
		/// FieldName: ACHT
		/// FieldType: N
		/// Length: 4
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("APP change time")]
		public int? M3ACHT => GetNullableInt("ACHT");

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
		/// Description: Old CFIN
		/// FieldName: CFXX
		/// FieldType: N
		/// Length: 7
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Old CFIN")]
		public int? M3CFXX => GetNullableInt("CFXX");

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
		/// Description: Structure type
		/// FieldName: STRT
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Structure type")]
		public string M3STRT => GetString("STRT");

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
		/// Description: Production workcenter
		/// FieldName: PLG6
		/// FieldType: A
		/// Length: 8
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Production workcenter")]
		public string M3PLG6 => GetString("PLG6");

		/// <summary>
		/// Description: Earliest start date
		/// FieldName: ETD2
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Earliest start date")]
		public DateTime? M3ETD2 => GetNullableDateTime("ETD2");

		/// <summary>
		/// Description: Order type
		/// FieldName: ORTY
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Order type")]
		public string M3ORTY => GetString("ORTY");

		/// <summary>
		/// Description: Number of decimal places
		/// FieldName: DCCD
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Number of decimal places")]
		public int? M3DCCD => GetNullableInt("DCCD");

		/// <summary>
		/// Description: Attribute number
		/// FieldName: ATNR
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Attribute number")]
		public decimal? M3ATNR => GetNullableDecimal("ATNR");

		/// <summary>
		/// Description: Due time
		/// FieldName: TIHM
		/// FieldType: N
		/// Length: 4
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Due time")]
		public int? M3TIHM => GetNullableInt("TIHM");

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
		/// Description: Earliest start time
		/// FieldName: TIH1
		/// FieldType: N
		/// Length: 4
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Earliest start time")]
		public int? M3TIH1 => GetNullableInt("TIH1");

		/// <summary>
		/// Description: Specific requirements
		/// FieldName: SPR1
		/// FieldType: A
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Specific requirements")]
		public string M3SPR1 => GetString("SPR1");

		/// <summary>
		/// Description: Specific requirements
		/// FieldName: SPR2
		/// FieldType: A
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Specific requirements")]
		public string M3SPR2 => GetString("SPR2");

		/// <summary>
		/// Description: Specific requirements
		/// FieldName: SPR3
		/// FieldType: A
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Specific requirements")]
		public string M3SPR3 => GetString("SPR3");

		/// <summary>
		/// Description: Specific requirements
		/// FieldName: SPR4
		/// FieldType: A
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Specific requirements")]
		public string M3SPR4 => GetString("SPR4");

		/// <summary>
		/// Description: Specific requirements
		/// FieldName: SPR5
		/// FieldType: A
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Specific requirements")]
		public string M3SPR5 => GetString("SPR5");

		/// <summary>
		/// Description: Specific requirements
		/// FieldName: SPR6
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Specific requirements")]
		public string M3SPR6 => GetString("SPR6");

		/// <summary>
		/// Description: Specific requirements
		/// FieldName: SPR7
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Specific requirements")]
		public string M3SPR7 => GetString("SPR7");

		/// <summary>
		/// Description: Specific requirements
		/// FieldName: SPR8
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Specific requirements")]
		public string M3SPR8 => GetString("SPR8");

		/// <summary>
		/// Description: Specific requirements
		/// FieldName: SPR9
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Specific requirements")]
		public string M3SPR9 => GetString("SPR9");

		/// <summary>
		/// Description: Specific requirements
		/// FieldName: SPR0
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Specific requirements")]
		public string M3SPR0 => GetString("SPR0");

		/// <summary>
		/// Description: Registration number/site
		/// FieldName: TAIL
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Registration number/site")]
		public string M3TAIL => GetString("TAIL");

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
		/// Description: Alias number for service
		/// FieldName: SALI
		/// FieldType: A
		/// Length: 30
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Alias number for service")]
		public string M3SALI => GetString("SALI");

		/// <summary>
		/// Description: Service group
		/// FieldName: SRGP
		/// FieldType: A
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Service group")]
		public string M3SRGP => GetString("SRGP");

		/// <summary>
		/// Description: Process type
		/// FieldName: TOFP
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Process type")]
		public string M3TOFP => GetString("TOFP");

		/// <summary>
		/// Description: User-defined field 1
		/// FieldName: CFI1
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("User-defined field 1")]
		public string M3CFI1 => GetString("CFI1");

		/// <summary>
		/// Description: User-defined field 2
		/// FieldName: CFI2
		/// FieldType: N
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("User-defined field 2")]
		public decimal? M3CFI2 => GetNullableDecimal("CFI2");

		/// <summary>
		/// Description: User-defined field 3
		/// FieldName: CFI3
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("User-defined field 3")]
		public string M3CFI3 => GetString("CFI3");

		/// <summary>
		/// Description: User-defined field 4
		/// FieldName: CFI4
		/// FieldType: A
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("User-defined field 4")]
		public string M3CFI4 => GetString("CFI4");

		/// <summary>
		/// Description: User-defined field 5
		/// FieldName: CFI5
		/// FieldType: A
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("User-defined field 5")]
		public string M3CFI5 => GetString("CFI5");

		/// <summary>
		/// Description: Configuration number
		/// FieldName: CFIN
		/// FieldType: N
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Configuration number")]
		public long? M3CFIN => GetNullableLong("CFIN");

		/// <summary>
		/// Description: Requester
		/// FieldName: RREQ
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Requester")]
		public string M3RREQ => GetString("RREQ");

		/// <summary>
		/// Description: Request budget amount
		/// FieldName: RBAM
		/// FieldType: N
		/// Length: 19
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Request budget amount")]
		public decimal? M3RBAM => GetNullableDecimal("RBAM");

		/// <summary>
		/// Description: Estimated cost
		/// FieldName: ESBU
		/// FieldType: N
		/// Length: 19
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Estimated cost")]
		public decimal? M3ESBU => GetNullableDecimal("ESBU");

		/// <summary>
		/// Description: Requested start date
		/// FieldName: RRSD
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Requested start date")]
		public DateTime? M3RRSD => GetNullableDateTime("RRSD");

		/// <summary>
		/// Description: Requested start time
		/// FieldName: RRST
		/// FieldType: N
		/// Length: 4
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Requested start time")]
		public int? M3RRST => GetNullableInt("RRST");

		/// <summary>
		/// Description: Requested finish date
		/// FieldName: RRFD
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Requested finish date")]
		public DateTime? M3RRFD => GetNullableDateTime("RRFD");

		/// <summary>
		/// Description: Requested finish time
		/// FieldName: RRFT
		/// FieldType: N
		/// Length: 4
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Requested finish time")]
		public int? M3RRFT => GetNullableInt("RRFT");

		/// <summary>
		/// Description: Estimated downtime
		/// FieldName: EDWT
		/// FieldType: N
		/// Length: 9
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Estimated downtime")]
		public int? M3EDWT => GetNullableInt("EDWT");

		/// <summary>
		/// Description: Scheduling logic
		/// FieldName: SCHL
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Scheduling logic")]
		public int? M3SCHL => GetNullableInt("SCHL");

		/// <summary>
		/// Description: Service Classification
		/// FieldName: SECL
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Service Classification")]
		public int? M3SECL => GetNullableInt("SECL");

		/// <summary>
		/// Description: Service Type
		/// FieldName: STYP
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Service Type")]
		public string M3STYP => GetString("STYP");
	}
}
// EOF
