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

namespace M3H5Lib.Api.PDS090MI
{
	public partial class GetResponse : M3BaseRecord 
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
		/// Description: Selection matrix
		/// FieldName: MXID
		/// FieldType: A
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Selection matrix")]
		public string M3MXID => GetString("MXID");

		/// <summary>
		/// Description: Selection matrix type
		/// FieldName: MXTP
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Selection matrix type")]
		public int? M3MXTP => GetNullableInt("MXTP");

		/// <summary>
		/// Description: Text
		/// FieldName: TX30
		/// FieldType: A
		/// Length: 30
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Text")]
		public string M3TX30 => GetString("TX30");

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
		/// Description: Field group
		/// FieldName: MGRP
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Field group")]
		public string M3MGRP => GetString("MGRP");

		/// <summary>
		/// Description: Responsible
		/// FieldName: RESP
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Responsible")]
		public string M3RESP => GetString("RESP");

		/// <summary>
		/// Description: Basic unit of measure
		/// FieldName: UNMS
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Basic unit of measure")]
		public string M3UNMS => GetString("UNMS");

		/// <summary>
		/// Description: Display quantity
		/// FieldName: DSQU
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Display quantity")]
		public int? M3DSQU => GetNullableInt("DSQU");

		/// <summary>
		/// Description: Text
		/// FieldName: DMD1
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Text")]
		public string M3DMD1 => GetString("DMD1");

		/// <summary>
		/// Description: Text
		/// FieldName: DMD2
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Text")]
		public string M3DMD2 => GetString("DMD2");

		/// <summary>
		/// Description: Text
		/// FieldName: DMD3
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Text")]
		public string M3DMD3 => GetString("DMD3");

		/// <summary>
		/// Description: Column Type
		/// FieldName: MOC1
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Column Type")]
		public int? M3MOC1 => GetNullableInt("MOC1");

		/// <summary>
		/// Description: Column
		/// FieldName: MCC1
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Column")]
		public string M3MCC1 => GetString("MCC1");

		/// <summary>
		/// Description: Column Rank
		/// FieldName: MRC1
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Column Rank")]
		public int? M3MRC1 => GetNullableInt("MRC1");

		/// <summary>
		/// Description: Description
		/// FieldName: COL1
		/// FieldType: A
		/// Length: 30
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Description")]
		public string M3COL1 => GetString("COL1");

		/// <summary>
		/// Description: Column Type
		/// FieldName: MOC2
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Column Type")]
		public int? M3MOC2 => GetNullableInt("MOC2");

		/// <summary>
		/// Description: Column
		/// FieldName: MCC2
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Column")]
		public string M3MCC2 => GetString("MCC2");

		/// <summary>
		/// Description: Column Rank
		/// FieldName: MRC2
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Column Rank")]
		public int? M3MRC2 => GetNullableInt("MRC2");

		/// <summary>
		/// Description: Description
		/// FieldName: COL2
		/// FieldType: A
		/// Length: 30
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Description")]
		public string M3COL2 => GetString("COL2");

		/// <summary>
		/// Description: Column Type
		/// FieldName: MOC3
		/// FieldType: A
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Column Type")]
		public string M3MOC3 => GetString("MOC3");

		/// <summary>
		/// Description: Column
		/// FieldName: MCC3
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Column")]
		public string M3MCC3 => GetString("MCC3");

		/// <summary>
		/// Description: Column Rank
		/// FieldName: MRC3
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Column Rank")]
		public int? M3MRC3 => GetNullableInt("MRC3");

		/// <summary>
		/// Description: Description
		/// FieldName: COL3
		/// FieldType: A
		/// Length: 30
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Description")]
		public string M3COL3 => GetString("COL3");

		/// <summary>
		/// Description: Column Type
		/// FieldName: MOC4
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Column Type")]
		public int? M3MOC4 => GetNullableInt("MOC4");

		/// <summary>
		/// Description: Column
		/// FieldName: MCC4
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Column")]
		public string M3MCC4 => GetString("MCC4");

		/// <summary>
		/// Description: Column Rank
		/// FieldName: MRC4
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Column Rank")]
		public int? M3MRC4 => GetNullableInt("MRC4");

		/// <summary>
		/// Description: Description
		/// FieldName: COL4
		/// FieldType: A
		/// Length: 30
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Description")]
		public string M3COL4 => GetString("COL4");

		/// <summary>
		/// Description: Column Type
		/// FieldName: MOC5
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Column Type")]
		public int? M3MOC5 => GetNullableInt("MOC5");

		/// <summary>
		/// Description: Column
		/// FieldName: MCC5
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Column")]
		public string M3MCC5 => GetString("MCC5");

