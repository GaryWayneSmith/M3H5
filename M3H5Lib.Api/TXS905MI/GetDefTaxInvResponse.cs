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

namespace M3H5Lib.Api.TXS905MI
{
	public partial class GetDefTaxInvResponse : M3BaseRecord 
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
		public string M3_DIVI => GetString("DIVI");

		/// <summary>
		/// Description: Base country
		/// FieldName: BSCD
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Base country")]
		public string M3_BSCD => GetString("BSCD");

		/// <summary>
		/// Description: Preliminary tax invoice number
		/// FieldName: PTIN
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Preliminary tax invoice number")]
		public decimal? M3_PTIN => GetNullableDecimal("PTIN");

		/// <summary>
		/// Description: Preliminary tax invoice year
		/// FieldName: PTIY
		/// FieldType: N
		/// Length: 4
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Preliminary tax invoice year")]
		public int? M3_PTIY => GetNullableInt("PTIY");

		/// <summary>
		/// Description: Creation date for tax invoice
		/// FieldName: TICR
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Creation date for tax invoice")]
		public DateTime? M3_TICR => GetNullableDateTime("TICR");

		/// <summary>
		/// Description: Tax invoice status
		/// FieldName: TXIS
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Tax invoice status")]
		public int? M3_TXIS => GetNullableInt("TXIS");

		/// <summary>
		/// Description: Tax invoice number
		/// FieldName: TXIV
		/// FieldType: A
		/// Length: 24
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Tax invoice number")]
		public string M3_TXIV => GetString("TXIV");

		/// <summary>
		/// Description: Tax invoice year
		/// FieldName: TXIY
		/// FieldType: N
		/// Length: 4
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Tax invoice year")]
		public int? M3_TXIY => GetNullableInt("TXIY");

		/// <summary>
		/// Description: Tax invoice sequence number
		/// FieldName: TXSQ
		/// FieldType: N
		/// Length: 8
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Tax invoice sequence number")]
		public int? M3_TXSQ => GetNullableInt("TXSQ");

		/// <summary>
		/// Description: Reversed reporting
		/// FieldName: ARRV
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Reversed reporting")]
		public int? M3_ARRV => GetNullableInt("ARRV");

		/// <summary>
		/// Description: Customer
		/// FieldName: CUNO
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Customer")]
		public string M3_CUNO => GetString("CUNO");

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
		/// Description: VAT registration number
		/// FieldName: VRNO
		/// FieldType: A
		/// Length: 16
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("VAT registration number")]
		public string M3_VRNO => GetString("VRNO");

		/// <summary>
		/// Description: Email address
		/// FieldName: EMAL
		/// FieldType: A
		/// Length: 60
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Email address")]
		public string M3_EMAL => GetString("EMAL");

		/// <summary>
		/// Description: Tax invoice type
		/// FieldName: TINP
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Tax invoice type")]
		public int? M3_TINP => GetNullableInt("TINP");

		/// <summary>
		/// Description: Paid
		/// FieldName: TXPY
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Paid")]
		public int? M3_TXPY => GetNullableInt("TXPY");

		/// <summary>
		/// Description: Net amount
		/// FieldName: NAMT
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Net amount")]
		public decimal? M3_NAMT => GetNullableDecimal("NAMT");

		/// <summary>
		/// Description: VAT
		/// FieldName: VTAM
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("VAT")]
		public decimal? M3_VTAM => GetNullableDecimal("VTAM");

		/// <summary>
		/// Description: Gross amount
		/// FieldName: GAMT
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Gross amount")]
		public decimal? M3_GAMT => GetNullableDecimal("GAMT");

		/// <summary>
		/// Description: Entry date
		/// FieldName: RGDT
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Entry date")]
		public DateTime? M3_RGDT => GetNullableDateTime("RGDT");

		/// <summary>
		/// Description: Entry time
		/// FieldName: RGTM
		/// FieldType: N
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Entry time")]
		public int? M3_RGTM => GetNullableInt("RGTM");

		/// <summary>
		/// Description: Change date
		/// FieldName: LMDT
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Change date")]
		public DateTime? M3_LMDT => GetNullableDateTime("LMDT");

		/// <summary>
		/// Description: Change number
		/// FieldName: CHNO
		/// FieldType: N
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Change number")]
		public int? M3_CHNO => GetNullableInt("CHNO");

		/// <summary>
		/// Description: Changed by
		/// FieldName: CHID
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Changed by")]
		public string M3_CHID => GetString("CHID");

		/// <summary>
		/// Description: Sequence number
		/// FieldName: TIS5
		/// FieldType: A
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Sequence number")]
		public string M3_TIS5 => GetString("TIS5");

		/// <summary>
		/// Description: In progress
		/// FieldName: TIIP
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("In progress")]
		public int? M3_TIIP => GetNullableInt("TIIP");

		/// <summary>
		/// Description: Message
		/// FieldName: MSGT
		/// FieldType: A
		/// Length: 180
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Message")]
		public string M3_MSGT => GetString("MSGT");

		/// <summary>
		/// Description: Conversation ID
		/// FieldName: CNVI
		/// FieldType: A
		/// Length: 35
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Conversation ID")]
		public string M3_CNVI => GetString("CNVI");
	}
}
// EOF
