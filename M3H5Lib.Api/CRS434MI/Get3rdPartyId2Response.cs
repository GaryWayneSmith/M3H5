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

namespace M3H5Lib.Api.CRS434MI
{
	public partial class Get3rdPartyId2Response : M3BaseRecord 
	{

		/// <summary>
		/// Description: 3rd-party id
		/// FieldName: TRDI
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("3rd-party id")]
		public string M3TRDI => GetString("TRDI");

		/// <summary>
		/// Description: 3rd-party provider
		/// FieldName: TRDP
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("3rd-party provider")]
		public string M3TRDP => GetString("TRDP");

		/// <summary>
		/// Description: Merchant id
		/// FieldName: MEID
		/// FieldType: N
		/// Length: 9
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Merchant id")]
		public int? M3MEID => GetNullableInt("MEID");

		/// <summary>
		/// Description: User
		/// FieldName: US65
		/// FieldType: A
		/// Length: 65
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("User")]
		public string M3US65 => GetString("US65");

		/// <summary>
		/// Description: Password
		/// FieldName: PWRD
		/// FieldType: A
		/// Length: 35
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Password")]
		public string M3PWRD => GetString("PWRD");

		/// <summary>
		/// Description: Host address
		/// FieldName: HADR
		/// FieldType: A
		/// Length: 65
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Host address")]
		public string M3HADR => GetString("HADR");

		/// <summary>
		/// Description: Host port
		/// FieldName: HPOR
		/// FieldType: N
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Host port")]
		public int? M3HPOR => GetNullableInt("HPOR");

		/// <summary>
		/// Description: Timeout in seconds
		/// FieldName: TOSE
		/// FieldType: N
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Timeout in seconds")]
		public int? M3TOSE => GetNullableInt("TOSE");

		/// <summary>
		/// Description: Vendor
		/// FieldName: VEND
		/// FieldType: A
		/// Length: 65
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Vendor")]
		public string M3VEND => GetString("VEND");

		/// <summary>
		/// Description: Partner
		/// FieldName: PART
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Partner")]
		public string M3PART => GetString("PART");

		/// <summary>
		/// Description: Proxy address
		/// FieldName: PRXA
		/// FieldType: A
		/// Length: 65
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Proxy address")]
		public string M3PRXA => GetString("PRXA");

		/// <summary>
		/// Description: Proxy port
		/// FieldName: PRXP
		/// FieldType: N
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Proxy port")]
		public int? M3PRXP => GetNullableInt("PRXP");

		/// <summary>
		/// Description: Proxy logon
		/// FieldName: PRXL
		/// FieldType: A
		/// Length: 65
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Proxy logon")]
		public string M3PRXL => GetString("PRXL");

		/// <summary>
		/// Description: Proxy password
		/// FieldName: PRXW
		/// FieldType: A
		/// Length: 35
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Proxy password")]
		public string M3PRXW => GetString("PRXW");

		/// <summary>
		/// Description: User-defined field
		/// FieldName: UD01
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("User-defined field")]
		public string M3UD01 => GetString("UD01");

		/// <summary>
		/// Description: User-defined field
		/// FieldName: UD02
		/// FieldType: A
		/// Length: 35
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("User-defined field")]
		public string M3UD02 => GetString("UD02");

		/// <summary>
		/// Description: User-defined field
		/// FieldName: UD03
		/// FieldType: A
		/// Length: 99
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("User-defined field")]
		public string M3UD03 => GetString("UD03");

		/// <summary>
		/// Description: User-defined field
		/// FieldName: UD04
		/// FieldType: A
		/// Length: 99
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("User-defined field")]
		public string M3UD04 => GetString("UD04");

		/// <summary>
		/// Description: Text identity
		/// FieldName: TXID
		/// FieldType: N
		/// Length: 13
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Text identity")]
		public decimal? M3TXID => GetNullableDecimal("TXID");

		/// <summary>
		/// Description: URL address
		/// FieldName: URLA
		/// FieldType: A
		/// Length: 256
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("URL address")]
		public string M3URLA => GetString("URLA");

		/// <summary>
		/// Description: Authorization days
		/// FieldName: AUDY
		/// FieldType: N
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Authorization days")]
		public int? M3AUDY => GetNullableInt("AUDY");
	}
}
// EOF
