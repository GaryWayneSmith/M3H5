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
	public partial class ListLineResponse : M3BaseRecord 
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
		/// Description: Valid date
		/// FieldName: FDAT
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Valid date")]
		public DateTime? M3FDAT => GetNullableDateTime("FDAT");

		/// <summary>
		/// Description: Matrix value in column 1 alpha
		/// FieldName: MVC1
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Matrix value in column 1 alpha")]
		public string M3MVC1 => GetString("MVC1");

		/// <summary>
		/// Description: Matrix value in column 1 numeric
		/// FieldName: MVN1
		/// FieldType: N
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Matrix value in column 1 numeric")]
		public decimal? M3MVN1 => GetNullableDecimal("MVN1");

		/// <summary>
		/// Description: Matrix value in column 2 alpha
		/// FieldName: MVC2
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Matrix value in column 2 alpha")]
		public string M3MVC2 => GetString("MVC2");

		/// <summary>
		/// Description: Matrix value in column 2 numeric
		/// FieldName: MVN2
		/// FieldType: N
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Matrix value in column 2 numeric")]
		public decimal? M3MVN2 => GetNullableDecimal("MVN2");

		/// <summary>
		/// Description: Matrix value in column 3 alpha
		/// FieldName: MVC3
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Matrix value in column 3 alpha")]
		public string M3MVC3 => GetString("MVC3");

		/// <summary>
		/// Description: Matrix value in column 3 numeric
		/// FieldName: MVN3
		/// FieldType: N
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Matrix value in column 3 numeric")]
		public decimal? M3MVN3 => GetNullableDecimal("MVN3");

		/// <summary>
		/// Description: Matrix value in column 4 alpha
		/// FieldName: MVC4
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Matrix value in column 4 alpha")]
		public string M3MVC4 => GetString("MVC4");

		/// <summary>
		/// Description: Matrix value in column 4 numeric
		/// FieldName: MVN4
		/// FieldType: N
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Matrix value in column 4 numeric")]
		public decimal? M3MVN4 => GetNullableDecimal("MVN4");

		/// <summary>
		/// Description: Matrix value in column 5 alpha
		/// FieldName: MVC5
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Matrix value in column 5 alpha")]
		public string M3MVC5 => GetString("MVC5");

		/// <summary>
		/// Description: Matrix value in column 5 numeric
		/// FieldName: MVN5
		/// FieldType: N
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Matrix value in column 5 numeric")]
		public decimal? M3MVN5 => GetNullableDecimal("MVN5");

		/// <summary>
		/// Description: Matrix value in column 6 alpha
		/// FieldName: MVC6
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Matrix value in column 6 alpha")]
		public string M3MVC6 => GetString("MVC6");

		/// <summary>
		/// Description: Matrix value in column 6 numeric
		/// FieldName: MVN6
		/// FieldType: N
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Matrix value in column 6 numeric")]
		public decimal? M3MVN6 => GetNullableDecimal("MVN6");

		/// <summary>
		/// Description: Result
		/// FieldName: MRC1
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Result")]
		public string M3MRC1 => GetString("MRC1");

		/// <summary>
		/// Description: Result numeric column 1
		/// FieldName: MNC1
		/// FieldType: N
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Result numeric column 1")]
		public decimal? M3MNC1 => GetNullableDecimal("MNC1");

		/// <summary>
		/// Description: Result numeric column 2
		/// FieldName: MNC2
		/// FieldType: N
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Result numeric column 2")]
		public decimal? M3MNC2 => GetNullableDecimal("MNC2");

		/// <summary>
		/// Description: Result numeric column 3
		/// FieldName: MNC3
		/// FieldType: N
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Result numeric column 3")]
		public decimal? M3MNC3 => GetNullableDecimal("MNC3");

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
		/// Description: Name
		/// FieldName: ITDS
		/// FieldType: A
		/// Length: 30
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Name")]
		public string M3ITDS => GetString("ITDS");

		/// <summary>
		/// Description: Desciption
		/// FieldName: TEDS
		/// FieldType: A
		/// Length: 60
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Desciption")]
		public string M3TEDS => GetString("TEDS");
	}
}
// EOF
