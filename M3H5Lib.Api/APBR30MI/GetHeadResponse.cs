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

namespace M3H5Lib.Api.APBR30MI
{
	public partial class GetHeadResponse : M3BaseRecord 
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
		/// Description: Payment proposal
		/// FieldName: PRPN
		/// FieldType: N
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Payment proposal")]
		public long? M3_PRPN => GetNullableLong("PRPN");

		/// <summary>
		/// Description: Payment order
		/// FieldName: PYON
		/// FieldType: N
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Payment order")]
		public int? M3_PYON => GetNullableInt("PYON");

		/// <summary>
		/// Description: Payment method - accounts payable
		/// FieldName: PYME
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Payment method - accounts payable")]
		public string M3_PYME => GetString("PYME");

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
		/// Description: Quotas used
		/// FieldName: QUSD
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Quotas used")]
		public int? M3_QUSD => GetNullableInt("QUSD");

		/// <summary>
		/// Description: Status - payment
		/// FieldName: PYST
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Status - payment")]
		public int? M3_PYST => GetNullableInt("PYST");

		/// <summary>
		/// Description: Foreign currency amount
		/// FieldName: CUAM
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Foreign currency amount")]
		public decimal? M3_CUAM => GetNullableDecimal("CUAM");

		/// <summary>
		/// Description: Payment proposal date
		/// FieldName: PRPD
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Payment proposal date")]
		public DateTime? M3_PRPD => GetNullableDateTime("PRPD");

		/// <summary>
		/// Description: Number of payments
		/// FieldName: NOPD
		/// FieldType: N
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Number of payments")]
		public int? M3_NOPD => GetNullableInt("NOPD");

		/// <summary>
		/// Description: Foreign/domestic
		/// FieldName: NADO
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Foreign/domestic")]
		public string M3_NADO => GetString("NADO");

		/// <summary>
		/// Description: Grouped payment
		/// FieldName: GRPP
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Grouped payment")]
		public int? M3_GRPP => GetNullableInt("GRPP");

		/// <summary>
		/// Description: Transfer method
		/// FieldName: TR25
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Transfer method")]
		public int? M3_TR25 => GetNullableInt("TR25");

		/// <summary>
		/// Description: Bank operation
		/// FieldName: BOPC
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Bank operation")]
		public string M3_BOPC => GetString("BOPC");

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
		/// Description: Accounting dimension 1
		/// FieldName: AIT1
		/// FieldType: A
		/// Length: 8
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Accounting dimension 1")]
		public string M3_AIT1 => GetString("AIT1");

		/// <summary>
		/// Description: Accounting dimension 2
		/// FieldName: AIT2
		/// FieldType: A
		/// Length: 8
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Accounting dimension 2")]
		public string M3_AIT2 => GetString("AIT2");

		/// <summary>
		/// Description: Accounting dimension 3
		/// FieldName: AIT3
		/// FieldType: A
		/// Length: 8
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Accounting dimension 3")]
		public string M3_AIT3 => GetString("AIT3");

		/// <summary>
		/// Description: Accounting dimension 4
		/// FieldName: AIT4
		/// FieldType: A
		/// Length: 8
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Accounting dimension 4")]
		public string M3_AIT4 => GetString("AIT4");

		/// <summary>
		/// Description: Accounting dimension 5
		/// FieldName: AIT5
		/// FieldType: A
		/// Length: 8
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Accounting dimension 5")]
		public string M3_AIT5 => GetString("AIT5");

		/// <summary>
		/// Description: Accounting dimension 6
		/// FieldName: AIT6
		/// FieldType: A
		/// Length: 8
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Accounting dimension 6")]
		public string M3_AIT6 => GetString("AIT6");

		/// <summary>
		/// Description: Accounting dimension 7
		/// FieldName: AIT7
		/// FieldType: A
		/// Length: 8
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Accounting dimension 7")]
		public string M3_AIT7 => GetString("AIT7");

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
		/// Description: Length - bank account identity field 1
		/// FieldName: BIL1
		/// FieldType: N
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Length - bank account identity field 1")]
		public int? M3_BIL1 => GetNullableInt("BIL1");

		/// <summary>
		/// Description: Length - bank account identity field 2
		/// FieldName: BIL2
		/// FieldType: N
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Length - bank account identity field 2")]
		public int? M3_BIL2 => GetNullableInt("BIL2");

		/// <summary>
		/// Description: Length - bank account identity field 3
		/// FieldName: BIL3
		/// FieldType: N
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Length - bank account identity field 3")]
		public int? M3_BIL3 => GetNullableInt("BIL3");

		/// <summary>
		/// Description: Length - bank account identity field 4
		/// FieldName: BIL4
		/// FieldType: N
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Length - bank account identity field 4")]
		public int? M3_BIL4 => GetNullableInt("BIL4");

