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

namespace M3H5Lib.Api.OIS215MI
{
	public partial class LstLinesResponse : M3BaseRecord 
	{

		/// <summary>
		/// Description: Line number
		/// FieldName: PLNB
		/// FieldType: N
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Line number")]
		public int? M3PLNB => GetNullableInt("PLNB");

		/// <summary>
		/// Description: Year
		/// FieldName: YEA4
		/// FieldType: N
		/// Length: 4
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Year")]
		public int? M3YEA4 => GetNullableInt("YEA4");

		/// <summary>
		/// Description: Extended invoice number
		/// FieldName: EXIN
		/// FieldType: A
		/// Length: 14
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Extended invoice number")]
		public string M3EXIN => GetString("EXIN");

		/// <summary>
		/// Description: Customer
		/// FieldName: CUNO
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Customer")]
		public string M3CUNO => GetString("CUNO");

		/// <summary>
		/// Description: Remaining amount to pay - foreign curr
		/// FieldName: RAFC
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Remaining amount to pay - foreign curr")]
		public decimal? M3RAFC => GetNullableDecimal("RAFC");

		/// <summary>
		/// Description: Payment method - accounts receivable
		/// FieldName: PYCD
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Payment method - accounts receivable")]
		public string M3PYCD => GetString("PYCD");

		/// <summary>
		/// Description: Payment amount - foreign currency
		/// FieldName: PMAM
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Payment amount - foreign currency")]
		public decimal? M3PMAM => GetNullableDecimal("PMAM");

		/// <summary>
		/// Description: Due date
		/// FieldName: DUDT
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Due date")]
		public DateTime? M3DUDT => GetNullableDateTime("DUDT");

		/// <summary>
		/// Description: Payment date
		/// FieldName: PYDT
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Payment date")]
		public DateTime? M3PYDT => GetNullableDateTime("PYDT");

		/// <summary>
		/// Description: Message
		/// FieldName: MSGT
		/// FieldType: A
		/// Length: 180
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Message")]
		public string M3MSGT => GetString("MSGT");

		/// <summary>
		/// Description: Transaction type
		/// FieldName: TRT6
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Transaction type")]
		public string M3TRT6 => GetString("TRT6");

		/// <summary>
		/// Description: Bank account identity
		/// FieldName: BKID
		/// FieldType: A
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Bank account identity")]
		public string M3BKID => GetString("BKID");

		/// <summary>
		/// Description: Check number
		/// FieldName: CKNO
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Check number")]
		public string M3CKNO => GetString("CKNO");
	}
}
// EOF
