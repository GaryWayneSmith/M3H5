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

namespace M3H5Lib.Api.GLS215MI
{
	public partial class GetBitFromPtidResponse : M3BaseRecord 
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
		/// Description: Balance key
		/// FieldName: BAKY
		/// FieldType: N
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Balance key")]
		public int? M3BAKY => GetNullableInt("BAKY");

		/// <summary>
		/// Description: Balance dimension 1
		/// FieldName: BIT1
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Balance dimension 1")]
		public string M3BIT1 => GetString("BIT1");

		/// <summary>
		/// Description: Balance dimension 2
		/// FieldName: BIT2
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Balance dimension 2")]
		public string M3BIT2 => GetString("BIT2");

		/// <summary>
		/// Description: Balance dimension 3
		/// FieldName: BIT3
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Balance dimension 3")]
		public string M3BIT3 => GetString("BIT3");

		/// <summary>
		/// Description: Balance dimension 4
		/// FieldName: BIT4
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Balance dimension 4")]
		public string M3BIT4 => GetString("BIT4");

		/// <summary>
		/// Description: Balance dimension 5
		/// FieldName: BIT5
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Balance dimension 5")]
		public string M3BIT5 => GetString("BIT5");

		/// <summary>
		/// Description: Balance dimension 6
		/// FieldName: BIT6
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Balance dimension 6")]
		public string M3BIT6 => GetString("BIT6");

		/// <summary>
		/// Description: Balance dimension 7
		/// FieldName: BIT7
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Balance dimension 7")]
		public string M3BIT7 => GetString("BIT7");

		/// <summary>
		/// Description: Pointer ID
		/// FieldName: PTID
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Pointer ID")]
		public decimal? M3PTID => GetNullableDecimal("PTID");
	}
}
// EOF
