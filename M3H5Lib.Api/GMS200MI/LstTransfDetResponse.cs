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

namespace M3H5Lib.Api.GMS200MI
{
	public partial class LstTransfDetResponse : M3BaseRecord 
	{

		/// <summary>
		/// Description: Accounting dimension 1
		/// FieldName: AIT1
		/// FieldType: A
		/// Length: 8
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Accounting dimension 1")]
		public string M3_AIT1 => GetString("AIT1");

		/// <summary>
		/// Description: Accounting dimension 2
		/// FieldName: AIT2
		/// FieldType: A
		/// Length: 8
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Accounting dimension 2")]
		public string M3_AIT2 => GetString("AIT2");

		/// <summary>
		/// Description: Accounting dimension 3
		/// FieldName: AIT3
		/// FieldType: A
		/// Length: 8
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Accounting dimension 3")]
		public string M3_AIT3 => GetString("AIT3");

		/// <summary>
		/// Description: Accounting dimension 4
		/// FieldName: AIT4
		/// FieldType: A
		/// Length: 8
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Accounting dimension 4")]
		public string M3_AIT4 => GetString("AIT4");

		/// <summary>
		/// Description: Accounting dimension 5
		/// FieldName: AIT5
		/// FieldType: A
		/// Length: 8
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Accounting dimension 5")]
		public string M3_AIT5 => GetString("AIT5");

		/// <summary>
		/// Description: Accounting dimension 6
		/// FieldName: AIT6
		/// FieldType: A
		/// Length: 8
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Accounting dimension 6")]
		public string M3_AIT6 => GetString("AIT6");

		/// <summary>
		/// Description: Accounting dimension 7
		/// FieldName: AIT7
		/// FieldType: A
		/// Length: 8
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Accounting dimension 7")]
		public string M3_AIT7 => GetString("AIT7");

		/// <summary>
		/// Description: Recorded amount
		/// FieldName: ACAM
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Recorded amount")]
		public decimal? M3_ACAM => GetNullableDecimal("ACAM");

		/// <summary>
		/// Description: Foreign currency amount
		/// FieldName: CUAM
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Foreign currency amount")]
		public decimal? M3_CUAM => GetNullableDecimal("CUAM");

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
		/// Description: Accounted quantity
		/// FieldName: ACQT
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Accounted quantity")]
		public decimal? M3_ACQT => GetNullableDecimal("ACQT");

		/// <summary>
		/// Description: Mapping field 1
		/// FieldName: MAF1
		/// FieldType: A
		/// Length: 35
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Mapping field 1")]
		public string M3_MAF1 => GetString("MAF1");

		/// <summary>
		/// Description: Mapping field 2
		/// FieldName: MAF2
		/// FieldType: A
		/// Length: 25
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Mapping field 2")]
		public string M3_MAF2 => GetString("MAF2");

		/// <summary>
		/// Description: Subsidiary
		/// FieldName: GCID
		/// FieldType: A
		/// Length: 8
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Subsidiary")]
		public string M3_GCID => GetString("GCID");
	}
}
// EOF