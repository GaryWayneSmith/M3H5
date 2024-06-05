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

namespace M3H5Lib.Api.PPS194MI
{
	public partial class LstLinesResponse : M3BaseRecord 
	{

		/// <summary>
		/// Description: Supplier
		/// FieldName: SUNO
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Supplier")]
		public string M3SUNO => GetString("SUNO");

		/// <summary>
		/// Description: Procurement group
		/// FieldName: PRGP
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Procurement group")]
		public string M3PRGP => GetString("PRGP");

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
		/// Description: Purchase order number
		/// FieldName: PUNO
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Purchase order number")]
		public string M3PUNO => GetString("PUNO");

		/// <summary>
		/// Description: Buyer
		/// FieldName: BUYE
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Buyer")]
		public string M3BUYE => GetString("BUYE");

		/// <summary>
		/// Description: Release date
		/// FieldName: RELD
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Release date")]
		public DateTime? M3RELD => GetNullableDateTime("RELD");

		/// <summary>
		/// Description: Planned delivery date
		/// FieldName: DLDT
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Planned delivery date")]
		public DateTime? M3DLDT => GetNullableDateTime("DLDT");

		/// <summary>
		/// Description: Total cost
		/// FieldName: TOCO
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Total cost")]
		public decimal? M3TOCO => GetNullableDecimal("TOCO");

		/// <summary>
		/// Description: Total volume
		/// FieldName: TVOL
		/// FieldType: N
		/// Length: 14
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Total volume")]
		public decimal? M3TVOL => GetNullableDecimal("TVOL");

		/// <summary>
		/// Description: Total gross weight
		/// FieldName: TGRW
		/// FieldType: N
		/// Length: 14
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Total gross weight")]
		public decimal? M3TGRW => GetNullableDecimal("TGRW");

		/// <summary>
		/// Description: Gross weight
		/// FieldName: GRWE
		/// FieldType: N
		/// Length: 11
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Gross weight")]
		public decimal? M3GRWE => GetNullableDecimal("GRWE");

		/// <summary>
		/// Description: Net weight
		/// FieldName: NEWE
		/// FieldType: N
		/// Length: 11
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Net weight")]
		public decimal? M3NEWE => GetNullableDecimal("NEWE");

		/// <summary>
		/// Description: Late proposals
		/// FieldName: LAPL
		/// FieldType: N
		/// Length: 7
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Late proposals")]
		public int? M3LAPL => GetNullableInt("LAPL");

		/// <summary>
		/// Description: Referenced proposals
		/// FieldName: RFPL
		/// FieldType: N
		/// Length: 7
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Referenced proposals")]
		public int? M3RFPL => GetNullableInt("RFPL");

		/// <summary>
		/// Description: Normal proposals
		/// FieldName: NOPL
		/// FieldType: N
		/// Length: 7
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Normal proposals")]
		public int? M3NOPL => GetNullableInt("NOPL");

		/// <summary>
		/// Description: Number of planned orders
		/// FieldName: NUPL
		/// FieldType: N
		/// Length: 7
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Number of planned orders")]
		public int? M3NUPL => GetNullableInt("NUPL");

		/// <summary>
		/// Description: Target type
		/// FieldName: TRGT
		/// FieldType: N
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Target type")]
		public int? M3TRGT => GetNullableInt("TRGT");

		/// <summary>
		/// Description: Target weight
		/// FieldName: TRGW
		/// FieldType: N
		/// Length: 14
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Target weight")]
		public decimal? M3TRGW => GetNullableDecimal("TRGW");

		/// <summary>
		/// Description: Target volume
		/// FieldName: TRGV
		/// FieldType: N
		/// Length: 14
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Target volume")]
		public decimal? M3TRGV => GetNullableDecimal("TRGV");

		/// <summary>
		/// Description: Target cost
		/// FieldName: TRGC
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Target cost")]
		public decimal? M3TRGC => GetNullableDecimal("TRGC");

		/// <summary>
		/// Description: Release interval
		/// FieldName: RLIV
		/// FieldType: N
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Release interval")]
		public int? M3RLIV => GetNullableInt("RLIV");

		/// <summary>
		/// Description: Line buy
		/// FieldName: LIBU
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Line buy")]
		public int? M3LIBU => GetNullableInt("LIBU");

		/// <summary>
		/// Description: Fill-up
		/// FieldName: FILU
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Fill-up")]
		public int? M3FILU => GetNullableInt("FILU");

		/// <summary>
		/// Description: Planned release date
		/// FieldName: PRLD
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Planned release date")]
		public DateTime? M3PRLD => GetNullableDateTime("PRLD");
	}
}
// EOF
