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

namespace M3H5Lib.Api.CMS015MI
{
	public partial class LstCustomMIResponse : M3BaseRecord 
	{

		/// <summary>
		/// Description: Transaction ID
		/// FieldName: TRID
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Transaction ID")]
		public string M3TRID => GetString("TRID");

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
		/// Description: Object access group
		/// FieldName: ACGR
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Object access group")]
		public string M3ACGR => GetString("ACGR");

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
		/// Description: Sorting order
		/// FieldName: QTTP
		/// FieldType: N
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Sorting order")]
		public int? M3QTTP => GetNullableInt("QTTP");

		/// <summary>
		/// Description: View
		/// FieldName: PAVR
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("View")]
		public string M3PAVR => GetString("PAVR");

		/// <summary>
		/// Description: Number of filters
		/// FieldName: NFTR
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Number of filters")]
		public int? M3NFTR => GetNullableInt("NFTR");

		/// <summary>
		/// Description: Aggregation
		/// FieldName: AGGR
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Aggregation")]
		public int? M3AGGR => GetNullableInt("AGGR");

		/// <summary>
		/// Description: Subtotal 1
		/// FieldName: SUB1
		/// FieldType: N
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Subtotal 1")]
		public int? M3SUB1 => GetNullableInt("SUB1");

		/// <summary>
		/// Description: Subtotal 2
		/// FieldName: SUB2
		/// FieldType: N
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Subtotal 2")]
		public int? M3SUB2 => GetNullableInt("SUB2");

		/// <summary>
		/// Description: Subtotal 3
		/// FieldName: SUB3
		/// FieldType: N
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Subtotal 3")]
		public int? M3SUB3 => GetNullableInt("SUB3");

		/// <summary>
		/// Description: Selection field 1
		/// FieldName: SLF1
		/// FieldType: A
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Selection field 1")]
		public string M3SLF1 => GetString("SLF1");

		/// <summary>
		/// Description: Selection field 2
		/// FieldName: SLF2
		/// FieldType: A
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Selection field 2")]
		public string M3SLF2 => GetString("SLF2");

		/// <summary>
		/// Description: Selection field 3
		/// FieldName: SLF3
		/// FieldType: A
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Selection field 3")]
		public string M3SLF3 => GetString("SLF3");

		/// <summary>
		/// Description: Last file name used
		/// FieldName: LUFN
		/// FieldType: A
		/// Length: 60
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Last file name used")]
		public string M3LUFN => GetString("LUFN");

		/// <summary>
		/// Description: Last version used
		/// FieldName: LUVE
		/// FieldType: A
		/// Length: 20
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Last version used")]
		public string M3LUVE => GetString("LUVE");

		/// <summary>
		/// Description: Search
		/// FieldName: SACH
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Search")]
		public int? M3SACH => GetNullableInt("SACH");

		/// <summary>
		/// Description: Include bookmark fields
		/// FieldName: INBO
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Include bookmark fields")]
		public int? M3INBO => GetNullableInt("INBO");

		/// <summary>
		/// Description: Maximum number of records
		/// FieldName: MXRE
		/// FieldType: N
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Maximum number of records")]
		public int? M3MXRE => GetNullableInt("MXRE");
	}
}
// EOF
