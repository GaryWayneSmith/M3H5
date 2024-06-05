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

namespace M3H5Lib.Api.CRS138MI
{
	public partial class LstTaxRatesResponse : M3BaseRecord 
	{

		/// <summary>
		/// Description: Geographical code
		/// FieldName: GEOC
		/// FieldType: N
		/// Length: 9
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Geographical code")]
		public int? M3_GEOC => GetNullableInt("GEOC");

		/// <summary>
		/// Description: Tax type
		/// FieldName: TAXT
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Tax type")]
		public int? M3_TAXT => GetNullableInt("TAXT");

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
		/// Description: Limit amount 1
		/// FieldName: TAA1
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Limit amount 1")]
		public decimal? M3_TAA1 => GetNullableDecimal("TAA1");

		/// <summary>
		/// Description: Tax rate 1
		/// FieldName: TAR1
		/// FieldType: N
		/// Length: 8
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Tax rate 1")]
		public int? M3_TAR1 => GetNullableInt("TAR1");

		/// <summary>
		/// Description: Limit type
		/// FieldName: TAD1
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Limit type")]
		public int? M3_TAD1 => GetNullableInt("TAD1");

		/// <summary>
		/// Description: Tax type
		/// FieldName: TXT1
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Tax type")]
		public int? M3_TXT1 => GetNullableInt("TXT1");

		/// <summary>
		/// Description: Limit amount 2
		/// FieldName: TAA2
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Limit amount 2")]
		public decimal? M3_TAA2 => GetNullableDecimal("TAA2");

		/// <summary>
		/// Description: Tax rate 2
		/// FieldName: TAR2
		/// FieldType: N
		/// Length: 8
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Tax rate 2")]
		public int? M3_TAR2 => GetNullableInt("TAR2");

		/// <summary>
		/// Description: Limit type
		/// FieldName: TAD2
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Limit type")]
		public int? M3_TAD2 => GetNullableInt("TAD2");

		/// <summary>
		/// Description: Tax type
		/// FieldName: TXT2
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Tax type")]
		public int? M3_TXT2 => GetNullableInt("TXT2");

		/// <summary>
		/// Description: Limit amount 3
		/// FieldName: TAA3
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Limit amount 3")]
		public decimal? M3_TAA3 => GetNullableDecimal("TAA3");

		/// <summary>
		/// Description: Tax rate 3
		/// FieldName: TAR3
		/// FieldType: N
		/// Length: 8
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Tax rate 3")]
		public int? M3_TAR3 => GetNullableInt("TAR3");

		/// <summary>
		/// Description: Limit type
		/// FieldName: TAD3
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Limit type")]
		public int? M3_TAD3 => GetNullableInt("TAD3");

		/// <summary>
		/// Description: Tax type
		/// FieldName: TXT3
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Tax type")]
		public int? M3_TXT3 => GetNullableInt("TXT3");

		/// <summary>
		/// Description: Limit amount 4
		/// FieldName: TAA4
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Limit amount 4")]
		public decimal? M3_TAA4 => GetNullableDecimal("TAA4");

		/// <summary>
		/// Description: Tax rate 4
		/// FieldName: TAR4
		/// FieldType: N
		/// Length: 8
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Tax rate 4")]
		public int? M3_TAR4 => GetNullableInt("TAR4");

		/// <summary>
		/// Description: Limit type
		/// FieldName: TAD4
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Limit type")]
		public int? M3_TAD4 => GetNullableInt("TAD4");

		/// <summary>
		/// Description: Tax type
		/// FieldName: TXT4
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Tax type")]
		public int? M3_TXT4 => GetNullableInt("TXT4");

		/// <summary>
		/// Description: Limit amount 5
		/// FieldName: TAA5
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Limit amount 5")]
		public decimal? M3_TAA5 => GetNullableDecimal("TAA5");

		/// <summary>
		/// Description: Tax rate 5
		/// FieldName: TAR5
		/// FieldType: N
		/// Length: 8
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Tax rate 5")]
		public int? M3_TAR5 => GetNullableInt("TAR5");

		/// <summary>
		/// Description: Limit type
		/// FieldName: TAD5
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Limit type")]
		public int? M3_TAD5 => GetNullableInt("TAD5");

		/// <summary>
		/// Description: Tax type
		/// FieldName: TXT5
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Tax type")]
		public int? M3_TXT5 => GetNullableInt("TXT5");

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
