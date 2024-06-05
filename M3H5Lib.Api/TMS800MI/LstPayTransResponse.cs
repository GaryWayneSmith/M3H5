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

namespace M3H5Lib.Api.TMS800MI
{
	public partial class LstPayTransResponse : M3BaseRecord 
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
		/// Description: Employee number
		/// FieldName: EMNO
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Employee number")]
		public string M3EMNO => GetString("EMNO");

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
		/// Description: From date
		/// FieldName: TDAF
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("From date")]
		public DateTime? M3TDAF => GetNullableDateTime("TDAF");

		/// <summary>
		/// Description: To date
		/// FieldName: TDAT
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("To date")]
		public DateTime? M3TDAT => GetNullableDateTime("TDAT");

		/// <summary>
		/// Description: From clock
		/// FieldName: TCLF
		/// FieldType: N
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("From clock")]
		public int? M3TCLF => GetNullableInt("TCLF");

		/// <summary>
		/// Description: To clock
		/// FieldName: TCLT
		/// FieldType: N
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("To clock")]
		public int? M3TCLT => GetNullableInt("TCLT");

		/// <summary>
		/// Description: Pay element
		/// FieldName: KIWG
		/// FieldType: N
		/// Length: 4
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Pay element")]
		public int? M3KIWG => GetNullableInt("KIWG");

		/// <summary>
		/// Description: Calculated time
		/// FieldName: CTME
		/// FieldType: N
		/// Length: 11
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Calculated time")]
		public decimal? M3CTME => GetNullableDecimal("CTME");

		/// <summary>
		/// Description: Total amount
		/// FieldName: TODL
		/// FieldType: N
		/// Length: 19
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Total amount")]
		public decimal? M3TODL => GetNullableDecimal("TODL");

		/// <summary>
		/// Description: Accounting dimension 1
		/// FieldName: AIT1
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Accounting dimension 1")]
		public string M3AIT1 => GetString("AIT1");

		/// <summary>
		/// Description: Accounting dimension 2
		/// FieldName: AIT2
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Accounting dimension 2")]
		public string M3AIT2 => GetString("AIT2");

		/// <summary>
		/// Description: Accounting dimension 3
		/// FieldName: AIT3
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Accounting dimension 3")]
		public string M3AIT3 => GetString("AIT3");

		/// <summary>
		/// Description: Accounting dimension 4
		/// FieldName: AIT4
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Accounting dimension 4")]
		public string M3AIT4 => GetString("AIT4");

		/// <summary>
		/// Description: Accounting dimension 5
		/// FieldName: AIT5
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Accounting dimension 5")]
		public string M3AIT5 => GetString("AIT5");

		/// <summary>
		/// Description: Accounting dimension 6
		/// FieldName: AIT6
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Accounting dimension 6")]
		public string M3AIT6 => GetString("AIT6");

		/// <summary>
		/// Description: Accounting dimension 7
		/// FieldName: AIT7
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Accounting dimension 7")]
		public string M3AIT7 => GetString("AIT7");

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
		/// Description: Work center
		/// FieldName: PLGR
		/// FieldType: A
		/// Length: 8
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Work center")]
		public string M3PLGR => GetString("PLGR");

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
		/// Description: Operation number
		/// FieldName: OPNO
		/// FieldType: N
		/// Length: 4
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Operation number")]
		public int? M3OPNO => GetNullableInt("OPNO");

		/// <summary>
		/// Description: Yield quantity
		/// FieldName: BAQT
		/// FieldType: N
		/// Length: 19
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Yield quantity")]
		public decimal? M3BAQT => GetNullableDecimal("BAQT");

		/// <summary>
		/// Description: Manfactured quantity
		/// FieldName: MAQA
		/// FieldType: N
		/// Length: 19
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Manfactured quantity")]
		public decimal? M3MAQA => GetNullableDecimal("MAQA");

		/// <summary>
		/// Description: Scrap quantity alternative unit
		/// FieldName: SCQA
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Scrap quantity alternative unit")]
		public decimal? M3SCQA => GetNullableDecimal("SCQA");

		/// <summary>
		/// Description: Used labor setup time
		/// FieldName: UMAT
		/// FieldType: N
		/// Length: 11
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Used labor setup time")]
		public decimal? M3UMAT => GetNullableDecimal("UMAT");

		/// <summary>
		/// Description: Used labor setup time
		/// FieldName: UMAS
		/// FieldType: N
		/// Length: 11
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Used labor setup time")]
		public decimal? M3UMAS => GetNullableDecimal("UMAS");

		/// <summary>
		/// Description: Unit price
		/// FieldName: PIPR
		/// FieldType: N
		/// Length: 19
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Unit price")]
		public decimal? M3PIPR => GetNullableDecimal("PIPR");

		/// <summary>
		/// Description: Price and time quantity
		/// FieldName: CTCD
		/// FieldType: N
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Price and time quantity")]
		public int? M3CTCD => GetNullableInt("CTCD");

		/// <summary>
		/// Description: Setup price
		/// FieldName: SEPR
		/// FieldType: N
		/// Length: 19
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Setup price")]
		public decimal? M3SEPR => GetNullableDecimal("SEPR");

		/// <summary>
		/// Description: Time rate
		/// FieldName: WAFA
		/// FieldType: N
		/// Length: 19
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Time rate")]
		public decimal? M3WAFA => GetNullableDecimal("WAFA");

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
		/// Description: Production lot number
		/// FieldName: PLNO
		/// FieldType: N
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Production lot number")]
		public long? M3PLNO => GetNullableLong("PLNO");

		/// <summary>
		/// Description: Payroll period
		/// FieldName: PEWA
		/// FieldType: N
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Payroll period")]
		public int? M3PEWA => GetNullableInt("PEWA");

		/// <summary>
		/// Description: Reporting date
		/// FieldName: RPDT
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Reporting date")]
		public DateTime? M3RPDT => GetNullableDateTime("RPDT");

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
		/// Description: Transaction type payroll
		/// FieldName: ETCD
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Transaction type payroll")]
		public int? M3ETCD => GetNullableInt("ETCD");

		/// <summary>
		/// Description: Job number
		/// FieldName: JNU
		/// FieldType: N
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Job number")]
		public int? M3JNU => GetNullableInt("JNU");

		/// <summary>
		/// Description: Job date
		/// FieldName: PRD
		/// FieldType: N
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Job date")]
		public int? M3PRD => GetNullableInt("PRD");

		/// <summary>
		/// Description: Job time
		/// FieldName: PRT
		/// FieldType: N
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Job time")]
		public int? M3PRT => GetNullableInt("PRT");

		/// <summary>
		/// Description: Time of dispatch
		/// FieldName: PRT1
		/// FieldType: N
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Time of dispatch")]
		public int? M3PRT1 => GetNullableInt("PRT1");

		/// <summary>
		/// Description: Sequence number
		/// FieldName: SEQN
		/// FieldType: N
		/// Length: 7
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Sequence number")]
		public int? M3SEQN => GetNullableInt("SEQN");

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
