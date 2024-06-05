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

namespace M3H5Lib.Api.STS124MI
{
	public partial class LstMeterPriceResponse : M3BaseRecord 
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
		/// Description: Price list
		/// FieldName: PRRF
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Price list")]
		public string M3_PRRF => GetString("PRRF");

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
		/// Description: Customer
		/// FieldName: CUNO
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Customer")]
		public string M3_CUNO => GetString("CUNO");

		/// <summary>
		/// Description: Start date
		/// FieldName: STDT
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Start date")]
		public DateTime? M3_STDT => GetNullableDateTime("STDT");

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
		/// Description: Item group
		/// FieldName: ITGR
		/// FieldType: A
		/// Length: 8
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Item group")]
		public string M3_ITGR => GetString("ITGR");

		/// <summary>
		/// Description: Contract item
		/// FieldName: AGRS
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Contract item")]
		public string M3_AGRS => GetString("AGRS");

		/// <summary>
		/// Description: Price schedule type
		/// FieldName: PSCT
		/// FieldType: N
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Price schedule type")]
		public int? M3_PSCT => GetNullableInt("PSCT");

		/// <summary>
		/// Description: Agr qty per day 1
		/// FieldName: ATD1
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Agr qty per day 1")]
		public decimal? M3_ATD1 => GetNullableDecimal("ATD1");

		/// <summary>
		/// Description: Agr qty per day 2
		/// FieldName: ATD2
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Agr qty per day 2")]
		public decimal? M3_ATD2 => GetNullableDecimal("ATD2");

		/// <summary>
		/// Description: Agr qty per day 3
		/// FieldName: ATD3
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Agr qty per day 3")]
		public decimal? M3_ATD3 => GetNullableDecimal("ATD3");

		/// <summary>
		/// Description: Agr qty per day 0
		/// FieldName: ATD0
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Agr qty per day 0")]
		public decimal? M3_ATD0 => GetNullableDecimal("ATD0");

		/// <summary>
		/// Description: Agr qty per week(5) 1
		/// FieldName: AW15
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Agr qty per week(5) 1")]
		public decimal? M3_AW15 => GetNullableDecimal("AW15");

		/// <summary>
		/// Description: Agr qty per week(5) 2
		/// FieldName: AW25
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Agr qty per week(5) 2")]
		public decimal? M3_AW25 => GetNullableDecimal("AW25");

		/// <summary>
		/// Description: Agr qty per week(5) 3
		/// FieldName: AW35
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Agr qty per week(5) 3")]
		public decimal? M3_AW35 => GetNullableDecimal("AW35");

		/// <summary>
		/// Description: Agr qty per week(5) 0
		/// FieldName: AW05
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Agr qty per week(5) 0")]
		public decimal? M3_AW05 => GetNullableDecimal("AW05");

		/// <summary>
		/// Description: Agr qty per week(6) 1
		/// FieldName: AW16
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Agr qty per week(6) 1")]
		public decimal? M3_AW16 => GetNullableDecimal("AW16");

		/// <summary>
		/// Description: Agr qty per week(6) 2
		/// FieldName: AW26
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Agr qty per week(6) 2")]
		public decimal? M3_AW26 => GetNullableDecimal("AW26");

		/// <summary>
		/// Description: Agr qty per week(6) 3
		/// FieldName: AW36
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Agr qty per week(6) 3")]
		public decimal? M3_AW36 => GetNullableDecimal("AW36");

		/// <summary>
		/// Description: Agr qty per week(6) 0
		/// FieldName: AW06
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Agr qty per week(6) 0")]
		public decimal? M3_AW06 => GetNullableDecimal("AW06");

		/// <summary>
		/// Description: Agr qty per week(7) 1
		/// FieldName: AW17
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Agr qty per week(7) 1")]
		public decimal? M3_AW17 => GetNullableDecimal("AW17");

		/// <summary>
		/// Description: Agr qty per week(7) 2
		/// FieldName: AW27
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Agr qty per week(7) 2")]
		public decimal? M3_AW27 => GetNullableDecimal("AW27");

