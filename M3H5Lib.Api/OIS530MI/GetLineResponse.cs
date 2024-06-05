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

namespace M3H5Lib.Api.OIS530MI
{
	public partial class GetLineResponse : M3BaseRecord 
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
		/// Description: Report
		/// FieldName: RPID
		/// FieldType: A
		/// Length: 8
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Report")]
		public string M3_RPID => GetString("RPID");

		/// <summary>
		/// Description: Transaction type
		/// FieldName: SSTT
		/// FieldType: N
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Transaction type")]
		public int? M3_SSTT => GetNullableInt("SSTT");

		/// <summary>
		/// Description: Transaction identity
		/// FieldName: TTID
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Transaction identity")]
		public string M3_TTID => GetString("TTID");

		/// <summary>
		/// Description: Start value 1
		/// FieldName: OBV1
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Start value 1")]
		public string M3_OBV1 => GetString("OBV1");

		/// <summary>
		/// Description: Start value 2
		/// FieldName: OBV2
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Start value 2")]
		public string M3_OBV2 => GetString("OBV2");

		/// <summary>
		/// Description: Start value 3
		/// FieldName: OBV3
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Start value 3")]
		public string M3_OBV3 => GetString("OBV3");

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
		/// Description: Sequence
		/// FieldName: SEQN
		/// FieldType: N
		/// Length: 7
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Sequence")]
		public int? M3_SEQN => GetNullableInt("SEQN");

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
		/// Description: Lowest level
		/// FieldName: LEVL
		/// FieldType: N
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Lowest level")]
		public int? M3_LEVL => GetNullableInt("LEVL");

		/// <summary>
		/// Description: Sales price source
		/// FieldName: PSID
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Sales price source")]
		public string M3_PSID => GetString("PSID");

		/// <summary>
		/// Description: Customer number
		/// FieldName: PSCN
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Customer number")]
		public string M3_PSCN => GetString("PSCN");

		/// <summary>
		/// Description: Sales price currency
		/// FieldName: PSCU
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Sales price currency")]
		public string M3_PSCU => GetString("PSCU");

		/// <summary>
		/// Description: Sales price start date
		/// FieldName: PSFD
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Sales price start date")]
		public DateTime? M3_PSFD => GetNullableDateTime("PSFD");

		/// <summary>
		/// Description: Sales price end date
		/// FieldName: PSTD
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Sales price end date")]
		public DateTime? M3_PSTD => GetNullableDateTime("PSTD");

		/// <summary>
		/// Description: Lowest quantity limit
		/// FieldName: QTYL
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Lowest quantity limit")]
		public decimal? M3_QTYL => GetNullableDecimal("QTYL");

		/// <summary>
		/// Description: Scale U/M
		/// FieldName: SGGU
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Scale U/M")]
		public string M3_SGGU => GetString("SGGU");

		/// <summary>
		/// Description: Agreed quantity
		/// FieldName: AGQT
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Agreed quantity")]
		public decimal? M3_AGQT => GetNullableDecimal("AGQT");

		/// <summary>
		/// Description: Unit of measure
		/// FieldName: UNIT
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Unit of measure")]
		public string M3_UNIT => GetString("UNIT");

		/// <summary>
		/// Description: Normal call-off quantity
		/// FieldName: NAQT
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Normal call-off quantity")]
		public decimal? M3_NAQT => GetNullableDecimal("NAQT");

		/// <summary>
		/// Description: Sales price
		/// FieldName: SAPR
		/// FieldType: N
		/// Length: 18
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Sales price")]
		public decimal? M3_SAPR => GetNullableDecimal("SAPR");

		/// <summary>
		/// Description: Sales price quantity
		/// FieldName: SACD
		/// FieldType: N
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Sales price quantity")]
		public int? M3_SACD => GetNullableInt("SACD");

		/// <summary>
		/// Description: Sales price unit of measure
		/// FieldName: SPUN
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Sales price unit of measure")]
		public string M3_SPUN => GetString("SPUN");

		/// <summary>
		/// Description: Net price used
		/// FieldName: NTCD
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Net price used")]
		public int? M3_NTCD => GetNullableInt("NTCD");

		/// <summary>
		/// Description: Sales campaign
		/// FieldName: CMNO
		/// FieldType: A
		/// Length: 4
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Sales campaign")]
		public string M3_CMNO => GetString("CMNO");

		/// <summary>
		/// Description: Bonus generating
		/// FieldName: BNCD
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Bonus generating")]
		public int? M3_BNCD => GetNullableInt("BNCD");

		/// <summary>
		/// Description: Commission generating
		/// FieldName: PRAC
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Commission generating")]
		public int? M3_PRAC => GetNullableInt("PRAC");

