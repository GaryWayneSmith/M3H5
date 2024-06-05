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

namespace M3H5Lib.Api.CUSEXTMI
{
	public partial class LstNumericKPIResponse : M3BaseRecord 
	{

		/// <summary>
		/// Description: KPI ID
		/// FieldName: KPID
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("KPI ID")]
		public string M3KPID => GetString("KPID");

		/// <summary>
		/// Description: Primary key 1
		/// FieldName: PK01
		/// FieldType: A
		/// Length: 30
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Primary key 1")]
		public string M3PK01 => GetString("PK01");

		/// <summary>
		/// Description: Primary key 2
		/// FieldName: PK02
		/// FieldType: A
		/// Length: 30
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Primary key 2")]
		public string M3PK02 => GetString("PK02");

		/// <summary>
		/// Description: Primary key 3
		/// FieldName: PK03
		/// FieldType: A
		/// Length: 30
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Primary key 3")]
		public string M3PK03 => GetString("PK03");

		/// <summary>
		/// Description: Primary key 4
		/// FieldName: PK04
		/// FieldType: A
		/// Length: 30
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Primary key 4")]
		public string M3PK04 => GetString("PK04");

		/// <summary>
		/// Description: Primary key 5
		/// FieldName: PK05
		/// FieldType: A
		/// Length: 30
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Primary key 5")]
		public string M3PK05 => GetString("PK05");

		/// <summary>
		/// Description: Primary key 6
		/// FieldName: PK06
		/// FieldType: A
		/// Length: 30
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Primary key 6")]
		public string M3PK06 => GetString("PK06");

		/// <summary>
		/// Description: Primary key 7
		/// FieldName: PK07
		/// FieldType: A
		/// Length: 30
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Primary key 7")]
		public string M3PK07 => GetString("PK07");

		/// <summary>
		/// Description: Primary key 8
		/// FieldName: PK08
		/// FieldType: A
		/// Length: 30
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Primary key 8")]
		public string M3PK08 => GetString("PK08");

		/// <summary>
		/// Description: Numeric field 19,6 positions
		/// FieldName: N096
		/// FieldType: N
		/// Length: 21
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Numeric field 19,6 positions")]
		public decimal? M3N096 => GetNullableDecimal("N096");

		/// <summary>
		/// Description: Numeric field 19,6 positions
		/// FieldName: N196
		/// FieldType: N
		/// Length: 21
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Numeric field 19,6 positions")]
		public decimal? M3N196 => GetNullableDecimal("N196");

		/// <summary>
		/// Description: Numeric field 19,6 positions
		/// FieldName: N296
		/// FieldType: N
		/// Length: 21
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Numeric field 19,6 positions")]
		public decimal? M3N296 => GetNullableDecimal("N296");

		/// <summary>
		/// Description: Numeric field 19,6 positions
		/// FieldName: N396
		/// FieldType: N
		/// Length: 21
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Numeric field 19,6 positions")]
		public decimal? M3N396 => GetNullableDecimal("N396");

		/// <summary>
		/// Description: Numeric field 19,6 positions
		/// FieldName: N496
		/// FieldType: N
		/// Length: 21
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Numeric field 19,6 positions")]
		public decimal? M3N496 => GetNullableDecimal("N496");

		/// <summary>
		/// Description: Numeric field 19,6 positions
		/// FieldName: N596
		/// FieldType: N
		/// Length: 21
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Numeric field 19,6 positions")]
		public decimal? M3N596 => GetNullableDecimal("N596");

		/// <summary>
		/// Description: Numeric field 19,6 positions
		/// FieldName: N696
		/// FieldType: N
		/// Length: 21
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Numeric field 19,6 positions")]
		public decimal? M3N696 => GetNullableDecimal("N696");

		/// <summary>
		/// Description: Numeric field 19,6 positions
		/// FieldName: N796
		/// FieldType: N
		/// Length: 21
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Numeric field 19,6 positions")]
		public decimal? M3N796 => GetNullableDecimal("N796");

		/// <summary>
		/// Description: Numeric field 19,6 positions
		/// FieldName: N896
		/// FieldType: N
		/// Length: 21
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Numeric field 19,6 positions")]
		public decimal? M3N896 => GetNullableDecimal("N896");

		/// <summary>
		/// Description: Numeric field 19,6 positions
		/// FieldName: N996
		/// FieldType: N
		/// Length: 21
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Numeric field 19,6 positions")]
		public decimal? M3N996 => GetNullableDecimal("N996");
	}
}
// EOF
