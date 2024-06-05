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

namespace M3H5Lib.Api.APS430MI
{
	public partial class GetTaxTotSerResponse : M3BaseRecord 
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
		/// Description: Job number
		/// FieldName: JBNO
		/// FieldType: N
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Job number")]
		public int? M3_JBNO => GetNullableInt("JBNO");

		/// <summary>
		/// Description: Job date
		/// FieldName: JBDT
		/// FieldType: D
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Job date")]
		public DateTime? M3_JBDT => GetNullableDateTime("JBDT");

		/// <summary>
		/// Description: Job time
		/// FieldName: JBTM
		/// FieldType: N
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Job time")]
		public int? M3_JBTM => GetNullableInt("JBTM");

		/// <summary>
		/// Description: Service code
		/// FieldName: SERS
		/// FieldType: N
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Service code")]
		public int? M3_SERS => GetNullableInt("SERS");

		/// <summary>
		/// Description: Payment amount
		/// FieldName: PYAM
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Payment amount")]
		public decimal? M3_PYAM => GetNullableDecimal("PYAM");

		/// <summary>
		/// Description: Withheld tax - local currency
		/// FieldName: WAAM
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Withheld tax - local currency")]
		public decimal? M3_WAAM => GetNullableDecimal("WAAM");

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
		/// Description: Control total 1
		/// FieldName: PA01
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Control total 1")]
		public decimal? M3_PA01 => GetNullableDecimal("PA01");

		/// <summary>
		/// Description: Control total 2
		/// FieldName: PA02
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Control total 2")]
		public decimal? M3_PA02 => GetNullableDecimal("PA02");

		/// <summary>
		/// Description: Control total 3
		/// FieldName: PA03
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Control total 3")]
		public decimal? M3_PA03 => GetNullableDecimal("PA03");

		/// <summary>
		/// Description: Post-actual value - component A04
		/// FieldName: PA04
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Post-actual value - component A04")]
		public decimal? M3_PA04 => GetNullableDecimal("PA04");

		/// <summary>
		/// Description: Post-actual value - component A05
		/// FieldName: PA05
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Post-actual value - component A05")]
		public decimal? M3_PA05 => GetNullableDecimal("PA05");

		/// <summary>
		/// Description: Control total 06
		/// FieldName: PA06
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Control total 06")]
		public decimal? M3_PA06 => GetNullableDecimal("PA06");

		/// <summary>
		/// Description: Control total 07
		/// FieldName: PA07
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Control total 07")]
		public decimal? M3_PA07 => GetNullableDecimal("PA07");

		/// <summary>
		/// Description: Control total 8
		/// FieldName: PA08
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Control total 8")]
		public decimal? M3_PA08 => GetNullableDecimal("PA08");

		/// <summary>
		/// Description: Control total 9
		/// FieldName: PA09
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Control total 9")]
		public decimal? M3_PA09 => GetNullableDecimal("PA09");

		/// <summary>
		/// Description: Control total 10
		/// FieldName: PA10
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Control total 10")]
		public decimal? M3_PA10 => GetNullableDecimal("PA10");

		/// <summary>
		/// Description: Control total 11
		/// FieldName: PA11
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Control total 11")]
		public decimal? M3_PA11 => GetNullableDecimal("PA11");

		/// <summary>
		/// Description: Control total 12
		/// FieldName: PA12
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Control total 12")]
		public decimal? M3_PA12 => GetNullableDecimal("PA12");

		/// <summary>
		/// Description: control total 13
		/// FieldName: PA13
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("control total 13")]
		public decimal? M3_PA13 => GetNullableDecimal("PA13");

		/// <summary>
		/// Description: Control total 14
		/// FieldName: PA14
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Control total 14")]
		public decimal? M3_PA14 => GetNullableDecimal("PA14");

		/// <summary>
		/// Description: Control total 15
		/// FieldName: PA15
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Control total 15")]
		public decimal? M3_PA15 => GetNullableDecimal("PA15");

		/// <summary>
		/// Description: Control total 16
		/// FieldName: PA16
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Control total 16")]
		public decimal? M3_PA16 => GetNullableDecimal("PA16");

		/// <summary>
		/// Description: Control total 17
		/// FieldName: PA17
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Control total 17")]
		public decimal? M3_PA17 => GetNullableDecimal("PA17");

		/// <summary>
		/// Description: Control total 18
		/// FieldName: PA18
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Control total 18")]
		public decimal? M3_PA18 => GetNullableDecimal("PA18");

		/// <summary>
		/// Description: Control total 19
		/// FieldName: PA19
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Control total 19")]
		public decimal? M3_PA19 => GetNullableDecimal("PA19");

		/// <summary>
		/// Description: Control total 20
		/// FieldName: PA20
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Control total 20")]
		public decimal? M3_PA20 => GetNullableDecimal("PA20");

		/// <summary>
		/// Description: Box identity
		/// FieldName: BOXI
		/// FieldType: N
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Box identity")]
		public int? M3_BOXI => GetNullableInt("BOXI");
	}
}
// EOF
