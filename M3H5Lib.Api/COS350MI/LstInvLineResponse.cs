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
		public string M3_AIVT => GetString("AIVT");

		/// <summary>
		/// Description: Invoice reference
		/// FieldName: AIVR
		/// FieldType: A
		/// Length: 40
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Invoice reference")]
		public string M3_AIVR => GetString("AIVR");

		/// <summary>
		/// Description: Invoiced amount, local currency
		/// FieldName: AMT1
		/// FieldType: A
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Invoiced amount, local currency")]
		public string M3_AMT1 => GetString("AMT1");

		/// <summary>
		/// Description: Invoiced amount, foreign currency
		/// FieldName: AMT2
		/// FieldType: A
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Invoiced amount, foreign currency")]
		public string M3_AMT2 => GetString("AMT2");

		/// <summary>
		/// Description: Payer
		/// FieldName: PYNO
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Payer")]
		public string M3_PYNO => GetString("PYNO");

		/// <summary>
		/// Description: VAT
		/// FieldName: VTAM
		/// FieldType: A
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("VAT")]
		public string M3_VTAM => GetString("VTAM");

		/// <summary>
		/// Description: Customer Order Number
		/// FieldName: ORNO
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Customer Order Number")]
		public string M3_ORNO => GetString("ORNO");

		/// <summary>
		/// Description: Order Line Number
		/// FieldName: PONR
		/// FieldType: N
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Order Line Number")]
		public int? M3_PONR => GetNullableInt("PONR");

		/// <summary>
		/// Description: Transaction Number
		/// FieldName: ALI1
		/// FieldType: N
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Transaction Number")]
		public int? M3_ALI1 => GetNullableInt("ALI1");

		/// <summary>
		/// Description: VAT code
		/// FieldName: VTCD
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("VAT code")]
		public decimal? M3_VTCD => GetNullableDecimal("VTCD");
	}
}
// EOF
