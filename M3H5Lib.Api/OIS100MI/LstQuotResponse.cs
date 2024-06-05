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

namespace M3H5Lib.Api.OIS100MI
{
	public partial class LstQuotResponse : M3BaseRecord 
	{

		/// <summary>
		/// Description: Status quotation
		/// FieldName: STAT
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Status quotation")]
		public string M3_STAT => GetString("STAT");

		/// <summary>
		/// Description: Order number
		/// FieldName: ORNO
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Order number")]
		public string M3_ORNO => GetString("ORNO");

		/// <summary>
		/// Description: Quotation reason
		/// FieldName: ORCD
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Quotation reason")]
		public string M3_ORCD => GetString("ORCD");

		/// <summary>
		/// Description: Ordering method
		/// FieldName: BECD
		/// FieldType: A
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Ordering method")]
		public string M3_BECD => GetString("BECD");

		/// <summary>
		/// Description: Valid to
		/// FieldName: GIDT
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Valid to")]
		public DateTime? M3_GIDT => GetNullableDateTime("GIDT");

		/// <summary>
		/// Description: Monitoring date 1
		/// FieldName: BVD1
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Monitoring date 1")]
		public DateTime? M3_BVD1 => GetNullableDateTime("BVD1");

		/// <summary>
		/// Description: Monitoring date 2
		/// FieldName: BVD2
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Monitoring date 2")]
		public DateTime? M3_BVD2 => GetNullableDateTime("BVD2");
	}
}
// EOF