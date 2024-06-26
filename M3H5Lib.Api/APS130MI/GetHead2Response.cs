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

namespace M3H5Lib.Api.APS130MI
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
		/// Description: Payment proposal
		/// FieldName: PRPN
		/// FieldType: N
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Payment proposal")]
		public long? M3PRPN => GetNullableLong("PRPN");

		/// <summary>
		/// Description: Payment order
		/// FieldName: PYON
		/// FieldType: N
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Payment order")]
		public int? M3PYON => GetNullableInt("PYON");

		/// <summary>
		/// Description: Payment method - accounts payable
		/// FieldName: PYME
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Payment method - accounts payable")]
		public string M3PYME => GetString("PYME");

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
		/// Description: Transfer method
		/// FieldName: TR25
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Transfer method")]
		public int? M3TR25 => GetNullableInt("TR25");

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
		/// Description: Status - payment
		/// FieldName: PYST
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Status - payment")]
		public int? M3PYST => GetNullableInt("PYST");

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
		/// Description: Foreign currency amount
		/// FieldName: CUAM
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Foreign currency amount")]
		public decimal? M3CUAM => GetNullableDecimal("CUAM");

		/// <summary>
		/// Description: Payment proposal date
		/// FieldName: PRPD
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Payment proposal date")]
		public DateTime? M3PRPD => GetNullableDateTime("PRPD");

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
		/// Description: Foreign/domestic
		/// FieldName: NADO
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Foreign/domestic")]
		public string M3NADO => GetString("NADO");

		/// <summary>
		/// Description: Bank operation
		/// FieldName: BOPC
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Bank operation")]
		public string M3BOPC => GetString("BOPC");

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
		/// Description: Currency - bank account
		/// FieldName: BCUC
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Currency - bank account")]
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
		/// Description: Intermediary - Bank account description
		/// FieldName: IBBD
		/// FieldType: A
		/// Length: 36
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Intermediary - Bank account description")]
		public string M3IBBD => GetString("IBBD");

		/// <summary>
		/// Description: Intermediary - Bank number
		/// FieldName: IBBN
		/// FieldType: A
		/// Length: 8
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Intermediary - Bank number")]
		public string M3IBBN => GetString("IBBN");

		/// <summary>
		/// Description: Intermediary - Bank branch ID
		/// FieldName: IBBB
		/// FieldType: A
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Intermediary - Bank branch ID")]
		public string M3IBBB => GetString("IBBB");

		/// <summary>
		/// Description: Intermediary - SWIFT/BIC code
		/// FieldName: IBSW
		/// FieldType: A
		/// Length: 34
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Intermediary - SWIFT/BIC code")]
		public string M3IBSW => GetString("IBSW");

		/// <summary>
		/// Description: Intermediary - Clearing system ID
		/// FieldName: IBSI
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Intermediary - Clearing system ID")]
		public string M3IBSI => GetString("IBSI");

		/// <summary>
		/// Description: Intermediary - Clearing system number
		/// FieldName: IBSN
		/// FieldType: A
		/// Length: 20
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Intermediary - Clearing system number")]
		public string M3IBSN => GetString("IBSN");

		/// <summary>
		/// Description: Intermediary - international bank acc no
		/// FieldName: IBIB
		/// FieldType: A
		/// Length: 34
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Intermediary - international bank acc no")]
		public string M3IBIB => GetString("IBIB");

		/// <summary>
		/// Description: Intermediary - Bank account number
		/// FieldName: IBCN
		/// FieldType: A
		/// Length: 35
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Intermediary - Bank account number")]
		public string M3IBCN => GetString("IBCN");

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
		/// Description: End to end ID
		/// FieldName: ETEI
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("End to end ID")]
		public int? M3ETEI => GetNullableInt("ETEI");

		/// <summary>
		/// Description: Instruction ID
		/// FieldName: INID
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Instruction ID")]
		public int? M3INID => GetNullableInt("INID");

		/// <summary>
		/// Description: Payment information
		/// FieldName: PYIN
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Payment information")]
		public int? M3PYIN => GetNullableInt("PYIN");

		/// <summary>
		/// Description: Payment transfer code
		/// FieldName: PYTC
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Payment transfer code")]
		public string M3PYTC => GetString("PYTC");

		/// <summary>
		/// Description: Structured creditor reference
		/// FieldName: SCRA
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Structured creditor reference")]
		public int? M3SCRA => GetNullableInt("SCRA");

		/// <summary>
		/// Description: Batch booking indicator
		/// FieldName: BBIN
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Batch booking indicator")]
		public int? M3BBIN => GetNullableInt("BBIN");

		/// <summary>
		/// Description: Service level code
		/// FieldName: SLVC
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Service level code")]
		public int? M3SLVC => GetNullableInt("SLVC");

		/// <summary>
		/// Description: Service level code - standard
		/// FieldName: SLCS
		/// FieldType: A
		/// Length: 4
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Service level code - standard")]
		public string M3SLCS => GetString("SLCS");

		/// <summary>
		/// Description: Service level code - exception
		/// FieldName: SLCE
		/// FieldType: A
		/// Length: 4
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Service level code - exception")]
		public string M3SLCE => GetString("SLCE");

		/// <summary>
		/// Description: Check digit method for bank account
		/// FieldName: CMBN
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Check digit method for bank account")]
		public string M3CMBN => GetString("CMBN");
	}
}
// EOF
