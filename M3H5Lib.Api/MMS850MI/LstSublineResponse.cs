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

namespace M3H5Lib.Api.MMS850MI
{
	public partial class LstSublineResponse : M3BaseRecord 
	{

		/// <summary>
		/// Description: Message Number
		/// FieldName: MSNR
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Message Number")]
		public string M3MSNR => GetString("MSNR");

		/// <summary>
		/// Description: Message line number
		/// FieldName: MSLN
		/// FieldType: N
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Message line number")]
		public int? M3MSLN => GetNullableInt("MSLN");

		/// <summary>
		/// Description: Sequence number
		/// FieldName: MSGS
		/// FieldType: N
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Sequence number")]
		public int? M3MSGS => GetNullableInt("MSGS");

		/// <summary>
		/// Description: Subline number
		/// FieldName: SUBL
		/// FieldType: N
		/// Length: 8
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Subline number")]
		public int? M3SUBL => GetNullableInt("SUBL");

		/// <summary>
		/// Description: Reference sublot ID
		/// FieldName: BANT
		/// FieldType: A
		/// Length: 36
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Reference sublot ID")]
		public string M3BANT => GetString("BANT");

		/// <summary>
		/// Description: Item number
		/// FieldName: ITNO
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Item number")]
		public string M3ITNO => GetString("ITNO");

		/// <summary>
		/// Description: Lot number
		/// FieldName: BANO
		/// FieldType: A
		/// Length: 20
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Lot number")]
		public string M3BANO => GetString("BANO");

		/// <summary>
		/// Description: Catch weight
		/// FieldName: CAWE
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Catch weight")]
		public decimal? M3CAWE => GetNullableDecimal("CAWE");

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
