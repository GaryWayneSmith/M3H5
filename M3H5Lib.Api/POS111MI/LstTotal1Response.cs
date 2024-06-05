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

namespace M3H5Lib.Api.POS111MI
{
	public partial class LstTotal1Response : M3BaseRecord 
	{

		/// <summary>
		/// Description: Project element
		/// FieldName: ELNO
		/// FieldType: A
		/// Length: 8
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Project element")]
		public string M3_ELNO => GetString("ELNO");

		/// <summary>
		/// Description: Budget item ID
		/// FieldName: IDEN
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Budget item ID")]
		public string M3_IDEN => GetString("IDEN");

		/// <summary>
		/// Description: Budget amount
		/// FieldName: BUAT
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Budget amount")]
		public decimal? M3_BUAT => GetNullableDecimal("BUAT");

		/// <summary>
		/// Description: Budget quantity
		/// FieldName: BUQT
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Budget quantity")]
		public decimal? M3_BUQT => GetNullableDecimal("BUQT");

		/// <summary>
		/// Description: Actual
		/// FieldName: OUAT
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Actual")]
		public decimal? M3_OUAT => GetNullableDecimal("OUAT");

		/// <summary>
		/// Description: Actual quantity
		/// FieldName: OUQT
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Actual quantity")]
		public decimal? M3_OUQT => GetNullableDecimal("OUQT");

		/// <summary>
		/// Description: Expense/Revenue code
		/// FieldName: ICVT
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Expense/Revenue code")]
		public int? M3_ICVT => GetNullableInt("ICVT");

		/// <summary>
		/// Description: Date
		/// FieldName: DTUM
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Date")]
		public DateTime? M3_DTUM => GetNullableDateTime("DTUM");
	}
}
// EOF
