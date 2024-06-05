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

namespace M3H5Lib.Api.PPS100MI
{
	public partial class LstStgPriceResponse : M3BaseRecord 
	{

		/// <summary>
		/// Description: Supplier number
		/// FieldName: SUNO
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Supplier number")]
		public string M3SUNO => GetString("SUNO");

		/// <summary>
		/// Description: Agreement number
		/// FieldName: AGNB
		/// FieldType: A
		/// Length: 7
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Agreement number")]
		public string M3AGNB => GetString("AGNB");

		/// <summary>
		/// Description: Group identity
		/// FieldName: GRPI
		/// FieldType: N
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Group identity")]
		public int? M3GRPI => GetNullableInt("GRPI");

		/// <summary>
		/// Description: Start value 1
		/// FieldName: OBV1
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Start value 1")]
		public string M3OBV1 => GetString("OBV1");

		/// <summary>
		/// Description: Start value 2
		/// FieldName: OBV2
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Start value 2")]
		public string M3OBV2 => GetString("OBV2");

		/// <summary>
		/// Description: Start value 3
		/// FieldName: OBV3
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Start value 3")]
		public string M3OBV3 => GetString("OBV3");

		/// <summary>
		/// Description: Start value 4
		/// FieldName: OBV4
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Start value 4")]
		public string M3OBV4 => GetString("OBV4");

		/// <summary>
		/// Description: Valid from
		/// FieldName: FVDT
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Valid from")]
		public DateTime? M3FVDT => GetNullableDateTime("FVDT");

		/// <summary>
		/// Description: From quantity
		/// FieldName: FRQT
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("From quantity")]
		public decimal? M3FRQT => GetNullableDecimal("FRQT");

		/// <summary>
		/// Description: Purchase price
		/// FieldName: PUPR
		/// FieldType: N
		/// Length: 18
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Purchase price")]
		public decimal? M3PUPR => GetNullableDecimal("PUPR");

		/// <summary>
		/// Description: Discount 3
		/// FieldName: DIP3
		/// FieldType: N
		/// Length: 7
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Discount 3")]
		public int? M3DIP3 => GetNullableInt("DIP3");

		/// <summary>
		/// Description: Normal price
		/// FieldName: MAPR
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Normal price")]
		public int? M3MAPR => GetNullableInt("MAPR");
	}
}
// EOF
