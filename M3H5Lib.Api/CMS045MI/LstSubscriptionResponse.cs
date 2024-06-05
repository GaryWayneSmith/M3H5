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

namespace M3H5Lib.Api.CMS045MI
{
	public partial class LstSubscriptionResponse : M3BaseRecord 
	{

		/// <summary>
		/// Description: Event publisher
		/// FieldName: EVPB
		/// FieldType: A
		/// Length: 30
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Event publisher")]
		public string M3_EVPB => GetString("EVPB");

		/// <summary>
		/// Description: Event name
		/// FieldName: EVNM
		/// FieldType: A
		/// Length: 30
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Event name")]
		public string M3_EVNM => GetString("EVNM");

		/// <summary>
		/// Description: Event name operation
		/// FieldName: EVNO
		/// FieldType: A
		/// Length: 30
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Event name operation")]
		public string M3_EVNO => GetString("EVNO");

		/// <summary>
		/// Description: Status
		/// FieldName: STAT
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Status")]
		public string M3_STAT => GetString("STAT");

		/// <summary>
		/// Description: Include/exclude in event mapping
		/// FieldName: INEM
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Include/exclude in event mapping")]
		public int? M3_INEM => GetNullableInt("INEM");

		/// <summary>
		/// Description: Include/exclude in event alerts
		/// FieldName: INEA
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Include/exclude in event alerts")]
		public int? M3_INEA => GetNullableInt("INEA");

		/// <summary>
		/// Description: Include in event Db changes
		/// FieldName: INEC
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Include in event Db changes")]
		public int? M3_INEC => GetNullableInt("INEC");
	}
}
// EOF