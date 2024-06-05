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

namespace M3H5Lib.Api.STS120MI
{
	public partial class GetPrcLstLinesResponse : M3BaseRecord 
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
		/// Description: Price list
		/// FieldName: PRRF
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Price list")]
		public string M3PRRF => GetString("PRRF");

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
		/// Description: Start date
		/// FieldName: STDT
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Start date")]
		public DateTime? M3STDT => GetNullableDateTime("STDT");

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
		/// Description: Item group
		/// FieldName: ITGR
		/// FieldType: A
		/// Length: 8
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Item group")]
		public string M3ITGR => GetString("ITGR");

		/// <summary>
		/// Description: Hourly rate 1
		/// FieldName: HPS1
		/// FieldType: N
		/// Length: 19
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Hourly rate 1")]
		public decimal? M3HPS1 => GetNullableDecimal("HPS1");

		/// <summary>
		/// Description: Hourly rate 2
		/// FieldName: HPS2
		/// FieldType: N
		/// Length: 19
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Hourly rate 2")]
		public decimal? M3HPS2 => GetNullableDecimal("HPS2");

		/// <summary>
		/// Description: Hourly rate 3
		/// FieldName: HPS3
		/// FieldType: N
		/// Length: 19
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Hourly rate 3")]
		public decimal? M3HPS3 => GetNullableDecimal("HPS3");

		/// <summary>
		/// Description: Hourly rate 0
		/// FieldName: HPS0
		/// FieldType: N
		/// Length: 19
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Hourly rate 0")]
		public decimal? M3HPS0 => GetNullableDecimal("HPS0");

		/// <summary>
		/// Description: Daily rate 1
		/// FieldName: DPS1
		/// FieldType: N
		/// Length: 19
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Daily rate 1")]
		public decimal? M3DPS1 => GetNullableDecimal("DPS1");

		/// <summary>
		/// Description: Daily rate 2
		/// FieldName: DPS2
		/// FieldType: N
		/// Length: 19
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Daily rate 2")]
		public decimal? M3DPS2 => GetNullableDecimal("DPS2");

		/// <summary>
		/// Description: Daily rate 3
		/// FieldName: DPS3
		/// FieldType: N
		/// Length: 19
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Daily rate 3")]
		public decimal? M3DPS3 => GetNullableDecimal("DPS3");

		/// <summary>
		/// Description: Daily rate 0
		/// FieldName: DPS0
		/// FieldType: N
		/// Length: 19
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Daily rate 0")]
		public decimal? M3DPS0 => GetNullableDecimal("DPS0");

		/// <summary>
		/// Description: Weekly rate(5) 1
		/// FieldName: WP15
		/// FieldType: N
		/// Length: 19
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Weekly rate(5) 1")]
		public decimal? M3WP15 => GetNullableDecimal("WP15");

		/// <summary>
		/// Description: Weekly rate(5) 2
		/// FieldName: WP25
		/// FieldType: N
		/// Length: 19
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Weekly rate(5) 2")]
		public decimal? M3WP25 => GetNullableDecimal("WP25");

		/// <summary>
		/// Description: Weekly rate(5) 3
		/// FieldName: WP35
		/// FieldType: N
		/// Length: 19
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Weekly rate(5) 3")]
		public decimal? M3WP35 => GetNullableDecimal("WP35");

		/// <summary>
		/// Description: Weekly rate(5) 0
		/// FieldName: WP05
		/// FieldType: N
		/// Length: 19
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Weekly rate(5) 0")]
		public decimal? M3WP05 => GetNullableDecimal("WP05");

		/// <summary>
		/// Description: Weekly rate(6) 1
		/// FieldName: WP16
		/// FieldType: N
		/// Length: 19
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Weekly rate(6) 1")]
		public decimal? M3WP16 => GetNullableDecimal("WP16");

		/// <summary>
		/// Description: Weekly rate(6) 2
		/// FieldName: WP26
		/// FieldType: N
		/// Length: 19
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Weekly rate(6) 2")]
		public decimal? M3WP26 => GetNullableDecimal("WP26");

		/// <summary>
		/// Description: Weekly rate(6) 3
		/// FieldName: WP36
		/// FieldType: N
		/// Length: 19
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Weekly rate(6) 3")]
		public decimal? M3WP36 => GetNullableDecimal("WP36");

		/// <summary>
		/// Description: Weekly rate(6) 0
		/// FieldName: WP06
		/// FieldType: N
		/// Length: 19
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Weekly rate(6) 0")]
		public decimal? M3WP06 => GetNullableDecimal("WP06");

