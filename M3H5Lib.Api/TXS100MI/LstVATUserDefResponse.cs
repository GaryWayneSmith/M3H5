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

namespace M3H5Lib.Api.TXS100MI
{
	public partial class LstVATUserDefResponse : M3BaseRecord 
	{

		/// <summary>
		/// Description: VAT report line sequence number
		/// FieldName: VRLS
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("VAT report line sequence number")]
		public decimal? M3_VRLS => GetNullableDecimal("VRLS");

		/// <summary>
		/// Description: On hold
		/// FieldName: UDBL
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("On hold")]
		public int? M3_UDBL => GetNullableInt("UDBL");

		/// <summary>
		/// Description: Changed line
		/// FieldName: CHGL
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Changed line")]
		public int? M3_CHGL => GetNullableInt("CHGL");

		/// <summary>
		/// Description: Primary key 1
		/// FieldName: UK01
		/// FieldType: A
		/// Length: 24
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Primary key 1")]
		public string M3_UK01 => GetString("UK01");

		/// <summary>
		/// Description: Primary key 2
		/// FieldName: UK02
		/// FieldType: A
		/// Length: 24
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Primary key 2")]
		public string M3_UK02 => GetString("UK02");

		/// <summary>
		/// Description: Primary key 3
		/// FieldName: UK03
		/// FieldType: A
		/// Length: 24
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Primary key 3")]
		public string M3_UK03 => GetString("UK03");

		/// <summary>
		/// Description: Primary key 4
		/// FieldName: UK04
		/// FieldType: A
		/// Length: 24
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Primary key 4")]
		public string M3_UK04 => GetString("UK04");

		/// <summary>
		/// Description: Primary key 5
		/// FieldName: UK05
		/// FieldType: A
		/// Length: 24
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Primary key 5")]
		public string M3_UK05 => GetString("UK05");

		/// <summary>
		/// Description: Primary key 6
		/// FieldName: UK06
		/// FieldType: A
		/// Length: 24
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Primary key 6")]
		public string M3_UK06 => GetString("UK06");

		/// <summary>
		/// Description: Primary key 7
		/// FieldName: UK07
		/// FieldType: A
		/// Length: 24
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Primary key 7")]
		public string M3_UK07 => GetString("UK07");

		/// <summary>
		/// Description: Primary key 8
		/// FieldName: UK08
		/// FieldType: A
		/// Length: 24
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Primary key 8")]
		public string M3_UK08 => GetString("UK08");

		/// <summary>
		/// Description: Primary key 9
		/// FieldName: UK09
		/// FieldType: A
		/// Length: 24
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Primary key 9")]
		public string M3_UK09 => GetString("UK09");

		/// <summary>
		/// Description: Primary key 10
		/// FieldName: UK10
		/// FieldType: A
		/// Length: 24
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Primary key 10")]
		public string M3_UK10 => GetString("UK10");

		/// <summary>
		/// Description: Alphanumeric data
		/// FieldName: AL01
		/// FieldType: A
		/// Length: 24
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Alphanumeric data")]
		public string M3_AL01 => GetString("AL01");

		/// <summary>
		/// Description: Alphanumeric data
		/// FieldName: AL02
		/// FieldType: A
		/// Length: 24
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Alphanumeric data")]
		public string M3_AL02 => GetString("AL02");

		/// <summary>
		/// Description: Alphanumeric data
		/// FieldName: AL03
		/// FieldType: A
		/// Length: 24
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Alphanumeric data")]
		public string M3_AL03 => GetString("AL03");

		/// <summary>
		/// Description: Alphanumeric data
		/// FieldName: AL04
		/// FieldType: A
		/// Length: 24
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Alphanumeric data")]
		public string M3_AL04 => GetString("AL04");

		/// <summary>
		/// Description: Alphanumeric data
		/// FieldName: AL05
		/// FieldType: A
		/// Length: 24
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Alphanumeric data")]
		public string M3_AL05 => GetString("AL05");

		/// <summary>
		/// Description: Alphanumeric data
		/// FieldName: AL06
		/// FieldType: A
		/// Length: 24
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Alphanumeric data")]
		public string M3_AL06 => GetString("AL06");

		/// <summary>
		/// Description: Alphanumeric data
		/// FieldName: AL07
		/// FieldType: A
		/// Length: 24
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Alphanumeric data")]
		public string M3_AL07 => GetString("AL07");

		/// <summary>
		/// Description: Alphanumeric data
		/// FieldName: AL08
		/// FieldType: A
		/// Length: 24
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Alphanumeric data")]
		public string M3_AL08 => GetString("AL08");

		/// <summary>
		/// Description: Alphanumeric data
		/// FieldName: AL09
		/// FieldType: A
		/// Length: 24
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Alphanumeric data")]
		public string M3_AL09 => GetString("AL09");

		/// <summary>
		/// Description: Alphanumeric data
		/// FieldName: AL10
		/// FieldType: A
		/// Length: 24
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Alphanumeric data")]
		public string M3_AL10 => GetString("AL10");

		/// <summary>
		/// Description: Numeric data
		/// FieldName: NU01
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Numeric data")]
		public decimal? M3_NU01 => GetNullableDecimal("NU01");

		/// <summary>
		/// Description: Numeric data
		/// FieldName: NU02
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Numeric data")]
		public decimal? M3_NU02 => GetNullableDecimal("NU02");

		/// <summary>
		/// Description: Numeric data
		/// FieldName: NU03
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Numeric data")]
		public decimal? M3_NU03 => GetNullableDecimal("NU03");

		/// <summary>
		/// Description: Numeric data
		/// FieldName: NU04
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Numeric data")]
		public decimal? M3_NU04 => GetNullableDecimal("NU04");

		/// <summary>
		/// Description: Numeric data
		/// FieldName: NU05
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Numeric data")]
		public decimal? M3_NU05 => GetNullableDecimal("NU05");

		/// <summary>
		/// Description: Numeric data
		/// FieldName: NU06
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Numeric data")]
		public decimal? M3_NU06 => GetNullableDecimal("NU06");

		/// <summary>
		/// Description: Numeric data
		/// FieldName: NU07
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Numeric data")]
		public decimal? M3_NU07 => GetNullableDecimal("NU07");

		/// <summary>
		/// Description: Date
		/// FieldName: DT01
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Date")]
		public DateTime? M3_DT01 => GetNullableDateTime("DT01");

		/// <summary>
		/// Description: Date
		/// FieldName: DT02
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Date")]
		public DateTime? M3_DT02 => GetNullableDateTime("DT02");

		/// <summary>
		/// Description: Date
		/// FieldName: DT03
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Date")]
		public DateTime? M3_DT03 => GetNullableDateTime("DT03");

		/// <summary>
		/// Description: Date
		/// FieldName: DT04
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Date")]
		public DateTime? M3_DT04 => GetNullableDateTime("DT04");

		/// <summary>
		/// Description: Date
		/// FieldName: DT05
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Date")]
		public DateTime? M3_DT05 => GetNullableDateTime("DT05");

		/// <summary>
		/// Description: Date
		/// FieldName: DT06
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Date")]
		public DateTime? M3_DT06 => GetNullableDateTime("DT06");

		/// <summary>
		/// Description: Date
		/// FieldName: DT07
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Date")]
		public DateTime? M3_DT07 => GetNullableDateTime("DT07");

		/// <summary>
		/// Description: Amount column
		/// FieldName: AC01
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Amount column")]
		public decimal? M3_AC01 => GetNullableDecimal("AC01");

		/// <summary>
		/// Description: Amount column
		/// FieldName: AC02
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Amount column")]
		public decimal? M3_AC02 => GetNullableDecimal("AC02");

		/// <summary>
		/// Description: Amount column
		/// FieldName: AC03
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Amount column")]
		public decimal? M3_AC03 => GetNullableDecimal("AC03");

		/// <summary>
		/// Description: Amount column
		/// FieldName: AC04
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Amount column")]
		public decimal? M3_AC04 => GetNullableDecimal("AC04");

		/// <summary>
		/// Description: Amount column
		/// FieldName: AC05
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Amount column")]
		public decimal? M3_AC05 => GetNullableDecimal("AC05");

		/// <summary>
		/// Description: Amount column
		/// FieldName: AC06
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Amount column")]
		public decimal? M3_AC06 => GetNullableDecimal("AC06");

		/// <summary>
		/// Description: Amount column
		/// FieldName: AC07
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Amount column")]
		public decimal? M3_AC07 => GetNullableDecimal("AC07");

		/// <summary>
		/// Description: Amount column
		/// FieldName: AC08
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Amount column")]
		public decimal? M3_AC08 => GetNullableDecimal("AC08");

		/// <summary>
		/// Description: Amount column
		/// FieldName: AC09
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Amount column")]
		public decimal? M3_AC09 => GetNullableDecimal("AC09");

		/// <summary>
		/// Description: Amount column
		/// FieldName: AC10
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Amount column")]
		public decimal? M3_AC10 => GetNullableDecimal("AC10");

		/// <summary>
		/// Description: Amount column
		/// FieldName: AC11
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Amount column")]
		public decimal? M3_AC11 => GetNullableDecimal("AC11");

		/// <summary>
		/// Description: Amount column
		/// FieldName: AC12
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Amount column")]
		public decimal? M3_AC12 => GetNullableDecimal("AC12");

		/// <summary>
		/// Description: Amount column
		/// FieldName: AC13
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Amount column")]
		public decimal? M3_AC13 => GetNullableDecimal("AC13");

		/// <summary>
		/// Description: Amount column
		/// FieldName: AC14
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Amount column")]
		public decimal? M3_AC14 => GetNullableDecimal("AC14");

		/// <summary>
		/// Description: Amount column
		/// FieldName: AC15
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Amount column")]
		public decimal? M3_AC15 => GetNullableDecimal("AC15");
	}
}
// EOF
