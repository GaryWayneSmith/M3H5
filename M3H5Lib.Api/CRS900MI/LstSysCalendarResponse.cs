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

namespace M3H5Lib.Api.CRS900MI
{
	public partial class LstSysCalendarResponse : M3BaseRecord 
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
		/// Description: Division
		/// FieldName: DIVI
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Division")]
		public string M3_DIVI => GetString("DIVI");

		/// <summary>
		/// Description: Date YYYYMMDD
		/// FieldName: YMD8
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Date YYYYMMDD")]
		public DateTime? M3_YMD8 => GetNullableDateTime("YMD8");

		/// <summary>
		/// Description: Date user defined 8
		/// FieldName: UDF8
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Date user defined 8")]
		public DateTime? M3_UDF8 => GetNullableDateTime("UDF8");

		/// <summary>
		/// Description: Date YYMMDD
		/// FieldName: YMD6
		/// FieldType: N
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Date YYMMDD")]
		public int? M3_YMD6 => GetNullableInt("YMD6");

		/// <summary>
		/// Description: Date user-defined 6
		/// FieldName: UDF6
		/// FieldType: N
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Date user-defined 6")]
		public int? M3_UDF6 => GetNullableInt("UDF6");

		/// <summary>
		/// Description: Date DDMMYY
		/// FieldName: DMY6
		/// FieldType: N
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Date DDMMYY")]
		public int? M3_DMY6 => GetNullableInt("DMY6");

		/// <summary>
		/// Description: Date MMDDYY
		/// FieldName: MDY6
		/// FieldType: N
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Date MMDDYY")]
		public int? M3_MDY6 => GetNullableInt("MDY6");

		/// <summary>
		/// Description: DAte YYWWD
		/// FieldName: YWD5
		/// FieldType: N
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("DAte YYWWD")]
		public int? M3_YWD5 => GetNullableInt("YWD5");

		/// <summary>
		/// Description: Day number YYYYNNN
		/// FieldName: CDNO
		/// FieldType: N
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Day number YYYYNNN")]
		public int? M3_CDNO => GetNullableInt("CDNO");

		/// <summary>
		/// Description: Working day serial number
		/// FieldName: WDNO
		/// FieldType: N
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Working day serial number")]
		public int? M3_WDNO => GetNullableInt("WDNO");

		/// <summary>
		/// Description: Goods receiving day
		/// FieldName: GDAY
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Goods receiving day")]
		public int? M3_GDAY => GetNullableInt("GDAY");

		/// <summary>
		/// Description: Goods receiving day serial number
		/// FieldName: GDNO
		/// FieldType: N
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Goods receiving day serial number")]
		public int? M3_GDNO => GetNullableInt("GDNO");

		/// <summary>
		/// Description: Delivery day
		/// FieldName: DDAY
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Delivery day")]
		public int? M3_DDAY => GetNullableInt("DDAY");

		/// <summary>
		/// Description: Delivery day serial number
		/// FieldName: DDNO
		/// FieldType: N
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Delivery day serial number")]
		public int? M3_DDNO => GetNullableInt("DDNO");

		/// <summary>
		/// Description: Bank day
		/// FieldName: BDAY
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Bank day")]
		public int? M3_BDAY => GetNullableInt("BDAY");

		/// <summary>
		/// Description: Bank day serial number
		/// FieldName: BDNO
		/// FieldType: N
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Bank day serial number")]
		public int? M3_BDNO => GetNullableInt("BDNO");

		/// <summary>
		/// Description: Production day
		/// FieldName: PODY
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Production day")]
		public int? M3_PODY => GetNullableInt("PODY");

		/// <summary>
		/// Description: Working day percentage
		/// FieldName: WDPC
		/// FieldType: N
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Working day percentage")]
		public int? M3_WDPC => GetNullableInt("WDPC");

		/// <summary>
		/// Description: Day number YYYYNNN
		/// FieldName: YDNO
		/// FieldType: N
		/// Length: 7
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Day number YYYYNNN")]
		public int? M3_YDNO => GetNullableInt("YDNO");

		/// <summary>
		/// Description: Period type 1
		/// FieldName: CYP1
		/// FieldType: N
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Period type 1")]
		public int? M3_CYP1 => GetNullableInt("CYP1");

		/// <summary>
		/// Description: Period type 2
		/// FieldName: CYP2
		/// FieldType: N
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Period type 2")]
		public int? M3_CYP2 => GetNullableInt("CYP2");

		/// <summary>
		/// Description: Period type 3
		/// FieldName: CYP3
		/// FieldType: N
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Period type 3")]
		public int? M3_CYP3 => GetNullableInt("CYP3");

		/// <summary>
		/// Description: Period type 4
		/// FieldName: CYP4
		/// FieldType: N
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Period type 4")]
		public int? M3_CYP4 => GetNullableInt("CYP4");

		/// <summary>
		/// Description: Period type 5
		/// FieldName: CYP5
		/// FieldType: N
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Period type 5")]
		public int? M3_CYP5 => GetNullableInt("CYP5");
	}
}
// EOF
