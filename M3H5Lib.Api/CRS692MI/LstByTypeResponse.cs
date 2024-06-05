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

namespace M3H5Lib.Api.CRS692MI
{
	public partial class LstByTypeResponse : M3BaseRecord 
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
		/// Description: Bank account identity
		/// FieldName: BKID
		/// FieldType: A
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Bank account identity")]
		public string M3_BKID => GetString("BKID");

		/// <summary>
		/// Description: Bank account type
		/// FieldName: BKTP
		/// FieldType: N
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Bank account type")]
		public int? M3_BKTP => GetNullableInt("BKTP");

		/// <summary>
		/// Description: Account holder
		/// FieldName: ACHO
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Account holder")]
		public string M3_ACHO => GetString("ACHO");

		/// <summary>
		/// Description: Bank number
		/// FieldName: BKNO
		/// FieldType: A
		/// Length: 8
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Bank number")]
		public string M3_BKNO => GetString("BKNO");

		/// <summary>
		/// Description: Bank branch identity
		/// FieldName: BBRN
		/// FieldType: A
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Bank branch identity")]
		public string M3_BBRN => GetString("BBRN");

		/// <summary>
		/// Description: Status
		/// FieldName: STAT
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Status")]
		public string M3_STAT => GetString("STAT");

		/// <summary>
		/// Description: Bank account name
		/// FieldName: BANA
		/// FieldType: A
		/// Length: 36
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Bank account name")]
		public string M3_BANA => GetString("BANA");

		/// <summary>
		/// Description: Accounting dimension 1
		/// FieldName: AIT1
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Accounting dimension 1")]
		public string M3_AIT1 => GetString("AIT1");

		/// <summary>
		/// Description: Accounting dimension 2
		/// FieldName: AIT2
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Accounting dimension 2")]
		public string M3_AIT2 => GetString("AIT2");

		/// <summary>
		/// Description: Accounting dimension 3
		/// FieldName: AIT3
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Accounting dimension 3")]
		public string M3_AIT3 => GetString("AIT3");

		/// <summary>
		/// Description: Accounting dimension 4
		/// FieldName: AIT4
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Accounting dimension 4")]
		public string M3_AIT4 => GetString("AIT4");

		/// <summary>
		/// Description: Accounting dimension 5
		/// FieldName: AIT5
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Accounting dimension 5")]
		public string M3_AIT5 => GetString("AIT5");

		/// <summary>
		/// Description: Accounting dimension 6
		/// FieldName: AIT6
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Accounting dimension 6")]
		public string M3_AIT6 => GetString("AIT6");

		/// <summary>
		/// Description: Accounting dimension 7
		/// FieldName: AIT7
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Accounting dimension 7")]
		public string M3_AIT7 => GetString("AIT7");

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
		/// Description: Bank account indicator
		/// FieldName: BKIN
		/// FieldType: A
		/// Length: 4
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Bank account indicator")]
		public string M3_BKIN => GetString("BKIN");

		/// <summary>
		/// Description: Description bank account indicator
		/// FieldName: BKIT
		/// FieldType: A
		/// Length: 40
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Description bank account indicator")]
		public string M3_BKIT => GetString("BKIT");

		/// <summary>
		/// Description: Bank account field 1
		/// FieldName: BAF1
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Bank account field 1")]
		public string M3_BAF1 => GetString("BAF1");

		/// <summary>
		/// Description: Bank account field 2
		/// FieldName: BAF2
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Bank account field 2")]
		public string M3_BAF2 => GetString("BAF2");

		/// <summary>
		/// Description: Bank account field 3
		/// FieldName: BAF3
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Bank account field 3")]
		public string M3_BAF3 => GetString("BAF3");

		/// <summary>
		/// Description: Bank account field 4
		/// FieldName: BAF4
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Bank account field 4")]
		public string M3_BAF4 => GetString("BAF4");

		/// <summary>
		/// Description: Bank account field 5
		/// FieldName: BAF5
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Bank account field 5")]
		public string M3_BAF5 => GetString("BAF5");

		/// <summary>
		/// Description: Banking region
		/// FieldName: BKPL
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Banking region")]
		public string M3_BKPL => GetString("BKPL");

		/// <summary>
		/// Description: Description banking region
		/// FieldName: BKPT
		/// FieldType: A
		/// Length: 40
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Description banking region")]
		public string M3_BKPT => GetString("BKPT");

		/// <summary>
		/// Description: Remittance method
		/// FieldName: ARTP
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Remittance method")]
		public int? M3_ARTP => GetNullableInt("ARTP");

		/// <summary>
		/// Description: Maximum discountable amount
		/// FieldName: BMDA
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Maximum discountable amount")]
		public decimal? M3_BMDA => GetNullableDecimal("BMDA");

		/// <summary>
		/// Description: Maximum collection amount
		/// FieldName: BMCA
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Maximum collection amount")]
		public decimal? M3_BMCA => GetNullableDecimal("BMCA");

		/// <summary>
		/// Description: Fixed discount charge
		/// FieldName: FCDC
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Fixed discount charge")]
		public decimal? M3_FCDC => GetNullableDecimal("FCDC");

