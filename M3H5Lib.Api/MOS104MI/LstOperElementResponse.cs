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

namespace M3H5Lib.Api.MOS104MI
{
	public partial class LstOperElementResponse : M3BaseRecord 
	{

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
		/// Description: Work order number
		/// FieldName: MWNO
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Work order number")]
		public string M3_MWNO => GetString("MWNO");

		/// <summary>
		/// Description: Operation number
		/// FieldName: OPNO
		/// FieldType: N
		/// Length: 4
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Operation number")]
		public int? M3_OPNO => GetNullableInt("OPNO");

		/// <summary>
		/// Description: Task element number
		/// FieldName: ACTS
		/// FieldType: N
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Task element number")]
		public int? M3_ACTS => GetNullableInt("ACTS");

		/// <summary>
		/// Description: Work element
		/// FieldName: ACTR
		/// FieldType: A
		/// Length: 20
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Work element")]
		public string M3_ACTR => GetString("ACTR");

		/// <summary>
		/// Description: Operation element type
		/// FieldName: ACTT
		/// FieldType: A
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Operation element type")]
		public string M3_ACTT => GetString("ACTT");

		/// <summary>
		/// Description: Tool number
		/// FieldName: TOOL
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Tool number")]
		public string M3_TOOL => GetString("TOOL");

		/// <summary>
		/// Description: Serial number
		/// FieldName: SERN
		/// FieldType: A
		/// Length: 20
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Serial number")]
		public string M3_SERN => GetString("SERN");

		/// <summary>
		/// Description: Employee number
		/// FieldName: EMNO
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Employee number")]
		public string M3_EMNO => GetString("EMNO");

		/// <summary>
		/// Description: Name
		/// FieldName: EMNM
		/// FieldType: A
		/// Length: 36
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Name")]
		public string M3_EMNM => GetString("EMNM");

		/// <summary>
		/// Description: Document identity
		/// FieldName: DOID
		/// FieldType: A
		/// Length: 20
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Document identity")]
		public string M3_DOID => GetString("DOID");

		/// <summary>
		/// Description: Inspection identity
		/// FieldName: INSI
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Inspection identity")]
		public string M3_INSI => GetString("INSI");

		/// <summary>
		/// Description: Description
		/// FieldName: ACDS
		/// FieldType: A
		/// Length: 30
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Description")]
		public string M3_ACDS => GetString("ACDS");

		/// <summary>
		/// Description: Text line 1
		/// FieldName: TXT1
		/// FieldType: A
		/// Length: 60
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Text line 1")]
		public string M3_TXT1 => GetString("TXT1");

		/// <summary>
		/// Description: Text line 2
		/// FieldName: TXT2
		/// FieldType: A
		/// Length: 60
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Text line 2")]
		public string M3_TXT2 => GetString("TXT2");

		/// <summary>
		/// Description: Setup time
		/// FieldName: SETI
		/// FieldType: N
		/// Length: 9
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Setup time")]
		public int? M3_SETI => GetNullableInt("SETI");

		/// <summary>
		/// Description: Run time
		/// FieldName: PITI
		/// FieldType: N
		/// Length: 9
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Run time")]
		public int? M3_PITI => GetNullableInt("PITI");

		/// <summary>
		/// Description: Planned number of workers - setup
		/// FieldName: SENP
		/// FieldType: N
		/// Length: 7
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Planned number of workers - setup")]
		public int? M3_SENP => GetNullableInt("SENP");

		/// <summary>
		/// Description: Planned number of workers - run time
		/// FieldName: PRNP
		/// FieldType: N
		/// Length: 7
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Planned number of workers - run time")]
		public int? M3_PRNP => GetNullableInt("PRNP");

		/// <summary>
		/// Description: Labor skill
		/// FieldName: LASK
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Labor skill")]
		public string M3_LASK => GetString("LASK");

		/// <summary>
		/// Description: Inspection skill
		/// FieldName: INSK
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Inspection skill")]
		public string M3_INSK => GetString("INSK");

		/// <summary>
		/// Description: Meter value 1
		/// FieldName: MVA1
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Meter value 1")]
		public decimal? M3_MVA1 => GetNullableDecimal("MVA1");

		/// <summary>
		/// Description: Meter value 2
		/// FieldName: MVA2
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Meter value 2")]
		public decimal? M3_MVA2 => GetNullableDecimal("MVA2");

		/// <summary>
		/// Description: Meter value 3
		/// FieldName: MVA3
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Meter value 3")]
		public decimal? M3_MVA3 => GetNullableDecimal("MVA3");

		/// <summary>
		/// Description: Meter value 4
		/// FieldName: MVA4
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Meter value 4")]
		public decimal? M3_MVA4 => GetNullableDecimal("MVA4");

		/// <summary>
		/// Description: Quantity or time
		/// FieldName: PEQ1
		/// FieldType: N
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Quantity or time")]
		public int? M3_PEQ1 => GetNullableInt("PEQ1");

		/// <summary>
		/// Description: Quantity or time
		/// FieldName: PEQ2
		/// FieldType: N
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Quantity or time")]
		public int? M3_PEQ2 => GetNullableInt("PEQ2");

		/// <summary>
		/// Description: Quantity or time
		/// FieldName: PEQ3
		/// FieldType: N
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Quantity or time")]
		public int? M3_PEQ3 => GetNullableInt("PEQ3");

		/// <summary>
		/// Description: Quantity or time
		/// FieldName: PEQ4
		/// FieldType: N
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Quantity or time")]
		public int? M3_PEQ4 => GetNullableInt("PEQ4");

		/// <summary>
		/// Description: Trigger type
		/// FieldName: PET1
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Trigger type")]
		public int? M3_PET1 => GetNullableInt("PET1");

		/// <summary>
		/// Description: Trigger type
		/// FieldName: PET2
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Trigger type")]
		public int? M3_PET2 => GetNullableInt("PET2");

		/// <summary>
		/// Description: Trigger type
		/// FieldName: PET3
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Trigger type")]
		public int? M3_PET3 => GetNullableInt("PET3");

		/// <summary>
		/// Description: Trigger type
		/// FieldName: PET4
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Trigger type")]
		public int? M3_PET4 => GetNullableInt("PET4");

		/// <summary>
		/// Description: Status
		/// FieldName: STAT
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Status")]
		public string M3_STAT => GetString("STAT");

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
		/// Description: Permit
		/// FieldName: PERM
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Permit")]
		public string M3_PERM => GetString("PERM");

		/// <summary>
		/// Description: Permit type
		/// FieldName: TPRM
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Permit type")]
		public string M3_TPRM => GetString("TPRM");

		/// <summary>
		/// Description: Permit mandatory
		/// FieldName: PRMA
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Permit mandatory")]
		public int? M3_PRMA => GetNullableInt("PRMA");

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
		/// Description: Status mobility
		/// FieldName: STMB
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Status mobility")]
		public string M3_STMB => GetString("STMB");

		/// <summary>
		/// Description: Capability type
		/// FieldName: CATY
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Capability type")]
		public string M3_CATY => GetString("CATY");

		/// <summary>
		/// Description: Transaction quantity - basic U/M
		/// FieldName: TRQT
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Transaction quantity - basic U/M")]
		public decimal? M3_TRQT => GetNullableDecimal("TRQT");
	}
}
// EOF
