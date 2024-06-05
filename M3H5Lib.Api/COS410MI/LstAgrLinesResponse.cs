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

namespace M3H5Lib.Api.COS410MI
{
	public partial class LstAgrLinesResponse : M3BaseRecord 
	{

		/// <summary>
		/// Description: Agreement
		/// FieldName: AAGN
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Agreement")]
		public string M3_AAGN => GetString("AAGN");

		/// <summary>
		/// Description: Service price method
		/// FieldName: SRVP
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Service price method")]
		public int? M3_SRVP => GetNullableInt("SRVP");

		/// <summary>
		/// Description: Product
		/// FieldName: PRNO
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Product")]
		public string M3_PRNO => GetString("PRNO");

		/// <summary>
		/// Description: Product structure type
		/// FieldName: STRT
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Product structure type")]
		public string M3_STRT => GetString("STRT");

		/// <summary>
		/// Description: Service
		/// FieldName: SUFI
		/// FieldType: A
		/// Length: 20
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Service")]
		public string M3_SUFI => GetString("SUFI");

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
		/// Description: To date
		/// FieldName: TODT
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("To date")]
		public DateTime? M3_TODT => GetNullableDateTime("TODT");

		/// <summary>
		/// Description: Text
		/// FieldName: PRTX
		/// FieldType: A
		/// Length: 30
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Text")]
		public string M3_PRTX => GetString("PRTX");

		/// <summary>
		/// Description: Lead time - service
		/// FieldName: LEAS
		/// FieldType: N
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Lead time - service")]
		public int? M3_LEAS => GetNullableInt("LEAS");

		/// <summary>
		/// Description: Meter
		/// FieldName: MES0
		/// FieldType: A
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Meter")]
		public string M3_MES0 => GetString("MES0");

		/// <summary>
		/// Description: Warranty limit 1
		/// FieldName: WAL1
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Warranty limit 1")]
		public decimal? M3_WAL1 => GetNullableDecimal("WAL1");

		/// <summary>
		/// Description: Meter 1
		/// FieldName: MES1
		/// FieldType: A
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Meter 1")]
		public string M3_MES1 => GetString("MES1");

		/// <summary>
		/// Description: Warranty limit 2
		/// FieldName: WAL2
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Warranty limit 2")]
		public decimal? M3_WAL2 => GetNullableDecimal("WAL2");

		/// <summary>
		/// Description: Meter 2
		/// FieldName: MES2
		/// FieldType: A
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Meter 2")]
		public string M3_MES2 => GetString("MES2");

		/// <summary>
		/// Description: Warranty limit 3
		/// FieldName: WAL3
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Warranty limit 3")]
		public decimal? M3_WAL3 => GetNullableDecimal("WAL3");

		/// <summary>
		/// Description: Meter 3
		/// FieldName: MES3
		/// FieldType: A
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Meter 3")]
		public string M3_MES3 => GetString("MES3");

		/// <summary>
		/// Description: Warranty limit 4
		/// FieldName: WAL4
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Warranty limit 4")]
		public decimal? M3_WAL4 => GetNullableDecimal("WAL4");

		/// <summary>
		/// Description: Meter 4
		/// FieldName: MES4
		/// FieldType: A
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Meter 4")]
		public string M3_MES4 => GetString("MES4");

		/// <summary>
		/// Description: Index
		/// FieldName: AINX
		/// FieldType: N
		/// Length: 7
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Index")]
		public int? M3_AINX => GetNullableInt("AINX");

		/// <summary>
		/// Description: Maximum material value per item
		/// FieldName: AMVI
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Maximum material value per item")]
		public decimal? M3_AMVI => GetNullableDecimal("AMVI");

		/// <summary>
		/// Description: Maximum material cost
		/// FieldName: AMAM
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Maximum material cost")]
		public decimal? M3_AMAM => GetNullableDecimal("AMAM");

		/// <summary>
		/// Description: Max material price per transaction
		/// FieldName: AMPI
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Max material price per transaction")]
		public decimal? M3_AMPI => GetNullableDecimal("AMPI");

		/// <summary>
		/// Description: Maximum labor cost
		/// FieldName: AMAL
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Maximum labor cost")]
		public decimal? M3_AMAL => GetNullableDecimal("AMAL");

		/// <summary>
		/// Description: Max material price per order
		/// FieldName: AMM1
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Max material price per order")]
		public decimal? M3_AMM1 => GetNullableDecimal("AMM1");

		/// <summary>
		/// Description: Minimum hours per line
		/// FieldName: AMLL
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Minimum hours per line")]
		public decimal? M3_AMLL => GetNullableDecimal("AMLL");

		/// <summary>
		/// Description: Exclude / include material
		/// FieldName: AEXC
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Exclude / include material")]
		public int? M3_AEXC => GetNullableInt("AEXC");

		/// <summary>
		/// Description: Minimum labor hours per job ID
		/// FieldName: AMLJ
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Minimum labor hours per job ID")]
		public decimal? M3_AMLJ => GetNullableDecimal("AMLJ");

		/// <summary>
		/// Description: Minimum hours per order
		/// FieldName: AMLO
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Minimum hours per order")]
		public decimal? M3_AMLO => GetNullableDecimal("AMLO");

		/// <summary>
		/// Description: Minimum material cost/line
		/// FieldName: AMIL
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Minimum material cost/line")]
		public decimal? M3_AMIL => GetNullableDecimal("AMIL");

		/// <summary>
		/// Description: Minimum material cost/order
		/// FieldName: AMIO
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Minimum material cost/order")]
		public decimal? M3_AMIO => GetNullableDecimal("AMIO");

		/// <summary>
		/// Description: Minimum subcontract charge per line
		/// FieldName: AMSL
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Minimum subcontract charge per line")]
		public decimal? M3_AMSL => GetNullableDecimal("AMSL");

		/// <summary>
		/// Description: Minimum subcontract charge per order
		/// FieldName: AMSO
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Minimum subcontract charge per order")]
		public decimal? M3_AMSO => GetNullableDecimal("AMSO");
	}
}
// EOF
