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
	public partial class LstPerBalancesResponse : M3BaseRecord 
	{

		/// <summary>
		/// Description: Pointer ID
		/// FieldName: PTID
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Pointer ID")]
		public decimal? M3PTID => GetNullableDecimal("PTID");

		/// <summary>
		/// Description: Value type
		/// FieldName: VTYP
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Value type")]
		public int? M3VTYP => GetNullableInt("VTYP");

		/// <summary>
		/// Description: Budget number
		/// FieldName: BUNO
		/// FieldType: N
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Budget number")]
		public int? M3BUNO => GetNullableInt("BUNO");

		/// <summary>
		/// Description: Budget version
		/// FieldName: BVER
		/// FieldType: A
		/// Length: 4
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Budget version")]
		public string M3BVER => GetString("BVER");

		/// <summary>
		/// Description: Year
		/// FieldName: YEA4
		/// FieldType: N
		/// Length: 4
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Year")]
		public int? M3YEA4 => GetNullableInt("YEA4");

		/// <summary>
		/// Description: Period
		/// FieldName: PERI
		/// FieldType: N
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Period")]
		public int? M3PERI => GetNullableInt("PERI");

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
