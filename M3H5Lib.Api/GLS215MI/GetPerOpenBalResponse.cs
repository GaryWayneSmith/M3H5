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

namespace M3H5Lib.Api.GLS215MI
{
	public partial class GetPerOpenBalResponse : M3BaseRecord 
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
		public decimal? M3_ACAD => GetNullableDecimal("ACAD");

		/// <summary>
		/// Description: Accounted amount (credit)
		/// FieldName: ACAC
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Accounted amount (credit)")]
		public decimal? M3_ACAC => GetNullableDecimal("ACAC");

		/// <summary>
		/// Description: Currency amount (debit)
		/// FieldName: CUAD
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Currency amount (debit)")]
		public decimal? M3_CUAD => GetNullableDecimal("CUAD");

		/// <summary>
		/// Description: Currency amount (credit)
		/// FieldName: CUAC
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Currency amount (credit)")]
		public decimal? M3_CUAC => GetNullableDecimal("CUAC");

		/// <summary>
		/// Description: Accounted quantity (debit)
		/// FieldName: ACQD
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Accounted quantity (debit)")]
		public decimal? M3_ACQD => GetNullableDecimal("ACQD");

		/// <summary>
		/// Description: Accounted quantity (credit)
		/// FieldName: ACQC
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Accounted quantity (credit)")]
		public decimal? M3_ACQC => GetNullableDecimal("ACQC");

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
		/// Description: Internal accounted amount (debit)
		/// FieldName: IAAD
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Internal accounted amount (debit)")]
		public decimal? M3_IAAD => GetNullableDecimal("IAAD");

		/// <summary>
		/// Description: Internal accounted amount (credit)
		/// FieldName: IAAC
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Internal accounted amount (credit)")]
		public decimal? M3_IAAC => GetNullableDecimal("IAAC");

		/// <summary>
		/// Description: Internal currency amount (debit)
		/// FieldName: ICUD
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Internal currency amount (debit)")]
		public decimal? M3_ICUD => GetNullableDecimal("ICUD");

		/// <summary>
		/// Description: Internal currency amount (credit)
		/// FieldName: ICUC
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Internal currency amount (credit)")]
		public decimal? M3_ICUC => GetNullableDecimal("ICUC");

		/// <summary>
		/// Description: Internal 3rd currency amount (debit)
		/// FieldName: ITAD
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Internal 3rd currency amount (debit)")]
		public decimal? M3_ITAD => GetNullableDecimal("ITAD");

		/// <summary>
		/// Description: Internal 3rd currency amount (credit)
		/// FieldName: ITAC
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Internal 3rd currency amount (credit)")]
		public decimal? M3_ITAC => GetNullableDecimal("ITAC");

		/// <summary>
		/// Description: Third currency code
		/// FieldName: THCC
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Third currency code")]
		public string M3_THCC => GetString("THCC");
	}
}
// EOF
