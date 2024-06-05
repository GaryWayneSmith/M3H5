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

namespace M3H5Lib.Api.CRS420MI
{
	public partial class LstByActDateDscResponse : M3BaseRecord 
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
		/// Description: Unique mail id
		/// FieldName: MLID
		/// FieldType: N
		/// Length: 13
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Unique mail id")]
		public decimal? M3MLID => GetNullableDecimal("MLID");

		/// <summary>
		/// Description: Message receiver
		/// FieldName: REC2
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Message receiver")]
		public string M3REC2 => GetString("REC2");

		/// <summary>
		/// Description: Application message id
		/// FieldName: MTPE
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Application message id")]
		public string M3MTPE => GetString("MTPE");

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
		/// Description: Message text - short
		/// FieldName: TX30
		/// FieldType: A
		/// Length: 30
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Message text - short")]
		public string M3TX30 => GetString("TX30");

		/// <summary>
		/// Description: Sender
		/// FieldName: SEND
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Sender")]
		public string M3SEND => GetString("SEND");

		/// <summary>
		/// Description: Original receiver
		/// FieldName: REC3
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Original receiver")]
		public string M3REC3 => GetString("REC3");

		/// <summary>
		/// Description: Action date - CCYYMMDD
		/// FieldName: ADAT
		/// FieldType: N
		/// Length: 8
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Action date - CCYYMMDD")]
		public int? M3ADAT => GetNullableInt("ADAT");

		/// <summary>
		/// Description: Completed date - CCYYMMDD
		/// FieldName: CDAT
		/// FieldType: N
		/// Length: 8
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Completed date - CCYYMMDD")]
		public int? M3CDAT => GetNullableInt("CDAT");

		/// <summary>
		/// Description: Removal date - CCYYMMDD
		/// FieldName: RMDT
		/// FieldType: D
		/// Length: 8
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Removal date - CCYYMMDD")]
		public DateTime? M3RMDT => GetNullableDateTime("RMDT");

		/// <summary>
		/// Description: Application message text
		/// FieldName: MSGT
		/// FieldType: A
		/// Length: 180
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Application message text")]
		public string M3MSGT => GetString("MSGT");

		/// <summary>
		/// Description: Registration date - CCYYMMDD
		/// FieldName: RGDT
		/// FieldType: D
		/// Length: 8
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Registration date - CCYYMMDD")]
		public DateTime? M3RGDT => GetNullableDateTime("RGDT");

		/// <summary>
		/// Description: Registarion time - HHMMSS
		/// FieldName: RGTM
		/// FieldType: N
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Registarion time - HHMMSS")]
		public int? M3RGTM => GetNullableInt("RGTM");

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
		/// Description: Panel check ID
		/// FieldName: PICC
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Panel check ID")]
		public string M3PICC => GetString("PICC");

		/// <summary>
		/// Description: Inquiry type
		/// FieldName: QTTP
		/// FieldType: N
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Inquiry type")]
		public int? M3QTTP => GetNullableInt("QTTP");

		/// <summary>
		/// Description: Option
		/// FieldName: OPT2
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Option")]
		public string M3OPT2 => GetString("OPT2");

		/// <summary>
		/// Description: Transfer data area
		/// FieldName: DT01
		/// FieldType: A
		/// Length: 30
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Transfer data area")]
		public string M3DT01 => GetString("DT01");

		/// <summary>
		/// Description: Transfer data area
		/// FieldName: DT02
		/// FieldType: A
		/// Length: 30
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Transfer data area")]
		public string M3DT02 => GetString("DT02");

		/// <summary>
		/// Description: Transfer data area
		/// FieldName: DT03
		/// FieldType: A
		/// Length: 30
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Transfer data area")]
		public string M3DT03 => GetString("DT03");

		/// <summary>
		/// Description: Transfer data area
		/// FieldName: DT04
		/// FieldType: A
		/// Length: 30
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Transfer data area")]
		public string M3DT04 => GetString("DT04");

		/// <summary>
		/// Description: Transfer data area
		/// FieldName: DT05
		/// FieldType: A
		/// Length: 30
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Transfer data area")]
		public string M3DT05 => GetString("DT05");

		/// <summary>
		/// Description: Transfer data area
		/// FieldName: DT06
		/// FieldType: A
		/// Length: 30
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Transfer data area")]
		public string M3DT06 => GetString("DT06");

		/// <summary>
		/// Description: Transfer data area
		/// FieldName: DT07
		/// FieldType: A
		/// Length: 30
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Transfer data area")]
		public string M3DT07 => GetString("DT07");

		/// <summary>
		/// Description: Transfer data area
		/// FieldName: DT08
		/// FieldType: A
		/// Length: 30
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Transfer data area")]
		public string M3DT08 => GetString("DT08");

		/// <summary>
		/// Description: Transfer data area
		/// FieldName: DT09
		/// FieldType: A
		/// Length: 30
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Transfer data area")]
		public string M3DT09 => GetString("DT09");

		/// <summary>
		/// Description: Transfer data area
		/// FieldName: DT10
		/// FieldType: A
		/// Length: 30
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Transfer data area")]
		public string M3DT10 => GetString("DT10");

		/// <summary>
		/// Description: Transfer data area
		/// FieldName: DT11
		/// FieldType: A
		/// Length: 30
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Transfer data area")]
		public string M3DT11 => GetString("DT11");

		/// <summary>
		/// Description: Transfer data area
		/// FieldName: DT12
		/// FieldType: A
		/// Length: 30
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Transfer data area")]
		public string M3DT12 => GetString("DT12");

		/// <summary>
		/// Description: Transfer data area
		/// FieldName: DT13
		/// FieldType: A
		/// Length: 30
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Transfer data area")]
		public string M3DT13 => GetString("DT13");

		/// <summary>
		/// Description: Transfer data area
		/// FieldName: DT14
		/// FieldType: A
		/// Length: 30
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Transfer data area")]
		public string M3DT14 => GetString("DT14");

		/// <summary>
		/// Description: Transfer data area
		/// FieldName: DT15
		/// FieldType: A
		/// Length: 30
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Transfer data area")]
		public string M3DT15 => GetString("DT15");

		/// <summary>
		/// Description: Transfer data area
		/// FieldName: DT16
		/// FieldType: A
		/// Length: 30
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Transfer data area")]
		public string M3DT16 => GetString("DT16");

		/// <summary>
		/// Description: Table
		/// FieldName: FILE
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Table")]
		public string M3FILE => GetString("FILE");

		/// <summary>
		/// Description: Field
		/// FieldName: FLDI
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Field")]
		public string M3FLDI => GetString("FLDI");

		/// <summary>
		/// Description: Keystring exists
		/// FieldName: KSEX
		/// FieldType: A
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Keystring exists")]
		public string M3KSEX => GetString("KSEX");
	}
}
// EOF
