/// **********************************************************************
/// This class is auto-generated.
/// Updated: 6/5/2024 3:52:20 PM
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

namespace M3H5Lib.Api.ARS120MI
{
	public partial class LstSalesTaxInfoResponse : M3BaseRecord 
	{

		/// <summary>
		/// Description: Job number
		/// FieldName: JBNO
		/// FieldType: N
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Job number")]
		public int? M3JBNO => GetNullableInt("JBNO");

		/// <summary>
		/// Description: Job date
		/// FieldName: JBDT
		/// FieldType: D
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Job date")]
		public DateTime? M3JBDT => GetNullableDateTime("JBDT");

		/// <summary>
		/// Description: Job time
		/// FieldName: JBTM
		/// FieldType: N
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Job time")]
		public int? M3JBTM => GetNullableInt("JBTM");

		/// <summary>
		/// Description: Company
		/// FieldName: CONO
		/// FieldType: N
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Company")]
		public int? M3CONO => GetNullableInt("CONO");

		/// <summary>
		/// Description: Division
		/// FieldName: DIVI
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Division")]
		public string M3DIVI => GetString("DIVI");

		/// <summary>
		/// Description: Invoice number
		/// FieldName: CINO
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Invoice number")]
		public string M3CINO => GetString("CINO");

		/// <summary>
		/// Description: Invoice year
		/// FieldName: INYR
		/// FieldType: N
		/// Length: 4
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Invoice year")]
		public int? M3INYR => GetNullableInt("INYR");

		/// <summary>
		/// Description: Customer
		/// FieldName: CUNO
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Customer")]
		public string M3CUNO => GetString("CUNO");

		/// <summary>
		/// Description: Sequence number
		/// FieldName: SEQN
		/// FieldType: N
		/// Length: 7
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Sequence number")]
		public int? M3SEQN => GetNullableInt("SEQN");

		/// <summary>
		/// Description: Tax amount 1
		/// FieldName: TXA1
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Tax amount 1")]
		public decimal? M3TXA1 => GetNullableDecimal("TXA1");

		/// <summary>
		/// Description: Tax amt 1, loc curr (calculated)
		/// FieldName: CTX1
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Tax amt 1, loc curr (calculated)")]
		public decimal? M3CTX1 => GetNullableDecimal("CTX1");

		/// <summary>
		/// Description: Tax rate 1
		/// FieldName: TXR1
		/// FieldType: N
		/// Length: 13
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Tax rate 1")]
		public decimal? M3TXR1 => GetNullableDecimal("TXR1");

		/// <summary>
		/// Description: Tax description 1
		/// FieldName: TXD1
		/// FieldType: A
		/// Length: 40
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Tax description 1")]
		public string M3TXD1 => GetString("TXD1");

		/// <summary>
		/// Description: Tax amount 2
		/// FieldName: TXA2
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Tax amount 2")]
		public decimal? M3TXA2 => GetNullableDecimal("TXA2");

		/// <summary>
		/// Description: Tax amt 2, loc curr (calculated)
		/// FieldName: CTX2
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Tax amt 2, loc curr (calculated)")]
		public decimal? M3CTX2 => GetNullableDecimal("CTX2");

		/// <summary>
		/// Description: Tax rate 2
		/// FieldName: TXR2
		/// FieldType: N
		/// Length: 13
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Tax rate 2")]
		public decimal? M3TXR2 => GetNullableDecimal("TXR2");

		/// <summary>
		/// Description: Tax description 2
		/// FieldName: TXD2
		/// FieldType: A
		/// Length: 40
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Tax description 2")]
		public string M3TXD2 => GetString("TXD2");

		/// <summary>
		/// Description: Tax code customer/address
		/// FieldName: TAXC
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Tax code customer/address")]
		public string M3TAXC => GetString("TAXC");

		/// <summary>
		/// Description: Tax amount 3
		/// FieldName: TXA3
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Tax amount 3")]
		public decimal? M3TXA3 => GetNullableDecimal("TXA3");

		/// <summary>
		/// Description: Tax amt 3, loc curr (calculated)
		/// FieldName: CTX3
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Tax amt 3, loc curr (calculated)")]
		public decimal? M3CTX3 => GetNullableDecimal("CTX3");

		/// <summary>
		/// Description: Tax rate 3
		/// FieldName: TXR3
		/// FieldType: N
		/// Length: 13
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Tax rate 3")]
		public decimal? M3TXR3 => GetNullableDecimal("TXR3");

		/// <summary>
		/// Description: Tax description 3
		/// FieldName: TXD3
		/// FieldType: A
		/// Length: 40
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Tax description 3")]
		public string M3TXD3 => GetString("TXD3");

		/// <summary>
		/// Description: Tax amount 4
		/// FieldName: TXA4
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Tax amount 4")]
		public decimal? M3TXA4 => GetNullableDecimal("TXA4");

		/// <summary>
		/// Description: Tax amt 4, loc curr (calculated)
		/// FieldName: CTX4
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Tax amt 4, loc curr (calculated)")]
		public decimal? M3CTX4 => GetNullableDecimal("CTX4");

		/// <summary>
		/// Description: Tax rate 4
		/// FieldName: TXR4
		/// FieldType: N
		/// Length: 13
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Tax rate 4")]
		public decimal? M3TXR4 => GetNullableDecimal("TXR4");

		/// <summary>
		/// Description: Tax description 4
		/// FieldName: TXD4
		/// FieldType: A
		/// Length: 40
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Tax description 4")]
		public string M3TXD4 => GetString("TXD4");

		/// <summary>
		/// Description: Tax amount 5
		/// FieldName: TXA5
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Tax amount 5")]
		public decimal? M3TXA5 => GetNullableDecimal("TXA5");

		/// <summary>
		/// Description: Tax amt 5, loc curr (calculated)
		/// FieldName: CTX5
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Tax amt 5, loc curr (calculated)")]
		public decimal? M3CTX5 => GetNullableDecimal("CTX5");

		/// <summary>
		/// Description: Tax rate 5
		/// FieldName: TXR5
		/// FieldType: N
		/// Length: 13
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Tax rate 5")]
		public decimal? M3TXR5 => GetNullableDecimal("TXR5");

		/// <summary>
		/// Description: Tax description 5
		/// FieldName: TXD5
		/// FieldType: A
		/// Length: 40
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Tax description 5")]
		public string M3TXD5 => GetString("TXD5");
	}
}
// EOF
