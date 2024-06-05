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

namespace M3H5Lib.Api.RPS120MI
{
	public partial class GetDEOTypeResponse : M3BaseRecord 
	{

		/// <summary>
		/// Description: Order type
		/// FieldName: ORTY
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Order type")]
		public string M3_ORTY => GetString("ORTY");

		/// <summary>
		/// Description: Description
		/// FieldName: TX40
		/// FieldType: A
		/// Length: 40
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Description")]
		public string M3_TX40 => GetString("TX40");

		/// <summary>
		/// Description: Name
		/// FieldName: TX15
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Name")]
		public string M3_TX15 => GetString("TX15");

		/// <summary>
		/// Description: Automatic implementation
		/// FieldName: AUIM
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Automatic implementation")]
		public int? M3_AUIM => GetNullableInt("AUIM");

		/// <summary>
		/// Description: Forward order update material plan
		/// FieldName: FWUP
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Forward order update material plan")]
		public int? M3_FWUP => GetNullableInt("FWUP");

		/// <summary>
		/// Description: Replenishment order
		/// FieldName: REOD
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Replenishment order")]
		public int? M3_REOD => GetNullableInt("REOD");

		/// <summary>
		/// Description: Allocate at reciept
		/// FieldName: ALAR
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Allocate at reciept")]
		public int? M3_ALAR => GetNullableInt("ALAR");

		/// <summary>
		/// Description: Purchase date type
		/// FieldName: DTDP
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Purchase date type")]
		public int? M3_DTDP => GetNullableInt("DTDP");
	}
}
// EOF