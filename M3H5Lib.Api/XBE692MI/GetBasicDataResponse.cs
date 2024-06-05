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

namespace M3H5Lib.Api.XBE692MI
{
	public partial class GetBasicDataResponse : M3BaseRecord 
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
		public int? M3CONO => GetNullableInt("CONO");

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
		/// Description: Bank Account Identity
		/// FieldName: BKID
		/// FieldType: A
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Bank Account Identity")]
		public string M3BKID => GetString("BKID");

		/// <summary>
		/// Description: Bank Account Type
		/// FieldName: BKTP
		/// FieldType: N
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Bank Account Type")]
		public int? M3BKTP => GetNullableInt("BKTP");

		/// <summary>
		/// Description: Account Holder
		/// FieldName: ACHO
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Account Holder")]
		public string M3ACHO => GetString("ACHO");

		/// <summary>
		/// Description: Code Cost BNL
		/// FieldName: XBNL
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Code Cost BNL")]
		public int? M3XBNL => GetNullableInt("XBNL");

		/// <summary>
		/// Description: Code Cost Correspondence
		/// FieldName: XCCC
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Code Cost Correspondence")]
		public int? M3XCCC => GetNullableInt("XCCC");

		/// <summary>
		/// Description: Code Kind of Payment Order
		/// FieldName: XKPO
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Code Kind of Payment Order")]
		public int? M3XKPO => GetNullableInt("XKPO");

		/// <summary>
		/// Description: Code Kind of Performance
		/// FieldName: XKPR
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Code Kind of Performance")]
		public int? M3XKPR => GetNullableInt("XKPR");

		/// <summary>
		/// Description: Code Cheque Cross
		/// FieldName: XCCR
		/// FieldType: A
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Code Cheque Cross")]
		public string M3XCCR => GetString("XCCR");

		/// <summary>
		/// Description: Code Send Cheque
		/// FieldName: XCSC
		/// FieldType: A
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Code Send Cheque")]
		public string M3XCSC => GetString("XCSC");

		/// <summary>
		/// Description: Code Payment Instruction 1
		/// FieldName: XPA1
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Code Payment Instruction 1")]
		public string M3XPA1 => GetString("XPA1");

		/// <summary>
		/// Description: Code Payment Instruction 2
		/// FieldName: XPA2
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Code Payment Instruction 2")]
		public string M3XPA2 => GetString("XPA2");

		/// <summary>
		/// Description: Code Payment Instruction 3
		/// FieldName: XPA3
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Code Payment Instruction 3")]
		public string M3XPA3 => GetString("XPA3");

		/// <summary>
		/// Description: Code Payment Instruction 4
		/// FieldName: XPA4
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Code Payment Instruction 4")]
		public string M3XPA4 => GetString("XPA4");

		/// <summary>
		/// Description: Code Kind of Payment
		/// FieldName: XKPY
		/// FieldType: A
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Code Kind of Payment")]
		public string M3XKPY => GetString("XKPY");

		/// <summary>
		/// Description: Description Kind of Payment
		/// FieldName: XDP1
		/// FieldType: A
		/// Length: 40
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Description Kind of Payment")]
		public string M3XDP1 => GetString("XDP1");

		/// <summary>
		/// Description: Description Kind of Payment
		/// FieldName: XDP2
		/// FieldType: A
		/// Length: 40
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Description Kind of Payment")]
		public string M3XDP2 => GetString("XDP2");

		/// <summary>
		/// Description: Registration Number DNB
		/// FieldName: XDNB
		/// FieldType: A
		/// Length: 8
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Registration Number DNB")]
		public string M3XDNB => GetString("XDNB");

		/// <summary>
		/// Description: Code Item
		/// FieldName: XCIT
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Code Item")]
		public string M3XCIT => GetString("XCIT");

		/// <summary>
		/// Description: Item Number
		/// FieldName: XITR
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Item Number")]
		public string M3XITR => GetString("XITR");

		/// <summary>
		/// Description: Trader Number
		/// FieldName: XTRN
		/// FieldType: A
		/// Length: 4
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Trader Number")]
		public string M3XTRN => GetString("XTRN");

		/// <summary>
		/// Description: Purity of Giro Accounts
		/// FieldName: XPUR
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Purity of Giro Accounts")]
		public int? M3XPUR => GetNullableInt("XPUR");

		/// <summary>
		/// Description: Bank
		/// FieldName: XBAN
		/// FieldType: A
		/// Length: 4
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Bank")]
		public string M3XBAN => GetString("XBAN");

		/// <summary>
		/// Description: Prefix Account Number
		/// FieldName: XPRF
		/// FieldType: N
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Prefix Account Number")]
		public int? M3XPRF => GetNullableInt("XPRF");

		/// <summary>
		/// Description: Code Cost
		/// FieldName: XCST
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Code Cost")]
		public string M3XCST => GetString("XCST");

		/// <summary>
		/// Description: Code Payment
		/// FieldName: XCPY
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Code Payment")]
		public string M3XCPY => GetString("XCPY");

		/// <summary>
		/// Description: Code BLIW
		/// FieldName: XBLW
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Code BLIW")]
		public string M3XBLW => GetString("XBLW");

		/// <summary>
		/// Description: Currency Account
		/// FieldName: XCAC
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Currency Account")]
		public int? M3XCAC => GetNullableInt("XCAC");
	}
}
// EOF
