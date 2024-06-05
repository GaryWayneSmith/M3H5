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

namespace M3H5Lib.Api.CRSPCIMI
{
	public partial class GetSumHeadResponse : M3BaseRecord 
	{

		/// <summary>
		/// Description: Sales price
		/// FieldName: SAPR
		/// FieldType: A
		/// Length: 19
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Sales price")]
		public string M3_SAPR => GetString("SAPR");

		/// <summary>
		/// Description: Cost price
		/// FieldName: UCOS
		/// FieldType: A
		/// Length: 19
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Cost price")]
		public string M3_UCOS => GetString("UCOS");

		/// <summary>
		/// Description: Margin amount
		/// FieldName: MARG
		/// FieldType: A
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Margin amount")]
		public string M3_MARG => GetString("MARG");

		/// <summary>
		/// Description: Margin percentage
		/// FieldName: MAPC
		/// FieldType: N
		/// Length: 7
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Margin percentage")]
		public int? M3_MAPC => GetNullableInt("MAPC");

		/// <summary>
		/// Description: Local sales price
		/// FieldName: LOSP
		/// FieldType: A
		/// Length: 19
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Local sales price")]
		public string M3_LOSP => GetString("LOSP");

		/// <summary>
		/// Description: Local currency code
		/// FieldName: LOCD
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Local currency code")]
		public string M3_LOCD => GetString("LOCD");
	}
}
// EOF
