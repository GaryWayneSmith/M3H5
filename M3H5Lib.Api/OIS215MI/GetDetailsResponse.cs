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

namespace M3H5Lib.Api.OIS215MI
{
	public partial class GetDetailsResponse : M3BaseRecord 
	{

		/// <summary>
		/// Description: Facility
		/// FieldName: FACI
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Facility")]
		public string M3_FACI => GetString("FACI");

		/// <summary>
		/// Description: Name
		/// FieldName: FACN
		/// FieldType: A
		/// Length: 30
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Name")]
		public string M3_FACN => GetString("FACN");

		/// <summary>
		/// Description: Extended invoice number
		/// FieldName: EXIN
		/// FieldType: A
		/// Length: 14
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Extended invoice number")]
		public string M3_EXIN => GetString("EXIN");

		/// <summary>
		/// Description: Year
		/// FieldName: YEA4
		/// FieldType: N
		/// Length: 4
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Year")]
		public int? M3_YEA4 => GetNullableInt("YEA4");

		/// <summary>
		/// Description: Voucher number
		/// FieldName: VONO
		/// FieldType: N
		/// Length: 8
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Voucher number")]
		public int? M3_VONO => GetNullableInt("VONO");

		/// <summary>
		/// Description: Payer
		/// FieldName: PYNO
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Payer")]
		public string M3_PYNO => GetString("PYNO");

		/// <summary>
		/// Description: Payer Name
		/// FieldName: PYNT
		/// FieldType: A
		/// Length: 36
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Payer Name")]
		public string M3_PYNT => GetString("PYNT");

		/// <summary>
		/// Description: Customer
		/// FieldName: CUNO
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Customer")]
		public string M3_CUNO => GetString("CUNO");

		/// <summary>
		/// Description: Name
		/// FieldName: CUNM
		/// FieldType: A
		/// Length: 36
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Name")]
		public string M3_CUNM => GetString("CUNM");

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
		/// Description: Invoice reciever name
		/// FieldName: INRT
		/// FieldType: A
		/// Length: 36
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Invoice reciever name")]
		public string M3_INRT => GetString("INRT");

		/// <summary>
		/// Description: Invoice amount - local currency
		/// FieldName: IVAM
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Invoice amount - local currency")]
		public decimal? M3_IVAM => GetNullableDecimal("IVAM");

		/// <summary>
		/// Description: Currency invoice
		/// FieldName: CUIN
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Currency invoice")]
		public string M3_CUIN => GetString("CUIN");

		/// <summary>
		/// Description: Invoice amount - local currency
		/// FieldName: IVLA
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Invoice amount - local currency")]
		public decimal? M3_IVLA => GetNullableDecimal("IVLA");

		/// <summary>
		/// Description: Currency invoice
		/// FieldName: CULI
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Currency invoice")]
		public string M3_CULI => GetString("CULI");

		/// <summary>
		/// Description: Invoice rate
		/// FieldName: RAIN
		/// FieldType: N
		/// Length: 13
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Invoice rate")]
		public decimal? M3_RAIN => GetNullableDecimal("RAIN");

		/// <summary>
		/// Description: Payment amount - foreign currency
		/// FieldName: PMAM
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Payment amount - foreign currency")]
		public decimal? M3_PMAM => GetNullableDecimal("PMAM");

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
		/// Description: Payment amount - local currency
		/// FieldName: PMLA
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Payment amount - local currency")]
		public decimal? M3_PMLA => GetNullableDecimal("PMLA");

		/// <summary>
		/// Description: Currency code - local
		/// FieldName: CULO
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Currency code - local")]
		public string M3_CULO => GetString("CULO");

		/// <summary>
		/// Description: Invoice date
		/// FieldName: IDAT
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Invoice date")]
		public DateTime? M3_IDAT => GetNullableDateTime("IDAT");

		/// <summary>
		/// Description: Due date
		/// FieldName: DUDT
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Due date")]
		public DateTime? M3_DUDT => GetNullableDateTime("DUDT");

		/// <summary>
		/// Description: Accounting date
		/// FieldName: ACDT
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Accounting date")]
		public DateTime? M3_ACDT => GetNullableDateTime("ACDT");

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
		/// Description: Payment date
		/// FieldName: PYDT
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Payment date")]
		public DateTime? M3_PYDT => GetNullableDateTime("PYDT");

		/// <summary>
		/// Description: Information type
		/// FieldName: IVTP
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Information type")]
		public string M3_IVTP => GetString("IVTP");

		/// <summary>
		/// Description: Status - invoice
		/// FieldName: INST
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Status - invoice")]
		public string M3_INST => GetString("INST");

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
		/// Description: Check number
		/// FieldName: CKNO
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Check number")]
		public string M3_CKNO => GetString("CKNO");

		/// <summary>
		/// Description: Voucher text
		/// FieldName: VTXT
		/// FieldType: A
		/// Length: 40
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Voucher text")]
		public string M3_VTXT => GetString("VTXT");

		/// <summary>
		/// Description: Invoice reference number
		/// FieldName: IRNO
		/// FieldType: A
		/// Length: 40
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Invoice reference number")]
		public string M3_IRNO => GetString("IRNO");

		/// <summary>
		/// Description: Cash desk
		/// FieldName: CSHD
		/// FieldType: A
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Cash desk")]
		public string M3_CSHD => GetString("CSHD");

		/// <summary>
		/// Description: Cash desk transaction type
		/// FieldName: TRT6
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Cash desk transaction type")]
		public string M3_TRT6 => GetString("TRT6");

		/// <summary>
		/// Description: 3rd-party ID
		/// FieldName: 3RDI
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("3rd-party ID")]
		public string M3_3RDI => GetString("3RDI");

		/// <summary>
		/// Description: 3rd-party provider
		/// FieldName: 3RDP
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("3rd-party provider")]
		public string M3_3RDP => GetString("3RDP");

		/// <summary>
		/// Description: 3rd party transaction type
		/// FieldName: TRTY
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("3rd party transaction type")]
		public string M3_TRTY => GetString("TRTY");

		/// <summary>
		/// Description: Card type
		/// FieldName: CTPY
		/// FieldType: A
		/// Length: 20
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Card type")]
		public string M3_CTPY => GetString("CTPY");

		/// <summary>
		/// Description: Card number
		/// FieldName: CANU
		/// FieldType: A
		/// Length: 19
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Card number")]
		public string M3_CANU => GetString("CANU");

		/// <summary>
		/// Description: Name on card
		/// FieldName: NOCA
		/// FieldType: A
		/// Length: 36
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Name on card")]
		public string M3_NOCA => GetString("NOCA");
	}
}
// EOF
