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

namespace M3H5Lib.Api.MOS306MI
{
	public partial class ListResponse : M3BaseRecord 
	{

		/// <summary>
		/// Description: Product
		/// FieldName: PRNO
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Product")]
		public string M3_PRNO => GetString("PRNO");

		/// <summary>
		/// Description: Product structure type
		/// FieldName: STRT
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Product structure type")]
		public string M3_STRT => GetString("STRT");

		/// <summary>
		/// Description: Service
		/// FieldName: SUFI
		/// FieldType: A
		/// Length: 20
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Service")]
		public string M3_SUFI => GetString("SUFI");

		/// <summary>
		/// Description: Service price list
		/// FieldName: SPRL
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Service price list")]
		public string M3_SPRL => GetString("SPRL");

		/// <summary>
		/// Description: Service price method
		/// FieldName: SRVP
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Service price method")]
		public int? M3_SRVP => GetNullableInt("SRVP");

		/// <summary>
		/// Description: Currency
		/// FieldName: CUCD
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Currency")]
		public string M3_CUCD => GetString("CUCD");

		/// <summary>
		/// Description: Facility
		/// FieldName: FACI
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Facility")]
		public string M3_FACI => GetString("FACI");

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
		/// Description: Service price
		/// FieldName: SERP
		/// FieldType: N
		/// Length: 19
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Service price")]
		public decimal? M3_SERP => GetNullableDecimal("SERP");

		/// <summary>
		/// Description: Price in labor currency
		/// FieldName: ADF1
		/// FieldType: N
		/// Length: 19
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Price in labor currency")]
		public decimal? M3_ADF1 => GetNullableDecimal("ADF1");

		/// <summary>
		/// Description: Price in material currency
		/// FieldName: ADF2
		/// FieldType: N
		/// Length: 19
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Price in material currency")]
		public decimal? M3_ADF2 => GetNullableDecimal("ADF2");

		/// <summary>
		/// Description: Price in subcontracting currency
		/// FieldName: ADF3
		/// FieldType: N
		/// Length: 19
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Price in subcontracting currency")]
		public decimal? M3_ADF3 => GetNullableDecimal("ADF3");

		/// <summary>
		/// Description: Price in miscellaneous currency
		/// FieldName: ADF4
		/// FieldType: N
		/// Length: 19
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Price in miscellaneous currency")]
		public decimal? M3_ADF4 => GetNullableDecimal("ADF4");

		/// <summary>
		/// Description: Fixed amount
		/// FieldName: ADY1
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Fixed amount")]
		public int? M3_ADY1 => GetNullableInt("ADY1");

		/// <summary>
		/// Description: Fixed amount
		/// FieldName: ADY2
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Fixed amount")]
		public int? M3_ADY2 => GetNullableInt("ADY2");

		/// <summary>
		/// Description: Fixed amount
		/// FieldName: ADY3
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Fixed amount")]
		public int? M3_ADY3 => GetNullableInt("ADY3");

		/// <summary>
		/// Description: Fixed amount
		/// FieldName: ADY4
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Fixed amount")]
		public int? M3_ADY4 => GetNullableInt("ADY4");
	}
}
// EOF
