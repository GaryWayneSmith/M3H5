/// **********************************************************************
/// This class is auto-generated.
/// Updated: 6/5/2024 3:52:20 PM
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

namespace M3H5Lib.Api.RPS040MI
{
	public partial class GetResponse : M3BaseRecord 
	{

		/// <summary>
		/// Description: To date
		/// FieldName: TODT
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("To date")]
		public DateTime? M3TODT => GetNullableDateTime("TODT");

		/// <summary>
		/// Description: Number of days demand
		/// FieldName: RQDA
		/// FieldType: N
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Number of days demand")]
		public int? M3RQDA => GetNullableInt("RQDA");

		/// <summary>
		/// Description: Demand base
		/// FieldName: RQBA
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Demand base")]
		public int? M3RQBA => GetNullableInt("RQBA");

		/// <summary>
		/// Description: Calculated extra safety stock
		/// FieldName: CESS
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Calculated extra safety stock")]
		public decimal? M3CESS => GetNullableDecimal("CESS");

		/// <summary>
		/// Description: Extra safety stock method
		/// FieldName: ESSM
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Extra safety stock method")]
		public int? M3ESSM => GetNullableInt("ESSM");

		/// <summary>
		/// Description: Max extra safety stock
		/// FieldName: MXSS
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Max extra safety stock")]
		public decimal? M3MXSS => GetNullableDecimal("MXSS");

		/// <summary>
		/// Description: Frozen safety stock
		/// FieldName: FSSQ
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Frozen safety stock")]
		public int? M3FSSQ => GetNullableInt("FSSQ");

		/// <summary>
		/// Description: Calculation date
		/// FieldName: CALD
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Calculation date")]
		public DateTime? M3CALD => GetNullableDateTime("CALD");

		/// <summary>
		/// Description: Safety stock reason code
		/// FieldName: SSRE
		/// FieldType: A
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Safety stock reason code")]
		public string M3SSRE => GetString("SSRE");

		/// <summary>
		/// Description: Calculation time
		/// FieldName: CATM
		/// FieldType: N
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Calculation time")]
		public int? M3CATM => GetNullableInt("CATM");

		/// <summary>
		/// Description: Frozen safety stock implementation date
		/// FieldName: FSID
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Frozen safety stock implementation date")]
		public DateTime? M3FSID => GetNullableDateTime("FSID");

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
	}
}
// EOF
