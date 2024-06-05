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

namespace M3H5Lib.Api.QMS302MI
{
	public partial class GetTestQIReqResponse : M3BaseRecord 
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
		public string M3FACI => GetString("FACI");

		/// <summary>
		/// Description: Request ID
		/// FieldName: QRID
		/// FieldType: A
		/// Length: 8
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Request ID")]
		public string M3QRID => GetString("QRID");

		/// <summary>
		/// Description: Specification
		/// FieldName: SPEC
		/// FieldType: A
		/// Length: 20
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Specification")]
		public string M3SPEC => GetString("SPEC");

		/// <summary>
		/// Description: Effective date
		/// FieldName: QSE1
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Effective date")]
		public DateTime? M3QSE1 => GetNullableDateTime("QSE1");

		/// <summary>
		/// Description: Effective time
		/// FieldName: QSE2
		/// FieldType: N
		/// Length: 4
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Effective time")]
		public int? M3QSE2 => GetNullableInt("QSE2");

		/// <summary>
		/// Description: Test
		/// FieldName: QTST
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Test")]
		public string M3QTST => GetString("QTST");

		/// <summary>
		/// Description: Test type
		/// FieldName: TSTY
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Test type")]
		public int? M3TSTY => GetNullableInt("TSTY");

		/// <summary>
		/// Description: Effective date
		/// FieldName: QTE1
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Effective date")]
		public DateTime? M3QTE1 => GetNullableDateTime("QTE1");

		/// <summary>
		/// Description: Effective time
		/// FieldName: QTE2
		/// FieldType: N
		/// Length: 4
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Effective time")]
		public int? M3QTE2 => GetNullableInt("QTE2");

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
		/// Description: Lot number
		/// FieldName: BANO
		/// FieldType: A
		/// Length: 20
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Lot number")]
		public string M3BANO => GetString("BANO");

		/// <summary>
		/// Description: Inactive date
		/// FieldName: QTI1
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Inactive date")]
		public DateTime? M3QTI1 => GetNullableDateTime("QTI1");

		/// <summary>
		/// Description: Inactive time
		/// FieldName: QTI2
		/// FieldType: N
		/// Length: 4
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Inactive time")]
		public int? M3QTI2 => GetNullableInt("QTI2");

		/// <summary>
		/// Description: Description
		/// FieldName: TX40
		/// FieldType: A
		/// Length: 40
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Description")]
		public string M3TX40 => GetString("TX40");

		/// <summary>
		/// Description: Test order
		/// FieldName: EXSQ
		/// FieldType: N
		/// Length: 4
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Test order")]
		public int? M3EXSQ => GetNullableInt("EXSQ");

		/// <summary>
		/// Description: Test priority
		/// FieldName: QTSP
		/// FieldType: N
		/// Length: 4
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Test priority")]
		public int? M3QTSP => GetNullableInt("QTSP");

		/// <summary>
		/// Description: Numeric qualitative
		/// FieldName: QTCD
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Numeric qualitative")]
		public string M3QTCD => GetString("QTCD");

		/// <summary>
		/// Description: Test result
		/// FieldName: QLCD
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Test result")]
		public string M3QLCD => GetString("QLCD");

		/// <summary>
		/// Description: Attribute identity
		/// FieldName: ATID
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Attribute identity")]
		public string M3ATID => GetString("ATID");

		/// <summary>
		/// Description: Measurement method
		/// FieldName: MSUR
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Measurement method")]
		public string M3MSUR => GetString("MSUR");

		/// <summary>
		/// Description: Measurement instrument
		/// FieldName: MSIN
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Measurement instrument")]
		public string M3MSIN => GetString("MSIN");

		/// <summary>
		/// Description: Department
		/// FieldName: DEPT
		/// FieldType: A
		/// Length: 8
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Department")]
		public string M3DEPT => GetString("DEPT");

		/// <summary>
		/// Description: Laboratory
		/// FieldName: LABO
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Laboratory")]
		public string M3LABO => GetString("LABO");

