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

namespace M3H5Lib.Api.APS450MI
{
	public partial class LstInvBySupInvResponse : M3BaseRecord 
	{

		/// <summary>
		/// Description: Invoice batch number
		/// FieldName: INBN
		/// FieldType: N
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Invoice batch number")]
		public long? M3_INBN => GetNullableLong("INBN");

		/// <summary>
		/// Description: Invoice batch type
		/// FieldName: IBTP
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Invoice batch type")]
		public string M3_IBTP => GetString("IBTP");

		/// <summary>
		/// Description: Invoice status
		/// FieldName: SUPA
		/// FieldType: N
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Invoice status")]
		public int? M3_SUPA => GetNullableInt("SUPA");
	}
}
// EOF
