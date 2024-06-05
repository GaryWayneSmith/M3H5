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

namespace M3H5Lib.Api.MMS200MI
{
	public partial class LstStyleResponse : M3BaseRecord 
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
		/// Description: Item number
		/// FieldName: ITNO
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Item number")]
		public string M3_ITNO => GetString("ITNO");

		/// <summary>
		/// Description: Style number
		/// FieldName: STYN
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Style number")]
		public string M3_STYN => GetString("STYN");

		/// <summary>
		/// Description: Sequence number for sorting
		/// FieldName: SQFZ
		/// FieldType: N
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Sequence number for sorting")]
		public int? M3_SQFZ => GetNullableInt("SQFZ");

		/// <summary>
		/// Description: Feature
		/// FieldName: FTIZ
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Feature")]
		public string M3_FTIZ => GetString("FTIZ");

		/// <summary>
		/// Description: Sequence number for sorting
		/// FieldName: SQNZ
		/// FieldType: N
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Sequence number for sorting")]
		public int? M3_SQNZ => GetNullableInt("SQNZ");

		/// <summary>
		/// Description: Option
		/// FieldName: OPTZ
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Option")]
		public string M3_OPTZ => GetString("OPTZ");

		/// <summary>
		/// Description: Name
		/// FieldName: TZ15
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Name")]
		public string M3_TZ15 => GetString("TZ15");

		/// <summary>
		/// Description: Sequence number for sorting
		/// FieldName: SQFX
		/// FieldType: N
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Sequence number for sorting")]
		public int? M3_SQFX => GetNullableInt("SQFX");

		/// <summary>
		/// Description: Feature
		/// FieldName: FTIX
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Feature")]
		public string M3_FTIX => GetString("FTIX");

		/// <summary>
		/// Description: Sequence number for sorting
		/// FieldName: SQNX
		/// FieldType: N
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Sequence number for sorting")]
		public int? M3_SQNX => GetNullableInt("SQNX");

		/// <summary>
		/// Description: Option
		/// FieldName: OPTX
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Option")]
		public string M3_OPTX => GetString("OPTX");

		/// <summary>
		/// Description: Name
		/// FieldName: TX15
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Name")]
		public string M3_TX15 => GetString("TX15");

		/// <summary>
		/// Description: Sequence number for sorting
		/// FieldName: SQFY
		/// FieldType: N
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Sequence number for sorting")]
		public int? M3_SQFY => GetNullableInt("SQFY");

		/// <summary>
		/// Description: Feature
		/// FieldName: FTIY
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Feature")]
		public string M3_FTIY => GetString("FTIY");

		/// <summary>
		/// Description: Sequence number for sorting
		/// FieldName: SQNY
		/// FieldType: N
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Sequence number for sorting")]
		public int? M3_SQNY => GetNullableInt("SQNY");

		/// <summary>
		/// Description: Option
		/// FieldName: OPTY
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Option")]
		public string M3_OPTY => GetString("OPTY");

		/// <summary>
		/// Description: Name
		/// FieldName: TY15
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Name")]
		public string M3_TY15 => GetString("TY15");

		/// <summary>
		/// Description: Season control
		/// FieldName: SECH
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Season control")]
		public int? M3_SECH => GetNullableInt("SECH");

		/// <summary>
		/// Description: Entry date
		/// FieldName: RGDT
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Entry date")]
		public DateTime? M3_RGDT => GetNullableDateTime("RGDT");

		/// <summary>
		/// Description: Entry time
		/// FieldName: RGTM
		/// FieldType: N
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Entry time")]
		public int? M3_RGTM => GetNullableInt("RGTM");

		/// <summary>
		/// Description: Change date
		/// FieldName: LMDT
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Change date")]
		public DateTime? M3_LMDT => GetNullableDateTime("LMDT");

		/// <summary>
		/// Description: Change number
		/// FieldName: CHNO
		/// FieldType: N
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Change number")]
		public int? M3_CHNO => GetNullableInt("CHNO");

		/// <summary>
		/// Description: Changed by
		/// FieldName: CHID
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Changed by")]
		public string M3_CHID => GetString("CHID");

		/// <summary>
		/// Description: Phantom ID
		/// FieldName: PHID
		/// FieldType: A
		/// Length: 32
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Phantom ID")]
		public string M3_PHID => GetString("PHID");

		/// <summary>
		/// Description: Color
		/// FieldName: COLO
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Color")]
		public string M3_COLO => GetString("COLO");

		/// <summary>
		/// Description: Sequence number for sorting
		/// FieldName: SFCO
		/// FieldType: N
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Sequence number for sorting")]
		public int? M3_SFCO => GetNullableInt("SFCO");

		/// <summary>
		/// Description: Sequence number for sorting
		/// FieldName: SQCO
		/// FieldType: N
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Sequence number for sorting")]
		public int? M3_SQCO => GetNullableInt("SQCO");

		/// <summary>
		/// Description: Axis for color
		/// FieldName: AXCO
		/// FieldType: A
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Axis for color")]
		public string M3_AXCO => GetString("AXCO");

		/// <summary>
		/// Description: Size
		/// FieldName: SIZE
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Size")]
		public string M3_SIZE => GetString("SIZE");

		/// <summary>
		/// Description: Sequence number for sorting
		/// FieldName: SFSI
		/// FieldType: N
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Sequence number for sorting")]
		public int? M3_SFSI => GetNullableInt("SFSI");

		/// <summary>
		/// Description: Sequence number for sorting
		/// FieldName: SQSI
		/// FieldType: N
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Sequence number for sorting")]
		public int? M3_SQSI => GetNullableInt("SQSI");

		/// <summary>
		/// Description: Axis for size
		/// FieldName: AXSI
		/// FieldType: A
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Axis for size")]
		public string M3_AXSI => GetString("AXSI");

		/// <summary>
		/// Description: Characteristics
		/// FieldName: CHCS
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Characteristics")]
		public string M3_CHCS => GetString("CHCS");

		/// <summary>
		/// Description: Sequence number for sorting
		/// FieldName: SQCH
		/// FieldType: N
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Sequence number for sorting")]
		public int? M3_SQCH => GetNullableInt("SQCH");

		/// <summary>
		/// Description: Sequence number for sorting
		/// FieldName: SFCH
		/// FieldType: N
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Sequence number for sorting")]
		public int? M3_SFCH => GetNullableInt("SFCH");

		/// <summary>
		/// Description: Axis for characteristics
		/// FieldName: AXCH
		/// FieldType: A
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Axis for characteristics")]
		public string M3_AXCH => GetString("AXCH");

		/// <summary>
		/// Description: Kit indicator
		/// FieldName: KITI
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Kit indicator")]
		public int? M3_KITI => GetNullableInt("KITI");

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

		/// <summary>
		/// Description: Customer table extension
		/// FieldName: CUEX
		/// FieldType: A
		/// Length: 641
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Customer table extension")]
		public string M3_CUEX => GetString("CUEX");
	}
}
// EOF
