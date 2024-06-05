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

namespace M3H5Lib.Api.STS107MI
{
	public partial class SimRentalPrcResponse : M3BaseRecord 
	{

		/// <summary>
		/// Description: Agreement customer
		/// FieldName: AGCN
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Agreement customer")]
		public string M3_AGCN => GetString("AGCN");

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
		/// Description: Ordered quantity - basic U/M
		/// FieldName: ORQT
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Ordered quantity - basic U/M")]
		public decimal? M3_ORQT => GetNullableDecimal("ORQT");

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
		/// Description: Valid to
		/// FieldName: LVDT
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Valid to")]
		public DateTime? M3_LVDT => GetNullableDateTime("LVDT");

		/// <summary>
		/// Description: Agreement order type
		/// FieldName: AOTP
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Agreement order type")]
		public string M3_AOTP => GetString("AOTP");

		/// <summary>
		/// Description: Rental depot
		/// FieldName: DPOT
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Rental depot")]
		public string M3_DPOT => GetString("DPOT");

		/// <summary>
		/// Description: Facility
		/// FieldName: FACI
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Facility")]
		public string M3_FACI => GetString("FACI");

		/// <summary>
		/// Description: Line type
		/// FieldName: LTYP
		/// FieldType: A
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Line type")]
		public string M3_LTYP => GetString("LTYP");

		/// <summary>
		/// Description: Rental rate type
		/// FieldName: CCAP
		/// FieldType: A
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Rental rate type")]
		public string M3_CCAP => GetString("CCAP");

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
		/// Description: Rate factor
		/// FieldName: RAFA
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Rate factor")]
		public int? M3_RAFA => GetNullableInt("RAFA");

		/// <summary>
		/// Description: Days per week
		/// FieldName: ADPW
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Days per week")]
		public int? M3_ADPW => GetNullableInt("ADPW");

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
		/// Description: Rate
		/// FieldName: PPCA
		/// FieldType: N
		/// Length: 19
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Rate")]
		public decimal? M3_PPCA => GetNullableDecimal("PPCA");

		/// <summary>
		/// Description: Net rate/rental rate type
		/// FieldName: PNCA
		/// FieldType: N
		/// Length: 19
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Net rate/rental rate type")]
		public decimal? M3_PNCA => GetNullableDecimal("PNCA");

		/// <summary>
		/// Description: Gross weekly price
		/// FieldName: GRWP
		/// FieldType: N
		/// Length: 19
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Gross weekly price")]
		public decimal? M3_GRWP => GetNullableDecimal("GRWP");

		/// <summary>
		/// Description: Net weekly price
		/// FieldName: NEWP
		/// FieldType: N
		/// Length: 19
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Net weekly price")]
		public decimal? M3_NEWP => GetNullableDecimal("NEWP");

		/// <summary>
		/// Description: Daily rate
		/// FieldName: PDAP
		/// FieldType: N
		/// Length: 19
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Daily rate")]
		public decimal? M3_PDAP => GetNullableDecimal("PDAP");

		/// <summary>
		/// Description: Net daily rate
		/// FieldName: PDAN
		/// FieldType: N
		/// Length: 19
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Net daily rate")]
		public decimal? M3_PDAN => GetNullableDecimal("PDAN");

		/// <summary>
		/// Description: Hourly rate
		/// FieldName: PHOR
		/// FieldType: N
		/// Length: 19
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Hourly rate")]
		public decimal? M3_PHOR => GetNullableDecimal("PHOR");

		/// <summary>
		/// Description: Net hourly rate
		/// FieldName: PHON
		/// FieldType: N
		/// Length: 19
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Net hourly rate")]
		public decimal? M3_PHON => GetNullableDecimal("PHON");

		/// <summary>
		/// Description: Cost price
		/// FieldName: UCOS
		/// FieldType: N
		/// Length: 19
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Cost price")]
		public decimal? M3_UCOS => GetNullableDecimal("UCOS");

		/// <summary>
		/// Description: Sales price
		/// FieldName: SAPR
		/// FieldType: N
		/// Length: 19
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Sales price")]
		public decimal? M3_SAPR => GetNullableDecimal("SAPR");

		/// <summary>
		/// Description: Total rental price
		/// FieldName: RTTA
		/// FieldType: N
		/// Length: 19
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Total rental price")]
		public decimal? M3_RTTA => GetNullableDecimal("RTTA");

		/// <summary>
		/// Description: Sales of item
		/// FieldName: SLIT
		/// FieldType: N
		/// Length: 19
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Sales of item")]
		public decimal? M3_SLIT => GetNullableDecimal("SLIT");
	}
}
// EOF
