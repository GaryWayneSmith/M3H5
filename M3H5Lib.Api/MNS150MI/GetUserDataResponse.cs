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

namespace M3H5Lib.Api.MNS150MI
{
	public partial class GetUserDataResponse : M3BaseRecord 
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
		/// Description: Division
		/// FieldName: DIVI
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Division")]
		public string M3DIVI => GetString("DIVI");

		/// <summary>
		/// Description: Language
		/// FieldName: LANC
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Language")]
		public string M3LANC => GetString("LANC");

		/// <summary>
		/// Description: Date format
		/// FieldName: DTFM
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Date format")]
		public string M3DTFM => GetString("DTFM");

		/// <summary>
		/// Description: Decimal format
		/// FieldName: DCFM
		/// FieldType: A
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Decimal format")]
		public string M3DCFM => GetString("DCFM");

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
		/// Description: Facility
		/// FieldName: FACI
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Facility")]
		public string M3FACI => GetString("FACI");

		/// <summary>
		/// Description: Warehouse
		/// FieldName: WHLO
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Warehouse")]
		public string M3WHLO => GetString("WHLO");

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
		/// Description: Department
		/// FieldName: DEPT
		/// FieldType: A
		/// Length: 8
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Department")]
		public string M3DEPT => GetString("DEPT");

		/// <summary>
		/// Description: Company name
		/// FieldName: TX40
		/// FieldType: A
		/// Length: 40
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Company name")]
		public string M3TX40 => GetString("TX40");

		/// <summary>
		/// Description: Division name
		/// FieldName: CONM
		/// FieldType: A
		/// Length: 40
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Division name")]
		public string M3CONM => GetString("CONM");

		/// <summary>
		/// Description: Menu version
		/// FieldName: MNVR
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Menu version")]
		public string M3MNVR => GetString("MNVR");

		/// <summary>
		/// Description: Start menu
		/// FieldName: DFMN
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Start menu")]
		public string M3DFMN => GetString("DFMN");

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
		/// Description: Name
		/// FieldName: NAME
		/// FieldType: A
		/// Length: 36
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Name")]
		public string M3NAME => GetString("NAME");

		/// <summary>
		/// Description: Equipment alias search sequense
		/// FieldName: EQAL
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Equipment alias search sequense")]
		public string M3EQAL => GetString("EQAL");

		/// <summary>
		/// Description: User status
		/// FieldName: USTA
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("User status")]
		public string M3USTA => GetString("USTA");

		/// <summary>
		/// Description: Electronic mail address
		/// FieldName: EMAL
		/// FieldType: A
		/// Length: 60
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Electronic mail address")]
		public string M3EMAL => GetString("EMAL");

		/// <summary>
		/// Description: User type
		/// FieldName: USTP
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("User type")]
		public string M3USTP => GetString("USTP");

		/// <summary>
		/// Description: External user id
		/// FieldName: EUID
		/// FieldType: A
		/// Length: 256
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("External user id")]
		public string M3EUID => GetString("EUID");

		/// <summary>
		/// Description: Telephone number
		/// FieldName: PHNO
		/// FieldType: A
		/// Length: 16
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Telephone number")]
		public string M3PHNO => GetString("PHNO");

		/// <summary>
		/// Description: Facsimile transmission number
		/// FieldName: TFNO
		/// FieldType: A
		/// Length: 16
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Facsimile transmission number")]
		public string M3TFNO => GetString("TFNO");

		/// <summary>
		/// Description: Free field 1
		/// FieldName: FRF6
		/// FieldType: A
		/// Length: 30
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Free field 1")]
		public string M3FRF6 => GetString("FRF6");

		/// <summary>
		/// Description: Free field 2
		/// FieldName: FRF7
		/// FieldType: A
		/// Length: 30
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Free field 2")]
		public string M3FRF7 => GetString("FRF7");

		/// <summary>
		/// Description: Free field 3
		/// FieldName: FRF8
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Free field 3")]
		public decimal? M3FRF8 => GetNullableDecimal("FRF8");

		/// <summary>
		/// Description: First active date
		/// FieldName: FADT
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("First active date")]
		public DateTime? M3FADT => GetNullableDateTime("FADT");

		/// <summary>
		/// Description: Last active date
		/// FieldName: LADT
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Last active date")]
		public DateTime? M3LADT => GetNullableDateTime("LADT");
	}
}
// EOF
