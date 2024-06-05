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

namespace M3H5Lib.Api.TXS140MI
{
	public partial class LstTotalPerInvResponse : M3BaseRecord 
	{

		/// <summary>
		/// Description: VAT run
		/// FieldName: VRUN
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("VAT run")]
		public string M3_VRUN => GetString("VRUN");

		/// <summary>
		/// Description: VAT registration number
		/// FieldName: YVRN
		/// FieldType: A
		/// Length: 16
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("VAT registration number")]
		public string M3_YVRN => GetString("YVRN");

		/// <summary>
		/// Description: From/to country
		/// FieldName: FTCO
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("From/to country")]
		public string M3_FTCO => GetString("FTCO");

		/// <summary>
		/// Description: Customer/supplier code
		/// FieldName: CVOP
		/// FieldType: N
		/// Length: 1
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Customer/supplier code")]
		public int? M3_CVOP => GetNullableInt("CVOP");

		/// <summary>
		/// Description: Customer/supplier
		/// FieldName: CUSP
		/// FieldType: A
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Customer/supplier")]
		public string M3_CUSP => GetString("CUSP");

		/// <summary>
		/// Description: Supplier invoice number
		/// FieldName: SINO
		/// FieldType: A
		/// Length: 24
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Supplier invoice number")]
		public string M3_SINO => GetString("SINO");

		/// <summary>
		/// Description: Invoice year
		/// FieldName: INYR
		/// FieldType: N
		/// Length: 4
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Invoice year")]
		public int? M3_INYR => GetNullableInt("INYR");

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
		/// Description: VAT date
		/// FieldName: VATD
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("VAT date")]
		public DateTime? M3_VATD => GetNullableDateTime("VATD");

		/// <summary>
		/// Description: Invoice date
		/// FieldName: IVDT
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Invoice date")]
		public DateTime? M3_IVDT => GetNullableDateTime("IVDT");

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
		/// Description: Voucher number series
		/// FieldName: VSER
		/// FieldType: A
		/// Length: 3
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Voucher number series")]
		public string M3_VSER => GetString("VSER");

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
		/// Description: Exchange rate
		/// FieldName: ARAT
		/// FieldType: N
		/// Length: 13
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Exchange rate")]
		public decimal? M3_ARAT => GetNullableDecimal("ARAT");

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
		/// Description: Recorded amount
		/// FieldName: ACAM
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Recorded amount")]
		public decimal? M3_ACAM => GetNullableDecimal("ACAM");

		/// <summary>
		/// Description: VAT
		/// FieldName: VTAM
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("VAT")]
		public decimal? M3_VTAM => GetNullableDecimal("VTAM");

		/// <summary>
		/// Description: Adjusted VAT amount
		/// FieldName: ADVT
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Adjusted VAT amount")]
		public decimal? M3_ADVT => GetNullableDecimal("ADVT");

		/// <summary>
		/// Description: Original - Supplier invoice number
		/// FieldName: SIN2
		/// FieldType: A
		/// Length: 24
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Original - Supplier invoice number")]
		public string M3_SIN2 => GetString("SIN2");

		/// <summary>
		/// Description: Original - Invoice year
		/// FieldName: OINY
		/// FieldType: N
		/// Length: 4
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Original - Invoice year")]
		public int? M3_OINY => GetNullableInt("OINY");

		/// <summary>
		/// Description: Original - Accounting date
		/// FieldName: OACD
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Original - Accounting date")]
		public DateTime? M3_OACD => GetNullableDateTime("OACD");

		/// <summary>
		/// Description: Original - Invoice date
		/// FieldName: OIVD
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Original - Invoice date")]
		public DateTime? M3_OIVD => GetNullableDateTime("OIVD");

		/// <summary>
		/// Description: Original - VAT date
		/// FieldName: OVTD
		/// FieldType: D
		/// Length: 10
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Original - VAT date")]
		public DateTime? M3_OVTD => GetNullableDateTime("OVTD");

		/// <summary>
		/// Description: Original VAT base amount - Recorded amount
		/// FieldName: OACA
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Original VAT base amount - Recorded amount")]
		public decimal? M3_OACA => GetNullableDecimal("OACA");

		/// <summary>
		/// Description: Original VATamount - Recorded amount
		/// FieldName: OVTA
		/// FieldType: N
		/// Length: 17
		/// Nullabe: Y
		/// </summary>
		[JsonIgnore]
		[Description("Original VATamount - Recorded amount")]
		public decimal? M3_OVTA => GetNullableDecimal("OVTA");
	}
}
// EOF
