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

namespace M3H5Lib.Api.LTS101MI
{
	public partial class GetLeaseCondResponse : M3BaseRecord 
	{

		/// <summary>
		/// Description: Agreement number
		/// FieldName: AGNB
		/// FieldType: A
		/// Length: 7
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Agreement number")]
		public string M3AGNB => GetString("AGNB");

		/// <summary>
		/// Description: Line number
		/// FieldName: PONR
		/// FieldType: N
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Line number")]
		public int? M3PONR => GetNullableInt("PONR");

		/// <summary>
		/// Description: Line suffix
		/// FieldName: POSX
		/// FieldType: N
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Line suffix")]
		public int? M3POSX => GetNullableInt("POSX");

		/// <summary>
		/// Description: Item number
		/// FieldName: ITNO
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Item number")]
		public string M3ITNO => GetString("ITNO");

		/// <summary>
		/// Description: Lot number
		/// FieldName: BANO
		/// FieldType: A
		/// Length: 20
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Lot number")]
		public string M3BANO => GetString("BANO");

		/// <summary>
		/// Description: Subnumber
		/// FieldName: SBNO
		/// FieldType: N
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Subnumber")]
		public int? M3SBNO => GetNullableInt("SBNO");

		/// <summary>
		/// Description: Agreement customer
		/// FieldName: AGCN
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Agreement customer")]
		public string M3AGCN => GetString("AGCN");

		/// <summary>
		/// Description: Model description
		/// FieldName: MODE
		/// FieldType: A
		/// Length: 30
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Model description")]
		public string M3MODE => GetString("MODE");

		/// <summary>
		/// Description: Text
		/// FieldName: TX25
		/// FieldType: A
		/// Length: 25
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Text")]
		public string M3TX25 => GetString("TX25");

		/// <summary>
		/// Description: Individual item type
		/// FieldName: INTY
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Individual item type")]
		public int? M3INTY => GetNullableInt("INTY");

		/// <summary>
		/// Description: Brand
		/// FieldName: BRAN
		/// FieldType: A
		/// Length: 8
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Brand")]
		public string M3BRAN => GetString("BRAN");

		/// <summary>
		/// Description: Status
		/// FieldName: STAT
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Status")]
		public string M3STAT => GetString("STAT");

		/// <summary>
		/// Description: Number of periods
		/// FieldName: NOPR
		/// FieldType: N
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Number of periods")]
		public int? M3NOPR => GetNullableInt("NOPR");

		/// <summary>
		/// Description: Valid from
		/// FieldName: FVDT
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Valid from")]
		public DateTime? M3FVDT => GetNullableDateTime("FVDT");

		/// <summary>
		/// Description: Valid to
		/// FieldName: LVDT
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Valid to")]
		public DateTime? M3LVDT => GetNullableDateTime("LVDT");

		/// <summary>
		/// Description: Months/period
		/// FieldName: CMPP
		/// FieldType: N
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Months/period")]
		public int? M3CMPP => GetNullableInt("CMPP");

		/// <summary>
		/// Description: Invoicing method
		/// FieldName: INVM
		/// FieldType: A
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Invoicing method")]
		public string M3INVM => GetString("INVM");

		/// <summary>
		/// Description: Customer price
		/// FieldName: CSPR
		/// FieldType: N
		/// Length: 19
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Customer price")]
		public decimal? M3CSPR => GetNullableDecimal("CSPR");

		/// <summary>
		/// Description: Residual value
		/// FieldName: RESV
		/// FieldType: N
		/// Length: 19
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Residual value")]
		public decimal? M3RESV => GetNullableDecimal("RESV");

		/// <summary>
		/// Description: Residual %
		/// FieldName: REPE
		/// FieldType: N
		/// Length: 7
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Residual %")]
		public int? M3REPE => GetNullableInt("REPE");

		/// <summary>
		/// Description: Interest type
		/// FieldName: INTT
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Interest type")]
		public string M3INTT => GetString("INTT");

		/// <summary>
		/// Description: Interest rate
		/// FieldName: INPE
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Interest rate")]
		public decimal? M3INPE => GetNullableDecimal("INPE");

		/// <summary>
		/// Description: Rent amount
		/// FieldName: RENT
		/// FieldType: N
		/// Length: 19
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Rent amount")]
		public decimal? M3RENT => GetNullableDecimal("RENT");

		/// <summary>
		/// Description: Currency
		/// FieldName: CUCD
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Currency")]
		public string M3CUCD => GetString("CUCD");

		/// <summary>
		/// Description: Minimun variable interest rate
		/// FieldName: INLL
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Minimun variable interest rate")]
		public decimal? M3INLL => GetNullableDecimal("INLL");

		/// <summary>
		/// Description: Interest threshold value
		/// FieldName: INTH
		/// FieldType: N
		/// Length: 7
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Interest threshold value")]
		public int? M3INTH => GetNullableInt("INTH");

