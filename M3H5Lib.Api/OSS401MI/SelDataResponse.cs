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

namespace M3H5Lib.Api.OSS401MI
{
	public partial class SelDataResponse : M3BaseRecord 
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
		/// Description: Dataset - statistics and budget
		/// FieldName: SBDS
		/// FieldType: A
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Dataset - statistics and budget")]
		public string M3SBDS => GetString("SBDS");

		/// <summary>
		/// Description: Transaction type
		/// FieldName: SSTT
		/// FieldType: N
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Transaction type")]
		public int? M3SSTT => GetNullableInt("SSTT");

		/// <summary>
		/// Description: Budget version
		/// FieldName: BVER
		/// FieldType: A
		/// Length: 4
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Budget version")]
		public string M3BVER => GetString("BVER");

		/// <summary>
		/// Description: Lowest level
		/// FieldName: LEVL
		/// FieldType: N
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Lowest level")]
		public int? M3LEVL => GetNullableInt("LEVL");

		/// <summary>
		/// Description: Year
		/// FieldName: YEA4
		/// FieldType: N
		/// Length: 4
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Year")]
		public int? M3YEA4 => GetNullableInt("YEA4");

		/// <summary>
		/// Description: Period
		/// FieldName: PERI
		/// FieldType: N
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Period")]
		public int? M3PERI => GetNullableInt("PERI");

		/// <summary>
		/// Description: Key
		/// FieldName: KEY1
		/// FieldType: A
		/// Length: 30
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Key")]
		public string M3KEY1 => GetString("KEY1");

		/// <summary>
		/// Description: Key
		/// FieldName: KEY2
		/// FieldType: A
		/// Length: 30
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Key")]
		public string M3KEY2 => GetString("KEY2");

		/// <summary>
		/// Description: Key
		/// FieldName: KEY3
		/// FieldType: A
		/// Length: 30
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Key")]
		public string M3KEY3 => GetString("KEY3");

		/// <summary>
		/// Description: Key
		/// FieldName: KEY4
		/// FieldType: A
		/// Length: 30
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Key")]
		public string M3KEY4 => GetString("KEY4");

		/// <summary>
		/// Description: Key
		/// FieldName: KEY5
		/// FieldType: A
		/// Length: 30
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Key")]
		public string M3KEY5 => GetString("KEY5");

		/// <summary>
		/// Description: Key
		/// FieldName: KEY6
		/// FieldType: A
		/// Length: 30
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Key")]
		public string M3KEY6 => GetString("KEY6");

		/// <summary>
		/// Description: Column
		/// FieldName: CL01
		/// FieldType: A
		/// Length: 30
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Column")]
		public string M3CL01 => GetString("CL01");

		/// <summary>
		/// Description: Column
		/// FieldName: CL02
		/// FieldType: A
		/// Length: 30
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Column")]
		public string M3CL02 => GetString("CL02");

		/// <summary>
		/// Description: Column
		/// FieldName: CL03
		/// FieldType: A
		/// Length: 30
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Column")]
		public string M3CL03 => GetString("CL03");

		/// <summary>
		/// Description: Column
		/// FieldName: CL04
		/// FieldType: A
		/// Length: 30
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Column")]
		public string M3CL04 => GetString("CL04");

		/// <summary>
		/// Description: Column
		/// FieldName: CL05
		/// FieldType: A
		/// Length: 30
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Column")]
		public string M3CL05 => GetString("CL05");

		/// <summary>
		/// Description: Column
		/// FieldName: CL06
		/// FieldType: A
		/// Length: 30
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Column")]
		public string M3CL06 => GetString("CL06");

		/// <summary>
		/// Description: Column
		/// FieldName: CL07
		/// FieldType: A
		/// Length: 30
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Column")]
		public string M3CL07 => GetString("CL07");

		/// <summary>
		/// Description: Column
		/// FieldName: CL08
		/// FieldType: A
		/// Length: 30
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Column")]
		public string M3CL08 => GetString("CL08");

		/// <summary>
		/// Description: Column
		/// FieldName: CL09
		/// FieldType: A
		/// Length: 30
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Column")]
		public string M3CL09 => GetString("CL09");

		/// <summary>
		/// Description: Column
		/// FieldName: CL10
		/// FieldType: A
		/// Length: 30
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Column")]
		public string M3CL10 => GetString("CL10");

		/// <summary>
		/// Description: Column
		/// FieldName: CL11
		/// FieldType: A
		/// Length: 30
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Column")]
		public string M3CL11 => GetString("CL11");

		/// <summary>
		/// Description: Column
		/// FieldName: CL12
		/// FieldType: A
		/// Length: 30
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Column")]
		public string M3CL12 => GetString("CL12");

		/// <summary>
		/// Description: Column
		/// FieldName: CL13
		/// FieldType: A
		/// Length: 30
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Column")]
		public string M3CL13 => GetString("CL13");

		/// <summary>
		/// Description: Column
		/// FieldName: CL14
		/// FieldType: A
		/// Length: 30
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Column")]
		public string M3CL14 => GetString("CL14");

		/// <summary>
		/// Description: Column
		/// FieldName: CL15
		/// FieldType: A
		/// Length: 30
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Column")]
		public string M3CL15 => GetString("CL15");

		/// <summary>
		/// Description: Column
		/// FieldName: CL16
		/// FieldType: A
		/// Length: 30
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Column")]
		public string M3CL16 => GetString("CL16");

		/// <summary>
		/// Description: Column
		/// FieldName: CL17
		/// FieldType: A
		/// Length: 30
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Column")]
		public string M3CL17 => GetString("CL17");

		/// <summary>
		/// Description: Column
		/// FieldName: CL18
		/// FieldType: A
		/// Length: 30
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Column")]
		public string M3CL18 => GetString("CL18");

		/// <summary>
		/// Description: Column
		/// FieldName: CL19
		/// FieldType: A
		/// Length: 30
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Column")]
		public string M3CL19 => GetString("CL19");

		/// <summary>
		/// Description: Column
		/// FieldName: CL20
		/// FieldType: A
		/// Length: 30
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Column")]
		public string M3CL20 => GetString("CL20");

		/// <summary>
		/// Description: Column
		/// FieldName: CL21
		/// FieldType: A
		/// Length: 30
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Column")]
		public string M3CL21 => GetString("CL21");

		/// <summary>
		/// Description: Column
		/// FieldName: CL22
		/// FieldType: A
		/// Length: 30
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Column")]
		public string M3CL22 => GetString("CL22");

		/// <summary>
		/// Description: Column
		/// FieldName: CL23
		/// FieldType: A
		/// Length: 30
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Column")]
		public string M3CL23 => GetString("CL23");

		/// <summary>
		/// Description: Column
		/// FieldName: CL24
		/// FieldType: A
		/// Length: 30
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Column")]
		public string M3CL24 => GetString("CL24");
	}
}
// EOF
