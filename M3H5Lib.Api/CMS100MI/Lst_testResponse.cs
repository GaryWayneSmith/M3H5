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

namespace M3H5Lib.Api.CMS100MI
{
	public partial class Lst_testResponse : M3BaseRecord 
	{

		/// <summary>
		/// Description: Division
		/// FieldName: EGDIVI
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Division")]
		public string M3_EGDIVI => GetString("EGDIVI");

		/// <summary>
		/// Description: Year
		/// FieldName: EGYEA4
		/// FieldType: N
		/// Length: 4
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Year")]
		public int? M3_EGYEA4 => GetNullableInt("EGYEA4");

		/// <summary>
		/// Description: Accounting date
		/// FieldName: EGACDT
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Accounting date")]
		public DateTime? M3_EGACDT => GetNullableDateTime("EGACDT");

		/// <summary>
		/// Description: Journal no
		/// FieldName: EGJRNO
		/// FieldType: N
		/// Length: 7
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Journal no")]
		public int? M3_EGJRNO => GetNullableInt("EGJRNO");

		/// <summary>
		/// Description: Journal seq no
		/// FieldName: EGJSNO
		/// FieldType: N
		/// Length: 7
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Journal seq no")]
		public int? M3_EGJSNO => GetNullableInt("EGJSNO");

		/// <summary>
		/// Description: Voucher no
		/// FieldName: EGVONO
		/// FieldType: N
		/// Length: 8
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Voucher no")]
		public int? M3_EGVONO => GetNullableInt("EGVONO");

		/// <summary>
		/// Description: Account dim 1
		/// FieldName: EGAIT1
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Account dim 1")]
		public string M3_EGAIT1 => GetString("EGAIT1");

		/// <summary>
		/// Description: Account dim 2
		/// FieldName: EGAIT2
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Account dim 2")]
		public string M3_EGAIT2 => GetString("EGAIT2");

		/// <summary>
		/// Description: Account dim 3
		/// FieldName: EGAIT3
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Account dim 3")]
		public string M3_EGAIT3 => GetString("EGAIT3");

		/// <summary>
		/// Description: Account dim 4
		/// FieldName: EGAIT4
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Account dim 4")]
		public string M3_EGAIT4 => GetString("EGAIT4");

		/// <summary>
		/// Description: Account dim 5
		/// FieldName: EGAIT5
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Account dim 5")]
		public string M3_EGAIT5 => GetString("EGAIT5");

		/// <summary>
		/// Description: Account dim 6
		/// FieldName: EGAIT6
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Account dim 6")]
		public string M3_EGAIT6 => GetString("EGAIT6");

		/// <summary>
		/// Description: Account dim 7
		/// FieldName: EGAIT7
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Account dim 7")]
		public string M3_EGAIT7 => GetString("EGAIT7");

		/// <summary>
		/// Description: Recorded amount
		/// FieldName: EGACAM
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Recorded amount")]
		public decimal? M3_EGACAM => GetNullableDecimal("EGACAM");

		/// <summary>
		/// Description: Voucher text
		/// FieldName: EGVTXT
		/// FieldType: A
		/// Length: 40
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Voucher text")]
		public string M3_EGVTXT => GetString("EGVTXT");
	}
}
// EOF
