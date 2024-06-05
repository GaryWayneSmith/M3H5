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

namespace M3H5Lib.Api.TXS140MI
{
	public partial class LstVATRegNoLineResponse : M3BaseRecord 
	{

		/// <summary>
		/// Description: VAT registration number
		/// FieldName: YVRN
		/// FieldType: A
		/// Length: 16
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("VAT registration number")]
		public string M3YVRN => GetString("YVRN");

		/// <summary>
		/// Description: Customer/supplier code
		/// FieldName: CVOP
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Customer/supplier code")]
		public int? M3CVOP => GetNullableInt("CVOP");

		/// <summary>
		/// Description: Customer/supplier
		/// FieldName: CUSP
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Customer/supplier")]
		public string M3CUSP => GetString("CUSP");

		/// <summary>
		/// Description: Recorded amount
		/// FieldName: ACA1
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Recorded amount")]
		public decimal? M3ACA1 => GetNullableDecimal("ACA1");

		/// <summary>
		/// Description: Recorded amount
		/// FieldName: ACA2
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Recorded amount")]
		public decimal? M3ACA2 => GetNullableDecimal("ACA2");

		/// <summary>
		/// Description: Recorded amount
		/// FieldName: ACA3
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Recorded amount")]
		public decimal? M3ACA3 => GetNullableDecimal("ACA3");

		/// <summary>
		/// Description: Number of invoices
		/// FieldName: ACQ1
		/// FieldType: N
		/// Length: 8
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Number of invoices")]
		public int? M3ACQ1 => GetNullableInt("ACQ1");

		/// <summary>
		/// Description: Recorded amount
		/// FieldName: ACA4
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Recorded amount")]
		public decimal? M3ACA4 => GetNullableDecimal("ACA4");

		/// <summary>
		/// Description: Number of credit invoices
		/// FieldName: ACQ2
		/// FieldType: N
		/// Length: 8
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Number of credit invoices")]
		public int? M3ACQ2 => GetNullableInt("ACQ2");

		/// <summary>
		/// Description: Recorded amount
		/// FieldName: ACA5
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Recorded amount")]
		public decimal? M3ACA5 => GetNullableDecimal("ACA5");

		/// <summary>
		/// Description: Recorded amount
		/// FieldName: ACA6
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Recorded amount")]
		public decimal? M3ACA6 => GetNullableDecimal("ACA6");

		/// <summary>
		/// Description: Recorded amount
		/// FieldName: ACA7
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Recorded amount")]
		public decimal? M3ACA7 => GetNullableDecimal("ACA7");

		/// <summary>
		/// Description: Number of invoices
		/// FieldName: ACQ3
		/// FieldType: N
		/// Length: 8
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Number of invoices")]
		public int? M3ACQ3 => GetNullableInt("ACQ3");

		/// <summary>
		/// Description: Recorded amount
		/// FieldName: ACA8
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Recorded amount")]
		public decimal? M3ACA8 => GetNullableDecimal("ACA8");

		/// <summary>
		/// Description: Number of credit invoices
		/// FieldName: ACQ4
		/// FieldType: N
		/// Length: 8
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Number of credit invoices")]
		public int? M3ACQ4 => GetNullableInt("ACQ4");
	}
}
// EOF
