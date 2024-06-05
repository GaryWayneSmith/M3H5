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

namespace M3H5Lib.Api.SES400MI
{
	public partial class GetResponse : M3BaseRecord 
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
		public string M3_STAT => GetString("STAT");

		/// <summary>
		/// Description: Option 1 permitted
		/// FieldName: AL01
		/// FieldType: A
		/// Length: 9
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Option 1 permitted")]
		public string M3_AL01 => GetString("AL01");

		/// <summary>
		/// Description: Option 2 permitted
		/// FieldName: AL02
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Option 2 permitted")]
		public int? M3_AL02 => GetNullableInt("AL02");

		/// <summary>
		/// Description: Option 3 permitted
		/// FieldName: AL03
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Option 3 permitted")]
		public int? M3_AL03 => GetNullableInt("AL03");

		/// <summary>
		/// Description: Option 4 permitted
		/// FieldName: AL04
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Option 4 permitted")]
		public int? M3_AL04 => GetNullableInt("AL04");

		/// <summary>
		/// Description: Option 5 permitted
		/// FieldName: AL05
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Option 5 permitted")]
		public int? M3_AL05 => GetNullableInt("AL05");

		/// <summary>
		/// Description: Option 6 permitted
		/// FieldName: AL06
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Option 6 permitted")]
		public int? M3_AL06 => GetNullableInt("AL06");

		/// <summary>
		/// Description: Option 7 permitted
		/// FieldName: AL07
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Option 7 permitted")]
		public int? M3_AL07 => GetNullableInt("AL07");

		/// <summary>
		/// Description: Option 8 permitted
		/// FieldName: AL08
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Option 8 permitted")]
		public int? M3_AL08 => GetNullableInt("AL08");

		/// <summary>
		/// Description: Option 9 permitted
		/// FieldName: AL09
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Option 9 permitted")]
		public int? M3_AL09 => GetNullableInt("AL09");

		/// <summary>
		/// Description: Option 10 permitted
		/// FieldName: OK10
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Option 10 permitted")]
		public int? M3_OK10 => GetNullableInt("OK10");

		/// <summary>
		/// Description: Option 11 permitted
		/// FieldName: OK11
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Option 11 permitted")]
		public int? M3_OK11 => GetNullableInt("OK11");

		/// <summary>
		/// Description: Option 12 permitted
		/// FieldName: OK12
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Option 12 permitted")]
		public int? M3_OK12 => GetNullableInt("OK12");

		/// <summary>
		/// Description: Option 13 permitted
		/// FieldName: OK13
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Option 13 permitted")]
		public int? M3_OK13 => GetNullableInt("OK13");

		/// <summary>
		/// Description: Option 14 permitted
		/// FieldName: OK14
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Option 14 permitted")]
		public int? M3_OK14 => GetNullableInt("OK14");

		/// <summary>
		/// Description: Option 15 permitted
		/// FieldName: OK15
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Option 15 permitted")]
		public int? M3_OK15 => GetNullableInt("OK15");

		/// <summary>
		/// Description: Option 16 permitted
		/// FieldName: OK16
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Option 16 permitted")]
		public int? M3_OK16 => GetNullableInt("OK16");

		/// <summary>
		/// Description: Option 17 permitted
		/// FieldName: OK17
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Option 17 permitted")]
		public int? M3_OK17 => GetNullableInt("OK17");

		/// <summary>
		/// Description: Option 18 permitted
		/// FieldName: OK18
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Option 18 permitted")]
		public int? M3_OK18 => GetNullableInt("OK18");

		/// <summary>
		/// Description: Option 19 permitted
		/// FieldName: OK19
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Option 19 permitted")]
		public int? M3_OK19 => GetNullableInt("OK19");

		/// <summary>
		/// Description: Option 20 permitted
		/// FieldName: OK20
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Option 20 permitted")]
		public int? M3_OK20 => GetNullableInt("OK20");

		/// <summary>
		/// Description: Option 21 permitted
		/// FieldName: OK21
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Option 21 permitted")]
		public int? M3_OK21 => GetNullableInt("OK21");

		/// <summary>
		/// Description: Option 22 permitted
		/// FieldName: OK22
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Option 22 permitted")]
		public int? M3_OK22 => GetNullableInt("OK22");

		/// <summary>
		/// Description: Option 23 permitted
		/// FieldName: OK23
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Option 23 permitted")]
		public int? M3_OK23 => GetNullableInt("OK23");

		/// <summary>
		/// Description: Option 24 permitted
		/// FieldName: OK24
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Option 24 permitted")]
		public int? M3_OK24 => GetNullableInt("OK24");

