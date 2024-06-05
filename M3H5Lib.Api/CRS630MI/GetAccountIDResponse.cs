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

namespace M3H5Lib.Api.CRS630MI
{
	public partial class GetAccountIDResponse : M3BaseRecord 
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
		/// Description: Accounting dimension
		/// FieldName: AITP
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Accounting dimension")]
		public int? M3_AITP => GetNullableInt("AITP");

		/// <summary>
		/// Description: Accounting identity
		/// FieldName: AITM
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Accounting identity")]
		public string M3_AITM => GetString("AITM");

		/// <summary>
		/// Description: Account group
		/// FieldName: AICL
		/// FieldType: A
		/// Length: 8
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Account group")]
		public string M3_AICL => GetString("AICL");

		/// <summary>
		/// Description: Description
		/// FieldName: TX40
		/// FieldType: A
		/// Length: 40
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Description")]
		public string M3_TX40 => GetString("TX40");

		/// <summary>
		/// Description: Name
		/// FieldName: TX15
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Name")]
		public string M3_TX15 => GetString("TX15");

		/// <summary>
		/// Description: Balance account
		/// FieldName: AT01
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Balance account")]
		public int? M3_AT01 => GetNullableInt("AT01");

		/// <summary>
		/// Description: Profit or loss account
		/// FieldName: AT02
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Profit or loss account")]
		public int? M3_AT02 => GetNullableInt("AT02");

		/// <summary>
		/// Description: Accounts receivable account
		/// FieldName: AT03
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Accounts receivable account")]
		public int? M3_AT03 => GetNullableInt("AT03");

		/// <summary>
		/// Description: Accounts payable account
		/// FieldName: AT11
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Accounts payable account")]
		public int? M3_AT11 => GetNullableInt("AT11");

