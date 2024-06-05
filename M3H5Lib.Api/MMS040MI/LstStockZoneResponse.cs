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

namespace M3H5Lib.Api.MMS040MI
{
	public partial class LstStockZoneResponse : M3BaseRecord 
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
		/// Description: Stock zone
		/// FieldName: SLTP
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Stock zone")]
		public string M3SLTP => GetString("SLTP");

		/// <summary>
		/// Description: Name of stock location type
		/// FieldName: ARNM
		/// FieldType: A
		/// Length: 30
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Name of stock location type")]
		public string M3ARNM => GetString("ARNM");

		/// <summary>
		/// Description: Volume calculation
		/// FieldName: COVO
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Volume calculation")]
		public int? M3COVO => GetNullableInt("COVO");

		/// <summary>
		/// Description: Weight check
		/// FieldName: WECD
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Weight check")]
		public int? M3WECD => GetNullableInt("WECD");

		/// <summary>
		/// Description: Weight check from position
		/// FieldName: FWLP
		/// FieldType: N
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Weight check from position")]
		public int? M3FWLP => GetNullableInt("FWLP");

		/// <summary>
		/// Description: Weight check to position
		/// FieldName: TWLP
		/// FieldType: N
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Weight check to position")]
		public int? M3TWLP => GetNullableInt("TWLP");

		/// <summary>
		/// Description: Horizontal axis from position
		/// FieldName: FHOR
		/// FieldType: N
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Horizontal axis from position")]
		public int? M3FHOR => GetNullableInt("FHOR");

		/// <summary>
		/// Description: Horizontal axis to position
		/// FieldName: THOR
		/// FieldType: N
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Horizontal axis to position")]
		public int? M3THOR => GetNullableInt("THOR");

		/// <summary>
		/// Description: Vertical axis from position
		/// FieldName: FVER
		/// FieldType: N
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Vertical axis from position")]
		public int? M3FVER => GetNullableInt("FVER");

		/// <summary>
		/// Description: Vertical axis to position
		/// FieldName: TVER
		/// FieldType: N
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Vertical axis to position")]
		public int? M3TVER => GetNullableInt("TVER");

		/// <summary>
		/// Description: Picking list break
		/// FieldName: PLBR
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Picking list break")]
		public int? M3PLBR => GetNullableInt("PLBR");

		/// <summary>
		/// Description: Picking team
		/// FieldName: TEAM
		/// FieldType: A
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Picking team")]
		public string M3TEAM => GetString("TEAM");

		/// <summary>
		/// Description: Container used for storage
		/// FieldName: LCUC
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Container used for storage")]
		public int? M3LCUC => GetNullableInt("LCUC");

		/// <summary>
		/// Description: Prevent put-away label
		/// FieldName: SPRD
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Prevent put-away label")]
		public int? M3SPRD => GetNullableInt("SPRD");

		/// <summary>
		/// Description: Sorting
		/// FieldName: TRFU
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Sorting")]
		public int? M3TRFU => GetNullableInt("TRFU");

		/// <summary>
		/// Description: Printer
		/// FieldName: DEV
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Printer")]
		public string M3DEV => GetString("DEV");

		/// <summary>
		/// Description: Filling rate calculation
		/// FieldName: FRCA
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Filling rate calculation")]
		public int? M3FRCA => GetNullableInt("FRCA");

		/// <summary>
		/// Description: Responsible
		/// FieldName: RESP
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Responsible")]
		public string M3RESP => GetString("RESP");

		/// <summary>
		/// Description: Packing area
		/// FieldName: PASL
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Packing area")]
		public string M3PASL => GetString("PASL");

		/// <summary>
		/// Description: Two-step put-away
		/// FieldName: TSPA
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Two-step put-away")]
		public int? M3TSPA => GetNullableInt("TSPA");

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
		/// Description: Timestamp
		/// FieldName: LMTS
		/// FieldType: N
		/// Length: 18
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Timestamp")]
		public decimal? M3LMTS => GetNullableDecimal("LMTS");
	}
}
// EOF
