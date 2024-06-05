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

namespace M3H5Lib.Api.LTS101MI
{
	public partial class LstAgreeKitResponse : M3BaseRecord 
	{

		/// <summary>
		/// Description: Kit number
		/// FieldName: KTNO
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Kit number")]
		public string M3_KTNO => GetString("KTNO");

		/// <summary>
		/// Description: Index adjustment line
		/// FieldName: INAL
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Index adjustment line")]
		public int? M3_INAL => GetNullableInt("INAL");

		/// <summary>
		/// Description: Price type
		/// FieldName: AFPT
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Price type")]
		public int? M3_AFPT => GetNullableInt("AFPT");

		/// <summary>
		/// Description: Name
		/// FieldName: KTDS
		/// FieldType: A
		/// Length: 30
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Name")]
		public string M3_KTDS => GetString("KTDS");
	}
}
// EOF
