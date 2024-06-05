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

namespace M3H5Lib.Api.QMS201MI
{
	public partial class GetSpecTestResponse : M3BaseRecord 
	{

		/// <summary>
		/// Description: Inactive date
		/// FieldName: QTI1
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Inactive date")]
		public DateTime? M3_QTI1 => GetNullableDateTime("QTI1");

		/// <summary>
		/// Description: Inactive time
		/// FieldName: QTI2
		/// FieldType: N
		/// Length: 4
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Inactive time")]
		public int? M3_QTI2 => GetNullableInt("QTI2");

		/// <summary>
		/// Description: Description
		/// FieldName: TX40
		/// FieldType: A
		/// Length: 40
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Description")]
		public string M3_TX40 => GetString("TX40");

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
		/// Description: Numeric qualitative
		/// FieldName: QTCD
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Numeric qualitative")]
		public string M3_QTCD => GetString("QTCD");

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
		/// Description: Attribute identity
		/// FieldName: ATID
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Attribute identity")]
		public string M3_ATID => GetString("ATID");

		/// <summary>
		/// Description: Measurement method
		/// FieldName: MSUR
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Measurement method")]
		public string M3_MSUR => GetString("MSUR");

		/// <summary>
		/// Description: Measurement instrument
		/// FieldName: MSIN
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Measurement instrument")]
		public string M3_MSIN => GetString("MSIN");

		/// <summary>
		/// Description: Department
		/// FieldName: DEPT
		/// FieldType: A
		/// Length: 8
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Department")]
		public string M3_DEPT => GetString("DEPT");

		/// <summary>
		/// Description: Laboratory
		/// FieldName: LABO
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Laboratory")]
		public string M3_LABO => GetString("LABO");

		/// <summary>
		/// Description: Sample type
		/// FieldName: SMTP
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Sample type")]
		public string M3_SMTP => GetString("SMTP");

		/// <summary>
		/// Description: Industry standard
		/// FieldName: INSD
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Industry standard")]
		public string M3_INSD => GetString("INSD");

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
		/// Description: External operator
		/// FieldName: QOP2
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("External operator")]
		public int? M3_QOP2 => GetNullableInt("QOP2");

		/// <summary>
		/// Description: Alarm operator
		/// FieldName: QOP3
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Alarm operator")]
		public int? M3_QOP3 => GetNullableInt("QOP3");

		/// <summary>
		/// Description: Expected value max
		/// FieldName: EVMX
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Expected value max")]
		public decimal? M3_EVMX => GetNullableDecimal("EVMX");

		/// <summary>
		/// Description: Expected value min
		/// FieldName: EVMN
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Expected value min")]
		public decimal? M3_EVMN => GetNullableDecimal("EVMN");

