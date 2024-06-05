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

namespace M3H5Lib.Api.APS430MI
{
	public partial class GetTaxTotStaSerResponse : M3BaseRecord 
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
		/// Description: Area/state
		/// FieldName: ECAR
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Area/state")]
		public string M3ECAR => GetString("ECAR");

		/// <summary>
		/// Description: Number of payments
		/// FieldName: NOPY
		/// FieldType: N
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Number of payments")]
		public int? M3NOPY => GetNullableInt("NOPY");

		/// <summary>
		/// Description: Control total 1
		/// FieldName: PA01
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Control total 1")]
		public decimal? M3PA01 => GetNullableDecimal("PA01");

		/// <summary>
		/// Description: Control total 2
		/// FieldName: PA02
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Control total 2")]
		public decimal? M3PA02 => GetNullableDecimal("PA02");

		/// <summary>
		/// Description: Control total 3
		/// FieldName: PA03
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Control total 3")]
		public decimal? M3PA03 => GetNullableDecimal("PA03");

		/// <summary>
		/// Description: Post-actual value - component A04
		/// FieldName: PA04
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Post-actual value - component A04")]
		public decimal? M3PA04 => GetNullableDecimal("PA04");

		/// <summary>
		/// Description: Post-actual value - component A05
		/// FieldName: PA05
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Post-actual value - component A05")]
		public decimal? M3PA05 => GetNullableDecimal("PA05");

		/// <summary>
		/// Description: Control total 6
		/// FieldName: PA06
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Control total 6")]
		public decimal? M3PA06 => GetNullableDecimal("PA06");

		/// <summary>
		/// Description: Control total 7
		/// FieldName: PA07
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Control total 7")]
		public decimal? M3PA07 => GetNullableDecimal("PA07");

		/// <summary>
		/// Description: Control total 8
		/// FieldName: PA08
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Control total 8")]
		public decimal? M3PA08 => GetNullableDecimal("PA08");

		/// <summary>
		/// Description: Control total 9
		/// FieldName: PA09
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Control total 9")]
		public decimal? M3PA09 => GetNullableDecimal("PA09");

		/// <summary>
		/// Description: Control total 10
		/// FieldName: PA10
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Control total 10")]
		public decimal? M3PA10 => GetNullableDecimal("PA10");

		/// <summary>
		/// Description: Control total 11
		/// FieldName: PA11
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Control total 11")]
		public decimal? M3PA11 => GetNullableDecimal("PA11");

		/// <summary>
		/// Description: Control total 12
		/// FieldName: PA12
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Control total 12")]
		public decimal? M3PA12 => GetNullableDecimal("PA12");

		/// <summary>
		/// Description: Control total 13
		/// FieldName: PA13
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Control total 13")]
		public decimal? M3PA13 => GetNullableDecimal("PA13");

		/// <summary>
		/// Description: Control total 14
		/// FieldName: PA14
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Control total 14")]
		public decimal? M3PA14 => GetNullableDecimal("PA14");

		/// <summary>
		/// Description: Control total 16
		/// FieldName: PA15
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Control total 16")]
		public decimal? M3PA15 => GetNullableDecimal("PA15");

		/// <summary>
		/// Description: Control total 16
		/// FieldName: PA16
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Control total 16")]
		public decimal? M3PA16 => GetNullableDecimal("PA16");

		/// <summary>
		/// Description: Control total 17
		/// FieldName: PA17
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Control total 17")]
		public decimal? M3PA17 => GetNullableDecimal("PA17");

		/// <summary>
		/// Description: Control total 18
		/// FieldName: PA18
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Control total 18")]
		public decimal? M3PA18 => GetNullableDecimal("PA18");

		/// <summary>
		/// Description: Control total 19
		/// FieldName: PA19
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Control total 19")]
		public decimal? M3PA19 => GetNullableDecimal("PA19");

		/// <summary>
		/// Description: Control total 20
		/// FieldName: PA20
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Control total 20")]
		public decimal? M3PA20 => GetNullableDecimal("PA20");
	}
}
// EOF
