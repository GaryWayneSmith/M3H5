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

namespace M3H5Lib.Api.GLS215MI
{
	public partial class GetPerBalanceResponse : M3BaseRecord 
	{

		/// <summary>
		/// Description: Accounted amount (debit)
		/// FieldName: ACAD
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Accounted amount (debit)")]
		public decimal? M3ACAD => GetNullableDecimal("ACAD");

		/// <summary>
		/// Description: Accounted amount (credit)
		/// FieldName: ACAC
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Accounted amount (credit)")]
		public decimal? M3ACAC => GetNullableDecimal("ACAC");

		/// <summary>
		/// Description: Currency amount (debit)
		/// FieldName: CUAD
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Currency amount (debit)")]
		public decimal? M3CUAD => GetNullableDecimal("CUAD");

		/// <summary>
		/// Description: Currency amount (credit)
		/// FieldName: CUAC
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Currency amount (credit)")]
		public decimal? M3CUAC => GetNullableDecimal("CUAC");

		/// <summary>
		/// Description: Accounted quantity (debit)
		/// FieldName: ACQD
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Accounted quantity (debit)")]
		public decimal? M3ACQD => GetNullableDecimal("ACQD");

		/// <summary>
		/// Description: Accounted quantity (credit)
		/// FieldName: ACQC
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Accounted quantity (credit)")]
		public decimal? M3ACQC => GetNullableDecimal("ACQC");

		/// <summary>
		/// Description: Third currency amount - debit
		/// FieldName: TCAD
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Third currency amount - debit")]
		public decimal? M3TCAD => GetNullableDecimal("TCAD");

		/// <summary>
		/// Description: Third currency amount - credit
		/// FieldName: TCAC
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Third currency amount - credit")]
		public decimal? M3TCAC => GetNullableDecimal("TCAC");

		/// <summary>
		/// Description: Internal accounted amount (debit)
		/// FieldName: IAAD
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Internal accounted amount (debit)")]
		public decimal? M3IAAD => GetNullableDecimal("IAAD");

		/// <summary>
		/// Description: Internal accounted amount (credit)
		/// FieldName: IAAC
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Internal accounted amount (credit)")]
		public decimal? M3IAAC => GetNullableDecimal("IAAC");

		/// <summary>
		/// Description: Internal currency amount (debit)
		/// FieldName: ICUD
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Internal currency amount (debit)")]
		public decimal? M3ICUD => GetNullableDecimal("ICUD");

		/// <summary>
		/// Description: Internal currency amount (credit)
		/// FieldName: ICUC
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Internal currency amount (credit)")]
		public decimal? M3ICUC => GetNullableDecimal("ICUC");

		/// <summary>
		/// Description: Internal 3rd currency amount (debit)
		/// FieldName: ITAD
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Internal 3rd currency amount (debit)")]
		public decimal? M3ITAD => GetNullableDecimal("ITAD");

		/// <summary>
		/// Description: Internal 3rd currency amount (credit)
		/// FieldName: ITAC
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Internal 3rd currency amount (credit)")]
		public decimal? M3ITAC => GetNullableDecimal("ITAC");

		/// <summary>
		/// Description: Third currency code
		/// FieldName: THCC
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Third currency code")]
		public string M3THCC => GetString("THCC");
	}
}
// EOF