		/// <summary>
		/// Description: Discount rate
		/// FieldName: BIDC
		/// FieldType: N
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Discount rate")]
		public int? M3_BIDC => GetNullableInt("BIDC");

		/// <summary>
		/// Description: Minimum number of days for interest
		/// FieldName: BMDI
		/// FieldType: N
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Minimum number of days for interest")]
		public int? M3_BMDI => GetNullableInt("BMDI");

		/// <summary>
		/// Description: Fixed collection charges
		/// FieldName: FCCO
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Fixed collection charges")]
		public decimal? M3_FCCO => GetNullableDecimal("FCCO");

		/// <summary>
		/// Description: Discounted amount not overdue
		/// FieldName: DNOV
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Discounted amount not overdue")]
		public decimal? M3_DNOV => GetNullableDecimal("DNOV");

		/// <summary>
		/// Description: Cash remittance not overdue
		/// FieldName: CNOV
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Cash remittance not overdue")]
		public decimal? M3_CNOV => GetNullableDecimal("CNOV");

		/// <summary>
		/// Description: Bank EDI agreement number
		/// FieldName: BKAG
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Bank EDI agreement number")]
		public string M3_BKAG => GetString("BKAG");

		/// <summary>
		/// Description: Financial institution
		/// FieldName: FINC
		/// FieldType: A
		/// Length: 11
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Financial institution")]
		public string M3_FINC => GetString("FINC");

		/// <summary>
		/// Description: Code list - qualifier
		/// FieldName: C1QF
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Code list - qualifier")]
		public string M3_C1QF => GetString("C1QF");

		/// <summary>
		/// Description: Code list - responsible agent
		/// FieldName: C1RA
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Code list - responsible agent")]
		public string M3_C1RA => GetString("C1RA");

		/// <summary>
		/// Description: Account number at financial institution
		/// FieldName: FIAN
		/// FieldType: A
		/// Length: 25
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Account number at financial institution")]
		public string M3_FIAN => GetString("FIAN");

		/// <summary>
		/// Description: Branch number
		/// FieldName: BRNO
		/// FieldType: A
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Branch number")]
		public string M3_BRNO => GetString("BRNO");

		/// <summary>
		/// Description: Code list - qualifier
		/// FieldName: C2QF
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Code list - qualifier")]
		public string M3_C2QF => GetString("C2QF");

		/// <summary>
		/// Description: Code list - responsible agent
		/// FieldName: C2RA
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Code list - responsible agent")]
		public string M3_C2RA => GetString("C2RA");

		/// <summary>
		/// Description: Customer number at financial institution
		/// FieldName: FICU
		/// FieldType: A
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Customer number at financial institution")]
		public string M3_FICU => GetString("FICU");

		/// <summary>
		/// Description: Number of lines
		/// FieldName: NCHL
		/// FieldType: N
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Number of lines")]
		public int? M3_NCHL => GetNullableInt("NCHL");

		/// <summary>
		/// Description: Bank priority
		/// FieldName: CBPY
		/// FieldType: N
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Bank priority")]
		public int? M3_CBPY => GetNullableInt("CBPY");

		/// <summary>
		/// Description: Payment method - accounts receivable
		/// FieldName: PYCD
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Payment method - accounts receivable")]
		public string M3_PYCD => GetString("PYCD");

		/// <summary>
		/// Description: Description payment method
		/// FieldName: PYCT
		/// FieldType: A
		/// Length: 40
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Description payment method")]
		public string M3_PYCT => GetString("PYCT");

		/// <summary>
		/// Description: Language
		/// FieldName: LNCD
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Language")]
		public string M3_LNCD => GetString("LNCD");

		/// <summary>
		/// Description: Description language code
		/// FieldName: LNCT
		/// FieldType: A
		/// Length: 40
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Description language code")]
		public string M3_LNCT => GetString("LNCT");

		/// <summary>
		/// Description: Number of days risk
		/// FieldName: NODY
		/// FieldType: N
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Number of days risk")]
		public int? M3_NODY => GetNullableInt("NODY");

		/// <summary>
		/// Description: Employee bank account type
		/// FieldName: EBAT
		/// FieldType: A
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Employee bank account type")]
		public string M3_EBAT => GetString("EBAT");

		/// <summary>
		/// Description: Payment type key
		/// FieldName: PYTK
		/// FieldType: N
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Payment type key")]
		public int? M3_PYTK => GetNullableInt("PYTK");

		/// <summary>
		/// Description: Cost allocation code
		/// FieldName: CSTC
		/// FieldType: N
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Cost allocation code")]
		public int? M3_CSTC => GetNullableInt("CSTC");

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
		/// Description: International bank account number
		/// FieldName: IBAN
		/// FieldType: A
		/// Length: 34
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("International bank account number")]
		public string M3_IBAN => GetString("IBAN");

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
		/// Description: Check digit method - bank account number
		/// FieldName: CMBN
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Check digit method - bank account number")]
		public string M3_CMBN => GetString("CMBN");

		/// <summary>
		/// Description: Creditor identifier number
		/// FieldName: CIDN
		/// FieldType: A
		/// Length: 35
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Creditor identifier number")]
		public string M3_CIDN => GetString("CIDN");
	}
}
// EOF