		/// <summary>
		/// Description: VAT account type
		/// FieldName: AT04
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("VAT account type")]
		public int? M3_AT04 => GetNullableInt("AT04");

		/// <summary>
		/// Description: Internal account
		/// FieldName: AT05
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Internal account")]
		public int? M3_AT05 => GetNullableInt("AT05");

		/// <summary>
		/// Description: Revaluation account
		/// FieldName: AT06
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Revaluation account")]
		public int? M3_AT06 => GetNullableInt("AT06");

		/// <summary>
		/// Description: Cost of capital account
		/// FieldName: AT07
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Cost of capital account")]
		public int? M3_AT07 => GetNullableInt("AT07");

		/// <summary>
		/// Description: Fixed assets account
		/// FieldName: AT08
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Fixed assets account")]
		public int? M3_AT08 => GetNullableInt("AT08");

		/// <summary>
		/// Description: Period account
		/// FieldName: AT09
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Period account")]
		public int? M3_AT09 => GetNullableInt("AT09");

		/// <summary>
		/// Description: Clearing account
		/// FieldName: AT10
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Clearing account")]
		public int? M3_AT10 => GetNullableInt("AT10");

		/// <summary>
		/// Description: Blocked accounting identity
		/// FieldName: LCCD
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Blocked accounting identity")]
		public int? M3_LCCD => GetNullableInt("LCCD");

		/// <summary>
		/// Description: Outcome account
		/// FieldName: OUAC
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Outcome account")]
		public int? M3_OUAC => GetNullableInt("OUAC");

		/// <summary>
		/// Description: Budget account
		/// FieldName: BUAC
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Budget account")]
		public int? M3_BUAC => GetNullableInt("BUAC");

		/// <summary>
		/// Description: Cost accounting account
		/// FieldName: CAAC
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Cost accounting account")]
		public int? M3_CAAC => GetNullableInt("CAAC");

		/// <summary>
		/// Description: Valid from
		/// FieldName: VFDT
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Valid from")]
		public DateTime? M3_VFDT => GetNullableDateTime("VFDT");

		/// <summary>
		/// Description: Valid to
		/// FieldName: VTDT
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Valid to")]
		public DateTime? M3_VTDT => GetNullableDateTime("VTDT");

		/// <summary>
		/// Description: Filing
		/// FieldName: ARCH
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Filing")]
		public int? M3_ARCH => GetNullableInt("ARCH");

		/// <summary>
		/// Description: ACR for accounting dimension 2
		/// FieldName: ACR2
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("ACR for accounting dimension 2")]
		public int? M3_ACR2 => GetNullableInt("ACR2");

		/// <summary>
		/// Description: ACR for accounting dimension 3
		/// FieldName: ACR3
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("ACR for accounting dimension 3")]
		public int? M3_ACR3 => GetNullableInt("ACR3");

		/// <summary>
		/// Description: ACR for accounting dimension 4
		/// FieldName: ACR4
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("ACR for accounting dimension 4")]
		public int? M3_ACR4 => GetNullableInt("ACR4");

		/// <summary>
		/// Description: ACR for accounting dimension 5
		/// FieldName: ACR5
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("ACR for accounting dimension 5")]
		public int? M3_ACR5 => GetNullableInt("ACR5");

		/// <summary>
		/// Description: ACR for accounting dimension 6
		/// FieldName: ACR6
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("ACR for accounting dimension 6")]
		public int? M3_ACR6 => GetNullableInt("ACR6");

		/// <summary>
		/// Description: ACR for accounting dimension 7
		/// FieldName: ACR7
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("ACR for accounting dimension 7")]
		public int? M3_ACR7 => GetNullableInt("ACR7");

		/// <summary>
		/// Description: ACR for VAT codes
		/// FieldName: ACRV
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("ACR for VAT codes")]
		public int? M3_ACRV => GetNullableInt("ACRV");

		/// <summary>
		/// Description: ACR for acc dimension 2 (budget)
		/// FieldName: ACB2
		/// FieldType: A
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("ACR for acc dimension 2 (budget)")]
		public string M3_ACB2 => GetString("ACB2");

		/// <summary>
		/// Description: ACR for acc dimension 3 (budget)
		/// FieldName: ACB3
		/// FieldType: A
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("ACR for acc dimension 3 (budget)")]
		public string M3_ACB3 => GetString("ACB3");

		/// <summary>
		/// Description: ACR for acc dimension 4 (budget)
		/// FieldName: ACB4
		/// FieldType: A
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("ACR for acc dimension 4 (budget)")]
		public string M3_ACB4 => GetString("ACB4");

		/// <summary>
		/// Description: ACR for acc dimension 5 (budget)
		/// FieldName: ACB5
		/// FieldType: A
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("ACR for acc dimension 5 (budget)")]
		public string M3_ACB5 => GetString("ACB5");

		/// <summary>
		/// Description: ACR for acc dimension 6 (budget)
		/// FieldName: ACB6
		/// FieldType: A
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("ACR for acc dimension 6 (budget)")]
		public string M3_ACB6 => GetString("ACB6");

		/// <summary>
		/// Description: ACR for acc dimension 7 (budget)
		/// FieldName: ACB7
		/// FieldType: A
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("ACR for acc dimension 7 (budget)")]
		public string M3_ACB7 => GetString("ACB7");

		/// <summary>
		/// Description: Object access group
		/// FieldName: ACGR
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Object access group")]
		public string M3_ACGR => GetString("ACGR");

		/// <summary>
		/// Description: Authority group
		/// FieldName: APCG
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Authority group")]
		public string M3_APCG => GetString("APCG");

		/// <summary>
		/// Description: Responsible
		/// FieldName: RESP
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Responsible")]
		public string M3_RESP => GetString("RESP");

		/// <summary>
		/// Description: VAT code
		/// FieldName: VTCD
		/// FieldType: N
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("VAT code")]
		public int? M3_VTCD => GetNullableInt("VTCD");

		/// <summary>
		/// Description: Currency connection
		/// FieldName: CCCD
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Currency connection")]
		public int? M3_CCCD => GetNullableInt("CCCD");

		/// <summary>
		/// Description: Currency
		/// FieldName: CUCD
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Currency")]
		public string M3_CUCD => GetString("CUCD");

		/// <summary>
		/// Description: Sign lock
		/// FieldName: SLCD
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Sign lock")]
		public int? M3_SLCD => GetNullableInt("SLCD");

		/// <summary>
		/// Description: Quantity mandatory
		/// FieldName: MQCD
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Quantity mandatory")]
		public int? M3_MQCD => GetNullableInt("MQCD");

		/// <summary>
		/// Description: Text mandatory
		/// FieldName: MTCD
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Text mandatory")]
		public int? M3_MTCD => GetNullableInt("MTCD");

		/// <summary>
		/// Description: Replacement category
		/// FieldName: SUCT
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Replacement category")]
		public string M3_SUCT => GetString("SUCT");

		/// <summary>
		/// Description: Cost of capital rule
		/// FieldName: CICT
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Cost of capital rule")]
		public string M3_CICT => GetString("CICT");

		/// <summary>
		/// Description: Transaction check before deletion
		/// FieldName: ETCH
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Transaction check before deletion")]
		public int? M3_ETCH => GetNullableInt("ETCH");

		/// <summary>
		/// Description: Field
		/// FieldName: OBJE
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Field")]
		public string M3_OBJE => GetString("OBJE");

		/// <summary>
		/// Description: Reconciliation
		/// FieldName: RECE
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Reconciliation")]
		public int? M3_RECE => GetNullableInt("RECE");

		/// <summary>
		/// Description: Petty cash account
		/// FieldName: PCA1
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Petty cash account")]
		public int? M3_PCA1 => GetNullableInt("PCA1");

		/// <summary>
		/// Description: Bank account
		/// FieldName: AT12
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Bank account")]
		public int? M3_AT12 => GetNullableInt("AT12");

		/// <summary>
		/// Description: Suspense account
		/// FieldName: CLRA
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Suspense account")]
		public int? M3_CLRA => GetNullableInt("CLRA");

		/// <summary>
		/// Description: Inventory account
		/// FieldName: STOA
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Inventory account")]
		public int? M3_STOA => GetNullableInt("STOA");

		/// <summary>
		/// Description: Enter bank operation
		/// FieldName: BACR
		/// FieldType: A
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Enter bank operation")]
		public string M3_BACR => GetString("BACR");

		/// <summary>
		/// Description: Resource driver
		/// FieldName: RDRI
		/// FieldType: A
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Resource driver")]
		public string M3_RDRI => GetString("RDRI");

		/// <summary>
		/// Description: Variable percent
		/// FieldName: RDVP
		/// FieldType: N
		/// Length: 7
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Variable percent")]
		public int? M3_RDVP => GetNullableInt("RDVP");

		/// <summary>
		/// Description: Cost center model
		/// FieldName: CMID
		/// FieldType: A
		/// Length: 8
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Cost center model")]
		public string M3_CMID => GetString("CMID");

		/// <summary>
		/// Description: Consolidation method
		/// FieldName: GCMT
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Consolidation method")]
		public int? M3_GCMT => GetNullableInt("GCMT");

		/// <summary>
		/// Description: Text identity
		/// FieldName: TXID
		/// FieldType: N
		/// Length: 13
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Text identity")]
		public decimal? M3_TXID => GetNullableDecimal("TXID");

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
		/// Description: Timestamp
		/// FieldName: LMTS
		/// FieldType: N
		/// Length: 18
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Timestamp")]
		public decimal? M3_LMTS => GetNullableDecimal("LMTS");

		/// <summary>
		/// Description: Compress for accounting dimension 2
		/// FieldName: CAD2
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Compress for accounting dimension 2")]
		public int? M3_CAD2 => GetNullableInt("CAD2");

		/// <summary>
		/// Description: Compress for accounting dimension 3
		/// FieldName: CAD3
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Compress for accounting dimension 3")]
		public int? M3_CAD3 => GetNullableInt("CAD3");

		/// <summary>
		/// Description: Compress for accounting dimension 4
		/// FieldName: CAD4
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Compress for accounting dimension 4")]
		public int? M3_CAD4 => GetNullableInt("CAD4");

		/// <summary>
		/// Description: Compress for accounting dimension 5
		/// FieldName: CAD5
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Compress for accounting dimension 5")]
		public int? M3_CAD5 => GetNullableInt("CAD5");

		/// <summary>
		/// Description: Compress for accounting dimension 6
		/// FieldName: CAD6
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Compress for accounting dimension 6")]
		public int? M3_CAD6 => GetNullableInt("CAD6");

		/// <summary>
		/// Description: Compress for accounting dimension 7
		/// FieldName: CAD7
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Compress for accounting dimension 7")]
		public int? M3_CAD7 => GetNullableInt("CAD7");

		/// <summary>
		/// Description: Delegation of authority code
		/// FieldName: DAUC
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Delegation of authority code")]
		public string M3_DAUC => GetString("DAUC");

		/// <summary>
		/// Description: Blocked for manual entry
		/// FieldName: AT13
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Blocked for manual entry")]
		public int? M3_AT13 => GetNullableInt("AT13");
	}
}
// EOF
