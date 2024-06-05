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

namespace M3H5Lib.Api.LTS200MI
{
	public partial class GetFundDetailResponse : M3BaseRecord 
	{

		/// <summary>
		/// Description: Item number
		/// FieldName: ITNO
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Item number")]
		public string M3_ITNO => GetString("ITNO");

		/// <summary>
		/// Description: Lot number
		/// FieldName: BANO
		/// FieldType: A
		/// Length: 20
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Lot number")]
		public string M3_BANO => GetString("BANO");

		/// <summary>
		/// Description: Model description
		/// FieldName: MODE
		/// FieldType: A
		/// Length: 30
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Model description")]
		public string M3_MODE => GetString("MODE");

		/// <summary>
		/// Description: Text
		/// FieldName: TX25
		/// FieldType: A
		/// Length: 25
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Text")]
		public string M3_TX25 => GetString("TX25");

		/// <summary>
		/// Description: Individual item type
		/// FieldName: INTY
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Individual item type")]
		public int? M3_INTY => GetNullableInt("INTY");

		/// <summary>
		/// Description: Subnumber
		/// FieldName: SBNO
		/// FieldType: N
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Subnumber")]
		public int? M3_SBNO => GetNullableInt("SBNO");

		/// <summary>
		/// Description: Status
		/// FieldName: STAT
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Status")]
		public string M3_STAT => GetString("STAT");

		/// <summary>
		/// Description: Number of periods
		/// FieldName: NOPR
		/// FieldType: N
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Number of periods")]
		public int? M3_NOPR => GetNullableInt("NOPR");

		/// <summary>
		/// Description: Valid from
		/// FieldName: FVDT
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Valid from")]
		public DateTime? M3_FVDT => GetNullableDateTime("FVDT");

		/// <summary>
		/// Description: Months/period
		/// FieldName: CMPP
		/// FieldType: N
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Months/period")]
		public int? M3_CMPP => GetNullableInt("CMPP");

		/// <summary>
		/// Description: Invoicing method
		/// FieldName: INVM
		/// FieldType: A
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Invoicing method")]
		public string M3_INVM => GetString("INVM");

		/// <summary>
		/// Description: Funding price
		/// FieldName: FUPR
		/// FieldType: N
		/// Length: 19
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Funding price")]
		public decimal? M3_FUPR => GetNullableDecimal("FUPR");

		/// <summary>
		/// Description: Residual value
		/// FieldName: RESV
		/// FieldType: N
		/// Length: 19
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Residual value")]
		public decimal? M3_RESV => GetNullableDecimal("RESV");

		/// <summary>
		/// Description: Residual %
		/// FieldName: REPE
		/// FieldType: N
		/// Length: 7
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Residual %")]
		public int? M3_REPE => GetNullableInt("REPE");

		/// <summary>
		/// Description: Interest type
		/// FieldName: INTT
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Interest type")]
		public string M3_INTT => GetString("INTT");

		/// <summary>
		/// Description: Interest rate
		/// FieldName: INPE
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Interest rate")]
		public decimal? M3_INPE => GetNullableDecimal("INPE");

		/// <summary>
		/// Description: Rent amount
		/// FieldName: RENT
		/// FieldType: N
		/// Length: 19
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Rent amount")]
		public decimal? M3_RENT => GetNullableDecimal("RENT");

		/// <summary>
		/// Description: Brand
		/// FieldName: BRAN
		/// FieldType: A
		/// Length: 8
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Brand")]
		public string M3_BRAN => GetString("BRAN");

		/// <summary>
		/// Description: Serial number
		/// FieldName: SERI
		/// FieldType: A
		/// Length: 30
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Serial number")]
		public string M3_SERI => GetString("SERI");

		/// <summary>
		/// Description: Funder number
		/// FieldName: FUND
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Funder number")]
		public string M3_FUND => GetString("FUND");

		/// <summary>
		/// Description: Name
		/// FieldName: TX15
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Name")]
		public string M3_TX15 => GetString("TX15");

		/// <summary>
		/// Description: Invoice number
		/// FieldName: CINO
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Invoice number")]
		public string M3_CINO => GetString("CINO");

		/// <summary>
		/// Description: Funder agreement number
		/// FieldName: FUAG
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Funder agreement number")]
		public string M3_FUAG => GetString("FUAG");

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
		/// Description: Minimun variable interest rate
		/// FieldName: INLL
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Minimun variable interest rate")]
		public decimal? M3_INLL => GetNullableDecimal("INLL");

		/// <summary>
		/// Description: Interest threshold value
		/// FieldName: INTH
		/// FieldType: N
		/// Length: 7
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Interest threshold value")]
		public int? M3_INTH => GetNullableInt("INTH");