		/// <summary>
		/// Description: Weekly rate(7) 1
		/// FieldName: WP17
		/// FieldType: N
		/// Length: 19
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Weekly rate(7) 1")]
		public decimal? M3WP17 => GetNullableDecimal("WP17");

		/// <summary>
		/// Description: Weekly rate(7) 2
		/// FieldName: WP27
		/// FieldType: N
		/// Length: 19
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Weekly rate(7) 2")]
		public decimal? M3WP27 => GetNullableDecimal("WP27");

		/// <summary>
		/// Description: Weekly rate(7) 3
		/// FieldName: WP37
		/// FieldType: N
		/// Length: 19
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Weekly rate(7) 3")]
		public decimal? M3WP37 => GetNullableDecimal("WP37");

		/// <summary>
		/// Description: Weekly rate(7) 0
		/// FieldName: WP07
		/// FieldType: N
		/// Length: 19
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Weekly rate(7) 0")]
		public decimal? M3WP07 => GetNullableDecimal("WP07");

		/// <summary>
		/// Description: Monthly rate(5) 1
		/// FieldName: MP15
		/// FieldType: N
		/// Length: 19
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Monthly rate(5) 1")]
		public decimal? M3MP15 => GetNullableDecimal("MP15");

		/// <summary>
		/// Description: Monthly rate(5) 2
		/// FieldName: MP25
		/// FieldType: N
		/// Length: 19
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Monthly rate(5) 2")]
		public decimal? M3MP25 => GetNullableDecimal("MP25");

		/// <summary>
		/// Description: Monthly rate(5) 3
		/// FieldName: MP35
		/// FieldType: N
		/// Length: 19
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Monthly rate(5) 3")]
		public decimal? M3MP35 => GetNullableDecimal("MP35");

		/// <summary>
		/// Description: Monthly rate(5) 0
		/// FieldName: MP05
		/// FieldType: N
		/// Length: 19
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Monthly rate(5) 0")]
		public decimal? M3MP05 => GetNullableDecimal("MP05");

		/// <summary>
		/// Description: Monthly rate(6) 1
		/// FieldName: MP16
		/// FieldType: N
		/// Length: 19
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Monthly rate(6) 1")]
		public decimal? M3MP16 => GetNullableDecimal("MP16");

		/// <summary>
		/// Description: Monthly rate(6) 2
		/// FieldName: MP26
		/// FieldType: N
		/// Length: 19
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Monthly rate(6) 2")]
		public decimal? M3MP26 => GetNullableDecimal("MP26");

		/// <summary>
		/// Description: Monthly rate(6) 3
		/// FieldName: MP36
		/// FieldType: N
		/// Length: 19
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Monthly rate(6) 3")]
		public decimal? M3MP36 => GetNullableDecimal("MP36");

		/// <summary>
		/// Description: Monthly rate(6) 0
		/// FieldName: MP06
		/// FieldType: N
		/// Length: 19
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Monthly rate(6) 0")]
		public decimal? M3MP06 => GetNullableDecimal("MP06");

		/// <summary>
		/// Description: Monthly rate(7) 1
		/// FieldName: MP17
		/// FieldType: N
		/// Length: 19
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Monthly rate(7) 1")]
		public decimal? M3MP17 => GetNullableDecimal("MP17");

		/// <summary>
		/// Description: Monthly rate(7) 2
		/// FieldName: MP27
		/// FieldType: N
		/// Length: 19
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Monthly rate(7) 2")]
		public decimal? M3MP27 => GetNullableDecimal("MP27");

		/// <summary>
		/// Description: Monthly rate(7) 3
		/// FieldName: MP37
		/// FieldType: N
		/// Length: 19
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Monthly rate(7) 3")]
		public decimal? M3MP37 => GetNullableDecimal("MP37");

		/// <summary>
		/// Description: Monthly rate(7) 0
		/// FieldName: MP07
		/// FieldType: N
		/// Length: 19
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Monthly rate(7) 0")]
		public decimal? M3MP07 => GetNullableDecimal("MP07");

		/// <summary>
		/// Description: Delivery charge
		/// FieldName: DECH
		/// FieldType: N
		/// Length: 19
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Delivery charge")]
		public decimal? M3DECH => GetNullableDecimal("DECH");

		/// <summary>
		/// Description: Delivery cost
		/// FieldName: DECO
		/// FieldType: N
		/// Length: 19
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Delivery cost")]
		public decimal? M3DECO => GetNullableDecimal("DECO");

		/// <summary>
		/// Description: Cost percentage
		/// FieldName: CPER
		/// FieldType: N
		/// Length: 7
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Cost percentage")]
		public int? M3CPER => GetNullableInt("CPER");
	}
}
// EOF
