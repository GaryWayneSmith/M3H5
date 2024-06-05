/// **********************************************************************
/// This class is auto-generated.
/// Updated: 6/5/2024 3:52:20 PM
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

namespace M3H5Lib.Api.CMS011MI
{
	public partial class GetRelatedTableResponse : M3BaseRecord 
	{

		/// <summary>
		/// Description: Information browser category
		/// FieldName: IBCA
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Information browser category")]
		public string M3IBCA => GetString("IBCA");

		/// <summary>
		/// Description: File
		/// FieldName: FILE
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("File")]
		public string M3FILE => GetString("FILE");

		/// <summary>
		/// Description: Field prefix
		/// FieldName: FIPX
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Field prefix")]
		public string M3FIPX => GetString("FIPX");

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
		/// Description: Field
		/// FieldName: OB01
		/// FieldType: A
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Field")]
		public string M3OB01 => GetString("OB01");

		/// <summary>
		/// Description: Field
		/// FieldName: OB02
		/// FieldType: A
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Field")]
		public string M3OB02 => GetString("OB02");

		/// <summary>
		/// Description: Field
		/// FieldName: OB03
		/// FieldType: A
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Field")]
		public string M3OB03 => GetString("OB03");

		/// <summary>
		/// Description: Field
		/// FieldName: OB04
		/// FieldType: A
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Field")]
		public string M3OB04 => GetString("OB04");

		/// <summary>
		/// Description: Field
		/// FieldName: OB05
		/// FieldType: A
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Field")]
		public string M3OB05 => GetString("OB05");

		/// <summary>
		/// Description: Field
		/// FieldName: OB06
		/// FieldType: A
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Field")]
		public string M3OB06 => GetString("OB06");

		/// <summary>
		/// Description: Field
		/// FieldName: OB07
		/// FieldType: A
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Field")]
		public string M3OB07 => GetString("OB07");

		/// <summary>
		/// Description: Field
		/// FieldName: OB08
		/// FieldType: A
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Field")]
		public string M3OB08 => GetString("OB08");

		/// <summary>
		/// Description: Field
		/// FieldName: OB09
		/// FieldType: A
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Field")]
		public string M3OB09 => GetString("OB09");

		/// <summary>
		/// Description: Field
		/// FieldName: OB10
		/// FieldType: A
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Field")]
		public string M3OB10 => GetString("OB10");

		/// <summary>
		/// Description: Field
		/// FieldName: OB11
		/// FieldType: A
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Field")]
		public string M3OB11 => GetString("OB11");

		/// <summary>
		/// Description: Field
		/// FieldName: OB12
		/// FieldType: A
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Field")]
		public string M3OB12 => GetString("OB12");

		/// <summary>
		/// Description: Field
		/// FieldName: OB13
		/// FieldType: A
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Field")]
		public string M3OB13 => GetString("OB13");

		/// <summary>
		/// Description: Field
		/// FieldName: OB14
		/// FieldType: A
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Field")]
		public string M3OB14 => GetString("OB14");

		/// <summary>
		/// Description: Field
		/// FieldName: OB15
		/// FieldType: A
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Field")]
		public string M3OB15 => GetString("OB15");

		/// <summary>
		/// Description: Field
		/// FieldName: OB16
		/// FieldType: A
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Field")]
		public string M3OB16 => GetString("OB16");

		/// <summary>
		/// Description: Key field
		/// FieldName: KEY1
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Key field")]
		public string M3KEY1 => GetString("KEY1");

		/// <summary>
		/// Description: Key field
		/// FieldName: KEY2
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Key field")]
		public string M3KEY2 => GetString("KEY2");

		/// <summary>
		/// Description: Key field
		/// FieldName: KEY3
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Key field")]
		public string M3KEY3 => GetString("KEY3");

		/// <summary>
		/// Description: Key field
		/// FieldName: KEY4
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Key field")]
		public string M3KEY4 => GetString("KEY4");

