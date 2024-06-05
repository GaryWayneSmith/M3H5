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

namespace M3H5Lib.Api.MMS072MI
{
	public partial class GetCumulativeResponse : M3BaseRecord 
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
		/// Description: Internal reference type
		/// FieldName: IRTY
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Internal reference type")]
		public int? M3_IRTY => GetNullableInt("IRTY");

		/// <summary>
		/// Description: Internal reference
		/// FieldName: INRF
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Internal reference")]
		public string M3_INRF => GetString("INRF");

		/// <summary>
		/// Description: Cumulative level
		/// FieldName: CUML
		/// FieldType: N
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Cumulative level")]
		public int? M3_CUML => GetNullableInt("CUML");

		/// <summary>
		/// Description: Warehouse
		/// FieldName: WHLO
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Warehouse")]
		public string M3_WHLO => GetString("WHLO");

		/// <summary>
		/// Description: Address number
		/// FieldName: ADID
		/// FieldType: A
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Address number")]
		public string M3_ADID => GetString("ADID");

		/// <summary>
		/// Description: Delivery specification
		/// FieldName: DLSP
		/// FieldType: A
		/// Length: 12
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Delivery specification")]
		public string M3_DLSP => GetString("DLSP");

		/// <summary>
		/// Description: Model/year
		/// FieldName: MOYE
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Model/year")]
		public string M3_MOYE => GetString("MOYE");

		/// <summary>
		/// Description: Blanket agreement number
		/// FieldName: AGNO
		/// FieldType: A
		/// Length: 7
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Blanket agreement number")]
		public string M3_AGNO => GetString("AGNO");

		/// <summary>
		/// Description: Cumulative quantity
		/// FieldName: CQCF
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Cumulative quantity")]
		public decimal? M3_CQCF => GetNullableDecimal("CQCF");

		/// <summary>
		/// Description: Cumulative quantity alternate U/M
		/// FieldName: CQCA
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Cumulative quantity alternate U/M")]
		public decimal? M3_CQCA => GetNullableDecimal("CQCA");

		/// <summary>
		/// Description: Cumulative calculation date
		/// FieldName: CUMD
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Cumulative calculation date")]
		public DateTime? M3_CUMD => GetNullableDateTime("CUMD");

		/// <summary>
		/// Description: Alias number
		/// FieldName: POPN
		/// FieldType: A
		/// Length: 30
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Alias number")]
		public string M3_POPN => GetString("POPN");

		/// <summary>
		/// Description: Alias category
		/// FieldName: ALWT
		/// FieldType: N
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Alias category")]
		public int? M3_ALWT => GetNullableInt("ALWT");

		/// <summary>
		/// Description: Alias qualifier
		/// FieldName: ALWQ
		/// FieldType: A
		/// Length: 4
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Alias qualifier")]
		public string M3_ALWQ => GetString("ALWQ");

		/// <summary>
		/// Description: Cumulative from date
		/// FieldName: CUFD
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Cumulative from date")]
		public DateTime? M3_CUFD => GetNullableDateTime("CUFD");

		/// <summary>
		/// Description: Deduct returns
		/// FieldName: CUMR
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Deduct returns")]
		public int? M3_CUMR => GetNullableInt("CUMR");

		/// <summary>
		/// Description: Year to year cumulative calculation
		/// FieldName: CUAY
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Year to year cumulative calculation")]
		public int? M3_CUAY => GetNullableInt("CUAY");
	}
}
// EOF
