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

namespace M3H5Lib.Api.OIS100MI
{
	public partial class GetOrderPromiseResponse : M3BaseRecord 
	{

		/// <summary>
		/// Description: Atp - Quantity
		/// FieldName: AVTQ
		/// FieldType: N
		/// Length: 16
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Atp - Quantity")]
		public decimal? M3AVTQ => GetNullableDecimal("AVTQ");

		/// <summary>
		/// Description: Unit of measurement
		/// FieldName: UNMS
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Unit of measurement")]
		public string M3UNMS => GetString("UNMS");

		/// <summary>
		/// Description: ATP - Date
		/// FieldName: AVDT
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("ATP - Date")]
		public DateTime? M3AVDT => GetNullableDateTime("AVDT");
	}
}
// EOF
