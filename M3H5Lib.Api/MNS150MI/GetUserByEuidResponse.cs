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

namespace M3H5Lib.Api.MNS150MI
{
	public partial class GetUserByEuidResponse : M3BaseRecord 
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
		public int? M3_CONO => GetNullableInt("CONO");

		/// <summary>
		/// Description: Division
		/// FieldName: DIVI
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Division")]
		public string M3_DIVI => GetString("DIVI");

		/// <summary>
		/// Description: External user ID
		/// FieldName: EUID
		/// FieldType: A
		/// Length: 256
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("External user ID")]
		public string M3_EUID => GetString("EUID");

		/// <summary>
		/// Description: User
		/// FieldName: USID
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("User")]
		public string M3_USID => GetString("USID");

		/// <summary>
		/// Description: Name
		/// FieldName: NAME
		/// FieldType: A
		/// Length: 36
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Name")]
		public string M3_NAME => GetString("NAME");

		/// <summary>
		/// Description: Language
		/// FieldName: LANC
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Language")]
		public string M3_LANC => GetString("LANC");

		/// <summary>
		/// Description: Date format
		/// FieldName: DTFM
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Date format")]
		public string M3_DTFM => GetString("DTFM");

		/// <summary>
		/// Description: Decimal format
		/// FieldName: DCFM
		/// FieldType: A
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Decimal format")]
		public string M3_DCFM => GetString("DCFM");

		/// <summary>
		/// Description: Time zone
		/// FieldName: TIZO
		/// FieldType: A
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Time zone")]
		public string M3_TIZO => GetString("TIZO");

		/// <summary>
		/// Description: Facility
		/// FieldName: FACI
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Facility")]
		public string M3_FACI => GetString("FACI");

		/// <summary>
		/// Description: Warehouse
		/// FieldName: WHLO
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Warehouse")]
		public string M3_WHLO => GetString("WHLO");

		/// <summary>
		/// Description: Customer
		/// FieldName: CUNO
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Customer")]
		public string M3_CUNO => GetString("CUNO");

		/// <summary>
		/// Description: Department
		/// FieldName: DEPT
		/// FieldType: A
		/// Length: 8
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Department")]
		public string M3_DEPT => GetString("DEPT");

		/// <summary>
		/// Description: Company name
		/// FieldName: TX40
		/// FieldType: A
		/// Length: 40
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Company name")]
		public string M3_TX40 => GetString("TX40");

		/// <summary>
		/// Description: Division name
		/// FieldName: CONM
		/// FieldType: A
		/// Length: 40
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Division name")]
		public string M3_CONM => GetString("CONM");

		/// <summary>
		/// Description: Menu version
		/// FieldName: MNVR
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Menu version")]
		public string M3_MNVR => GetString("MNVR");

		/// <summary>
		/// Description: Start menu
		/// FieldName: DFMN
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Start menu")]
		public string M3_DFMN => GetString("DFMN");

		/// <summary>
		/// Description: Equipment alias search sequense
		/// FieldName: EQAL
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Equipment alias search sequense")]
		public string M3_EQAL => GetString("EQAL");

		/// <summary>
		/// Description: User status
		/// FieldName: USTA
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("User status")]
		public string M3_USTA => GetString("USTA");

		/// <summary>
		/// Description: Electronic mail address
		/// FieldName: EMAL
		/// FieldType: A
		/// Length: 60
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Electronic mail address")]
		public string M3_EMAL => GetString("EMAL");

		/// <summary>
		/// Description: User type
		/// FieldName: USTP
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("User type")]
		public string M3_USTP => GetString("USTP");
	}
}
// EOF
