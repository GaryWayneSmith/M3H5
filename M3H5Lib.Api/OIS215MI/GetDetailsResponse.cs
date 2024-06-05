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
		public string M3FACI => GetString("FACI");

		/// <summary>
		/// Description: Name
		/// FieldName: FACN
		/// FieldType: A
		/// Length: 30
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Name")]
		public string M3FACN => GetString("FACN");

		/// <summary>
		/// Description: Extended invoice number
		/// FieldName: EXIN
		/// FieldType: A
		/// Length: 14
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Extended invoice number")]
		public string M3EXIN => GetString("EXIN");

		/// <summary>
		/// Description: Year
		/// FieldName: YEA4
		/// FieldType: N
		/// Length: 4
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Year")]
		public int? M3YEA4 => GetNullableInt("YEA4");

		/// <summary>
		/// Description: Voucher number
		/// FieldName: VONO
		/// FieldType: N
		/// Length: 8
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Voucher number")]
		public int? M3VONO => GetNullableInt("VONO");

		/// <summary>
		/// Description: Payer
		/// FieldName: PYNO
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Payer")]
		public string M3PYNO => GetString("PYNO");

		/// <summary>
		/// Description: Payer Name
		/// FieldName: PYNT
		/// FieldType: A
		/// Length: 36
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Payer Name")]
		public string M3PYNT => GetString("PYNT");

		/// <summary>
		/// Description: Customer
		/// FieldName: CUNO
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Customer")]
		public string M3CUNO => GetString("CUNO");

		/// <summary>
		/// Description: Name
		/// FieldName: CUNM
		/// FieldType: A
		/// Length: 36
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Name")]
		public string M3CUNM => GetString("CUNM");

		/// <summary>
		/// Description: Invoice recipient
		/// FieldName: INRC
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Invoice recipient")]
		public string M3INRC => GetString("INRC");

		/// <summary>
		/// Description: Invoice reciever name
		/// FieldName: INRT
		/// FieldType: A
		/// Length: 36
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Invoice reciever name")]
		public string M3INRT => GetString("INRT");

		/// <summary>
		/// Description: Invoice amount - local currency
		/// FieldName: IVAM
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Invoice amount - local currency")]
		public decimal? M3IVAM => GetNullableDecimal("IVAM");

		/// <summary>
		/// Description: Currency invoice
		/// FieldName: CUIN
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Currency invoice")]
		public string M3CUIN => GetString("CUIN");

		/// <summary>
		/// Description: Invoice amount - local currency
		/// FieldName: IVLA
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Invoice amount - local currency")]
		public decimal? M3IVLA => GetNullableDecimal("IVLA");

		/// <summary>
		/// Description: Currency invoice
		/// FieldName: CULI
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Currency invoice")]
		public string M3CULI => GetString("CULI");

		/// <summary>
		/// Description: Invoice rate
		/// FieldName: RAIN
		/// FieldType: N
		/// Length: 13
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Invoice rate")]
		public decimal? M3RAIN => GetNullableDecimal("RAIN");

		/// <summary>
		/// Description: Payment amount - foreign currency
		/// FieldName: PMAM
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Payment amount - foreign currency")]
		public decimal? M3PMAM => GetNullableDecimal("PMAM");

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
		/// Description: Payment amount - local currency
		/// FieldName: PMLA
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Payment amount - local currency")]
		public decimal? M3PMLA => GetNullableDecimal("PMLA");

		/// <summary>
		/// Description: Currency code - local
		/// FieldName: CULO
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Currency code - local")]
		public string M3CULO => GetString("CULO");

		/// <summary>
		/// Description: Invoice date
		/// FieldName: IDAT
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Invoice date")]
		public DateTime? M3IDAT => GetNullableDateTime("IDAT");

		/// <summary>
		/// Description: Due date
		/// FieldName: DUDT
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Due date")]
		public DateTime? M3DUDT => GetNullableDateTime("DUDT");

		/// <summary>
		/// Description: Accounting date
		/// FieldName: ACDT
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Accounting date")]
		public DateTime? M3ACDT => GetNullableDateTime("ACDT");

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
		/// Description: Payment date
		/// FieldName: PYDT
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Payment date")]
		public DateTime? M3PYDT => GetNullableDateTime("PYDT");

		/// <summary>
		/// Description: Information type
		/// FieldName: IVTP
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Information type")]
		public string M3IVTP => GetString("IVTP");

		/// <summary>
		/// Description: Status - invoice
		/// FieldName: INST
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Status - invoice")]
		public string M3INST => GetString("INST");

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
		/// Description: Check number
		/// FieldName: CKNO
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Check number")]
		public string M3CKNO => GetString("CKNO");

		/// <summary>
		/// Description: Voucher text
		/// FieldName: VTXT
		/// FieldType: A
		/// Length: 40
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Voucher text")]
		public string M3VTXT => GetString("VTXT");

		/// <summary>
		/// Description: Invoice reference number
		/// FieldName: IRNO
		/// FieldType: A
		/// Length: 40
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Invoice reference number")]
		public string M3IRNO => GetString("IRNO");

		/// <summary>
		/// Description: Cash desk
		/// FieldName: CSHD
		/// FieldType: A
		/// Length: 5
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Cash desk")]
		public string M3CSHD => GetString("CSHD");

		/// <summary>
		/// Description: Cash desk transaction type
		/// FieldName: TRT6
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Cash desk transaction type")]
		public string M3TRT6 => GetString("TRT6");

		/// <summary>
		/// Description: 3rd-party ID
		/// FieldName: 3RDI
		/// FieldType: A
		/// Length: 15
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("3rd-party ID")]
		public string M33RDI => GetString("3RDI");

		/// <summary>
		/// Description: 3rd-party provider
		/// FieldName: 3RDP
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("3rd-party provider")]
		public string M33RDP => GetString("3RDP");

		/// <summary>
		/// Description: 3rd party transaction type
		/// FieldName: TRTY
		/// FieldType: A
		/// Length: 2
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("3rd party transaction type")]
		public string M3TRTY => GetString("TRTY");

		/// <summary>
		/// Description: Card type
		/// FieldName: CTPY
		/// FieldType: A
		/// Length: 20
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Card type")]
		public string M3CTPY => GetString("CTPY");

		/// <summary>
		/// Description: Card number
		/// FieldName: CANU
		/// FieldType: A
		/// Length: 19
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Card number")]
		public string M3CANU => GetString("CANU");

		/// <summary>
		/// Description: Name on card
		/// FieldName: NOCA
		/// FieldType: A
		/// Length: 36
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Name on card")]
		public string M3NOCA => GetString("NOCA");
	}
}
// EOF