		/// <summary>
		/// Description: Length - bank account identity field 5
		/// FieldName: BIL5
		/// FieldType: N
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Length - bank account identity field 5")]
		public int? M3_BIL5 => GetNullableInt("BIL5");

		/// <summary>
		/// Description: Numeric field 1 position
		/// FieldName: NUM1
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Numeric field 1 position")]
		public int? M3_NUM1 => GetNullableInt("NUM1");

		/// <summary>
		/// Description: Numeric field 1 position
		/// FieldName: NUM2
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Numeric field 1 position")]
		public int? M3_NUM2 => GetNullableInt("NUM2");

		/// <summary>
		/// Description: Numeric field 1 position
		/// FieldName: NUM3
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Numeric field 1 position")]
		public int? M3_NUM3 => GetNullableInt("NUM3");

		/// <summary>
		/// Description: Numeric field 1 position
		/// FieldName: NUM4
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Numeric field 1 position")]
		public int? M3_NUM4 => GetNullableInt("NUM4");

		/// <summary>
		/// Description: Numeric field 1 position
		/// FieldName: NUM5
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Numeric field 1 position")]
		public int? M3_NUM5 => GetNullableInt("NUM5");

		/// <summary>
		/// Description: Bank account identity
		/// FieldName: PBNK
		/// FieldType: A
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Bank account identity")]
		public string M3_PBNK => GetString("PBNK");

		/// <summary>
		/// Description: Bank number 2
		/// FieldName: BKN2
		/// FieldType: A
		/// Length: 8
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Bank number 2")]
		public string M3_BKN2 => GetString("BKN2");

		/// <summary>
		/// Description: Bank account 2 field 1
		/// FieldName: BA21
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Bank account 2 field 1")]
		public string M3_BA21 => GetString("BA21");

		/// <summary>
		/// Description: Bank account 2 field 2
		/// FieldName: BA22
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Bank account 2 field 2")]
		public string M3_BA22 => GetString("BA22");

		/// <summary>
		/// Description: Bank account 2 field 3
		/// FieldName: BA23
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Bank account 2 field 3")]
		public string M3_BA23 => GetString("BA23");

		/// <summary>
		/// Description: Bank account 2 field 4
		/// FieldName: BA24
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Bank account 2 field 4")]
		public string M3_BA24 => GetString("BA24");

		/// <summary>
		/// Description: Bank account 2 field 5
		/// FieldName: BA25
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Bank account 2 field 5")]
		public string M3_BA25 => GetString("BA25");

		/// <summary>
		/// Description: Currency code 2
		/// FieldName: CUC2
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Currency code 2")]
		public string M3_CUC2 => GetString("CUC2");

		/// <summary>
		/// Description: AWV report
		/// FieldName: AWVR
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("AWV report")]
		public int? M3_AWVR => GetNullableInt("AWVR");

		/// <summary>
		/// Description: Report key
		/// FieldName: REPK
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Report key")]
		public int? M3_REPK => GetNullableInt("REPK");

		/// <summary>
		/// Description: Currency code - payment
		/// FieldName: CUCP
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Currency code - payment")]
		public string M3_CUCP => GetString("CUCP");

		/// <summary>
		/// Description: Agreement Number
		/// FieldName: XAGN
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Agreement Number")]
		public string M3_XAGN => GetString("XAGN");

		/// <summary>
		/// Description: Company Code - Header AP
		/// FieldName: XCHA
		/// FieldType: A
		/// Length: 20
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Company Code - Header AP")]
		public string M3_XCHA => GetString("XCHA");

		/// <summary>
		/// Description: Company Code - Line AP
		/// FieldName: XCLA
		/// FieldType: A
		/// Length: 20
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Company Code - Line AP")]
		public string M3_XCLA => GetString("XCLA");

		/// <summary>
		/// Description: Bank Code
		/// FieldName: XBKC
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Bank Code")]
		public string M3_XBKC => GetString("XBKC");

		/// <summary>
		/// Description: Bank Name
		/// FieldName: XBKN
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Bank Name")]
		public string M3_XBKN => GetString("XBKN");

		/// <summary>
		/// Description: Postal code
		/// FieldName: PONO
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Postal code")]
		public string M3_PONO => GetString("PONO");

		/// <summary>
		/// Description: CNPJ / CPF
		/// FieldName: CNPJ
		/// FieldType: N
		/// Length: 14
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("CNPJ / CPF")]
		public decimal? M3_CNPJ => GetNullableDecimal("CNPJ");

		/// <summary>
		/// Description: Federation Unit
		/// FieldName: FEDA
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Federation Unit")]
		public string M3_FEDA => GetString("FEDA");
	}
}
// EOF