		/// <summary>
		/// Description: Start interest rate
		/// FieldName: INSV
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Start interest rate")]
		public decimal? M3_INSV => GetNullableDecimal("INSV");

		/// <summary>
		/// Description: Compare interest
		/// FieldName: INCM
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Compare interest")]
		public decimal? M3_INCM => GetNullableDecimal("INCM");

		/// <summary>
		/// Description: Last interest change date
		/// FieldName: ICDT
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Last interest change date")]
		public DateTime? M3_ICDT => GetNullableDateTime("ICDT");

		/// <summary>
		/// Description: Margin amount
		/// FieldName: MARG
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Margin amount")]
		public decimal? M3_MARG => GetNullableDecimal("MARG");

		/// <summary>
		/// Description: User-defined field 1 alfa
		/// FieldName: FFA1
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("User-defined field 1 alfa")]
		public string M3_FFA1 => GetString("FFA1");

		/// <summary>
		/// Description: User-defined field 2 alfa
		/// FieldName: FFA2
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("User-defined field 2 alfa")]
		public string M3_FFA2 => GetString("FFA2");

		/// <summary>
		/// Description: User-defined field 3 alfa
		/// FieldName: FFA3
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("User-defined field 3 alfa")]
		public string M3_FFA3 => GetString("FFA3");

		/// <summary>
		/// Description: User-defined field 4 alfa
		/// FieldName: FFA4
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("User-defined field 4 alfa")]
		public string M3_FFA4 => GetString("FFA4");

		/// <summary>
		/// Description: User-defined field 5 alfa
		/// FieldName: FFA5
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("User-defined field 5 alfa")]
		public string M3_FFA5 => GetString("FFA5");

		/// <summary>
		/// Description: User-defined field 6 alfa
		/// FieldName: FFA6
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("User-defined field 6 alfa")]
		public string M3_FFA6 => GetString("FFA6");

		/// <summary>
		/// Description: User-defined field 7 alfa
		/// FieldName: FFA7
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("User-defined field 7 alfa")]
		public string M3_FFA7 => GetString("FFA7");

		/// <summary>
		/// Description: User-defined field 8 alfa
		/// FieldName: FFA8
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("User-defined field 8 alfa")]
		public string M3_FFA8 => GetString("FFA8");

		/// <summary>
		/// Description: User-defined field 9 alfa
		/// FieldName: FFA9
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("User-defined field 9 alfa")]
		public string M3_FFA9 => GetString("FFA9");

		/// <summary>
		/// Description: User-defined field 0 alfa
		/// FieldName: FFA0
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("User-defined field 0 alfa")]
		public string M3_FFA0 => GetString("FFA0");

		/// <summary>
		/// Description: User-defined field 1 numeric
		/// FieldName: FFN1
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("User-defined field 1 numeric")]
		public decimal? M3_FFN1 => GetNullableDecimal("FFN1");

		/// <summary>
		/// Description: User-defined field 2 numeric
		/// FieldName: FFN2
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("User-defined field 2 numeric")]
		public decimal? M3_FFN2 => GetNullableDecimal("FFN2");

		/// <summary>
		/// Description: User-defined field 3 numeric
		/// FieldName: FFN3
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("User-defined field 3 numeric")]
		public decimal? M3_FFN3 => GetNullableDecimal("FFN3");

		/// <summary>
		/// Description: User-defined field 4 numeric
		/// FieldName: FFN4
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("User-defined field 4 numeric")]
		public decimal? M3_FFN4 => GetNullableDecimal("FFN4");

		/// <summary>
		/// Description: User-defined field 5 numeric
		/// FieldName: FFN5
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("User-defined field 5 numeric")]
		public decimal? M3_FFN5 => GetNullableDecimal("FFN5");

		/// <summary>
		/// Description: User-defined field 6 numeric
		/// FieldName: FFN6
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("User-defined field 6 numeric")]
		public decimal? M3_FFN6 => GetNullableDecimal("FFN6");

		/// <summary>
		/// Description: User-defined field 7 numeric
		/// FieldName: FFN7
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("User-defined field 7 numeric")]
		public decimal? M3_FFN7 => GetNullableDecimal("FFN7");

		/// <summary>
		/// Description: User-defined field 8 numeric
		/// FieldName: FFN8
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("User-defined field 8 numeric")]
		public decimal? M3_FFN8 => GetNullableDecimal("FFN8");

		/// <summary>
		/// Description: User-defined field 9 numeric
		/// FieldName: FFN9
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("User-defined field 9 numeric")]
		public decimal? M3_FFN9 => GetNullableDecimal("FFN9");

		/// <summary>
		/// Description: User-defined field 0 numeric
		/// FieldName: FFN0
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("User-defined field 0 numeric")]
		public decimal? M3_FFN0 => GetNullableDecimal("FFN0");
	}
}
// EOF
