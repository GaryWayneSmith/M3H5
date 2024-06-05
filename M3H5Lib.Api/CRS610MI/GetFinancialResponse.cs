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

namespace M3H5Lib.Api.CRS610MI
{
	public partial class GetFinancialResponse : M3BaseRecord 
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
		/// Description: Customer number
		/// FieldName: CUNO
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Customer number")]
		public string M3_CUNO => GetString("CUNO");

		/// <summary>
		/// Description: Customer name
		/// FieldName: CUNM
		/// FieldType: A
		/// Length: 36
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Customer name")]
		public string M3_CUNM => GetString("CUNM");

		/// <summary>
		/// Description: Organization number 1
		/// FieldName: CORG
		/// FieldType: A
		/// Length: 11
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Organization number 1")]
		public string M3_CORG => GetString("CORG");

		/// <summary>
		/// Description: Organization number 2
		/// FieldName: COR2
		/// FieldType: A
		/// Length: 11
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Organization number 2")]
		public string M3_COR2 => GetString("COR2");

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
		/// Description: Credit limit 1 - max overdue invoices
		/// FieldName: CRLM
		/// FieldType: N
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Credit limit 1 - max overdue invoices")]
		public decimal? M3_CRLM => GetNullableDecimal("CRLM");

		/// <summary>
		/// Description: Credit limit 2 - max out.invoices
		/// FieldName: CRL2
		/// FieldType: N
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Credit limit 2 - max out.invoices")]
		public decimal? M3_CRL2 => GetNullableDecimal("CRL2");

		/// <summary>
		/// Description: Credit limit 3 - max out.invoices + ord.
		/// FieldName: CRL3
		/// FieldType: N
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Credit limit 3 - max out.invoices + ord.")]
		public decimal? M3_CRL3 => GetNullableDecimal("CRL3");

		/// <summary>
		/// Description: Credit limit 4 - max days on invoices
		/// FieldName: ODUD
		/// FieldType: N
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Credit limit 4 - max days on invoices")]
		public int? M3_ODUD => GetNullableInt("ODUD");

		/// <summary>
		/// Description: Overdue invoice amount
		/// FieldName: TDIN
		/// FieldType: N
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Overdue invoice amount")]
		public decimal? M3_TDIN => GetNullableDecimal("TDIN");

		/// <summary>
		/// Description: Insurance company
		/// FieldName: INCO
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Insurance company")]
		public string M3_INCO => GetString("INCO");

		/// <summary>
		/// Description: Insurance number
		/// FieldName: INSN
		/// FieldType: A
		/// Length: 20
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Insurance number")]
		public string M3_INSN => GetString("INSN");

		/// <summary>
		/// Description: Insurance limit
		/// FieldName: INLI
		/// FieldType: N
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Insurance limit")]
		public decimal? M3_INLI => GetNullableDecimal("INLI");

		/// <summary>
		/// Description: Payer - post giro
		/// FieldName: AGPY
		/// FieldType: A
		/// Length: 18
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Payer - post giro")]
		public string M3_AGPY => GetString("AGPY");

		/// <summary>
		/// Description: Clearing number -  post giro
		/// FieldName: AGCP
		/// FieldType: A
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Clearing number -  post giro")]
		public string M3_AGCP => GetString("AGCP");

		/// <summary>
		/// Description: Account number - post giro
		/// FieldName: AGAC
		/// FieldType: A
		/// Length: 12
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Account number - post giro")]
		public string M3_AGAC => GetString("AGAC");

		/// <summary>
		/// Description: Payer - bank giro
		/// FieldName: AGBP
		/// FieldType: A
		/// Length: 18
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Payer - bank giro")]
		public string M3_AGBP => GetString("AGBP");

		/// <summary>
		/// Description: Clearing number - bank giro
		/// FieldName: AGLB
		/// FieldType: A
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Clearing number - bank giro")]
		public string M3_AGLB => GetString("AGLB");

		/// <summary>
		/// Description: Account number - bank giro
		/// FieldName: AACB
		/// FieldType: A
		/// Length: 12
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Account number - bank giro")]
		public string M3_AACB => GetString("AACB");

		/// <summary>
		/// Description: Bank giro number
		/// FieldName: AGBG
		/// FieldType: N
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Bank giro number")]
		public long? M3_AGBG => GetNullableLong("AGBG");

		/// <summary>
		/// Description: Post giro number
		/// FieldName: AGPG
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Post giro number")]
		public string M3_AGPG => GetString("AGPG");