		/// <summary>
		/// Description: Discount model
		/// FieldName: DISY
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Discount model")]
		public string M3_DISY => GetString("DISY");

		/// <summary>
		/// Description: Discount amount 1
		/// FieldName: DIA1
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Discount amount 1")]
		public decimal? M3_DIA1 => GetNullableDecimal("DIA1");

		/// <summary>
		/// Description: Discount amount 2
		/// FieldName: DIA2
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Discount amount 2")]
		public decimal? M3_DIA2 => GetNullableDecimal("DIA2");

		/// <summary>
		/// Description: Discount amount 3
		/// FieldName: DIA3
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Discount amount 3")]
		public decimal? M3_DIA3 => GetNullableDecimal("DIA3");

		/// <summary>
		/// Description: Discount amount 4
		/// FieldName: DIA4
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Discount amount 4")]
		public decimal? M3_DIA4 => GetNullableDecimal("DIA4");

		/// <summary>
		/// Description: Discount amount 5
		/// FieldName: DIA5
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Discount amount 5")]
		public decimal? M3_DIA5 => GetNullableDecimal("DIA5");

		/// <summary>
		/// Description: Discount amount 6
		/// FieldName: DIA6
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Discount amount 6")]
		public decimal? M3_DIA6 => GetNullableDecimal("DIA6");

		/// <summary>
		/// Description: Discount 1
		/// FieldName: DIP1
		/// FieldType: N
		/// Length: 7
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Discount 1")]
		public int? M3_DIP1 => GetNullableInt("DIP1");

		/// <summary>
		/// Description: Discount 2
		/// FieldName: DIP2
		/// FieldType: N
		/// Length: 7
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Discount 2")]
		public int? M3_DIP2 => GetNullableInt("DIP2");

		/// <summary>
		/// Description: Discount 3
		/// FieldName: DIP3
		/// FieldType: N
		/// Length: 7
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Discount 3")]
		public int? M3_DIP3 => GetNullableInt("DIP3");

		/// <summary>
		/// Description: Discount 4
		/// FieldName: DIP4
		/// FieldType: N
		/// Length: 7
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Discount 4")]
		public int? M3_DIP4 => GetNullableInt("DIP4");

		/// <summary>
		/// Description: Discount 5
		/// FieldName: DIP5
		/// FieldType: N
		/// Length: 7
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Discount 5")]
		public int? M3_DIP5 => GetNullableInt("DIP5");

		/// <summary>
		/// Description: Discount 6
		/// FieldName: DIP6
		/// FieldType: N
		/// Length: 7
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Discount 6")]
		public int? M3_DIP6 => GetNullableInt("DIP6");

		/// <summary>
		/// Description: Additional text
		/// FieldName: DIT1
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Additional text")]
		public string M3_DIT1 => GetString("DIT1");

		/// <summary>
		/// Description: Additional text
		/// FieldName: DIT2
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Additional text")]
		public string M3_DIT2 => GetString("DIT2");

		/// <summary>
		/// Description: Additional text
		/// FieldName: DIT3
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Additional text")]
		public string M3_DIT3 => GetString("DIT3");

		/// <summary>
		/// Description: Additional text
		/// FieldName: DIT4
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Additional text")]
		public string M3_DIT4 => GetString("DIT4");

		/// <summary>
		/// Description: Additional text
		/// FieldName: DIT5
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Additional text")]
		public string M3_DIT5 => GetString("DIT5");

		/// <summary>
		/// Description: Additional text
		/// FieldName: DIT6
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Additional text")]
		public string M3_DIT6 => GetString("DIT6");

		/// <summary>
		/// Description: Net price
		/// FieldName: NEPR
		/// FieldType: N
		/// Length: 18
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Net price")]
		public decimal? M3_NEPR => GetNullableDecimal("NEPR");

		/// <summary>
		/// Description: Gross sales price in basic U/M
		/// FieldName: GPBU
		/// FieldType: N
		/// Length: 18
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Gross sales price in basic U/M")]
		public decimal? M3_GPBU => GetNullableDecimal("GPBU");

		/// <summary>
		/// Description: Net sales price in basic U/M
		/// FieldName: NPBU
		/// FieldType: N
		/// Length: 18
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Net sales price in basic U/M")]
		public decimal? M3_NPBU => GetNullableDecimal("NPBU");

		/// <summary>
		/// Description: Currency code 3
		/// FieldName: CUC3
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Currency code 3")]
		public string M3_CUC3 => GetString("CUC3");

		/// <summary>
		/// Description: Pricelist sequence number
		/// FieldName: PLSN
		/// FieldType: N
		/// Length: 9
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Pricelist sequence number")]
		public int? M3_PLSN => GetNullableInt("PLSN");
	}
}
// EOF
