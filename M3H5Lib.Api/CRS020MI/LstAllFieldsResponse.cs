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

namespace M3H5Lib.Api.CRS020MI
{
	public partial class LstAllFieldsResponse : M3BaseRecord 
	{

		/// <summary>
		/// Description: Program name
		/// FieldName: PGNM
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Program name")]
		public string M3_PGNM => GetString("PGNM");

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
		/// Description: Field type
		/// FieldName: FLTY
		/// FieldType: A
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Field type")]
		public string M3_FLTY => GetString("FLTY");

		/// <summary>
		/// Description: Message ID
		/// FieldName: MSID
		/// FieldType: A
		/// Length: 7
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Message ID")]
		public string M3_MSID => GetString("MSID");

		/// <summary>
		/// Description: Field length
		/// FieldName: FLDL
		/// FieldType: N
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Field length")]
		public int? M3_FLDL => GetNullableInt("FLDL");

		/// <summary>
		/// Description: Number of decimals
		/// FieldName: FNDC
		/// FieldType: A
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Number of decimals")]
		public string M3_FNDC => GetString("FNDC");

		/// <summary>
		/// Description: Edit code
		/// FieldName: ECDE
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Edit code")]
		public string M3_ECDE => GetString("ECDE");

		/// <summary>
		/// Description: Small field
		/// FieldName: SMFL
		/// FieldType: N
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Small field")]
		public int? M3_SMFL => GetNullableInt("SMFL");

		/// <summary>
		/// Description: Description
		/// FieldName: TX40
		/// FieldType: A
		/// Length: 40
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Description")]
		public string M3_TX40 => GetString("TX40");

		/// <summary>
		/// Description: Name
		/// FieldName: TX15
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Name")]
		public string M3_TX15 => GetString("TX15");

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
		/// Description: Description
		/// FieldName: TXC0
		/// FieldType: A
		/// Length: 40
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Description")]
		public string M3_TXC0 => GetString("TXC0");

		/// <summary>
		/// Description: Field help ID
		/// FieldName: FHID
		/// FieldType: A
		/// Length: 8
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Field help ID")]
		public string M3_FHID => GetString("FHID");

		/// <summary>
		/// Description: Field information code
		/// FieldName: FDCA
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Field information code")]
		public string M3_FDCA => GetString("FDCA");

		/// <summary>
		/// Description: Debit / credit code used
		/// FieldName: DCNY
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Debit / credit code used")]
		public int? M3_DCNY => GetNullableInt("DCNY");

		/// <summary>
		/// Description: Information browser category
		/// FieldName: IBCA
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Information browser category")]
		public string M3_IBCA => GetString("IBCA");

		/// <summary>
		/// Description: Edit field used
		/// FieldName: EDUS
		/// FieldType: A
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Edit field used")]
		public string M3_EDUS => GetString("EDUS");

		/// <summary>
		/// Description: Default aggregation display rule
		/// FieldName: DEAD
		/// FieldType: N
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Default aggregation display rule")]
		public int? M3_DEAD => GetNullableInt("DEAD");

		/// <summary>
		/// Description: Default subtotal rule
		/// FieldName: DESU
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Default subtotal rule")]
		public int? M3_DESU => GetNullableInt("DESU");

		/// <summary>
		/// Description: Default date format
		/// FieldName: DEDF
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Default date format")]
		public string M3_DEDF => GetString("DEDF");

		/// <summary>
		/// Description: Default decimal format
		/// FieldName: DEDC
		/// FieldType: A
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Default decimal format")]
		public string M3_DEDC => GetString("DEDC");

		/// <summary>
		/// Description: Field heading
		/// FieldName: FLDH
		/// FieldType: A
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Field heading")]
		public string M3_FLDH => GetString("FLDH");

		/// <summary>
		/// Description: Drop down box
		/// FieldName: DDBX
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Drop down box")]
		public int? M3_DDBX => GetNullableInt("DDBX");
	}
}
// EOF
