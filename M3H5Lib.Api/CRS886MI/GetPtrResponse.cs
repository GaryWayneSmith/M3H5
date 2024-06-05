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

namespace M3H5Lib.Api.CRS886MI
{
	public partial class GetPtrResponse : M3BaseRecord 
	{

		/// <summary>
		/// Description: Partner ID higher level
		/// FieldName: PAIH
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Partner ID higher level")]
		public string M3_PAIH => GetString("PAIH");

		/// <summary>
		/// Description: Partner qualifier
		/// FieldName: PAQU
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Partner qualifier")]
		public string M3_PAQU => GetString("PAQU");

		/// <summary>
		/// Description: Partner type
		/// FieldName: PATE
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Partner type")]
		public string M3_PATE => GetString("PATE");
	}
}
// EOF
