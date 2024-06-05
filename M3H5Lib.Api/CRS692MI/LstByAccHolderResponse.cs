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

namespace M3H5Lib.Api.CRS692MI
{
	public partial class LstByAccHolderResponse : M3BaseRecord 
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
		/// Description: Bank account type
		/// FieldName: BKTP
		/// FieldType: N
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Bank account type")]
		public int? M3BKTP => GetNullableInt("BKTP");

		/// <summary>
		/// Description: Account holder
		/// FieldName: ACHO
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Account holder")]
		public string M3ACHO => GetString("ACHO");

		/// <summary>
		/// Description: Bank priority
		/// FieldName: CBPY
		/// FieldType: N
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Bank priority")]
		public int? M3CBPY => GetNullableInt("CBPY");

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
		/// Description: Status
		/// FieldName: STAT
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Status")]
		public string M3STAT => GetString("STAT");

		/// <summary>
		/// Description: Bank number
		/// FieldName: BKNO
		/// FieldType: A
		/// Length: 8
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Bank number")]
		public string M3BKNO => GetString("BKNO");

		/// <summary>
		/// Description: Bank branch identity
		/// FieldName: BBRN
		/// FieldType: A
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Bank branch identity")]
		public string M3BBRN => GetString("BBRN");

		/// <summary>
		/// Description: Banking region
		/// FieldName: BKPL
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Banking region")]
		public string M3BKPL => GetString("BKPL");

		/// <summary>
		/// Description: Bank account name
		/// FieldName: BANA
		/// FieldType: A
		/// Length: 36
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Bank account name")]
		public string M3BANA => GetString("BANA");

		/// <summary>
		/// Description: Currency
		/// FieldName: CUCD
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Currency")]
		public string M3CUCD => GetString("CUCD");

		/// <summary>
		/// Description: Bank account indicator
		/// FieldName: BKIN
		/// FieldType: A
		/// Length: 4
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Bank account indicator")]
		public string M3BKIN => GetString("BKIN");

		/// <summary>
		/// Description: Bank account field 1
		/// FieldName: BAF1
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Bank account field 1")]
		public string M3BAF1 => GetString("BAF1");

		/// <summary>
		/// Description: Bank account field 2
		/// FieldName: BAF2
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Bank account field 2")]
		public string M3BAF2 => GetString("BAF2");

		/// <summary>
		/// Description: Bank account field 3
		/// FieldName: BAF3
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Bank account field 3")]
		public string M3BAF3 => GetString("BAF3");

		/// <summary>
		/// Description: Bank account field 4
		/// FieldName: BAF4
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Bank account field 4")]
		public string M3BAF4 => GetString("BAF4");

		/// <summary>
		/// Description: Bank account field 5
		/// FieldName: BAF5
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Bank account field 5")]
		public string M3BAF5 => GetString("BAF5");

		/// <summary>
		/// Description: Bank EDI agreement number
		/// FieldName: BKAG
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Bank EDI agreement number")]
		public string M3BKAG => GetString("BKAG");

		/// <summary>
		/// Description: Financial institution
		/// FieldName: FINC
		/// FieldType: A
		/// Length: 11
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Financial institution")]
		public string M3FINC => GetString("FINC");

		/// <summary>
		/// Description: Account number at financial institution
		/// FieldName: FIAN
		/// FieldType: A
		/// Length: 25
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Account number at financial institution")]
		public string M3FIAN => GetString("FIAN");

		/// <summary>
		/// Description: Customer number at financial institution
		/// FieldName: FICU
		/// FieldType: A
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Customer number at financial institution")]
		public string M3FICU => GetString("FICU");

		/// <summary>
		/// Description: Branch number
		/// FieldName: BRNO
		/// FieldType: A
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Branch number")]
		public string M3BRNO => GetString("BRNO");

		/// <summary>
		/// Description: Number of lines
		/// FieldName: NCHL
		/// FieldType: N
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Number of lines")]
		public int? M3NCHL => GetNullableInt("NCHL");

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
		/// Description: Language
		/// FieldName: LNCD
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Language")]
		public string M3LNCD => GetString("LNCD");

		/// <summary>
		/// Description: Language check
		/// FieldName: LONC
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Language check")]
		public int? M3LONC => GetNullableInt("LONC");

		/// <summary>
		/// Description: Transfer type
		/// FieldName: PYTK
		/// FieldType: N
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Transfer type")]
		public int? M3PYTK => GetNullableInt("PYTK");

		/// <summary>
		/// Description: Bank fee payment
		/// FieldName: CSTC
		/// FieldType: N
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Bank fee payment")]
		public int? M3CSTC => GetNullableInt("CSTC");

		/// <summary>
		/// Description: International bank account number
		/// FieldName: IBAN
		/// FieldType: A
		/// Length: 34
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("International bank account number")]
		public string M3IBAN => GetString("IBAN");

		/// <summary>
		/// Description: Creditor identifier number
		/// FieldName: CIDN
		/// FieldType: A
		/// Length: 35
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Creditor identifier number")]
		public string M3CIDN => GetString("CIDN");
	}
}
// EOF
