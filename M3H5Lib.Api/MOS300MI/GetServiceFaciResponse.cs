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

namespace M3H5Lib.Api.MOS300MI
{
	public partial class GetServiceFaciResponse : M3BaseRecord 
	{

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
		/// Description: Start date
		/// FieldName: STDT
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Start date")]
		public DateTime? M3STDT => GetNullableDateTime("STDT");

		/// <summary>
		/// Description: To date
		/// FieldName: TODT
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("To date")]
		public DateTime? M3TODT => GetNullableDateTime("TODT");

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
		/// Description: Lead time - service
		/// FieldName: LEAS
		/// FieldType: N
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Lead time - service")]
		public int? M3LEAS => GetNullableInt("LEAS");

		/// <summary>
		/// Description: Capability list
		/// FieldName: SRVL
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Capability list")]
		public int? M3SRVL => GetNullableInt("SRVL");

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
		/// Description: Warranty certified
		/// FieldName: WACF
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Warranty certified")]
		public int? M3WACF => GetNullableInt("WACF");

		/// <summary>
		/// Description: Warranty limit 1
		/// FieldName: WAL1
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Warranty limit 1")]
		public decimal? M3WAL1 => GetNullableDecimal("WAL1");

		/// <summary>
		/// Description: Warranty limit 2
		/// FieldName: WAL2
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Warranty limit 2")]
		public decimal? M3WAL2 => GetNullableDecimal("WAL2");

		/// <summary>
		/// Description: Warranty limit 3
		/// FieldName: WAL3
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Warranty limit 3")]
		public decimal? M3WAL3 => GetNullableDecimal("WAL3");

		/// <summary>
		/// Description: Warranty limit 4
		/// FieldName: WAL4
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Warranty limit 4")]
		public decimal? M3WAL4 => GetNullableDecimal("WAL4");

		/// <summary>
		/// Description: Document identity
		/// FieldName: DOID
		/// FieldType: A
		/// Length: 20
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Document identity")]
		public string M3DOID => GetString("DOID");

		/// <summary>
		/// Description: Failure effect category
		/// FieldName: MRBF
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Failure effect category")]
		public int? M3MRBF => GetNullableInt("MRBF");

		/// <summary>
		/// Description: Service level
		/// FieldName: ZSET
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Service level")]
		public int? M3ZSET => GetNullableInt("ZSET");

		/// <summary>
		/// Description: Calculation method
		/// FieldName: ZSEC
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Calculation method")]
		public int? M3ZSEC => GetNullableInt("ZSEC");

		/// <summary>
		/// Description: Scheduled maintenance service
		/// FieldName: SCHD
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Scheduled maintenance service")]
		public int? M3SCHD => GetNullableInt("SCHD");

		/// <summary>
		/// Description: Total time
		/// FieldName: TOTT
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Total time")]
		public int? M3TOTT => GetNullableInt("TOTT");

		/// <summary>
		/// Description: Service motivation
		/// FieldName: TSMO
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Service motivation")]
		public string M3TSMO => GetString("TSMO");

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
		/// Description: Criticality class
		/// FieldName: AESC
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Criticality class")]
		public int? M3AESC => GetNullableInt("AESC");

		/// <summary>
		/// Description: Supplier group
		/// FieldName: SUCL
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Supplier group")]
		public string M3SUCL => GetString("SUCL");

		/// <summary>
		/// Description: Subservice
		/// FieldName: SUSE
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Subservice")]
		public int? M3SUSE => GetNullableInt("SUSE");

		/// <summary>
		/// Description: Competing type
		/// FieldName: BLTA
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Competing type")]
		public int? M3BLTA => GetNullableInt("BLTA");

		/// <summary>
		/// Description: Component installed
		/// FieldName: CINS
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Component installed")]
		public int? M3CINS => GetNullableInt("CINS");

		/// <summary>
		/// Description: Service with operations
		/// FieldName: SNOP
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Service with operations")]
		public int? M3SNOP => GetNullableInt("SNOP");

