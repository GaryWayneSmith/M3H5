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

namespace M3H5Lib.Api.MMS200MI
{
	public partial class GetItmPriceResponse : M3BaseRecord 
	{

		/// <summary>
		/// Description: Purchase price U/M
		/// FieldName: PPUN
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Purchase price U/M")]
		public string M3_PPUN => GetString("PPUN");

		/// <summary>
		/// Description: Description - Purchase price U/M
		/// FieldName: DS01
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Description - Purchase price U/M")]
		public string M3_DS01 => GetString("DS01");

		/// <summary>
		/// Description: Consumption code - trade stat (TST)
		/// FieldName: ECCC
		/// FieldType: A
		/// Length: 4
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Consumption code - trade stat (TST)")]
		public string M3_ECCC => GetString("ECCC");

		/// <summary>
		/// Description: Costing model - purchasing
		/// FieldName: WSCA
		/// FieldType: A
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Costing model - purchasing")]
		public string M3_WSCA => GetString("WSCA");

		/// <summary>
		/// Description: Procurement group
		/// FieldName: PRGP
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Procurement group")]
		public string M3_PRGP => GetString("PRGP");

		/// <summary>
		/// Description: User-defined accounting control object
		/// FieldName: ACRF
		/// FieldType: A
		/// Length: 8
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("User-defined accounting control object")]
		public string M3_ACRF => GetString("ACRF");

		/// <summary>
		/// Description: Costing model - product costing
		/// FieldName: PRCM
		/// FieldType: A
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Costing model - product costing")]
		public string M3_PRCM => GetString("PRCM");

		/// <summary>
		/// Description: Supplier number
		/// FieldName: SUNO
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Supplier number")]
		public string M3_SUNO => GetString("SUNO");

		/// <summary>
		/// Description: Supplier name
		/// FieldName: SUNM
		/// FieldType: A
		/// Length: 36
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Supplier name")]
		public string M3_SUNM => GetString("SUNM");

		/// <summary>
		/// Description: Purchase price
		/// FieldName: PUPR
		/// FieldType: N
		/// Length: 19
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Purchase price")]
		public decimal? M3_PUPR => GetNullableDecimal("PUPR");

		/// <summary>
		/// Description: Purchase price quantity
		/// FieldName: PUCD
		/// FieldType: N
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Purchase price quantity")]
		public int? M3_PUCD => GetNullableInt("PUCD");

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
		/// Description: Description - Currency
		/// FieldName: DS02
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Description - Currency")]
		public string M3_DS02 => GetString("DS02");

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
		/// Description: Currency - sales price
		/// FieldName: CUCS
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Currency - sales price")]
		public string M3_CUCS => GetString("CUCS");

		/// <summary>
		/// Description: Description - Currency - sales price
		/// FieldName: DS03
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Description - Currency - sales price")]
		public string M3_DS03 => GetString("DS03");

		/// <summary>
		/// Description: Discount group - item
		/// FieldName: DIGI
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Discount group - item")]
		public string M3_DIGI => GetString("DIGI");

		/// <summary>
		/// Description: Description - Discount group - item
		/// FieldName: DS04
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Description - Discount group - item")]
		public string M3_DS04 => GetString("DS04");

		/// <summary>
		/// Description: Bonus group
		/// FieldName: BGRP
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Bonus group")]
		public string M3_BGRP => GetString("BGRP");

		/// <summary>
		/// Description: Description - Bonus group
		/// FieldName: DS05
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Description - Bonus group")]
		public string M3_DS05 => GetString("DS05");

		/// <summary>
		/// Description: Commission group
		/// FieldName: PRVG
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Commission group")]
		public string M3_PRVG => GetString("PRVG");

		/// <summary>
		/// Description: Description - Commission group
		/// FieldName: DS06
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Description - Commission group")]
		public string M3_DS06 => GetString("DS06");

		/// <summary>
		/// Description: Statistics identity 3 item
		/// FieldName: FRE3
		/// FieldType: A
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Statistics identity 3 item")]
		public string M3_FRE3 => GetString("FRE3");

		/// <summary>
		/// Description: Statistics identity 4 item
		/// FieldName: FRE4
		/// FieldType: A
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Statistics identity 4 item")]
		public string M3_FRE4 => GetString("FRE4");

		/// <summary>
		/// Description: Order total discount generating
		/// FieldName: OTDI
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Order total discount generating")]
		public int? M3_OTDI => GetNullableInt("OTDI");

		/// <summary>
		/// Description: Bonus generating
		/// FieldName: BOGR
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Bonus generating")]
		public int? M3_BOGR => GetNullableInt("BOGR");

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
		/// Description: Description - Sales price U/M
		/// FieldName: DS07
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Description - Sales price U/M")]
		public string M3_DS07 => GetString("DS07");

		/// <summary>
		/// Description: Fixed or dynamic sales price U/M
		/// FieldName: SPUC
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Fixed or dynamic sales price U/M")]
		public int? M3_SPUC => GetNullableInt("SPUC");

		/// <summary>
		/// Description: VAT code - purchase
		/// FieldName: VTCP
		/// FieldType: N
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("VAT code - purchase")]
		public int? M3_VTCP => GetNullableInt("VTCP");

		/// <summary>
		/// Description: VAT code - sales
		/// FieldName: VTCS
		/// FieldType: N
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("VAT code - sales")]
		public int? M3_VTCS => GetNullableInt("VTCS");

		/// <summary>
		/// Description: Sales price - basic U/M
		/// FieldName: SAPB
		/// FieldType: N
		/// Length: 19
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Sales price - basic U/M")]
		public decimal? M3_SAPB => GetNullableDecimal("SAPB");

		/// <summary>
		/// Description: Change date
		/// FieldName: LMDT
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Change date")]
		public DateTime? M3_LMDT => GetNullableDateTime("LMDT");

		/// <summary>
		/// Description: Number of price decimal places
		/// FieldName: PDCC
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Number of price decimal places")]
		public int? M3_PDCC => GetNullableInt("PDCC");

		/// <summary>
		/// Description: Purchase Price date
		/// FieldName: PPDT
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Purchase Price date")]
		public DateTime? M3_PPDT => GetNullableDateTime("PPDT");

		/// <summary>
		/// Description: Sales price date
		/// FieldName: SPDT
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Sales price date")]
		public DateTime? M3_SPDT => GetNullableDateTime("SPDT");
	}
}
// EOF
