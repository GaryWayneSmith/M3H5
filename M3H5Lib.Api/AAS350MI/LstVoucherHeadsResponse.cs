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

namespace M3H5Lib.Api.AAS350MI
{
	public partial class LstVoucherHeadsResponse : M3BaseRecord 
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
		/// Description: Division
		/// FieldName: DIVI
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Division")]
		public string M3_DIVI => GetString("DIVI");

		/// <summary>
		/// Description: Run number
		/// FieldName: RNNO
		/// FieldType: N
		/// Length: 9
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Run number")]
		public int? M3_RNNO => GetNullableInt("RNNO");

		/// <summary>
		/// Description: Protocol number
		/// FieldName: GLRP
		/// FieldType: N
		/// Length: 9
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Protocol number")]
		public int? M3_GLRP => GetNullableInt("GLRP");

		/// <summary>
		/// Description: Year
		/// FieldName: YEA4
		/// FieldType: N
		/// Length: 4
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Year")]
		public int? M3_YEA4 => GetNullableInt("YEA4");

		/// <summary>
		/// Description: Voucher number series
		/// FieldName: VSER
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Voucher number series")]
		public string M3_VSER => GetString("VSER");

		/// <summary>
		/// Description: Voucher number
		/// FieldName: VONO
		/// FieldType: N
		/// Length: 8
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Voucher number")]
		public int? M3_VONO => GetNullableInt("VONO");

		/// <summary>
		/// Description: Recorded amount
		/// FieldName: ACAD
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Recorded amount")]
		public decimal? M3_ACAD => GetNullableDecimal("ACAD");

		/// <summary>
		/// Description: Recorded amount
		/// FieldName: ACAC
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Recorded amount")]
		public decimal? M3_ACAC => GetNullableDecimal("ACAC");

		/// <summary>
		/// Description: Foreign currency amount
		/// FieldName: CUAD
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Foreign currency amount")]
		public decimal? M3_CUAD => GetNullableDecimal("CUAD");

		/// <summary>
		/// Description: Foreign currency amount
		/// FieldName: CUAC
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Foreign currency amount")]
		public decimal? M3_CUAC => GetNullableDecimal("CUAC");

		/// <summary>
		/// Description: Third currency amount - debit
		/// FieldName: TCAD
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Third currency amount - debit")]
		public decimal? M3_TCAD => GetNullableDecimal("TCAD");

		/// <summary>
		/// Description: Third currency amount - credit
		/// FieldName: TCAC
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Third currency amount - credit")]
		public decimal? M3_TCAC => GetNullableDecimal("TCAC");

		/// <summary>
		/// Description: User
		/// FieldName: USID
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("User")]
		public string M3_USID => GetString("USID");

		/// <summary>
		/// Description: Timestamp
		/// FieldName: DTTM
		/// FieldType: N
		/// Length: 18
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Timestamp")]
		public decimal? M3_DTTM => GetNullableDecimal("DTTM");
	}
}
// EOF