		/// <summary>
		/// Description: Option 25 permitted
		/// FieldName: OK25
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Option 25 permitted")]
		public int? M3_OK25 => GetNullableInt("OK25");

		/// <summary>
		/// Description: Option 26 permitted
		/// FieldName: OK26
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Option 26 permitted")]
		public int? M3_OK26 => GetNullableInt("OK26");

		/// <summary>
		/// Description: Option 27 permitted
		/// FieldName: OK27
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Option 27 permitted")]
		public int? M3_OK27 => GetNullableInt("OK27");

		/// <summary>
		/// Description: Option 28 permitted
		/// FieldName: OK28
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Option 28 permitted")]
		public int? M3_OK28 => GetNullableInt("OK28");

		/// <summary>
		/// Description: Option 29 permitted
		/// FieldName: OK29
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Option 29 permitted")]
		public int? M3_OK29 => GetNullableInt("OK29");

		/// <summary>
		/// Description: Option 30 permitted
		/// FieldName: OK30
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Option 30 permitted")]
		public int? M3_OK30 => GetNullableInt("OK30");

		/// <summary>
		/// Description: Option 31 permitted
		/// FieldName: OK31
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Option 31 permitted")]
		public int? M3_OK31 => GetNullableInt("OK31");

		/// <summary>
		/// Description: Option 32 permitted
		/// FieldName: OK32
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Option 32 permitted")]
		public int? M3_OK32 => GetNullableInt("OK32");

		/// <summary>
		/// Description: Option 33 permitted
		/// FieldName: OK33
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Option 33 permitted")]
		public int? M3_OK33 => GetNullableInt("OK33");

		/// <summary>
		/// Description: Option 34 permitted
		/// FieldName: OK34
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Option 34 permitted")]
		public int? M3_OK34 => GetNullableInt("OK34");

		/// <summary>
		/// Description: Option 35 permitted
		/// FieldName: OK35
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Option 35 permitted")]
		public int? M3_OK35 => GetNullableInt("OK35");

		/// <summary>
		/// Description: Option 36 permitted
		/// FieldName: OK36
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Option 36 permitted")]
		public int? M3_OK36 => GetNullableInt("OK36");

		/// <summary>
		/// Description: Option 37 permitted
		/// FieldName: OK37
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Option 37 permitted")]
		public int? M3_OK37 => GetNullableInt("OK37");

		/// <summary>
		/// Description: Option 38 permitted
		/// FieldName: OK38
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Option 38 permitted")]
		public int? M3_OK38 => GetNullableInt("OK38");

		/// <summary>
		/// Description: Option 39 permitted
		/// FieldName: OK39
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Option 39 permitted")]
		public int? M3_OK39 => GetNullableInt("OK39");

		/// <summary>
		/// Description: Option 40 permitted
		/// FieldName: OK40
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Option 40 permitted")]
		public int? M3_OK40 => GetNullableInt("OK40");

		/// <summary>
		/// Description: Option 41 permitted
		/// FieldName: OK41
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Option 41 permitted")]
		public int? M3_OK41 => GetNullableInt("OK41");

		/// <summary>
		/// Description: Option 42 permitted
		/// FieldName: OK42
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Option 42 permitted")]
		public int? M3_OK42 => GetNullableInt("OK42");

		/// <summary>
		/// Description: Option 43 permitted
		/// FieldName: OK43
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Option 43 permitted")]
		public int? M3_OK43 => GetNullableInt("OK43");

		/// <summary>
		/// Description: Option 44 permitted
		/// FieldName: OK44
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Option 44 permitted")]
		public int? M3_OK44 => GetNullableInt("OK44");

		/// <summary>
		/// Description: Option 45 permitted
		/// FieldName: OK45
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Option 45 permitted")]
		public int? M3_OK45 => GetNullableInt("OK45");

		/// <summary>
		/// Description: Option 46 permitted
		/// FieldName: OK46
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Option 46 permitted")]
		public int? M3_OK46 => GetNullableInt("OK46");

		/// <summary>
		/// Description: Option 47 permitted
		/// FieldName: OK47
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Option 47 permitted")]
		public int? M3_OK47 => GetNullableInt("OK47");

		/// <summary>
		/// Description: Option 48 permitted
		/// FieldName: OK48
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Option 48 permitted")]
		public int? M3_OK48 => GetNullableInt("OK48");

		/// <summary>
		/// Description: Option 49 permitted
		/// FieldName: OK49
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Option 49 permitted")]
		public int? M3_OK49 => GetNullableInt("OK49");

