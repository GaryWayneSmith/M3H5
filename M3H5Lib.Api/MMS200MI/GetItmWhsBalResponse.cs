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

namespace M3H5Lib.Api.MMS200MI
{
	public partial class GetItmWhsBalResponse : M3BaseRecord 
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
		/// Description: Item number
		/// FieldName: ITNO
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Item number")]
		public string M3_ITNO => GetString("ITNO");

		/// <summary>
		/// Description: On-hand balance approved
		/// FieldName: STQT
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("On-hand balance approved")]
		public decimal? M3_STQT => GetNullableDecimal("STQT");

		/// <summary>
		/// Description: On-hand balance for inspection
		/// FieldName: QUQT
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("On-hand balance for inspection")]
		public decimal? M3_QUQT => GetNullableDecimal("QUQT");

		/// <summary>
		/// Description: Rejected on-hand balance
		/// FieldName: RJQT
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Rejected on-hand balance")]
		public decimal? M3_RJQT => GetNullableDecimal("RJQT");

		/// <summary>
		/// Description: Allocated quantity - basic U/M
		/// FieldName: ALQT
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Allocated quantity - basic U/M")]
		public decimal? M3_ALQT => GetNullableDecimal("ALQT");

		/// <summary>
		/// Description: Allocatable net
		/// FieldName: AV01
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Allocatable net")]
		public decimal? M3_AV01 => GetNullableDecimal("AV01");

		/// <summary>
		/// Description: Allocatable on-hand balance
		/// FieldName: AVAL
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Allocatable on-hand balance")]
		public decimal? M3_AVAL => GetNullableDecimal("AVAL");

		/// <summary>
		/// Description: Excess quantity
		/// FieldName: EXQT
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Excess quantity")]
		public decimal? M3_EXQT => GetNullableDecimal("EXQT");

		/// <summary>
		/// Description: Picking list quantity - basic U/M
		/// FieldName: PLQT
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Picking list quantity - basic U/M")]
		public decimal? M3_PLQT => GetNullableDecimal("PLQT");

		/// <summary>
		/// Description: Ordered quantity - basic U/M
		/// FieldName: ORQT
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Ordered quantity - basic U/M")]
		public decimal? M3_ORQT => GetNullableDecimal("ORQT");

		/// <summary>
		/// Description: Reserved quantity
		/// FieldName: REQT
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Reserved quantity")]
		public decimal? M3_REQT => GetNullableDecimal("REQT");

		/// <summary>
		/// Description: Reserved quantity to backorder
		/// FieldName: RLQT
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Reserved quantity to backorder")]
		public decimal? M3_RLQT => GetNullableDecimal("RLQT");

		/// <summary>
		/// Description: Available inventory
		/// FieldName: AV02
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Available inventory")]
		public decimal? M3_AV02 => GetNullableDecimal("AV02");

		/// <summary>
		/// Description: Reserved quantity - planned orders
		/// FieldName: REQP
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Reserved quantity - planned orders")]
		public decimal? M3_REQP => GetNullableDecimal("REQP");

		/// <summary>
		/// Description: Last receipt date
		/// FieldName: IDDT
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Last receipt date")]
		public DateTime? M3_IDDT => GetNullableDateTime("IDDT");

		/// <summary>
		/// Description: Last issue date
		/// FieldName: ODDT
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Last issue date")]
		public DateTime? M3_ODDT => GetNullableDateTime("ODDT");

		/// <summary>
		/// Description: Latest physical inventory date
		/// FieldName: INDT
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Latest physical inventory date")]
		public DateTime? M3_INDT => GetNullableDateTime("INDT");

		/// <summary>
		/// Description: Excess date
		/// FieldName: EXDC
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Excess date")]
		public DateTime? M3_EXDC => GetNullableDateTime("EXDC");

		/// <summary>
		/// Description: Priority date selection
		/// FieldName: PRDC
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Priority date selection")]
		public int? M3_PRDC => GetNullableInt("PRDC");

		/// <summary>
		/// Description: Number of records for physical inventory
		/// FieldName: NUIN
		/// FieldType: N
		/// Length: 4
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Number of records for physical inventory")]
		public int? M3_NUIN => GetNullableInt("NUIN");

		/// <summary>
		/// Description: Annual usage
		/// FieldName: USYE
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Annual usage")]
		public decimal? M3_USYE => GetNullableDecimal("USYE");

		/// <summary>
		/// Description: Average on-hand balance
		/// FieldName: AVST
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Average on-hand balance")]
		public decimal? M3_AVST => GetNullableDecimal("AVST");

		/// <summary>
		/// Description: Projected on-hand at end of lead time
		/// FieldName: DILE
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Projected on-hand at end of lead time")]
		public decimal? M3_DILE => GetNullableDecimal("DILE");

		/// <summary>
		/// Description: Number of balance IDs
		/// FieldName: NUS7
		/// FieldType: N
		/// Length: 7
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Number of balance IDs")]
		public int? M3_NUS7 => GetNullableInt("NUS7");

		/// <summary>
		/// Description: Priority value
		/// FieldName: PRIF
		/// FieldType: N
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Priority value")]
		public int? M3_PRIF => GetNullableInt("PRIF");

		/// <summary>
		/// Description: Run-out time
		/// FieldName: SODY
		/// FieldType: N
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Run-out time")]
		public int? M3_SODY => GetNullableInt("SODY");

		/// <summary>
		/// Description: Fixed annual demand
		/// FieldName: LYQT
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Fixed annual demand")]
		public decimal? M3_LYQT => GetNullableDecimal("LYQT");

		/// <summary>
		/// Description: Fixed acquisition requirement
		/// FieldName: LRYE
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Fixed acquisition requirement")]
		public decimal? M3_LRYE => GetNullableDecimal("LRYE");

		/// <summary>
		/// Description: Zero mark
		/// FieldName: ZCAC
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Zero mark")]
		public int? M3_ZCAC => GetNullableInt("ZCAC");

		/// <summary>
		/// Description: Turnover rate
		/// FieldName: TURN
		/// FieldType: N
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Turnover rate")]
		public int? M3_TURN => GetNullableInt("TURN");

		/// <summary>
		/// Description: Calculation date - material planning
		/// FieldName: MPCD
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Calculation date - material planning")]
		public DateTime? M3_MPCD => GetNullableDateTime("MPCD");

		/// <summary>
		/// Description: Calculation time - material planning
		/// FieldName: MPCT
		/// FieldType: N
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Calculation time - material planning")]
		public int? M3_MPCT => GetNullableInt("MPCT");

		/// <summary>
		/// Description: Time phased safety stock
		/// FieldName: DCSS
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Time phased safety stock")]
		public int? M3_DCSS => GetNullableInt("DCSS");

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
		/// Description: Catch weight approved on hand balance
		/// FieldName: STCW
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Catch weight approved on hand balance")]
		public decimal? M3_STCW => GetNullableDecimal("STCW");

		/// <summary>
		/// Description: Catch weight rejected on hand balance
		/// FieldName: RJCW
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Catch weight rejected on hand balance")]
		public decimal? M3_RJCW => GetNullableDecimal("RJCW");

		/// <summary>
		/// Description: Catch weight for inspection on hand bal
		/// FieldName: QUCW
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Catch weight for inspection on hand bal")]
		public decimal? M3_QUCW => GetNullableDecimal("QUCW");
	}
}
// EOF
