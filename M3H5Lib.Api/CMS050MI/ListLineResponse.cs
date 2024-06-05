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

namespace M3H5Lib.Api.CMS050MI
{
	public partial class ListLineResponse : M3BaseRecord 
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
		/// Description: Actionlog number
		/// FieldName: LONO
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Actionlog number")]
		public string M3_LONO => GetString("LONO");

		/// <summary>
		/// Description: Action squence number
		/// FieldName: ACTN
		/// FieldType: N
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Action squence number")]
		public int? M3_ACTN => GetNullableInt("ACTN");

		/// <summary>
		/// Description: Action type
		/// FieldName: ACT0
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Action type")]
		public string M3_ACT0 => GetString("ACT0");

		/// <summary>
		/// Description: Decision date
		/// FieldName: DEDT
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Decision date")]
		public DateTime? M3_DEDT => GetNullableDateTime("DEDT");

		/// <summary>
		/// Description: Decision time
		/// FieldName: DECT
		/// FieldType: N
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Decision time")]
		public int? M3_DECT => GetNullableInt("DECT");

		/// <summary>
		/// Description: Time suffix
		/// FieldName: TMSX
		/// FieldType: N
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Time suffix")]
		public int? M3_TMSX => GetNullableInt("TMSX");

		/// <summary>
		/// Description: Action group
		/// FieldName: ACTG
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Action group")]
		public string M3_ACTG => GetString("ACTG");

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
		/// Description: Action status
		/// FieldName: ACST
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Action status")]
		public string M3_ACST => GetString("ACST");

		/// <summary>
		/// Description: Implementation method
		/// FieldName: IMPM
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Implementation method")]
		public int? M3_IMPM => GetNullableInt("IMPM");

		/// <summary>
		/// Description: Implementation date
		/// FieldName: IMPD
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Implementation date")]
		public DateTime? M3_IMPD => GetNullableDateTime("IMPD");

		/// <summary>
		/// Description: Implementation time
		/// FieldName: IMPT
		/// FieldType: N
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Implementation time")]
		public int? M3_IMPT => GetNullableInt("IMPT");

		/// <summary>
		/// Description: Implemented by
		/// FieldName: IMPB
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Implemented by")]
		public string M3_IMPB => GetString("IMPB");

		/// <summary>
		/// Description: Return data
		/// FieldName: RTDA
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Return data")]
		public string M3_RTDA => GetString("RTDA");

		/// <summary>
		/// Description: Key/result1
		/// FieldName: KR01
		/// FieldType: A
		/// Length: 20
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Key/result1")]
		public string M3_KR01 => GetString("KR01");

		/// <summary>
		/// Description: Key/result2
		/// FieldName: KR02
		/// FieldType: A
		/// Length: 20
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Key/result2")]
		public string M3_KR02 => GetString("KR02");

		/// <summary>
		/// Description: Key/result3
		/// FieldName: KR03
		/// FieldType: A
		/// Length: 20
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Key/result3")]
		public string M3_KR03 => GetString("KR03");

		/// <summary>
		/// Description: Key/result4
		/// FieldName: KR04
		/// FieldType: A
		/// Length: 20
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Key/result4")]
		public string M3_KR04 => GetString("KR04");

		/// <summary>
		/// Description: Key/result5
		/// FieldName: KR05
		/// FieldType: A
		/// Length: 20
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Key/result5")]
		public string M3_KR05 => GetString("KR05");

		/// <summary>
		/// Description: Key/result6
		/// FieldName: KR06
		/// FieldType: A
		/// Length: 20
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Key/result6")]
		public string M3_KR06 => GetString("KR06");

		/// <summary>
		/// Description: Key/result7
		/// FieldName: KR07
		/// FieldType: A
		/// Length: 20
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Key/result7")]
		public string M3_KR07 => GetString("KR07");

		/// <summary>
		/// Description: Key/result8
		/// FieldName: KR08
		/// FieldType: A
		/// Length: 20
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Key/result8")]
		public string M3_KR08 => GetString("KR08");

		/// <summary>
		/// Description: Key/result9
		/// FieldName: KR09
		/// FieldType: A
		/// Length: 20
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Key/result9")]
		public string M3_KR09 => GetString("KR09");

		/// <summary>
		/// Description: Key/result10
		/// FieldName: KR10
		/// FieldType: A
		/// Length: 20
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Key/result10")]
		public string M3_KR10 => GetString("KR10");

		/// <summary>
		/// Description: Key/result11
		/// FieldName: KR11
		/// FieldType: A
		/// Length: 20
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Key/result11")]
		public string M3_KR11 => GetString("KR11");

		/// <summary>
		/// Description: Key/result12
		/// FieldName: KR12
		/// FieldType: A
		/// Length: 20
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Key/result12")]
		public string M3_KR12 => GetString("KR12");

		/// <summary>
		/// Description: Key/result13
		/// FieldName: KR13
		/// FieldType: A
		/// Length: 20
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Key/result13")]
		public string M3_KR13 => GetString("KR13");

		/// <summary>
		/// Description: Key/result14
		/// FieldName: KR14
		/// FieldType: A
		/// Length: 20
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Key/result14")]
		public string M3_KR14 => GetString("KR14");

		/// <summary>
		/// Description: Key/result15
		/// FieldName: KR15
		/// FieldType: A
		/// Length: 20
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Key/result15")]
		public string M3_KR15 => GetString("KR15");

