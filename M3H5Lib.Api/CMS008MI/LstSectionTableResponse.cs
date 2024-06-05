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

namespace M3H5Lib.Api.CMS008MI
{
	public partial class LstSectionTableResponse : M3BaseRecord 
	{

		/// <summary>
		/// Description: Printer file
		/// FieldName: PRTF
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Printer file")]
		public string M3_PRTF => GetString("PRTF");

		/// <summary>
		/// Description: XML section
		/// FieldName: RPBK
		/// FieldType: N
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("XML section")]
		public int? M3_RPBK => GetNullableInt("RPBK");

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
		/// Description: Field prefix
		/// FieldName: FIPX
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Field prefix")]
		public string M3_FIPX => GetString("FIPX");

		/// <summary>
		/// Description: Base XML section
		/// FieldName: RPBA
		/// FieldType: N
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Base XML section")]
		public int? M3_RPBA => GetNullableInt("RPBA");

		/// <summary>
		/// Description: Configuration component
		/// FieldName: COCO
		/// FieldType: A
		/// Length: 30
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Configuration component")]
		public string M3_COCO => GetString("COCO");

		/// <summary>
		/// Description: Sorting option
		/// FieldName: SOPT
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Sorting option")]
		public string M3_SOPT => GetString("SOPT");

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
		/// Description: Field
		/// FieldName: OB07
		/// FieldType: A
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Field")]
		public string M3_OB07 => GetString("OB07");

		/// <summary>
		/// Description: Field
		/// FieldName: OB08
		/// FieldType: A
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Field")]
		public string M3_OB08 => GetString("OB08");

		/// <summary>
		/// Description: Field
		/// FieldName: OB09
		/// FieldType: A
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Field")]
		public string M3_OB09 => GetString("OB09");

		/// <summary>
		/// Description: Field
		/// FieldName: OB10
		/// FieldType: A
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Field")]
		public string M3_OB10 => GetString("OB10");

		/// <summary>
		/// Description: Field
		/// FieldName: OB11
		/// FieldType: A
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Field")]
		public string M3_OB11 => GetString("OB11");

		/// <summary>
		/// Description: Field
		/// FieldName: OB12
		/// FieldType: A
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Field")]
		public string M3_OB12 => GetString("OB12");

		/// <summary>
		/// Description: Field
		/// FieldName: OB13
		/// FieldType: A
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Field")]
		public string M3_OB13 => GetString("OB13");

		/// <summary>
		/// Description: Field
		/// FieldName: OB14
		/// FieldType: A
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Field")]
		public string M3_OB14 => GetString("OB14");

		/// <summary>
		/// Description: Field
		/// FieldName: OB15
		/// FieldType: A
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Field")]
		public string M3_OB15 => GetString("OB15");

		/// <summary>
		/// Description: Field
		/// FieldName: OB16
		/// FieldType: A
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Field")]
		public string M3_OB16 => GetString("OB16");

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
		/// Description: Value field
		/// FieldName: VAL4
		/// FieldType: A
		/// Length: 30
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Value field")]
		public string M3_VAL4 => GetString("VAL4");

		/// <summary>
		/// Description: Value field
		/// FieldName: VAL5
		/// FieldType: A
		/// Length: 30
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Value field")]
		public string M3_VAL5 => GetString("VAL5");

		/// <summary>
		/// Description: Value field
		/// FieldName: VAL6
		/// FieldType: A
		/// Length: 30
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Value field")]
		public string M3_VAL6 => GetString("VAL6");

		/// <summary>
		/// Description: Value field
		/// FieldName: VAL7
		/// FieldType: A
		/// Length: 30
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Value field")]
		public string M3_VAL7 => GetString("VAL7");

		/// <summary>
		/// Description: Value field
		/// FieldName: VAL8
		/// FieldType: A
		/// Length: 30
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Value field")]
		public string M3_VAL8 => GetString("VAL8");

		/// <summary>
		/// Description: Value field
		/// FieldName: VAL9
		/// FieldType: A
		/// Length: 30
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Value field")]
		public string M3_VAL9 => GetString("VAL9");

		/// <summary>
		/// Description: Value field
		/// FieldName: VA10
		/// FieldType: A
		/// Length: 30
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Value field")]
		public string M3_VA10 => GetString("VA10");

		/// <summary>
		/// Description: Value field
		/// FieldName: VA11
		/// FieldType: A
		/// Length: 30
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Value field")]
		public string M3_VA11 => GetString("VA11");

