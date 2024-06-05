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

namespace M3H5Lib.Api.PMS120MI
{
	public partial class GetOrderTypeResponse : M3BaseRecord 
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
		/// Description: Name
		/// FieldName: TX15
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Name")]
		public string M3_TX15 => GetString("TX15");

		/// <summary>
		/// Description: Description
		/// FieldName: TX40
		/// FieldType: A
		/// Length: 40
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Description")]
		public string M3_TX40 => GetString("TX40");

		/// <summary>
		/// Description: Number series
		/// FieldName: NBID
		/// FieldType: A
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Number series")]
		public string M3_NBID => GetString("NBID");

		/// <summary>
		/// Description: Keep planned order number as MO number
		/// FieldName: KEEP
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Keep planned order number as MO number")]
		public int? M3_KEEP => GetNullableInt("KEEP");

		/// <summary>
		/// Description: Load category
		/// FieldName: LCAT
		/// FieldType: A
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Load category")]
		public string M3_LCAT => GetString("LCAT");

		/// <summary>
		/// Description: Set prop sched no. as order sched no.
		/// FieldName: SOSC
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Set prop sched no. as order sched no.")]
		public int? M3_SOSC => GetNullableInt("SOSC");

		/// <summary>
		/// Description: Load creation
		/// FieldName: CRLO
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Load creation")]
		public int? M3_CRLO => GetNullableInt("CRLO");

		/// <summary>
		/// Description: Create load directly for planned orders
		/// FieldName: CWPO
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Create load directly for planned orders")]
		public int? M3_CWPO => GetNullableInt("CWPO");

		/// <summary>
		/// Description: Time on product receipt
		/// FieldName: TPRR
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Time on product receipt")]
		public int? M3_TPRR => GetNullableInt("TPRR");

		/// <summary>
		/// Description: Time on material reservation
		/// FieldName: TMAR
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Time on material reservation")]
		public int? M3_TMAR => GetNullableInt("TMAR");

		/// <summary>
		/// Description: Time on material plan from status
		/// FieldName: TIST
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Time on material plan from status")]
		public string M3_TIST => GetString("TIST");

		/// <summary>
		/// Description: Reschedule after operation reporting
		/// FieldName: RCOR
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Reschedule after operation reporting")]
		public int? M3_RCOR => GetNullableInt("RCOR");

		/// <summary>
		/// Description: Create product costing at order release
		/// FieldName: COSM
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Create product costing at order release")]
		public int? M3_COSM => GetNullableInt("COSM");

		/// <summary>
		/// Description: Costing warnings
		/// FieldName: WACO
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Costing warnings")]
		public int? M3_WACO => GetNullableInt("WACO");

		/// <summary>
		/// Description: Print product costing
		/// FieldName: PRTC
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Print product costing")]
		public int? M3_PRTC => GetNullableInt("PRTC");

		/// <summary>
		/// Description: Panel version
		/// FieldName: PAVR
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Panel version")]
		public string M3_PAVR => GetString("PAVR");

		/// <summary>
		/// Description: Picking list separator
		/// FieldName: PIOP
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Picking list separator")]
		public int? M3_PIOP => GetNullableInt("PIOP");

		/// <summary>
		/// Description: Accumulate plan meter load on mach/tool
		/// FieldName: ACML
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Accumulate plan meter load on mach/tool")]
		public int? M3_ACML => GetNullableInt("ACML");

		/// <summary>
		/// Description: Reschedule order
		/// FieldName: RSCH
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Reschedule order")]
		public int? M3_RSCH => GetNullableInt("RSCH");

		/// <summary>
		/// Description: Setup time processing
		/// FieldName: SSTH
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Setup time processing")]
		public int? M3_SSTH => GetNullableInt("SSTH");

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
		/// Description: Dispatch policy
		/// FieldName: DPOL
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Dispatch policy")]
		public string M3_DPOL => GetString("DPOL");

		/// <summary>
		/// Description: Reschedule from when pre-alloc change
		/// FieldName: PTRG
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Reschedule from when pre-alloc change")]
		public int? M3_PTRG => GetNullableInt("PTRG");

		/// <summary>
		/// Description: Update pre-allocation when qty chg
		/// FieldName: PTQC
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Update pre-allocation when qty chg")]
		public int? M3_PTQC => GetNullableInt("PTQC");

		/// <summary>
		/// Description: Automatically release for order costing
		/// FieldName: AROC
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Automatically release for order costing")]
		public int? M3_AROC => GetNullableInt("AROC");

		/// <summary>
		/// Description: Surplus priority
		/// FieldName: BASP
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Surplus priority")]
		public int? M3_BASP => GetNullableInt("BASP");

		/// <summary>
		/// Description: Two-step put-away
		/// FieldName: TSPA
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Two-step put-away")]
		public int? M3_TSPA => GetNullableInt("TSPA");

		/// <summary>
		/// Description: Aging
		/// FieldName: AGIG
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Aging")]
		public int? M3_AGIG => GetNullableInt("AGIG");

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
		/// Description: Timestamp
		/// FieldName: LMTS
		/// FieldType: N
		/// Length: 18
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Timestamp")]
		public decimal? M3_LMTS => GetNullableDecimal("LMTS");

		/// <summary>
		/// Description: Keep expiry date decisions made on mo
		/// FieldName: KEDM
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Keep expiry date decisions made on mo")]
		public int? M3_KEDM => GetNullableInt("KEDM");

		/// <summary>
		/// Description: Release proposals without standardprice
		/// FieldName: RPWS
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Release proposals without standardprice")]
		public int? M3_RPWS => GetNullableInt("RPWS");

		/// <summary>
		/// Description: MO test frequency basis
		/// FieldName: MTFB
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("MO test frequency basis")]
		public int? M3_MTFB => GetNullableInt("MTFB");

		/// <summary>
		/// Description: QI request timing
		/// FieldName: QIRT
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("QI request timing")]
		public int? M3_QIRT => GetNullableInt("QIRT");

		/// <summary>
		/// Description: Disable work center change
		/// FieldName: AWCC
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Disable work center change")]
		public int? M3_AWCC => GetNullableInt("AWCC");

		/// <summary>
		/// Description: Keep start date
		/// FieldName: KPSD
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Keep start date")]
		public int? M3_KPSD => GetNullableInt("KPSD");

		/// <summary>
		/// Description: Print package
		/// FieldName: PPCK
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Print package")]
		public int? M3_PPCK => GetNullableInt("PPCK");

		/// <summary>
		/// Description: Prevent over-reporting
		/// FieldName: PORP
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Prevent over-reporting")]
		public int? M3_PORP => GetNullableInt("PORP");
	}
}
// EOF
