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

namespace M3H5Lib.Api.DRS045MI
{
	public partial class ConvertByRefResponse : M3BaseRecord 
	{

		/// <summary>
		/// Description: Company
		/// FieldName: CONO
		/// FieldType: N
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Company")]
		public int? M3CONO => GetNullableInt("CONO");

		/// <summary>
		/// Description: From date
		/// FieldName: FRDT
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("From date")]
		public DateTime? M3FRDT => GetNullableDateTime("FRDT");

		/// <summary>
		/// Description: From time
		/// FieldName: FRTM
		/// FieldType: A
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("From time")]
		public string M3FRTM => GetString("FRTM");

		/// <summary>
		/// Description: From reference
		/// FieldName: FRTB
		/// FieldType: A
		/// Length: 4
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("From reference")]
		public string M3FRTB => GetString("FRTB");

		/// <summary>
		/// Description: From ID
		/// FieldName: FRIA
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("From ID")]
		public string M3FRIA => GetString("FRIA");

		/// <summary>
		/// Description: From time zone
		/// FieldName: FRTZ
		/// FieldType: A
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("From time zone")]
		public string M3FRTZ => GetString("FRTZ");

		/// <summary>
		/// Description: To date
		/// FieldName: TODT
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("To date")]
		public DateTime? M3TODT => GetNullableDateTime("TODT");

		/// <summary>
		/// Description: To time
		/// FieldName: TOTM
		/// FieldType: A
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("To time")]
		public string M3TOTM => GetString("TOTM");

		/// <summary>
		/// Description: To reference
		/// FieldName: TOTB
		/// FieldType: A
		/// Length: 4
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("To reference")]
		public string M3TOTB => GetString("TOTB");

		/// <summary>
		/// Description: To ID
		/// FieldName: TOIA
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("To ID")]
		public string M3TOIA => GetString("TOIA");

		/// <summary>
		/// Description: To time zone
		/// FieldName: TOTZ
		/// FieldType: A
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("To time zone")]
		public string M3TOTZ => GetString("TOTZ");
	}
}
// EOF
