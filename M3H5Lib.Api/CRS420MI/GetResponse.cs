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

namespace M3H5Lib.Api.CRS420MI
{
	public partial class GetResponse : M3BaseRecord 
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
		/// Description: Unique mail id
		/// FieldName: MLID
		/// FieldType: N
		/// Length: 13
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Unique mail id")]
		public decimal? M3_MLID => GetNullableDecimal("MLID");

		/// <summary>
		/// Description: Message receiver
		/// FieldName: REC2
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Message receiver")]
		public string M3_REC2 => GetString("REC2");

		/// <summary>
		/// Description: Application message id
		/// FieldName: MTPE
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Application message id")]
		public string M3_MTPE => GetString("MTPE");

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
		/// Description: Message text - short
		/// FieldName: TX30
		/// FieldType: A
		/// Length: 30
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Message text - short")]
		public string M3_TX30 => GetString("TX30");

		/// <summary>
		/// Description: Sender
		/// FieldName: SEND
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Sender")]
		public string M3_SEND => GetString("SEND");

		/// <summary>
		/// Description: Original receiver
		/// FieldName: REC3
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Original receiver")]
		public string M3_REC3 => GetString("REC3");

		/// <summary>
		/// Description: Action date - CCYYMMDD
		/// FieldName: ADAT
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Action date - CCYYMMDD")]
		public DateTime? M3_ADAT => GetNullableDateTime("ADAT");

		/// <summary>
		/// Description: Completed date - CCYYMMDD
		/// FieldName: CDAT
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Completed date - CCYYMMDD")]
		public DateTime? M3_CDAT => GetNullableDateTime("CDAT");

		/// <summary>
		/// Description: Removal date - CCYYMMDD
		/// FieldName: RMDT
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Removal date - CCYYMMDD")]
		public DateTime? M3_RMDT => GetNullableDateTime("RMDT");

		/// <summary>
		/// Description: Application message text
		/// FieldName: MSGT
		/// FieldType: A
		/// Length: 180
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Application message text")]
		public string M3_MSGT => GetString("MSGT");

		/// <summary>
		/// Description: Registration date - CCYYMMDD
		/// FieldName: RGDT
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Registration date - CCYYMMDD")]
		public DateTime? M3_RGDT => GetNullableDateTime("RGDT");

		/// <summary>
		/// Description: Registarion time - HHMMSS
		/// FieldName: RGTM
		/// FieldType: N
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Registarion time - HHMMSS")]
		public int? M3_RGTM => GetNullableInt("RGTM");

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
		/// Description: Program name
		/// FieldName: PGNM
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Program name")]
		public string M3_PGNM => GetString("PGNM");

		/// <summary>
		/// Description: Panel check ID
		/// FieldName: PICC
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Panel check ID")]
		public string M3_PICC => GetString("PICC");

		/// <summary>
		/// Description: Inquiry type
		/// FieldName: QTTP
		/// FieldType: N
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Inquiry type")]
		public int? M3_QTTP => GetNullableInt("QTTP");

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
		/// Description: Transfer data area
		/// FieldName: DT01
		/// FieldType: A
		/// Length: 30
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Transfer data area")]
		public string M3_DT01 => GetString("DT01");

		/// <summary>
		/// Description: Transfer data area
		/// FieldName: DT02
		/// FieldType: A
		/// Length: 30
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Transfer data area")]
		public string M3_DT02 => GetString("DT02");

		/// <summary>
		/// Description: Transfer data area
		/// FieldName: DT03
		/// FieldType: A
		/// Length: 30
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Transfer data area")]
		public string M3_DT03 => GetString("DT03");

		/// <summary>
		/// Description: Transfer data area
		/// FieldName: DT04
		/// FieldType: A
		/// Length: 30
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Transfer data area")]
		public string M3_DT04 => GetString("DT04");

		/// <summary>
		/// Description: Transfer data area
		/// FieldName: DT05
		/// FieldType: A
		/// Length: 30
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Transfer data area")]
		public string M3_DT05 => GetString("DT05");

		/// <summary>
		/// Description: Transfer data area
		/// FieldName: DT06
		/// FieldType: A
		/// Length: 30
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Transfer data area")]
		public string M3_DT06 => GetString("DT06");

		/// <summary>
		/// Description: Transfer data area
		/// FieldName: DT07
		/// FieldType: A
		/// Length: 30
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Transfer data area")]
		public string M3_DT07 => GetString("DT07");

		/// <summary>
		/// Description: Transfer data area
		/// FieldName: DT08
		/// FieldType: A
		/// Length: 30
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Transfer data area")]
		public string M3_DT08 => GetString("DT08");

		/// <summary>
		/// Description: Transfer data area
		/// FieldName: DT09
		/// FieldType: A
		/// Length: 30
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Transfer data area")]
		public string M3_DT09 => GetString("DT09");

		/// <summary>
		/// Description: Transfer data area
		/// FieldName: DT10
		/// FieldType: A
		/// Length: 30
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Transfer data area")]
		public string M3_DT10 => GetString("DT10");

		/// <summary>
		/// Description: Transfer data area
		/// FieldName: DT11
		/// FieldType: A
		/// Length: 30
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Transfer data area")]
		public string M3_DT11 => GetString("DT11");

		/// <summary>
		/// Description: Transfer data area
		/// FieldName: DT12
		/// FieldType: A
		/// Length: 30
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Transfer data area")]
		public string M3_DT12 => GetString("DT12");

		/// <summary>
		/// Description: Transfer data area
		/// FieldName: DT13
		/// FieldType: A
		/// Length: 30
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Transfer data area")]
		public string M3_DT13 => GetString("DT13");

		/// <summary>
		/// Description: Transfer data area
		/// FieldName: DT14
		/// FieldType: A
		/// Length: 30
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Transfer data area")]
		public string M3_DT14 => GetString("DT14");

		/// <summary>
		/// Description: Transfer data area
		/// FieldName: DT15
		/// FieldType: A
		/// Length: 30
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Transfer data area")]
		public string M3_DT15 => GetString("DT15");

		/// <summary>
		/// Description: Transfer data area
		/// FieldName: DT16
		/// FieldType: A
		/// Length: 30
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Transfer data area")]
		public string M3_DT16 => GetString("DT16");

		/// <summary>
		/// Description: Table
		/// FieldName: FILE
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Table")]
		public string M3_FILE => GetString("FILE");

		/// <summary>
		/// Description: Field
		/// FieldName: FLDI
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Field")]
		public string M3_FLDI => GetString("FLDI");

		/// <summary>
		/// Description: Keystring exists
		/// FieldName: KSEX
		/// FieldType: A
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Keystring exists")]
		public string M3_KSEX => GetString("KSEX");

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
	}
}
// EOF