		/// <summary>
		/// Description: External lab min
		/// FieldName: EXMN
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("External lab min")]
		public decimal? M3_EXMN => GetNullableDecimal("EXMN");

		/// <summary>
		/// Description: External lab max
		/// FieldName: EXMX
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("External lab max")]
		public decimal? M3_EXMX => GetNullableDecimal("EXMX");

		/// <summary>
		/// Description: Alarm limit max
		/// FieldName: ALMX
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Alarm limit max")]
		public decimal? M3_ALMX => GetNullableDecimal("ALMX");

		/// <summary>
		/// Description: Alarm limit min
		/// FieldName: ALMN
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Alarm limit min")]
		public decimal? M3_ALMN => GetNullableDecimal("ALMN");

		/// <summary>
		/// Description: Expected target value
		/// FieldName: EVTG
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Expected target value")]
		public decimal? M3_EVTG => GetNullableDecimal("EVTG");

		/// <summary>
		/// Description: External target value
		/// FieldName: TVTG
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("External target value")]
		public decimal? M3_TVTG => GetNullableDecimal("TVTG");

		/// <summary>
		/// Description: Alarm target value
		/// FieldName: AVTG
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Alarm target value")]
		public decimal? M3_AVTG => GetNullableDecimal("AVTG");

		/// <summary>
		/// Description: Test U/M
		/// FieldName: TEUM
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Test U/M")]
		public string M3_TEUM => GetString("TEUM");

		/// <summary>
		/// Description: Number of decimal places
		/// FieldName: DCCD
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Number of decimal places")]
		public int? M3_DCCD => GetNullableInt("DCCD");

		/// <summary>
		/// Description: Required
		/// FieldName: REQD
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Required")]
		public int? M3_REQD => GetNullableInt("REQD");

		/// <summary>
		/// Description: Sampling required
		/// FieldName: SMPR
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Sampling required")]
		public int? M3_SMPR => GetNullableInt("SMPR");

		/// <summary>
		/// Description: Internal test required
		/// FieldName: INTR
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Internal test required")]
		public int? M3_INTR => GetNullableInt("INTR");

		/// <summary>
		/// Description: Frequency per
		/// FieldName: FRPR
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Frequency per")]
		public int? M3_FRPR => GetNullableInt("FRPR");

		/// <summary>
		/// Description: Frequency times
		/// FieldName: FRTI
		/// FieldType: N
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Frequency times")]
		public int? M3_FRTI => GetNullableInt("FRTI");

		/// <summary>
		/// Description: Frequency quantity
		/// FieldName: FRQY
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Frequency quantity")]
		public decimal? M3_FRQY => GetNullableDecimal("FRQY");

		/// <summary>
		/// Description: Frequency U/M
		/// FieldName: FRUM
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Frequency U/M")]
		public string M3_FRUM => GetString("FRUM");

		/// <summary>
		/// Description: Sample U/M
		/// FieldName: SMUM
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Sample U/M")]
		public string M3_SMUM => GetString("SMUM");

		/// <summary>
		/// Description: Sample size
		/// FieldName: SMSZ
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Sample size")]
		public decimal? M3_SMSZ => GetNullableDecimal("SMSZ");

		/// <summary>
		/// Description: Discard sample
		/// FieldName: DSSM
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Discard sample")]
		public int? M3_DSSM => GetNullableInt("DSSM");

		/// <summary>
		/// Description: Retain sample
		/// FieldName: RTSM
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Retain sample")]
		public int? M3_RTSM => GetNullableInt("RTSM");

		/// <summary>
		/// Description: Calculated by formula
		/// FieldName: TCAL
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Calculated by formula")]
		public int? M3_TCAL => GetNullableInt("TCAL");

		/// <summary>
		/// Description: Test classification
		/// FieldName: TCLS
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Test classification")]
		public string M3_TCLS => GetString("TCLS");

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
		/// Description: Value setup
		/// FieldName: VLTP
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Value setup")]
		public int? M3_VLTP => GetNullableInt("VLTP");

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
		/// Description: Include test in QI request
		/// FieldName: ITQR
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Include test in QI request")]
		public int? M3_ITQR => GetNullableInt("ITQR");

		/// <summary>
		/// Description: Print test on Certificate of Analysis
		/// FieldName: PTCA
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Print test on Certificate of Analysis")]
		public int? M3_PTCA => GetNullableInt("PTCA");

		/// <summary>
		/// Description: Print test on specification document
		/// FieldName: PTSP
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Print test on specification document")]
		public int? M3_PTSP => GetNullableInt("PTSP");

		/// <summary>
		/// Description: Sample usage
		/// FieldName: DUSM
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Sample usage")]
		public int? M3_DUSM => GetNullableInt("DUSM");

		/// <summary>
		/// Description: Set
		/// FieldName: QSET
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Set")]
		public string M3_QSET => GetString("QSET");

		/// <summary>
		/// Description: Formula
		/// FieldName: FMID
		/// FieldType: A
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Formula")]
		public string M3_FMID => GetString("FMID");

		/// <summary>
		/// Description: Print spec test values
		/// FieldName: QPTT
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Print spec test values")]
		public int? M3_QPTT => GetNullableInt("QPTT");

		/// <summary>
		/// Description: Print result value
		/// FieldName: QPTR
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Print result value")]
		public int? M3_QPTR => GetNullableInt("QPTR");

		/// <summary>
		/// Description: Copy DO results
		/// FieldName: CDOR
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Copy DO results")]
		public int? M3_CDOR => GetNullableInt("CDOR");
	}
}
// EOF