		/// <summary>
		/// Description: Option 50 permitted
		/// FieldName: OK50
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Option 50 permitted")]
		public int? M3_OK50 => GetNullableInt("OK50");

		/// <summary>
		/// Description: Option 51 permitted
		/// FieldName: OK51
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Option 51 permitted")]
		public int? M3_OK51 => GetNullableInt("OK51");

		/// <summary>
		/// Description: Option 52 permitted
		/// FieldName: OK52
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Option 52 permitted")]
		public int? M3_OK52 => GetNullableInt("OK52");

		/// <summary>
		/// Description: Option 53 permitted
		/// FieldName: OK53
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Option 53 permitted")]
		public int? M3_OK53 => GetNullableInt("OK53");

		/// <summary>
		/// Description: Option 54 permitted
		/// FieldName: OK54
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Option 54 permitted")]
		public int? M3_OK54 => GetNullableInt("OK54");

		/// <summary>
		/// Description: Option 55 permitted
		/// FieldName: OK55
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Option 55 permitted")]
		public int? M3_OK55 => GetNullableInt("OK55");

		/// <summary>
		/// Description: Option 56 permitted
		/// FieldName: OK56
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Option 56 permitted")]
		public int? M3_OK56 => GetNullableInt("OK56");

		/// <summary>
		/// Description: Option 57 permitted
		/// FieldName: OK57
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Option 57 permitted")]
		public int? M3_OK57 => GetNullableInt("OK57");

		/// <summary>
		/// Description: Option 58 permitted
		/// FieldName: OK58
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Option 58 permitted")]
		public int? M3_OK58 => GetNullableInt("OK58");

		/// <summary>
		/// Description: Option 59 permitted
		/// FieldName: OK59
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Option 59 permitted")]
		public int? M3_OK59 => GetNullableInt("OK59");

		/// <summary>
		/// Description: Option 60 permitted
		/// FieldName: OK60
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Option 60 permitted")]
		public int? M3_OK60 => GetNullableInt("OK60");

		/// <summary>
		/// Description: Option 61 permitted
		/// FieldName: OK61
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Option 61 permitted")]
		public int? M3_OK61 => GetNullableInt("OK61");

		/// <summary>
		/// Description: Option 62 permitted
		/// FieldName: OK62
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Option 62 permitted")]
		public int? M3_OK62 => GetNullableInt("OK62");

		/// <summary>
		/// Description: Option 63 permitted
		/// FieldName: OK63
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Option 63 permitted")]
		public int? M3_OK63 => GetNullableInt("OK63");

		/// <summary>
		/// Description: Option 64 permitted
		/// FieldName: OK64
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Option 64 permitted")]
		public int? M3_OK64 => GetNullableInt("OK64");

		/// <summary>
		/// Description: Option 65 permitted
		/// FieldName: OK65
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Option 65 permitted")]
		public int? M3_OK65 => GetNullableInt("OK65");

		/// <summary>
		/// Description: Option 66 permitted
		/// FieldName: OK66
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Option 66 permitted")]
		public int? M3_OK66 => GetNullableInt("OK66");

		/// <summary>
		/// Description: Option 67 permitted
		/// FieldName: OK67
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Option 67 permitted")]
		public int? M3_OK67 => GetNullableInt("OK67");

		/// <summary>
		/// Description: Option 68 permitted
		/// FieldName: OK68
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Option 68 permitted")]
		public int? M3_OK68 => GetNullableInt("OK68");

		/// <summary>
		/// Description: Option 69 permitted
		/// FieldName: OK69
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Option 69 permitted")]
		public int? M3_OK69 => GetNullableInt("OK69");

		/// <summary>
		/// Description: Option 70 permitted
		/// FieldName: OK70
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Option 70 permitted")]
		public int? M3_OK70 => GetNullableInt("OK70");

		/// <summary>
		/// Description: Option 71 permitted
		/// FieldName: OK71
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Option 71 permitted")]
		public int? M3_OK71 => GetNullableInt("OK71");

		/// <summary>
		/// Description: Option 72 permitted
		/// FieldName: OK72
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Option 72 permitted")]
		public int? M3_OK72 => GetNullableInt("OK72");

		/// <summary>
		/// Description: Option 73 permitted
		/// FieldName: OK73
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Option 73 permitted")]
		public int? M3_OK73 => GetNullableInt("OK73");

		/// <summary>
		/// Description: Option 74 permitted
		/// FieldName: OK74
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Option 74 permitted")]
		public int? M3_OK74 => GetNullableInt("OK74");

