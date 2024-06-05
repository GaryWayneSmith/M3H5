/// **********************************************************************
/// This class is auto-generated.
/// Updated: 6/5/2024 3:52:20 PM
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

namespace M3H5Lib.Api.MDBREADMI
{
	public partial class LstCAABAL00Response : M3BaseRecord 
	{

		/// <summary>
		/// Description: Division
		/// FieldName: DIVI
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Division")]
		public string M3DIVI => GetString("DIVI");

		/// <summary>
		/// Description: Acc model ID
		/// FieldName: MOID
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Acc model ID")]
		public string M3MOID => GetString("MOID");

		/// <summary>
		/// Description: Acc model line
		/// FieldName: MOLN
		/// FieldType: N
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Acc model line")]
		public int? M3MOLN => GetNullableInt("MOLN");

		/// <summary>
		/// Description: Column value 1
		/// FieldName: COV1
		/// FieldType: A
		/// Length: 20
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Column value 1")]
		public string M3COV1 => GetString("COV1");

		/// <summary>
		/// Description: Column value 2
		/// FieldName: COV2
		/// FieldType: A
		/// Length: 20
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Column value 2")]
		public string M3COV2 => GetString("COV2");

		/// <summary>
		/// Description: Column value 3
		/// FieldName: COV3
		/// FieldType: A
		/// Length: 20
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Column value 3")]
		public string M3COV3 => GetString("COV3");

		/// <summary>
		/// Description: Column value 4
		/// FieldName: COV4
		/// FieldType: A
		/// Length: 20
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Column value 4")]
		public string M3COV4 => GetString("COV4");

		/// <summary>
		/// Description: Column value 6
		/// FieldName: COV6
		/// FieldType: A
		/// Length: 20
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Column value 6")]
		public string M3COV6 => GetString("COV6");

		/// <summary>
		/// Description: Column value 7
		/// FieldName: COV7
		/// FieldType: A
		/// Length: 20
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Column value 7")]
		public string M3COV7 => GetString("COV7");

		/// <summary>
		/// Description: Column value 8
		/// FieldName: COV8
		/// FieldType: A
		/// Length: 20
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Column value 8")]
		public string M3COV8 => GetString("COV8");

		/// <summary>
		/// Description: Column value 9
		/// FieldName: COV9
		/// FieldType: A
		/// Length: 20
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Column value 9")]
		public string M3COV9 => GetString("COV9");

		/// <summary>
		/// Description: Column value 10
		/// FieldName: CO10
		/// FieldType: A
		/// Length: 20
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Column value 10")]
		public string M3CO10 => GetString("CO10");

		/// <summary>
		/// Description: Recorded amount
		/// FieldName: ACAM
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Recorded amount")]
		public decimal? M3ACAM => GetNullableDecimal("ACAM");

		/// <summary>
		/// Description: Budg amount
		/// FieldName: BUAM
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Budg amount")]
		public decimal? M3BUAM => GetNullableDecimal("BUAM");

		/// <summary>
		/// Description: Account period
		/// FieldName: ACYP
		/// FieldType: N
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Account period")]
		public int? M3ACYP => GetNullableInt("ACYP");

		/// <summary>
		/// Description: Act amt rep cur
		/// FieldName: CURC
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Act amt rep cur")]
		public decimal? M3CURC => GetNullableDecimal("CURC");

		/// <summary>
		/// Description: Budget amt rep
		/// FieldName: BURC
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Budget amt rep")]
		public decimal? M3BURC => GetNullableDecimal("BURC");

		/// <summary>
		/// Description: Quantity
		/// FieldName: ACQT
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Quantity")]
		public decimal? M3ACQT => GetNullableDecimal("ACQT");

		/// <summary>
		/// Description: Budg qty
		/// FieldName: BUQT
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Budg qty")]
		public decimal? M3BUQT => GetNullableDecimal("BUQT");

		/// <summary>
		/// Description: Next orig ID
		/// FieldName: NHBI
		/// FieldType: N
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Next orig ID")]
		public long? M3NHBI => GetNullableLong("NHBI");
	}
}
// EOF