		/// <summary>
		/// Description: Column Rank
		/// FieldName: MRC5
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Column Rank")]
		public int? M3MRC5 => GetNullableInt("MRC5");

		/// <summary>
		/// Description: Description
		/// FieldName: COL5
		/// FieldType: A
		/// Length: 30
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Description")]
		public string M3COL5 => GetString("COL5");

		/// <summary>
		/// Description: Column Type
		/// FieldName: MOC6
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Column Type")]
		public int? M3MOC6 => GetNullableInt("MOC6");

		/// <summary>
		/// Description: Column
		/// FieldName: MCC6
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Column")]
		public string M3MCC6 => GetString("MCC6");

		/// <summary>
		/// Description: Column Rank
		/// FieldName: MRC6
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Column Rank")]
		public int? M3MRC6 => GetNullableInt("MRC6");

		/// <summary>
		/// Description: Description
		/// FieldName: COL6
		/// FieldType: A
		/// Length: 20
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Description")]
		public string M3COL6 => GetString("COL6");

		/// <summary>
		/// Description: Column Type
		/// FieldName: MOC7
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Column Type")]
		public int? M3MOC7 => GetNullableInt("MOC7");

		/// <summary>
		/// Description: Column
		/// FieldName: MCC7
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Column")]
		public string M3MCC7 => GetString("MCC7");

		/// <summary>
		/// Description: Column Rank
		/// FieldName: MRC7
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Column Rank")]
		public int? M3MRC7 => GetNullableInt("MRC7");

		/// <summary>
		/// Description: Description
		/// FieldName: COL7
		/// FieldType: A
		/// Length: 30
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Description")]
		public string M3COL7 => GetString("COL7");

		/// <summary>
		/// Description: Column Type
		/// FieldName: MOC8
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Column Type")]
		public int? M3MOC8 => GetNullableInt("MOC8");

		/// <summary>
		/// Description: Column
		/// FieldName: MCC8
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Column")]
		public string M3MCC8 => GetString("MCC8");

		/// <summary>
		/// Description: Column Rank
		/// FieldName: MRC8
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Column Rank")]
		public int? M3MRC8 => GetNullableInt("MRC8");

		/// <summary>
		/// Description: Description
		/// FieldName: COL8
		/// FieldType: A
		/// Length: 30
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Description")]
		public string M3COL8 => GetString("COL8");

		/// <summary>
		/// Description: Column Type
		/// FieldName: MOC9
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Column Type")]
		public int? M3MOC9 => GetNullableInt("MOC9");

		/// <summary>
		/// Description: Column
		/// FieldName: MCC9
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Column")]
		public string M3MCC9 => GetString("MCC9");

		/// <summary>
		/// Description: Column Rank
		/// FieldName: MRC9
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Column Rank")]
		public int? M3MRC9 => GetNullableInt("MRC9");

		/// <summary>
		/// Description: Description
		/// FieldName: COL9
		/// FieldType: A
		/// Length: 30
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Description")]
		public string M3COL9 => GetString("COL9");

		/// <summary>
		/// Description: Formula result identity
		/// FieldName: FOR1
		/// FieldType: A
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Formula result identity")]
		public string M3FOR1 => GetString("FOR1");

		/// <summary>
		/// Description: Formula result identity
		/// FieldName: FOR2
		/// FieldType: A
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Formula result identity")]
		public string M3FOR2 => GetString("FOR2");

		/// <summary>
		/// Description: Formula result identity
		/// FieldName: FOR3
		/// FieldType: A
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Formula result identity")]
		public string M3FOR3 => GetString("FOR3");

		/// <summary>
		/// Description: Formula result identity
		/// FieldName: FOR4
		/// FieldType: A
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Formula result identity")]
		public string M3FOR4 => GetString("FOR4");

		/// <summary>
		/// Description: Formula result identity
		/// FieldName: FOR5
		/// FieldType: A
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Formula result identity")]
		public string M3FOR5 => GetString("FOR5");

		/// <summary>
		/// Description: Formula result identity
		/// FieldName: FOR6
		/// FieldType: A
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Formula result identity")]
		public string M3FOR6 => GetString("FOR6");

		/// <summary>
		/// Description: Formula result identity
		/// FieldName: FOR7
		/// FieldType: A
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Formula result identity")]
		public string M3FOR7 => GetString("FOR7");

		/// <summary>
		/// Description: Formula result identity
		/// FieldName: FOR8
		/// FieldType: A
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Formula result identity")]
		public string M3FOR8 => GetString("FOR8");

		/// <summary>
		/// Description: Formula result identity
		/// FieldName: FOR9
		/// FieldType: A
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Formula result identity")]
		public string M3FOR9 => GetString("FOR9");
	}
}
// EOF
