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

namespace M3H5Lib.Api.CRS610MI
{
	public partial class GetRentalDataResponse : M3BaseRecord 
	{

		/// <summary>
		/// Description: Rental price list table
		/// FieldName: RPLT
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Rental price list table")]
		public string M3_RPLT => GetString("RPLT");

		/// <summary>
		/// Description: Rental discount model
		/// FieldName: RDIS
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Rental discount model")]
		public string M3_RDIS => GetString("RDIS");

		/// <summary>
		/// Description: Rental payment terms
		/// FieldName: RTEP
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Rental payment terms")]
		public string M3_RTEP => GetString("RTEP");

		/// <summary>
		/// Description: Rental salesperson
		/// FieldName: RSMC
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Rental salesperson")]
		public string M3_RSMC => GetString("RSMC");

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
		/// Description: Rental rate type
		/// FieldName: ST75
		/// FieldType: A
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Rental rate type")]
		public string M3_ST75 => GetString("ST75");

		/// <summary>
		/// Description: Number of shifts
		/// FieldName: ST76
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Number of shifts")]
		public int? M3_ST76 => GetNullableInt("ST76");

		/// <summary>
		/// Description: Number of days per week
		/// FieldName: ST77
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Number of days per week")]
		public int? M3_ST77 => GetNullableInt("ST77");

		/// <summary>
		/// Description: Minimum days/week to invoice a week
		/// FieldName: ST78
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Minimum days/week to invoice a week")]
		public int? M3_ST78 => GetNullableInt("ST78");

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
		/// Description: Minimum rental type
		/// FieldName: MRTP
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Minimum rental type")]
		public int? M3_MRTP => GetNullableInt("MRTP");

		/// <summary>
		/// Description: Min rental amount
		/// FieldName: MINV
		/// FieldType: N
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Min rental amount")]
		public decimal? M3_MINV => GetNullableDecimal("MINV");

		/// <summary>
		/// Description: Min rental period
		/// FieldName: MIHP
		/// FieldType: N
		/// Length: 8
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Min rental period")]
		public int? M3_MIHP => GetNullableInt("MIHP");

		/// <summary>
		/// Description: Return year - open agreement
		/// FieldName: RTYR
		/// FieldType: N
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Return year - open agreement")]
		public int? M3_RTYR => GetNullableInt("RTYR");

		/// <summary>
		/// Description: Return month - open agreement
		/// FieldName: RTMO
		/// FieldType: N
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Return month - open agreement")]
		public int? M3_RTMO => GetNullableInt("RTMO");

		/// <summary>
		/// Description: Invoice interval - years
		/// FieldName: IIYR
		/// FieldType: N
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Invoice interval - years")]
		public int? M3_IIYR => GetNullableInt("IIYR");

		/// <summary>
		/// Description: Invoice interval - months
		/// FieldName: IIMO
		/// FieldType: N
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Invoice interval - months")]
		public int? M3_IIMO => GetNullableInt("IIMO");

		/// <summary>
		/// Description: Invoice intervall days
		/// FieldName: IIDA
		/// FieldType: N
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Invoice intervall days")]
		public int? M3_IIDA => GetNullableInt("IIDA");

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
	}
}
// EOF
