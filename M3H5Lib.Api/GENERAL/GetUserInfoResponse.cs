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

namespace M3H5Lib.Api.GENERAL
{
	public partial class GetUserInfoResponse : M3BaseRecord 
	{

		/// <summary>
		/// Description: User
		/// FieldName: ZZUSID
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("User")]
		public string M3ZZUSID => GetString("ZZUSID");

		/// <summary>
		/// Description: Company
		/// FieldName: ZDCONO
		/// FieldType: N
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Company")]
		public int? M3ZDCONO => GetNullableInt("ZDCONO");

		/// <summary>
		/// Description: Division
		/// FieldName: ZDDIVI
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Division")]
		public string M3ZDDIVI => GetString("ZDDIVI");

		/// <summary>
		/// Description: Facility
		/// FieldName: ZDFACI
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Facility")]
		public string M3ZDFACI => GetString("ZDFACI");

		/// <summary>
		/// Description: Warehouse
		/// FieldName: ZZWHLO
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Warehouse")]
		public string M3ZZWHLO => GetString("ZZWHLO");

		/// <summary>
		/// Description: User group-function access
		/// FieldName: ZDAUPF
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("User group-function access")]
		public string M3ZDAUPF => GetString("ZDAUPF");

		/// <summary>
		/// Description: Display item name in own language
		/// FieldName: ZDREPF
		/// FieldType: A
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Display item name in own language")]
		public string M3ZDREPF => GetString("ZDREPF");

		/// <summary>
		/// Description: System language
		/// FieldName: ZDLANC
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("System language")]
		public string M3ZDLANC => GetString("ZDLANC");

		/// <summary>
		/// Description: Date format
		/// FieldName: ZDDTFM
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Date format")]
		public string M3ZDDTFM => GetString("ZDDTFM");

		/// <summary>
		/// Description: Date separator
		/// FieldName: DSEP
		/// FieldType: A
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Date separator")]
		public string M3DSEP => GetString("DSEP");

		/// <summary>
		/// Description: Time separator
		/// FieldName: TSEP
		/// FieldType: A
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Time separator")]
		public string M3TSEP => GetString("TSEP");

		/// <summary>
		/// Description: Time zone
		/// FieldName: TIZO
		/// FieldType: A
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Time zone")]
		public string M3TIZO => GetString("TIZO");

		/// <summary>
		/// Description: User full name
		/// FieldName: USFN
		/// FieldType: A
		/// Length: 40
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("User full name")]
		public string M3USFN => GetString("USFN");
	}
}
// EOF
