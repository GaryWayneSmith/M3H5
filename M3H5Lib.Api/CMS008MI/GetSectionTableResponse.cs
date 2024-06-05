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

namespace M3H5Lib.Api.CMS008MI
{
	public partial class GetSectionTableResponse : M3BaseRecord 
	{

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
		/// Description: Base XML section
		/// FieldName: RPBA
		/// FieldType: N
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Base XML section")]
		public int? M3RPBA => GetNullableInt("RPBA");

		/// <summary>
		/// Description: Configuration component
		/// FieldName: COCO
		/// FieldType: A
		/// Length: 30
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Configuration component")]
		public string M3COCO => GetString("COCO");

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
		/// Description: File
		/// FieldName: FI01
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("File")]
		public string M3FI01 => GetString("FI01");

		/// <summary>
		/// Description: File
		/// FieldName: FI02
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("File")]
		public string M3FI02 => GetString("FI02");

		/// <summary>
		/// Description: File
		/// FieldName: FI03
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("File")]
		public string M3FI03 => GetString("FI03");

		/// <summary>
		/// Description: File
		/// FieldName: FI04
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("File")]
		public string M3FI04 => GetString("FI04");

		/// <summary>
		/// Description: File
		/// FieldName: FI05
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("File")]
		public string M3FI05 => GetString("FI05");

		/// <summary>
		/// Description: File
		/// FieldName: FI06
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("File")]
		public string M3FI06 => GetString("FI06");

		/// <summary>
		/// Description: File
		/// FieldName: FI07
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("File")]
		public string M3FI07 => GetString("FI07");

		/// <summary>
		/// Description: File
		/// FieldName: FI08
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("File")]
		public string M3FI08 => GetString("FI08");

		/// <summary>
		/// Description: File
		/// FieldName: FI09
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("File")]
		public string M3FI09 => GetString("FI09");

		/// <summary>
		/// Description: File
		/// FieldName: FI10
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("File")]
		public string M3FI10 => GetString("FI10");

		/// <summary>
		/// Description: File
		/// FieldName: FI11
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("File")]
		public string M3FI11 => GetString("FI11");

		/// <summary>
		/// Description: File
		/// FieldName: FI12
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("File")]
		public string M3FI12 => GetString("FI12");

		/// <summary>
		/// Description: File
		/// FieldName: FI13
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("File")]
		public string M3FI13 => GetString("FI13");

		/// <summary>
		/// Description: File
		/// FieldName: FI14
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("File")]
		public string M3FI14 => GetString("FI14");

		/// <summary>
		/// Description: File
		/// FieldName: FI15
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("File")]
		public string M3FI15 => GetString("FI15");

		/// <summary>
		/// Description: File
		/// FieldName: FI16
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("File")]
		public string M3FI16 => GetString("FI16");

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
