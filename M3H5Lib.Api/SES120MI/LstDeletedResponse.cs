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

namespace M3H5Lib.Api.SES120MI
{
	public partial class LstDeletedResponse : M3BaseRecord 
	{

		/// <summary>
		/// Description: Entry date
		/// FieldName: RGDT
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Entry date")]
		public DateTime? M3RGDT => GetNullableDateTime("RGDT");

		/// <summary>
		/// Description: Entry time
		/// FieldName: RGTM
		/// FieldType: N
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Entry time")]
		public int? M3RGTM => GetNullableInt("RGTM");

		/// <summary>
		/// Description: User
		/// FieldName: USID
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("User")]
		public string M3USID => GetString("USID");

		/// <summary>
		/// Description: Key value 1
		/// FieldName: KEY1
		/// FieldType: A
		/// Length: 60
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Key value 1")]
		public string M3KEY1 => GetString("KEY1");

		/// <summary>
		/// Description: Key value 2
		/// FieldName: KEY2
		/// FieldType: A
		/// Length: 60
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Key value 2")]
		public string M3KEY2 => GetString("KEY2");

		/// <summary>
		/// Description: Key value 3
		/// FieldName: KEY3
		/// FieldType: A
		/// Length: 60
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Key value 3")]
		public string M3KEY3 => GetString("KEY3");

		/// <summary>
		/// Description: Key value 4
		/// FieldName: KEY4
		/// FieldType: A
		/// Length: 60
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Key value 4")]
		public string M3KEY4 => GetString("KEY4");

		/// <summary>
		/// Description: Key value 5
		/// FieldName: KEY5
		/// FieldType: A
		/// Length: 60
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Key value 5")]
		public string M3KEY5 => GetString("KEY5");

		/// <summary>
		/// Description: Key value 6
		/// FieldName: KEY6
		/// FieldType: A
		/// Length: 60
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Key value 6")]
		public string M3KEY6 => GetString("KEY6");

		/// <summary>
		/// Description: Key value 7
		/// FieldName: KEY7
		/// FieldType: A
		/// Length: 60
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Key value 7")]
		public string M3KEY7 => GetString("KEY7");

		/// <summary>
		/// Description: Key value 8
		/// FieldName: KEY8
		/// FieldType: A
		/// Length: 60
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Key value 8")]
		public string M3KEY8 => GetString("KEY8");

		/// <summary>
		/// Description: Key value 9
		/// FieldName: KEY9
		/// FieldType: A
		/// Length: 60
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Key value 9")]
		public string M3KEY9 => GetString("KEY9");

		/// <summary>
		/// Description: Key value 10
		/// FieldName: KE10
		/// FieldType: A
		/// Length: 60
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Key value 10")]
		public string M3KE10 => GetString("KE10");

		/// <summary>
		/// Description: Key value 11
		/// FieldName: KE11
		/// FieldType: A
		/// Length: 60
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Key value 11")]
		public string M3KE11 => GetString("KE11");

		/// <summary>
		/// Description: Key value 12
		/// FieldName: KE12
		/// FieldType: A
		/// Length: 60
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Key value 12")]
		public string M3KE12 => GetString("KE12");

		/// <summary>
		/// Description: Key value 13
		/// FieldName: KE13
		/// FieldType: A
		/// Length: 60
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Key value 13")]
		public string M3KE13 => GetString("KE13");

		/// <summary>
		/// Description: Key value 14
		/// FieldName: KE14
		/// FieldType: A
		/// Length: 60
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Key value 14")]
		public string M3KE14 => GetString("KE14");

		/// <summary>
		/// Description: Key value 15
		/// FieldName: KE15
		/// FieldType: A
		/// Length: 60
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Key value 15")]
		public string M3KE15 => GetString("KE15");

		/// <summary>
		/// Description: Key value 16
		/// FieldName: KE16
		/// FieldType: A
		/// Length: 58
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Key value 16")]
		public string M3KE16 => GetString("KE16");
	}
}
// EOF
