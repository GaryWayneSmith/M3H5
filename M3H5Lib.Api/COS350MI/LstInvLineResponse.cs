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

namespace M3H5Lib.Api.COS350MI
{
	public partial class LstInvLineResponse : M3BaseRecord 
	{

		/// <summary>
		/// Description: Invoice line type
		/// FieldName: AIVT
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Invoice line type")]
		public string M3AIVT => GetString("AIVT");

		/// <summary>
		/// Description: Invoice reference
		/// FieldName: AIVR
		/// FieldType: A
		/// Length: 40
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Invoice reference")]
		public string M3AIVR => GetString("AIVR");

		/// <summary>
		/// Description: Invoiced amount, local currency
		/// FieldName: AMT1
		/// FieldType: A
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Invoiced amount, local currency")]
		public string M3AMT1 => GetString("AMT1");

		/// <summary>
		/// Description: Invoiced amount, foreign currency
		/// FieldName: AMT2
		/// FieldType: A
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Invoiced amount, foreign currency")]
		public string M3AMT2 => GetString("AMT2");

		/// <summary>
		/// Description: Payer
		/// FieldName: PYNO
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Payer")]
		public string M3PYNO => GetString("PYNO");

		/// <summary>
		/// Description: VAT
		/// FieldName: VTAM
		/// FieldType: A
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("VAT")]
		public string M3VTAM => GetString("VTAM");

		/// <summary>
		/// Description: Customer Order Number
		/// FieldName: ORNO
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Customer Order Number")]
		public string M3ORNO => GetString("ORNO");

		/// <summary>
		/// Description: Order Line Number
		/// FieldName: PONR
		/// FieldType: N
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Order Line Number")]
		public int? M3PONR => GetNullableInt("PONR");

		/// <summary>
		/// Description: Transaction Number
		/// FieldName: ALI1
		/// FieldType: N
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Transaction Number")]
		public int? M3ALI1 => GetNullableInt("ALI1");

		/// <summary>
		/// Description: VAT code
		/// FieldName: VTCD
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("VAT code")]
		public decimal? M3VTCD => GetNullableDecimal("VTCD");
	}
}
// EOF
