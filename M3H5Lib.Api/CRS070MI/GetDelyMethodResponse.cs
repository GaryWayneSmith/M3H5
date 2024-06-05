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

namespace M3H5Lib.Api.CRS070MI
{
	public partial class GetDelyMethodResponse : M3BaseRecord 
	{

		/// <summary>
		/// Description: Deliverymethod
		/// FieldName: MODL
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Deliverymethod")]
		public string M3MODL => GetString("MODL");

		/// <summary>
		/// Description: Language
		/// FieldName: LNCD
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Language")]
		public string M3LNCD => GetString("LNCD");

		/// <summary>
		/// Description: Name
		/// FieldName: TX15
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Name")]
		public string M3TX15 => GetString("TX15");

		/// <summary>
		/// Description: Termstext
		/// FieldName: TEL1
		/// FieldType: A
		/// Length: 36
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Termstext")]
		public string M3TEL1 => GetString("TEL1");

		/// <summary>
		/// Description: Termstext
		/// FieldName: TEL2
		/// FieldType: A
		/// Length: 36
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Termstext")]
		public string M3TEL2 => GetString("TEL2");

		/// <summary>
		/// Description: Transport method - trade stat (TST)
		/// FieldName: VRDL
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Transport method - trade stat (TST)")]
		public int? M3VRDL => GetNullableInt("VRDL");

		/// <summary>
		/// Description: Containerused
		/// FieldName: COTT
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Containerused")]
		public int? M3COTT => GetNullableInt("COTT");
	}
}
// EOF