		/// <summary>
		/// Description: Key field
		/// FieldName: KEY5
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Key field")]
		public string M3KEY5 => GetString("KEY5");

		/// <summary>
		/// Description: Key field
		/// FieldName: KEY6
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Key field")]
		public string M3KEY6 => GetString("KEY6");

		/// <summary>
		/// Description: Key field
		/// FieldName: KEY7
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Key field")]
		public string M3KEY7 => GetString("KEY7");

		/// <summary>
		/// Description: Key field
		/// FieldName: KEY8
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Key field")]
		public string M3KEY8 => GetString("KEY8");

		/// <summary>
		/// Description: Key field
		/// FieldName: KEY9
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Key field")]
		public string M3KEY9 => GetString("KEY9");

		/// <summary>
		/// Description: Key field
		/// FieldName: KE10
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Key field")]
		public string M3KE10 => GetString("KE10");

		/// <summary>
		/// Description: Key field
		/// FieldName: KE11
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Key field")]
		public string M3KE11 => GetString("KE11");

		/// <summary>
		/// Description: Key field
		/// FieldName: KE12
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Key field")]
		public string M3KE12 => GetString("KE12");

		/// <summary>
		/// Description: Key field
		/// FieldName: KE13
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Key field")]
		public string M3KE13 => GetString("KE13");

		/// <summary>
		/// Description: Key field
		/// FieldName: KE14
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Key field")]
		public string M3KE14 => GetString("KE14");

		/// <summary>
		/// Description: Key field
		/// FieldName: KE15
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Key field")]
		public string M3KE15 => GetString("KE15");

		/// <summary>
		/// Description: Key field
		/// FieldName: KE16
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Key field")]
		public string M3KE16 => GetString("KE16");

		/// <summary>
		/// Description: Value field
		/// FieldName: VAL1
		/// FieldType: A
		/// Length: 30
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Value field")]
		public string M3VAL1 => GetString("VAL1");

		/// <summary>
		/// Description: Value field
		/// FieldName: VAL2
		/// FieldType: A
		/// Length: 30
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Value field")]
		public string M3VAL2 => GetString("VAL2");

		/// <summary>
		/// Description: Value field
		/// FieldName: VAL3
		/// FieldType: A
		/// Length: 30
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Value field")]
		public string M3VAL3 => GetString("VAL3");

		/// <summary>
		/// Description: Value field
		/// FieldName: VAL4
		/// FieldType: A
		/// Length: 30
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Value field")]
		public string M3VAL4 => GetString("VAL4");

		/// <summary>
		/// Description: Value field
		/// FieldName: VAL5
		/// FieldType: A
		/// Length: 30
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Value field")]
		public string M3VAL5 => GetString("VAL5");

		/// <summary>
		/// Description: Value field
		/// FieldName: VAL6
		/// FieldType: A
		/// Length: 30
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Value field")]
		public string M3VAL6 => GetString("VAL6");

		/// <summary>
		/// Description: Value field
		/// FieldName: VAL7
		/// FieldType: A
		/// Length: 30
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Value field")]
		public string M3VAL7 => GetString("VAL7");

		/// <summary>
		/// Description: Value field
		/// FieldName: VAL8
		/// FieldType: A
		/// Length: 30
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Value field")]
		public string M3VAL8 => GetString("VAL8");

		/// <summary>
		/// Description: Value field
		/// FieldName: VAL9
		/// FieldType: A
		/// Length: 30
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Value field")]
		public string M3VAL9 => GetString("VAL9");

		/// <summary>
		/// Description: Value field
		/// FieldName: VA10
		/// FieldType: A
		/// Length: 30
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Value field")]
		public string M3VA10 => GetString("VA10");

		/// <summary>
		/// Description: Value field
		/// FieldName: VA11
		/// FieldType: A
		/// Length: 30
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Value field")]
		public string M3VA11 => GetString("VA11");

