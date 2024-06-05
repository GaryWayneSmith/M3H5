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

namespace M3H5Lib.Api.ARS300MI
{
	public partial class GetHead2Response : M3BaseRecord 
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
		public string M3DIVI => GetString("DIVI");

		/// <summary>
		/// Description: Remittance number
		/// FieldName: RMNB
		/// FieldType: N
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Remittance number")]
		public int? M3RMNB => GetNullableInt("RMNB");

		/// <summary>
		/// Description: Payment type
		/// FieldName: PYTP
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Payment type")]
		public string M3PYTP => GetString("PYTP");

		/// <summary>
		/// Description: Payment class
		/// FieldName: PYCL
		/// FieldType: N
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Payment class")]
		public int? M3PYCL => GetNullableInt("PYCL");

		/// <summary>
		/// Description: Grouped payment
		/// FieldName: GRPP
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Grouped payment")]
		public int? M3GRPP => GetNullableInt("GRPP");

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
		/// Description: Quotas used
		/// FieldName: QUSD
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Quotas used")]
		public int? M3QUSD => GetNullableInt("QUSD");

		/// <summary>
		/// Description: Status - remittance
		/// FieldName: RSTA
		/// FieldType: N
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Status - remittance")]
		public int? M3RSTA => GetNullableInt("RSTA");

		/// <summary>
		/// Description: Remittance type
		/// FieldName: RMTY
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Remittance type")]
		public int? M3RMTY => GetNullableInt("RMTY");

		/// <summary>
		/// Description: Action
		/// FieldName: ACTO
		/// FieldType: N
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Action")]
		public int? M3ACTO => GetNullableInt("ACTO");

		/// <summary>
		/// Description: Remittance amount in foreign currency
		/// FieldName: RMTC
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Remittance amount in foreign currency")]
		public decimal? M3RMTC => GetNullableDecimal("RMTC");

		/// <summary>
		/// Description: Remittance amount in local currency
		/// FieldName: RMTA
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Remittance amount in local currency")]
		public decimal? M3RMTA => GetNullableDecimal("RMTA");

		/// <summary>
		/// Description: Remittance date
		/// FieldName: RMDA
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Remittance date")]
		public DateTime? M3RMDA => GetNullableDateTime("RMDA");

		/// <summary>
		/// Description: Number of payments
		/// FieldName: NOPD
		/// FieldType: N
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Number of payments")]
		public int? M3NOPD => GetNullableInt("NOPD");

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
		/// Description: Yes/no
		/// FieldName: BKSR
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Yes/no")]
		public int? M3BKSR => GetNullableInt("BKSR");

		/// <summary>
		/// Description: Bank fee
		/// FieldName: RMCH
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Bank fee")]
		public decimal? M3RMCH => GetNullableDecimal("RMCH");

		/// <summary>
		/// Description: Bank interest amount
		/// FieldName: RMIN
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Bank interest amount")]
		public decimal? M3RMIN => GetNullableDecimal("RMIN");

		/// <summary>
		/// Description: Bank account identity
		/// FieldName: BKI2
		/// FieldType: A
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Bank account identity")]
		public string M3BKI2 => GetString("BKI2");

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
		/// Description: Currency - Bank account
		/// FieldName: BCUC
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Currency - Bank account")]
		public string M3BCUC => GetString("BCUC");

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
		/// Description: Creditor identifier number
		/// FieldName: CIDN
		/// FieldType: A
		/// Length: 35
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Creditor identifier number")]
		public string M3CIDN => GetString("CIDN");

		/// <summary>
		/// Description: SWIFT/BIC code
		/// FieldName: SWBI
		/// FieldType: A
		/// Length: 34
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("SWIFT/BIC code")]
		public string M3SWBI => GetString("SWBI");

		/// <summary>
		/// Description: Clearing system ID
		/// FieldName: CLSI
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Clearing system ID")]
		public string M3CLSI => GetString("CLSI");

		/// <summary>
		/// Description: Clearing system number
		/// FieldName: CLSN
		/// FieldType: A
		/// Length: 20
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Clearing system number")]
		public string M3CLSN => GetString("CLSN");

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
		/// Description: Bank account number
		/// FieldName: BACN
		/// FieldType: A
		/// Length: 35
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Bank account number")]
		public string M3BACN => GetString("BACN");

		/// <summary>
		/// Description: Category purpose code
		/// FieldName: CPCO
		/// FieldType: A
		/// Length: 4
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Category purpose code")]
		public string M3CPCO => GetString("CPCO");

		/// <summary>
		/// Description: Payment purpose code
		/// FieldName: PPCO
		/// FieldType: A
		/// Length: 4
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Payment purpose code")]
		public string M3PPCO => GetString("PPCO");

		/// <summary>
		/// Description: Priority code
		/// FieldName: PITY
		/// FieldType: N
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Priority code")]
		public int? M3PITY => GetNullableInt("PITY");

		/// <summary>
		/// Description: Charge bearer code
		/// FieldName: CBCD
		/// FieldType: N
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Charge bearer code")]
		public int? M3CBCD => GetNullableInt("CBCD");

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
		/// Description: Electronic format
		/// FieldName: ELET
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Electronic format")]
		public string M3ELET => GetString("ELET");

		/// <summary>
		/// Description: Document
		/// FieldName: DOCU
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Document")]
		public string M3DOCU => GetString("DOCU");

		/// <summary>
		/// Description: Direct debit scheme
		/// FieldName: SDDS
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Direct debit scheme")]
		public int? M3SDDS => GetNullableInt("SDDS");

		/// <summary>
		/// Description: Electronic group code
		/// FieldName: GRP2
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Electronic group code")]
		public int? M3GRP2 => GetNullableInt("GRP2");
	}
}
// EOF