		/// <summary>
		/// Description: Value field
		/// FieldName: VA12
		/// FieldType: A
		/// Length: 30
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Value field")]
		public string M3_VA12 => GetString("VA12");

		/// <summary>
		/// Description: Value field
		/// FieldName: VA13
		/// FieldType: A
		/// Length: 30
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Value field")]
		public string M3_VA13 => GetString("VA13");

		/// <summary>
		/// Description: Value field
		/// FieldName: VA14
		/// FieldType: A
		/// Length: 30
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Value field")]
		public string M3_VA14 => GetString("VA14");

		/// <summary>
		/// Description: Value field
		/// FieldName: VA15
		/// FieldType: A
		/// Length: 30
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Value field")]
		public string M3_VA15 => GetString("VA15");

		/// <summary>
		/// Description: Value field
		/// FieldName: VA16
		/// FieldType: A
		/// Length: 30
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Value field")]
		public string M3_VA16 => GetString("VA16");

		/// <summary>
		/// Description: Read option
		/// FieldName: RO01
		/// FieldType: N
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Read option")]
		public int? M3_RO01 => GetNullableInt("RO01");

		/// <summary>
		/// Description: Read option
		/// FieldName: RO02
		/// FieldType: N
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Read option")]
		public int? M3_RO02 => GetNullableInt("RO02");

		/// <summary>
		/// Description: Read option
		/// FieldName: RO03
		/// FieldType: N
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Read option")]
		public int? M3_RO03 => GetNullableInt("RO03");

		/// <summary>
		/// Description: Read option
		/// FieldName: RO04
		/// FieldType: N
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Read option")]
		public int? M3_RO04 => GetNullableInt("RO04");

		/// <summary>
		/// Description: Read option
		/// FieldName: RO05
		/// FieldType: N
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Read option")]
		public int? M3_RO05 => GetNullableInt("RO05");

		/// <summary>
		/// Description: Read option
		/// FieldName: RO06
		/// FieldType: N
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Read option")]
		public int? M3_RO06 => GetNullableInt("RO06");

		/// <summary>
		/// Description: Read option
		/// FieldName: RO07
		/// FieldType: N
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Read option")]
		public int? M3_RO07 => GetNullableInt("RO07");

		/// <summary>
		/// Description: Read option
		/// FieldName: RO08
		/// FieldType: N
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Read option")]
		public int? M3_RO08 => GetNullableInt("RO08");

		/// <summary>
		/// Description: Read option
		/// FieldName: RO09
		/// FieldType: N
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Read option")]
		public int? M3_RO09 => GetNullableInt("RO09");

		/// <summary>
		/// Description: Read option
		/// FieldName: RO10
		/// FieldType: N
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Read option")]
		public int? M3_RO10 => GetNullableInt("RO10");

		/// <summary>
		/// Description: Read option
		/// FieldName: RO11
		/// FieldType: N
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Read option")]
		public int? M3_RO11 => GetNullableInt("RO11");

		/// <summary>
		/// Description: Read option
		/// FieldName: RO12
		/// FieldType: N
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Read option")]
		public int? M3_RO12 => GetNullableInt("RO12");

		/// <summary>
		/// Description: Read option
		/// FieldName: RO13
		/// FieldType: N
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Read option")]
		public int? M3_RO13 => GetNullableInt("RO13");

		/// <summary>
		/// Description: Read option
		/// FieldName: RO14
		/// FieldType: N
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Read option")]
		public int? M3_RO14 => GetNullableInt("RO14");

		/// <summary>
		/// Description: Read option
		/// FieldName: RO15
		/// FieldType: N
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Read option")]
		public int? M3_RO15 => GetNullableInt("RO15");

		/// <summary>
		/// Description: Read option
		/// FieldName: RO16
		/// FieldType: N
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Read option")]
		public int? M3_RO16 => GetNullableInt("RO16");