		/// <summary>
		/// Description: Option 75 permitted
		/// FieldName: OK75
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Option 75 permitted")]
		public int? M3_OK75 => GetNullableInt("OK75");

		/// <summary>
		/// Description: Option 76 permitted
		/// FieldName: OK76
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Option 76 permitted")]
		public int? M3_OK76 => GetNullableInt("OK76");

		/// <summary>
		/// Description: Option 77 permitted
		/// FieldName: OK77
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Option 77 permitted")]
		public int? M3_OK77 => GetNullableInt("OK77");

		/// <summary>
		/// Description: Option 78 permitted
		/// FieldName: OK78
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Option 78 permitted")]
		public int? M3_OK78 => GetNullableInt("OK78");

		/// <summary>
		/// Description: Option 79 permitted
		/// FieldName: OK79
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Option 79 permitted")]
		public int? M3_OK79 => GetNullableInt("OK79");

		/// <summary>
		/// Description: Option 80 permitted
		/// FieldName: OK80
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Option 80 permitted")]
		public int? M3_OK80 => GetNullableInt("OK80");

		/// <summary>
		/// Description: Option 81 permitted
		/// FieldName: OK81
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Option 81 permitted")]
		public int? M3_OK81 => GetNullableInt("OK81");

		/// <summary>
		/// Description: Option 82 permitted
		/// FieldName: OK82
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Option 82 permitted")]
		public int? M3_OK82 => GetNullableInt("OK82");

		/// <summary>
		/// Description: Option 83 permitted
		/// FieldName: OK83
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Option 83 permitted")]
		public int? M3_OK83 => GetNullableInt("OK83");

		/// <summary>
		/// Description: Option 84 permitted
		/// FieldName: OK84
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Option 84 permitted")]
		public int? M3_OK84 => GetNullableInt("OK84");

		/// <summary>
		/// Description: Option 85 permitted
		/// FieldName: OK85
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Option 85 permitted")]
		public int? M3_OK85 => GetNullableInt("OK85");

		/// <summary>
		/// Description: Option 86 permitted
		/// FieldName: OK86
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Option 86 permitted")]
		public int? M3_OK86 => GetNullableInt("OK86");

		/// <summary>
		/// Description: Option 87 permitted
		/// FieldName: OK87
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Option 87 permitted")]
		public int? M3_OK87 => GetNullableInt("OK87");

		/// <summary>
		/// Description: Option 88 permitted
		/// FieldName: OK88
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Option 88 permitted")]
		public int? M3_OK88 => GetNullableInt("OK88");

		/// <summary>
		/// Description: Option 89 permitted
		/// FieldName: OK89
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Option 89 permitted")]
		public int? M3_OK89 => GetNullableInt("OK89");

		/// <summary>
		/// Description: Option 90 permitted
		/// FieldName: OK90
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Option 90 permitted")]
		public int? M3_OK90 => GetNullableInt("OK90");

		/// <summary>
		/// Description: Option 91 permitted
		/// FieldName: OK91
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Option 91 permitted")]
		public int? M3_OK91 => GetNullableInt("OK91");

		/// <summary>
		/// Description: Option 92 permitted
		/// FieldName: OK92
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Option 92 permitted")]
		public int? M3_OK92 => GetNullableInt("OK92");

		/// <summary>
		/// Description: Option 93 permitted
		/// FieldName: OK93
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Option 93 permitted")]
		public int? M3_OK93 => GetNullableInt("OK93");

		/// <summary>
		/// Description: Option 94 permitted
		/// FieldName: OK94
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Option 94 permitted")]
		public int? M3_OK94 => GetNullableInt("OK94");

		/// <summary>
		/// Description: Option 95 permitted
		/// FieldName: OK95
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Option 95 permitted")]
		public int? M3_OK95 => GetNullableInt("OK95");

		/// <summary>
		/// Description: Option 96 permitted
		/// FieldName: OK96
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Option 96 permitted")]
		public int? M3_OK96 => GetNullableInt("OK96");

		/// <summary>
		/// Description: Option 97 permitted
		/// FieldName: OK97
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Option 97 permitted")]
		public int? M3_OK97 => GetNullableInt("OK97");

		/// <summary>
		/// Description: Option 98 permitted
		/// FieldName: OK98
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Option 98 permitted")]
		public int? M3_OK98 => GetNullableInt("OK98");

		/// <summary>
		/// Description: Option 99 permitted
		/// FieldName: OK99
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Option 99 permitted")]
		public int? M3_OK99 => GetNullableInt("OK99");

