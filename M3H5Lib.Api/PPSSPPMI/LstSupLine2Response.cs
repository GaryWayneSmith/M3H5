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

namespace M3H5Lib.Api.PPSSPPMI
{
	public partial class LstSupLine2Response : M3BaseRecord 
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
		/// Description: Purchase order number
		/// FieldName: PUNO
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Purchase order number")]
		public string M3_PUNO => GetString("PUNO");

		/// <summary>
		/// Description: Purchase order line
		/// FieldName: PNLI
		/// FieldType: N
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Purchase order line")]
		public int? M3_PNLI => GetNullableInt("PNLI");

		/// <summary>
		/// Description: Purchase order line subnumber
		/// FieldName: PNLS
		/// FieldType: N
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Purchase order line subnumber")]
		public int? M3_PNLS => GetNullableInt("PNLS");

		/// <summary>
		/// Description: Main product
		/// FieldName: HDPR
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Main product")]
		public string M3_HDPR => GetString("HDPR");

		/// <summary>
		/// Description: Name
		/// FieldName: ITDS
		/// FieldType: A
		/// Length: 30
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Name")]
		public string M3_ITDS => GetString("ITDS");

		/// <summary>
		/// Description: Style description
		/// FieldName: FUDS
		/// FieldType: A
		/// Length: 60
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Style description")]
		public string M3_FUDS => GetString("FUDS");

		/// <summary>
		/// Description: X-option
		/// FieldName: OPTX
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("X-option")]
		public string M3_OPTX => GetString("OPTX");

		/// <summary>
		/// Description: X-option Name
		/// FieldName: OXTX
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("X-option Name")]
		public string M3_OXTX => GetString("OXTX");

		/// <summary>
		/// Description: Y-option
		/// FieldName: OPTY
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Y-option")]
		public string M3_OPTY => GetString("OPTY");

		/// <summary>
		/// Description: Y-option Name
		/// FieldName: OYTX
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Y-option Name")]
		public string M3_OYTX => GetString("OYTX");

		/// <summary>
		/// Description: Z-option
		/// FieldName: OPTZ
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Z-option")]
		public string M3_OPTZ => GetString("OPTZ");

		/// <summary>
		/// Description: Z-option Name
		/// FieldName: OZTX
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Z-option Name")]
		public string M3_OZTX => GetString("OZTX");

		/// <summary>
		/// Description: Configuration code
		/// FieldName: CHCD
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Configuration code")]
		public int? M3_CHCD => GetNullableInt("CHCD");

		/// <summary>
		/// Description: Feature ID X Text
		/// FieldName: FTIX
		/// FieldType: A
		/// Length: 30
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Feature ID X Text")]
		public string M3_FTIX => GetString("FTIX");

		/// <summary>
		/// Description: Feature ID Y Text
		/// FieldName: FTIY
		/// FieldType: A
		/// Length: 30
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Feature ID Y Text")]
		public string M3_FTIY => GetString("FTIY");

		/// <summary>
		/// Description: Feature ID Z Text
		/// FieldName: FTIZ
		/// FieldType: A
		/// Length: 30
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Feature ID Z Text")]
		public string M3_FTIZ => GetString("FTIZ");

		/// <summary>
		/// Description: Sequence number for sorting X
		/// FieldName: SQFX
		/// FieldType: N
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Sequence number for sorting X")]
		public int? M3_SQFX => GetNullableInt("SQFX");

		/// <summary>
		/// Description: Sequence number for sorting Y
		/// FieldName: SQFY
		/// FieldType: N
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Sequence number for sorting Y")]
		public int? M3_SQFY => GetNullableInt("SQFY");

		/// <summary>
		/// Description: Sequence number for sorting Z
		/// FieldName: SQFZ
		/// FieldType: N
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Sequence number for sorting Z")]
		public int? M3_SQFZ => GetNullableInt("SQFZ");

		/// <summary>
		/// Description: X-option Text
		/// FieldName: TX30
		/// FieldType: A
		/// Length: 30
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("X-option Text")]
		public string M3_TX30 => GetString("TX30");

		/// <summary>
		/// Description: Y-option Text
		/// FieldName: TY30
		/// FieldType: A
		/// Length: 30
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Y-option Text")]
		public string M3_TY30 => GetString("TY30");

		/// <summary>
		/// Description: Z-option Text
		/// FieldName: TZ30
		/// FieldType: A
		/// Length: 30
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Z-option Text")]
		public string M3_TZ30 => GetString("TZ30");

		/// <summary>
		/// Description: Feature group X Name
		/// FieldName: TX15
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Feature group X Name")]
		public string M3_TX15 => GetString("TX15");

		/// <summary>
		/// Description: Feature group Y Name
		/// FieldName: TY15
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Feature group Y Name")]
		public string M3_TY15 => GetString("TY15");

		/// <summary>
		/// Description: Feature group Z Name
		/// FieldName: TZ15
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Feature group Z Name")]
		public string M3_TZ15 => GetString("TZ15");

		/// <summary>
		/// Description: Timestamp
		/// FieldName: LMTS
		/// FieldType: N
		/// Length: 18
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Timestamp")]
		public decimal? M3_LMTS => GetNullableDecimal("LMTS");
	}
}
// EOF