		/// <summary>
		/// Description: File
		/// FieldName: FI01
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("File")]
		public string M3_FI01 => GetString("FI01");

		/// <summary>
		/// Description: File
		/// FieldName: FI02
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("File")]
		public string M3_FI02 => GetString("FI02");

		/// <summary>
		/// Description: File
		/// FieldName: FI03
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("File")]
		public string M3_FI03 => GetString("FI03");

		/// <summary>
		/// Description: File
		/// FieldName: FI04
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("File")]
		public string M3_FI04 => GetString("FI04");

		/// <summary>
		/// Description: File
		/// FieldName: FI05
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("File")]
		public string M3_FI05 => GetString("FI05");

		/// <summary>
		/// Description: File
		/// FieldName: FI06
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("File")]
		public string M3_FI06 => GetString("FI06");

		/// <summary>
		/// Description: File
		/// FieldName: FI07
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("File")]
		public string M3_FI07 => GetString("FI07");

		/// <summary>
		/// Description: File
		/// FieldName: FI08
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("File")]
		public string M3_FI08 => GetString("FI08");

		/// <summary>
		/// Description: File
		/// FieldName: FI09
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("File")]
		public string M3_FI09 => GetString("FI09");

		/// <summary>
		/// Description: File
		/// FieldName: FI10
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("File")]
		public string M3_FI10 => GetString("FI10");

		/// <summary>
		/// Description: File
		/// FieldName: FI11
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("File")]
		public string M3_FI11 => GetString("FI11");

		/// <summary>
		/// Description: File
		/// FieldName: FI12
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("File")]
		public string M3_FI12 => GetString("FI12");

		/// <summary>
		/// Description: File
		/// FieldName: FI13
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("File")]
		public string M3_FI13 => GetString("FI13");

		/// <summary>
		/// Description: File
		/// FieldName: FI14
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("File")]
		public string M3_FI14 => GetString("FI14");

		/// <summary>
		/// Description: File
		/// FieldName: FI15
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("File")]
		public string M3_FI15 => GetString("FI15");

		/// <summary>
		/// Description: File
		/// FieldName: FI16
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("File")]
		public string M3_FI16 => GetString("FI16");

		/// <summary>
		/// Description: Trim zeros
		/// FieldName: TR01
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Trim zeros")]
		public int? M3_TR01 => GetNullableInt("TR01");

		/// <summary>
		/// Description: Trim zeros
		/// FieldName: TR02
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Trim zeros")]
		public int? M3_TR02 => GetNullableInt("TR02");

		/// <summary>
		/// Description: Trim zeros
		/// FieldName: TR03
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Trim zeros")]
		public int? M3_TR03 => GetNullableInt("TR03");

		/// <summary>
		/// Description: Trim zeros
		/// FieldName: TR04
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Trim zeros")]
		public int? M3_TR04 => GetNullableInt("TR04");

		/// <summary>
		/// Description: Trim zeros
		/// FieldName: TR05
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Trim zeros")]
		public int? M3_TR05 => GetNullableInt("TR05");

		/// <summary>
		/// Description: Trim zeros
		/// FieldName: TR06
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Trim zeros")]
		public int? M3_TR06 => GetNullableInt("TR06");

		/// <summary>
		/// Description: Trim zeros
		/// FieldName: TR07
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Trim zeros")]
		public int? M3_TR07 => GetNullableInt("TR07");

		/// <summary>
		/// Description: Trim zeros
		/// FieldName: TR08
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Trim zeros")]
		public int? M3_TR08 => GetNullableInt("TR08");

		/// <summary>
		/// Description: Trim zeros
		/// FieldName: TR09
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Trim zeros")]
		public int? M3_TR09 => GetNullableInt("TR09");

		/// <summary>
		/// Description: Trim zeros
		/// FieldName: TR10
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Trim zeros")]
		public int? M3_TR10 => GetNullableInt("TR10");

		/// <summary>
		/// Description: Trim zeros
		/// FieldName: TR11
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Trim zeros")]
		public int? M3_TR11 => GetNullableInt("TR11");

		/// <summary>
		/// Description: Trim zeros
		/// FieldName: TR12
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Trim zeros")]
		public int? M3_TR12 => GetNullableInt("TR12");

		/// <summary>
		/// Description: Trim zeros
		/// FieldName: TR13
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Trim zeros")]
		public int? M3_TR13 => GetNullableInt("TR13");

		/// <summary>
		/// Description: Trim zeros
		/// FieldName: TR14
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Trim zeros")]
		public int? M3_TR14 => GetNullableInt("TR14");

		/// <summary>
		/// Description: Trim zeros
		/// FieldName: TR15
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Trim zeros")]
		public int? M3_TR15 => GetNullableInt("TR15");

		/// <summary>
		/// Description: Trim zeros
		/// FieldName: TR16
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Trim zeros")]
		public int? M3_TR16 => GetNullableInt("TR16");
	}
}
// EOF
