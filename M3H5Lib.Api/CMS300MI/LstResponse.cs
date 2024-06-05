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

namespace M3H5Lib.Api.CMS300MI
{
	public partial class LstResponse : M3BaseRecord 
	{

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
		/// Description: Event sequence number
		/// FieldName: EVNR
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Event sequence number")]
		public decimal? M3_EVNR => GetNullableDecimal("EVNR");

		/// <summary>
		/// Description: Primary key 1
		/// FieldName: PK01
		/// FieldType: A
		/// Length: 30
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Primary key 1")]
		public string M3_PK01 => GetString("PK01");

		/// <summary>
		/// Description: Primary key 2
		/// FieldName: PK02
		/// FieldType: A
		/// Length: 30
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Primary key 2")]
		public string M3_PK02 => GetString("PK02");

		/// <summary>
		/// Description: Primary key 3
		/// FieldName: PK03
		/// FieldType: A
		/// Length: 30
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Primary key 3")]
		public string M3_PK03 => GetString("PK03");

		/// <summary>
		/// Description: Primary key 4
		/// FieldName: PK04
		/// FieldType: A
		/// Length: 30
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Primary key 4")]
		public string M3_PK04 => GetString("PK04");

		/// <summary>
		/// Description: Primary key 5
		/// FieldName: PK05
		/// FieldType: A
		/// Length: 30
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Primary key 5")]
		public string M3_PK05 => GetString("PK05");

		/// <summary>
		/// Description: Primary key 6
		/// FieldName: PK06
		/// FieldType: A
		/// Length: 30
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Primary key 6")]
		public string M3_PK06 => GetString("PK06");

		/// <summary>
		/// Description: Primary key 7
		/// FieldName: PK07
		/// FieldType: A
		/// Length: 30
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Primary key 7")]
		public string M3_PK07 => GetString("PK07");

		/// <summary>
		/// Description: Primary key 8
		/// FieldName: PK08
		/// FieldType: A
		/// Length: 30
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Primary key 8")]
		public string M3_PK08 => GetString("PK08");

		/// <summary>
		/// Description: Primary key 9
		/// FieldName: PK09
		/// FieldType: A
		/// Length: 30
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Primary key 9")]
		public string M3_PK09 => GetString("PK09");

		/// <summary>
		/// Description: Primary key 10
		/// FieldName: PK10
		/// FieldType: A
		/// Length: 30
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Primary key 10")]
		public string M3_PK10 => GetString("PK10");

		/// <summary>
		/// Description: Primary key 11
		/// FieldName: PK11
		/// FieldType: A
		/// Length: 30
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Primary key 11")]
		public string M3_PK11 => GetString("PK11");

		/// <summary>
		/// Description: Primary key 12
		/// FieldName: PK12
		/// FieldType: A
		/// Length: 30
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Primary key 12")]
		public string M3_PK12 => GetString("PK12");

		/// <summary>
		/// Description: Primary key 13
		/// FieldName: PK13
		/// FieldType: A
		/// Length: 30
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Primary key 13")]
		public string M3_PK13 => GetString("PK13");

		/// <summary>
		/// Description: Primary key 14
		/// FieldName: PK14
		/// FieldType: A
		/// Length: 30
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Primary key 14")]
		public string M3_PK14 => GetString("PK14");

		/// <summary>
		/// Description: Primary key 15
		/// FieldName: PK15
		/// FieldType: A
		/// Length: 30
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Primary key 15")]
		public string M3_PK15 => GetString("PK15");

		/// <summary>
		/// Description: Old value
		/// FieldName: OV80
		/// FieldType: A
		/// Length: 80
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Old value")]
		public string M3_OV80 => GetString("OV80");

		/// <summary>
		/// Description: New value
		/// FieldName: NV80
		/// FieldType: A
		/// Length: 80
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("New value")]
		public string M3_NV80 => GetString("NV80");

		/// <summary>
		/// Description: Updating date
		/// FieldName: UPDT
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Updating date")]
		public DateTime? M3_UPDT => GetNullableDateTime("UPDT");

		/// <summary>
		/// Description: Date printed
		/// FieldName: DTPR
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Date printed")]
		public DateTime? M3_DTPR => GetNullableDateTime("DTPR");

		/// <summary>
		/// Description: Updating program
		/// FieldName: UPGM
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Updating program")]
		public string M3_UPGM => GetString("UPGM");

		/// <summary>
		/// Description: Start program
		/// FieldName: SPGM
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Start program")]
		public string M3_SPGM => GetString("SPGM");

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
		/// Description: Time suffix
		/// FieldName: TMSX
		/// FieldType: N
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Time suffix")]
		public int? M3_TMSX => GetNullableInt("TMSX");
	}
}
// EOF
