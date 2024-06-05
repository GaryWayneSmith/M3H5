/// **********************************************************************
/// This class is auto-generated.
/// Updated: 6/5/2024 3:52:20 PM
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

namespace M3H5Lib.Api.TXS095MI
{
	public partial class GetTaxAgentSetResponse : M3BaseRecord 
	{

		/// <summary>
		/// Description: Agent
		/// FieldName: TIAG
		/// FieldType: N
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Agent")]
		public int? M3TIAG => GetNullableInt("TIAG");

		/// <summary>
		/// Description: Transfer method
		/// FieldName: TIMT
		/// FieldType: N
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Transfer method")]
		public int? M3TIMT => GetNullableInt("TIMT");

		/// <summary>
		/// Description: Issuing number system
		/// FieldName: TIIN
		/// FieldType: A
		/// Length: 8
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Issuing number system")]
		public string M3TIIN => GetString("TIIN");

		/// <summary>
		/// Description: Business code
		/// FieldName: TIBC
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Business code")]
		public string M3TIBC => GetString("TIBC");

		/// <summary>
		/// Description: Client code
		/// FieldName: TICC
		/// FieldType: A
		/// Length: 8
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Client code")]
		public string M3TICC => GetString("TICC");

		/// <summary>
		/// Description: Sequence number
		/// FieldName: TISQ
		/// FieldType: N
		/// Length: 4
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Sequence number")]
		public int? M3TISQ => GetNullableInt("TISQ");

		/// <summary>
		/// Description: Certificate password
		/// FieldName: TIPW
		/// FieldType: A
		/// Length: 60
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Certificate password")]
		public string M3TIPW => GetString("TIPW");

		/// <summary>
		/// Description: Encryption key
		/// FieldName: TIEK
		/// FieldType: A
		/// Length: 60
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Encryption key")]
		public string M3TIEK => GetString("TIEK");

		/// <summary>
		/// Description: Keystore id
		/// FieldName: TIKI
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Keystore id")]
		public string M3TIKI => GetString("TIKI");

		/// <summary>
		/// Description: Rvalue
		/// FieldName: TIRV
		/// FieldType: A
		/// Length: 256
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Rvalue")]
		public string M3TIRV => GetString("TIRV");

		/// <summary>
		/// Description: Smartbills server
		/// FieldName: TISB
		/// FieldType: A
		/// Length: 265
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Smartbills server")]
		public string M3TISB => GetString("TISB");

		/// <summary>
		/// Description: Authentification token
		/// FieldName: TIAT
		/// FieldType: A
		/// Length: 250
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Authentification token")]
		public string M3TIAT => GetString("TIAT");

		/// <summary>
		/// Description: Authentification token valid date
		/// FieldName: TIDA
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Authentification token valid date")]
		public DateTime? M3TIDA => GetNullableDateTime("TIDA");

		/// <summary>
		/// Description: Authentication code for customer company
		/// FieldName: TIAC
		/// FieldType: A
		/// Length: 32
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Authentication code for customer company")]
		public string M3TIAC => GetString("TIAC");

		/// <summary>
		/// Description: Tax registration ID
		/// FieldName: TRGI
		/// FieldType: A
		/// Length: 4
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Tax registration ID")]
		public string M3TRGI => GetString("TRGI");

		/// <summary>
		/// Description: Save XML
		/// FieldName: SXML
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Save XML")]
		public int? M3SXML => GetNullableInt("SXML");
	}
}
// EOF