		/// <summary>
		/// Description: Key/result16
		/// FieldName: KR16
		/// FieldType: A
		/// Length: 20
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Key/result16")]
		public string M3_KR16 => GetString("KR16");

		/// <summary>
		/// Description: Key/result17
		/// FieldName: KR17
		/// FieldType: A
		/// Length: 20
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Key/result17")]
		public string M3_KR17 => GetString("KR17");

		/// <summary>
		/// Description: Key/result18
		/// FieldName: KR18
		/// FieldType: A
		/// Length: 20
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Key/result18")]
		public string M3_KR18 => GetString("KR18");

		/// <summary>
		/// Description: Key/result19
		/// FieldName: KR19
		/// FieldType: A
		/// Length: 20
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Key/result19")]
		public string M3_KR19 => GetString("KR19");

		/// <summary>
		/// Description: Key/result20
		/// FieldName: KR20
		/// FieldType: A
		/// Length: 20
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Key/result20")]
		public string M3_KR20 => GetString("KR20");

		/// <summary>
		/// Description: Key/result21
		/// FieldName: KR21
		/// FieldType: A
		/// Length: 20
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Key/result21")]
		public string M3_KR21 => GetString("KR21");

		/// <summary>
		/// Description: Key/result22
		/// FieldName: KR22
		/// FieldType: A
		/// Length: 20
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Key/result22")]
		public string M3_KR22 => GetString("KR22");

		/// <summary>
		/// Description: Key/result23
		/// FieldName: KR23
		/// FieldType: A
		/// Length: 20
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Key/result23")]
		public string M3_KR23 => GetString("KR23");

		/// <summary>
		/// Description: Key/result24
		/// FieldName: KR24
		/// FieldType: A
		/// Length: 20
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Key/result24")]
		public string M3_KR24 => GetString("KR24");

		/// <summary>
		/// Description: Key/result25
		/// FieldName: KR25
		/// FieldType: A
		/// Length: 20
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Key/result25")]
		public string M3_KR25 => GetString("KR25");

		/// <summary>
		/// Description: Key/result26
		/// FieldName: KR26
		/// FieldType: A
		/// Length: 20
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Key/result26")]
		public string M3_KR26 => GetString("KR26");

		/// <summary>
		/// Description: Key/result27
		/// FieldName: KR27
		/// FieldType: A
		/// Length: 20
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Key/result27")]
		public string M3_KR27 => GetString("KR27");

		/// <summary>
		/// Description: Key/result28
		/// FieldName: KR28
		/// FieldType: A
		/// Length: 20
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Key/result28")]
		public string M3_KR28 => GetString("KR28");

		/// <summary>
		/// Description: Key/result29
		/// FieldName: KR29
		/// FieldType: A
		/// Length: 20
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Key/result29")]
		public string M3_KR29 => GetString("KR29");

		/// <summary>
		/// Description: Key/result30
		/// FieldName: KR30
		/// FieldType: A
		/// Length: 20
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Key/result30")]
		public string M3_KR30 => GetString("KR30");

		/// <summary>
		/// Description: Key/result31
		/// FieldName: KR31
		/// FieldType: A
		/// Length: 20
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Key/result31")]
		public string M3_KR31 => GetString("KR31");

		/// <summary>
		/// Description: Key/result32
		/// FieldName: KR32
		/// FieldType: A
		/// Length: 20
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Key/result32")]
		public string M3_KR32 => GetString("KR32");

		/// <summary>
		/// Description: Key/result33
		/// FieldName: KR33
		/// FieldType: A
		/// Length: 20
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Key/result33")]
		public string M3_KR33 => GetString("KR33");

		/// <summary>
		/// Description: Key/result34
		/// FieldName: KR34
		/// FieldType: A
		/// Length: 20
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Key/result34")]
		public string M3_KR34 => GetString("KR34");

		/// <summary>
		/// Description: Key/result35
		/// FieldName: KR35
		/// FieldType: A
		/// Length: 20
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Key/result35")]
		public string M3_KR35 => GetString("KR35");

		/// <summary>
		/// Description: Key/result36
		/// FieldName: KR36
		/// FieldType: A
		/// Length: 20
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Key/result36")]
		public string M3_KR36 => GetString("KR36");

		/// <summary>
		/// Description: Key/result37
		/// FieldName: KR37
		/// FieldType: A
		/// Length: 20
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Key/result37")]
		public string M3_KR37 => GetString("KR37");

		/// <summary>
		/// Description: Key/result38
		/// FieldName: KR38
		/// FieldType: A
		/// Length: 20
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Key/result38")]
		public string M3_KR38 => GetString("KR38");

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
		/// Description: Decision type
		/// FieldName: DCTP
		/// FieldType: A
		/// Length: 8
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Decision type")]
		public string M3_DCTP => GetString("DCTP");

		/// <summary>
		/// Description: Decision reference
		/// FieldName: DCRF
		/// FieldType: N
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Decision reference")]
		public int? M3_DCRF => GetNullableInt("DCRF");

		/// <summary>
		/// Description: Decision reference type
		/// FieldName: DCRT
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Decision reference type")]
		public int? M3_DCRT => GetNullableInt("DCRT");

		/// <summary>
		/// Description: Responsible header
		/// FieldName: RES2
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Responsible header")]
		public string M3_RES2 => GetString("RES2");

		/// <summary>
		/// Description: Role
		/// FieldName: ROLE
		/// FieldType: A
		/// Length: 20
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Role")]
		public string M3_ROLE => GetString("ROLE");
	}
}
// EOF
