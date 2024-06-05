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

namespace M3H5Lib.Api.TXS130MI
{
	public partial class LstAmountEUSaleResponse : M3BaseRecord 
	{

		/// <summary>
		/// Description: From/to country
		/// FieldName: FTCO
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("From/to country")]
		public string M3_FTCO => GetString("FTCO");

		/// <summary>
		/// Description: VAT registration number
		/// FieldName: YVRN
		/// FieldType: A
		/// Length: 16
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("VAT registration number")]
		public string M3_YVRN => GetString("YVRN");

		/// <summary>
		/// Description: Triangulation
		/// FieldName: TRIA
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Triangulation")]
		public int? M3_TRIA => GetNullableInt("TRIA");

		/// <summary>
		/// Description: Recorded amount
		/// FieldName: ACAM
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Recorded amount")]
		public decimal? M3_ACAM => GetNullableDecimal("ACAM");

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
		/// Description: Customer/supplier code
		/// FieldName: CVOP
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Customer/supplier code")]
		public int? M3_CVOP => GetNullableInt("CVOP");

		/// <summary>
		/// Description: Customer number
		/// FieldName: CUNO
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Customer number")]
		public string M3_CUNO => GetString("CUNO");

		/// <summary>
		/// Description: Correction period
		/// FieldName: CORP
		/// FieldType: N
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Correction period")]
		public int? M3_CORP => GetNullableInt("CORP");

		/// <summary>
		/// Description: Service indicator
		/// FieldName: SERV
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Service indicator")]
		public int? M3_SERV => GetNullableInt("SERV");

		/// <summary>
		/// Description: Calculation base
		/// FieldName: BACA
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Calculation base")]
		public decimal? M3_BACA => GetNullableDecimal("BACA");

		/// <summary>
		/// Description: Correct original invoice amount
		/// FieldName: CACA
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Correct original invoice amount")]
		public decimal? M3_CACA => GetNullableDecimal("CACA");

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
		/// Description: Period
		/// FieldName: PERI
		/// FieldType: N
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Period")]
		public int? M3_PERI => GetNullableInt("PERI");

		/// <summary>
		/// Description: Quarter of the year
		/// FieldName: QUAR
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Quarter of the year")]
		public int? M3_QUAR => GetNullableInt("QUAR");

		/// <summary>
		/// Description: Number of invoices
		/// FieldName: NINV
		/// FieldType: N
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Number of invoices")]
		public long? M3_NINV => GetNullableLong("NINV");
	}
}
// EOF