		/// <summary>
		/// Description: Function key F1 permitted
		/// FieldName: KK01
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Function key F1 permitted")]
		public int? M3_KK01 => GetNullableInt("KK01");

		/// <summary>
		/// Description: Function key F2 permitted
		/// FieldName: KK02
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Function key F2 permitted")]
		public int? M3_KK02 => GetNullableInt("KK02");

		/// <summary>
		/// Description: Function key F3 permitted
		/// FieldName: KK03
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Function key F3 permitted")]
		public int? M3_KK03 => GetNullableInt("KK03");

		/// <summary>
		/// Description: Function key F4 permitted
		/// FieldName: KK04
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Function key F4 permitted")]
		public int? M3_KK04 => GetNullableInt("KK04");

		/// <summary>
		/// Description: Function key F5 permitted
		/// FieldName: KK05
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Function key F5 permitted")]
		public int? M3_KK05 => GetNullableInt("KK05");

		/// <summary>
		/// Description: Function key F6 permitted
		/// FieldName: KK06
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Function key F6 permitted")]
		public int? M3_KK06 => GetNullableInt("KK06");

		/// <summary>
		/// Description: Function key F7 permitted
		/// FieldName: KK07
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Function key F7 permitted")]
		public int? M3_KK07 => GetNullableInt("KK07");

		/// <summary>
		/// Description: Function key F8 permitted
		/// FieldName: KK08
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Function key F8 permitted")]
		public int? M3_KK08 => GetNullableInt("KK08");

		/// <summary>
		/// Description: Function key F9 permitted
		/// FieldName: KK09
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Function key F9 permitted")]
		public int? M3_KK09 => GetNullableInt("KK09");

		/// <summary>
		/// Description: Function key F10 permitted
		/// FieldName: KK10
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Function key F10 permitted")]
		public int? M3_KK10 => GetNullableInt("KK10");

		/// <summary>
		/// Description: Function key F11 permitted
		/// FieldName: KK11
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Function key F11 permitted")]
		public int? M3_KK11 => GetNullableInt("KK11");

		/// <summary>
		/// Description: Function key F12 permitted
		/// FieldName: KK12
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Function key F12 permitted")]
		public int? M3_KK12 => GetNullableInt("KK12");

		/// <summary>
		/// Description: Function key F13 permitted
		/// FieldName: KK13
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Function key F13 permitted")]
		public int? M3_KK13 => GetNullableInt("KK13");

		/// <summary>
		/// Description: Function key F14 permitted
		/// FieldName: KK14
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Function key F14 permitted")]
		public int? M3_KK14 => GetNullableInt("KK14");

		/// <summary>
		/// Description: Function key F15 permitted
		/// FieldName: KK15
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Function key F15 permitted")]
		public int? M3_KK15 => GetNullableInt("KK15");

		/// <summary>
		/// Description: Function key F16 permitted
		/// FieldName: KK16
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Function key F16 permitted")]
		public int? M3_KK16 => GetNullableInt("KK16");

		/// <summary>
		/// Description: Function key F17 permitted
		/// FieldName: KK17
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Function key F17 permitted")]
		public int? M3_KK17 => GetNullableInt("KK17");

		/// <summary>
		/// Description: Function key F18 permitted
		/// FieldName: KK18
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Function key F18 permitted")]
		public int? M3_KK18 => GetNullableInt("KK18");

		/// <summary>
		/// Description: Function key F19 permitted
		/// FieldName: KK19
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Function key F19 permitted")]
		public int? M3_KK19 => GetNullableInt("KK19");

		/// <summary>
		/// Description: Function key F20 permitted
		/// FieldName: KK20
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Function key F20 permitted")]
		public int? M3_KK20 => GetNullableInt("KK20");

		/// <summary>
		/// Description: Function key F21 permitted
		/// FieldName: KK21
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Function key F21 permitted")]
		public int? M3_KK21 => GetNullableInt("KK21");

		/// <summary>
		/// Description: Function key F22 permitted
		/// FieldName: KK22
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Function key F22 permitted")]
		public int? M3_KK22 => GetNullableInt("KK22");

		/// <summary>
		/// Description: Function key F23 permitted
		/// FieldName: KK23
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Function key F23 permitted")]
		public int? M3_KK23 => GetNullableInt("KK23");

		/// <summary>
		/// Description: Function key F24 permitted
		/// FieldName: KK24
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Function key F24 permitted")]
		public int? M3_KK24 => GetNullableInt("KK24");

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
	}
}
// EOF