		/// <summary>
		/// Description: Value field
		/// FieldName: VA12
		/// FieldType: A
		/// Length: 30
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Value field")]
		public string M3VA12 => GetString("VA12");

		/// <summary>
		/// Description: Value field
		/// FieldName: VA13
		/// FieldType: A
		/// Length: 30
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Value field")]
		public string M3VA13 => GetString("VA13");

		/// <summary>
		/// Description: Value field
		/// FieldName: VA14
		/// FieldType: A
		/// Length: 30
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Value field")]
		public string M3VA14 => GetString("VA14");

		/// <summary>
		/// Description: Value field
		/// FieldName: VA15
		/// FieldType: A
		/// Length: 30
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Value field")]
		public string M3VA15 => GetString("VA15");

		/// <summary>
		/// Description: Value field
		/// FieldName: VA16
		/// FieldType: A
		/// Length: 30
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Value field")]
		public string M3VA16 => GetString("VA16");

		/// <summary>
		/// Description: Read option
		/// FieldName: RO01
		/// FieldType: N
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Read option")]
		public int? M3RO01 => GetNullableInt("RO01");

		/// <summary>
		/// Description: Read option
		/// FieldName: RO02
		/// FieldType: N
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Read option")]
		public int? M3RO02 => GetNullableInt("RO02");

		/// <summary>
		/// Description: Read option
		/// FieldName: RO03
		/// FieldType: N
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Read option")]
		public int? M3RO03 => GetNullableInt("RO03");

		/// <summary>
		/// Description: Read option
		/// FieldName: RO04
		/// FieldType: N
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Read option")]
		public int? M3RO04 => GetNullableInt("RO04");

		/// <summary>
		/// Description: Read option
		/// FieldName: RO05
		/// FieldType: N
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Read option")]
		public int? M3RO05 => GetNullableInt("RO05");

		/// <summary>
		/// Description: Read option
		/// FieldName: RO06
		/// FieldType: N
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Read option")]
		public int? M3RO06 => GetNullableInt("RO06");

		/// <summary>
		/// Description: Read option
		/// FieldName: RO07
		/// FieldType: N
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Read option")]
		public int? M3RO07 => GetNullableInt("RO07");

		/// <summary>
		/// Description: Read option
		/// FieldName: RO08
		/// FieldType: N
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Read option")]
		public int? M3RO08 => GetNullableInt("RO08");

		/// <summary>
		/// Description: Read option
		/// FieldName: RO09
		/// FieldType: N
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Read option")]
		public int? M3RO09 => GetNullableInt("RO09");

		/// <summary>
		/// Description: Read option
		/// FieldName: RO10
		/// FieldType: N
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Read option")]
		public int? M3RO10 => GetNullableInt("RO10");

		/// <summary>
		/// Description: Read option
		/// FieldName: RO11
		/// FieldType: N
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Read option")]
		public int? M3RO11 => GetNullableInt("RO11");

		/// <summary>
		/// Description: Read option
		/// FieldName: RO12
		/// FieldType: N
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Read option")]
		public int? M3RO12 => GetNullableInt("RO12");

		/// <summary>
		/// Description: Read option
		/// FieldName: RO13
		/// FieldType: N
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Read option")]
		public int? M3RO13 => GetNullableInt("RO13");

		/// <summary>
		/// Description: Read option
		/// FieldName: RO14
		/// FieldType: N
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Read option")]
		public int? M3RO14 => GetNullableInt("RO14");

		/// <summary>
		/// Description: Read option
		/// FieldName: RO15
		/// FieldType: N
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Read option")]
		public int? M3RO15 => GetNullableInt("RO15");

		/// <summary>
		/// Description: Read option
		/// FieldName: RO16
		/// FieldType: N
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Read option")]
		public int? M3RO16 => GetNullableInt("RO16");

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
		/// Description: Index in search
		/// FieldName: IXSE
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Index in search")]
		public string M3IXSE => GetString("IXSE");