		/// <summary>
		/// Description: Lowest level service
		/// FieldName: LEVS
		/// FieldType: N
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Lowest level service")]
		public int? M3LEVS => GetNullableInt("LEVS");

		/// <summary>
		/// Description: Excluded item
		/// FieldName: EXCE
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Excluded item")]
		public int? M3EXCE => GetNullableInt("EXCE");

		/// <summary>
		/// Description: Service flow
		/// FieldName: SEFL
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Service flow")]
		public string M3SEFL => GetString("SEFL");

		/// <summary>
		/// Description: Event type
		/// FieldName: EVTY
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Event type")]
		public string M3EVTY => GetString("EVTY");

		/// <summary>
		/// Description: Event sequence
		/// FieldName: EVTS
		/// FieldType: N
		/// Length: 4
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Event sequence")]
		public int? M3EVTS => GetNullableInt("EVTS");

		/// <summary>
		/// Description: Revision number
		/// FieldName: ECVE
		/// FieldType: A
		/// Length: 4
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Revision number")]
		public string M3ECVE => GetString("ECVE");

		/// <summary>
		/// Description: Revision date
		/// FieldName: REDS
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Revision date")]
		public DateTime? M3REDS => GetNullableDateTime("REDS");

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
		/// Description: User-defined accounting control object
		/// FieldName: ACRF
		/// FieldType: A
		/// Length: 8
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("User-defined accounting control object")]
		public string M3ACRF => GetString("ACRF");

		/// <summary>
		/// Description: Trend alarm
		/// FieldName: TRLA
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Trend alarm")]
		public string M3TRLA => GetString("TRLA");

		/// <summary>
		/// Description: Manual replanning after removal
		/// FieldName: MPN1
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Manual replanning after removal")]
		public string M3MPN1 => GetString("MPN1");

		/// <summary>
		/// Description: Manual replanning after service
		/// FieldName: MPN2
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Manual replanning after service")]
		public string M3MPN2 => GetString("MPN2");

		/// <summary>
		/// Description: Manual replanning after installation
		/// FieldName: MPN3
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Manual replanning after installation")]
		public string M3MPN3 => GetString("MPN3");

		/// <summary>
		/// Description: Performing level
		/// FieldName: SELV
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Performing level")]
		public int? M3SELV => GetNullableInt("SELV");

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
		/// Description: Shutdown
		/// FieldName: NSTP
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Shutdown")]
		public int? M3NSTP => GetNullableInt("NSTP");

		/// <summary>
		/// Description: Quick reporting
		/// FieldName: QRPT
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Quick reporting")]
		public int? M3QRPT => GetNullableInt("QRPT");

		/// <summary>
		/// Description: Calculation date
		/// FieldName: DTME
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Calculation date")]
		public int? M3DTME => GetNullableInt("DTME");

		/// <summary>
		/// Description: Installation code
		/// FieldName: ISTC
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Installation code")]
		public int? M3ISTC => GetNullableInt("ISTC");

		/// <summary>
		/// Description: Adjust code
		/// FieldName: ADJU
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Adjust code")]
		public int? M3ADJU => GetNullableInt("ADJU");

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
		/// Description: User defined field 1
		/// FieldName: SMC0
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("User defined field 1")]
		public string M3SMC0 => GetString("SMC0");

		/// <summary>
		/// Description: User defined field 2
		/// FieldName: SMC1
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("User defined field 2")]
		public string M3SMC1 => GetString("SMC1");

		/// <summary>
		/// Description: User defined field 3
		/// FieldName: SMC2
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("User defined field 3")]
		public string M3SMC2 => GetString("SMC2");

		/// <summary>
		/// Description: User defined field 4
		/// FieldName: SMC3
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("User defined field 4")]
		public string M3SMC3 => GetString("SMC3");

		/// <summary>
		/// Description: User defined field 5
		/// FieldName: SMC4
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("User defined field 5")]
		public string M3SMC4 => GetString("SMC4");

		/// <summary>
		/// Description: User defined field 6
		/// FieldName: SMC5
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("User defined field 6")]
		public string M3SMC5 => GetString("SMC5");

		/// <summary>
		/// Description: User defined field 7
		/// FieldName: SMC6
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("User defined field 7")]
		public string M3SMC6 => GetString("SMC6");

		/// <summary>
		/// Description: User defined field 8
		/// FieldName: SMC7
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("User defined field 8")]
		public string M3SMC7 => GetString("SMC7");

		/// <summary>
		/// Description: User defined field 9
		/// FieldName: SMC8
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("User defined field 9")]
		public string M3SMC8 => GetString("SMC8");

		/// <summary>
		/// Description: User defined field 10
		/// FieldName: SMC9
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("User defined field 10")]
		public string M3SMC9 => GetString("SMC9");

		/// <summary>
		/// Description: Repeat interval
		/// FieldName: REI0
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Repeat interval")]
		public decimal? M3REI0 => GetNullableDecimal("REI0");

		/// <summary>
		/// Description: Repeat interval
		/// FieldName: REI1
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Repeat interval")]
		public decimal? M3REI1 => GetNullableDecimal("REI1");

		/// <summary>
		/// Description: Repeat interval
		/// FieldName: REI2
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Repeat interval")]
		public decimal? M3REI2 => GetNullableDecimal("REI2");

		/// <summary>
		/// Description: Repeat interval
		/// FieldName: REI3
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Repeat interval")]
		public decimal? M3REI3 => GetNullableDecimal("REI3");

		/// <summary>
		/// Description: Threshold interval
		/// FieldName: THI0
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Threshold interval")]
		public decimal? M3THI0 => GetNullableDecimal("THI0");

		/// <summary>
		/// Description: Threshold interval
		/// FieldName: THI1
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Threshold interval")]
		public decimal? M3THI1 => GetNullableDecimal("THI1");

		/// <summary>
		/// Description: Threshold interval
		/// FieldName: THI2
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Threshold interval")]
		public decimal? M3THI2 => GetNullableDecimal("THI2");

		/// <summary>
		/// Description: Threshold interval
		/// FieldName: THI3
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Threshold interval")]
		public decimal? M3THI3 => GetNullableDecimal("THI3");

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
		/// Description: Meter
		/// FieldName: MES0
		/// FieldType: A
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Meter")]
		public string M3MES0 => GetString("MES0");

		/// <summary>
		/// Description: Meter
		/// FieldName: MES1
		/// FieldType: A
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Meter")]
		public string M3MES1 => GetString("MES1");

		/// <summary>
		/// Description: Meter
		/// FieldName: MES2
		/// FieldType: A
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Meter")]
		public string M3MES2 => GetString("MES2");

		/// <summary>
		/// Description: Meter
		/// FieldName: MES3
		/// FieldType: A
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Meter")]
		public string M3MES3 => GetString("MES3");

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

		/// <summary>
		/// Description: ECO managed
		/// FieldName: ECMA
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("ECO managed")]
		public int? M3ECMA => GetNullableInt("ECMA");

		/// <summary>
		/// Description: Claim warranty
		/// FieldName: ACWA
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Claim warranty")]
		public int? M3ACWA => GetNullableInt("ACWA");

		/// <summary>
		/// Description: Service category
		/// FieldName: PTSR
		/// FieldType: A
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Service category")]
		public string M3PTSR => GetString("PTSR");

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
		/// Description: Number of put-away cards
		/// FieldName: NUC1
		/// FieldType: N
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Number of put-away cards")]
		public int? M3NUC1 => GetNullableInt("NUC1");

		/// <summary>
		/// Description: Number of material requisitions
		/// FieldName: NUC2
		/// FieldType: N
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Number of material requisitions")]
		public int? M3NUC2 => GetNullableInt("NUC2");

		/// <summary>
		/// Description: Number of labor tickets
		/// FieldName: NUC3
		/// FieldType: N
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Number of labor tickets")]
		public int? M3NUC3 => GetNullableInt("NUC3");

		/// <summary>
		/// Description: Number of shop travelers
		/// FieldName: NUC4
		/// FieldType: N
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Number of shop travelers")]
		public int? M3NUC4 => GetNullableInt("NUC4");

		/// <summary>
		/// Description: Number of routing cards
		/// FieldName: NUC5
		/// FieldType: N
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Number of routing cards")]
		public int? M3NUC5 => GetNullableInt("NUC5");

		/// <summary>
		/// Description: Number of picking lists
		/// FieldName: NUC6
		/// FieldType: N
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Number of picking lists")]
		public int? M3NUC6 => GetNullableInt("NUC6");

		/// <summary>
		/// Description: Number of design documents
		/// FieldName: NUC7
		/// FieldType: N
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Number of design documents")]
		public int? M3NUC7 => GetNullableInt("NUC7");

		/// <summary>
		/// Description: Number of put-away cards
		/// FieldName: NUC11
		/// FieldType: N
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Number of put-away cards")]
		public int? M3NUC11 => GetNullableInt("NUC11");

		/// <summary>
		/// Description: Number of material requisitions
		/// FieldName: NUC21
		/// FieldType: N
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Number of material requisitions")]
		public int? M3NUC21 => GetNullableInt("NUC21");

		/// <summary>
		/// Description: Number of labor tickets
		/// FieldName: NUC31
		/// FieldType: N
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Number of labor tickets")]
		public int? M3NUC31 => GetNullableInt("NUC31");

		/// <summary>
		/// Description: Number of shop travelers
		/// FieldName: NUC41
		/// FieldType: N
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Number of shop travelers")]
		public int? M3NUC41 => GetNullableInt("NUC41");

		/// <summary>
		/// Description: Number of routing cards
		/// FieldName: NUC51
		/// FieldType: N
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Number of routing cards")]
		public int? M3NUC51 => GetNullableInt("NUC51");

		/// <summary>
		/// Description: Number of picking lists
		/// FieldName: NUC61
		/// FieldType: N
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Number of picking lists")]
		public int? M3NUC61 => GetNullableInt("NUC61");

		/// <summary>
		/// Description: Number of design documents
		/// FieldName: NUC71
		/// FieldType: N
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Number of design documents")]
		public int? M3NUC71 => GetNullableInt("NUC71");

		/// <summary>
		/// Description: Number of put-away cards
		/// FieldName: NUC12
		/// FieldType: N
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Number of put-away cards")]
		public int? M3NUC12 => GetNullableInt("NUC12");

		/// <summary>
		/// Description: Number of material requisitions
		/// FieldName: NUC22
		/// FieldType: N
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Number of material requisitions")]
		public int? M3NUC22 => GetNullableInt("NUC22");

		/// <summary>
		/// Description: Number of labor tickets
		/// FieldName: NUC32
		/// FieldType: N
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Number of labor tickets")]
		public int? M3NUC32 => GetNullableInt("NUC32");

		/// <summary>
		/// Description: Number of shop travelers
		/// FieldName: NUC42
		/// FieldType: N
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Number of shop travelers")]
		public int? M3NUC42 => GetNullableInt("NUC42");

		/// <summary>
		/// Description: Number of routing cards
		/// FieldName: NUC52
		/// FieldType: N
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Number of routing cards")]
		public int? M3NUC52 => GetNullableInt("NUC52");

		/// <summary>
		/// Description: Number of picking lists
		/// FieldName: NUC62
		/// FieldType: N
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Number of picking lists")]
		public int? M3NUC62 => GetNullableInt("NUC62");

		/// <summary>
		/// Description: Number of design documents
		/// FieldName: NUC72
		/// FieldType: N
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Number of design documents")]
		public int? M3NUC72 => GetNullableInt("NUC72");

		/// <summary>
		/// Description: Planning policy
		/// FieldName: PLCD
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Planning policy")]
		public string M3PLCD => GetString("PLCD");
	}
}
// EOF
