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

namespace M3H5Lib.Api.OIS215MI
{
	public partial class GetSummaryResponse : M3BaseRecord 
	{

		/// <summary>
		/// Description: Total due
		/// FieldName: TOPA
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Total due")]
		public decimal? M3TOPA => GetNullableDecimal("TOPA");

		/// <summary>
		/// Description: Recd cash/Chg to give
		/// FieldName: TIAM
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Recd cash/Chg to give")]
		public decimal? M3TIAM => GetNullableDecimal("TIAM");

		/// <summary>
		/// Description: Discrepancy
		/// FieldName: DSCR
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Discrepancy")]
		public decimal? M3DSCR => GetNullableDecimal("DSCR");

		/// <summary>
		/// Description: Change to give
		/// FieldName: CHGI
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Change to give")]
		public decimal? M3CHGI => GetNullableDecimal("CHGI");
	}
}
// EOF
