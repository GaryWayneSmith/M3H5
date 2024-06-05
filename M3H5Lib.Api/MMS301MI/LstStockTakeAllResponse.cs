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

namespace M3H5Lib.Api.MMS301MI
{
	public partial class LstStockTakeAllResponse : M3BaseRecord 
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
		/// Description: Physical inventory number
		/// FieldName: STNB
		/// FieldType: N
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Physical inventory number")]
		public long? M3_STNB => GetNullableLong("STNB");

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
		/// Description: Physical inventory method
		/// FieldName: STMD
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Physical inventory method")]
		public int? M3_STMD => GetNullableInt("STMD");

		/// <summary>
		/// Description: Planned physical inventory date
		/// FieldName: STPD
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Planned physical inventory date")]
		public DateTime? M3_STPD => GetNullableDateTime("STPD");

		/// <summary>
		/// Description: Desired number of phys inventory lines
		/// FieldName: STWR
		/// FieldType: N
		/// Length: 7
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Desired number of phys inventory lines")]
		public int? M3_STWR => GetNullableInt("STWR");

		/// <summary>
		/// Description: Active physical inventory lines
		/// FieldName: STAR
		/// FieldType: N
		/// Length: 7
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Active physical inventory lines")]
		public int? M3_STAR => GetNullableInt("STAR");

		/// <summary>
		/// Description: Print next planned transaction
		/// FieldName: NPTP
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Print next planned transaction")]
		public int? M3_NPTP => GetNullableInt("NPTP");

		/// <summary>
		/// Description: Printout date
		/// FieldName: STOD
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Printout date")]
		public DateTime? M3_STOD => GetNullableDateTime("STOD");

		/// <summary>
		/// Description: Status
		/// FieldName: STAT
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Status")]
		public string M3_STAT => GetString("STAT");

		/// <summary>
		/// Description: Number of pages on stock-taking request
		/// FieldName: STPA
		/// FieldType: N
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Number of pages on stock-taking request")]
		public int? M3_STPA => GetNullableInt("STPA");

		/// <summary>
		/// Description: Print on-hand balance
		/// FieldName: SBOL
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Print on-hand balance")]
		public int? M3_SBOL => GetNullableInt("SBOL");

		/// <summary>
		/// Description: Multiple warehouses permitted
		/// FieldName: MWHE
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Multiple warehouses permitted")]
		public int? M3_MWHE => GetNullableInt("MWHE");

		/// <summary>
		/// Description: Consider cycle time
		/// FieldName: CCYC
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Consider cycle time")]
		public int? M3_CCYC => GetNullableInt("CCYC");

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
		/// Description: Planned physical inventory time
		/// FieldName: SPTM
		/// FieldType: N
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Planned physical inventory time")]
		public int? M3_SPTM => GetNullableInt("SPTM");
	}
}
// EOF
