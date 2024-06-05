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

namespace M3H5Lib.Api.CMS045MI
{
	public partial class GetAlertRuleResponse : M3BaseRecord 
	{

		/// <summary>
		/// Description: Event publisher
		/// FieldName: EVPB
		/// FieldType: A
		/// Length: 30
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Event publisher")]
		public string M3_EVPB => GetString("EVPB");

		/// <summary>
		/// Description: Event name
		/// FieldName: EVNM
		/// FieldType: A
		/// Length: 30
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Event name")]
		public string M3_EVNM => GetString("EVNM");

		/// <summary>
		/// Description: Event name operation
		/// FieldName: EVNO
		/// FieldType: A
		/// Length: 30
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Event name operation")]
		public string M3_EVNO => GetString("EVNO");

		/// <summary>
		/// Description: Alert rule identity
		/// FieldName: ARID
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Alert rule identity")]
		public string M3_ARID => GetString("ARID");

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
		/// Description: Logical type
		/// FieldName: LOT1
		/// FieldType: A
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Logical type")]
		public string M3_LOT1 => GetString("LOT1");

		/// <summary>
		/// Description: Logical type
		/// FieldName: LOT2
		/// FieldType: A
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Logical type")]
		public string M3_LOT2 => GetString("LOT2");

		/// <summary>
		/// Description: Logical type
		/// FieldName: LOT3
		/// FieldType: A
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Logical type")]
		public string M3_LOT3 => GetString("LOT3");

		/// <summary>
		/// Description: Field
		/// FieldName: OB01
		/// FieldType: A
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Field")]
		public string M3_OB01 => GetString("OB01");

		/// <summary>
		/// Description: Field
		/// FieldName: OB02
		/// FieldType: A
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Field")]
		public string M3_OB02 => GetString("OB02");

		/// <summary>
		/// Description: Field
		/// FieldName: OB03
		/// FieldType: A
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Field")]
		public string M3_OB03 => GetString("OB03");

		/// <summary>
		/// Description: Field
		/// FieldName: OB04
		/// FieldType: A
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Field")]
		public string M3_OB04 => GetString("OB04");

		/// <summary>
		/// Description: Field
		/// FieldName: OB05
		/// FieldType: A
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Field")]
		public string M3_OB05 => GetString("OB05");

		/// <summary>
		/// Description: Field
		/// FieldName: OB06
		/// FieldType: A
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Field")]
		public string M3_OB06 => GetString("OB06");

		/// <summary>
		/// Description: Value field
		/// FieldName: VAL1
		/// FieldType: A
		/// Length: 30
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Value field")]
		public string M3_VAL1 => GetString("VAL1");

		/// <summary>
		/// Description: Value field
		/// FieldName: VAL2
		/// FieldType: A
		/// Length: 30
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Value field")]
		public string M3_VAL2 => GetString("VAL2");

		/// <summary>
		/// Description: Value field
		/// FieldName: VAL3
		/// FieldType: A
		/// Length: 30
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Value field")]
		public string M3_VAL3 => GetString("VAL3");

		/// <summary>
		/// Description: Condition
		/// FieldName: COD1
		/// FieldType: N
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Condition")]
		public int? M3_COD1 => GetNullableInt("COD1");

		/// <summary>
		/// Description: Condition
		/// FieldName: COD2
		/// FieldType: N
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Condition")]
		public int? M3_COD2 => GetNullableInt("COD2");

		/// <summary>
		/// Description: Condition
		/// FieldName: COD3
		/// FieldType: N
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Condition")]
		public int? M3_COD3 => GetNullableInt("COD3");

		/// <summary>
		/// Description: Operand
		/// FieldName: OPR1
		/// FieldType: N
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Operand")]
		public int? M3_OPR1 => GetNullableInt("OPR1");

		/// <summary>
		/// Description: Operand
		/// FieldName: OPR2
		/// FieldType: N
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Operand")]
		public int? M3_OPR2 => GetNullableInt("OPR2");

		/// <summary>
		/// Description: Operand
		/// FieldName: OPR3
		/// FieldType: N
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Operand")]
		public int? M3_OPR3 => GetNullableInt("OPR3");

		/// <summary>
		/// Description: And/or
		/// FieldName: ADO1
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("And/or")]
		public int? M3_ADO1 => GetNullableInt("ADO1");

		/// <summary>
		/// Description: And/or
		/// FieldName: ADO2
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("And/or")]
		public int? M3_ADO2 => GetNullableInt("ADO2");

		/// <summary>
		/// Description: Alert message
		/// FieldName: AMSG
		/// FieldType: A
		/// Length: 180
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Alert message")]
		public string M3_AMSG => GetString("AMSG");

		/// <summary>
		/// Description: Receiver
		/// FieldName: REC2
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Receiver")]
		public string M3_REC2 => GetString("REC2");

		/// <summary>
		/// Description: File
		/// FieldName: OARF
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("File")]
		public string M3_OARF => GetString("OARF");

		/// <summary>
		/// Description: Field
		/// FieldName: OARE
		/// FieldType: A
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Field")]
		public string M3_OARE => GetString("OARE");

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
		/// Description: BOD enabled
		/// FieldName: BODE
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("BOD enabled")]
		public int? M3_BODE => GetNullableInt("BODE");

		/// <summary>
		/// Description: BOD message type
		/// FieldName: BDMT
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("BOD message type")]
		public int? M3_BDMT => GetNullableInt("BDMT");

		/// <summary>
		/// Description: Overriding function
		/// FieldName: OFNC
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Overriding function")]
		public string M3_OFNC => GetString("OFNC");

		/// <summary>
		/// Description: Bookmark focus field
		/// FieldName: BFFL
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Bookmark focus field")]
		public string M3_BFFL => GetString("BFFL");

		/// <summary>
		/// Description: Option
		/// FieldName: OPT2
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Option")]
		public string M3_OPT2 => GetString("OPT2");

		/// <summary>
		/// Description: Opening panel
		/// FieldName: PICC
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Opening panel")]
		public string M3_PICC => GetString("PICC");

		/// <summary>
		/// Description: Workflow name
		/// FieldName: WFNM
		/// FieldType: A
		/// Length: 60
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Workflow name")]
		public string M3_WFNM => GetString("WFNM");

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
	}
}
// EOF
