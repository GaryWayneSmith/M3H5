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
	public partial class LstAllColumnsResponse : M3BaseRecord 
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
		/// Description: Responsible
		/// FieldName: RESP
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Responsible")]
		public string M3_RESP => GetString("RESP");

		/// <summary>
		/// Description: Panel version
		/// FieldName: PAVR
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Panel version")]
		public string M3_PAVR => GetString("PAVR");

		/// <summary>
		/// Description: Panel
		/// FieldName: PIC1
		/// FieldType: A
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Panel")]
		public string M3_PIC1 => GetString("PIC1");

		/// <summary>
		/// Description: Column number
		/// FieldName: COID
		/// FieldType: N
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Column number")]
		public int? M3_COID => GetNullableInt("COID");

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
		/// Description: Field length user value
		/// FieldName: FLLU
		/// FieldType: N
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Field length user value")]
		public int? M3_FLLU => GetNullableInt("FLLU");

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
		/// Description: Number of decimals - user
		/// FieldName: UNDC
		/// FieldType: A
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Number of decimals - user")]
		public string M3_UNDC => GetString("UNDC");

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
		/// Description: Edit code - user
		/// FieldName: ECDU
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Edit code - user")]
		public string M3_ECDU => GetString("ECDU");

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
		/// Description: Maximum accumulated value
		/// FieldName: MXAV
		/// FieldType: N
		/// Length: 13
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Maximum accumulated value")]
		public decimal? M3_MXAV => GetNullableDecimal("MXAV");

		/// <summary>
		/// Description: Sum
		/// FieldName: SUMA
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Sum")]
		public int? M3_SUMA => GetNullableInt("SUMA");

		/// <summary>
		/// Description: Override max value
		/// FieldName: OMAX
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Override max value")]
		public int? M3_OMAX => GetNullableInt("OMAX");

		/// <summary>
		/// Description: Sorting sequence
		/// FieldName: SOSQ
		/// FieldType: N
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Sorting sequence")]
		public int? M3_SOSQ => GetNullableInt("SOSQ");

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
		/// Description: Debit / credit code used - user
		/// FieldName: UDCN
		/// FieldType: A
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Debit / credit code used - user")]
		public string M3_UDCN => GetString("UDCN");

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
		/// Description: Edit field
		/// FieldName: EDFL
		/// FieldType: A
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Edit field")]
		public string M3_EDFL => GetString("EDFL");

		/// <summary>
		/// Description: Aggregation display rule
		/// FieldName: AGDR
		/// FieldType: N
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Aggregation display rule")]
		public int? M3_AGDR => GetNullableInt("AGDR");

		/// <summary>
		/// Description: Aggregation update rule
		/// FieldName: AGUR
		/// FieldType: N
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Aggregation update rule")]
		public int? M3_AGUR => GetNullableInt("AGUR");

		/// <summary>
		/// Description: Subtotal rule
		/// FieldName: SUBR
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Subtotal rule")]
		public int? M3_SUBR => GetNullableInt("SUBR");

		/// <summary>
		/// Description: Date format
		/// FieldName: DTFR
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Date format")]
		public string M3_DTFR => GetString("DTFR");

		/// <summary>
		/// Description: Decimal format
		/// FieldName: DCFM
		/// FieldType: A
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Decimal format")]
		public string M3_DCFM => GetString("DCFM");

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