		/// <summary>
		/// Description: Start interest rate
		/// FieldName: INSV
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Start interest rate")]
		public decimal? M3INSV => GetNullableDecimal("INSV");

		/// <summary>
		/// Description: Last interest change date
		/// FieldName: ICDT
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Last interest change date")]
		public DateTime? M3ICDT => GetNullableDateTime("ICDT");

		/// <summary>
		/// Description: Compare interest
		/// FieldName: INCM
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Compare interest")]
		public decimal? M3INCM => GetNullableDecimal("INCM");

		/// <summary>
		/// Description: Margin amount
		/// FieldName: MARG
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Margin amount")]
		public decimal? M3MARG => GetNullableDecimal("MARG");

		/// <summary>
		/// Description: User-defined field 1 alfa
		/// FieldName: FFA1
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("User-defined field 1 alfa")]
		public string M3FFA1 => GetString("FFA1");

		/// <summary>
		/// Description: User-defined field 1 alfa
		/// FieldName: FFA2
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("User-defined field 1 alfa")]
		public string M3FFA2 => GetString("FFA2");

		/// <summary>
		/// Description: User-defined field 1 alfa
		/// FieldName: FFA3
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("User-defined field 1 alfa")]
		public string M3FFA3 => GetString("FFA3");

		/// <summary>
		/// Description: User-defined field 1 alfa
		/// FieldName: FFA4
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("User-defined field 1 alfa")]
		public string M3FFA4 => GetString("FFA4");

		/// <summary>
		/// Description: User-defined field 1 alfa
		/// FieldName: FFA5
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("User-defined field 1 alfa")]
		public string M3FFA5 => GetString("FFA5");

		/// <summary>
		/// Description: User-defined field 1 alfa
		/// FieldName: FFA6
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("User-defined field 1 alfa")]
		public string M3FFA6 => GetString("FFA6");

		/// <summary>
		/// Description: User-defined field 1 alfa
		/// FieldName: FFA7
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("User-defined field 1 alfa")]
		public string M3FFA7 => GetString("FFA7");

		/// <summary>
		/// Description: User-defined field 1 alfa
		/// FieldName: FFA8
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("User-defined field 1 alfa")]
		public string M3FFA8 => GetString("FFA8");

		/// <summary>
		/// Description: User-defined field 1 alfa
		/// FieldName: FFA9
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("User-defined field 1 alfa")]
		public string M3FFA9 => GetString("FFA9");

		/// <summary>
		/// Description: User-defined field 1 alfa
		/// FieldName: FFA0
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("User-defined field 1 alfa")]
		public string M3FFA0 => GetString("FFA0");

		/// <summary>
		/// Description: User-defined field 1 numeric
		/// FieldName: FFN1
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("User-defined field 1 numeric")]
		public decimal? M3FFN1 => GetNullableDecimal("FFN1");

		/// <summary>
		/// Description: User-defined field 1 numeric
		/// FieldName: FFN2
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("User-defined field 1 numeric")]
		public decimal? M3FFN2 => GetNullableDecimal("FFN2");

		/// <summary>
		/// Description: User-defined field 1 numeric
		/// FieldName: FFN3
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("User-defined field 1 numeric")]
		public decimal? M3FFN3 => GetNullableDecimal("FFN3");

		/// <summary>
		/// Description: User-defined field 1 numeric
		/// FieldName: FFN4
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("User-defined field 1 numeric")]
		public decimal? M3FFN4 => GetNullableDecimal("FFN4");

		/// <summary>
		/// Description: User-defined field 1 numeric
		/// FieldName: FFN5
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("User-defined field 1 numeric")]
		public decimal? M3FFN5 => GetNullableDecimal("FFN5");

		/// <summary>
		/// Description: User-defined field 1 numeric
		/// FieldName: FFN6
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("User-defined field 1 numeric")]
		public decimal? M3FFN6 => GetNullableDecimal("FFN6");

		/// <summary>
		/// Description: User-defined field 1 numeric
		/// FieldName: FFN7
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("User-defined field 1 numeric")]
		public decimal? M3FFN7 => GetNullableDecimal("FFN7");

		/// <summary>
		/// Description: User-defined field 1 numeric
		/// FieldName: FFN8
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("User-defined field 1 numeric")]
		public decimal? M3FFN8 => GetNullableDecimal("FFN8");

		/// <summary>
		/// Description: User-defined field 1 numeric
		/// FieldName: FFN9
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("User-defined field 1 numeric")]
		public decimal? M3FFN9 => GetNullableDecimal("FFN9");

		/// <summary>
		/// Description: User-defined field 1 numeric
		/// FieldName: FFN0
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("User-defined field 1 numeric")]
		public decimal? M3FFN0 => GetNullableDecimal("FFN0");
	}
}
// EOF
