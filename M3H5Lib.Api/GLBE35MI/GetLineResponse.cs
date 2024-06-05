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

namespace M3H5Lib.Api.GLBE35MI
{
	public partial class GetLineResponse : M3BaseRecord 
	{

		/// <summary>
		/// Description: Job Number
		/// FieldName: BJNO
		/// FieldType: A
		/// Length: 18
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Job Number")]
		public string M3BJNO => GetString("BJNO");

		/// <summary>
		/// Description: Accounting Dimension 1
		/// FieldName: AIT1
		/// FieldType: A
		/// Length: 8
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Accounting Dimension 1")]
		public string M3AIT1 => GetString("AIT1");

		/// <summary>
		/// Description: Recorded Amount
		/// FieldName: DBAM
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Recorded Amount")]
		public decimal? M3DBAM => GetNullableDecimal("DBAM");

		/// <summary>
		/// Description: Recorded Amount
		/// FieldName: CRAM
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Recorded Amount")]
		public decimal? M3CRAM => GetNullableDecimal("CRAM");

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
	}
}
// EOF
