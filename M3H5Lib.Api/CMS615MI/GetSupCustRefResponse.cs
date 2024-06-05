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

namespace M3H5Lib.Api.CMS615MI
{
	public partial class GetSupCustRefResponse : M3BaseRecord 
	{

		/// <summary>
		/// Description: Customer
		/// FieldName: CUNO
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Customer")]
		public string M3CUNO => GetString("CUNO");

		/// <summary>
		/// Description: Supplier
		/// FieldName: SUNO
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Supplier")]
		public string M3SUNO => GetString("SUNO");

		/// <summary>
		/// Description: Supplier's customer reference
		/// FieldName: CSRE
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Supplier's customer reference")]
		public string M3CSRE => GetString("CSRE");

		/// <summary>
		/// Description: Supplier reference type
		/// FieldName: CSRT
		/// FieldType: N
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Supplier reference type")]
		public int? M3CSRT => GetNullableInt("CSRT");
	}
}
// EOF
