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

namespace M3H5Lib.Api.COS100MI
{
	public partial class LstMCOLinesResponse : M3BaseRecord 
	{

		/// <summary>
		/// Description: Order line number
		/// FieldName: PONR
		/// FieldType: N
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Order line number")]
		public int? M3PONR => GetNullableInt("PONR");

		/// <summary>
		/// Description: Service
		/// FieldName: SUFI
		/// FieldType: A
		/// Length: 20
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Service")]
		public string M3SUFI => GetString("SUFI");

		/// <summary>
		/// Description: Planned delivery date
		/// FieldName: APD1
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Planned delivery date")]
		public DateTime? M3APD1 => GetNullableDateTime("APD1");

		/// <summary>
		/// Description: Planned delivery time
		/// FieldName: APTA
		/// FieldType: N
		/// Length: 4
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Planned delivery time")]
		public int? M3APTA => GetNullableInt("APTA");

		/// <summary>
		/// Description: Planned receipt date
		/// FieldName: AAP1
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Planned receipt date")]
		public DateTime? M3AAP1 => GetNullableDateTime("AAP1");

		/// <summary>
		/// Description: Planned receipt time
		/// FieldName: APTI
		/// FieldType: N
		/// Length: 4
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Planned receipt time")]
		public int? M3APTI => GetNullableInt("APTI");

		/// <summary>
		/// Description: Actual delivery date
		/// FieldName: AACD
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Actual delivery date")]
		public DateTime? M3AACD => GetNullableDateTime("AACD");

		/// <summary>
		/// Description: Actual delivery time
		/// FieldName: ADTM
		/// FieldType: N
		/// Length: 4
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Actual delivery time")]
		public int? M3ADTM => GetNullableInt("ADTM");

		/// <summary>
		/// Description: Actual receipt date
		/// FieldName: AADT
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Actual receipt date")]
		public DateTime? M3AADT => GetNullableDateTime("AADT");

		/// <summary>
		/// Description: Actual receipt time
		/// FieldName: AAT1
		/// FieldType: N
		/// Length: 4
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Actual receipt time")]
		public int? M3AAT1 => GetNullableInt("AAT1");

		/// <summary>
		/// Description: Actual start date
		/// FieldName: RSDT
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Actual start date")]
		public DateTime? M3RSDT => GetNullableDateTime("RSDT");

		/// <summary>
		/// Description: Actual start time
		/// FieldName: RSTI
		/// FieldType: N
		/// Length: 4
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Actual start time")]
		public int? M3RSTI => GetNullableInt("RSTI");

		/// <summary>
		/// Description: Supplier
		/// FieldName: SUNO
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Supplier")]
		public string M3SUNO => GetString("SUNO");

		/// <summary>
		/// Description: Transaction number
		/// FieldName: ALI1
		/// FieldType: N
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Transaction number")]
		public int? M3ALI1 => GetNullableInt("ALI1");

		/// <summary>
		/// Description: Invoice date
		/// FieldName: IVDT
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Invoice date")]
		public DateTime? M3IVDT => GetNullableDateTime("IVDT");

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
		/// Description: Name
		/// FieldName: ITDS
		/// FieldType: A
		/// Length: 30
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Name")]
		public string M3ITDS => GetString("ITDS");

		/// <summary>
		/// Description: Payer
		/// FieldName: PYNO
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Payer")]
		public string M3PYNO => GetString("PYNO");

		/// <summary>
		/// Description: Transaction quantity - basic U/M
		/// FieldName: TRQT
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Transaction quantity - basic U/M")]
		public decimal? M3TRQT => GetNullableDecimal("TRQT");

		/// <summary>
		/// Description: WIP debit
		/// FieldName: AWCO
		/// FieldType: N
		/// Length: 19
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("WIP debit")]
		public decimal? M3AWCO => GetNullableDecimal("AWCO");

		/// <summary>
		/// Description: Sales price
		/// FieldName: ASP1
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Sales price")]
		public decimal? M3ASP1 => GetNullableDecimal("ASP1");

		/// <summary>
		/// Description: Original quantity
		/// FieldName: AOQT
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Original quantity")]
		public decimal? M3AOQT => GetNullableDecimal("AOQT");

		/// <summary>
		/// Description: Miscellaneous cost types
		/// FieldName: AMTY
		/// FieldType: A
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Miscellaneous cost types")]
		public string M3AMTY => GetString("AMTY");

		/// <summary>
		/// Description: Error code 1
		/// FieldName: FCLA
		/// FieldType: A
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Error code 1")]
		public string M3FCLA => GetString("FCLA");

		/// <summary>
		/// Description: Unit of measure
		/// FieldName: UNIT
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Unit of measure")]
		public string M3UNIT => GetString("UNIT");
	}
}
// EOF