		/// <summary>
		/// Description: Tax applicable
		/// FieldName: TXAP
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Tax applicable")]
		public int? M3_TXAP => GetNullableInt("TXAP");

		/// <summary>
		/// Description: Change date for customer
		/// FieldName: LMDT
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Change date for customer")]
		public DateTime? M3_LMDT => GetNullableDateTime("LMDT");

		/// <summary>
		/// Description: Geographical code
		/// FieldName: GEOC
		/// FieldType: N
		/// Length: 9
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Geographical code")]
		public int? M3_GEOC => GetNullableInt("GEOC");

		/// <summary>
		/// Description: Tax exemption contract number
		/// FieldName: TECN
		/// FieldType: A
		/// Length: 20
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Tax exemption contract number")]
		public string M3_TECN => GetString("TECN");

		/// <summary>
		/// Description: Tax exemption expiry date
		/// FieldName: TEEC
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Tax exemption expiry date")]
		public DateTime? M3_TEEC => GetNullableDateTime("TEEC");

		/// <summary>
		/// Description: Tax code
		/// FieldName: TAXC
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Tax code")]
		public string M3_TAXC => GetString("TAXC");

		/// <summary>
		/// Description: Invoice recipient
		/// FieldName: INRC
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Invoice recipient")]
		public string M3_INRC => GetString("INRC");

		/// <summary>
		/// Description: Customer stop
		/// FieldName: BLCD
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Customer stop")]
		public int? M3_BLCD => GetNullableInt("BLCD");

		/// <summary>
		/// Description: Exchange rate type
		/// FieldName: CRTP
		/// FieldType: N
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Exchange rate type")]
		public int? M3_CRTP => GetNullableInt("CRTP");

		/// <summary>
		/// Description: Cash discount term
		/// FieldName: TECD
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Cash discount term")]
		public string M3_TECD => GetString("TECD");

		/// <summary>
		/// Description: Credit department reference
		/// FieldName: CDRC
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Credit department reference")]
		public string M3_CDRC => GetString("CDRC");

		/// <summary>
		/// Description: Payment method AR
		/// FieldName: PYCD
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Payment method AR")]
		public string M3_PYCD => GetString("PYCD");

		/// <summary>
		/// Description: Outstanding invoice amount
		/// FieldName: TOIN
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Outstanding invoice amount")]
		public decimal? M3_TOIN => GetNullableDecimal("TOIN");

		/// <summary>
		/// Description: Order value not invoiced
		/// FieldName: TBLG
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Order value not invoiced")]
		public decimal? M3_TBLG => GetNullableDecimal("TBLG");

		/// <summary>
		/// Description: Number of overdue days
		/// FieldName: ODUE
		/// FieldType: N
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Number of overdue days")]
		public int? M3_ODUE => GetNullableInt("ODUE");

		/// <summary>
		/// Description: Collection
		/// FieldName: CLCD
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Collection")]
		public int? M3_CLCD => GetNullableInt("CLCD");

		/// <summary>
		/// Description: Payment reminder code
		/// FieldName: BLPR
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Payment reminder code")]
		public int? M3_BLPR => GetNullableInt("BLPR");

		/// <summary>
		/// Description: Payment reminder rule
		/// FieldName: RMCT
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Payment reminder rule")]
		public string M3_RMCT => GetString("RMCT");

		/// <summary>
		/// Description: Advice code
		/// FieldName: BLAC
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Advice code")]
		public int? M3_BLAC => GetNullableInt("BLAC");

		/// <summary>
		/// Description: Advice rule
		/// FieldName: ADCA
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Advice rule")]
		public string M3_ADCA => GetString("ADCA");

		/// <summary>
		/// Description: Payment instruction
		/// FieldName: PYDI
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Payment instruction")]
		public string M3_PYDI => GetString("PYDI");

		/// <summary>
		/// Description: Company group customer number
		/// FieldName: CCUS
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Company group customer number")]
		public string M3_CCUS => GetString("CCUS");

		/// <summary>
		/// Description: Statement rule
		/// FieldName: STMR
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Statement rule")]
		public string M3_STMR => GetString("STMR");

		/// <summary>
		/// Description: Interest invoicing
		/// FieldName: BLII
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Interest invoicing")]
		public int? M3_BLII => GetNullableInt("BLII");

		/// <summary>
		/// Description: Interest rule
		/// FieldName: IICT
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Interest rule")]
		public string M3_IICT => GetString("IICT");
	}
}
// EOF