		/// <summary>
		/// Description: Agr qty per week(7) 3
		/// FieldName: AW37
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Agr qty per week(7) 3")]
		public decimal? M3_AW37 => GetNullableDecimal("AW37");

		/// <summary>
		/// Description: Agr qty per week(7) 0
		/// FieldName: AW07
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Agr qty per week(7) 0")]
		public decimal? M3_AW07 => GetNullableDecimal("AW07");

		/// <summary>
		/// Description: Agr qty per month(5) 1
		/// FieldName: AM15
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Agr qty per month(5) 1")]
		public decimal? M3_AM15 => GetNullableDecimal("AM15");

		/// <summary>
		/// Description: Agr qty per month(5) 2
		/// FieldName: AM25
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Agr qty per month(5) 2")]
		public decimal? M3_AM25 => GetNullableDecimal("AM25");

		/// <summary>
		/// Description: Agr qty per month(5) 3
		/// FieldName: AM35
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Agr qty per month(5) 3")]
		public decimal? M3_AM35 => GetNullableDecimal("AM35");

		/// <summary>
		/// Description: Agr qty per month(5) 0
		/// FieldName: AM05
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Agr qty per month(5) 0")]
		public decimal? M3_AM05 => GetNullableDecimal("AM05");

		/// <summary>
		/// Description: Agr qty per month(6) 1
		/// FieldName: AM16
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Agr qty per month(6) 1")]
		public decimal? M3_AM16 => GetNullableDecimal("AM16");

		/// <summary>
		/// Description: Agr qty per month(6) 2
		/// FieldName: AM26
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Agr qty per month(6) 2")]
		public decimal? M3_AM26 => GetNullableDecimal("AM26");

		/// <summary>
		/// Description: Agr qty per month(6) 3
		/// FieldName: AM36
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Agr qty per month(6) 3")]
		public decimal? M3_AM36 => GetNullableDecimal("AM36");

		/// <summary>
		/// Description: Agr qty per month(6) 0
		/// FieldName: AM06
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Agr qty per month(6) 0")]
		public decimal? M3_AM06 => GetNullableDecimal("AM06");

		/// <summary>
		/// Description: Agr qty per month(7) 1
		/// FieldName: AM17
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Agr qty per month(7) 1")]
		public decimal? M3_AM17 => GetNullableDecimal("AM17");

		/// <summary>
		/// Description: Agr qty per month(7) 2
		/// FieldName: AM27
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Agr qty per month(7) 2")]
		public decimal? M3_AM27 => GetNullableDecimal("AM27");

		/// <summary>
		/// Description: Agr qty per month(7) 3
		/// FieldName: AM37
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Agr qty per month(7) 3")]
		public decimal? M3_AM37 => GetNullableDecimal("AM37");

		/// <summary>
		/// Description: Agr qty per month(7) 0
		/// FieldName: AM07
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Agr qty per month(7) 0")]
		public decimal? M3_AM07 => GetNullableDecimal("AM07");

		/// <summary>
		/// Description: Overusage price 1
		/// FieldName: OMP1
		/// FieldType: N
		/// Length: 19
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Overusage price 1")]
		public decimal? M3_OMP1 => GetNullableDecimal("OMP1");

		/// <summary>
		/// Description: Overusage price 2
		/// FieldName: OMP2
		/// FieldType: N
		/// Length: 19
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Overusage price 2")]
		public decimal? M3_OMP2 => GetNullableDecimal("OMP2");

		/// <summary>
		/// Description: Overusage price 3
		/// FieldName: OMP3
		/// FieldType: N
		/// Length: 19
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Overusage price 3")]
		public decimal? M3_OMP3 => GetNullableDecimal("OMP3");

		/// <summary>
		/// Description: Overusage price 0
		/// FieldName: OMP0
		/// FieldType: N
		/// Length: 19
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Overusage price 0")]
		public decimal? M3_OMP0 => GetNullableDecimal("OMP0");
	}
}
// EOF
