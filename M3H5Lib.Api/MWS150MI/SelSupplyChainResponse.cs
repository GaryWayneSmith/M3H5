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

namespace M3H5Lib.Api.MWS150MI
{
	public partial class SelSupplyChainResponse : M3BaseRecord 
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
		/// Description: Supply chain level
		/// FieldName: SCLE
		/// FieldType: N
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Supply chain level")]
		public int? M3_SCLE => GetNullableInt("SCLE");

		/// <summary>
		/// Description: Order category
		/// FieldName: ORCA
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Order category")]
		public string M3_ORCA => GetString("ORCA");

		/// <summary>
		/// Description: Order number
		/// FieldName: RIDN
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Order number")]
		public string M3_RIDN => GetString("RIDN");

		/// <summary>
		/// Description: Line number
		/// FieldName: PONR
		/// FieldType: N
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Line number")]
		public int? M3_PONR => GetNullableInt("PONR");

		/// <summary>
		/// Description: Line specification
		/// FieldName: RIDS
		/// FieldType: N
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Line specification")]
		public int? M3_RIDS => GetNullableInt("RIDS");

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
		/// Description: Pre-allocated quantity
		/// FieldName: PQTY
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Pre-allocated quantity")]
		public decimal? M3_PQTY => GetNullableDecimal("PQTY");

		/// <summary>
		/// Description: Recieved pre-allocated quantity
		/// FieldName: PQTR
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Recieved pre-allocated quantity")]
		public decimal? M3_PQTR => GetNullableDecimal("PQTR");

		/// <summary>
		/// Description: Pre-allocation type
		/// FieldName: PATY
		/// FieldType: A
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Pre-allocation type")]
		public string M3_PATY => GetString("PATY");

		/// <summary>
		/// Description: Color
		/// FieldName: FLAG
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Color")]
		public int? M3_FLAG => GetNullableInt("FLAG");

		/// <summary>
		/// Description: Planning date
		/// FieldName: PLDT
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Planning date")]
		public DateTime? M3_PLDT => GetNullableDateTime("PLDT");

		/// <summary>
		/// Description: Planning time
		/// FieldName: PLHM
		/// FieldType: N
		/// Length: 4
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Planning time")]
		public int? M3_PLHM => GetNullableInt("PLHM");

		/// <summary>
		/// Description: Compare date
		/// FieldName: CPDT
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Compare date")]
		public DateTime? M3_CPDT => GetNullableDateTime("CPDT");

		/// <summary>
		/// Description: Compare time
		/// FieldName: CPHM
		/// FieldType: N
		/// Length: 4
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Compare time")]
		public int? M3_CPHM => GetNullableInt("CPHM");

		/// <summary>
		/// Description: Supply chain number
		/// FieldName: SCNB
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Supply chain number")]
		public string M3_SCNB => GetString("SCNB");

		/// <summary>
		/// Description: Attribute number
		/// FieldName: ATNR
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Attribute number")]
		public decimal? M3_ATNR => GetNullableDecimal("ATNR");

		/// <summary>
		/// Description: Main Attribute 1
		/// FieldName: ATI1
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Main Attribute 1")]
		public string M3_ATI1 => GetString("ATI1");

		/// <summary>
		/// Description: Main value 1
		/// FieldName: AAT1
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Main value 1")]
		public string M3_AAT1 => GetString("AAT1");

		/// <summary>
		/// Description: Main Attribute 2
		/// FieldName: ATI2
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Main Attribute 2")]
		public string M3_ATI2 => GetString("ATI2");

		/// <summary>
		/// Description: Main value 2
		/// FieldName: AAT2
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Main value 2")]
		public string M3_AAT2 => GetString("AAT2");

		/// <summary>
		/// Description: Main Attribute 3
		/// FieldName: ATI3
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Main Attribute 3")]
		public string M3_ATI3 => GetString("ATI3");

		/// <summary>
		/// Description: Main Value 3
		/// FieldName: AAT3
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Main Value 3")]
		public string M3_AAT3 => GetString("AAT3");

		/// <summary>
		/// Description: Main Attribute 4
		/// FieldName: ATI4
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Main Attribute 4")]
		public string M3_ATI4 => GetString("ATI4");

		/// <summary>
		/// Description: Main Value 4
		/// FieldName: AAT4
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Main Value 4")]
		public string M3_AAT4 => GetString("AAT4");

		/// <summary>
		/// Description: Main Attribute 5
		/// FieldName: ATI5
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Main Attribute 5")]
		public string M3_ATI5 => GetString("ATI5");

		/// <summary>
		/// Description: Main value 5
		/// FieldName: AAT5
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Main value 5")]
		public string M3_AAT5 => GetString("AAT5");

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
	}
}
// EOF
