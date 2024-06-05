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

namespace M3H5Lib.Api.QMS400MI
{
	public partial class LstTestResultsResponse : M3BaseRecord 
	{

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
		/// Description: Request ID
		/// FieldName: QRID
		/// FieldType: A
		/// Length: 8
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Request ID")]
		public string M3_QRID => GetString("QRID");

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
		/// Description: Lot number
		/// FieldName: BANO
		/// FieldType: A
		/// Length: 20
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Lot number")]
		public string M3_BANO => GetString("BANO");

		/// <summary>
		/// Description: Test
		/// FieldName: QTST
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Test")]
		public string M3_QTST => GetString("QTST");

		/// <summary>
		/// Description: Test type
		/// FieldName: TSTY
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Test type")]
		public int? M3_TSTY => GetNullableInt("TSTY");

		/// <summary>
		/// Description: Sequence number
		/// FieldName: TSEQ
		/// FieldType: N
		/// Length: 4
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Sequence number")]
		public int? M3_TSEQ => GetNullableInt("TSEQ");

		/// <summary>
		/// Description: Test order
		/// FieldName: EXSQ
		/// FieldType: N
		/// Length: 4
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Test order")]
		public int? M3_EXSQ => GetNullableInt("EXSQ");

		/// <summary>
		/// Description: Test priority
		/// FieldName: QTSP
		/// FieldType: N
		/// Length: 4
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Test priority")]
		public int? M3_QTSP => GetNullableInt("QTSP");

		/// <summary>
		/// Description: Expected operator
		/// FieldName: QOP1
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Expected operator")]
		public int? M3_QOP1 => GetNullableInt("QOP1");

		/// <summary>
		/// Description: Test result
		/// FieldName: QTRS
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Test result")]
		public decimal? M3_QTRS => GetNullableDecimal("QTRS");

		/// <summary>
		/// Description: Test result
		/// FieldName: QLCD
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Test result")]
		public string M3_QLCD => GetString("QLCD");

		/// <summary>
		/// Description: Tested by
		/// FieldName: TTUS
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Tested by")]
		public string M3_TTUS => GetString("TTUS");

		/// <summary>
		/// Description: Tested date
		/// FieldName: TTDT
		/// FieldType: D
		/// Length: 8
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Tested date")]
		public DateTime? M3_TTDT => GetNullableDateTime("TTDT");

		/// <summary>
		/// Description: Tested time
		/// FieldName: TTTE
		/// FieldType: N
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Tested time")]
		public int? M3_TTTE => GetNullableInt("TTTE");

		/// <summary>
		/// Description: Prior test result
		/// FieldName: PRVL
		/// FieldType: A
		/// Length: 20
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Prior test result")]
		public string M3_PRVL => GetString("PRVL");

		/// <summary>
		/// Description: Reason
		/// FieldName: QRSN
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Reason")]
		public string M3_QRSN => GetString("QRSN");

		/// <summary>
		/// Description: Value entered
		/// FieldName: VLEN
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Value entered")]
		public int? M3_VLEN => GetNullableInt("VLEN");

		/// <summary>
		/// Description: Text identity
		/// FieldName: TXID
		/// FieldType: N
		/// Length: 13
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Text identity")]
		public decimal? M3_TXID => GetNullableDecimal("TXID");

		/// <summary>
		/// Description: Comments
		/// FieldName: SI01
		/// FieldType: A
		/// Length: 50
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Comments")]
		public string M3_SI01 => GetString("SI01");
	}
}
// EOF
