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

namespace M3H5Lib.Api.PPS280MI
{
	public partial class GetElementResponse : M3BaseRecord 
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
		/// Description: Purchase costing element
		/// FieldName: CEID
		/// FieldType: A
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Purchase costing element")]
		public string M3_CEID => GetString("CEID");

		/// <summary>
		/// Description: Text
		/// FieldName: TX30
		/// FieldType: A
		/// Length: 30
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Text")]
		public string M3_TX30 => GetString("TX30");

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
		/// Description: End value 1
		/// FieldName: OBT1
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("End value 1")]
		public string M3_OBT1 => GetString("OBT1");

		/// <summary>
		/// Description: End value 2
		/// FieldName: OBT2
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("End value 2")]
		public string M3_OBT2 => GetString("OBT2");

		/// <summary>
		/// Description: End value 3
		/// FieldName: OBT3
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("End value 3")]
		public string M3_OBT3 => GetString("OBT3");

		/// <summary>
		/// Description: Costing operator
		/// FieldName: WSOP
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Costing operator")]
		public string M3_WSOP => GetString("WSOP");

		/// <summary>
		/// Description: Markup
		/// FieldName: POOV
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Markup")]
		public int? M3_POOV => GetNullableInt("POOV");

		/// <summary>
		/// Description: Charge type
		/// FieldName: EXTY
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Charge type")]
		public int? M3_EXTY => GetNullableInt("EXTY");

		/// <summary>
		/// Description: Distribution method
		/// FieldName: DIMT
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Distribution method")]
		public int? M3_DIMT => GetNullableInt("DIMT");

		/// <summary>
		/// Description: Distribution unit type
		/// FieldName: DIUN
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Distribution unit type")]
		public int? M3_DIUN => GetNullableInt("DIUN");

		/// <summary>
		/// Description: Charge invoicing
		/// FieldName: EXIC
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Charge invoicing")]
		public int? M3_EXIC => GetNullableInt("EXIC");

		/// <summary>
		/// Description: User-defined accounting control object
		/// FieldName: ACRF
		/// FieldType: A
		/// Length: 8
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("User-defined accounting control object")]
		public string M3_ACRF => GetString("ACRF");

		/// <summary>
		/// Description: VAT code
		/// FieldName: VTCD
		/// FieldType: N
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("VAT code")]
		public int? M3_VTCD => GetNullableInt("VTCD");

		/// <summary>
		/// Description: Attribute identity
		/// FieldName: ATI1
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Attribute identity")]
		public string M3_ATI1 => GetString("ATI1");

		/// <summary>
		/// Description: Attribute identity
		/// FieldName: ATI2
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Attribute identity")]
		public string M3_ATI2 => GetString("ATI2");

		/// <summary>
		/// Description: Attribute identity
		/// FieldName: ATI3
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Attribute identity")]
		public string M3_ATI3 => GetString("ATI3");

		/// <summary>
		/// Description: Value in range
		/// FieldName: MRF1
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Value in range")]
		public int? M3_MRF1 => GetNullableInt("MRF1");

		/// <summary>
		/// Description: Value in range
		/// FieldName: MRF2
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Value in range")]
		public int? M3_MRF2 => GetNullableInt("MRF2");

		/// <summary>
		/// Description: Value in range
		/// FieldName: MRF3
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Value in range")]
		public int? M3_MRF3 => GetNullableInt("MRF3");

		/// <summary>
		/// Description: Invoice charge quantity
		/// FieldName: IVCQ
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Invoice charge quantity")]
		public int? M3_IVCQ => GetNullableInt("IVCQ");

		/// <summary>
		/// Description: Third part charge
		/// FieldName: THPR
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Third part charge")]
		public int? M3_THPR => GetNullableInt("THPR");

		/// <summary>
		/// Description: Hide element value
		/// FieldName: HELV
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Hide element value")]
		public int? M3_HELV => GetNullableInt("HELV");

		/// <summary>
		/// Description: Text identity
		/// FieldName: TXID
		/// FieldType: N
		/// Length: 13
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Text identity")]
		public decimal? M3_TXID => GetNullableDecimal("TXID");

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
		/// Description: End value 4
		/// FieldName: OBT4
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("End value 4")]
		public string M3_OBT4 => GetString("OBT4");

		/// <summary>
		/// Description: End value 5
		/// FieldName: OBT5
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("End value 5")]
		public string M3_OBT5 => GetString("OBT5");

		/// <summary>
		/// Description: Attribute identity
		/// FieldName: ATI4
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Attribute identity")]
		public string M3_ATI4 => GetString("ATI4");

		/// <summary>
		/// Description: Attribute identity
		/// FieldName: ATI5
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Attribute identity")]
		public string M3_ATI5 => GetString("ATI5");

		/// <summary>
		/// Description: Charge categori
		/// FieldName: CTY2
		/// FieldType: N
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Charge categori")]
		public int? M3_CTY2 => GetNullableInt("CTY2");
	}
}
// EOF
