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

namespace M3H5Lib.Api.MRS001MI
{
	public partial class LstAdtFieldInfResponse : M3BaseRecord 
	{

		/// <summary>
		/// Description: Field name
		/// FieldName: FLNM
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Field name")]
		public string M3FLNM => GetString("FLNM");

		/// <summary>
		/// Description: Description
		/// FieldName: FLDS
		/// FieldType: A
		/// Length: 60
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Description")]
		public string M3FLDS => GetString("FLDS");

		/// <summary>
		/// Description: Text ID
		/// FieldName: TXT1
		/// FieldType: N
		/// Length: 13
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Text ID")]
		public decimal? M3TXT1 => GetNullableDecimal("TXT1");

		/// <summary>
		/// Description: From position
		/// FieldName: FRPO
		/// FieldType: N
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("From position")]
		public int? M3FRPO => GetNullableInt("FRPO");

		/// <summary>
		/// Description: To position
		/// FieldName: TOPO
		/// FieldType: N
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("To position")]
		public int? M3TOPO => GetNullableInt("TOPO");

		/// <summary>
		/// Description: Length
		/// FieldName: LENG
		/// FieldType: N
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Length")]
		public int? M3LENG => GetNullableInt("LENG");

		/// <summary>
		/// Description: Number of decimal places
		/// FieldName: FLDP
		/// FieldType: N
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Number of decimal places")]
		public int? M3FLDP => GetNullableInt("FLDP");

		/// <summary>
		/// Description: Field type A=Alphanumeric, N=Numeric
		/// FieldName: TYPE
		/// FieldType: A
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Field type A=Alphanumeric, N=Numeric")]
		public string M3TYPE => GetString("TYPE");

		/// <summary>
		/// Description: Mandatory
		/// FieldName: MAND
		/// FieldType: A
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Mandatory")]
		public string M3MAND => GetString("MAND");

		/// <summary>
		/// Description: Lower case
		/// FieldName: FLDX
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Lower case")]
		public int? M3FLDX => GetNullableInt("FLDX");

		/// <summary>
		/// Description: General word
		/// FieldName: MSI5
		/// FieldType: A
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("General word")]
		public string M3MSI5 => GetString("MSI5");

		/// <summary>
		/// Description: Type
		/// FieldName: TYP2
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Type")]
		public string M3TYP2 => GetString("TYP2");

		/// <summary>
		/// Description: Category
		/// FieldName: CTGY
		/// FieldType: A
		/// Length: 20
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Category")]
		public string M3CTGY => GetString("CTGY");

		/// <summary>
		/// Description: Base category
		/// FieldName: BCTG
		/// FieldType: A
		/// Length: 20
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Base category")]
		public string M3BCTG => GetString("BCTG");

		/// <summary>
		/// Description: Length in table
		/// FieldName: LNTH
		/// FieldType: A
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Length in table")]
		public string M3LNTH => GetString("LNTH");

		/// <summary>
		/// Description: Language file prefix for field heading
		/// FieldName: LNF1
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Language file prefix for field heading")]
		public string M3LNF1 => GetString("LNF1");

		/// <summary>
		/// Description: Field help
		/// FieldName: HELP
		/// FieldType: A
		/// Length: 8
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Field help")]
		public string M3HELP => GetString("HELP");

		/// <summary>
		/// Description: Language file prefix for field help
		/// FieldName: LNF2
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Language file prefix for field help")]
		public string M3LNF2 => GetString("LNF2");

		/// <summary>
		/// Description: Additional info length
		/// FieldName: AILN
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Additional info length")]
		public string M3AILN => GetString("AILN");

		/// <summary>
		/// Description: Additional info short length
		/// FieldName: AISL
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Additional info short length")]
		public string M3AISL => GetString("AISL");

		/// <summary>
		/// Description: Lower limit
		/// FieldName: LLIM
		/// FieldType: A
		/// Length: 30
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Lower limit")]
		public string M3LLIM => GetString("LLIM");

		/// <summary>
		/// Description: Decimals for lower limit
		/// FieldName: LDCM
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Decimals for lower limit")]
		public int? M3LDCM => GetNullableInt("LDCM");

		/// <summary>
		/// Description: Upper limit
		/// FieldName: ULIM
		/// FieldType: A
		/// Length: 30
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Upper limit")]
		public string M3ULIM => GetString("ULIM");

		/// <summary>
		/// Description: Decimals for upper limit
		/// FieldName: UDCM
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Decimals for upper limit")]
		public int? M3UDCM => GetNullableInt("UDCM");

		/// <summary>
		/// Description: Value map exists for this field
		/// FieldName: VMAP
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Value map exists for this field")]
		public int? M3VMAP => GetNullableInt("VMAP");

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
		/// Description: Field is available for browse
		/// FieldName: BRWS
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Field is available for browse")]
		public int? M3BRWS => GetNullableInt("BRWS");
	}
}
// EOF
