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

namespace M3H5Lib.Api.RPS040MI
{
	public partial class LstResponse : M3BaseRecord 
	{

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
		/// Description: From date
		/// FieldName: FRDT
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("From date")]
		public DateTime? M3_FRDT => GetNullableDateTime("FRDT");

		/// <summary>
		/// Description: To date
		/// FieldName: TODT
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("To date")]
		public DateTime? M3_TODT => GetNullableDateTime("TODT");

		/// <summary>
		/// Description: Number of days demand
		/// FieldName: RQDA
		/// FieldType: N
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Number of days demand")]
		public int? M3_RQDA => GetNullableInt("RQDA");

		/// <summary>
		/// Description: Demand base
		/// FieldName: RQBA
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Demand base")]
		public int? M3_RQBA => GetNullableInt("RQBA");

		/// <summary>
		/// Description: Calculated extra safety stock
		/// FieldName: CESS
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Calculated extra safety stock")]
		public decimal? M3_CESS => GetNullableDecimal("CESS");

		/// <summary>
		/// Description: Extra safety stock method
		/// FieldName: ESSM
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Extra safety stock method")]
		public int? M3_ESSM => GetNullableInt("ESSM");

		/// <summary>
		/// Description: Max extra safety stock
		/// FieldName: MXSS
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Max extra safety stock")]
		public decimal? M3_MXSS => GetNullableDecimal("MXSS");

		/// <summary>
		/// Description: Frozen safety stock
		/// FieldName: FSSQ
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Frozen safety stock")]
		public int? M3_FSSQ => GetNullableInt("FSSQ");

		/// <summary>
		/// Description: Calculation date
		/// FieldName: CALD
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Calculation date")]
		public DateTime? M3_CALD => GetNullableDateTime("CALD");

		/// <summary>
		/// Description: Safety stock reason code
		/// FieldName: SSRE
		/// FieldType: A
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Safety stock reason code")]
		public string M3_SSRE => GetString("SSRE");

		/// <summary>
		/// Description: Calculation time
		/// FieldName: CATM
		/// FieldType: N
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Calculation time")]
		public int? M3_CATM => GetNullableInt("CATM");

		/// <summary>
		/// Description: Frozen safety stock implementation date
		/// FieldName: FSID
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Frozen safety stock implementation date")]
		public DateTime? M3_FSID => GetNullableDateTime("FSID");

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
	}
}
// EOF
