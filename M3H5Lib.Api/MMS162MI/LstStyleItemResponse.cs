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

namespace M3H5Lib.Api.MMS162MI
{
	public partial class LstStyleItemResponse : M3BaseRecord 
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
		/// Description: Item number
		/// FieldName: ITNO
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Item number")]
		public string M3ITNO => GetString("ITNO");

		/// <summary>
		/// Description: Style number
		/// FieldName: STYN
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Style number")]
		public string M3STYN => GetString("STYN");

		/// <summary>
		/// Description: Feature for X
		/// FieldName: FTIX
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Feature for X")]
		public string M3FTIX => GetString("FTIX");

		/// <summary>
		/// Description: Sorting for feature
		/// FieldName: SQFX
		/// FieldType: N
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Sorting for feature")]
		public int? M3SQFX => GetNullableInt("SQFX");

		/// <summary>
		/// Description: Option for feature X
		/// FieldName: OPTX
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Option for feature X")]
		public string M3OPTX => GetString("OPTX");

		/// <summary>
		/// Description: Sorting for option
		/// FieldName: SQNX
		/// FieldType: N
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Sorting for option")]
		public int? M3SQNX => GetNullableInt("SQNX");

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
		/// Description: Feature for Y
		/// FieldName: FTIY
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Feature for Y")]
		public string M3FTIY => GetString("FTIY");

		/// <summary>
		/// Description: Sorting for feature
		/// FieldName: SQFY
		/// FieldType: N
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Sorting for feature")]
		public int? M3SQFY => GetNullableInt("SQFY");

		/// <summary>
		/// Description: Option for feature Y
		/// FieldName: OPTY
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Option for feature Y")]
		public string M3OPTY => GetString("OPTY");

		/// <summary>
		/// Description: Sorting for option
		/// FieldName: SQNY
		/// FieldType: N
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Sorting for option")]
		public int? M3SQNY => GetNullableInt("SQNY");

		/// <summary>
		/// Description: Name for Y-option
		/// FieldName: TY15
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Name for Y-option")]
		public string M3TY15 => GetString("TY15");

		/// <summary>
		/// Description: Feature for Z
		/// FieldName: FTIZ
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Feature for Z")]
		public string M3FTIZ => GetString("FTIZ");

		/// <summary>
		/// Description: Sorting for feature
		/// FieldName: SQFZ
		/// FieldType: N
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Sorting for feature")]
		public int? M3SQFZ => GetNullableInt("SQFZ");

		/// <summary>
		/// Description: Option for feature Z
		/// FieldName: OPTZ
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Option for feature Z")]
		public string M3OPTZ => GetString("OPTZ");

		/// <summary>
		/// Description: Sorting for option
		/// FieldName: SQNZ
		/// FieldType: N
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Sorting for option")]
		public int? M3SQNZ => GetNullableInt("SQNZ");

		/// <summary>
		/// Description: Name for Z-option
		/// FieldName: TZ15
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Name for Z-option")]
		public string M3TZ15 => GetString("TZ15");

		/// <summary>
		/// Description: Configuration code
		/// FieldName: CHCD
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Configuration code")]
		public int? M3CHCD => GetNullableInt("CHCD");
	}
}
// EOF