		/// <summary>
		/// Description: Number of keys
		/// FieldName: NOKY
		/// FieldType: N
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Number of keys")]
		public int? M3NOKY => GetNullableInt("NOKY");

		/// <summary>
		/// Description: Sequence number
		/// FieldName: SNNO
		/// FieldType: N
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Sequence number")]
		public int? M3SNNO => GetNullableInt("SNNO");

		/// <summary>
		/// Description: Sorting option
		/// FieldName: SOPT
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Sorting option")]
		public string M3SOPT => GetString("SOPT");

		/// <summary>
		/// Description: Connection type
		/// FieldName: CETP
		/// FieldType: N
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Connection type")]
		public int? M3CETP => GetNullableInt("CETP");

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
		/// Description: Name
		/// FieldName: TX15
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Name")]
		public string M3TX15 => GetString("TX15");

		/// <summary>
		/// Description: XML section
		/// FieldName: RPBK
		/// FieldType: N
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("XML section")]
		public int? M3RPBK => GetNullableInt("RPBK");

		/// <summary>
		/// Description: Trim zeros
		/// FieldName: TR01
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Trim zeros")]
		public int? M3TR01 => GetNullableInt("TR01");

		/// <summary>
		/// Description: Trim zeros
		/// FieldName: TR02
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Trim zeros")]
		public int? M3TR02 => GetNullableInt("TR02");

		/// <summary>
		/// Description: Trim zeros
		/// FieldName: TR03
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Trim zeros")]
		public int? M3TR03 => GetNullableInt("TR03");

		/// <summary>
		/// Description: Trim zeros
		/// FieldName: TR04
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Trim zeros")]
		public int? M3TR04 => GetNullableInt("TR04");

		/// <summary>
		/// Description: Trim zeros
		/// FieldName: TR05
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Trim zeros")]
		public int? M3TR05 => GetNullableInt("TR05");

		/// <summary>
		/// Description: Trim zeros
		/// FieldName: TR06
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Trim zeros")]
		public int? M3TR06 => GetNullableInt("TR06");

		/// <summary>
		/// Description: Trim zeros
		/// FieldName: TR07
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Trim zeros")]
		public int? M3TR07 => GetNullableInt("TR07");

		/// <summary>
		/// Description: Trim zeros
		/// FieldName: TR08
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Trim zeros")]
		public int? M3TR08 => GetNullableInt("TR08");

		/// <summary>
		/// Description: Trim zeros
		/// FieldName: TR09
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Trim zeros")]
		public int? M3TR09 => GetNullableInt("TR09");

		/// <summary>
		/// Description: Trim zeros
		/// FieldName: TR10
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Trim zeros")]
		public int? M3TR10 => GetNullableInt("TR10");

		/// <summary>
		/// Description: Trim zeros
		/// FieldName: TR11
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Trim zeros")]
		public int? M3TR11 => GetNullableInt("TR11");

		/// <summary>
		/// Description: Trim zeros
		/// FieldName: TR12
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Trim zeros")]
		public int? M3TR12 => GetNullableInt("TR12");

		/// <summary>
		/// Description: Trim zeros
		/// FieldName: TR13
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Trim zeros")]
		public int? M3TR13 => GetNullableInt("TR13");

		/// <summary>
		/// Description: Trim zeros
		/// FieldName: TR14
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Trim zeros")]
		public int? M3TR14 => GetNullableInt("TR14");

		/// <summary>
		/// Description: Trim zeros
		/// FieldName: TR15
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Trim zeros")]
		public int? M3TR15 => GetNullableInt("TR15");

		/// <summary>
		/// Description: Trim zeros
		/// FieldName: TR16
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Trim zeros")]
		public int? M3TR16 => GetNullableInt("TR16");
	}
}
// EOF
