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

namespace M3H5Lib.Api.MWS410MI
{
	public partial class ChkDelValueResponse : M3BaseRecord 
	{

		/// <summary>
		/// Description: Delivery number
		/// FieldName: DLIX
		/// FieldType: N
		/// Length: 11
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Delivery number")]
		public decimal? M3_DLIX => GetNullableDecimal("DLIX");

		/// <summary>
		/// Description: Issue reporting status
		/// FieldName: IRPS
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Issue reporting status")]
		public string M3_IRPS => GetString("IRPS");

		/// <summary>
		/// Description: Delivery value check amount
		/// FieldName: DVCA
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Delivery value check amount")]
		public decimal? M3_DVCA => GetNullableDecimal("DVCA");

		/// <summary>
		/// Description: Delivery value variance
		/// FieldName: DVDA
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Delivery value variance")]
		public decimal? M3_DVDA => GetNullableDecimal("DVDA");

		/// <summary>
		/// Description: Currency of payer used in delivery value
		/// FieldName: DVCU
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Currency of payer used in delivery value")]
		public string M3_DVCU => GetString("DVCU");
	}
}
// EOF