		/// <summary>
		/// Description: Sample type
		/// FieldName: SMTP
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Sample type")]
		public string M3SMTP => GetString("SMTP");

		/// <summary>
		/// Description: Industry standard
		/// FieldName: INSD
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Industry standard")]
		public string M3INSD => GetString("INSD");

		/// <summary>
		/// Description: Value setup
		/// FieldName: VLTP
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Value setup")]
		public int? M3VLTP => GetNullableInt("VLTP");

		/// <summary>
		/// Description: Specification test status
		/// FieldName: TSTT
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Specification test status")]
		public int? M3TSTT => GetNullableInt("TSTT");

		/// <summary>
		/// Description: Expected operator
		/// FieldName: QOP1
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Expected operator")]
		public int? M3QOP1 => GetNullableInt("QOP1");

		/// <summary>
		/// Description: External operator
		/// FieldName: QOP2
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("External operator")]
		public int? M3QOP2 => GetNullableInt("QOP2");

		/// <summary>
		/// Description: Alarm operator
		/// FieldName: QOP3
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Alarm operator")]
		public int? M3QOP3 => GetNullableInt("QOP3");

		/// <summary>
		/// Description: Expected value max
		/// FieldName: EVMX
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Expected value max")]
		public decimal? M3EVMX => GetNullableDecimal("EVMX");

		/// <summary>
		/// Description: Expected value min
		/// FieldName: EVMN
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Expected value min")]
		public decimal? M3EVMN => GetNullableDecimal("EVMN");

		/// <summary>
		/// Description: External lab max
		/// FieldName: EXMX
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("External lab max")]
		public decimal? M3EXMX => GetNullableDecimal("EXMX");

		/// <summary>
		/// Description: External lab min
		/// FieldName: EXMN
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("External lab min")]
		public decimal? M3EXMN => GetNullableDecimal("EXMN");

		/// <summary>
		/// Description: Alarm limit max
		/// FieldName: ALMX
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Alarm limit max")]
		public decimal? M3ALMX => GetNullableDecimal("ALMX");

		/// <summary>
		/// Description: Alarm limit min
		/// FieldName: ALMN
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Alarm limit min")]
		public decimal? M3ALMN => GetNullableDecimal("ALMN");

		/// <summary>
		/// Description: Expected target value
		/// FieldName: EVTG
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Expected target value")]
		public decimal? M3EVTG => GetNullableDecimal("EVTG");

		/// <summary>
		/// Description: External target value
		/// FieldName: TVTG
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("External target value")]
		public decimal? M3TVTG => GetNullableDecimal("TVTG");

		/// <summary>
		/// Description: Alarm target value
		/// FieldName: AVTG
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Alarm target value")]
		public decimal? M3AVTG => GetNullableDecimal("AVTG");

		/// <summary>
		/// Description: Test U/M
		/// FieldName: TEUM
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Test U/M")]
		public string M3TEUM => GetString("TEUM");

		/// <summary>
		/// Description: Number of decimal places
		/// FieldName: DCCD
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Number of decimal places")]
		public int? M3DCCD => GetNullableInt("DCCD");

		/// <summary>
		/// Description: Required
		/// FieldName: REQD
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Required")]
		public int? M3REQD => GetNullableInt("REQD");

		/// <summary>
		/// Description: Sampling required
		/// FieldName: SMPR
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Sampling required")]
		public int? M3SMPR => GetNullableInt("SMPR");

		/// <summary>
		/// Description: Internal test required
		/// FieldName: INTR
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Internal test required")]
		public int? M3INTR => GetNullableInt("INTR");

		/// <summary>
		/// Description: Frequency per
		/// FieldName: FRPR
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Frequency per")]
		public int? M3FRPR => GetNullableInt("FRPR");

		/// <summary>
		/// Description: Frequency times
		/// FieldName: FRTI
		/// FieldType: N
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Frequency times")]
		public int? M3FRTI => GetNullableInt("FRTI");

		/// <summary>
		/// Description: Frequency quantity
		/// FieldName: FRQY
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Frequency quantity")]
		public decimal? M3FRQY => GetNullableDecimal("FRQY");

		/// <summary>
		/// Description: Frequency U/M
		/// FieldName: FRUM
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Frequency U/M")]
		public string M3FRUM => GetString("FRUM");

		/// <summary>
		/// Description: Sample size
		/// FieldName: SMSZ
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Sample size")]
		public decimal? M3SMSZ => GetNullableDecimal("SMSZ");

		/// <summary>
		/// Description: Sample U/M
		/// FieldName: SMUM
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Sample U/M")]
		public string M3SMUM => GetString("SMUM");

		/// <summary>
		/// Description: Discard sample
		/// FieldName: DSSM
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Discard sample")]
		public int? M3DSSM => GetNullableInt("DSSM");

		/// <summary>
		/// Description: Retain sample
		/// FieldName: RTSM
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Retain sample")]
		public int? M3RTSM => GetNullableInt("RTSM");

		/// <summary>
		/// Description: Calculated by formula
		/// FieldName: TCAL
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Calculated by formula")]
		public int? M3TCAL => GetNullableInt("TCAL");

		/// <summary>
		/// Description: Test classification
		/// FieldName: TCLS
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Test classification")]
		public string M3TCLS => GetString("TCLS");

		/// <summary>
		/// Description: Overrided date
		/// FieldName: OVDT
		/// FieldType: D
		/// Length: 8
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Overrided date")]
		public DateTime? M3OVDT => GetNullableDateTime("OVDT");

		/// <summary>
		/// Description: Overrided time
		/// FieldName: OVTE
		/// FieldType: N
		/// Length: 4
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Overrided time")]
		public int? M3OVTE => GetNullableInt("OVTE");

		/// <summary>
		/// Description: Overrided by
		/// FieldName: OVUS
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Overrided by")]
		public string M3OVUS => GetString("OVUS");

		/// <summary>
		/// Description: Prior status
		/// FieldName: PVST
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Prior status")]
		public int? M3PVST => GetNullableInt("PVST");

		/// <summary>
		/// Description: Reason
		/// FieldName: QRSN
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Reason")]
		public string M3QRSN => GetString("QRSN");

		/// <summary>
		/// Description: Defective quantity
		/// FieldName: DQTY
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Defective quantity")]
		public decimal? M3DQTY => GetNullableDecimal("DQTY");

		/// <summary>
		/// Description: Text identity
		/// FieldName: TXID
		/// FieldType: N
		/// Length: 13
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Text identity")]
		public decimal? M3TXID => GetNullableDecimal("TXID");

		/// <summary>
		/// Description: Test result
		/// FieldName: QLC2
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Test result")]
		public string M3QLC2 => GetString("QLC2");

		/// <summary>
		/// Description: Test result value
		/// FieldName: QTRS
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Test result value")]
		public decimal? M3QTRS => GetNullableDecimal("QTRS");

		/// <summary>
		/// Description: Test result operator
		/// FieldName: QOPT
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Test result operator")]
		public int? M3QOPT => GetNullableInt("QOPT");

		/// <summary>
		/// Description: Formula ID
		/// FieldName: FMID
		/// FieldType: A
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Formula ID")]
		public string M3FMID => GetString("FMID");

		/// <summary>
		/// Description: Print test on Certificate of Analysis
		/// FieldName: PTCA
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Print test on Certificate of Analysis")]
		public int? M3PTCA => GetNullableInt("PTCA");

		/// <summary>
		/// Description: Print spec test values
		/// FieldName: QPTT
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Print spec test values")]
		public int? M3QPTT => GetNullableInt("QPTT");

		/// <summary>
		/// Description: Print result value
		/// FieldName: QPTR
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Print result value")]
		public int? M3QPTR => GetNullableInt("QPTR");

		/// <summary>
		/// Description: Copy DO results
		/// FieldName: CDOR
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Copy DO results")]
		public int? M3CDOR => GetNullableInt("CDOR");
	}
}
// EOF
