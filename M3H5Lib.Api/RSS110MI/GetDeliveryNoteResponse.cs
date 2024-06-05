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

namespace M3H5Lib.Api.RSS110MI
{
	public partial class GetDeliveryNoteResponse : M3BaseRecord 
	{

		/// <summary>
		/// Description: Delivery note number
		/// FieldName: DNNO
		/// FieldType: A
		/// Length: 11
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Delivery note number")]
		public string M3_DNNO => GetString("DNNO");

		/// <summary>
		/// Description: Delivery note date
		/// FieldName: DNDT
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Delivery note date")]
		public DateTime? M3_DNDT => GetNullableDateTime("DNDT");

		/// <summary>
		/// Description: Delivery note time
		/// FieldName: DNTM
		/// FieldType: N
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Delivery note time")]
		public int? M3_DNTM => GetNullableInt("DNTM");

		/// <summary>
		/// Description: Receipt quantity
		/// FieldName: RCQT
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Receipt quantity")]
		public decimal? M3_RCQT => GetNullableDecimal("RCQT");

		/// <summary>
		/// Description: Receipt date
		/// FieldName: RCDT
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Receipt date")]
		public DateTime? M3_RCDT => GetNullableDateTime("RCDT");

		/// <summary>
		/// Description: Receipt time
		/// FieldName: RCTM
		/// FieldType: N
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Receipt time")]
		public int? M3_RCTM => GetNullableInt("RCTM");

		/// <summary>
		/// Description: Delivery note exists
		/// FieldName: DNEX
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Delivery note exists")]
		public int? M3_DNEX => GetNullableInt("DNEX");
	}
}
// EOF
