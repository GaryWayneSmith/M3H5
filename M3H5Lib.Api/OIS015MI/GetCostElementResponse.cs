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

namespace M3H5Lib.Api.OIS015MI
{
	public partial class GetCostElementResponse : M3BaseRecord 
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
		/// Description: Element - sales price costing
		/// FieldName: SCEL
		/// FieldType: A
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Element - sales price costing")]
		public string M3SCEL => GetString("SCEL");

		/// <summary>
		/// Description: Element type - sales price costing
		/// FieldName: SCET
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Element type - sales price costing")]
		public int? M3SCET => GetNullableInt("SCET");

		/// <summary>
		/// Description: Description
		/// FieldName: TX40
		/// FieldType: A
		/// Length: 40
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Description")]
		public string M3TX40 => GetString("TX40");

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
		/// Description: Cost distribution key 1
		/// FieldName: PC01
		/// FieldType: A
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Cost distribution key 1")]
		public string M3PC01 => GetString("PC01");

		/// <summary>
		/// Description: Cost distribution key 2
		/// FieldName: PC02
		/// FieldType: A
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Cost distribution key 2")]
		public string M3PC02 => GetString("PC02");

		/// <summary>
		/// Description: Cost distribution key 3
		/// FieldName: PC03
		/// FieldType: A
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Cost distribution key 3")]
		public string M3PC03 => GetString("PC03");

		/// <summary>
		/// Description: Costing operator
		/// FieldName: WSOP
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Costing operator")]
		public string M3WSOP => GetString("WSOP");

		/// <summary>
		/// Description: Markup
		/// FieldName: POOV
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Markup")]
		public int? M3POOV => GetNullableInt("POOV");

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
		/// Description: Feature
		/// FieldName: FT01
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Feature")]
		public string M3FT01 => GetString("FT01");

		/// <summary>
		/// Description: Feature
		/// FieldName: FT02
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Feature")]
		public string M3FT02 => GetString("FT02");

		/// <summary>
		/// Description: Feature
		/// FieldName: FT03
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Feature")]
		public string M3FT03 => GetString("FT03");

		/// <summary>
		/// Description: Drawing measurement
		/// FieldName: DMI1
		/// FieldType: A
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Drawing measurement")]
		public string M3DMI1 => GetString("DMI1");

		/// <summary>
		/// Description: Drawing measurement
		/// FieldName: DMI2
		/// FieldType: A
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Drawing measurement")]
		public string M3DMI2 => GetString("DMI2");

		/// <summary>
		/// Description: Drawing measurement
		/// FieldName: DMI3
		/// FieldType: A
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Drawing measurement")]
		public string M3DMI3 => GetString("DMI3");

		/// <summary>
		/// Description: Attribute identity
		/// FieldName: ATI1
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Attribute identity")]
		public string M3ATI1 => GetString("ATI1");

		/// <summary>
		/// Description: Attribute identity
		/// FieldName: ATI2
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Attribute identity")]
		public string M3ATI2 => GetString("ATI2");

		/// <summary>
		/// Description: Attribute identity
		/// FieldName: ATI3
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Attribute identity")]
		public string M3ATI3 => GetString("ATI3");

		/// <summary>
		/// Description: Value in range
		/// FieldName: MRF1
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Value in range")]
		public int? M3MRF1 => GetNullableInt("MRF1");

		/// <summary>
		/// Description: Value in range
		/// FieldName: MRF2
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Value in range")]
		public int? M3MRF2 => GetNullableInt("MRF2");

		/// <summary>
		/// Description: Value in range
		/// FieldName: MRF3
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Value in range")]
		public int? M3MRF3 => GetNullableInt("MRF3");

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
		/// Description: Change date
		/// FieldName: LMDT
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Change date")]
		public DateTime? M3LMDT => GetNullableDateTime("LMDT");

		/// <summary>
		/// Description: Change number
		/// FieldName: CHNO
		/// FieldType: N
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Change number")]
		public int? M3CHNO => GetNullableInt("CHNO");

		/// <summary>
		/// Description: Changed by
		/// FieldName: CHID
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Changed by")]
		public string M3CHID => GetString("CHID");

		/// <summary>
		/// Description: Field
		/// FieldName: PC04
		/// FieldType: A
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Field")]
		public string M3PC04 => GetString("PC04");

		/// <summary>
		/// Description: Field
		/// FieldName: PC05
		/// FieldType: A
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Field")]
		public string M3PC05 => GetString("PC05");

		/// <summary>
		/// Description: Feature
		/// FieldName: FT04
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Feature")]
		public string M3FT04 => GetString("FT04");

		/// <summary>
		/// Description: Feature
		/// FieldName: FT05
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Feature")]
		public string M3FT05 => GetString("FT05");

		/// <summary>
		/// Description: Drawing measurement
		/// FieldName: DMI4
		/// FieldType: A
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Drawing measurement")]
		public string M3DMI4 => GetString("DMI4");

		/// <summary>
		/// Description: Drawing measurement
		/// FieldName: DMI5
		/// FieldType: A
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Drawing measurement")]
		public string M3DMI5 => GetString("DMI5");

		/// <summary>
		/// Description: Attribute identity
		/// FieldName: ATI4
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Attribute identity")]
		public string M3ATI4 => GetString("ATI4");

		/// <summary>
		/// Description: Attribute identity
		/// FieldName: ATI5
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Attribute identity")]
		public string M3ATI5 => GetString("ATI5");

		/// <summary>
		/// Description: Value in range
		/// FieldName: MRF4
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Value in range")]
		public int? M3MRF4 => GetNullableInt("MRF4");

		/// <summary>
		/// Description: Value in range
		/// FieldName: MRF5
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Value in range")]
		public int? M3MRF5 => GetNullableInt("MRF5");

		/// <summary>
		/// Description: Field
		/// FieldName: EX01
		/// FieldType: A
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Field")]
		public string M3EX01 => GetString("EX01");

		/// <summary>
		/// Description: Field
		/// FieldName: EX02
		/// FieldType: A
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Field")]
		public string M3EX02 => GetString("EX02");

		/// <summary>
		/// Description: Field
		/// FieldName: EX03
		/// FieldType: A
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Field")]
		public string M3EX03 => GetString("EX03");

		/// <summary>
		/// Description: Field
		/// FieldName: EX04
		/// FieldType: A
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Field")]
		public string M3EX04 => GetString("EX04");

		/// <summary>
		/// Description: Field
		/// FieldName: EX05
		/// FieldType: A
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Field")]
		public string M3EX05 => GetString("EX05");
	}
}
// EOF
