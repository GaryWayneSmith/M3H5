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

namespace M3H5Lib.Api.GMS200MI
{
	public partial class GetTransfTotResponse : M3BaseRecord 
	{

		/// <summary>
		/// Description: No of records
		/// FieldName: NORC
		/// FieldType: N
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("No of records")]
		public long? M3NORC => GetNullableLong("NORC");

		/// <summary>
		/// Description: Accounted amount (credit)
		/// FieldName: ACAC
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Accounted amount (credit)")]
		public decimal? M3ACAC => GetNullableDecimal("ACAC");

		/// <summary>
		/// Description: Accounted amount (debit)
		/// FieldName: ACAD
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Accounted amount (debit)")]
		public decimal? M3ACAD => GetNullableDecimal("ACAD");
	}
}
// EOF
