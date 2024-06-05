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

namespace M3H5Lib.Api.DCS001MI
{
	public partial class GetStatusByCardResponse : M3BaseRecord 
	{

		/// <summary>
		/// Description: Setup work in progress
		/// FieldName: SEIN
		/// FieldType: A
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Setup work in progress")]
		public string M3SEIN => GetString("SEIN");

		/// <summary>
		/// Description: Setup work is stoppable
		/// FieldName: SEST
		/// FieldType: A
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Setup work is stoppable")]
		public string M3SEST => GetString("SEST");

		/// <summary>
		/// Description: Operation work in progress
		/// FieldName: OPIN
		/// FieldType: A
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Operation work in progress")]
		public string M3OPIN => GetString("OPIN");

		/// <summary>
		/// Description: Operation work is stoppable
		/// FieldName: OPST
		/// FieldType: A
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Operation work is stoppable")]
		public string M3OPST => GetString("OPST");

		/// <summary>
		/// Description: Disturbance work in progress
		/// FieldName: DIIN
		/// FieldType: A
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Disturbance work in progress")]
		public string M3DIIN => GetString("DIIN");

		/// <summary>
		/// Description: Disturbance work is stoppable
		/// FieldName: DIST
		/// FieldType: A
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Disturbance work is stoppable")]
		public string M3DIST => GetString("DIST");
	}
}
// EOF
