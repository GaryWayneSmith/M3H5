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

namespace M3H5Lib.Api.XBE130MI
{
	public partial class LstInvByPayeeResponse : M3BaseRecord 
	{

		/// <summary>
		/// Description: Company
		/// FieldName: CONO
		/// FieldType: N
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Company")]
		public int? M3_CONO => GetNullableInt("CONO");

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
		/// Description: Payment Proposal
		/// FieldName: PRPN
		/// FieldType: N
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Payment Proposal")]
		public long? M3_PRPN => GetNullableLong("PRPN");

		/// <summary>
		/// Description: Payment Order
		/// FieldName: PYON
		/// FieldType: N
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Payment Order")]
		public int? M3_PYON => GetNullableInt("PYON");

		/// <summary>
		/// Description: Payee
		/// FieldName: SPYN
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Payee")]
		public string M3_SPYN => GetString("SPYN");

		/// <summary>
		/// Description: Original Division
		/// FieldName: ODIV
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Original Division")]
		public string M3_ODIV => GetString("ODIV");

		/// <summary>
		/// Description: Supplier Number
		/// FieldName: SUNO
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Supplier Number")]
		public string M3_SUNO => GetString("SUNO");

		/// <summary>
		/// Description: Supplier Invoice Number
		/// FieldName: SINO
		/// FieldType: A
		/// Length: 24
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Supplier Invoice Number")]
		public string M3_SINO => GetString("SINO");

		/// <summary>
		/// Description: Invoice Year
		/// FieldName: INYR
		/// FieldType: N
		/// Length: 4
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Invoice Year")]
		public int? M3_INYR => GetNullableInt("INYR");

		/// <summary>
		/// Description: Supplier Customer Number
		/// FieldName: SCNO
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Supplier Customer Number")]
		public string M3_SCNO => GetString("SCNO");

		/// <summary>
		/// Description: Code Cost BNL
		/// FieldName: XBNL
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Code Cost BNL")]
		public int? M3_XBNL => GetNullableInt("XBNL");

		/// <summary>
		/// Description: Code Cost Correspondence
		/// FieldName: XCCC
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Code Cost Correspondence")]
		public int? M3_XCCC => GetNullableInt("XCCC");

		/// <summary>
		/// Description: Code - Kind of Payment Order
		/// FieldName: XKPO
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Code - Kind of Payment Order")]
		public int? M3_XKPO => GetNullableInt("XKPO");

		/// <summary>
		/// Description: Code - Kind of Performance
		/// FieldName: XKPR
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Code - Kind of Performance")]
		public int? M3_XKPR => GetNullableInt("XKPR");

		/// <summary>
		/// Description: Code - Cheque Cross
		/// FieldName: XCCR
		/// FieldType: A
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Code - Cheque Cross")]
		public string M3_XCCR => GetString("XCCR");

		/// <summary>
		/// Description: Code - Send Cheque
		/// FieldName: XCSC
		/// FieldType: A
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Code - Send Cheque")]
		public string M3_XCSC => GetString("XCSC");

		/// <summary>
		/// Description: Code - Payment Instruction 1
		/// FieldName: XPA1
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Code - Payment Instruction 1")]
		public string M3_XPA1 => GetString("XPA1");

		/// <summary>
		/// Description: Code - Payment Instruction 2
		/// FieldName: XPA2
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Code - Payment Instruction 2")]
		public string M3_XPA2 => GetString("XPA2");

		/// <summary>
		/// Description: Code - Payment Instruction 3
		/// FieldName: XPA3
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Code - Payment Instruction 3")]
		public string M3_XPA3 => GetString("XPA3");

		/// <summary>
		/// Description: Code - Payment Instruction 4
		/// FieldName: XPA4
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Code - Payment Instruction 4")]
		public string M3_XPA4 => GetString("XPA4");

		/// <summary>
		/// Description: Code - Kind of Payment
		/// FieldName: XKPY
		/// FieldType: A
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Code - Kind of Payment")]
		public string M3_XKPY => GetString("XKPY");

		/// <summary>
		/// Description: Description - Kind of Payment
		/// FieldName: XDP1
		/// FieldType: A
		/// Length: 40
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Description - Kind of Payment")]
		public string M3_XDP1 => GetString("XDP1");

		/// <summary>
		/// Description: Description - Kind of Payment
		/// FieldName: XDP2
		/// FieldType: A
		/// Length: 40
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Description - Kind of Payment")]
		public string M3_XDP2 => GetString("XDP2");

		/// <summary>
		/// Description: Registration Number DNB
		/// FieldName: XDNB
		/// FieldType: A
		/// Length: 8
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Registration Number DNB")]
		public string M3_XDNB => GetString("XDNB");

		/// <summary>
		/// Description: Code Item
		/// FieldName: XCIT
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Code Item")]
		public string M3_XCIT => GetString("XCIT");

		/// <summary>
		/// Description: Item Number
		/// FieldName: XITR
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Item Number")]
		public string M3_XITR => GetString("XITR");

		/// <summary>
		/// Description: Trader Number
		/// FieldName: XTRN
		/// FieldType: A
		/// Length: 4
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Trader Number")]
		public string M3_XTRN => GetString("XTRN");

		/// <summary>
		/// Description: Purity of Giro Accounts
		/// FieldName: XPUR
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Purity of Giro Accounts")]
		public int? M3_XPUR => GetNullableInt("XPUR");

		/// <summary>
		/// Description: Bank
		/// FieldName: XBAN
		/// FieldType: A
		/// Length: 4
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Bank")]
		public string M3_XBAN => GetString("XBAN");

		/// <summary>
		/// Description: Prefix Account Number
		/// FieldName: XPRF
		/// FieldType: N
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Prefix Account Number")]
		public int? M3_XPRF => GetNullableInt("XPRF");

		/// <summary>
		/// Description: Code Cost
		/// FieldName: XCST
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Code Cost")]
		public string M3_XCST => GetString("XCST");

		/// <summary>
		/// Description: Code Payment
		/// FieldName: XCPY
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Code Payment")]
		public string M3_XCPY => GetString("XCPY");

		/// <summary>
		/// Description: Code BLIW
		/// FieldName: XBLW
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Code BLIW")]
		public string M3_XBLW => GetString("XBLW");

		/// <summary>
		/// Description: Currency Account
		/// FieldName: XCAC
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Currency Account")]
		public int? M3_XCAC => GetNullableInt("XCAC");

		/// <summary>
		/// Description: Recorded Amount
		/// FieldName: XABL
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Recorded Amount")]
		public decimal? M3_XABL => GetNullableDecimal("XABL");
	}
}
// EOF
