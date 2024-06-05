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

namespace M3H5Lib.Api.ARBR01MI
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
		/// Description: Remittance number
		/// FieldName: RMNB
		/// FieldType: N
		/// Length: 6
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Remittance number")]
		public int? M3_RMNB => GetNullableInt("RMNB");

		/// <summary>
		/// Description: Payment type
		/// FieldName: PYTP
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Payment type")]
		public string M3_PYTP => GetString("PYTP");

		/// <summary>
		/// Description: Bank account identity
		/// FieldName: BKI2
		/// FieldType: A
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Bank account identity")]
		public string M3_BKI2 => GetString("BKI2");

		/// <summary>
		/// Description: Status - remittance
		/// FieldName: RSTA
		/// FieldType: N
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Status - remittance")]
		public int? M3_RSTA => GetNullableInt("RSTA");

		/// <summary>
		/// Description: Remittance type
		/// FieldName: RMTY
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Remittance type")]
		public int? M3_RMTY => GetNullableInt("RMTY");

		/// <summary>
		/// Description: Remittance amount in local currency
		/// FieldName: RMTA
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Remittance amount in local currency")]
		public decimal? M3_RMTA => GetNullableDecimal("RMTA");

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
		/// Description: Remittance amount in foreign currency
		/// FieldName: RMTC
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Remittance amount in foreign currency")]
		public decimal? M3_RMTC => GetNullableDecimal("RMTC");

		/// <summary>
		/// Description: Remittance date
		/// FieldName: RMDA
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Remittance date")]
		public DateTime? M3_RMDA => GetNullableDateTime("RMDA");

		/// <summary>
		/// Description: Bank fee
		/// FieldName: RMCH
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Bank fee")]
		public decimal? M3_RMCH => GetNullableDecimal("RMCH");

		/// <summary>
		/// Description: Bank interest amount
		/// FieldName: RMIN
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Bank interest amount")]
		public decimal? M3_RMIN => GetNullableDecimal("RMIN");

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
		/// Description: Splitted by region
		/// FieldName: BKSR
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Splitted by region")]
		public int? M3_BKSR => GetNullableInt("BKSR");

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
		/// Description: Company Name
		/// FieldName: CONM
		/// FieldType: A
		/// Length: 36
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Company Name")]
		public string M3_CONM => GetString("CONM");

		/// <summary>
		/// Description: Company Address 1
		/// FieldName: COA1
		/// FieldType: A
		/// Length: 36
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Company Address 1")]
		public string M3_COA1 => GetString("COA1");

		/// <summary>
		/// Description: Company Address 2
		/// FieldName: COA2
		/// FieldType: A
		/// Length: 36
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Company Address 2")]
		public string M3_COA2 => GetString("COA2");

		/// <summary>
		/// Description: Company Address 3
		/// FieldName: COA3
		/// FieldType: A
		/// Length: 36
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Company Address 3")]
		public string M3_COA3 => GetString("COA3");

		/// <summary>
		/// Description: Company Address 4
		/// FieldName: COA4
		/// FieldType: A
		/// Length: 36
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Company Address 4")]
		public string M3_COA4 => GetString("COA4");

		/// <summary>
		/// Description: Postal Code
		/// FieldName: PONO
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Postal Code")]
		public string M3_PONO => GetString("PONO");

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

		/// <summary>
		/// Description: CNPJ
		/// FieldName: CNPJ
		/// FieldType: N
		/// Length: 14
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("CNPJ")]
		public decimal? M3_CNPJ => GetNullableDecimal("CNPJ");

		/// <summary>
		/// Description: Bank name
		/// FieldName: BKNM
		/// FieldType: A
		/// Length: 36
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Bank name")]
		public string M3_BKNM => GetString("BKNM");

		/// <summary>
		/// Description: Bank address 1
		/// FieldName: BKA1
		/// FieldType: A
		/// Length: 36
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Bank address 1")]
		public string M3_BKA1 => GetString("BKA1");

		/// <summary>
		/// Description: Bank address 2
		/// FieldName: BKA2
		/// FieldType: A
		/// Length: 36
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Bank address 2")]
		public string M3_BKA2 => GetString("BKA2");

		/// <summary>
		/// Description: Bank address 3
		/// FieldName: BKA3
		/// FieldType: A
		/// Length: 36
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Bank address 3")]
		public string M3_BKA3 => GetString("BKA3");

		/// <summary>
		/// Description: Bank address 4
		/// FieldName: BKA4
		/// FieldType: A
		/// Length: 36
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Bank address 4")]
		public string M3_BKA4 => GetString("BKA4");

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
		/// Description: Type of invoice
		/// FieldName: XINT
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Type of invoice")]
		public string M3_XINT => GetString("XINT");

		/// <summary>
		/// Description: Type of Debit Note
		/// FieldName: XTDN
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Type of Debit Note")]
		public string M3_XTDN => GetString("XTDN");

		/// <summary>
		/// Description: Company Code - Header AR
		/// FieldName: XCCH
		/// FieldType: A
		/// Length: 20
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Company Code - Header AR")]
		public string M3_XCCH => GetString("XCCH");

		/// <summary>
		/// Description: Company Code - Line AR
		/// FieldName: XCCL
		/// FieldType: A
		/// Length: 20
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Company Code - Line AR")]
		public string M3_XCCL => GetString("XCCL");

		/// <summary>
		/// Description: Portfolio code
		/// FieldName: XPOC
		/// FieldType: A
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Portfolio code")]
		public string M3_XPOC => GetString("XPOC");

		/// <summary>
		/// Description: First Instruction
		/// FieldName: XFIN
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("First Instruction")]
		public string M3_XFIN => GetString("XFIN");

		/// <summary>
		/// Description: Second Instruction
		/// FieldName: XSIN
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Second Instruction")]
		public string M3_XSIN => GetString("XSIN");

		/// <summary>
		/// Description: Third Instruction
		/// FieldName: XTIN
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Third Instruction")]
		public string M3_XTIN => GetString("XTIN");

		/// <summary>
		/// Description: Currency code
		/// FieldName: XCUC
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Currency code")]
		public string M3_XCUC => GetString("XCUC");

		/// <summary>
		/// Description: Days to protest
		/// FieldName: XDTP
		/// FieldType: N
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Days to protest")]
		public int? M3_XDTP => GetNullableInt("XDTP");

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
		/// Description: Bank Status Code
		/// FieldName: XBSC
		/// FieldType: N
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Bank Status Code")]
		public int? M3_XBSC => GetNullableInt("XBSC");

		/// <summary>
		/// Description: File Code
		/// FieldName: XFCO
		/// FieldType: N
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("File Code")]
		public int? M3_XFCO => GetNullableInt("XFCO");

		/// <summary>
		/// Description: File Identity
		/// FieldName: XFID
		/// FieldType: A
		/// Length: 7
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("File Identity")]
		public string M3_XFID => GetString("XFID");
	}
}
// EOF
