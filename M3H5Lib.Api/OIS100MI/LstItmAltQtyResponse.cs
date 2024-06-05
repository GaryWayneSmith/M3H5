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

namespace M3H5Lib.Api.OIS100MI
{
	public partial class LstItmAltQtyResponse : M3BaseRecord 
	{

		/// <summary>
		/// Description: Transaction quantity - basic U/M
		/// FieldName: TRQT
		/// FieldType: N
		/// Length: 16
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Transaction quantity - basic U/M")]
		public decimal? M3_TRQT => GetNullableDecimal("TRQT");

		/// <summary>
		/// Description: Alternate U/M
		/// FieldName: ALUN
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Alternate U/M")]
		public string M3_ALUN => GetString("ALUN");

		/// <summary>
		/// Description: Allocation deviation type
		/// FieldName: ALDE
		/// FieldType: N
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Allocation deviation type")]
		public decimal? M3_ALDE => GetNullableDecimal("ALDE");

		/// <summary>
		/// Description: Message
		/// FieldName: MSGD
		/// FieldType: A
		/// Length: 256
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Message")]
		public string M3_MSGD => GetString("MSGD");

		/// <summary>
		/// Description: Number of decimal places
		/// FieldName: DCCD
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Number of decimal places")]
		public int? M3_DCCD => GetNullableInt("DCCD");

		/// <summary>
		/// Description: Conversion factor
		/// FieldName: COFA
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Conversion factor")]
		public decimal? M3_COFA => GetNullableDecimal("COFA");

		/// <summary>
		/// Description: Conversion form
		/// FieldName: DMCF
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Conversion form")]
		public int? M3_DMCF => GetNullableInt("DMCF");

		/// <summary>
		/// Description: Price adjustment factor
		/// FieldName: PCOF
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Price adjustment factor")]
		public decimal? M3_PCOF => GetNullableDecimal("PCOF");

		/// <summary>
		/// Description: Standard U/M - purchase order
		/// FieldName: AUS1
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Standard U/M - purchase order")]
		public int? M3_AUS1 => GetNullableInt("AUS1");

		/// <summary>
		/// Description: Standard U/M - customer order sales
		/// FieldName: AUS2
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Standard U/M - customer order sales")]
		public int? M3_AUS2 => GetNullableInt("AUS2");

		/// <summary>
		/// Description: Standard U/M - manufacturing
		/// FieldName: AUS3
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Standard U/M - manufacturing")]
		public int? M3_AUS3 => GetNullableInt("AUS3");

		/// <summary>
		/// Description: Standard U/M - production engineering
		/// FieldName: AUS4
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Standard U/M - production engineering")]
		public int? M3_AUS4 => GetNullableInt("AUS4");

		/// <summary>
		/// Description: Standard U/M - purchase price
		/// FieldName: AUS5
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Standard U/M - purchase price")]
		public int? M3_AUS5 => GetNullableInt("AUS5");

		/// <summary>
		/// Description: Standard U/M - statistics
		/// FieldName: AUS6
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Standard U/M - statistics")]
		public int? M3_AUS6 => GetNullableInt("AUS6");

		/// <summary>
		/// Description: Standard U/M - sales price
		/// FieldName: AUS9
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Standard U/M - sales price")]
		public int? M3_AUS9 => GetNullableInt("AUS9");

		/// <summary>
		/// Description: Order multiple
		/// FieldName: UNMU
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Order multiple")]
		public decimal? M3_UNMU => GetNullableDecimal("UNMU");
	}
}
// EOF
